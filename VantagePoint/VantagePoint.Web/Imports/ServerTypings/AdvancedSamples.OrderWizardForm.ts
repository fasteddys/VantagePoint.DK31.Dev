namespace VantagePoint.AdvancedSamples {
    export interface OrderWizardForm {
        WelcomeMessage: StaticTextBlock;
        CustomerType: Serenity.RadioButtonEditor;
        ExistingCustomerID: Northwind.CustomerEditor;
        CustomerID: Serenity.StringEditor;
        CompanyName: Serenity.StringEditor;
        ContactName: Serenity.StringEditor;
        ContactTitle: Serenity.StringEditor;
        Representatives: Serenity.LookupEditor;
        Address: Serenity.StringEditor;
        Country: Serenity.LookupEditor;
        City: Serenity.LookupEditor;
        Region: Serenity.StringEditor;
        PostalCode: Serenity.StringEditor;
        Phone: Serenity.StringEditor;
        Fax: Serenity.StringEditor;
        OrderDate: Serenity.DateEditor;
        RequiredDate: Serenity.DateEditor;
        EmployeeID: Serenity.LookupEditor;
        DetailList: Northwind.OrderDetailsEditor;
        ShipName: Serenity.StringEditor;
        ShipAddress: Serenity.StringEditor;
        ShipCity: Serenity.StringEditor;
        ShipRegion: Serenity.StringEditor;
        ShipPostalCode: Serenity.StringEditor;
        ShipCountry: Serenity.StringEditor;
    }

    export class OrderWizardForm extends Serenity.PrefixedContext {
        static formKey = 'AdvancedSamples.OrderWizard';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderWizardForm.init)  {
                OrderWizardForm.init = true;

                var s = Serenity;
                var w0 = StaticTextBlock;
                var w1 = s.RadioButtonEditor;
                var w2 = Northwind.CustomerEditor;
                var w3 = s.StringEditor;
                var w4 = s.LookupEditor;
                var w5 = s.DateEditor;
                var w6 = Northwind.OrderDetailsEditor;

                Q.initFormType(OrderWizardForm, [
                    'WelcomeMessage', w0,
                    'CustomerType', w1,
                    'ExistingCustomerID', w2,
                    'CustomerID', w3,
                    'CompanyName', w3,
                    'ContactName', w3,
                    'ContactTitle', w3,
                    'Representatives', w4,
                    'Address', w3,
                    'Country', w4,
                    'City', w4,
                    'Region', w3,
                    'PostalCode', w3,
                    'Phone', w3,
                    'Fax', w3,
                    'OrderDate', w5,
                    'RequiredDate', w5,
                    'EmployeeID', w4,
                    'DetailList', w6,
                    'ShipName', w3,
                    'ShipAddress', w3,
                    'ShipCity', w3,
                    'ShipRegion', w3,
                    'ShipPostalCode', w3,
                    'ShipCountry', w3
                ]);
            }
        }
    }
}
