
This code sample shows how to change (add/remove) toolbar buttons
The following snippet comes from the ProductClass Grid-View. The same technique applies for Dialog forms


    <code>

        protected getButtons() {
            // Preserving default buttons
            var buttons = super.getButtons();

            // New custom button
            buttons.push({
                title: 'New w/Predef Data',
                cssClass: 'add-button',
                onClick: () => {
                    // using EditItem method as a shortcut to create a new ProductClass dialog,
                    // bind to its events, load our order row, and open dialog
                    this.editItem(<Vantage.ProductClassRow>{
                        ProductClassName: 'CLASS-99',
                        ProductTypeId: Vantage.ProductTypeRow.getLookup().items
                            .filter(x => x.ProductTypeName === 'Bundle')[0].ProductTypeId,
                        ProductClassIsactive: true
                    });
                }
            });

            // New custom button
            buttons.push({
                title: 'Insert: New Type',
                cssClass: 'new-button',
                onClick: () => {

                    Q.confirm("Do you want to proceed?",
                        () => { this.goInsert() },
                        {
                            onNo: () => { Q.notifyInfo("You clicked NO. Why?"); },
                            onCancel: () => { Q.notifyError("You clicked X. Operation is cancelled. Will try again?"); },
                            title: "This is a confirmation Title"
                        });
                }
            });

            // New button: PDF Export
            buttons.push(PrototypeB.Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit()
            }));

            // New button: Excel Export
            buttons.push(PrototypeB.Common.ExcelExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                service: 'Vantage/ProductClass/ListExcel',
                separator: true
            }));

            // Removing default "Add" button
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);


            return buttons;
        }


    </code>

Sign-off:  
Jan-7/2021: emmanuel.sosa@planetaweb.do 

