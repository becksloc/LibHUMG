using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using LibHUMG.BusinessObjects;
using LibHUMG.DataAccess;

namespace LibHUMG.BusinessLogic
{
	public class CuonSachBL
	{

		#region ***** Init Methods ***** 
		CuonSachDA objCuonSachDA;
		public CuonSachBL()
		{
			objCuonSachDA = new CuonSachDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get CuonSach by cuonsachid
		/// </summary>
		/// <param name="cuonsachid">CuonSachID</param>
		/// <returns>CuonSach</returns>
		public CuonSach GetByCuonSachID(int cuonsachid)
		{
			return objCuonSachDA.GetByCuonSachID(cuonsachid);
		}

		/// <summary>
		/// Get all of CuonSach
		/// </summary>
		/// <returns>List<<CuonSach>></returns>
		public List<CuonSach> GetList()
		{
			return objCuonSachDA.GetList();
		}

		/// <summary>
		/// Get DataSet of CuonSach
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return objCuonSachDA.GetDataSet();
		}


		/// <summary>
		/// Get all of CuonSach paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<CuonSach>></returns>
		public List<CuonSach> GetListPaged(int recperpage, int pageindex)
		{
			return objCuonSachDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of CuonSach paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objCuonSachDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new CuonSach within CuonSach database table
		/// </summary>
		/// <param name="obj_cuonsach">CuonSach</param>
		/// <returns>key of table</returns>
		public int Add(CuonSach obj_cuonsach)
		{
			return objCuonSachDA.Add(obj_cuonsach);
		}

		/// <summary>
		/// updates the specified CuonSach
		/// </summary>
		/// <param name="obj_cuonsach">CuonSach</param>
		/// <returns></returns>
		public void Update(CuonSach obj_cuonsach)
		{
			objCuonSachDA.Update(obj_cuonsach);
		}

		/// <summary>
		/// Delete the specified CuonSach
		/// </summary>
		/// <param name="cuonsachid">CuonSachID</param>
		/// <returns></returns>
		public void Delete(int cuonsachid)
		{
			objCuonSachDA.Delete(cuonsachid);
		}
		#endregion
	}
}
