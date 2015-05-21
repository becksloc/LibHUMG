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
	public class TacGiaBL
	{

		#region ***** Init Methods ***** 
		TacGiaDA objTacGiaDA;
		public TacGiaBL()
		{
			objTacGiaDA = new TacGiaDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get TacGia by tacgiaid
		/// </summary>
		/// <param name="tacgiaid">TacGiaID</param>
		/// <returns>TacGia</returns>
		public TacGia GetByTacGiaID(int tacgiaid)
		{
			return objTacGiaDA.GetByTacGiaID(tacgiaid);
		}

		/// <summary>
		/// Get all of TacGia
		/// </summary>
		/// <returns>List<<TacGia>></returns>
		public List<TacGia> GetList()
		{
			return objTacGiaDA.GetList();
		}

		/// <summary>
		/// Get DataSet of TacGia
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return objTacGiaDA.GetDataSet();
		}


		/// <summary>
		/// Get all of TacGia paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<TacGia>></returns>
		public List<TacGia> GetListPaged(int recperpage, int pageindex)
		{
			return objTacGiaDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of TacGia paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objTacGiaDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new TacGia within TacGia database table
		/// </summary>
		/// <param name="obj_tacgia">TacGia</param>
		/// <returns>key of table</returns>
		public int Add(TacGia obj_tacgia)
		{
			return objTacGiaDA.Add(obj_tacgia);
		}

		/// <summary>
		/// updates the specified TacGia
		/// </summary>
		/// <param name="obj_tacgia">TacGia</param>
		/// <returns></returns>
		public void Update(TacGia obj_tacgia)
		{
			objTacGiaDA.Update(obj_tacgia);
		}

		/// <summary>
		/// Delete the specified TacGia
		/// </summary>
		/// <param name="tacgiaid">TacGiaID</param>
		/// <returns></returns>
		public void Delete(int tacgiaid)
		{
			objTacGiaDA.Delete(tacgiaid);
		}
		#endregion
	}
}
