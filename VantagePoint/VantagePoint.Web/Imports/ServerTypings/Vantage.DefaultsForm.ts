namespace VantagePoint.Vantage {
    export interface DefaultsForm {
        Name: Serenity.StringEditor;
        Datatype: Serenity.StringEditor;
        Value: Serenity.StringEditor;
        Class: Serenity.StringEditor;
        Scope: Serenity.StringEditor;
    }

    export class DefaultsForm extends Serenity.PrefixedContext {
        static formKey = 'Vantage.Defaults';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!DefaultsForm.init)  {
                DefaultsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(DefaultsForm, [
                    'Name', w0,
                    'Datatype', w0,
                    'Value', w0,
                    'Class', w0,
                    'Scope', w0
                ]);
            }
        }
    }
}
