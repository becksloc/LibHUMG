using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using LibHUMG.BusinessObjects;

namespace LibHUMG.DataAccess
{
	public class NhanVienDA
	{

		#region ***** Init Methods ***** 
		public NhanVienDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public NhanVien Populate(IDataReader myReader)
		{
			NhanVien obj = new NhanVien();
			obj.NhanVienID = (int) myReader["NhanVienID"];
			obj.MaNV = (int) myReader["MaNV"];
			obj.TenNV = (string) myReader["TenNV"];
			obj.GioiTinh = (string) myReader["GioiTinh"];
			obj.DiaChi = (string) myReader["DiaChi"];
			obj.DienThoai = (string) myReader["DienThoai"];
			obj.Username = (string) myReader["Username"];
			obj.Password = (string) myReader["Password"];
			return obj;
		}

		/// <summary>
		/// Get NhanVien by nhanvienid
		/// </summary>
		/// <param name="nhanvienid">NhanVienID</param>
		/// <returns>NhanVien</returns>
		public NhanVien GetByNhanVienID(int nhanvienid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_NhanVien_GetByNhanVienID", Data.CreateParameter("NhanVienID", nhanvienid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of NhanVien
		/// </summary>
		/// <returns>List<<NhanVien>></returns>
		public List<NhanVien> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_NhanVien_Get"))
			{
				List<NhanVien> list = new List<NhanVien>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of NhanVien
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Get");
		}


		/// <summary>
		/// Get all of NhanVien paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<NhanVien>></returns>
		public List<NhanVien> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_NhanVien_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<NhanVien> list = new List<NhanVien>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of NhanVien paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new NhanVien within NhanVien database table
		/// </summary>
		/// <param name="obj">NhanVien</param>
		/// <returns>key of table</returns>
		public int Add(NhanVien obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("NhanVienID", obj.NhanVienID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Add"
							,parameterItemID
							,Data.CreateParameter("MaNV", obj.MaNV)
							,Data.CreateParameter("TenNV", obj.TenNV)
							,Data.CreateParameter("GioiTinh", obj.GioiTinh)
							,Data.CreateParameter("DiaChi", obj.DiaChi)
							,Data.CreateParameter("DienThoai", obj.DienThoai)
							,Data.CreateParameter("Username", obj.Username)
							,Data.CreateParameter("Password", obj.Password)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified NhanVien
		/// </summary>
		/// <param name="obj">NhanVien</param>
		/// <returns></returns>
		public void Update(NhanVien obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Update"
							,Data.CreateParameter("NhanVienID", obj.NhanVienID)
							,Data.CreateParameter("MaNV", obj.MaNV)
							,Data.CreateParameter("TenNV", obj.TenNV)
							,Data.CreateParameter("GioiTinh", obj.GioiTinh)
							,Data.CreateParameter("DiaChi", obj.DiaChi)
							,Data.CreateParameter("DienThoai", obj.DienThoai)
							,Data.CreateParameter("Username", obj.Username)
							,Data.CreateParameter("Password", obj.Password)
			);
		}

		/// <summary>
		/// Delete the specified NhanVien
		/// </summary>
		/// <param name="nhanvienid">NhanVienID</param>
		/// <returns></returns>
		public void Delete(int nhanvienid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_NhanVien_Delete", Data.CreateParameter("NhanVienID", nhanvienid));
		}
		#endregion
	}
}
