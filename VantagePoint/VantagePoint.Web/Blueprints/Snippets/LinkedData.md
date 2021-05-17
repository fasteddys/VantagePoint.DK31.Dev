
This code sample shows how to display linked-data in a form after a selection has been made (look-up)
The following snippet comes from the OrderLine Dialog form. This is the most common scenario for this kind of functionality

Steps: 
(1) Invoking a private method that encapsulates data display. In a next edition of this SDK
 we can include this as a given behaviour that depends on the "populateLinkedDetails" method

(2) Displaying Linked Data based on the lookup field

    <code>

        // (1) Invoking the populate method 
        protected afterLoadEntity() {
            super.afterLoadEntity();

            this.populateLinkedDetails();
        }

        // (2) Displaying Linked Data <Change-instructions>: 
        // [ProductId] = LookUp Field As In xyzRow.cs
        // [productId] = Temp Variable for Null Check
        // [SalesLineCost] = Fields to be Populated As In xyzRow.cs (You can include as many as you need)

        private populateLinkedDetails() {
            this.form.ProductId.changeSelect2(e => {
                var productId = Q.toId(this.form.ProductId.value);
                if (productId != null) {
                    this.form.SalesLineCost.value = ProductRow.getLookup().itemById[productId].ProductCost;
                }
            });
        }

    </code>

Sign-off:
Jan-6/2021: emmanuel.sosa@planetaweb.do

