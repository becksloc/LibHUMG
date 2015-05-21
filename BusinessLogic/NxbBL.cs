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
	public class NxbBL
	{

		#region ***** Init Methods ***** 
		NxbDA objNxbDA;
		public NxbBL()
		{
			objNxbDA = new NxbDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Nxb by nxbid
		/// </summary>
		/// <param name="nxbid">NxbID</param>
		/// <returns>Nxb</returns>
		public Nxb GetByNxbID(int nxbid)
		{
			return objNxbDA.GetByNxbID(nxbid);
		}

		/// <summary>
		/// Get all of Nxb
		/// </summary>
		/// <returns>List<<Nxb>></returns>
		public List<Nxb> GetList()
		{
			return objNxbDA.GetList();
		}

		/// <summary>
		/// Get DataSet of Nxb
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return objNxbDA.GetDataSet();
		}


		/// <summary>
		/// Get all of Nxb paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Nxb>></returns>
		public List<Nxb> GetListPaged(int recperpage, int pageindex)
		{
			return objNxbDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Nxb paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objNxbDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Nxb within Nxb database table
		/// </summary>
		/// <param name="obj_nxb">Nxb</param>
		/// <returns>key of table</returns>
		public int Add(Nxb obj_nxb)
		{
			return objNxbDA.Add(obj_nxb);
		}

		/// <summary>
		/// updates the specified Nxb
		/// </summary>
		/// <param name="obj_nxb">Nxb</param>
		/// <returns></returns>
		public void Update(Nxb obj_nxb)
		{
			objNxbDA.Update(obj_nxb);
		}

		/// <summary>
		/// Delete the specified Nxb
		/// </summary>
		/// <param name="nxbid">NxbID</param>
		/// <returns></returns>
		public void Delete(int nxbid)
		{
			objNxbDA.Delete(nxbid);
		}
		#endregion
	}
}
