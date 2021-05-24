namespace VantagePoint.Administration {
    export interface TenantRow {
        TenantId?: string;
        Name?: string;
        Tier?: string;
        Domain?: string;
        Created?: string;
        Modified?: string;
    }

    export namespace TenantRow {
        export const idProperty = 'TenantId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Administration.Tenant';
        export const deletePermission = 'Administration:Tenant';
        export const insertPermission = 'Administration:Tenant';
        export const readPermission = 'Administration:Tenant';
        export const updatePermission = 'Administration:Tenant';

        export declare const enum Fields {
            TenantId = "TenantId",
            Name = "Name",
            Tier = "Tier",
            Domain = "Domain",
            Created = "Created",
            Modified = "Modified"
        }
    }
}
