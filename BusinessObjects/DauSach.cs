using System;

namespace LibHUMG.BusinessObjects
{
	public class DauSach
	{
		#region ***** Fields & Properties ***** 
		private int _DauSachID;
		public int DauSachID
		{ 
			get 
			{ 
				return _DauSachID;
			}
			set 
			{ 
				_DauSachID = value;
			}
		}
		private int _MaDauSach;
		public int MaDauSach
		{ 
			get 
			{ 
				return _MaDauSach;
			}
			set 
			{ 
				_MaDauSach = value;
			}
		}
		private int _TacGiaID;
		public int TacGiaID
		{ 
			get 
			{ 
				return _TacGiaID;
			}
			set 
			{ 
				_TacGiaID = value;
			}
		}
		private int _NxbID;
		public int NxbID
		{ 
			get 
			{ 
				return _NxbID;
			}
			set 
			{ 
				_NxbID = value;
			}
		}
		private int _TheLoaiID;
		public int TheLoaiID
		{ 
			get 
			{ 
				return _TheLoaiID;
			}
			set 
			{ 
				_TheLoaiID = value;
			}
		}
		private string _TenSach;
		public string TenSach
		{ 
			get 
			{ 
				return _TenSach;
			}
			set 
			{ 
				_TenSach = value;
			}
		}
		private string _TomTat;
		public string TomTat
		{ 
			get 
			{ 
				return _TomTat;
			}
			set 
			{ 
				_TomTat = value;
			}
		}
		private string _TuKhoa;
		public string TuKhoa
		{ 
			get 
			{ 
				return _TuKhoa;
			}
			set 
			{ 
				_TuKhoa = value;
			}
		}
		private string _ThoiHan;
		public string ThoiHan
		{ 
			get 
			{ 
				return _ThoiHan;
			}
			set 
			{ 
				_ThoiHan = value;
			}
		}
		private int _TongLuotMuon;
		public int TongLuotMuon
		{ 
			get 
			{ 
				return _TongLuotMuon;
			}
			set 
			{ 
				_TongLuotMuon = value;
			}
		}
		private int _SoCuonCon;
		public int SoCuonCon
		{ 
			get 
			{ 
				return _SoCuonCon;
			}
			set 
			{ 
				_SoCuonCon = value;
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
		public DauSach()
		{
		}
		public DauSach(int dausachid)
		{
			this.DauSachID = dausachid;
		}
		public DauSach(int dausachid, int madausach, int tacgiaid, int nxbid, int theloaiid, string tensach, string tomtat, string tukhoa, string thoihan, int tongluotmuon, int socuoncon, DateTime createddate, string createdby, DateTime modifieddate, string modifiedby)
		{
			this.DauSachID = dausachid;
			this.MaDauSach = madausach;
			this.TacGiaID = tacgiaid;
			this.NxbID = nxbid;
			this.TheLoaiID = theloaiid;
			this.TenSach = tensach;
			this.TomTat = tomtat;
			this.TuKhoa = tukhoa;
			this.ThoiHan = thoihan;
			this.TongLuotMuon = tongluotmuon;
			this.SoCuonCon = socuoncon;
			this.CreatedDate = createddate;
			this.CreatedBy = createdby;
			this.ModifiedDate = modifieddate;
			this.ModifiedBy = modifiedby;
		}
		#endregion
	}
}
