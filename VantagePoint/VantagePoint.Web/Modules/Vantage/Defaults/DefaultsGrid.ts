
namespace VantagePoint.Vantage {

    @Serenity.Decorators.registerClass()
    export class DefaultsGrid extends Serenity.EntityGrid<DefaultsRow, any> {
        protected getColumnsKey() { return 'Vantage.Defaults'; }
        protected getDialogType() { return DefaultsDialog; }
        protected getIdProperty() { return DefaultsRow.idProperty; }
        protected getInsertPermission() { return DefaultsRow.insertPermission; }
        protected getLocalTextPrefix() { return DefaultsRow.localTextPrefix; }
        protected getService() { return DefaultsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}