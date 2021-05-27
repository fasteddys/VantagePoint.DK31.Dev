namespace VantagePoint.Vantage {
    export interface DefaultsRow {
        Id?: number;
        Name?: string;
        Datatype?: string;
        Value?: string;
        Class?: string;
        Scope?: string;
    }

    export namespace DefaultsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Vantage.Defaults';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Datatype = "Datatype",
            Value = "Value",
            Class = "Class",
            Scope = "Scope"
        }
    }
}
