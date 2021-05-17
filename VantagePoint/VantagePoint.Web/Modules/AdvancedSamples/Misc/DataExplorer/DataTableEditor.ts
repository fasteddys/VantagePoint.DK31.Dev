/// <reference path="../../../Common/Helpers/ServiceEditorBase.ts" />

namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerEditor()
    export class DataTableEditor extends ServiceEditorBase<ServiceEditorOptions, DataExplorerTable> {

        constructor(hidden: JQuery, options: ServiceEditorOptions) {
            super(hidden, options);
        }

        public getItemKey(item: DataExplorerTable): string {
            return item.Name;
        }

        public getItemText(item: DataExplorerTable): string {
            return item.Name;
        }

        public getService() {
            return DataExplorerService.baseUrl;
        }

        public executeQuery(options: Serenity.ServiceOptions<Serenity.ListResponse<DataExplorerTable>>): void {
            options.url = Q.resolveUrl("~/Services/AdvancedSamples/DataExplorer/ListTables");
            var connectionKey = this.cascadeValue;

            if (!connectionKey) {
                options.onSuccess({ Entities: [] });
                return;
            }

            (options.request as DataExplorerListTablesRequest).ConnectionKey = connectionKey;
            super.executeQuery(options);
        }

        public executeQueryByKey(options: Serenity.ServiceOptions<Serenity.RetrieveResponse<DataExplorerTable>>): void {
            options.onSuccess({
                Entity: {
                    Name: (<Serenity.RetrieveRequest>options.request).EntityId
                }
            });
        }
    }
}