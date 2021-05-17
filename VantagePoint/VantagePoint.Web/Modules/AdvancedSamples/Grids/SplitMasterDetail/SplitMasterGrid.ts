/// <reference path="../../../Northwind/Customer/CustomerGrid.ts" />

namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass("VantagePoint.AdvancedSamples.SplitMasterGrid")
    export class SplitMasterGrid extends Northwind.CustomerGrid {

        constructor(container: JQuery) {
            super(container);
        }

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            opt.enableCellNavigation = true;
            return opt;
        }

        protected createSlickGrid() {
            var grid = super.createSlickGrid();
            grid.setSelectionModel(new Slick.RowSelectionModel());
            return grid;
        }
    }
}