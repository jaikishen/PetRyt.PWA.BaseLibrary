using System;
using System.Collections.Generic;

#nullable disable

namespace PetRyt.Common.UserManagementModels
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserRoles = new HashSet<AspNetUserRole>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            Pets = new HashSet<Pet>();
            UserAddressInfos = new HashSet<UserAddressInfo>();
            UserEmailInfos = new HashSet<UserEmailInfo>();
            UserPhoneInfos = new HashSet<UserPhoneInfo>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? PasswordExpiryDate { get; set; }
        public string EmailConfirmationCode { get; set; }
        public DateTime? EmailCodeExpiryDate { get; set; }
        public string PhoneConfirmationCode { get; set; }
        public DateTime? PhoneCodeExpiryDate { get; set; }
        public DateTime? PhoneCodeResendTime { get; set; }
        public bool EnforcePasswordChange { get; set; }
        public int? DeviceId { get; set; }
        public string PassCode { get; set; }
        public string Key { get; set; }
        public string DeviceAuthenticationType { get; set; }
        public string DeviceToken { get; set; }
        public string ClientId { get; set; }
        public string ClientGroup { get; set; }
        public DateTime? AgreementAcceptedDateTime { get; set; }
        public string ModifiedSystem { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public int? LastUpdatedBy { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeactivatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DefaultRole { get; set; }
        public string CurrentRole { get; set; }
        public int? GenderId { get; set; }
        public DateTime? Dob { get; set; }
        public bool? IsFirstLogin { get; set; }
        public bool? IsProfileUpdated { get; set; }

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<UserAddressInfo> UserAddressInfos { get; set; }
        public virtual ICollection<UserEmailInfo> UserEmailInfos { get; set; }
        public virtual ICollection<UserPhoneInfo> UserPhoneInfos { get; set; }
    }
}
