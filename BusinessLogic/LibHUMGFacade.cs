using System;
using LibHUMG.BusinessLogic;

namespace LibHUMG.BusinessLogic
{
	public class LibHUMGFacade
	{
		#region ***** Static Methods ***** 
		public static CuonSachBL GetCuonSachBL()
		{ 
			return new CuonSachBL();
		}
		public static DauSachBL GetDauSachBL()
		{ 
			return new DauSachBL();
		}
		public static DocGiaBL GetDocGiaBL()
		{ 
			return new DocGiaBL();
		}
		public static NhanVienBL GetNhanVienBL()
		{ 
			return new NhanVienBL();
		}
		public static NxbBL GetNxbBL()
		{ 
			return new NxbBL();
		}
		public static SoMuonBL GetSoMuonBL()
		{ 
			return new SoMuonBL();
		}
		public static TacGiaBL GetTacGiaBL()
		{ 
			return new TacGiaBL();
		}
		public static TheLoaiBL GetTheLoaiBL()
		{ 
			return new TheLoaiBL();
		}
		#endregion
	}
}
