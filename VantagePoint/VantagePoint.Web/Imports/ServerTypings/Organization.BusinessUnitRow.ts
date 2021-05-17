namespace VantagePoint.Organization {
    export interface BusinessUnitRow {
        UnitId?: number;
        Name?: string;
        ParentUnitId?: number;
        ParentUnitName?: string;
        ParentUnitParentUnitId?: number;
    }

    export namespace BusinessUnitRow {
        export const idProperty = 'UnitId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Organization.BusinessUnit';
        export const lookupKey = 'Organization.BusinessUnit';

        export function getLookup(): Q.Lookup<BusinessUnitRow> {
            return Q.getLookup<BusinessUnitRow>('Organization.BusinessUnit');
        }
        export const deletePermission = 'Organization:BusinessUnits:Management';
        export const insertPermission = 'Organization:BusinessUnits:Management';
        export const readPermission = 'Organization:BusinessUnits:Management';
        export const updatePermission = 'Organization:BusinessUnits:Management';

        export declare const enum Fields {
            UnitId = "UnitId",
            Name = "Name",
            ParentUnitId = "ParentUnitId",
            ParentUnitName = "ParentUnitName",
            ParentUnitParentUnitId = "ParentUnitParentUnitId"
        }
    }
}
