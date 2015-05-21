using System;

namespace LibHUMG.BusinessObjects
{
	public class NhanVien
	{
		#region ***** Fields & Properties ***** 
		private int _NhanVienID;
		public int NhanVienID
		{ 
			get 
			{ 
				return _NhanVienID;
			}
			set 
			{ 
				_NhanVienID = value;
			}
		}
		private int _MaNV;
		public int MaNV
		{ 
			get 
			{ 
				return _MaNV;
			}
			set 
			{ 
				_MaNV = value;
			}
		}
		private string _TenNV;
		public string TenNV
		{ 
			get 
			{ 
				return _TenNV;
			}
			set 
			{ 
				_TenNV = value;
			}
		}
		private string _GioiTinh;
		public string GioiTinh
		{ 
			get 
			{ 
				return _GioiTinh;
			}
			set 
			{ 
				_GioiTinh = value;
			}
		}
		private string _DiaChi;
		public string DiaChi
		{ 
			get 
			{ 
				return _DiaChi;
			}
			set 
			{ 
				_DiaChi = value;
			}
		}
		private string _DienThoai;
		public string DienThoai
		{ 
			get 
			{ 
				return _DienThoai;
			}
			set 
			{ 
				_DienThoai = value;
			}
		}
		private string _Username;
		public string Username
		{ 
			get 
			{ 
				return _Username;
			}
			set 
			{ 
				_Username = value;
			}
		}
		private string _Password;
		public string Password
		{ 
			get 
			{ 
				return _Password;
			}
			set 
			{ 
				_Password = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public NhanVien()
		{
		}
		public NhanVien(int nhanvienid)
		{
			this.NhanVienID = nhanvienid;
		}
		public NhanVien(int nhanvienid, int manv, string tennv, string gioitinh, string diachi, string dienthoai, string username, string password)
		{
			this.NhanVienID = nhanvienid;
			this.MaNV = manv;
			this.TenNV = tennv;
			this.GioiTinh = gioitinh;
			this.DiaChi = diachi;
			this.DienThoai = dienthoai;
			this.Username = username;
			this.Password = password;
		}
		#endregion
	}
}
