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

namespace DoAn.NetMVC.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="IM")]
	public partial class IMDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAlbum(Album instance);
    partial void UpdateAlbum(Album instance);
    partial void DeleteAlbum(Album instance);
    partial void InsertDanhSachHinhTrongAlbum(DanhSachHinhTrongAlbum instance);
    partial void UpdateDanhSachHinhTrongAlbum(DanhSachHinhTrongAlbum instance);
    partial void DeleteDanhSachHinhTrongAlbum(DanhSachHinhTrongAlbum instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    partial void InsertKhoHinh(KhoHinh instance);
    partial void UpdateKhoHinh(KhoHinh instance);
    partial void DeleteKhoHinh(KhoHinh instance);
    #endregion
		
		public IMDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["IMConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public IMDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IMDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IMDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IMDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Album> Albums
		{
			get
			{
				return this.GetTable<Album>();
			}
		}
		
		public System.Data.Linq.Table<DanhSachHinhTrongAlbum> DanhSachHinhTrongAlbums
		{
			get
			{
				return this.GetTable<DanhSachHinhTrongAlbum>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
		
		public System.Data.Linq.Table<KhoHinh> KhoHinhs
		{
			get
			{
				return this.GetTable<KhoHinh>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Album")]
	public partial class Album : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaAlbum;
		
		private string _MaNguoiDung;
		
		private string _TenAlbum;
		
		private System.Nullable<System.DateTime> _NgayTao;
		
		private string _MoTa;
		
		private EntitySet<DanhSachHinhTrongAlbum> _DanhSachHinhTrongAlbums;
		
		private EntityRef<TaiKhoan> _TaiKhoan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaAlbumChanging(int value);
    partial void OnMaAlbumChanged();
    partial void OnMaNguoiDungChanging(string value);
    partial void OnMaNguoiDungChanged();
    partial void OnTenAlbumChanging(string value);
    partial void OnTenAlbumChanged();
    partial void OnNgayTaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayTaoChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    #endregion
		
		public Album()
		{
			this._DanhSachHinhTrongAlbums = new EntitySet<DanhSachHinhTrongAlbum>(new Action<DanhSachHinhTrongAlbum>(this.attach_DanhSachHinhTrongAlbums), new Action<DanhSachHinhTrongAlbum>(this.detach_DanhSachHinhTrongAlbums));
			this._TaiKhoan = default(EntityRef<TaiKhoan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaAlbum", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaAlbum
		{
			get
			{
				return this._MaAlbum;
			}
			set
			{
				if ((this._MaAlbum != value))
				{
					this.OnMaAlbumChanging(value);
					this.SendPropertyChanging();
					this._MaAlbum = value;
					this.SendPropertyChanged("MaAlbum");
					this.OnMaAlbumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNguoiDung", DbType="VarChar(30)")]
		public string MaNguoiDung
		{
			get
			{
				return this._MaNguoiDung;
			}
			set
			{
				if ((this._MaNguoiDung != value))
				{
					if (this._TaiKhoan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNguoiDungChanging(value);
					this.SendPropertyChanging();
					this._MaNguoiDung = value;
					this.SendPropertyChanged("MaNguoiDung");
					this.OnMaNguoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenAlbum", DbType="NVarChar(100)")]
		public string TenAlbum
		{
			get
			{
				return this._TenAlbum;
			}
			set
			{
				if ((this._TenAlbum != value))
				{
					this.OnTenAlbumChanging(value);
					this.SendPropertyChanging();
					this._TenAlbum = value;
					this.SendPropertyChanged("TenAlbum");
					this.OnTenAlbumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTao", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayTao
		{
			get
			{
				return this._NgayTao;
			}
			set
			{
				if ((this._NgayTao != value))
				{
					this.OnNgayTaoChanging(value);
					this.SendPropertyChanging();
					this._NgayTao = value;
					this.SendPropertyChanged("NgayTao");
					this.OnNgayTaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(MAX)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Album_DanhSachHinhTrongAlbum", Storage="_DanhSachHinhTrongAlbums", ThisKey="MaAlbum", OtherKey="MaAlbum")]
		public EntitySet<DanhSachHinhTrongAlbum> DanhSachHinhTrongAlbums
		{
			get
			{
				return this._DanhSachHinhTrongAlbums;
			}
			set
			{
				this._DanhSachHinhTrongAlbums.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_Album", Storage="_TaiKhoan", ThisKey="MaNguoiDung", OtherKey="MaNguoiDung", IsForeignKey=true)]
		public TaiKhoan TaiKhoan
		{
			get
			{
				return this._TaiKhoan.Entity;
			}
			set
			{
				TaiKhoan previousValue = this._TaiKhoan.Entity;
				if (((previousValue != value) 
							|| (this._TaiKhoan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TaiKhoan.Entity = null;
						previousValue.Albums.Remove(this);
					}
					this._TaiKhoan.Entity = value;
					if ((value != null))
					{
						value.Albums.Add(this);
						this._MaNguoiDung = value.MaNguoiDung;
					}
					else
					{
						this._MaNguoiDung = default(string);
					}
					this.SendPropertyChanged("TaiKhoan");
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
		
		private void attach_DanhSachHinhTrongAlbums(DanhSachHinhTrongAlbum entity)
		{
			this.SendPropertyChanging();
			entity.Album = this;
		}
		
		private void detach_DanhSachHinhTrongAlbums(DanhSachHinhTrongAlbum entity)
		{
			this.SendPropertyChanging();
			entity.Album = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DanhSachHinhTrongAlbum")]
	public partial class DanhSachHinhTrongAlbum : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaAlbum;
		
		private int _MaHinh;
		
		private EntityRef<Album> _Album;
		
		private EntityRef<KhoHinh> _KhoHinh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaAlbumChanging(int value);
    partial void OnMaAlbumChanged();
    partial void OnMaHinhChanging(int value);
    partial void OnMaHinhChanged();
    #endregion
		
		public DanhSachHinhTrongAlbum()
		{
			this._Album = default(EntityRef<Album>);
			this._KhoHinh = default(EntityRef<KhoHinh>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaAlbum", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaAlbum
		{
			get
			{
				return this._MaAlbum;
			}
			set
			{
				if ((this._MaAlbum != value))
				{
					if (this._Album.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaAlbumChanging(value);
					this.SendPropertyChanging();
					this._MaAlbum = value;
					this.SendPropertyChanged("MaAlbum");
					this.OnMaAlbumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHinh", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHinh
		{
			get
			{
				return this._MaHinh;
			}
			set
			{
				if ((this._MaHinh != value))
				{
					if (this._KhoHinh.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHinhChanging(value);
					this.SendPropertyChanging();
					this._MaHinh = value;
					this.SendPropertyChanged("MaHinh");
					this.OnMaHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Album_DanhSachHinhTrongAlbum", Storage="_Album", ThisKey="MaAlbum", OtherKey="MaAlbum", IsForeignKey=true)]
		public Album Album
		{
			get
			{
				return this._Album.Entity;
			}
			set
			{
				Album previousValue = this._Album.Entity;
				if (((previousValue != value) 
							|| (this._Album.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Album.Entity = null;
						previousValue.DanhSachHinhTrongAlbums.Remove(this);
					}
					this._Album.Entity = value;
					if ((value != null))
					{
						value.DanhSachHinhTrongAlbums.Add(this);
						this._MaAlbum = value.MaAlbum;
					}
					else
					{
						this._MaAlbum = default(int);
					}
					this.SendPropertyChanged("Album");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoHinh_DanhSachHinhTrongAlbum", Storage="_KhoHinh", ThisKey="MaHinh", OtherKey="MaHinh", IsForeignKey=true)]
		public KhoHinh KhoHinh
		{
			get
			{
				return this._KhoHinh.Entity;
			}
			set
			{
				KhoHinh previousValue = this._KhoHinh.Entity;
				if (((previousValue != value) 
							|| (this._KhoHinh.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhoHinh.Entity = null;
						previousValue.DanhSachHinhTrongAlbums.Remove(this);
					}
					this._KhoHinh.Entity = value;
					if ((value != null))
					{
						value.DanhSachHinhTrongAlbums.Add(this);
						this._MaHinh = value.MaHinh;
					}
					else
					{
						this._MaHinh = default(int);
					}
					this.SendPropertyChanged("KhoHinh");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNguoiDung;
		
		private string _MatKhau;
		
		private string _pathAnhDaiDien;
		
		private string _TenTaiKhoan;
		
		private string _DienThoai;
		
		private string _Email;
		
		private EntitySet<Album> _Albums;
		
		private EntitySet<KhoHinh> _KhoHinhs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNguoiDungChanging(string value);
    partial void OnMaNguoiDungChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnpathAnhDaiDienChanging(string value);
    partial void OnpathAnhDaiDienChanged();
    partial void OnTenTaiKhoanChanging(string value);
    partial void OnTenTaiKhoanChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public TaiKhoan()
		{
			this._Albums = new EntitySet<Album>(new Action<Album>(this.attach_Albums), new Action<Album>(this.detach_Albums));
			this._KhoHinhs = new EntitySet<KhoHinh>(new Action<KhoHinh>(this.attach_KhoHinhs), new Action<KhoHinh>(this.detach_KhoHinhs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNguoiDung", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNguoiDung
		{
			get
			{
				return this._MaNguoiDung;
			}
			set
			{
				if ((this._MaNguoiDung != value))
				{
					this.OnMaNguoiDungChanging(value);
					this.SendPropertyChanging();
					this._MaNguoiDung = value;
					this.SendPropertyChanged("MaNguoiDung");
					this.OnMaNguoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(15)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pathAnhDaiDien", DbType="VarChar(MAX)")]
		public string pathAnhDaiDien
		{
			get
			{
				return this._pathAnhDaiDien;
			}
			set
			{
				if ((this._pathAnhDaiDien != value))
				{
					this.OnpathAnhDaiDienChanging(value);
					this.SendPropertyChanging();
					this._pathAnhDaiDien = value;
					this.SendPropertyChanged("pathAnhDaiDien");
					this.OnpathAnhDaiDienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTaiKhoan", DbType="NVarChar(10)")]
		public string TenTaiKhoan
		{
			get
			{
				return this._TenTaiKhoan;
			}
			set
			{
				if ((this._TenTaiKhoan != value))
				{
					this.OnTenTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TenTaiKhoan = value;
					this.SendPropertyChanged("TenTaiKhoan");
					this.OnTenTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="VarChar(15)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_Album", Storage="_Albums", ThisKey="MaNguoiDung", OtherKey="MaNguoiDung")]
		public EntitySet<Album> Albums
		{
			get
			{
				return this._Albums;
			}
			set
			{
				this._Albums.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_KhoHinh", Storage="_KhoHinhs", ThisKey="MaNguoiDung", OtherKey="MaNguoiDung")]
		public EntitySet<KhoHinh> KhoHinhs
		{
			get
			{
				return this._KhoHinhs;
			}
			set
			{
				this._KhoHinhs.Assign(value);
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
		
		private void attach_Albums(Album entity)
		{
			this.SendPropertyChanging();
			entity.TaiKhoan = this;
		}
		
		private void detach_Albums(Album entity)
		{
			this.SendPropertyChanging();
			entity.TaiKhoan = null;
		}
		
		private void attach_KhoHinhs(KhoHinh entity)
		{
			this.SendPropertyChanging();
			entity.TaiKhoan = this;
		}
		
		private void detach_KhoHinhs(KhoHinh entity)
		{
			this.SendPropertyChanging();
			entity.TaiKhoan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhoHinh")]
	public partial class KhoHinh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHinh;
		
		private string _DuoiHinh;
		
		private string _MaNguoiDung;
		
		private string _TenHinh;
		
		private string _MoTa;
		
		private string _Duoi;
		
		private System.Nullable<int> _Width;
		
		private System.Nullable<int> _Height;
		
		private System.Nullable<System.DateTime> _DateUpload;
		
		private string _Size;
		
		private EntitySet<DanhSachHinhTrongAlbum> _DanhSachHinhTrongAlbums;
		
		private EntityRef<TaiKhoan> _TaiKhoan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHinhChanging(int value);
    partial void OnMaHinhChanged();
    partial void OnDuoiHinhChanging(string value);
    partial void OnDuoiHinhChanged();
    partial void OnMaNguoiDungChanging(string value);
    partial void OnMaNguoiDungChanged();
    partial void OnTenHinhChanging(string value);
    partial void OnTenHinhChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnDuoiChanging(string value);
    partial void OnDuoiChanged();
    partial void OnWidthChanging(System.Nullable<int> value);
    partial void OnWidthChanged();
    partial void OnHeightChanging(System.Nullable<int> value);
    partial void OnHeightChanged();
    partial void OnDateUploadChanging(System.Nullable<System.DateTime> value);
    partial void OnDateUploadChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    #endregion
		
		public KhoHinh()
		{
			this._DanhSachHinhTrongAlbums = new EntitySet<DanhSachHinhTrongAlbum>(new Action<DanhSachHinhTrongAlbum>(this.attach_DanhSachHinhTrongAlbums), new Action<DanhSachHinhTrongAlbum>(this.detach_DanhSachHinhTrongAlbums));
			this._TaiKhoan = default(EntityRef<TaiKhoan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHinh", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHinh
		{
			get
			{
				return this._MaHinh;
			}
			set
			{
				if ((this._MaHinh != value))
				{
					this.OnMaHinhChanging(value);
					this.SendPropertyChanging();
					this._MaHinh = value;
					this.SendPropertyChanged("MaHinh");
					this.OnMaHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DuoiHinh", DbType="VarChar(10)")]
		public string DuoiHinh
		{
			get
			{
				return this._DuoiHinh;
			}
			set
			{
				if ((this._DuoiHinh != value))
				{
					this.OnDuoiHinhChanging(value);
					this.SendPropertyChanging();
					this._DuoiHinh = value;
					this.SendPropertyChanged("DuoiHinh");
					this.OnDuoiHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNguoiDung", DbType="VarChar(30)")]
		public string MaNguoiDung
		{
			get
			{
				return this._MaNguoiDung;
			}
			set
			{
				if ((this._MaNguoiDung != value))
				{
					if (this._TaiKhoan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNguoiDungChanging(value);
					this.SendPropertyChanging();
					this._MaNguoiDung = value;
					this.SendPropertyChanged("MaNguoiDung");
					this.OnMaNguoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHinh", DbType="NVarChar(MAX)")]
		public string TenHinh
		{
			get
			{
				return this._TenHinh;
			}
			set
			{
				if ((this._TenHinh != value))
				{
					this.OnTenHinhChanging(value);
					this.SendPropertyChanging();
					this._TenHinh = value;
					this.SendPropertyChanged("TenHinh");
					this.OnTenHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(MAX)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duoi", DbType="VarChar(10)")]
		public string Duoi
		{
			get
			{
				return this._Duoi;
			}
			set
			{
				if ((this._Duoi != value))
				{
					this.OnDuoiChanging(value);
					this.SendPropertyChanging();
					this._Duoi = value;
					this.SendPropertyChanged("Duoi");
					this.OnDuoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="Int")]
		public System.Nullable<int> Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				if ((this._Width != value))
				{
					this.OnWidthChanging(value);
					this.SendPropertyChanging();
					this._Width = value;
					this.SendPropertyChanged("Width");
					this.OnWidthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="Int")]
		public System.Nullable<int> Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				if ((this._Height != value))
				{
					this.OnHeightChanging(value);
					this.SendPropertyChanging();
					this._Height = value;
					this.SendPropertyChanged("Height");
					this.OnHeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateUpload", DbType="Date")]
		public System.Nullable<System.DateTime> DateUpload
		{
			get
			{
				return this._DateUpload;
			}
			set
			{
				if ((this._DateUpload != value))
				{
					this.OnDateUploadChanging(value);
					this.SendPropertyChanging();
					this._DateUpload = value;
					this.SendPropertyChanged("DateUpload");
					this.OnDateUploadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhoHinh_DanhSachHinhTrongAlbum", Storage="_DanhSachHinhTrongAlbums", ThisKey="MaHinh", OtherKey="MaHinh")]
		public EntitySet<DanhSachHinhTrongAlbum> DanhSachHinhTrongAlbums
		{
			get
			{
				return this._DanhSachHinhTrongAlbums;
			}
			set
			{
				this._DanhSachHinhTrongAlbums.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_KhoHinh", Storage="_TaiKhoan", ThisKey="MaNguoiDung", OtherKey="MaNguoiDung", IsForeignKey=true)]
		public TaiKhoan TaiKhoan
		{
			get
			{
				return this._TaiKhoan.Entity;
			}
			set
			{
				TaiKhoan previousValue = this._TaiKhoan.Entity;
				if (((previousValue != value) 
							|| (this._TaiKhoan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TaiKhoan.Entity = null;
						previousValue.KhoHinhs.Remove(this);
					}
					this._TaiKhoan.Entity = value;
					if ((value != null))
					{
						value.KhoHinhs.Add(this);
						this._MaNguoiDung = value.MaNguoiDung;
					}
					else
					{
						this._MaNguoiDung = default(string);
					}
					this.SendPropertyChanged("TaiKhoan");
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
		
		private void attach_DanhSachHinhTrongAlbums(DanhSachHinhTrongAlbum entity)
		{
			this.SendPropertyChanging();
			entity.KhoHinh = this;
		}
		
		private void detach_DanhSachHinhTrongAlbums(DanhSachHinhTrongAlbum entity)
		{
			this.SendPropertyChanging();
			entity.KhoHinh = null;
		}
	}
}
#pragma warning restore 1591
