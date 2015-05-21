using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using LibHUMG.BusinessObjects;

namespace LibHUMG.DataAccess
{
	public class SoMuonDA
	{

		#region ***** Init Methods ***** 
		public SoMuonDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public SoMuon Populate(IDataReader myReader)
		{
			SoMuon obj = new SoMuon();
			obj.SoMuonID = (int) myReader["SoMuonID"];
			obj.CuonSachID = (int) myReader["CuonSachID"];
			obj.DocGiaID = (int) myReader["DocGiaID"];
			obj.NgayMuon = (DateTime) myReader["NgayMuon"];
			obj.NgayTra = (DateTime) myReader["NgayTra"];
			obj.TienPhat = (decimal) myReader["TienPhat"];
			obj.CreatedDate = (DateTime) myReader["CreatedDate"];
			obj.CreatedBy = (string) myReader["CreatedBy"];
			obj.ModifiedDate = (DateTime) myReader["ModifiedDate"];
			obj.ModifiedBy = (string) myReader["ModifiedBy"];
			return obj;
		}

		/// <summary>
		/// Get SoMuon by somuonid
		/// </summary>
		/// <param name="somuonid">SoMuonID</param>
		/// <returns>SoMuon</returns>
		public SoMuon GetBySoMuonID(int somuonid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_SoMuon_GetBySoMuonID", Data.CreateParameter("SoMuonID", somuonid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of SoMuon
		/// </summary>
		/// <returns>List<<SoMuon>></returns>
		public List<SoMuon> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_SoMuon_Get"))
			{
				List<SoMuon> list = new List<SoMuon>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of SoMuon
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_SoMuon_Get");
		}


		/// <summary>
		/// Get all of SoMuon paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<SoMuon>></returns>
		public List<SoMuon> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_SoMuon_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<SoMuon> list = new List<SoMuon>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of SoMuon paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_SoMuon_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new SoMuon within SoMuon database table
		/// </summary>
		/// <param name="obj">SoMuon</param>
		/// <returns>key of table</returns>
		public int Add(SoMuon obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("SoMuonID", obj.SoMuonID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_SoMuon_Add"
							,parameterItemID
							,Data.CreateParameter("CuonSachID", obj.CuonSachID)
							,Data.CreateParameter("DocGiaID", obj.DocGiaID)
							,Data.CreateParameter("NgayMuon", obj.NgayMuon)
							,Data.CreateParameter("NgayTra", obj.NgayTra)
							,Data.CreateParameter("TienPhat", obj.TienPhat)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified SoMuon
		/// </summary>
		/// <param name="obj">SoMuon</param>
		/// <returns></returns>
		public void Update(SoMuon obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_SoMuon_Update"
							,Data.CreateParameter("SoMuonID", obj.SoMuonID)
							,Data.CreateParameter("CuonSachID", obj.CuonSachID)
							,Data.CreateParameter("DocGiaID", obj.DocGiaID)
							,Data.CreateParameter("NgayMuon", obj.NgayMuon)
							,Data.CreateParameter("NgayTra", obj.NgayTra)
							,Data.CreateParameter("TienPhat", obj.TienPhat)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
		}

		/// <summary>
		/// Delete the specified SoMuon
		/// </summary>
		/// <param name="somuonid">SoMuonID</param>
		/// <returns></returns>
		public void Delete(int somuonid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_SoMuon_Delete", Data.CreateParameter("SoMuonID", somuonid));
		}
		#endregion
	}
}
