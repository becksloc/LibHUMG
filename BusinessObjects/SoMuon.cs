using System;

namespace LibHUMG.BusinessObjects
{
	public class SoMuon
	{
		#region ***** Fields & Properties ***** 
		private int _SoMuonID;
		public int SoMuonID
		{ 
			get 
			{ 
				return _SoMuonID;
			}
			set 
			{ 
				_SoMuonID = value;
			}
		}
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
		private DateTime _NgayMuon;
		public DateTime NgayMuon
		{ 
			get 
			{ 
				return _NgayMuon;
			}
			set 
			{ 
				_NgayMuon = value;
			}
		}
		private DateTime _NgayTra;
		public DateTime NgayTra
		{ 
			get 
			{ 
				return _NgayTra;
			}
			set 
			{ 
				_NgayTra = value;
			}
		}
		private decimal _TienPhat;
		public decimal TienPhat
		{ 
			get 
			{ 
				return _TienPhat;
			}
			set 
			{ 
				_TienPhat = value;
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
		public SoMuon()
		{
		}
		public SoMuon(int somuonid)
		{
			this.SoMuonID = somuonid;
		}
		public SoMuon(int somuonid, int cuonsachid, int docgiaid, DateTime ngaymuon, DateTime ngaytra, decimal tienphat, DateTime createddate, string createdby, DateTime modifieddate, string modifiedby)
		{
			this.SoMuonID = somuonid;
			this.CuonSachID = cuonsachid;
			this.DocGiaID = docgiaid;
			this.NgayMuon = ngaymuon;
			this.NgayTra = ngaytra;
			this.TienPhat = tienphat;
			this.CreatedDate = createddate;
			this.CreatedBy = createdby;
			this.ModifiedDate = modifieddate;
			this.ModifiedBy = modifiedby;
		}
		#endregion
	}
}
