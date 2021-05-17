
This code sample shows several variants of Extension Methods that extend the repository class
The snippets below comes from the ProductRepository but exemplify the general guidelines 


    <code>

        //PWK: Extension Method for Product-retrieval on server-side
        public MyRow ItemById(int id)
        {
            MyRow result = null;

            using (IDbConnection connection = SqlConnections.NewFor<MyRow>())
            {
                result = connection.Single<MyRow>(q =>
                {
                    q.SelectTableFields();
                    q.Where(new Criteria(MyRow.Fields.ProductId) == id);
                });
            }

            return result;
        }

    </code>

    <code>

        //PWK: Extension Method for Product-retrieval on server-side
        public MyRow ItemByCode(string code)
        {
            MyRow result = null;

            using (IDbConnection connection = SqlConnections.NewFor<MyRow>())
            {
                result = connection.Single<MyRow>(q =>
                {
                    q.SelectTableFields();
                    q.Where(new Criteria(MyRow.Fields.ProductCode) == code);
                });
            }

            return result;
        }
    </code>

    <code>

        //PWK: Retrieve all productsList. This method is called from Checkout Page
        public List<MyRow> Items()
        {
            List<MyRow> result = null;

            using (IDbConnection connection = SqlConnections.NewFor<MyRow>())
            {
                result = connection.List<MyRow>(q =>
                {
                    q.SelectTableFields();
                    q.Where(MyRow.Fields.ProductId <= MyRow.Fields.Count);
                });
            }

            return result;
        }

    </code>

    <code>

        //PWK: Extension Method to Return Quantity Available in Stock
        public int GetQtyAvailable(int id)
        {
            MyRow result = null;

            using (IDbConnection connection = SqlConnections.NewFor<MyRow>())
            {
                result = connection.Single<MyRow>(q =>
                {
                    q.SelectTableFields();
                    q.Where(new Criteria(MyRow.Fields.ProductId) == id);
                });
            }
            int qty = result.ProductMaxstock ?? default;

            return qty;
        }
    </code>

    <code>

        //PWK: Extension Method to Disable Products Selectively
        public bool DisableById(int id)
        {
            MyRow result = null;

            using (IDbConnection connection = SqlConnections.NewFor<MyRow>())
            {
                result = connection.Single<MyRow>(q =>
                {
                    q.SelectTableFields();
                    q.Where(new Criteria(MyRow.Fields.ProductId) == id);
                });
                result.ProductIstaxable = false;

                try
                {
                    connection.UpdateById(result);
                }
                catch
                {
                    return false;
                }

            }

            return true;
        }

    </code>



Sign-off:  
Jan-7/2021: emmanuel.sosa@planetaweb.do

