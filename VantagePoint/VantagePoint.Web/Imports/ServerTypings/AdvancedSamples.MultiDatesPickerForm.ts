namespace VantagePoint.AdvancedSamples {
    export interface MultiDatesPickerForm {
        MultipleDates: MultiDatesPickerEditor;
        Max3Dates: MultiDatesPickerEditor;
    }

    export class MultiDatesPickerForm extends Serenity.PrefixedContext {
        static formKey = 'AdvancedSamples.MultiDatesPicker';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MultiDatesPickerForm.init)  {
                MultiDatesPickerForm.init = true;

                var s = Serenity;
                var w0 = MultiDatesPickerEditor;

                Q.initFormType(MultiDatesPickerForm, [
                    'MultipleDates', w0,
                    'Max3Dates', w0
                ]);
            }
        }
    }
}

