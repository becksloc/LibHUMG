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
	public class DocGiaBL
	{

		#region ***** Init Methods ***** 
		DocGiaDA objDocGiaDA;
		public DocGiaBL()
		{
			objDocGiaDA = new DocGiaDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get DocGia by docgiaid
		/// </summary>
		/// <param name="docgiaid">DocGiaID</param>
		/// <returns>DocGia</returns>
		public DocGia GetByDocGiaID(int docgiaid)
		{
			return objDocGiaDA.GetByDocGiaID(docgiaid);
		}

		/// <summary>
		/// Get all of DocGia
		/// </summary>
		/// <returns>List<<DocGia>></returns>
		public List<DocGia> GetList()
		{
			return objDocGiaDA.GetList();
		}

		/// <summary>
		/// Get DataSet of DocGia
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return objDocGiaDA.GetDataSet();
		}


		/// <summary>
		/// Get all of DocGia paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<DocGia>></returns>
		public List<DocGia> GetListPaged(int recperpage, int pageindex)
		{
			return objDocGiaDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of DocGia paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objDocGiaDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DocGia within DocGia database table
		/// </summary>
		/// <param name="obj_docgia">DocGia</param>
		/// <returns>key of table</returns>
		public int Add(DocGia obj_docgia)
		{
			return objDocGiaDA.Add(obj_docgia);
		}

		/// <summary>
		/// updates the specified DocGia
		/// </summary>
		/// <param name="obj_docgia">DocGia</param>
		/// <returns></returns>
		public void Update(DocGia obj_docgia)
		{
			objDocGiaDA.Update(obj_docgia);
		}

		/// <summary>
		/// Delete the specified DocGia
		/// </summary>
		/// <param name="docgiaid">DocGiaID</param>
		/// <returns></returns>
		public void Delete(int docgiaid)
		{
			objDocGiaDA.Delete(docgiaid);
		}
		#endregion
	}
}
