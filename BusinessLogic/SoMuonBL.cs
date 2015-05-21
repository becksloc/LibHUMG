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
	public class SoMuonBL
	{

		#region ***** Init Methods ***** 
		SoMuonDA objSoMuonDA;
		public SoMuonBL()
		{
			objSoMuonDA = new SoMuonDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get SoMuon by somuonid
		/// </summary>
		/// <param name="somuonid">SoMuonID</param>
		/// <returns>SoMuon</returns>
		public SoMuon GetBySoMuonID(int somuonid)
		{
			return objSoMuonDA.GetBySoMuonID(somuonid);
		}

		/// <summary>
		/// Get all of SoMuon
		/// </summary>
		/// <returns>List<<SoMuon>></returns>
		public List<SoMuon> GetList()
		{
			return objSoMuonDA.GetList();
		}

		/// <summary>
		/// Get DataSet of SoMuon
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return objSoMuonDA.GetDataSet();
		}


		/// <summary>
		/// Get all of SoMuon paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<SoMuon>></returns>
		public List<SoMuon> GetListPaged(int recperpage, int pageindex)
		{
			return objSoMuonDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of SoMuon paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objSoMuonDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new SoMuon within SoMuon database table
		/// </summary>
		/// <param name="obj_somuon">SoMuon</param>
		/// <returns>key of table</returns>
		public int Add(SoMuon obj_somuon)
		{
			return objSoMuonDA.Add(obj_somuon);
		}

		/// <summary>
		/// updates the specified SoMuon
		/// </summary>
		/// <param name="obj_somuon">SoMuon</param>
		/// <returns></returns>
		public void Update(SoMuon obj_somuon)
		{
			objSoMuonDA.Update(obj_somuon);
		}

		/// <summary>
		/// Delete the specified SoMuon
		/// </summary>
		/// <param name="somuonid">SoMuonID</param>
		/// <returns></returns>
		public void Delete(int somuonid)
		{
			objSoMuonDA.Delete(somuonid);
		}
		#endregion
	}
}
