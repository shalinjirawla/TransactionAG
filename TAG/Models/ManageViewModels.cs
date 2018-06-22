using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Text;
using System;

namespace TAG.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }

    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }

  public class UserInfo
  {
    public Guid ContactId { get; set; } //ContactId
    public Guid ParentCustomerId { get; set; } //ParentCustomerId
    public string ParentCustomerIdName { get; set; } //ParentCustomerIdName

    //[StringLength(60, MinimumLength = 3)]
    //[Required]
    //[Display(Name = "First Name")]
    //[DisplayFormat(ApplyFormatInEditMode =true, )]
    public string FirstName { get; set; } //FirstName
    //[Required]
    public string LastName { get; set; } //LastName
    public string NickName { get; set; } //NickName
    public string FullName { get; set; } //FullName
    public string JobTitle { get; set; } //JobTitle
    public string Department { get; set; } //Department
    //[Required]
    public string EMailAddress1 { get; set; } //EMailAddress1
    public string EMailAddress2 { get; set; } //EmailAddress2
    public string WebSiteUrl { get; set; } //WebSiteURL
    public string Telephone1 { get; set; } //Telephone1
    public string Telephone2 { get; set; } //Telephone2
    public string MobilePhone { get; set; } //MobilePhone
    public string Fax { get; set; } //Fax
                                    //[Required]
    
  }
}