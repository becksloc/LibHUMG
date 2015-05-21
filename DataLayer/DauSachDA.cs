using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using LibHUMG.BusinessObjects;

namespace LibHUMG.DataAccess
{
	public class DauSachDA
	{

		#region ***** Init Methods ***** 
		public DauSachDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public DauSach Populate(IDataReader myReader)
		{
			DauSach obj = new DauSach();
			obj.DauSachID = (int) myReader["DauSachID"];
			obj.MaDauSach = (int) myReader["MaDauSach"];
			obj.TacGiaID = (int) myReader["TacGiaID"];
			obj.NxbID = (int) myReader["NxbID"];
			obj.TheLoaiID = (int) myReader["TheLoaiID"];
			obj.TenSach = (string) myReader["TenSach"];
			obj.TomTat = (string) myReader["TomTat"];
			obj.TuKhoa = (string) myReader["TuKhoa"];
			obj.ThoiHan = (string) myReader["ThoiHan"];
			obj.TongLuotMuon = (int) myReader["TongLuotMuon"];
			obj.SoCuonCon = (int) myReader["SoCuonCon"];
			obj.CreatedDate = (DateTime) myReader["CreatedDate"];
			obj.CreatedBy = (string) myReader["CreatedBy"];
			obj.ModifiedDate = (DateTime) myReader["ModifiedDate"];
			obj.ModifiedBy = (string) myReader["ModifiedBy"];
			return obj;
		}

		/// <summary>
		/// Get DauSach by dausachid
		/// </summary>
		/// <param name="dausachid">DauSachID</param>
		/// <returns>DauSach</returns>
		public DauSach GetByDauSachID(int dausachid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DauSach_GetByDauSachID", Data.CreateParameter("DauSachID", dausachid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of DauSach
		/// </summary>
		/// <returns>List<<DauSach>></returns>
		public List<DauSach> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DauSach_Get"))
			{
				List<DauSach> list = new List<DauSach>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DauSach
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DauSach_Get");
		}


		/// <summary>
		/// Get all of DauSach paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<DauSach>></returns>
		public List<DauSach> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DauSach_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<DauSach> list = new List<DauSach>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DauSach paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DauSach_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DauSach within DauSach database table
		/// </summary>
		/// <param name="obj">DauSach</param>
		/// <returns>key of table</returns>
		public int Add(DauSach obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("DauSachID", obj.DauSachID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DauSach_Add"
							,parameterItemID
							,Data.CreateParameter("MaDauSach", obj.MaDauSach)
							,Data.CreateParameter("TacGiaID", obj.TacGiaID)
							,Data.CreateParameter("NxbID", obj.NxbID)
							,Data.CreateParameter("TheLoaiID", obj.TheLoaiID)
							,Data.CreateParameter("TenSach", obj.TenSach)
							,Data.CreateParameter("TomTat", obj.TomTat)
							,Data.CreateParameter("TuKhoa", obj.TuKhoa)
							,Data.CreateParameter("ThoiHan", obj.ThoiHan)
							,Data.CreateParameter("TongLuotMuon", obj.TongLuotMuon)
							,Data.CreateParameter("SoCuonCon", obj.SoCuonCon)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified DauSach
		/// </summary>
		/// <param name="obj">DauSach</param>
		/// <returns></returns>
		public void Update(DauSach obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DauSach_Update"
							,Data.CreateParameter("DauSachID", obj.DauSachID)
							,Data.CreateParameter("MaDauSach", obj.MaDauSach)
							,Data.CreateParameter("TacGiaID", obj.TacGiaID)
							,Data.CreateParameter("NxbID", obj.NxbID)
							,Data.CreateParameter("TheLoaiID", obj.TheLoaiID)
							,Data.CreateParameter("TenSach", obj.TenSach)
							,Data.CreateParameter("TomTat", obj.TomTat)
							,Data.CreateParameter("TuKhoa", obj.TuKhoa)
							,Data.CreateParameter("ThoiHan", obj.ThoiHan)
							,Data.CreateParameter("TongLuotMuon", obj.TongLuotMuon)
							,Data.CreateParameter("SoCuonCon", obj.SoCuonCon)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
		}

		/// <summary>
		/// Delete the specified DauSach
		/// </summary>
		/// <param name="dausachid">DauSachID</param>
		/// <returns></returns>
		public void Delete(int dausachid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DauSach_Delete", Data.CreateParameter("DauSachID", dausachid));
		}
		#endregion
	}
}
