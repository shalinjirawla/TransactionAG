using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TAG.Models
{
    public class ContactModel
    {
        public Guid ContactId { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Job title")]
        public string JobTitle { get; set; }
        public string Department { get; set; }
        [Display(Name = "Mobile phone")]
        public string MobilePhone { get; set; }
        [Display(Name = "Email address")]
        public string EMailAddress1 { get; set; }
        public Guid ParentCustomerId { get; set; }
    }
    public class AccountModel
    {
        public Guid AccountId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Company Email")]
        public string EMailAddress1 { get; set; }
        [Display(Name = "Main Phone")]
        public string Telephone1 { get; set; }
        public string PrimaryContactId { get; set; }
    }

    [Table("Account1")]
    public class Account1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AccountId { get; set; }
        public Int32 AccountCategoryCode { get; set; }
        public string TerritoryId { get; set; }
        public Int32 CustomerSizeCode { get; set; }
        public Int32 PreferredContactMethodCode { get; set; }
        public Int32 CustomerTypeCode { get; set; }
        public Int32 AccountRatingCode { get; set; }
        public Int32 IndustryCode { get; set; }
        public Int32 TerritoryCode { get; set; }
        public Int32 AccountClassificationCode { get; set; }
        public Int32 BusinessTypeCode { get; set; }
        public Guid OwningBusinessUnit { get; set; }
        public Guid OriginatingLeadId { get; set; }
        public Int32 PaymentTermsCode { get; set; }
        public Int32 ShippingMethodCode { get; set; }
        public Guid PrimaryContactId { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string Revenue { get; set; }
        public Int32 NumberOfEmployees { get; set; }
        public string Description { get; set; }
        public string SIC { get; set; }
        public Int32 OwnershipCode { get; set; }
        public string MarketCap { get; set; }
        public Int32 SharesOutstanding { get; set; }
        public string TickerSymbol { get; set; }
        public string StockExchange { get; set; }
        public string WebSiteURL { get; set; }
        public string FtpSiteURL { get; set; }
        public string EMailAddress1 { get; set; }
        public string EMailAddress2 { get; set; }
        public string EMailAddress3 { get; set; }
        public bool DoNotPhone { get; set; }
        public bool DoNotFax { get; set; }
        public string Telephone1 { get; set; }
        public bool DoNotEMail { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public string Telephone3 { get; set; }
        public bool DoNotPostalMail { get; set; }
        public bool DoNotBulkEMail { get; set; }
        public bool DoNotBulkPostalMail { get; set; }
        public string CreditLimit { get; set; }
        public bool CreditOnHold { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public string VersionNumber { get; set; }
        public Guid ParentAccountId { get; set; }
        public Int32 StateCode { get; set; }
        public Int32 StatusCode { get; set; }
        public Int32 PreferredAppointmentDayCode { get; set; }
        public Guid PreferredSystemUserId { get; set; }
        public Int32 PreferredAppointmentTimeCode { get; set; }
        public bool DoNotSendMM { get; set; }
        public Guid MasterId { get; set; }
        public DateTime LastUsedInCampaign { get; set; }
        public Guid PreferredServiceId { get; set; }
        public Guid PreferredEquipmentId { get; set; }
        public decimal ExchangeRate { get; set; }
        public string CreditLimit_Base { get; set; }
        public string Revenue_Base { get; set; }
        public string MarketCap_Base { get; set; }
        public Guid OwnerId { get; set; }
        public Guid ModifiedOnBehalfBy { get; set; }
        public Guid CreatedOnBehalfBy { get; set; }
        public Int32 OwnerIdType { get; set; }
        public Int32 OpenDeals { get; set; }
        public string OpenRevenue { get; set; }
        public Int32 OpenDeals_State { get; set; }
        public Int32 OpenRevenue_State { get; set; }
        public DateTime OpenRevenue_Date { get; set; }
        public string OpenRevenue_Base { get; set; }
        public DateTime OpenDeals_Date { get; set; }
        public Guid ModifiedByExternalParty { get; set; }
        public Guid CreatedByExternalParty { get; set; }
        public string PrimaryTwitterId { get; set; }
        public Guid PhysicalAddress { get; set; }
        public Guid MailingAddress { get; set; }
        public Guid ShippingAddress { get; set; }
        public Guid PlantAddress { get; set; }
        public string OperationType { get; set; }
        public string Logo { get; set; }
        public string LivestockType { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}