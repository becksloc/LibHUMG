using System;

namespace LibHUMG.BusinessObjects
{
	public class TheLoai
	{
		#region ***** Fields & Properties ***** 
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
		private int _MaTheLoai;
		public int MaTheLoai
		{ 
			get 
			{ 
				return _MaTheLoai;
			}
			set 
			{ 
				_MaTheLoai = value;
			}
		}
		private string _TenTheLoai;
		public string TenTheLoai
		{ 
			get 
			{ 
				return _TenTheLoai;
			}
			set 
			{ 
				_TenTheLoai = value;
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
		public TheLoai()
		{
		}
		public TheLoai(int theloaiid)
		{
			this.TheLoaiID = theloaiid;
		}
		public TheLoai(int theloaiid, int matheloai, string tentheloai, DateTime createddate, string createdby, DateTime modifieddate, string modifiedby)
		{
			this.TheLoaiID = theloaiid;
			this.MaTheLoai = matheloai;
			this.TenTheLoai = tentheloai;
			this.CreatedDate = createddate;
			this.CreatedBy = createdby;
			this.ModifiedDate = modifieddate;
			this.ModifiedBy = modifiedby;
		}
		#endregion
	}
}
