using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using LibHUMG.BusinessObjects;

namespace LibHUMG.DataAccess
{
	public class TheLoaiDA
	{

		#region ***** Init Methods ***** 
		public TheLoaiDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public TheLoai Populate(IDataReader myReader)
		{
			TheLoai obj = new TheLoai();
			obj.TheLoaiID = (int) myReader["TheLoaiID"];
			obj.MaTheLoai = (int) myReader["MaTheLoai"];
			obj.TenTheLoai = (string) myReader["TenTheLoai"];
			obj.CreatedDate = (DateTime) myReader["CreatedDate"];
			obj.CreatedBy = (string) myReader["CreatedBy"];
			obj.ModifiedDate = (DateTime) myReader["ModifiedDate"];
			obj.ModifiedBy = (string) myReader["ModifiedBy"];
			return obj;
		}

		/// <summary>
		/// Get TheLoai by theloaiid
		/// </summary>
		/// <param name="theloaiid">TheLoaiID</param>
		/// <returns>TheLoai</returns>
		public TheLoai GetByTheLoaiID(int theloaiid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_TheLoai_GetByTheLoaiID", Data.CreateParameter("TheLoaiID", theloaiid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of TheLoai
		/// </summary>
		/// <returns>List<<TheLoai>></returns>
		public List<TheLoai> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_TheLoai_Get"))
			{
				List<TheLoai> list = new List<TheLoai>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of TheLoai
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TheLoai_Get");
		}


		/// <summary>
		/// Get all of TheLoai paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<TheLoai>></returns>
		public List<TheLoai> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_TheLoai_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<TheLoai> list = new List<TheLoai>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of TheLoai paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TheLoai_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new TheLoai within TheLoai database table
		/// </summary>
		/// <param name="obj">TheLoai</param>
		/// <returns>key of table</returns>
		public int Add(TheLoai obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("TheLoaiID", obj.TheLoaiID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TheLoai_Add"
							,parameterItemID
							,Data.CreateParameter("MaTheLoai", obj.MaTheLoai)
							,Data.CreateParameter("TenTheLoai", obj.TenTheLoai)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified TheLoai
		/// </summary>
		/// <param name="obj">TheLoai</param>
		/// <returns></returns>
		public void Update(TheLoai obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TheLoai_Update"
							,Data.CreateParameter("TheLoaiID", obj.TheLoaiID)
							,Data.CreateParameter("MaTheLoai", obj.MaTheLoai)
							,Data.CreateParameter("TenTheLoai", obj.TenTheLoai)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
		}

		/// <summary>
		/// Delete the specified TheLoai
		/// </summary>
		/// <param name="theloaiid">TheLoaiID</param>
		/// <returns></returns>
		public void Delete(int theloaiid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_TheLoai_Delete", Data.CreateParameter("TheLoaiID", theloaiid));
		}
		#endregion
	}
}
