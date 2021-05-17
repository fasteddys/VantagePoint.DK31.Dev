namespace VantagePoint.Organization {
    export namespace BusinessUnitService {
        export const baseUrl = 'Organization/BusinessUnit';

        export declare function Create(request: Serenity.SaveRequest<BusinessUnitRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<BusinessUnitRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<BusinessUnitRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<BusinessUnitRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Organization/BusinessUnit/Create",
            Update = "Organization/BusinessUnit/Update",
            Delete = "Organization/BusinessUnit/Delete",
            Retrieve = "Organization/BusinessUnit/Retrieve",
            List = "Organization/BusinessUnit/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>BusinessUnitService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
