namespace VantagePoint.AdvancedSamples {
    export interface DataExplorerListRequest extends Serenity.ListRequest {
        ConnectionKey?: string;
        TableName?: string;
    }
}
