using System;

namespace LibHUMG.BusinessObjects
{
	public class Nxb
	{
		#region ***** Fields & Properties ***** 
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
		private int _MaNxb;
		public int MaNxb
		{ 
			get 
			{ 
				return _MaNxb;
			}
			set 
			{ 
				_MaNxb = value;
			}
		}
		private string _TenNxb;
		public string TenNxb
		{ 
			get 
			{ 
				return _TenNxb;
			}
			set 
			{ 
				_TenNxb = value;
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
		public Nxb()
		{
		}
		public Nxb(int nxbid)
		{
			this.NxbID = nxbid;
		}
		public Nxb(int nxbid, int manxb, string tennxb, DateTime createddate, string createdby, DateTime modifieddate, string modifiedby)
		{
			this.NxbID = nxbid;
			this.MaNxb = manxb;
			this.TenNxb = tennxb;
			this.CreatedDate = createddate;
			this.CreatedBy = createdby;
			this.ModifiedDate = modifieddate;
			this.ModifiedBy = modifiedby;
		}
		#endregion
	}
}
