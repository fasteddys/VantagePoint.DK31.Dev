namespace VantagePoint.Northwind {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class CustomerGrid extends Serenity.EntityGrid<CustomerRow, any> {
        protected getColumnsKey() { return "Northwind.Customer"; }
        protected getDialogType() { return <any>CustomerDialog; }
        protected getIdProperty() { return CustomerRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerRow.localTextPrefix; }
        protected getService() { return CustomerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected createToolbarExtensions() {
            super.createToolbarExtensions();

            var self = this;

            new Serenity.FavoriteViewsMixin({
                grid: this
            });

            var editItem = this.editItem.bind(this);

            new Serenity.CardViewMixin({
                grid: this,
                renderItem: (item, index) => React.createElement(CustomerCard, {
                    item: item,
                    editItem: editItem
                })
            });
        }

        getButtons() {
            var buttons = super.getButtons();

            buttons.push(VantagePoint.Common.ExcelExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                service: 'Northwind/Customer/ListExcel',
                separator: true
            }));

            buttons.push(VantagePoint.Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit()
            }));

            return buttons;
        }

        protected getIncludeColumns(include) {
            super.getIncludeColumns(include);

            // these columns are used by card view, so even if they
            // are hidden in grid view, we should make sure they
            // are loaded from server
            include[CustomerRow.Fields.CustomerID] = true;
            include[CustomerRow.Fields.CompanyName] = true;
            include[CustomerRow.Fields.ContactName] = true;
            include[CustomerRow.Fields.ContactTitle] = true;
            include[CustomerRow.Fields.Country] = true;
            include[CustomerRow.Fields.City] = true;
        }

        protected getPersistanceStorage(): Serenity.SettingStorage {
            return new Common.UserPreferenceStorage();
        }
    }
}