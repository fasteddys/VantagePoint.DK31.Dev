namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerClass()
    export class ProductPickerDialog extends Serenity.TemplatedDialog<ProductPickerOptions> {

        private checkGrid: ProductCheckGrid;

        constructor(opt: ProductPickerOptions) {
            super(opt);

            this.checkGrid = new ProductCheckGrid(this.byId("CheckGrid"), opt);
            this.dialogTitle = "Select Products";
        }

        protected getTemplate() {
            return `<div id="~_CheckGrid"></div>`;
        }

        protected getDialogButtons() {
            return [
                {
                    text: Q.text("Dialogs.OkButton"),
                    click: () => {
                        var selected = this.checkGrid.selectedItems;
                        if (!selected.length) {
                            Q.notifyWarning("Please select some products!");
                            return;
                        }

                        if (!this.onSuccess || this.onSuccess(selected))
                            this.dialogClose();
                    }
                },
                {
                    text: Q.text("Dialogs.CancelButton"),
                    click: () => {
                        this.dialogClose();
                    }
                }
            ];
        }

        get selectedItems() {
            return this.checkGrid.selectedItems;
        }

        public onSuccess: (selected: Northwind.ProductRow[]) => boolean;
    }
}