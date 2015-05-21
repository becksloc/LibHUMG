using System;

namespace LibHUMG.BusinessObjects
{
	public class TacGia
	{
		#region ***** Fields & Properties ***** 
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
		private int _MaTacGia;
		public int MaTacGia
		{ 
			get 
			{ 
				return _MaTacGia;
			}
			set 
			{ 
				_MaTacGia = value;
			}
		}
		private string _TenTacGia;
		public string TenTacGia
		{ 
			get 
			{ 
				return _TenTacGia;
			}
			set 
			{ 
				_TenTacGia = value;
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
		public TacGia()
		{
		}
		public TacGia(int tacgiaid)
		{
			this.TacGiaID = tacgiaid;
		}
		public TacGia(int tacgiaid, int matacgia, string tentacgia, DateTime createddate, string createdby, DateTime modifieddate, string modifiedby)
		{
			this.TacGiaID = tacgiaid;
			this.MaTacGia = matacgia;
			this.TenTacGia = tentacgia;
			this.CreatedDate = createddate;
			this.CreatedBy = createdby;
			this.ModifiedDate = modifieddate;
			this.ModifiedBy = modifiedby;
		}
		#endregion
	}
}
