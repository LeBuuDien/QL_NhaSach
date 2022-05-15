﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNhaSach.DTO.MODEL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bookshop")]
	public partial class QLNSDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSTAFF(STAFF instance);
    partial void UpdateSTAFF(STAFF instance);
    partial void DeleteSTAFF(STAFF instance);
    partial void InsertDOANHTHU(DOANHTHU instance);
    partial void UpdateDOANHTHU(DOANHTHU instance);
    partial void DeleteDOANHTHU(DOANHTHU instance);
    partial void InsertCUSTOMER(CUSTOMER instance);
    partial void UpdateCUSTOMER(CUSTOMER instance);
    partial void DeleteCUSTOMER(CUSTOMER instance);
    partial void InsertBOOK(BOOK instance);
    partial void UpdateBOOK(BOOK instance);
    partial void DeleteBOOK(BOOK instance);
    partial void InsertBillinfo(Billinfo instance);
    partial void UpdateBillinfo(Billinfo instance);
    partial void DeleteBillinfo(Billinfo instance);
    partial void InsertBILL(BILL instance);
    partial void UpdateBILL(BILL instance);
    partial void DeleteBILL(BILL instance);
    partial void InsertACCOUNT(ACCOUNT instance);
    partial void UpdateACCOUNT(ACCOUNT instance);
    partial void DeleteACCOUNT(ACCOUNT instance);
    #endregion
		
		public QLNSDataContext() : 
				base(global::QLNhaSach.Properties.Settings.Default.BookshopConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLNSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLNSDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLNSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLNSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<STAFF> STAFFs
		{
			get
			{
				return this.GetTable<STAFF>();
			}
		}
		
		public System.Data.Linq.Table<DOANHTHU> DOANHTHUs
		{
			get
			{
				return this.GetTable<DOANHTHU>();
			}
		}
		
		public System.Data.Linq.Table<CUSTOMER> CUSTOMERs
		{
			get
			{
				return this.GetTable<CUSTOMER>();
			}
		}
		
		public System.Data.Linq.Table<BOOK> BOOKs
		{
			get
			{
				return this.GetTable<BOOK>();
			}
		}
		
		public System.Data.Linq.Table<Billinfo> Billinfos
		{
			get
			{
				return this.GetTable<Billinfo>();
			}
		}
		
		public System.Data.Linq.Table<BILL> BILLs
		{
			get
			{
				return this.GetTable<BILL>();
			}
		}
		
		public System.Data.Linq.Table<ACCOUNT> ACCOUNTs
		{
			get
			{
				return this.GetTable<ACCOUNT>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.STAFF")]
	public partial class STAFF : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNV;
		
		private string _TenNV;
		
		private string _SDT;
		
		private string _Email;
		
		private string _address;
		
		private string _Username;
		
		private EntityRef<ACCOUNT> _ACCOUNT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(string value);
    partial void OnMaNVChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    #endregion
		
		public STAFF()
		{
			this._ACCOUNT = default(EntityRef<ACCOUNT>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					if (this._ACCOUNT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ACCOUNT_STAFF", Storage="_ACCOUNT", ThisKey="Username", OtherKey="Username", IsForeignKey=true)]
		public ACCOUNT ACCOUNT
		{
			get
			{
				return this._ACCOUNT.Entity;
			}
			set
			{
				ACCOUNT previousValue = this._ACCOUNT.Entity;
				if (((previousValue != value) 
							|| (this._ACCOUNT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ACCOUNT.Entity = null;
						previousValue.STAFFs.Remove(this);
					}
					this._ACCOUNT.Entity = value;
					if ((value != null))
					{
						value.STAFFs.Add(this);
						this._Username = value.Username;
					}
					else
					{
						this._Username = default(string);
					}
					this.SendPropertyChanged("ACCOUNT");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DOANHTHU")]
	public partial class DOANHTHU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<double> _tongThuNhap;
		
		private System.Nullable<double> _LuongNV;
		
		private System.Nullable<double> _LoiNhuan;
		
		private System.DateTime _Thang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntongThuNhapChanging(System.Nullable<double> value);
    partial void OntongThuNhapChanged();
    partial void OnLuongNVChanging(System.Nullable<double> value);
    partial void OnLuongNVChanged();
    partial void OnLoiNhuanChanging(System.Nullable<double> value);
    partial void OnLoiNhuanChanged();
    partial void OnThangChanging(System.DateTime value);
    partial void OnThangChanged();
    #endregion
		
		public DOANHTHU()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tongThuNhap", DbType="Float")]
		public System.Nullable<double> tongThuNhap
		{
			get
			{
				return this._tongThuNhap;
			}
			set
			{
				if ((this._tongThuNhap != value))
				{
					this.OntongThuNhapChanging(value);
					this.SendPropertyChanging();
					this._tongThuNhap = value;
					this.SendPropertyChanged("tongThuNhap");
					this.OntongThuNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LuongNV", DbType="Float")]
		public System.Nullable<double> LuongNV
		{
			get
			{
				return this._LuongNV;
			}
			set
			{
				if ((this._LuongNV != value))
				{
					this.OnLuongNVChanging(value);
					this.SendPropertyChanging();
					this._LuongNV = value;
					this.SendPropertyChanged("LuongNV");
					this.OnLuongNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoiNhuan", DbType="Float")]
		public System.Nullable<double> LoiNhuan
		{
			get
			{
				return this._LoiNhuan;
			}
			set
			{
				if ((this._LoiNhuan != value))
				{
					this.OnLoiNhuanChanging(value);
					this.SendPropertyChanging();
					this._LoiNhuan = value;
					this.SendPropertyChanged("LoiNhuan");
					this.OnLoiNhuanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thang", DbType="Date NOT NULL", IsPrimaryKey=true)]
		public System.DateTime Thang
		{
			get
			{
				return this._Thang;
			}
			set
			{
				if ((this._Thang != value))
				{
					this.OnThangChanging(value);
					this.SendPropertyChanging();
					this._Thang = value;
					this.SendPropertyChanged("Thang");
					this.OnThangChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CUSTOMER")]
	public partial class CUSTOMER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKH;
		
		private string _TenKH;
		
		private string _sdt;
		
		private string _Email;
		
		private string _address;
		
		private string _Username;
		
		private EntitySet<Billinfo> _Billinfos;
		
		private EntityRef<ACCOUNT> _ACCOUNT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(string value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnsdtChanging(string value);
    partial void OnsdtChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    #endregion
		
		public CUSTOMER()
		{
			this._Billinfos = new EntitySet<Billinfo>(new Action<Billinfo>(this.attach_Billinfos), new Action<Billinfo>(this.detach_Billinfos));
			this._ACCOUNT = default(EntityRef<ACCOUNT>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string sdt
		{
			get
			{
				return this._sdt;
			}
			set
			{
				if ((this._sdt != value))
				{
					this.OnsdtChanging(value);
					this.SendPropertyChanging();
					this._sdt = value;
					this.SendPropertyChanged("sdt");
					this.OnsdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					if (this._ACCOUNT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_Billinfo", Storage="_Billinfos", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<Billinfo> Billinfos
		{
			get
			{
				return this._Billinfos;
			}
			set
			{
				this._Billinfos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ACCOUNT_CUSTOMER", Storage="_ACCOUNT", ThisKey="Username", OtherKey="Username", IsForeignKey=true)]
		public ACCOUNT ACCOUNT
		{
			get
			{
				return this._ACCOUNT.Entity;
			}
			set
			{
				ACCOUNT previousValue = this._ACCOUNT.Entity;
				if (((previousValue != value) 
							|| (this._ACCOUNT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ACCOUNT.Entity = null;
						previousValue.CUSTOMERs.Remove(this);
					}
					this._ACCOUNT.Entity = value;
					if ((value != null))
					{
						value.CUSTOMERs.Add(this);
						this._Username = value.Username;
					}
					else
					{
						this._Username = default(string);
					}
					this.SendPropertyChanged("ACCOUNT");
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
		
		private void attach_Billinfos(Billinfo entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = this;
		}
		
		private void detach_Billinfos(Billinfo entity)
		{
			this.SendPropertyChanging();
			entity.CUSTOMER = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BOOKS")]
	public partial class BOOK : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSach;
		
		private string _TenSach;
		
		private string _TheLoai;
		
		private string _NXB;
		
		private string _TacGia;
		
		private double _gia;
		
		private EntitySet<Billinfo> _Billinfos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSachChanging(string value);
    partial void OnMaSachChanged();
    partial void OnTenSachChanging(string value);
    partial void OnTenSachChanged();
    partial void OnTheLoaiChanging(string value);
    partial void OnTheLoaiChanged();
    partial void OnNXBChanging(string value);
    partial void OnNXBChanged();
    partial void OnTacGiaChanging(string value);
    partial void OnTacGiaChanged();
    partial void OngiaChanging(double value);
    partial void OngiaChanged();
    #endregion
		
		public BOOK()
		{
			this._Billinfos = new EntitySet<Billinfo>(new Action<Billinfo>(this.attach_Billinfos), new Action<Billinfo>(this.detach_Billinfos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSach", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenSach
		{
			get
			{
				return this._TenSach;
			}
			set
			{
				if ((this._TenSach != value))
				{
					this.OnTenSachChanging(value);
					this.SendPropertyChanging();
					this._TenSach = value;
					this.SendPropertyChanged("TenSach");
					this.OnTenSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TheLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TheLoai
		{
			get
			{
				return this._TheLoai;
			}
			set
			{
				if ((this._TheLoai != value))
				{
					this.OnTheLoaiChanging(value);
					this.SendPropertyChanging();
					this._TheLoai = value;
					this.SendPropertyChanged("TheLoai");
					this.OnTheLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NXB", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NXB
		{
			get
			{
				return this._NXB;
			}
			set
			{
				if ((this._NXB != value))
				{
					this.OnNXBChanging(value);
					this.SendPropertyChanging();
					this._NXB = value;
					this.SendPropertyChanged("NXB");
					this.OnNXBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TacGia", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TacGia
		{
			get
			{
				return this._TacGia;
			}
			set
			{
				if ((this._TacGia != value))
				{
					this.OnTacGiaChanging(value);
					this.SendPropertyChanging();
					this._TacGia = value;
					this.SendPropertyChanged("TacGia");
					this.OnTacGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Float NOT NULL")]
		public double gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BOOK_Billinfo", Storage="_Billinfos", ThisKey="MaSach", OtherKey="MaSach")]
		public EntitySet<Billinfo> Billinfos
		{
			get
			{
				return this._Billinfos;
			}
			set
			{
				this._Billinfos.Assign(value);
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
		
		private void attach_Billinfos(Billinfo entity)
		{
			this.SendPropertyChanging();
			entity.BOOK = this;
		}
		
		private void detach_Billinfos(Billinfo entity)
		{
			this.SendPropertyChanging();
			entity.BOOK = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Billinfo")]
	public partial class Billinfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHD;
		
		private string _MaKH;
		
		private string _MaSach;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<double> _DonGia;
		
		private EntityRef<BOOK> _BOOK;
		
		private EntityRef<CUSTOMER> _CUSTOMER;
		
		private EntityRef<BILL> _BILL;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(string value);
    partial void OnMaHDChanged();
    partial void OnMaKHChanging(string value);
    partial void OnMaKHChanged();
    partial void OnMaSachChanging(string value);
    partial void OnMaSachChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(System.Nullable<double> value);
    partial void OnDonGiaChanged();
    #endregion
		
		public Billinfo()
		{
			this._BOOK = default(EntityRef<BOOK>);
			this._CUSTOMER = default(EntityRef<CUSTOMER>);
			this._BILL = default(EntityRef<BILL>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					if (this._BILL.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._CUSTOMER.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSach", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSach
		{
			get
			{
				return this._MaSach;
			}
			set
			{
				if ((this._MaSach != value))
				{
					if (this._BOOK.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSachChanging(value);
					this.SendPropertyChanging();
					this._MaSach = value;
					this.SendPropertyChanged("MaSach");
					this.OnMaSachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Float")]
		public System.Nullable<double> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BOOK_Billinfo", Storage="_BOOK", ThisKey="MaSach", OtherKey="MaSach", IsForeignKey=true)]
		public BOOK BOOK
		{
			get
			{
				return this._BOOK.Entity;
			}
			set
			{
				BOOK previousValue = this._BOOK.Entity;
				if (((previousValue != value) 
							|| (this._BOOK.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BOOK.Entity = null;
						previousValue.Billinfos.Remove(this);
					}
					this._BOOK.Entity = value;
					if ((value != null))
					{
						value.Billinfos.Add(this);
						this._MaSach = value.MaSach;
					}
					else
					{
						this._MaSach = default(string);
					}
					this.SendPropertyChanged("BOOK");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CUSTOMER_Billinfo", Storage="_CUSTOMER", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public CUSTOMER CUSTOMER
		{
			get
			{
				return this._CUSTOMER.Entity;
			}
			set
			{
				CUSTOMER previousValue = this._CUSTOMER.Entity;
				if (((previousValue != value) 
							|| (this._CUSTOMER.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CUSTOMER.Entity = null;
						previousValue.Billinfos.Remove(this);
					}
					this._CUSTOMER.Entity = value;
					if ((value != null))
					{
						value.Billinfos.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(string);
					}
					this.SendPropertyChanged("CUSTOMER");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BILL_Billinfo", Storage="_BILL", ThisKey="MaHD", OtherKey="MaHD", IsForeignKey=true)]
		public BILL BILL
		{
			get
			{
				return this._BILL.Entity;
			}
			set
			{
				BILL previousValue = this._BILL.Entity;
				if (((previousValue != value) 
							|| (this._BILL.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BILL.Entity = null;
						previousValue.Billinfos.Remove(this);
					}
					this._BILL.Entity = value;
					if ((value != null))
					{
						value.Billinfos.Add(this);
						this._MaHD = value.MaHD;
					}
					else
					{
						this._MaHD = default(string);
					}
					this.SendPropertyChanged("BILL");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BILL")]
	public partial class BILL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHD;
		
		private System.Nullable<System.DateTime> _ngayLap;
		
		private System.Nullable<double> _Gia;
		
		private EntitySet<Billinfo> _Billinfos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(string value);
    partial void OnMaHDChanged();
    partial void OnngayLapChanging(System.Nullable<System.DateTime> value);
    partial void OnngayLapChanged();
    partial void OnGiaChanging(System.Nullable<double> value);
    partial void OnGiaChanged();
    #endregion
		
		public BILL()
		{
			this._Billinfos = new EntitySet<Billinfo>(new Action<Billinfo>(this.attach_Billinfos), new Action<Billinfo>(this.detach_Billinfos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngayLap", DbType="Date")]
		public System.Nullable<System.DateTime> ngayLap
		{
			get
			{
				return this._ngayLap;
			}
			set
			{
				if ((this._ngayLap != value))
				{
					this.OnngayLapChanging(value);
					this.SendPropertyChanging();
					this._ngayLap = value;
					this.SendPropertyChanged("ngayLap");
					this.OnngayLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Float")]
		public System.Nullable<double> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BILL_Billinfo", Storage="_Billinfos", ThisKey="MaHD", OtherKey="MaHD")]
		public EntitySet<Billinfo> Billinfos
		{
			get
			{
				return this._Billinfos;
			}
			set
			{
				this._Billinfos.Assign(value);
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
		
		private void attach_Billinfos(Billinfo entity)
		{
			this.SendPropertyChanging();
			entity.BILL = this;
		}
		
		private void detach_Billinfos(Billinfo entity)
		{
			this.SendPropertyChanging();
			entity.BILL = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ACCOUNT")]
	public partial class ACCOUNT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
		private string _ChucVu;
		
		private EntitySet<STAFF> _STAFFs;
		
		private EntitySet<CUSTOMER> _CUSTOMERs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnChucVuChanging(string value);
    partial void OnChucVuChanged();
    #endregion
		
		public ACCOUNT()
		{
			this._STAFFs = new EntitySet<STAFF>(new Action<STAFF>(this.attach_STAFFs), new Action<STAFF>(this.detach_STAFFs));
			this._CUSTOMERs = new EntitySet<CUSTOMER>(new Action<CUSTOMER>(this.attach_CUSTOMERs), new Action<CUSTOMER>(this.detach_CUSTOMERs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(10)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChucVu", DbType="NChar(10)")]
		public string ChucVu
		{
			get
			{
				return this._ChucVu;
			}
			set
			{
				if ((this._ChucVu != value))
				{
					this.OnChucVuChanging(value);
					this.SendPropertyChanging();
					this._ChucVu = value;
					this.SendPropertyChanged("ChucVu");
					this.OnChucVuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ACCOUNT_STAFF", Storage="_STAFFs", ThisKey="Username", OtherKey="Username")]
		public EntitySet<STAFF> STAFFs
		{
			get
			{
				return this._STAFFs;
			}
			set
			{
				this._STAFFs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ACCOUNT_CUSTOMER", Storage="_CUSTOMERs", ThisKey="Username", OtherKey="Username")]
		public EntitySet<CUSTOMER> CUSTOMERs
		{
			get
			{
				return this._CUSTOMERs;
			}
			set
			{
				this._CUSTOMERs.Assign(value);
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
		
		private void attach_STAFFs(STAFF entity)
		{
			this.SendPropertyChanging();
			entity.ACCOUNT = this;
		}
		
		private void detach_STAFFs(STAFF entity)
		{
			this.SendPropertyChanging();
			entity.ACCOUNT = null;
		}
		
		private void attach_CUSTOMERs(CUSTOMER entity)
		{
			this.SendPropertyChanging();
			entity.ACCOUNT = this;
		}
		
		private void detach_CUSTOMERs(CUSTOMER entity)
		{
			this.SendPropertyChanging();
			entity.ACCOUNT = null;
		}
	}
}
#pragma warning restore 1591