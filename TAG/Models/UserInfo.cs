using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TAG.Models
{
  public class UserProfile
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
  }
}