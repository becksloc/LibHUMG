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
	public class DauSachBL
	{

		#region ***** Init Methods ***** 
		DauSachDA objDauSachDA;
		public DauSachBL()
		{
			objDauSachDA = new DauSachDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get DauSach by dausachid
		/// </summary>
		/// <param name="dausachid">DauSachID</param>
		/// <returns>DauSach</returns>
		public DauSach GetByDauSachID(int dausachid)
		{
			return objDauSachDA.GetByDauSachID(dausachid);
		}

		/// <summary>
		/// Get all of DauSach
		/// </summary>
		/// <returns>List<<DauSach>></returns>
		public List<DauSach> GetList()
		{
			return objDauSachDA.GetList();
		}

		/// <summary>
		/// Get DataSet of DauSach
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return objDauSachDA.GetDataSet();
		}


		/// <summary>
		/// Get all of DauSach paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<DauSach>></returns>
		public List<DauSach> GetListPaged(int recperpage, int pageindex)
		{
			return objDauSachDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of DauSach paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objDauSachDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DauSach within DauSach database table
		/// </summary>
		/// <param name="obj_dausach">DauSach</param>
		/// <returns>key of table</returns>
		public int Add(DauSach obj_dausach)
		{
			return objDauSachDA.Add(obj_dausach);
		}

		/// <summary>
		/// updates the specified DauSach
		/// </summary>
		/// <param name="obj_dausach">DauSach</param>
		/// <returns></returns>
		public void Update(DauSach obj_dausach)
		{
			objDauSachDA.Update(obj_dausach);
		}

		/// <summary>
		/// Delete the specified DauSach
		/// </summary>
		/// <param name="dausachid">DauSachID</param>
		/// <returns></returns>
		public void Delete(int dausachid)
		{
			objDauSachDA.Delete(dausachid);
		}
		#endregion
	}
}
