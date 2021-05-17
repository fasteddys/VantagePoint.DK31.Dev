
namespace VantagePoint.AdvancedSamples {

    export interface MultiDatesPickerEditorOptions {
        maxPicks: number;
        minDate: string;
        maxDate: string;
    }

    /**
     * This is a date editor with multiple date selection
     */
    @Serenity.Decorators.registerEditor("VantagePoint.AdvancedSamples.MultiDatesPickerEditor")
    export class MultiDatesPickerEditor extends Serenity.StringEditor {

        constructor(container: JQuery, options?: MultiDatesPickerEditorOptions) {
            super(container);

            container.multiDatesPicker({
                showOn: 'button',
                maxPicks: options && options.maxPicks,
                maxDate: options && Q.formatDate(options.maxDate),
                minDate: options && Q.formatDate(options.minDate),
                beforeShow: (input, inst: any) => {
                    var value = $(input).val();
                    $(input).multiDatesPicker('resetDates');
                    $(input).val(value);
                    $(input).multiDatesPicker('value', value);
                    return null;
                }
            });

        }

        @Serenity.Decorators.option()
        get maxPicks(): number {
            return this.element.datepicker('option', 'maxPicks');
        }

        set maxPicks(value: number) {
            this.element.datepicker('option', 'maxPicks', value);
        }

        @Serenity.Decorators.option()
        get minDate(): string {
            return this.element.datepicker('option', 'minDate');
        }

        set minDate(value: string) {
            this.element.datepicker('option', 'minDate', Q.formatDate(value));
        }

        @Serenity.Decorators.option()
        get maxDate(): string {
            return this.element.datepicker('option', 'maxDate');
        }

        set maxDate(value: string) {
            this.element.datepicker('option', 'maxDate', Q.formatDate(value));
        }

        destroy() {
            this.element.multiDatesPicker('destroy');

            super.destroy();
        }
    }
}

declare namespace JQueryUI {
    interface MultiDatesPickerOptions extends JQueryUI.DatepickerOptions {
        format?: string;
        addDates?: string | Date | (string | Date)[];
        addDisabledDates?: string | Date | (string | Date)[];
        separator?: string;
        mode?: 'normal' | 'daysRange';
        maxPicks?: number;
        pickableRange?: number;
        adjustRangeToDisabled?: boolean;
        autoselectRange?: number[];
    }
}

declare interface JQuery {
    multiDatesPicker(options?: JQueryUI.MultiDatesPickerOptions): string;
    multiDatesPicker(method: 'addDates', dates: Date | string | (Date | string)[], type?: 'picked' | 'disabled');
    multiDatesPicker(method: 'compareDates', date1: Date | string, date2: Date | string): number;
    multiDatesPicker(method: 'gotDate', date: Date | string, type?: 'picked' | 'disabled'): number;
    multiDatesPicker(method: 'removeIndexes', indexes: number | number[], type?: 'picked' | 'disabled');
    multiDatesPicker(method: 'removeDates', dates: Date | string | (Date | string)[], type?: 'picked' | 'disabled');
    multiDatesPicker(method: 'resetDates', type?: 'picked' | 'disabled');
    multiDatesPicker(method: 'toggleDate', dates: Date | string | (Date | string)[], type?: 'picked' | 'disabled');
    multiDatesPicker(method: 'getDates', format?: 'string' | 'object', type?: 'picked' | 'disabled');
    multiDatesPicker(method: 'value'): string;
    multiDatesPicker(method: 'value', value: string): void;
    multiDatesPicker(method: 'destroy'): void;
}