using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using LibHUMG.BusinessObjects;

namespace LibHUMG.DataAccess
{
	public class NxbDA
	{

		#region ***** Init Methods ***** 
		public NxbDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Nxb Populate(IDataReader myReader)
		{
			Nxb obj = new Nxb();
			obj.NxbID = (int) myReader["NxbID"];
			obj.MaNxb = (int) myReader["MaNxb"];
			obj.TenNxb = (string) myReader["TenNxb"];
			obj.CreatedDate = (DateTime) myReader["CreatedDate"];
			obj.CreatedBy = (string) myReader["CreatedBy"];
			obj.ModifiedDate = (DateTime) myReader["ModifiedDate"];
			obj.ModifiedBy = (string) myReader["ModifiedBy"];
			return obj;
		}

		/// <summary>
		/// Get Nxb by nxbid
		/// </summary>
		/// <param name="nxbid">NxbID</param>
		/// <returns>Nxb</returns>
		public Nxb GetByNxbID(int nxbid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Nxb_GetByNxbID", Data.CreateParameter("NxbID", nxbid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Nxb
		/// </summary>
		/// <returns>List<<Nxb>></returns>
		public List<Nxb> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Nxb_Get"))
			{
				List<Nxb> list = new List<Nxb>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Nxb
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Nxb_Get");
		}


		/// <summary>
		/// Get all of Nxb paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Nxb>></returns>
		public List<Nxb> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Nxb_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Nxb> list = new List<Nxb>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Nxb paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Nxb_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Nxb within Nxb database table
		/// </summary>
		/// <param name="obj">Nxb</param>
		/// <returns>key of table</returns>
		public int Add(Nxb obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("NxbID", obj.NxbID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Nxb_Add"
							,parameterItemID
							,Data.CreateParameter("MaNxb", obj.MaNxb)
							,Data.CreateParameter("TenNxb", obj.TenNxb)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified Nxb
		/// </summary>
		/// <param name="obj">Nxb</param>
		/// <returns></returns>
		public void Update(Nxb obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Nxb_Update"
							,Data.CreateParameter("NxbID", obj.NxbID)
							,Data.CreateParameter("MaNxb", obj.MaNxb)
							,Data.CreateParameter("TenNxb", obj.TenNxb)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
		}

		/// <summary>
		/// Delete the specified Nxb
		/// </summary>
		/// <param name="nxbid">NxbID</param>
		/// <returns></returns>
		public void Delete(int nxbid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Nxb_Delete", Data.CreateParameter("NxbID", nxbid));
		}
		#endregion
	}
}
