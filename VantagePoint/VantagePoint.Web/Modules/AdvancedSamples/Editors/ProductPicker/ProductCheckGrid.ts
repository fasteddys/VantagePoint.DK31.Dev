/// <reference path="../../../Northwind/Product/ProductGrid.ts" />

namespace VantagePoint.AdvancedSamples {

    export interface ProductPickerOptions {
        hideProducts?: number[];
    }

    @Serenity.Decorators.registerClass()
    export class ProductCheckGrid extends Serenity.EntityGrid<Northwind.ProductRow, ProductPickerOptions> {

        protected getColumnsKey() { return "Northwind.Product"; }
        protected getDialogType() { return <any>Northwind.ProductDialog; }
        protected getIdProperty() { return Northwind.ProductRow.idProperty; }
        protected getLocalTextPrefix() { return Northwind.ProductRow.localTextPrefix; }
        protected getService() { return Northwind.ProductService.baseUrl; }

        private rowSelection: Serenity.GridRowSelectionMixin;

        constructor(container: JQuery, options: ProductPickerOptions) {
            super(container, options);

            this.rowSelection = new Serenity.GridRowSelectionMixin(this);
        }

        protected getColumns() {
            var columns = super.getColumns();
            columns.splice(0, 0, Serenity.GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
            return columns;
        }

        protected usePager() {
            return false;
        }

        protected getInitialTitle() {
            return null;
        }

        protected getButtons() {
            var buttons = super.getButtons();
            buttons = buttons.filter(x => x.cssClass != 'add-button');
            return buttons;
        }

        get selectedItems() {
            return this.rowSelection.getSelectedAsInt32().map(x => this.view.getItemById(x));
        }

        onViewSubmit() {
            if (!super.onViewSubmit())
                return false;

            var request = this.view.params as Serenity.ListRequest;
            if (this.options.hideProducts && this.options.hideProducts.length)
                request.Criteria = Serenity.Criteria.and(request.Criteria,
                    [[Northwind.ProductRow.Fields.ProductID], 'not in', [this.options.hideProducts]]);

            return true;
        }
    }
}