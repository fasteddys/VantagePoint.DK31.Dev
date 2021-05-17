/// <reference path="../../../Common/Helpers/ServiceEditorBase.ts" />

namespace VantagePoint.AdvancedSamples {

    @Serenity.Decorators.registerEditor()
    export class DataConnectionEditor extends ServiceEditorBase<ServiceEditorOptions, DataExplorerConnection> {

        constructor(hidden: JQuery) {
            super(hidden, null);
        }

        public getItemKey(item: DataExplorerConnection): string {
            return item.Key;
        }

        public getItemText(item: DataExplorerConnection): string {
            return item.Key;
        }

        public getService() {
            return DataExplorerService.baseUrl;
        }

        public executeQuery(options: Serenity.ServiceOptions<Serenity.ListResponse<DataExplorerConnection>>): void {
            options.url = Q.resolveUrl("~/Services/AdvancedSamples/DataExplorer/ListConnections");
            super.executeQuery(options);
        }

        public executeQueryByKey(options: Serenity.ServiceOptions<Serenity.RetrieveResponse<DataExplorerConnection>>): void {
            options.onSuccess({
                Entity: {
                    Key: options.request.EntityId
                }
            });
        }
    }
}