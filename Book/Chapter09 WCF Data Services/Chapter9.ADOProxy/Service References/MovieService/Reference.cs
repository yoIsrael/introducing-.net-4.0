//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30128.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 13/02/2010 17:03:03
namespace Chapter9.ADOProxy.MovieService
{
    
    /// <summary>
    /// There are no comments for BookEntities in the schema.
    /// </summary>
    public partial class BookEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new BookEntities object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public BookEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("BookModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Chapter9.ADOProxy.MovieService", typeName.Substring(9)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Chapter9.ADOProxy.MovieService", global::System.StringComparison.Ordinal))
            {
                return string.Concat("BookModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Films in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Film> Films
        {
            get
            {
                if ((this._Films == null))
                {
                    this._Films = base.CreateQuery<Film>("Films");
                }
                return this._Films;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Film> _Films;
        /// <summary>
        /// There are no comments for FilmShowings in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<FilmShowing> FilmShowings
        {
            get
            {
                if ((this._FilmShowings == null))
                {
                    this._FilmShowings = base.CreateQuery<FilmShowing>("FilmShowings");
                }
                return this._FilmShowings;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<FilmShowing> _FilmShowings;
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Order> Orders
        {
            get
            {
                if ((this._Orders == null))
                {
                    this._Orders = base.CreateQuery<Order>("Orders");
                }
                return this._Orders;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Order> _Orders;
        /// <summary>
        /// There are no comments for OrderItems in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<OrderItem> OrderItems
        {
            get
            {
                if ((this._OrderItems == null))
                {
                    this._OrderItems = base.CreateQuery<OrderItem>("OrderItems");
                }
                return this._OrderItems;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<OrderItem> _OrderItems;
        /// <summary>
        /// There are no comments for Films in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToFilms(Film film)
        {
            base.AddObject("Films", film);
        }
        /// <summary>
        /// There are no comments for FilmShowings in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToFilmShowings(FilmShowing filmShowing)
        {
            base.AddObject("FilmShowings", filmShowing);
        }
        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }
        /// <summary>
        /// There are no comments for OrderItems in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToOrderItems(OrderItem orderItem)
        {
            base.AddObject("OrderItems", orderItem);
        }
    }
    /// <summary>
    /// There are no comments for BookModel.Film in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FilmID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Films")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("FilmID")]
    public partial class Film : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Film object.
        /// </summary>
        /// <param name="filmID">Initial value of FilmID.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Film CreateFilm(int filmID)
        {
            Film film = new Film();
            film.FilmID = filmID;
            return film;
        }
        /// <summary>
        /// There are no comments for Property FilmID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int FilmID
        {
            get
            {
                return this._FilmID;
            }
            set
            {
                this.OnFilmIDChanging(value);
                this._FilmID = value;
                this.OnFilmIDChanged();
                this.OnPropertyChanged("FilmID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _FilmID;
        partial void OnFilmIDChanging(int value);
        partial void OnFilmIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Length in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Length
        {
            get
            {
                return this._Length;
            }
            set
            {
                this.OnLengthChanging(value);
                this._Length = value;
                this.OnLengthChanged();
                this.OnPropertyChanged("Length");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Length;
        partial void OnLengthChanging(global::System.Nullable<int> value);
        partial void OnLengthChanged();
        /// <summary>
        /// There are no comments for FilmShowings in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<FilmShowing> FilmShowings
        {
            get
            {
                return this._FilmShowings;
            }
            set
            {
                this._FilmShowings = value;
                this.OnPropertyChanged("FilmShowings");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<FilmShowing> _FilmShowings = new global::System.Data.Services.Client.DataServiceCollection<FilmShowing>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for BookModel.FilmShowing in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FilmShowingID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("FilmShowings")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("FilmShowingID")]
    public partial class FilmShowing : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FilmShowing object.
        /// </summary>
        /// <param name="filmShowingID">Initial value of FilmShowingID.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static FilmShowing CreateFilmShowing(int filmShowingID)
        {
            FilmShowing filmShowing = new FilmShowing();
            filmShowing.FilmShowingID = filmShowingID;
            return filmShowing;
        }
        /// <summary>
        /// There are no comments for Property FilmShowingID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int FilmShowingID
        {
            get
            {
                return this._FilmShowingID;
            }
            set
            {
                this.OnFilmShowingIDChanging(value);
                this._FilmShowingID = value;
                this.OnFilmShowingIDChanged();
                this.OnPropertyChanged("FilmShowingID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _FilmShowingID;
        partial void OnFilmShowingIDChanging(int value);
        partial void OnFilmShowingIDChanged();
        /// <summary>
        /// There are no comments for Property FilmID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> FilmID
        {
            get
            {
                return this._FilmID;
            }
            set
            {
                this.OnFilmIDChanging(value);
                this._FilmID = value;
                this.OnFilmIDChanged();
                this.OnPropertyChanged("FilmID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _FilmID;
        partial void OnFilmIDChanging(global::System.Nullable<int> value);
        partial void OnFilmIDChanged();
        /// <summary>
        /// There are no comments for Property ShowingDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> ShowingDate
        {
            get
            {
                return this._ShowingDate;
            }
            set
            {
                this.OnShowingDateChanging(value);
                this._ShowingDate = value;
                this.OnShowingDateChanged();
                this.OnPropertyChanged("ShowingDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _ShowingDate;
        partial void OnShowingDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnShowingDateChanged();
        /// <summary>
        /// There are no comments for Property Screen in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Screen
        {
            get
            {
                return this._Screen;
            }
            set
            {
                this.OnScreenChanging(value);
                this._Screen = value;
                this.OnScreenChanged();
                this.OnPropertyChanged("Screen");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Screen;
        partial void OnScreenChanging(global::System.Nullable<int> value);
        partial void OnScreenChanged();
        /// <summary>
        /// There are no comments for Film in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Film Film
        {
            get
            {
                return this._Film;
            }
            set
            {
                this._Film = value;
                this.OnPropertyChanged("Film");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Film _Film;
        /// <summary>
        /// There are no comments for OrderItems in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<OrderItem> OrderItems
        {
            get
            {
                return this._OrderItems;
            }
            set
            {
                this._OrderItems = value;
                this.OnPropertyChanged("OrderItems");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<OrderItem> _OrderItems = new global::System.Data.Services.Client.DataServiceCollection<OrderItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for BookModel.Order in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OrderID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Orders")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("OrderID")]
    public partial class Order : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderID">Initial value of OrderID.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Order CreateOrder(int orderID)
        {
            Order order = new Order();
            order.OrderID = orderID;
            return order;
        }
        /// <summary>
        /// There are no comments for Property OrderID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this.OnOrderIDChanging(value);
                this._OrderID = value;
                this.OnOrderIDChanged();
                this.OnPropertyChanged("OrderID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _OrderID;
        partial void OnOrderIDChanging(int value);
        partial void OnOrderIDChanged();
        /// <summary>
        /// There are no comments for Property OrderNumber in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string OrderNumber
        {
            get
            {
                return this._OrderNumber;
            }
            set
            {
                this.OnOrderNumberChanging(value);
                this._OrderNumber = value;
                this.OnOrderNumberChanged();
                this.OnPropertyChanged("OrderNumber");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _OrderNumber;
        partial void OnOrderNumberChanging(string value);
        partial void OnOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property OrderDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> OrderDate
        {
            get
            {
                return this._OrderDate;
            }
            set
            {
                this.OnOrderDateChanging(value);
                this._OrderDate = value;
                this.OnOrderDateChanged();
                this.OnPropertyChanged("OrderDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _OrderDate;
        partial void OnOrderDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnOrderDateChanged();
        /// <summary>
        /// There are no comments for Property Firstname in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Firstname
        {
            get
            {
                return this._Firstname;
            }
            set
            {
                this.OnFirstnameChanging(value);
                this._Firstname = value;
                this.OnFirstnameChanged();
                this.OnPropertyChanged("Firstname");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Firstname;
        partial void OnFirstnameChanging(string value);
        partial void OnFirstnameChanged();
        /// <summary>
        /// There are no comments for Property Lastname in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Lastname
        {
            get
            {
                return this._Lastname;
            }
            set
            {
                this.OnLastnameChanging(value);
                this._Lastname = value;
                this.OnLastnameChanged();
                this.OnPropertyChanged("Lastname");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Lastname;
        partial void OnLastnameChanging(string value);
        partial void OnLastnameChanged();
        /// <summary>
        /// There are no comments for OrderItems in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<OrderItem> OrderItems
        {
            get
            {
                return this._OrderItems;
            }
            set
            {
                this._OrderItems = value;
                this.OnPropertyChanged("OrderItems");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<OrderItem> _OrderItems = new global::System.Data.Services.Client.DataServiceCollection<OrderItem>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for BookModel.OrderItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OrderItemID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("OrderItems")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("OrderItemID")]
    public partial class OrderItem : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OrderItem object.
        /// </summary>
        /// <param name="orderItemID">Initial value of OrderItemID.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static OrderItem CreateOrderItem(int orderItemID)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.OrderItemID = orderItemID;
            return orderItem;
        }
        /// <summary>
        /// There are no comments for Property OrderItemID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int OrderItemID
        {
            get
            {
                return this._OrderItemID;
            }
            set
            {
                this.OnOrderItemIDChanging(value);
                this._OrderItemID = value;
                this.OnOrderItemIDChanged();
                this.OnPropertyChanged("OrderItemID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _OrderItemID;
        partial void OnOrderItemIDChanging(int value);
        partial void OnOrderItemIDChanged();
        /// <summary>
        /// There are no comments for Property OrderID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> OrderID
        {
            get
            {
                return this._OrderID;
            }
            set
            {
                this.OnOrderIDChanging(value);
                this._OrderID = value;
                this.OnOrderIDChanged();
                this.OnPropertyChanged("OrderID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _OrderID;
        partial void OnOrderIDChanging(global::System.Nullable<int> value);
        partial void OnOrderIDChanged();
        /// <summary>
        /// There are no comments for Property FilmShowingID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> FilmShowingID
        {
            get
            {
                return this._FilmShowingID;
            }
            set
            {
                this.OnFilmShowingIDChanging(value);
                this._FilmShowingID = value;
                this.OnFilmShowingIDChanged();
                this.OnPropertyChanged("FilmShowingID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _FilmShowingID;
        partial void OnFilmShowingIDChanging(global::System.Nullable<int> value);
        partial void OnFilmShowingIDChanged();
        /// <summary>
        /// There are no comments for Property QtyAdult in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> QtyAdult
        {
            get
            {
                return this._QtyAdult;
            }
            set
            {
                this.OnQtyAdultChanging(value);
                this._QtyAdult = value;
                this.OnQtyAdultChanged();
                this.OnPropertyChanged("QtyAdult");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _QtyAdult;
        partial void OnQtyAdultChanging(global::System.Nullable<int> value);
        partial void OnQtyAdultChanged();
        /// <summary>
        /// There are no comments for Property QtyChild in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> QtyChild
        {
            get
            {
                return this._QtyChild;
            }
            set
            {
                this.OnQtyChildChanging(value);
                this._QtyChild = value;
                this.OnQtyChildChanged();
                this.OnPropertyChanged("QtyChild");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _QtyChild;
        partial void OnQtyChildChanging(global::System.Nullable<int> value);
        partial void OnQtyChildChanged();
        /// <summary>
        /// There are no comments for FilmShowing in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public FilmShowing FilmShowing
        {
            get
            {
                return this._FilmShowing;
            }
            set
            {
                this._FilmShowing = value;
                this.OnPropertyChanged("FilmShowing");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private FilmShowing _FilmShowing;
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Order Order
        {
            get
            {
                return this._Order;
            }
            set
            {
                this._Order = value;
                this.OnPropertyChanged("Order");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Order _Order;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
