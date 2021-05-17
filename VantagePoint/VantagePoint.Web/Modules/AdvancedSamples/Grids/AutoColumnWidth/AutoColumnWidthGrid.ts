/// <reference path="../../../Northwind/Order/OrderGrid.ts" />

namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    export class AutoColumnWidthGrid extends Northwind.OrderGrid {

        protected createSlickGrid() {
            this.slickGrid = super.createSlickGrid();

            new Serenity.AutoColumnWidthMixin({
                grid: this
            });

            return this.slickGrid;
        }

        /** We change number of rows for demonstration purposes, its not normally needed */
        protected getViewOptions() {
            var opt = super.getViewOptions();
            opt.rowsPerPage = 20;
            return opt;
        }
    }
}