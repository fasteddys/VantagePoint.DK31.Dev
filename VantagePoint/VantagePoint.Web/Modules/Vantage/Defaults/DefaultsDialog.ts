
namespace VantagePoint.Vantage {

    @Serenity.Decorators.registerClass()
    export class DefaultsDialog extends Serenity.EntityDialog<DefaultsRow, any> {
        protected getFormKey() { return DefaultsForm.formKey; }
        protected getIdProperty() { return DefaultsRow.idProperty; }
        protected getLocalTextPrefix() { return DefaultsRow.localTextPrefix; }
        protected getNameProperty() { return DefaultsRow.nameProperty; }
        protected getService() { return DefaultsService.baseUrl; }
        protected getDeletePermission() { return DefaultsRow.deletePermission; }
        protected getInsertPermission() { return DefaultsRow.insertPermission; }
        protected getUpdatePermission() { return DefaultsRow.updatePermission; }

        protected form = new DefaultsForm(this.idPrefix);

    }
}