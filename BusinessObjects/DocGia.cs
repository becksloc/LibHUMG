using System;

namespace LibHUMG.BusinessObjects
{
	public class DocGia
	{
		#region ***** Fields & Properties ***** 
		private int _DocGiaID;
		public int DocGiaID
		{ 
			get 
			{ 
				return _DocGiaID;
			}
			set 
			{ 
				_DocGiaID = value;
			}
		}
		private int _MaDocGia;
		public int MaDocGia
		{ 
			get 
			{ 
				return _MaDocGia;
			}
			set 
			{ 
				_MaDocGia = value;
			}
		}
		private string _HoTen;
		public string HoTen
		{ 
			get 
			{ 
				return _HoTen;
			}
			set 
			{ 
				_HoTen = value;
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
		private DateTime _NgaySinh;
		public DateTime NgaySinh
		{ 
			get 
			{ 
				return _NgaySinh;
			}
			set 
			{ 
				_NgaySinh = value;
			}
		}
		private string _QueQuan;
		public string QueQuan
		{ 
			get 
			{ 
				return _QueQuan;
			}
			set 
			{ 
				_QueQuan = value;
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
		private string _Email;
		public string Email
		{ 
			get 
			{ 
				return _Email;
			}
			set 
			{ 
				_Email = value;
			}
		}
		private DateTime _NgayDangKy;
		public DateTime NgayDangKy
		{ 
			get 
			{ 
				return _NgayDangKy;
			}
			set 
			{ 
				_NgayDangKy = value;
			}
		}
		private DateTime _NgayTaoThe;
		public DateTime NgayTaoThe
		{ 
			get 
			{ 
				return _NgayTaoThe;
			}
			set 
			{ 
				_NgayTaoThe = value;
			}
		}
		private DateTime _Hansd;
		public DateTime Hansd
		{ 
			get 
			{ 
				return _Hansd;
			}
			set 
			{ 
				_Hansd = value;
			}
		}
		private string _TrangThai;
		public string TrangThai
		{ 
			get 
			{ 
				return _TrangThai;
			}
			set 
			{ 
				_TrangThai = value;
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
		private DateTime _CreatedDate;
		public DateTime CreatedDate
		{ 
			get 
			{ 
				return _CreatedDate;
			}
			set 
			{ 
				_CreatedDate = value;
			}
		}
		private string _CreatedBy;
		public string CreatedBy
		{ 
			get 
			{ 
				return _CreatedBy;
			}
			set 
			{ 
				_CreatedBy = value;
			}
		}
		private DateTime _ModifiedDate;
		public DateTime ModifiedDate
		{ 
			get 
			{ 
				return _ModifiedDate;
			}
			set 
			{ 
				_ModifiedDate = value;
			}
		}
		private string _ModifiedBy;
		public string ModifiedBy
		{ 
			get 
			{ 
				return _ModifiedBy;
			}
			set 
			{ 
				_ModifiedBy = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public DocGia()
		{
		}
		public DocGia(int docgiaid)
		{
			this.DocGiaID = docgiaid;
		}
		public DocGia(int docgiaid, int madocgia, string hoten, string gioitinh, DateTime ngaysinh, string quequan, string dienthoai, string email, DateTime ngaydangky, DateTime ngaytaothe, DateTime hansd, string trangthai, string username, string password, DateTime createddate, string createdby, DateTime modifieddate, string modifiedby)
		{
			this.DocGiaID = docgiaid;
			this.MaDocGia = madocgia;
			this.HoTen = hoten;
			this.GioiTinh = gioitinh;
			this.NgaySinh = ngaysinh;
			this.QueQuan = quequan;
			this.DienThoai = dienthoai;
			this.Email = email;
			this.NgayDangKy = ngaydangky;
			this.NgayTaoThe = ngaytaothe;
			this.Hansd = hansd;
			this.TrangThai = trangthai;
			this.Username = username;
			this.Password = password;
			this.CreatedDate = createddate;
			this.CreatedBy = createdby;
			this.ModifiedDate = modifieddate;
			this.ModifiedBy = modifiedby;
		}
		#endregion
	}
}
