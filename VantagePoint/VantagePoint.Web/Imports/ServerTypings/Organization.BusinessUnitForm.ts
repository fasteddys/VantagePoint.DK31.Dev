namespace VantagePoint.Organization {
    export interface BusinessUnitForm {
        Name: Serenity.StringEditor;
        ParentUnitId: BusinessUnitEditor;
    }

    export class BusinessUnitForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.BusinessUnit';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BusinessUnitForm.init)  {
                BusinessUnitForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = BusinessUnitEditor;

                Q.initFormType(BusinessUnitForm, [
                    'Name', w0,
                    'ParentUnitId', w1
                ]);
            }
        }
    }
}
