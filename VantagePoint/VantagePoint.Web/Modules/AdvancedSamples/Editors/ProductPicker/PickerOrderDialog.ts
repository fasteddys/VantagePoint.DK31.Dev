namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    export class PickerOrderDialog extends Serenity.EntityDialog<Northwind.OrderRow, any> {
        protected getFormKey() { return PickerOrderForm.formKey; }
        protected getIdProperty() { return Northwind.OrderRow.idProperty; }
        protected getLocalTextPrefix() { return Northwind.OrderRow.localTextPrefix; }
        protected getNameProperty() { return Northwind.OrderRow.nameProperty; }
        protected getService() { return Northwind.OrderService.baseUrl; }

        //protected form = new PickerOrderForm(this.idPrefix);

        constructor() {
            super();
        }
    }
}