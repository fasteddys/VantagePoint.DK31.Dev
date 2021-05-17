/// <reference path="../../../Northwind/Customer/CustomerOrdersGrid.ts" />

namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass("VantagePoint.AdvancedSamples.SplitDetailGrid")
    export class SplitDetailGrid extends Northwind.CustomerOrdersGrid {
        constructor(container: JQuery) {
            super(container);
        }

        protected usePager() {
            return false;
        }
    }
}