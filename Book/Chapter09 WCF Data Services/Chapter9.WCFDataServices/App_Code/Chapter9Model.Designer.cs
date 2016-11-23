﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("BookModel", "FK_FilmShowing_Film", "Film", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(BookModel.Film), "FilmShowing", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BookModel.FilmShowing), true)]
[assembly: EdmRelationshipAttribute("BookModel", "FK_OrderItem_FilmShowing", "FilmShowing", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(BookModel.FilmShowing), "OrderItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BookModel.OrderItem), true)]
[assembly: EdmRelationshipAttribute("BookModel", "FK_OrderItem_Order", "Order", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(BookModel.Order), "OrderItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BookModel.OrderItem), true)]

#endregion

namespace BookModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class BookEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new BookEntities object using the connection string found in the 'BookEntities' section of the application configuration file.
        /// </summary>
        public BookEntities() : base("name=BookEntities", "BookEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BookEntities object.
        /// </summary>
        public BookEntities(string connectionString) : base(connectionString, "BookEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BookEntities object.
        /// </summary>
        public BookEntities(EntityConnection connection) : base(connection, "BookEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Film> Films
        {
            get
            {
                if ((_Films == null))
                {
                    _Films = base.CreateObjectSet<Film>("Films");
                }
                return _Films;
            }
        }
        private ObjectSet<Film> _Films;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<FilmShowing> FilmShowings
        {
            get
            {
                if ((_FilmShowings == null))
                {
                    _FilmShowings = base.CreateObjectSet<FilmShowing>("FilmShowings");
                }
                return _FilmShowings;
            }
        }
        private ObjectSet<FilmShowing> _FilmShowings;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OrderItem> OrderItems
        {
            get
            {
                if ((_OrderItems == null))
                {
                    _OrderItems = base.CreateObjectSet<OrderItem>("OrderItems");
                }
                return _OrderItems;
            }
        }
        private ObjectSet<OrderItem> _OrderItems;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Films EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFilms(Film film)
        {
            base.AddObject("Films", film);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the FilmShowings EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFilmShowings(FilmShowing filmShowing)
        {
            base.AddObject("FilmShowings", filmShowing);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the OrderItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrderItems(OrderItem orderItem)
        {
            base.AddObject("OrderItems", orderItem);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BookModel", Name="Film")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Film : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Film object.
        /// </summary>
        /// <param name="filmID">Initial value of the FilmID property.</param>
        public static Film CreateFilm(global::System.Int32 filmID)
        {
            Film film = new Film();
            film.FilmID = filmID;
            return film;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 FilmID
        {
            get
            {
                return _FilmID;
            }
            set
            {
                if (_FilmID != value)
                {
                    OnFilmIDChanging(value);
                    ReportPropertyChanging("FilmID");
                    _FilmID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("FilmID");
                    OnFilmIDChanged();
                }
            }
        }
        private global::System.Int32 _FilmID;
        partial void OnFilmIDChanging(global::System.Int32 value);
        partial void OnFilmIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Length
        {
            get
            {
                return _Length;
            }
            set
            {
                OnLengthChanging(value);
                ReportPropertyChanging("Length");
                _Length = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Length");
                OnLengthChanged();
            }
        }
        private Nullable<global::System.Int32> _Length;
        partial void OnLengthChanging(Nullable<global::System.Int32> value);
        partial void OnLengthChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookModel", "FK_FilmShowing_Film", "FilmShowing")]
        public EntityCollection<FilmShowing> FilmShowings
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FilmShowing>("BookModel.FK_FilmShowing_Film", "FilmShowing");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FilmShowing>("BookModel.FK_FilmShowing_Film", "FilmShowing", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BookModel", Name="FilmShowing")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class FilmShowing : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FilmShowing object.
        /// </summary>
        /// <param name="filmShowingID">Initial value of the FilmShowingID property.</param>
        public static FilmShowing CreateFilmShowing(global::System.Int32 filmShowingID)
        {
            FilmShowing filmShowing = new FilmShowing();
            filmShowing.FilmShowingID = filmShowingID;
            return filmShowing;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 FilmShowingID
        {
            get
            {
                return _FilmShowingID;
            }
            set
            {
                if (_FilmShowingID != value)
                {
                    OnFilmShowingIDChanging(value);
                    ReportPropertyChanging("FilmShowingID");
                    _FilmShowingID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("FilmShowingID");
                    OnFilmShowingIDChanged();
                }
            }
        }
        private global::System.Int32 _FilmShowingID;
        partial void OnFilmShowingIDChanging(global::System.Int32 value);
        partial void OnFilmShowingIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> FilmID
        {
            get
            {
                return _FilmID;
            }
            set
            {
                OnFilmIDChanging(value);
                ReportPropertyChanging("FilmID");
                _FilmID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FilmID");
                OnFilmIDChanged();
            }
        }
        private Nullable<global::System.Int32> _FilmID;
        partial void OnFilmIDChanging(Nullable<global::System.Int32> value);
        partial void OnFilmIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ShowingDate
        {
            get
            {
                return _ShowingDate;
            }
            set
            {
                OnShowingDateChanging(value);
                ReportPropertyChanging("ShowingDate");
                _ShowingDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ShowingDate");
                OnShowingDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _ShowingDate;
        partial void OnShowingDateChanging(Nullable<global::System.DateTime> value);
        partial void OnShowingDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Screen
        {
            get
            {
                return _Screen;
            }
            set
            {
                OnScreenChanging(value);
                ReportPropertyChanging("Screen");
                _Screen = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Screen");
                OnScreenChanged();
            }
        }
        private Nullable<global::System.Int32> _Screen;
        partial void OnScreenChanging(Nullable<global::System.Int32> value);
        partial void OnScreenChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookModel", "FK_FilmShowing_Film", "Film")]
        public Film Film
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Film>("BookModel.FK_FilmShowing_Film", "Film").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Film>("BookModel.FK_FilmShowing_Film", "Film").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Film> FilmReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Film>("BookModel.FK_FilmShowing_Film", "Film");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Film>("BookModel.FK_FilmShowing_Film", "Film", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookModel", "FK_OrderItem_FilmShowing", "OrderItem")]
        public EntityCollection<OrderItem> OrderItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderItem>("BookModel.FK_OrderItem_FilmShowing", "OrderItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderItem>("BookModel.FK_OrderItem_FilmShowing", "OrderItem", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BookModel", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderID">Initial value of the OrderID property.</param>
        public static Order CreateOrder(global::System.Int32 orderID)
        {
            Order order = new Order();
            order.OrderID = orderID;
            return order;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                if (_OrderID != value)
                {
                    OnOrderIDChanging(value);
                    ReportPropertyChanging("OrderID");
                    _OrderID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderID");
                    OnOrderIDChanged();
                }
            }
        }
        private global::System.Int32 _OrderID;
        partial void OnOrderIDChanging(global::System.Int32 value);
        partial void OnOrderIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String OrderNumber
        {
            get
            {
                return _OrderNumber;
            }
            set
            {
                OnOrderNumberChanging(value);
                ReportPropertyChanging("OrderNumber");
                _OrderNumber = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("OrderNumber");
                OnOrderNumberChanged();
            }
        }
        private global::System.String _OrderNumber;
        partial void OnOrderNumberChanging(global::System.String value);
        partial void OnOrderNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                OnOrderDateChanging(value);
                ReportPropertyChanging("OrderDate");
                _OrderDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderDate");
                OnOrderDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _OrderDate;
        partial void OnOrderDateChanging(Nullable<global::System.DateTime> value);
        partial void OnOrderDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Firstname
        {
            get
            {
                return _Firstname;
            }
            set
            {
                OnFirstnameChanging(value);
                ReportPropertyChanging("Firstname");
                _Firstname = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Firstname");
                OnFirstnameChanged();
            }
        }
        private global::System.String _Firstname;
        partial void OnFirstnameChanging(global::System.String value);
        partial void OnFirstnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Lastname
        {
            get
            {
                return _Lastname;
            }
            set
            {
                OnLastnameChanging(value);
                ReportPropertyChanging("Lastname");
                _Lastname = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Lastname");
                OnLastnameChanged();
            }
        }
        private global::System.String _Lastname;
        partial void OnLastnameChanging(global::System.String value);
        partial void OnLastnameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookModel", "FK_OrderItem_Order", "OrderItem")]
        public EntityCollection<OrderItem> OrderItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<OrderItem>("BookModel.FK_OrderItem_Order", "OrderItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<OrderItem>("BookModel.FK_OrderItem_Order", "OrderItem", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BookModel", Name="OrderItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OrderItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new OrderItem object.
        /// </summary>
        /// <param name="orderItemID">Initial value of the OrderItemID property.</param>
        public static OrderItem CreateOrderItem(global::System.Int32 orderItemID)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.OrderItemID = orderItemID;
            return orderItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderItemID
        {
            get
            {
                return _OrderItemID;
            }
            set
            {
                if (_OrderItemID != value)
                {
                    OnOrderItemIDChanging(value);
                    ReportPropertyChanging("OrderItemID");
                    _OrderItemID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderItemID");
                    OnOrderItemIDChanged();
                }
            }
        }
        private global::System.Int32 _OrderItemID;
        partial void OnOrderItemIDChanging(global::System.Int32 value);
        partial void OnOrderItemIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                OnOrderIDChanging(value);
                ReportPropertyChanging("OrderID");
                _OrderID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderID");
                OnOrderIDChanged();
            }
        }
        private Nullable<global::System.Int32> _OrderID;
        partial void OnOrderIDChanging(Nullable<global::System.Int32> value);
        partial void OnOrderIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> FilmShowingID
        {
            get
            {
                return _FilmShowingID;
            }
            set
            {
                OnFilmShowingIDChanging(value);
                ReportPropertyChanging("FilmShowingID");
                _FilmShowingID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FilmShowingID");
                OnFilmShowingIDChanged();
            }
        }
        private Nullable<global::System.Int32> _FilmShowingID;
        partial void OnFilmShowingIDChanging(Nullable<global::System.Int32> value);
        partial void OnFilmShowingIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> QtyAdult
        {
            get
            {
                return _QtyAdult;
            }
            set
            {
                OnQtyAdultChanging(value);
                ReportPropertyChanging("QtyAdult");
                _QtyAdult = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QtyAdult");
                OnQtyAdultChanged();
            }
        }
        private Nullable<global::System.Int32> _QtyAdult;
        partial void OnQtyAdultChanging(Nullable<global::System.Int32> value);
        partial void OnQtyAdultChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> QtyChild
        {
            get
            {
                return _QtyChild;
            }
            set
            {
                OnQtyChildChanging(value);
                ReportPropertyChanging("QtyChild");
                _QtyChild = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QtyChild");
                OnQtyChildChanged();
            }
        }
        private Nullable<global::System.Int32> _QtyChild;
        partial void OnQtyChildChanging(Nullable<global::System.Int32> value);
        partial void OnQtyChildChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookModel", "FK_OrderItem_FilmShowing", "FilmShowing")]
        public FilmShowing FilmShowing
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FilmShowing>("BookModel.FK_OrderItem_FilmShowing", "FilmShowing").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FilmShowing>("BookModel.FK_OrderItem_FilmShowing", "FilmShowing").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<FilmShowing> FilmShowingReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FilmShowing>("BookModel.FK_OrderItem_FilmShowing", "FilmShowing");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<FilmShowing>("BookModel.FK_OrderItem_FilmShowing", "FilmShowing", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BookModel", "FK_OrderItem_Order", "Order")]
        public Order Order
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("BookModel.FK_OrderItem_Order", "Order").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("BookModel.FK_OrderItem_Order", "Order").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Order> OrderReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Order>("BookModel.FK_OrderItem_Order", "Order");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Order>("BookModel.FK_OrderItem_Order", "Order", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
