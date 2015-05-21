using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using LibHUMG.BusinessObjects;

namespace LibHUMG.DataAccess
{
	public class TacGiaDA
	{

		#region ***** Init Methods ***** 
		public TacGiaDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public TacGia Populate(IDataReader myReader)
		{
			TacGia obj = new TacGia();
			obj.TacGiaID = (int) myReader["TacGiaID"];
			obj.MaTacGia = (int) myReader["MaTacGia"];
			obj.TenTacGia = (string) myReader["TenTacGia"];
			obj.CreatedDate = (DateTime) myReader["CreatedDate"];
			obj.CreatedBy = (string) myReader["CreatedBy"];
			obj.ModifiedDate = (DateTime) myReader["ModifiedDate"];
			obj.ModifiedBy = (string) myReader["ModifiedBy"];
			return obj;
		}

		/// <summary>
		/// Get TacGia by tacgiaid
		/// </summary>
		/// <param name="tacgiaid">TacGiaID</param>
		/// <returns>TacGia</returns>
		public TacGia GetByTacGiaID(int tacgiaid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_TacGia_GetByTacGiaID", Data.CreateParameter("TacGiaID", tacgiaid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of TacGia
		/// </summary>
		/// <returns>List<<TacGia>></returns>
		public List<TacGia> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_TacGia_Get"))
			{
				List<TacGia> list = new List<TacGia>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of TacGia
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TacGia_Get");
		}


		/// <summary>
		/// Get all of TacGia paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<TacGia>></returns>
		public List<TacGia> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_TacGia_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<TacGia> list = new List<TacGia>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of TacGia paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TacGia_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new TacGia within TacGia database table
		/// </summary>
		/// <param name="obj">TacGia</param>
		/// <returns>key of table</returns>
		public int Add(TacGia obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("TacGiaID", obj.TacGiaID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TacGia_Add"
							,parameterItemID
							,Data.CreateParameter("MaTacGia", obj.MaTacGia)
							,Data.CreateParameter("TenTacGia", obj.TenTacGia)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified TacGia
		/// </summary>
		/// <param name="obj">TacGia</param>
		/// <returns></returns>
		public void Update(TacGia obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TacGia_Update"
							,Data.CreateParameter("TacGiaID", obj.TacGiaID)
							,Data.CreateParameter("MaTacGia", obj.MaTacGia)
							,Data.CreateParameter("TenTacGia", obj.TenTacGia)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
		}

		/// <summary>
		/// Delete the specified TacGia
		/// </summary>
		/// <param name="tacgiaid">TacGiaID</param>
		/// <returns></returns>
		public void Delete(int tacgiaid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TacGia_Delete", Data.CreateParameter("TacGiaID", tacgiaid));
		}
		#endregion
	}
}
