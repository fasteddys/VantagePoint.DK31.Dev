/// <reference path="../../../Common/Helpers/GridEditorBase.ts" />

namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    export class PickerOrderDetailsEditor extends Common.GridEditorBase<Northwind.OrderDetailRow> {
        protected getColumnsKey() { return "Northwind.OrderDetail"; }
        protected getDialogType() { return Northwind.OrderDetailDialog; }
        protected getLocalTextPrefix() { return Northwind.OrderDetailRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        validateEntity(row, id) {
            row.ProductID = Q.toId(row.ProductID);

            var sameProduct = Q.tryFirst(this.view.getItems(), x => x.ProductID === row.ProductID);
            if (sameProduct && this.id(sameProduct) !== id) {
                Q.alert('This product is already in order details!');
                return false;
            }

            row.ProductName = Northwind.ProductRow.getLookup().itemById[row.ProductID].ProductName;
            row.LineTotal = (row.Quantity || 0) * (row.UnitPrice || 0) - (row.Discount || 0);
            return true;
        }

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.push({
                title: "Pick Products",
                cssClass: "add-button",
                onClick: () => {
                    var dlg = new ProductPickerDialog({
                        hideProducts: this.view.getItems().map(x => x.ProductID)
                    });
                    dlg.onSuccess = (selected) => {
                        // filter already existing products
                        selected = selected.filter(x => !Q.any(this.view.getItems(), y => y.ProductID == x.ProductID));

                        for (var sel of selected) {
                            var item = <Northwind.OrderDetailRow>{
                                ProductID: sel.ProductID,
                                ProductName: sel.ProductName,
                                UnitPrice: sel.UnitPrice,
                                Quantity: 1,
                                Discount: 0,
                                LineTotal: sel.UnitPrice
                            };

                            var id = this.getNextId();
                            item[this.getIdProperty()] = id;
                            this.view.addItem(item);
                        }

                        return true;
                    };
                    dlg.dialogOpen();
                }
            });

            return buttons;
        }
    }
}