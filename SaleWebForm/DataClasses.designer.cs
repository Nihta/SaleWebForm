#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleWebForm
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbWebProject")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblBrand(tblBrand instance);
    partial void UpdatetblBrand(tblBrand instance);
    partial void DeletetblBrand(tblBrand instance);
    partial void InserttbpProductImage(tbpProductImage instance);
    partial void UpdatetbpProductImage(tbpProductImage instance);
    partial void DeletetbpProductImage(tbpProductImage instance);
    partial void InserttblCategory(tblCategory instance);
    partial void UpdatetblCategory(tblCategory instance);
    partial void DeletetblCategory(tblCategory instance);
    partial void InserttblOrder(tblOrder instance);
    partial void UpdatetblOrder(tblOrder instance);
    partial void DeletetblOrder(tblOrder instance);
    partial void InserttblOrderDetail(tblOrderDetail instance);
    partial void UpdatetblOrderDetail(tblOrderDetail instance);
    partial void DeletetblOrderDetail(tblOrderDetail instance);
    partial void InserttblProduct(tblProduct instance);
    partial void UpdatetblProduct(tblProduct instance);
    partial void DeletetblProduct(tblProduct instance);
    partial void InserttblUser(tblUser instance);
    partial void UpdatetblUser(tblUser instance);
    partial void DeletetblUser(tblUser instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dbWebProjectConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblBrand> tblBrands
		{
			get
			{
				return this.GetTable<tblBrand>();
			}
		}
		
		public System.Data.Linq.Table<tbpProductImage> tbpProductImages
		{
			get
			{
				return this.GetTable<tbpProductImage>();
			}
		}
		
		public System.Data.Linq.Table<tblCategory> tblCategories
		{
			get
			{
				return this.GetTable<tblCategory>();
			}
		}
		
		public System.Data.Linq.Table<tblOrder> tblOrders
		{
			get
			{
				return this.GetTable<tblOrder>();
			}
		}
		
		public System.Data.Linq.Table<tblOrderDetail> tblOrderDetails
		{
			get
			{
				return this.GetTable<tblOrderDetail>();
			}
		}
		
		public System.Data.Linq.Table<tblProduct> tblProducts
		{
			get
			{
				return this.GetTable<tblProduct>();
			}
		}
		
		public System.Data.Linq.Table<tblUser> tblUsers
		{
			get
			{
				return this.GetTable<tblUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblBrand")]
	public partial class tblBrand : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _brandId;
		
		private string _name;
		
		private string _description;
		
		private EntitySet<tblProduct> _tblProducts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbrandIdChanging(int value);
    partial void OnbrandIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public tblBrand()
		{
			this._tblProducts = new EntitySet<tblProduct>(new Action<tblProduct>(this.attach_tblProducts), new Action<tblProduct>(this.detach_tblProducts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brandId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int brandId
		{
			get
			{
				return this._brandId;
			}
			set
			{
				if ((this._brandId != value))
				{
					this.OnbrandIdChanging(value);
					this.SendPropertyChanging();
					this._brandId = value;
					this.SendPropertyChanged("brandId");
					this.OnbrandIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(100)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblBrand_tblProduct", Storage="_tblProducts", ThisKey="brandId", OtherKey="brandId")]
		public EntitySet<tblProduct> tblProducts
		{
			get
			{
				return this._tblProducts;
			}
			set
			{
				this._tblProducts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblProducts(tblProduct entity)
		{
			this.SendPropertyChanging();
			entity.tblBrand = this;
		}
		
		private void detach_tblProducts(tblProduct entity)
		{
			this.SendPropertyChanging();
			entity.tblBrand = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbpProductImage")]
	public partial class tbpProductImage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _productImageId;
		
		private System.Data.Linq.Binary _image;
		
		private int _productId;
		
		private EntityRef<tblProduct> _tblProduct;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnproductImageIdChanging(int value);
    partial void OnproductImageIdChanged();
    partial void OnimageChanging(System.Data.Linq.Binary value);
    partial void OnimageChanged();
    partial void OnproductIdChanging(int value);
    partial void OnproductIdChanged();
    #endregion
		
		public tbpProductImage()
		{
			this._tblProduct = default(EntityRef<tblProduct>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productImageId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int productImageId
		{
			get
			{
				return this._productImageId;
			}
			set
			{
				if ((this._productImageId != value))
				{
					this.OnproductImageIdChanging(value);
					this.SendPropertyChanging();
					this._productImageId = value;
					this.SendPropertyChanged("productImageId");
					this.OnproductImageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary image
		{
			get
			{
				return this._image;
			}
			set
			{
				if ((this._image != value))
				{
					this.OnimageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("image");
					this.OnimageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productId", DbType="Int NOT NULL")]
		public int productId
		{
			get
			{
				return this._productId;
			}
			set
			{
				if ((this._productId != value))
				{
					if (this._tblProduct.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIdChanging(value);
					this.SendPropertyChanging();
					this._productId = value;
					this.SendPropertyChanged("productId");
					this.OnproductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblProduct_tbpProductImage", Storage="_tblProduct", ThisKey="productId", OtherKey="productId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public tblProduct tblProduct
		{
			get
			{
				return this._tblProduct.Entity;
			}
			set
			{
				tblProduct previousValue = this._tblProduct.Entity;
				if (((previousValue != value) 
							|| (this._tblProduct.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblProduct.Entity = null;
						previousValue.tbpProductImages.Remove(this);
					}
					this._tblProduct.Entity = value;
					if ((value != null))
					{
						value.tbpProductImages.Add(this);
						this._productId = value.productId;
					}
					else
					{
						this._productId = default(int);
					}
					this.SendPropertyChanged("tblProduct");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCategory")]
	public partial class tblCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _categoryId;
		
		private string _name;
		
		private string _description;
		
		private EntitySet<tblProduct> _tblProducts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncategoryIdChanging(int value);
    partial void OncategoryIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public tblCategory()
		{
			this._tblProducts = new EntitySet<tblProduct>(new Action<tblProduct>(this.attach_tblProducts), new Action<tblProduct>(this.detach_tblProducts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int categoryId
		{
			get
			{
				return this._categoryId;
			}
			set
			{
				if ((this._categoryId != value))
				{
					this.OncategoryIdChanging(value);
					this.SendPropertyChanging();
					this._categoryId = value;
					this.SendPropertyChanged("categoryId");
					this.OncategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(100)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCategory_tblProduct", Storage="_tblProducts", ThisKey="categoryId", OtherKey="categoryId")]
		public EntitySet<tblProduct> tblProducts
		{
			get
			{
				return this._tblProducts;
			}
			set
			{
				this._tblProducts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblProducts(tblProduct entity)
		{
			this.SendPropertyChanging();
			entity.tblCategory = this;
		}
		
		private void detach_tblProducts(tblProduct entity)
		{
			this.SendPropertyChanging();
			entity.tblCategory = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblOrder")]
	public partial class tblOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _orderId;
		
		private string _orderDate;
		
		private int _userId;
		
		private EntitySet<tblOrderDetail> _tblOrderDetails;
		
		private EntityRef<tblUser> _tblUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnorderIdChanging(int value);
    partial void OnorderIdChanged();
    partial void OnorderDateChanging(string value);
    partial void OnorderDateChanged();
    partial void OnuserIdChanging(int value);
    partial void OnuserIdChanged();
    #endregion
		
		public tblOrder()
		{
			this._tblOrderDetails = new EntitySet<tblOrderDetail>(new Action<tblOrderDetail>(this.attach_tblOrderDetails), new Action<tblOrderDetail>(this.detach_tblOrderDetails));
			this._tblUser = default(EntityRef<tblUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int orderId
		{
			get
			{
				return this._orderId;
			}
			set
			{
				if ((this._orderId != value))
				{
					this.OnorderIdChanging(value);
					this.SendPropertyChanging();
					this._orderId = value;
					this.SendPropertyChanged("orderId");
					this.OnorderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderDate", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string orderDate
		{
			get
			{
				return this._orderDate;
			}
			set
			{
				if ((this._orderDate != value))
				{
					this.OnorderDateChanging(value);
					this.SendPropertyChanging();
					this._orderDate = value;
					this.SendPropertyChanged("orderDate");
					this.OnorderDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="Int NOT NULL")]
		public int userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					if (this._tblUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblOrder_tblOrderDetail", Storage="_tblOrderDetails", ThisKey="orderId", OtherKey="orderId")]
		public EntitySet<tblOrderDetail> tblOrderDetails
		{
			get
			{
				return this._tblOrderDetails;
			}
			set
			{
				this._tblOrderDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblOrder", Storage="_tblUser", ThisKey="userId", OtherKey="userId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public tblUser tblUser
		{
			get
			{
				return this._tblUser.Entity;
			}
			set
			{
				tblUser previousValue = this._tblUser.Entity;
				if (((previousValue != value) 
							|| (this._tblUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblUser.Entity = null;
						previousValue.tblOrders.Remove(this);
					}
					this._tblUser.Entity = value;
					if ((value != null))
					{
						value.tblOrders.Add(this);
						this._userId = value.userId;
					}
					else
					{
						this._userId = default(int);
					}
					this.SendPropertyChanged("tblUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblOrderDetails(tblOrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.tblOrder = this;
		}
		
		private void detach_tblOrderDetails(tblOrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.tblOrder = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblOrderDetail")]
	public partial class tblOrderDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _orderDetailid;
		
		private int _quantity;
		
		private string _note;
		
		private int _orderId;
		
		private int _productId;
		
		private EntityRef<tblOrder> _tblOrder;
		
		private EntityRef<tblProduct> _tblProduct;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnorderDetailidChanging(int value);
    partial void OnorderDetailidChanged();
    partial void OnquantityChanging(int value);
    partial void OnquantityChanged();
    partial void OnnoteChanging(string value);
    partial void OnnoteChanged();
    partial void OnorderIdChanging(int value);
    partial void OnorderIdChanged();
    partial void OnproductIdChanging(int value);
    partial void OnproductIdChanged();
    #endregion
		
		public tblOrderDetail()
		{
			this._tblOrder = default(EntityRef<tblOrder>);
			this._tblProduct = default(EntityRef<tblProduct>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderDetailid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int orderDetailid
		{
			get
			{
				return this._orderDetailid;
			}
			set
			{
				if ((this._orderDetailid != value))
				{
					this.OnorderDetailidChanging(value);
					this.SendPropertyChanging();
					this._orderDetailid = value;
					this.SendPropertyChanged("orderDetailid");
					this.OnorderDetailidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int NOT NULL")]
		public int quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_note", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string note
		{
			get
			{
				return this._note;
			}
			set
			{
				if ((this._note != value))
				{
					this.OnnoteChanging(value);
					this.SendPropertyChanging();
					this._note = value;
					this.SendPropertyChanged("note");
					this.OnnoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderId", DbType="Int NOT NULL")]
		public int orderId
		{
			get
			{
				return this._orderId;
			}
			set
			{
				if ((this._orderId != value))
				{
					if (this._tblOrder.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnorderIdChanging(value);
					this.SendPropertyChanging();
					this._orderId = value;
					this.SendPropertyChanged("orderId");
					this.OnorderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productId", DbType="Int NOT NULL")]
		public int productId
		{
			get
			{
				return this._productId;
			}
			set
			{
				if ((this._productId != value))
				{
					if (this._tblProduct.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIdChanging(value);
					this.SendPropertyChanging();
					this._productId = value;
					this.SendPropertyChanged("productId");
					this.OnproductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblOrder_tblOrderDetail", Storage="_tblOrder", ThisKey="orderId", OtherKey="orderId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public tblOrder tblOrder
		{
			get
			{
				return this._tblOrder.Entity;
			}
			set
			{
				tblOrder previousValue = this._tblOrder.Entity;
				if (((previousValue != value) 
							|| (this._tblOrder.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblOrder.Entity = null;
						previousValue.tblOrderDetails.Remove(this);
					}
					this._tblOrder.Entity = value;
					if ((value != null))
					{
						value.tblOrderDetails.Add(this);
						this._orderId = value.orderId;
					}
					else
					{
						this._orderId = default(int);
					}
					this.SendPropertyChanged("tblOrder");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblProduct_tblOrderDetail", Storage="_tblProduct", ThisKey="productId", OtherKey="productId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public tblProduct tblProduct
		{
			get
			{
				return this._tblProduct.Entity;
			}
			set
			{
				tblProduct previousValue = this._tblProduct.Entity;
				if (((previousValue != value) 
							|| (this._tblProduct.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblProduct.Entity = null;
						previousValue.tblOrderDetails.Remove(this);
					}
					this._tblProduct.Entity = value;
					if ((value != null))
					{
						value.tblOrderDetails.Add(this);
						this._productId = value.productId;
					}
					else
					{
						this._productId = default(int);
					}
					this.SendPropertyChanged("tblProduct");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblProduct")]
	public partial class tblProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _productId;
		
		private string _name;
		
		private int _price;
		
		private int _amount;
		
		private string _description;
		
		private int _categoryId;
		
		private int _brandId;
		
		private int _status;
		
		private EntitySet<tbpProductImage> _tbpProductImages;
		
		private EntitySet<tblOrderDetail> _tblOrderDetails;
		
		private EntityRef<tblBrand> _tblBrand;
		
		private EntityRef<tblCategory> _tblCategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnproductIdChanging(int value);
    partial void OnproductIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpriceChanging(int value);
    partial void OnpriceChanged();
    partial void OnamountChanging(int value);
    partial void OnamountChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OncategoryIdChanging(int value);
    partial void OncategoryIdChanged();
    partial void OnbrandIdChanging(int value);
    partial void OnbrandIdChanged();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    #endregion
		
		public tblProduct()
		{
			this._tbpProductImages = new EntitySet<tbpProductImage>(new Action<tbpProductImage>(this.attach_tbpProductImages), new Action<tbpProductImage>(this.detach_tbpProductImages));
			this._tblOrderDetails = new EntitySet<tblOrderDetail>(new Action<tblOrderDetail>(this.attach_tblOrderDetails), new Action<tblOrderDetail>(this.detach_tblOrderDetails));
			this._tblBrand = default(EntityRef<tblBrand>);
			this._tblCategory = default(EntityRef<tblCategory>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int productId
		{
			get
			{
				return this._productId;
			}
			set
			{
				if ((this._productId != value))
				{
					this.OnproductIdChanging(value);
					this.SendPropertyChanging();
					this._productId = value;
					this.SendPropertyChanged("productId");
					this.OnproductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Int NOT NULL")]
		public int price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Int NOT NULL")]
		public int amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryId", DbType="Int NOT NULL")]
		public int categoryId
		{
			get
			{
				return this._categoryId;
			}
			set
			{
				if ((this._categoryId != value))
				{
					if (this._tblCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncategoryIdChanging(value);
					this.SendPropertyChanging();
					this._categoryId = value;
					this.SendPropertyChanged("categoryId");
					this.OncategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brandId", DbType="Int NOT NULL")]
		public int brandId
		{
			get
			{
				return this._brandId;
			}
			set
			{
				if ((this._brandId != value))
				{
					if (this._tblBrand.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnbrandIdChanging(value);
					this.SendPropertyChanging();
					this._brandId = value;
					this.SendPropertyChanged("brandId");
					this.OnbrandIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL")]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblProduct_tbpProductImage", Storage="_tbpProductImages", ThisKey="productId", OtherKey="productId")]
		public EntitySet<tbpProductImage> tbpProductImages
		{
			get
			{
				return this._tbpProductImages;
			}
			set
			{
				this._tbpProductImages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblProduct_tblOrderDetail", Storage="_tblOrderDetails", ThisKey="productId", OtherKey="productId")]
		public EntitySet<tblOrderDetail> tblOrderDetails
		{
			get
			{
				return this._tblOrderDetails;
			}
			set
			{
				this._tblOrderDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblBrand_tblProduct", Storage="_tblBrand", ThisKey="brandId", OtherKey="brandId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public tblBrand tblBrand
		{
			get
			{
				return this._tblBrand.Entity;
			}
			set
			{
				tblBrand previousValue = this._tblBrand.Entity;
				if (((previousValue != value) 
							|| (this._tblBrand.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblBrand.Entity = null;
						previousValue.tblProducts.Remove(this);
					}
					this._tblBrand.Entity = value;
					if ((value != null))
					{
						value.tblProducts.Add(this);
						this._brandId = value.brandId;
					}
					else
					{
						this._brandId = default(int);
					}
					this.SendPropertyChanged("tblBrand");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCategory_tblProduct", Storage="_tblCategory", ThisKey="categoryId", OtherKey="categoryId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public tblCategory tblCategory
		{
			get
			{
				return this._tblCategory.Entity;
			}
			set
			{
				tblCategory previousValue = this._tblCategory.Entity;
				if (((previousValue != value) 
							|| (this._tblCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblCategory.Entity = null;
						previousValue.tblProducts.Remove(this);
					}
					this._tblCategory.Entity = value;
					if ((value != null))
					{
						value.tblProducts.Add(this);
						this._categoryId = value.categoryId;
					}
					else
					{
						this._categoryId = default(int);
					}
					this.SendPropertyChanged("tblCategory");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tbpProductImages(tbpProductImage entity)
		{
			this.SendPropertyChanging();
			entity.tblProduct = this;
		}
		
		private void detach_tbpProductImages(tbpProductImage entity)
		{
			this.SendPropertyChanging();
			entity.tblProduct = null;
		}
		
		private void attach_tblOrderDetails(tblOrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.tblProduct = this;
		}
		
		private void detach_tblOrderDetails(tblOrderDetail entity)
		{
			this.SendPropertyChanging();
			entity.tblProduct = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUser")]
	public partial class tblUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userId;
		
		private string _fullName;
		
		private string _userName;
		
		private string _passWord;
		
		private string _email;
		
		private int _role;
		
		private EntitySet<tblOrder> _tblOrders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIdChanging(int value);
    partial void OnuserIdChanged();
    partial void OnfullNameChanging(string value);
    partial void OnfullNameChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void OnpassWordChanging(string value);
    partial void OnpassWordChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnroleChanging(int value);
    partial void OnroleChanged();
    #endregion
		
		public tblUser()
		{
			this._tblOrders = new EntitySet<tblOrder>(new Action<tblOrder>(this.attach_tblOrders), new Action<tblOrder>(this.detach_tblOrders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this.OnfullNameChanging(value);
					this.SendPropertyChanging();
					this._fullName = value;
					this.SendPropertyChanged("fullName");
					this.OnfullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this.OnuserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("userName");
					this.OnuserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passWord", DbType="VarChar(32) NOT NULL", CanBeNull=false)]
		public string passWord
		{
			get
			{
				return this._passWord;
			}
			set
			{
				if ((this._passWord != value))
				{
					this.OnpassWordChanging(value);
					this.SendPropertyChanging();
					this._passWord = value;
					this.SendPropertyChanged("passWord");
					this.OnpassWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NChar(40)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="Int NOT NULL")]
		public int role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblOrder", Storage="_tblOrders", ThisKey="userId", OtherKey="userId")]
		public EntitySet<tblOrder> tblOrders
		{
			get
			{
				return this._tblOrders;
			}
			set
			{
				this._tblOrders.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblOrders(tblOrder entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = this;
		}
		
		private void detach_tblOrders(tblOrder entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = null;
		}
	}
}
#pragma warning restore 1591
