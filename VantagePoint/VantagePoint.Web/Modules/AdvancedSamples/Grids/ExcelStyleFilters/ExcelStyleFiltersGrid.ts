/// <reference path="../../../Northwind/Order/OrderGrid.ts" />

namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    export class ExcelStyleFiltersGrid extends Northwind.OrderGrid {

        constructor(container: JQuery) {
            super(container);

            new Serenity.HeaderFiltersMixin({
                grid: this
            });
        }
    }
}