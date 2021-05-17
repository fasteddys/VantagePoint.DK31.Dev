namespace VantagePoint.Organization {
    export interface ContactForm {
        Title: Serenity.StringEditor;
        FirstName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        IdentityNo: Serenity.StringEditor;
        UserId: Serenity.LookupEditor;
    }

    export class ContactForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.Contact';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ContactForm.init)  {
                ContactForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EmailEditor;
                var w2 = s.LookupEditor;

                Q.initFormType(ContactForm, [
                    'Title', w0,
                    'FirstName', w0,
                    'LastName', w0,
                    'Email', w1,
                    'IdentityNo', w0,
                    'UserId', w2
                ]);
            }
        }
    }
}
