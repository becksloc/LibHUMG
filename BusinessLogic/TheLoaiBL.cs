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
	public class TheLoaiBL
	{

		#region ***** Init Methods ***** 
		TheLoaiDA objTheLoaiDA;
		public TheLoaiBL()
		{
			objTheLoaiDA = new TheLoaiDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get TheLoai by theloaiid
		/// </summary>
		/// <param name="theloaiid">TheLoaiID</param>
		/// <returns>TheLoai</returns>
		public TheLoai GetByTheLoaiID(int theloaiid)
		{
			return objTheLoaiDA.GetByTheLoaiID(theloaiid);
		}

		/// <summary>
		/// Get all of TheLoai
		/// </summary>
		/// <returns>List<<TheLoai>></returns>
		public List<TheLoai> GetList()
		{
			return objTheLoaiDA.GetList();
		}

		/// <summary>
		/// Get DataSet of TheLoai
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return objTheLoaiDA.GetDataSet();
		}


		/// <summary>
		/// Get all of TheLoai paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<TheLoai>></returns>
		public List<TheLoai> GetListPaged(int recperpage, int pageindex)
		{
			return objTheLoaiDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of TheLoai paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objTheLoaiDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new TheLoai within TheLoai database table
		/// </summary>
		/// <param name="obj_theloai">TheLoai</param>
		/// <returns>key of table</returns>
		public int Add(TheLoai obj_theloai)
		{
			return objTheLoaiDA.Add(obj_theloai);
		}

		/// <summary>
		/// updates the specified TheLoai
		/// </summary>
		/// <param name="obj_theloai">TheLoai</param>
		/// <returns></returns>
		public void Update(TheLoai obj_theloai)
		{
			objTheLoaiDA.Update(obj_theloai);
		}

		/// <summary>
		/// Delete the specified TheLoai
		/// </summary>
		/// <param name="theloaiid">TheLoaiID</param>
		/// <returns></returns>
		public void Delete(int theloaiid)
		{
			objTheLoaiDA.Delete(theloaiid);
		}
		#endregion
	}
}
