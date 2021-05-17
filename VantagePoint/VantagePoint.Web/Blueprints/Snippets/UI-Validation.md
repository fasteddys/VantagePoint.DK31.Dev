
This code sample shows how to perform UI Validation in a form after an input has been given
The following snippet comes from the OrderLine Dialog form


    <code>

    constructor() {
            super();

            this.form = new SalesLineForm(this.idPrefix);

            //PWK: UI Validation: Quantity on Hand
            this.form.SalesLineQty.addValidationRule(this.uniqueName, e => {
                var productId = Q.toId(this.form.ProductId.value);
                var productQty = this.form.SalesLineQty.value;
                var qtyOnHand = ProductRow.getLookup().itemById[productId].ProductMaxstock;

                if (qtyOnHand < productQty) {
                    return "There is not enough inventory to fulfill this Order!";
                }
            });
        }
       

    </code>

Sign-off:  
Jan-7/2021: emmanuel.sosa@planetaweb.do

