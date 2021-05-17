namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    export class InlineButtonsDialog extends Serenity.PropertyDialog<any, any> {
        protected getFormKey() { return InlineButtonsForm.formKey; }

        protected form = new InlineButtonsForm(this.idPrefix);

        constructor() {
            super();

            this.dialogTitle = "Editors with inline actions";

            $('<a class="inplace-button inplace-action3"><b><i class="fa fa-magic text-red"></i></b></a>')
                .attr("title", "Do Some Action 3")
                .insertAfter(this.form.ExternallyCreatedButton.element)
                .click(e => {
                    Q.notifyWarning("Action 3 with magic wand clicked!");
                });
        }

        protected getDialogOptions() {
            var opt = super.getDialogOptions();
            opt.width = 650;
            return opt;
        }
    }
}