
namespace Main.Web.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies AutoMetadata as the class
    // that carries additional metadata for the Auto class.
    [MetadataTypeAttribute(typeof(Auto.AutoMetadata))]
    public partial class Auto
    {

        // This class allows you to attach custom attributes to properties
        // of the Auto class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AutoMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AutoMetadata()
            {
            }

            public Nullable<decimal> Advance { get; set; }

            public EntityCollection<AutoPhotos> AutoPhotos { get; set; }

            public int BodyType { get; set; }

            public short Class { get; set; }

            public string ColorGroup { get; set; }

            public Nullable<decimal> DayRate { get; set; }

            public int Engine { get; set; }

            public string InsuaranceNumber { get; set; }

            public Nullable<decimal> KmRate { get; set; }

            public int Mileage { get; set; }

            public string ModelName { get; set; }

            public string Number { get; set; }

            public short Status { get; set; }

            public EntityCollection<Ticket> Ticket { get; set; }

            public short Year { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies AutoPhotosMetadata as the class
    // that carries additional metadata for the AutoPhotos class.
    [MetadataTypeAttribute(typeof(AutoPhotos.AutoPhotosMetadata))]
    public partial class AutoPhotos
    {

        // This class allows you to attach custom attributes to properties
        // of the AutoPhotos class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AutoPhotosMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AutoPhotosMetadata()
            {
            }

            public Auto Auto { get; set; }

            public string AutoNumber { get; set; }

            public DamageClass DamageClass { get; set; }

            public Nullable<int> DmgClass { get; set; }

            public DateTime DoDate { get; set; }

            public string PhotoFileName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies CustomerMetadata as the class
    // that carries additional metadata for the Customer class.
    [MetadataTypeAttribute(typeof(Customer.CustomerMetadata))]
    public partial class Customer
    {

        // This class allows you to attach custom attributes to properties
        // of the Customer class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CustomerMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CustomerMetadata()
            {
            }

            public string Address { get; set; }

            public Nullable<DateTime> BirthDay { get; set; }

            public string Data { get; set; }

            public Guid Id { get; set; }

            public string InsuranceNumber { get; set; }

            public string LicenceNumber { get; set; }

            public EntityCollection<Members> Members { get; set; }

            public string Name { get; set; }

            public EntityCollection<Order> Order { get; set; }

            public string Passport { get; set; }

            public EntityCollection<Payment> Payment { get; set; }

            public string Phone { get; set; }

            public EntityCollection<Ticket> Ticket { get; set; }

            public string Type { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DamageClassMetadata as the class
    // that carries additional metadata for the DamageClass class.
    [MetadataTypeAttribute(typeof(DamageClass.DamageClassMetadata))]
    public partial class DamageClass
    {

        // This class allows you to attach custom attributes to properties
        // of the DamageClass class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DamageClassMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DamageClassMetadata()
            {
            }

            public EntityCollection<AutoPhotos> AutoPhotos { get; set; }

            public int Class { get; set; }

            public EntityCollection<Damages> Damages { get; set; }

            public string Description { get; set; }

            public string Name { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DamagesMetadata as the class
    // that carries additional metadata for the Damages class.
    [MetadataTypeAttribute(typeof(Damages.DamagesMetadata))]
    public partial class Damages
    {

        // This class allows you to attach custom attributes to properties
        // of the Damages class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DamagesMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DamagesMetadata()
            {
            }

            public int Class { get; set; }

            public DamageClass DamageClass { get; set; }

            public long Id { get; set; }

            public byte Rate { get; set; }

            public long RevisionId { get; set; }

            public Revisions Revisions { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DepartmentMetadata as the class
    // that carries additional metadata for the Department class.
    [MetadataTypeAttribute(typeof(Department.DepartmentMetadata))]
    public partial class Department
    {

        // This class allows you to attach custom attributes to properties
        // of the Department class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DepartmentMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DepartmentMetadata()
            {
            }

            public string Addresse { get; set; }

            public int CityCode { get; set; }

            public EntityCollection<Employee> Employee { get; set; }

            public Guid Id { get; set; }

            public string Name { get; set; }

            public EntityCollection<Order> Order { get; set; }

            public string Phone { get; set; }

            public EntityCollection<Ticket> Ticket { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies EmployeeMetadata as the class
    // that carries additional metadata for the Employee class.
    [MetadataTypeAttribute(typeof(Employee.EmployeeMetadata))]
    public partial class Employee
    {

        // This class allows you to attach custom attributes to properties
        // of the Employee class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class EmployeeMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private EmployeeMetadata()
            {
            }

            public string Address { get; set; }

            public Nullable<DateTime> BirthDay { get; set; }

            public string Data { get; set; }

            public Department Department { get; set; }

            public Nullable<Guid> DepartmentId { get; set; }

            public Nullable<DateTime> FireDate { get; set; }

            public string FirstName { get; set; }

            public DateTime HireDate { get; set; }

            public Guid Id { get; set; }

            public string InsuranceNumber { get; set; }

            public string LastName { get; set; }

            public string LicenceNumber { get; set; }

            public EntityCollection<Members> Members { get; set; }

            public EntityCollection<Order> Order { get; set; }

            public string Phone { get; set; }

            public string Position { get; set; }

            public EntityCollection<Ticket> Ticket { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies MembersMetadata as the class
    // that carries additional metadata for the Members class.
    [MetadataTypeAttribute(typeof(Members.MembersMetadata))]
    public partial class Members
    {

        // This class allows you to attach custom attributes to properties
        // of the Members class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class MembersMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private MembersMetadata()
            {
            }

            public DateTime Created { get; set; }

            public Nullable<Guid> CRecord { get; set; }

            public Customer Customer { get; set; }

            public string Email { get; set; }

            public Employee Employee { get; set; }

            public Nullable<Guid> ERecord { get; set; }

            public bool Lock { get; set; }

            public string Login { get; set; }

            public string Password { get; set; }

            public EntityCollection<Roles> Roles { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies OrderMetadata as the class
    // that carries additional metadata for the Order class.
    [MetadataTypeAttribute(typeof(Order.OrderMetadata))]
    public partial class Order
    {

        // This class allows you to attach custom attributes to properties
        // of the Order class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class OrderMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private OrderMetadata()
            {
            }

            public string AutoNumber { get; set; }

            public DateTime CreationDate { get; set; }

            public Customer Customer { get; set; }

            public Guid CustomerId { get; set; }

            public string Data { get; set; }

            public Department Department { get; set; }

            public Guid DepartmentId { get; set; }

            public string Description { get; set; }

            public Employee Employee { get; set; }

            public Nullable<DateTime> ExpiredDate { get; set; }

            public Nullable<Guid> ManagerId { get; set; }

            public int Number { get; set; }

            public int Status { get; set; }

            public string Template { get; set; }

            public int Type { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies PaymentMetadata as the class
    // that carries additional metadata for the Payment class.
    [MetadataTypeAttribute(typeof(Payment.PaymentMetadata))]
    public partial class Payment
    {

        // This class allows you to attach custom attributes to properties
        // of the Payment class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PaymentMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PaymentMetadata()
            {
            }

            public decimal Amount { get; set; }

            public Customer Customer { get; set; }

            public Guid CustomerId { get; set; }

            public DateTime Date { get; set; }

            public string Destination { get; set; }

            public int Id { get; set; }

            public Nullable<int> OrderId { get; set; }

            public int TicketId { get; set; }

            public int Type { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies PermissionRuleMetadata as the class
    // that carries additional metadata for the PermissionRule class.
    [MetadataTypeAttribute(typeof(PermissionRule.PermissionRuleMetadata))]
    public partial class PermissionRule
    {

        // This class allows you to attach custom attributes to properties
        // of the PermissionRule class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PermissionRuleMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PermissionRuleMetadata()
            {
            }

            public long Id { get; set; }

            public string Name { get; set; }

            public string ObjectSubType { get; set; }

            public string ObjectType { get; set; }

            public EntityCollection<RulesInRole> RulesInRole { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies RevisionsMetadata as the class
    // that carries additional metadata for the Revisions class.
    [MetadataTypeAttribute(typeof(Revisions.RevisionsMetadata))]
    public partial class Revisions
    {

        // This class allows you to attach custom attributes to properties
        // of the Revisions class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RevisionsMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private RevisionsMetadata()
            {
            }

            public string AutoNumber { get; set; }

            public EntityCollection<Damages> Damages { get; set; }

            public DateTime DoDate { get; set; }

            public long Id { get; set; }

            public TicketHistory TicketHistory { get; set; }

            public int TicketId { get; set; }

            public Nullable<int> Type { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies RolesMetadata as the class
    // that carries additional metadata for the Roles class.
    [MetadataTypeAttribute(typeof(Roles.RolesMetadata))]
    public partial class Roles
    {

        // This class allows you to attach custom attributes to properties
        // of the Roles class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RolesMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private RolesMetadata()
            {
            }

            public Guid Id { get; set; }

            public EntityCollection<Members> Members { get; set; }

            public string Name { get; set; }

            public EntityCollection<RulesInRole> RulesInRole { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies RulesInRoleMetadata as the class
    // that carries additional metadata for the RulesInRole class.
    [MetadataTypeAttribute(typeof(RulesInRole.RulesInRoleMetadata))]
    public partial class RulesInRole
    {

        // This class allows you to attach custom attributes to properties
        // of the RulesInRole class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RulesInRoleMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private RulesInRoleMetadata()
            {
            }

            public bool Delete { get; set; }

            public bool Execute { get; set; }

            public bool New { get; set; }

            public long PermId { get; set; }

            public PermissionRule PermissionRule { get; set; }

            public bool Read { get; set; }

            public Guid RoleId { get; set; }

            public Roles Roles { get; set; }

            public bool Write { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies sysdiagramsMetadata as the class
    // that carries additional metadata for the sysdiagrams class.
    [MetadataTypeAttribute(typeof(sysdiagrams.sysdiagramsMetadata))]
    public partial class sysdiagrams
    {

        // This class allows you to attach custom attributes to properties
        // of the sysdiagrams class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class sysdiagramsMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private sysdiagramsMetadata()
            {
            }

            public byte[] definition { get; set; }

            public int diagram_id { get; set; }

            public string name { get; set; }

            public int principal_id { get; set; }

            public Nullable<int> version { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies TicketHistoryMetadata as the class
    // that carries additional metadata for the TicketHistory class.
    [MetadataTypeAttribute(typeof(TicketHistory.TicketHistoryMetadata))]
    public partial class TicketHistory
    {

        // This class allows you to attach custom attributes to properties
        // of the TicketHistory class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TicketHistoryMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private TicketHistoryMetadata()
            {
            }

            public int Action { get; set; }

            public Guid DepartmentId { get; set; }

            public string Description { get; set; }

            public DateTime DoDate { get; set; }

            public Nullable<Guid> Executor { get; set; }

            public EntityCollection<Revisions> Revisions { get; set; }

            public Ticket Ticket { get; set; }

            public int TicketId { get; set; }

            public string XmlData { get; set; }
        }
    }
}
