namespace VantagePoint.AdvancedSamples {

    /**
     * An order wizard that extends Serenity.WizardDialog, available only in premium version
     */
    @Serenity.Decorators.panel()
    export class OrderWizard extends Serenity.WizardDialog<Northwind.OrderRow, any> {
        protected getFormKey() { return OrderWizardForm.formKey; }
        protected getLocalTextPrefix() { return Northwind.OrderRow.localTextPrefix; }

        protected form = new OrderWizardForm(this.idPrefix);

        constructor() {
            super();

            this.dialogTitle = "Order Wizard";

            // auto enable / disable customer selection dropdown when radio buttons change
            this.form.CustomerType.change(e => {

                var isNewCustomer = this.isNewCustomer;
                Serenity.EditorUtils.setReadOnly(this.form.ExistingCustomerID, isNewCustomer);
                Serenity.EditorUtils.setRequired(this.form.ExistingCustomerID, !isNewCustomer);
                // open dropdown when existing customer radio button is clicked
                if (!isNewCustomer)
                    setTimeout(() => {
                        (this.form.ExistingCustomerID.element as any).select2('open');
                    }, 0);
            });
        }

        private get isNewCustomer() {
            return this.form.CustomerType.value != OrderWizardCustomerType.Existing.toString();
        }

        /**
         * next method is called when user tries to go forward
         * @param toStep the step user is trying to move to, usually one step ahead
         */
        protected next(toStep: number) {
            if (toStep == OrderWizardSteps.CustomerDetails) {
                // if user is trying to move forward to custom details step and 
                // we are using an existing customer, skip the customer details step
                if (!this.isNewCustomer)
                    toStep = OrderWizardSteps.OrderInfo;
            }
            else if (this.step == OrderWizardSteps.OrderDetails) {
                // validate that details list not empty before moving away from details step
                if (!this.form.DetailList.value.length) {
                    Q.notifyWarning("Please enter at least one detail!");
                    return;
                }
            }
            else if (toStep == OrderWizardSteps.OrderDetails) {
                // when moving into details step, if details are empty, auto open add detail dialog
                if (!this.form.DetailList.value.length) {
                    this.step = toStep;
                    this.form.DetailList.element.find('.add-button').click();
                    return;
                }
            }

            // you should call setStep after validating / modifying target step (toStep)
            this.step = toStep;
        }

        /**
         * back method is called when user tries to go backward
         * @param toStep the step user is trying to move to, usually one step back but can also be multiple
         */
        protected back(toStep: number) {
            if (toStep == OrderWizardSteps.CustomerDetails &&
                !this.isNewCustomer) {
                // if using existing customer, skip back to first step
                toStep = OrderWizardSteps.CustomerSelection;
            }

            this.step = toStep;
        }

        /**
         * called to reset the form, and go back to first step
         */
        protected reset() {
            super.reset();

            // we need to clear readonly / required state of existing customer selection
            // as base reset method won't reset its state, only form values
            Serenity.EditorUtils.setReadOnly(this.form.ExistingCustomerID, true);
            Serenity.EditorUtils.setRequired(this.form.ExistingCustomerID, false);
        }

        /**
         * is called when user clicks the Finish button (next button on last step)
         */
        protected finish() {
            if (this.isNewCustomer) {
                // if new customer type, first create customer by getting properties
                // from only the CustomerDetails step
                var customer = this.getSaveEntity([OrderWizardSteps.CustomerDetails]) as Northwind.CustomerRow;

                Northwind.CustomerService.Create({
                    Entity: customer
                }, response => {
                    this.saveOrder(customer.CustomerID);
                });
            } else {
                this.saveOrder(this.form.ExistingCustomerID.value);
            }
        }

        /**
         * will be called by finish method to save order with an existing customer ID,
         * or a newly created one 
         * @param customerID
         */
        protected saveOrder(customerID: string) {
            var order = this.getSaveEntity([
                OrderWizardSteps.OrderInfo,
                OrderWizardSteps.OrderDetails,
                OrderWizardSteps.Shipping]);
            order.CustomerID = customerID;

            Northwind.OrderService.Create({
                Entity: order
            }, response => {
                Q.confirm('New order with ID: ' + response.EntityId +
                    ' is created. Would you like to add another one?', () => {
                        this.reset();
                    }, {
                        onNo: () => this.dialogClose(),
                        onCancel: () => this.dialogClose(),
                        onClose: () => this.dialogClose()
                    });
            });
        }
    }

    // we define this enum to avoid magic step numbers
    export enum OrderWizardSteps {
        CustomerSelection = 1,
        CustomerDetails = 2,
        OrderInfo = 3,
        OrderDetails = 4,
        Shipping = 5
    }
}