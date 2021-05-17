namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    export class CustomizableSummariesGrid extends Serenity.EntityGrid<Northwind.ProductRow, any> {
        protected getColumnsKey() { return "Northwind.Product"; }
        protected getDialogType() { return <any>Northwind.ProductDialog; }
        protected getIdProperty() { return Northwind.ProductRow.idProperty; }
        protected getLocalTextPrefix() { return Northwind.ProductRow.localTextPrefix; }
        protected getService() { return Northwind.ProductService.baseUrl; }

        protected createToolbarExtensions() {
            super.createToolbarExtensions();

            this.slickGrid.registerPlugin(new Slick.Data.GroupItemMetadataProvider());
            
            new Serenity.DraggableGroupingMixin({
                grid: this
            });

            new Serenity.CustomSummaryMixin({
                grid: this
            });
        }

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            opt.groupingPanel = true;
            opt.showFooterRow = true;
            return opt;
        }
    }
}