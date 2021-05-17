/// <reference path="../../../Northwind/Order/OrderGrid.ts" />

namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class PickerOrderGrid extends Northwind.OrderGrid {
        protected getDialogType() { return <any>PickerOrderDialog; }
    }
}
