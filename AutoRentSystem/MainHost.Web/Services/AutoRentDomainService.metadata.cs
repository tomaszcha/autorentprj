
namespace MainHost.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ApplicationMetadata as the class
    // that carries additional metadata for the Application class.
    [MetadataTypeAttribute(typeof(Application.ApplicationMetadata))]
    public partial class Application
    {

        // This class allows you to attach custom attributes to properties
        // of the Application class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ApplicationMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ApplicationMetadata()
            {
            }

            public DateTime CreationDate { get; set; }

            public Department Department { get; set; }

            public Department Department1 { get; set; }

            public string Email { get; set; }

            public string FirstName { get; set; }

            public int Id { get; set; }

            public string LastName { get; set; }

            public Model Model { get; set; }

            public int ModelId { get; set; }

            public string Phone { get; set; }

            public DateTime PickupDate { get; set; }

            public int PickupDepartmentId { get; set; }

            public string Preferences { get; set; }

            public DateTime ReturnDate { get; set; }

            public int ReturnDepartmentId { get; set; }

            public short Status { get; set; }
        }
    }

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

            public Category Category { get; set; }

            public int CategoryId { get; set; }

            public EntityCollection<ChargeOffOrder> ChargeOffOrder { get; set; }

            public short Color { get; set; }

            public string Description { get; set; }

            public EntityCollection<ExtraDamage> ExtraDamage { get; set; }

            public int Id { get; set; }

            public Insuarance Insuarance { get; set; }

            public int InsuaranceId { get; set; }

            public Nullable<DateTime> LastCheckDate { get; set; }

            public int Mileage { get; set; }

            public Model Model { get; set; }

            public int ModelId { get; set; }

            public string Number { get; set; }

            public EntityCollection<Order> Order { get; set; }

            public EntityCollection<OrdinaryDamage> OrdinaryDamage { get; set; }

            public EntityCollection<PurchaseOrder> PurchaseOrder { get; set; }

            public EntityCollection<Repair> Repair { get; set; }

            public short Status { get; set; }

            public short Year { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies CategoryMetadata as the class
    // that carries additional metadata for the Category class.
    [MetadataTypeAttribute(typeof(Category.CategoryMetadata))]
    public partial class Category
    {

        // This class allows you to attach custom attributes to properties
        // of the Category class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CategoryMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CategoryMetadata()
            {
            }

            public EntityCollection<Auto> Auto { get; set; }

            public bool Deposit { get; set; }

            public int Id { get; set; }

            public string Name { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies ChargeOffOrderMetadata as the class
    // that carries additional metadata for the ChargeOffOrder class.
    [MetadataTypeAttribute(typeof(ChargeOffOrder.ChargeOffOrderMetadata))]
    public partial class ChargeOffOrder
    {

        // This class allows you to attach custom attributes to properties
        // of the ChargeOffOrder class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ChargeOffOrderMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ChargeOffOrderMetadata()
            {
            }

            public Auto Auto { get; set; }

            public int AutoId { get; set; }

            public Employee Employee { get; set; }

            public Employee Employee1 { get; set; }

            public int Id { get; set; }

            public Nullable<int> ManagerId { get; set; }

            public int MechanicId { get; set; }

            public string Reason { get; set; }

            public short Status { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies CityMetadata as the class
    // that carries additional metadata for the City class.
    [MetadataTypeAttribute(typeof(City.CityMetadata))]
    public partial class City
    {

        // This class allows you to attach custom attributes to properties
        // of the City class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CityMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CityMetadata()
            {
            }

            public EntityCollection<Department> Department { get; set; }

            public EntityCollection<Employee> Employee { get; set; }

            public EntityCollection<EvacuationOrder> EvacuationOrder { get; set; }

            public int Id { get; set; }

            public EntityCollection<InsuaranceAgency> InsuaranceAgency { get; set; }

            public string Name { get; set; }

            public EntityCollection<Purchaser> Purchaser { get; set; }

            public EntityCollection<Supplier> Supplier { get; set; }

            public EntityCollection<TechnicalService> TechnicalService { get; set; }
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

            public string Email { get; set; }

            public string FirstName { get; set; }

            public int Id { get; set; }

            public string Insuarance { get; set; }

            public string LastName { get; set; }

            public EntityCollection<Order> Order { get; set; }

            public string Passport { get; set; }

            public string Phone { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies DamageMetadata as the class
    // that carries additional metadata for the Damage class.
    [MetadataTypeAttribute(typeof(Damage.DamageMetadata))]
    public partial class Damage
    {

        // This class allows you to attach custom attributes to properties
        // of the Damage class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DamageMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DamageMetadata()
            {
            }

            public int Id { get; set; }

            public string Name { get; set; }

            public EntityCollection<OrdinaryDamage> OrdinaryDamage { get; set; }

            public decimal Price { get; set; }
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

            public string Address { get; set; }

            public EntityCollection<Application> Application { get; set; }

            public EntityCollection<Application> Application1 { get; set; }

            public City City { get; set; }

            public int CityId { get; set; }

            public EntityCollection<Employee> Employee { get; set; }

            public int Id { get; set; }

            public EntityCollection<Order> Order { get; set; }

            public EntityCollection<Order> Order1 { get; set; }

            public string Phone { get; set; }
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

            public Nullable<DateTime> Birthday { get; set; }

            public EntityCollection<ChargeOffOrder> ChargeOffOrder { get; set; }

            public EntityCollection<ChargeOffOrder> ChargeOffOrder1 { get; set; }

            public City City { get; set; }

            public int CityId { get; set; }

            public Department Department { get; set; }

            public int DepartmentId { get; set; }

            public Nullable<DateTime> FireDate { get; set; }

            public string FirstName { get; set; }

            public DateTime HireDate { get; set; }

            public int Id { get; set; }

            public string IdentificationCode { get; set; }

            public string LastName { get; set; }

            public string Passport { get; set; }

            public string Phone { get; set; }

            public string Position { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies EvacuationOrderMetadata as the class
    // that carries additional metadata for the EvacuationOrder class.
    [MetadataTypeAttribute(typeof(EvacuationOrder.EvacuationOrderMetadata))]
    public partial class EvacuationOrder
    {

        // This class allows you to attach custom attributes to properties
        // of the EvacuationOrder class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class EvacuationOrderMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private EvacuationOrderMetadata()
            {
            }

            public string Address { get; set; }

            public City City { get; set; }

            public int CityId { get; set; }

            public int Id { get; set; }

            public Order Order { get; set; }

            public int OrderId { get; set; }

            public Nullable<decimal> Value { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies ExtraDamageMetadata as the class
    // that carries additional metadata for the ExtraDamage class.
    [MetadataTypeAttribute(typeof(ExtraDamage.ExtraDamageMetadata))]
    public partial class ExtraDamage
    {

        // This class allows you to attach custom attributes to properties
        // of the ExtraDamage class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ExtraDamageMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ExtraDamageMetadata()
            {
            }

            public Auto Auto { get; set; }

            public int AutoId { get; set; }

            public Nullable<DateTime> DamageDate { get; set; }

            public string Description { get; set; }

            public Nullable<DateTime> FixDate { get; set; }

            public int Id { get; set; }

            public string Name { get; set; }

            public decimal Price { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies InsuaranceMetadata as the class
    // that carries additional metadata for the Insuarance class.
    [MetadataTypeAttribute(typeof(Insuarance.InsuaranceMetadata))]
    public partial class Insuarance
    {

        // This class allows you to attach custom attributes to properties
        // of the Insuarance class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class InsuaranceMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private InsuaranceMetadata()
            {
            }

            public EntityCollection<Auto> Auto { get; set; }

            public int Id { get; set; }

            public InsuaranceAgency InsuaranceAgency { get; set; }

            public int InsuaranceAgencyId { get; set; }

            public string Number { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies InsuaranceAgencyMetadata as the class
    // that carries additional metadata for the InsuaranceAgency class.
    [MetadataTypeAttribute(typeof(InsuaranceAgency.InsuaranceAgencyMetadata))]
    public partial class InsuaranceAgency
    {

        // This class allows you to attach custom attributes to properties
        // of the InsuaranceAgency class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class InsuaranceAgencyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private InsuaranceAgencyMetadata()
            {
            }

            public string Address { get; set; }

            public City City { get; set; }

            public int CityId { get; set; }

            public int Id { get; set; }

            public EntityCollection<Insuarance> Insuarance { get; set; }

            public string Name { get; set; }

            public string Phone { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies MakeMetadata as the class
    // that carries additional metadata for the Make class.
    [MetadataTypeAttribute(typeof(Make.MakeMetadata))]
    public partial class Make
    {

        // This class allows you to attach custom attributes to properties
        // of the Make class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class MakeMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private MakeMetadata()
            {
            }

            public int Id { get; set; }

            public EntityCollection<Model> Model { get; set; }

            public string Name { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies ModelMetadata as the class
    // that carries additional metadata for the Model class.
    [MetadataTypeAttribute(typeof(Model.ModelMetadata))]
    public partial class Model
    {

        // This class allows you to attach custom attributes to properties
        // of the Model class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ModelMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ModelMetadata()
            {
            }

            public EntityCollection<Application> Application { get; set; }

            public EntityCollection<Auto> Auto { get; set; }

            public Nullable<decimal> DayRate { get; set; }

            public Nullable<decimal> Deposit { get; set; }

            public string Engine { get; set; }

            public int Id { get; set; }

            public Nullable<decimal> KmRate { get; set; }

            public Make Make { get; set; }

            public int MakeId { get; set; }

            public string Name { get; set; }

            public byte[] Photo { get; set; }

            public Nullable<short> Seats { get; set; }

            public EntityCollection<SupplyOrder> SupplyOrder { get; set; }
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

            public Auto Auto { get; set; }

            public Nullable<int> AutoId { get; set; }

            public Nullable<DateTime> CloseDate { get; set; }

            public Nullable<DateTime> CreateDate { get; set; }

            public Customer Customer { get; set; }

            public int CustomerId { get; set; }

            public Department Department { get; set; }

            public Department Department1 { get; set; }

            public EntityCollection<EvacuationOrder> EvacuationOrder { get; set; }

            public int Id { get; set; }

            public Nullable<decimal> PaymentSum { get; set; }

            public Nullable<short> PaymentType { get; set; }

            public Nullable<DateTime> PickupDate { get; set; }

            public Nullable<int> PickupDepartmentId { get; set; }

            public short RentType { get; set; }

            public Nullable<DateTime> ReturnDate { get; set; }

            public Nullable<int> ReturnDepartmentId { get; set; }

            public short Status { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies OrdinaryDamageMetadata as the class
    // that carries additional metadata for the OrdinaryDamage class.
    [MetadataTypeAttribute(typeof(OrdinaryDamage.OrdinaryDamageMetadata))]
    public partial class OrdinaryDamage
    {

        // This class allows you to attach custom attributes to properties
        // of the OrdinaryDamage class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class OrdinaryDamageMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private OrdinaryDamageMetadata()
            {
            }

            public Auto Auto { get; set; }

            public int AutoId { get; set; }

            public Damage Damage { get; set; }

            public DateTime DamageDate { get; set; }

            public int DamageId { get; set; }

            public DateTime FixDate { get; set; }

            public int Id { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies PurchaseOrderMetadata as the class
    // that carries additional metadata for the PurchaseOrder class.
    [MetadataTypeAttribute(typeof(PurchaseOrder.PurchaseOrderMetadata))]
    public partial class PurchaseOrder
    {

        // This class allows you to attach custom attributes to properties
        // of the PurchaseOrder class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PurchaseOrderMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PurchaseOrderMetadata()
            {
            }

            public Auto Auto { get; set; }

            public int AutoId { get; set; }

            public int Id { get; set; }

            public decimal Price { get; set; }

            public int PuchaserId { get; set; }

            public Purchaser Purchaser { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies PurchaserMetadata as the class
    // that carries additional metadata for the Purchaser class.
    [MetadataTypeAttribute(typeof(Purchaser.PurchaserMetadata))]
    public partial class Purchaser
    {

        // This class allows you to attach custom attributes to properties
        // of the Purchaser class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PurchaserMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PurchaserMetadata()
            {
            }

            public string Address { get; set; }

            public City City { get; set; }

            public int CityId { get; set; }

            public int Id { get; set; }

            public string Name { get; set; }

            public string Phone { get; set; }

            public EntityCollection<PurchaseOrder> PurchaseOrder { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies RepairMetadata as the class
    // that carries additional metadata for the Repair class.
    [MetadataTypeAttribute(typeof(Repair.RepairMetadata))]
    public partial class Repair
    {

        // This class allows you to attach custom attributes to properties
        // of the Repair class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RepairMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private RepairMetadata()
            {
            }

            public Auto Auto { get; set; }

            public int AutoId { get; set; }

            public string Description { get; set; }

            public Nullable<DateTime> EndDate { get; set; }

            public int Id { get; set; }

            public Nullable<decimal> PaymentSum { get; set; }

            public DateTime StartDate { get; set; }

            public TechnicalService TechnicalService { get; set; }

            public int TechnicalServiceId { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies SupplierMetadata as the class
    // that carries additional metadata for the Supplier class.
    [MetadataTypeAttribute(typeof(Supplier.SupplierMetadata))]
    public partial class Supplier
    {

        // This class allows you to attach custom attributes to properties
        // of the Supplier class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class SupplierMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private SupplierMetadata()
            {
            }

            public string Address { get; set; }

            public City City { get; set; }

            public int CityId { get; set; }

            public int Id { get; set; }

            public string Name { get; set; }

            public string Phone { get; set; }

            public EntityCollection<SupplyOrder> SupplyOrder { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies SupplyOrderMetadata as the class
    // that carries additional metadata for the SupplyOrder class.
    [MetadataTypeAttribute(typeof(SupplyOrder.SupplyOrderMetadata))]
    public partial class SupplyOrder
    {

        // This class allows you to attach custom attributes to properties
        // of the SupplyOrder class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class SupplyOrderMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private SupplyOrderMetadata()
            {
            }

            public int Id { get; set; }

            public Model Model { get; set; }

            public int ModelId { get; set; }

            public decimal Price { get; set; }

            public short Quantity { get; set; }

            public Supplier Supplier { get; set; }

            public int SupplierId { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies TechnicalServiceMetadata as the class
    // that carries additional metadata for the TechnicalService class.
    [MetadataTypeAttribute(typeof(TechnicalService.TechnicalServiceMetadata))]
    public partial class TechnicalService
    {

        // This class allows you to attach custom attributes to properties
        // of the TechnicalService class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TechnicalServiceMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private TechnicalServiceMetadata()
            {
            }

            public string Address { get; set; }

            public City City { get; set; }

            public int CityId { get; set; }

            public int Id { get; set; }

            public string Name { get; set; }

            public string Phone { get; set; }

            public EntityCollection<Repair> Repair { get; set; }
        }
    }
}
