namespace VantagePoint.Administration {
    export interface TenantForm {
        Name: Serenity.StringEditor;
        Tier: Serenity.StringEditor;
        Domain: Serenity.StringEditor;
        Created: Serenity.DateEditor;
        Modified: Serenity.DateEditor;
    }

    export class TenantForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.Tenant';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TenantForm.init)  {
                TenantForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;

                Q.initFormType(TenantForm, [
                    'Name', w0,
                    'Tier', w0,
                    'Domain', w0,
                    'Created', w1,
                    'Modified', w1
                ]);
            }
        }
    }
}
