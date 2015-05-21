using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using LibHUMG.BusinessObjects;

namespace LibHUMG.DataAccess
{
	public class DocGiaDA
	{

		#region ***** Init Methods ***** 
		public DocGiaDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public DocGia Populate(IDataReader myReader)
		{
			DocGia obj = new DocGia();
			obj.DocGiaID = (int) myReader["DocGiaID"];
			obj.MaDocGia = (int) myReader["MaDocGia"];
			obj.HoTen = (string) myReader["HoTen"];
			obj.GioiTinh = (string) myReader["GioiTinh"];
			obj.NgaySinh = (DateTime) myReader["NgaySinh"];
			obj.QueQuan = (string) myReader["QueQuan"];
			obj.DienThoai = (string) myReader["DienThoai"];
			obj.Email = (string) myReader["Email"];
			obj.NgayDangKy = (DateTime) myReader["NgayDangKy"];
			obj.NgayTaoThe = (DateTime) myReader["NgayTaoThe"];
			obj.Hansd = (DateTime) myReader["Hansd"];
			obj.TrangThai = (string) myReader["TrangThai"];
			obj.Username = (string) myReader["Username"];
			obj.Password = (string) myReader["Password"];
			obj.CreatedDate = (DateTime) myReader["CreatedDate"];
			obj.CreatedBy = (string) myReader["CreatedBy"];
			obj.ModifiedDate = (DateTime) myReader["ModifiedDate"];
			obj.ModifiedBy = (string) myReader["ModifiedBy"];
			return obj;
		}

		/// <summary>
		/// Get DocGia by docgiaid
		/// </summary>
		/// <param name="docgiaid">DocGiaID</param>
		/// <returns>DocGia</returns>
		public DocGia GetByDocGiaID(int docgiaid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DocGia_GetByDocGiaID", Data.CreateParameter("DocGiaID", docgiaid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of DocGia
		/// </summary>
		/// <returns>List<<DocGia>></returns>
		public List<DocGia> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DocGia_Get"))
			{
				List<DocGia> list = new List<DocGia>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DocGia
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DocGia_Get");
		}


		/// <summary>
		/// Get all of DocGia paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<DocGia>></returns>
		public List<DocGia> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_DocGia_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<DocGia> list = new List<DocGia>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of DocGia paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DocGia_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new DocGia within DocGia database table
		/// </summary>
		/// <param name="obj">DocGia</param>
		/// <returns>key of table</returns>
		public int Add(DocGia obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("DocGiaID", obj.DocGiaID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DocGia_Add"
							,parameterItemID
							,Data.CreateParameter("MaDocGia", obj.MaDocGia)
							,Data.CreateParameter("HoTen", obj.HoTen)
							,Data.CreateParameter("GioiTinh", obj.GioiTinh)
							,Data.CreateParameter("NgaySinh", obj.NgaySinh)
							,Data.CreateParameter("QueQuan", obj.QueQuan)
							,Data.CreateParameter("DienThoai", obj.DienThoai)
							,Data.CreateParameter("Email", obj.Email)
							,Data.CreateParameter("NgayDangKy", obj.NgayDangKy)
							,Data.CreateParameter("NgayTaoThe", obj.NgayTaoThe)
							,Data.CreateParameter("Hansd", obj.Hansd)
							,Data.CreateParameter("TrangThai", obj.TrangThai)
							,Data.CreateParameter("Username", obj.Username)
							,Data.CreateParameter("Password", obj.Password)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified DocGia
		/// </summary>
		/// <param name="obj">DocGia</param>
		/// <returns></returns>
		public void Update(DocGia obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DocGia_Update"
							,Data.CreateParameter("DocGiaID", obj.DocGiaID)
							,Data.CreateParameter("MaDocGia", obj.MaDocGia)
							,Data.CreateParameter("HoTen", obj.HoTen)
							,Data.CreateParameter("GioiTinh", obj.GioiTinh)
							,Data.CreateParameter("NgaySinh", obj.NgaySinh)
							,Data.CreateParameter("QueQuan", obj.QueQuan)
							,Data.CreateParameter("DienThoai", obj.DienThoai)
							,Data.CreateParameter("Email", obj.Email)
							,Data.CreateParameter("NgayDangKy", obj.NgayDangKy)
							,Data.CreateParameter("NgayTaoThe", obj.NgayTaoThe)
							,Data.CreateParameter("Hansd", obj.Hansd)
							,Data.CreateParameter("TrangThai", obj.TrangThai)
							,Data.CreateParameter("Username", obj.Username)
							,Data.CreateParameter("Password", obj.Password)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("CreatedBy", obj.CreatedBy)
							,Data.CreateParameter("ModifiedDate", obj.ModifiedDate)
							,Data.CreateParameter("ModifiedBy", obj.ModifiedBy)
			);
		}

		/// <summary>
		/// Delete the specified DocGia
		/// </summary>
		/// <param name="docgiaid">DocGiaID</param>
		/// <returns></returns>
		public void Delete(int docgiaid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_DocGia_Delete", Data.CreateParameter("DocGiaID", docgiaid));
		}
		#endregion
	}
}
