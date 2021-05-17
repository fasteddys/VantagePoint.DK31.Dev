namespace VantagePoint.AdvancedSamples {
    export interface InlineButtonsForm {
        SomeTextInput: Serenity.StringEditor;
        InputWithButton: InlineButtonsEditor;
        ExternallyCreatedButton: Serenity.IntegerEditor;
    }

    export class InlineButtonsForm extends Serenity.PrefixedContext {
        static formKey = 'AdvancedSamples.InlineButtons';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!InlineButtonsForm.init)  {
                InlineButtonsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = InlineButtonsEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(InlineButtonsForm, [
                    'SomeTextInput', w0,
                    'InputWithButton', w1,
                    'ExternallyCreatedButton', w2
                ]);
            }
        }
    }
}
