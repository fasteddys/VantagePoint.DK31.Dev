namespace VantagePoint.AdvancedSamples {
    export namespace DataExplorerService {
        export const baseUrl = 'AdvancedSamples/DataExplorer';

        export declare function ListConnections(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<DataExplorerConnection>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ListTables(request: DataExplorerListTablesRequest, onSuccess?: (response: Serenity.ListResponse<DataExplorerTable>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ListColumns(request: DataExplorerListRequest, onSuccess?: (response: Serenity.ListResponse<Serenity.PropertyItem>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: DataExplorerListRequest, onSuccess?: (response: Serenity.ListResponse<{ [key: string]: any }>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            ListConnections = "AdvancedSamples/DataExplorer/ListConnections",
            ListTables = "AdvancedSamples/DataExplorer/ListTables",
            ListColumns = "AdvancedSamples/DataExplorer/ListColumns",
            List = "AdvancedSamples/DataExplorer/List"
        }

        [
            'ListConnections', 
            'ListTables', 
            'ListColumns', 
            'List'
        ].forEach(x => {
            (<any>DataExplorerService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
