namespace VantagePoint.Organization {
    export interface ContactRow {
        ContactId?: number;
        Title?: string;
        FirstName?: string;
        LastName?: string;
        FullName?: string;
        Email?: string;
        IdentityNo?: string;
        UserId?: number;
        Username?: string;
        UserDisplayName?: string;
        UserEmail?: string;
        UserSource?: string;
        UserPasswordHash?: string;
        UserPasswordSalt?: string;
        UserLastDirectoryUpdate?: string;
        UserUserImage?: string;
        UserInsertDate?: string;
        UserInsertUserId?: number;
        UserUpdateDate?: string;
        UserUpdateUserId?: number;
        UserIsActive?: number;
    }

    export namespace ContactRow {
        export const idProperty = 'ContactId';
        export const nameProperty = 'FullName';
        export const localTextPrefix = 'Organization.Contact';
        export const lookupKey = 'Organization.Contact';

        export function getLookup(): Q.Lookup<ContactRow> {
            return Q.getLookup<ContactRow>('Organization.Contact');
        }
        export const deletePermission = 'Organization:Contacts:Management';
        export const insertPermission = 'Organization:Contacts:Management';
        export const readPermission = 'Organization:Contacts:Management';
        export const updatePermission = 'Organization:Contacts:Management';

        export declare const enum Fields {
            ContactId = "ContactId",
            Title = "Title",
            FirstName = "FirstName",
            LastName = "LastName",
            FullName = "FullName",
            Email = "Email",
            IdentityNo = "IdentityNo",
            UserId = "UserId",
            Username = "Username",
            UserDisplayName = "UserDisplayName",
            UserEmail = "UserEmail",
            UserSource = "UserSource",
            UserPasswordHash = "UserPasswordHash",
            UserPasswordSalt = "UserPasswordSalt",
            UserLastDirectoryUpdate = "UserLastDirectoryUpdate",
            UserUserImage = "UserUserImage",
            UserInsertDate = "UserInsertDate",
            UserInsertUserId = "UserInsertUserId",
            UserUpdateDate = "UserUpdateDate",
            UserUpdateUserId = "UserUpdateUserId",
            UserIsActive = "UserIsActive"
        }
    }
}
