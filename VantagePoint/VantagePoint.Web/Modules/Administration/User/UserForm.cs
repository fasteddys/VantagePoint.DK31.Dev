﻿using Serenity.ComponentModel;
using System;

namespace VantagePoint.Administration.Forms
{
    [FormScript("Administration.User")]
    [BasedOnRow(typeof(Entities.UserRow), CheckNames = true)]
    public class UserForm
    {
        public String Username { get; set; }
        public String DisplayName { get; set; }
        [EmailEditor]
        public String Email { get; set; }
        public String MobilePhoneNumber { get; set; }
        public Boolean MobilePhoneVerified { get; set; }
        public TwoFactorAuthType TwoFactorAuth { get; set; }
        public String UserImage { get; set; }
        [PasswordEditor, Required(true)]
        public String Password { get; set; }
        [PasswordEditor, OneWay, Required(true)]
        public String PasswordConfirm { get; set; }
        [OneWay]
        public string Source { get; set; }
        public Guid? TenantId { get; set; }
    }
}