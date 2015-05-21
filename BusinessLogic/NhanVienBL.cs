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
	public class NhanVienBL
	{

		#region ***** Init Methods ***** 
		NhanVienDA objNhanVienDA;
		public NhanVienBL()
		{
			objNhanVienDA = new NhanVienDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get NhanVien by nhanvienid
		/// </summary>
		/// <param name="nhanvienid">NhanVienID</param>
		/// <returns>NhanVien</returns>
		public NhanVien GetByNhanVienID(int nhanvienid)
		{
			return objNhanVienDA.GetByNhanVienID(nhanvienid);
		}

		/// <summary>
		/// Get all of NhanVien
		/// </summary>
		/// <returns>List<<NhanVien>></returns>
		public List<NhanVien> GetList()
		{
			return objNhanVienDA.GetList();
		}

		/// <summary>
		/// Get DataSet of NhanVien
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return objNhanVienDA.GetDataSet();
		}


		/// <summary>
		/// Get all of NhanVien paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<NhanVien>></returns>
		public List<NhanVien> GetListPaged(int recperpage, int pageindex)
		{
			return objNhanVienDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of NhanVien paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objNhanVienDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new NhanVien within NhanVien database table
		/// </summary>
		/// <param name="obj_nhanvien">NhanVien</param>
		/// <returns>key of table</returns>
		public int Add(NhanVien obj_nhanvien)
		{
			return objNhanVienDA.Add(obj_nhanvien);
		}

		/// <summary>
		/// updates the specified NhanVien
		/// </summary>
		/// <param name="obj_nhanvien">NhanVien</param>
		/// <returns></returns>
		public void Update(NhanVien obj_nhanvien)
		{
			objNhanVienDA.Update(obj_nhanvien);
		}

		/// <summary>
		/// Delete the specified NhanVien
		/// </summary>
		/// <param name="nhanvienid">NhanVienID</param>
		/// <returns></returns>
		public void Delete(int nhanvienid)
		{
			objNhanVienDA.Delete(nhanvienid);
		}
		#endregion
	}
}
