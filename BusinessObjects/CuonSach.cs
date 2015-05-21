using System;

namespace LibHUMG.BusinessObjects
{
	public class CuonSach
	{
		#region ***** Fields & Properties ***** 
		private int _CuonSachID;
		public int CuonSachID
		{ 
			get 
			{ 
				return _CuonSachID;
			}
			set 
			{ 
				_CuonSachID = value;
			}
		}
		private int _MaCuonSach;
		public int MaCuonSach
		{ 
			get 
			{ 
				return _MaCuonSach;
			}
			set 
			{ 
				_MaCuonSach = value;
			}
		}
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
		private string _ViTri;
		public string ViTri
		{ 
			get 
			{ 
				return _ViTri;
			}
			set 
			{ 
				_ViTri = value;
			}
		}
		private string _LuotXem;
		public string LuotXem
		{ 
			get 
			{ 
				return _LuotXem;
			}
			set 
			{ 
				_LuotXem = value;
			}
		}
		private string _TinhTrang;
		public string TinhTrang
		{ 
			get 
			{ 
				return _TinhTrang;
			}
			set 
			{ 
				_TinhTrang = value;
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
		public CuonSach()
		{
		}
		public CuonSach(int cuonsachid)
		{
			this.CuonSachID = cuonsachid;
		}
		public CuonSach(int cuonsachid, int macuonsach, int dausachid, string vitri, string luotxem, string tinhtrang, DateTime createddate, string createdby, DateTime modifieddate, string modifiedby)
		{
			this.CuonSachID = cuonsachid;
			this.MaCuonSach = macuonsach;
			this.DauSachID = dausachid;
			this.ViTri = vitri;
			this.LuotXem = luotxem;
			this.TinhTrang = tinhtrang;
			this.CreatedDate = createddate;
			this.CreatedBy = createdby;
			this.ModifiedDate = modifieddate;
			this.ModifiedBy = modifiedby;
		}
		#endregion
	}
}
