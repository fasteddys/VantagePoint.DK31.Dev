﻿namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    export class DataExplorerGrid extends Serenity.EntityGrid<any, any> {

        protected getDialogType() { return null; }
        protected getIdProperty() { return "__id"; }
        protected getInitialTitle() { return "Data Explorer"; }
        protected getLocalTextPrefix() { return ""; }
        protected getService() { return DataExplorerService.baseUrl; }

        private connection: DataConnectionEditor;
        private table: DataTableEditor;

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            return [];
        }

        protected createToolbarExtensions() {
            super.createToolbarExtensions();

            this.connection = Serenity.Widget.create({
                type: DataConnectionEditor,
                element: e => e.attr("placeholder", "--select connection--")
                    .attr("id", "ConnectionKey")
                    .appendTo(this.toolbar.element)
            });

            this.table = Serenity.Widget.create({
                type: DataTableEditor,
                options: {
                    cascadeFrom: "ConnectionKey",
                    cascadeField: "ConnectionKey"
                },
                element: e => e.attr("placeholder", "--select table--")
                    .attr("id", "Table")
                    .appendTo(this.toolbar.element)
            });

            this.table.change(e => {
                var table = this.table.value;
                this.view.setItems([], true);
                this.slickGrid.setColumns([]);

                if (Q.isEmptyOrNull(table))
                    return;

                DataExplorerService.ListColumns({
                    ConnectionKey: this.connection.value,
                    TableName: table
                }, response => {
                    this.slickGrid.setColumns(this.postProcessColumns(this.propertyItemsToSlickColumns(response.Entities)));
                    this.refresh();
                });
            });
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !Q.isEmptyOrNull(this.table.value);
        }

        protected onViewSubmit() {
            if (!super.onViewSubmit())
                return false;

            (this.view.params as DataExplorerListRequest).ConnectionKey = this.connection.value;
            (this.view.params as DataExplorerListRequest).TableName = this.table.value;

            return true;
        }

        protected onViewProcessData(response) {
            response = super.onViewProcessData(response);
            for (var i = 0; i < response.Entities.length; i++) {
                response.Entities[i].__id = i + 1;
            }
            return response;
        }
    }
}