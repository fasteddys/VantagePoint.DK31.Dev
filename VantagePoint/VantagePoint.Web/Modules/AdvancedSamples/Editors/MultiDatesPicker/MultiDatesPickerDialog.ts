namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class MultiDatesPickerDialog extends Serenity.PropertyDialog<any, any> {
        protected getFormKey() { return MultiDatesPickerForm.formKey; }

        protected form = new MultiDatesPickerForm(this.idPrefix);

        constructor() {
            super();

            this.dialogTitle = "Multi Dates Picker Sample";

        }
    }
}