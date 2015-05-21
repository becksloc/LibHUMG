using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using LibHUMG.BusinessObjects;

namespace LibHUMG.DataAccess
{
	public class CuonSachDA
	{

		#region ***** Init Methods ***** 
		public CuonSachDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public CuonSach Populate(IDataReader myReader)
		{
			CuonSach obj = new CuonSach();
			obj.CuonSachID = (int) myReader["CuonSachID"];
			obj.MaCuonSach = (int) myReader["MaCuonSach"];
			obj.DauSachID = (int) myReader["DauSachID"];
			obj.ViTri = (string) myReader["ViTri"];
			obj.LuotXem = (string) myReader["LuotXem"];
			obj.TinhTrang = (string) myReader["TinhTrang"];
			obj.CreatedDate = (DateTime) myReader["CreatedDate"];
			obj.CreatedBy = (string) myReader["CreatedBy"];
			obj.ModifiedDate = (DateTime) myReader["ModifiedDate"];
			obj.ModifiedBy = (string) myReader["ModifiedBy"];
			return obj;
		}

		/// <summary>
		/// Get CuonSach by cuonsachid
		/// </summary>
		/// <param name="cuonsachid">CuonSachID</param>
		/// <returns>CuonSach</returns>
		public CuonSach GetByCuonSachID(int cuonsachid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_CuonSach_GetByCuonSachID", Data.CreateParameter("CuonSachID", cuonsachid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of CuonSach
		/// </summary>
		/// <returns>List<<CuonSach>></returns>
		public List<CuonSach> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_CuonSach_Get"))
			{
				List<CuonSach> list = new List<CuonSach>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of CuonSach
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CuonSach_Get");
		}


		/// <summary>
		/// Get all of CuonSach paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<CuonSach>></returns>
		public List<CuonSach> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_CuonSach_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<CuonSach> list = new List<CuonSach>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of CuonSach paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CuonSach_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new CuonSach within CuonSach database table
		/// </summary>
		/// <param name="obj">CuonSach</param>
		/// <returns>key of table</returns>
		public int Add(CuonSach obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("CuonSachID", obj.CuonSachID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CuonSach_Add"
							,parameterItemID
							,Data.CreateParameter("MaCuonSach", obj.MaCuonSach)
							,Data.CreateParameter("DauSachID", obj.DauSachID)
							,Data.CreateParameter("ViTri", obj.ViTri)
							,Data.CreateParameter("LuotXem", obj.LuotXem)
							,Data.CreateParameter("TinhTrang", obj.TinhTrang)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified CuonSach
		/// </summary>
		/// <param name="obj">CuonSach</param>
		/// <returns></returns>
		public void Update(CuonSach obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CuonSach_Update"
							,Data.CreateParameter("CuonSachID", obj.CuonSachID)
							,Data.CreateParameter("MaCuonSach", obj.MaCuonSach)
							,Data.CreateParameter("DauSachID", obj.DauSachID)
							,Data.CreateParameter("ViTri", obj.ViTri)
							,Data.CreateParameter("LuotXem", obj.LuotXem)
							,Data.CreateParameter("TinhTrang", obj.TinhTrang)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
		}

		/// <summary>
		/// Delete the specified CuonSach
		/// </summary>
		/// <param name="cuonsachid">CuonSachID</param>
		/// <returns></returns>
		public void Delete(int cuonsachid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_CuonSach_Delete", Data.CreateParameter("CuonSachID", cuonsachid));
		}
		#endregion
	}
}
