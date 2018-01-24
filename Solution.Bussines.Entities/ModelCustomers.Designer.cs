﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]
[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute("BookingPagosModel", "FK_Customers_Category", "Category", global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Solution.Bussines.Entities.Category), "Customers", global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Solution.Bussines.Entities.Customers))]

// Original file name:
// Generation date: 07/07/2009 08:44:04 p.m.
namespace Solution.Bussines.Entities
{
    
    /// <summary>
    /// There are no comments for CustomersEntities in the schema.
    /// </summary>
    public partial class CustomersEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new CustomersEntities object using the connection string found in the 'CustomersEntities' section of the application configuration file.
        /// </summary>
        public CustomersEntities() : 
                base("name=CustomersEntities", "CustomersEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CustomersEntities object.
        /// </summary>
        public CustomersEntities(string connectionString) : 
                base(connectionString, "CustomersEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CustomersEntities object.
        /// </summary>
        public CustomersEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "CustomersEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Category> Category
        {
            get
            {
                if ((this._Category == null))
                {
                    this._Category = base.CreateQuery<Category>("[Category]");
                }
                return this._Category;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Category> _Category;
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Customers> Customers
        {
            get
            {
                if ((this._Customers == null))
                {
                    this._Customers = base.CreateQuery<Customers>("[Customers]");
                }
                return this._Customers;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Customers> _Customers;
        /// <summary>
        /// There are no comments for Table1 in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Table1> Table1
        {
            get
            {
                if ((this._Table1 == null))
                {
                    this._Table1 = base.CreateQuery<Table1>("[Table1]");
                }
                return this._Table1;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Table1> _Table1;
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        public void AddToCategory(Category category)
        {
            base.AddObject("Category", category);
        }
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        public void AddToCustomers(Customers customers)
        {
            base.AddObject("Customers", customers);
        }
        /// <summary>
        /// There are no comments for Table1 in the schema.
        /// </summary>
        public void AddToTable1(Table1 table1)
        {
            base.AddObject("Table1", table1);
        }
        /// <summary>
        /// There are no comments for BookingPagosModel.getCustomersByName in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectResult<Customers> getCustomersByName(string name)
        {
            global::System.Data.Objects.ObjectParameter nameParameter;
            if ((name != null))
            {
                nameParameter = new global::System.Data.Objects.ObjectParameter("Name", name);
            }
            else
            {
                nameParameter = new global::System.Data.Objects.ObjectParameter("Name", typeof(string));
            }
            return base.ExecuteFunction<Customers>("getCustomersByName", nameParameter);
        }
    }
    /// <summary>
    /// There are no comments for BookingPagosModel.Category in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="BookingPagosModel", Name="Category")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Category : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Category object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        public static Category CreateCategory(int id)
        {
            Category category = new Category();
            category.Id = id;
            return category;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Customers in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("BookingPagosModel", "FK_Customers_Category", "Customers")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityCollection<Customers> Customers
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Customers>("BookingPagosModel.FK_Customers_Category", "Customers");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Customers>("BookingPagosModel.FK_Customers_Category", "Customers", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for BookingPagosModel.Customers in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="BookingPagosModel", Name="Customers")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Customers : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Customers object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        public static Customers CreateCustomers(int id, string name)
        {
            Customers customers = new Customers();
            customers.Id = id;
            customers.Name = name;
            return customers;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this.ReportPropertyChanging("Id");
                this._Id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Id");
                this.OnIdChanged();
            }
        }
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this.ReportPropertyChanging("Name");
                this._Name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("Name");
                this.OnNameChanged();
            }
        }
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("BookingPagosModel", "FK_Customers_Category", "Category")]
        [global::System.Xml.Serialization.XmlIgnoreAttribute()]
        [global::System.Xml.Serialization.SoapIgnoreAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public Category Category
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Category>("BookingPagosModel.FK_Customers_Category", "Category").Value;
            }
            set
            {
                ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Category>("BookingPagosModel.FK_Customers_Category", "Category").Value = value;
            }
        }
        /// <summary>
        /// There are no comments for Category in the schema.
        /// </summary>
        [global::System.ComponentModel.BrowsableAttribute(false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Data.Objects.DataClasses.EntityReference<Category> CategoryReference
        {
            get
            {
                return ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Category>("BookingPagosModel.FK_Customers_Category", "Category");
            }
            set
            {
                if ((value != null))
                {
                    ((global::System.Data.Objects.DataClasses.IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Category>("BookingPagosModel.FK_Customers_Category", "Category", value);
                }
            }
        }
    }
    /// <summary>
    /// There are no comments for BookingPagosModel.Table1 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// id
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="BookingPagosModel", Name="Table1")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Table1 : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Table1 object.
        /// </summary>
        /// <param name="id">Initial value of id.</param>
        public static Table1 CreateTable1(int id)
        {
            Table1 table1 = new Table1();
            table1.id = id;
            return table1;
        }
        /// <summary>
        /// There are no comments for Property id in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.OnidChanging(value);
                this.ReportPropertyChanging("id");
                this._id = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("id");
                this.OnidChanged();
            }
        }
        private int _id;
        partial void OnidChanging(int value);
        partial void OnidChanged();
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                this.ReportPropertyChanging("name");
                this._name = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("name");
                this.OnnameChanged();
            }
        }
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
    }
}