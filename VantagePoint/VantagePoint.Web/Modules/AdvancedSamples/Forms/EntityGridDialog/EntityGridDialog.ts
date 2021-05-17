
namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    export class EntityGridDialog extends Serenity.EntityGridDialog<Northwind.SupplierRow, any> {
        protected getColumnsKey() { return "Northwind.Supplier"; }
        protected getFormKey() { return Northwind.SupplierForm.formKey; }
        protected getIdProperty() { return Northwind.SupplierRow.idProperty; }
        protected getLocalTextPrefix() { return Northwind.SupplierRow.localTextPrefix; }
        protected getNameProperty() { return Northwind.SupplierRow.nameProperty; }
        protected getService() { return Northwind.SupplierService.baseUrl; }

        protected form = new Northwind.SupplierForm(this.idPrefix);

        constructor(container: JQuery) {
            super(container);
        }

        protected autoSaveOnSwitch() {
            return Serenity.AutoSaveOption.Auto;
        }

        protected autoSaveOnClose() {
            return Serenity.AutoSaveOption.Confirm;
        }
    }
}