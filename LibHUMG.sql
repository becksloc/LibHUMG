if exists (select * from sysobjects where id = object_id(N'[sproc_CuonSach_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CuonSach_GetCount]
GO

/* Procedure sproc_CuonSach_GetCount*/
CREATE PROCEDURE sproc_CuonSach_GetCount
AS
SELECT
	COUNT(*)
FROM
	[CuonSach]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_CuonSach_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CuonSach_Get]
GO

/* Procedure sproc_CuonSach_Get*/
CREATE PROCEDURE sproc_CuonSach_Get
AS
SELECT
	--[CuonSachID],
	--[MaCuonSach],
	--[DauSachID],
	--[ViTri],
	--[LuotXem],
	--[TinhTrang],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[CuonSach]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_CuonSach_GetByCuonSachID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CuonSach_GetByCuonSachID]
GO

/* Procedure sproc_CuonSach_GetByCuonSachID*/
CREATE PROCEDURE sproc_CuonSach_GetByCuonSachID
@CuonSachID int
AS
SELECT
	--[CuonSachID],
	--[MaCuonSach],
	--[DauSachID],
	--[ViTri],
	--[LuotXem],
	--[TinhTrang],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[CuonSach]
WHERE
	[CuonSachID] = @CuonSachID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_CuonSach_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CuonSach_GetPaged]
GO

/* Procedure sproc_CuonSach_GetPaged*/
CREATE PROCEDURE sproc_CuonSach_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [CuonSachID]
FROM [CuonSach]


-- query out
SELECT *
FROM [CuonSach]
WHERE [CuonSachID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_CuonSach_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CuonSach_Add]
GO

/* Procedure sproc_CuonSach_Add*/
CREATE PROCEDURE sproc_CuonSach_Add
	@CuonSachID int OUTPUT
	,@MaCuonSach int
	,@DauSachID int
	,@ViTri nvarchar(50)
	,@LuotXem nvarchar(50)
	,@TinhTrang nvarchar(50)
	,@CreatedDate smalldatetime
	,@CreatedBy nvarchar(50)
	,@ModifiedDate smalldatetime
	,@ModifiedBy nvarchar(50)

AS

	INSERT INTO [CuonSach]
	(
		[CuonSachID],
		[MaCuonSach],
		[DauSachID],
		[ViTri],
		[LuotXem],
		[TinhTrang],
		[CreatedDate],
		[CreatedBy],
		[ModifiedDate],
		[ModifiedBy]
	)
	VALUES
	(
		@CuonSachID,
		@MaCuonSach,
		@DauSachID,
		@ViTri,
		@LuotXem,
		@TinhTrang,
		@CreatedDate,
		@CreatedBy,
		@ModifiedDate,
		@ModifiedBy
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_CuonSach_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CuonSach_Update]
GO

/* Procedure sproc_CuonSach_Update*/
CREATE PROCEDURE sproc_CuonSach_Update
	@MaCuonSach int,
	@DauSachID int,
	@ViTri nvarchar(50),
	@LuotXem nvarchar(50),
	@TinhTrang nvarchar(50),
	@CreatedDate smalldatetime,
	@CreatedBy nvarchar(50),
	@ModifiedDate smalldatetime,
	@ModifiedBy nvarchar(50),
	@CuonSachID int

AS
UPDATE [CuonSach]
SET
	[MaCuonSach] = @MaCuonSach,
	[DauSachID] = @DauSachID,
	[ViTri] = @ViTri,
	[LuotXem] = @LuotXem,
	[TinhTrang] = @TinhTrang,
	[CreatedDate] = @CreatedDate,
	[CreatedBy] = @CreatedBy,
	[ModifiedDate] = @ModifiedDate,
	[ModifiedBy] = @ModifiedBy
WHERE
	[CuonSachID] = @CuonSachID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_CuonSach_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CuonSach_Delete]
GO

/* Procedure sproc_CuonSach_Delete*/
CREATE PROCEDURE sproc_CuonSach_Delete
	@CuonSachID int
AS
DELETE
FROM
	[CuonSach]
WHERE
	[CuonSachID] = @CuonSachID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DauSach_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DauSach_GetCount]
GO

/* Procedure sproc_DauSach_GetCount*/
CREATE PROCEDURE sproc_DauSach_GetCount
AS
SELECT
	COUNT(*)
FROM
	[DauSach]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DauSach_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DauSach_Get]
GO

/* Procedure sproc_DauSach_Get*/
CREATE PROCEDURE sproc_DauSach_Get
AS
SELECT
	--[DauSachID],
	--[MaDauSach],
	--[TacGiaID],
	--[NxbID],
	--[TheLoaiID],
	--[TenSach],
	--[TomTat],
	--[TuKhoa],
	--[ThoiHan],
	--[TongLuotMuon],
	--[SoCuonCon],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[DauSach]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DauSach_GetByDauSachID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DauSach_GetByDauSachID]
GO

/* Procedure sproc_DauSach_GetByDauSachID*/
CREATE PROCEDURE sproc_DauSach_GetByDauSachID
@DauSachID int
AS
SELECT
	--[DauSachID],
	--[MaDauSach],
	--[TacGiaID],
	--[NxbID],
	--[TheLoaiID],
	--[TenSach],
	--[TomTat],
	--[TuKhoa],
	--[ThoiHan],
	--[TongLuotMuon],
	--[SoCuonCon],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[DauSach]
WHERE
	[DauSachID] = @DauSachID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DauSach_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DauSach_GetPaged]
GO

/* Procedure sproc_DauSach_GetPaged*/
CREATE PROCEDURE sproc_DauSach_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [DauSachID]
FROM [DauSach]


-- query out
SELECT *
FROM [DauSach]
WHERE [DauSachID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DauSach_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DauSach_Add]
GO

/* Procedure sproc_DauSach_Add*/
CREATE PROCEDURE sproc_DauSach_Add
	@DauSachID int OUTPUT
	,@MaDauSach int
	,@TacGiaID int
	,@NxbID int
	,@TheLoaiID int
	,@TenSach nvarchar(200)
	,@TomTat nvarchar(1000)
	,@TuKhoa nvarchar(200)
	,@ThoiHan varchar(50)
	,@TongLuotMuon int
	,@SoCuonCon int
	,@CreatedDate smalldatetime
	,@CreatedBy nvarchar(50)
	,@ModifiedDate smalldatetime
	,@ModifiedBy nvarchar(50)

AS

	INSERT INTO [DauSach]
	(
		[DauSachID],
		[MaDauSach],
		[TacGiaID],
		[NxbID],
		[TheLoaiID],
		[TenSach],
		[TomTat],
		[TuKhoa],
		[ThoiHan],
		[TongLuotMuon],
		[SoCuonCon],
		[CreatedDate],
		[CreatedBy],
		[ModifiedDate],
		[ModifiedBy]
	)
	VALUES
	(
		@DauSachID,
		@MaDauSach,
		@TacGiaID,
		@NxbID,
		@TheLoaiID,
		@TenSach,
		@TomTat,
		@TuKhoa,
		@ThoiHan,
		@TongLuotMuon,
		@SoCuonCon,
		@CreatedDate,
		@CreatedBy,
		@ModifiedDate,
		@ModifiedBy
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_DauSach_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DauSach_Update]
GO

/* Procedure sproc_DauSach_Update*/
CREATE PROCEDURE sproc_DauSach_Update
	@MaDauSach int,
	@TacGiaID int,
	@NxbID int,
	@TheLoaiID int,
	@TenSach nvarchar(200),
	@TomTat nvarchar(1000),
	@TuKhoa nvarchar(200),
	@ThoiHan varchar(50),
	@TongLuotMuon int,
	@SoCuonCon int,
	@CreatedDate smalldatetime,
	@CreatedBy nvarchar(50),
	@ModifiedDate smalldatetime,
	@ModifiedBy nvarchar(50),
	@DauSachID int

AS
UPDATE [DauSach]
SET
	[MaDauSach] = @MaDauSach,
	[TacGiaID] = @TacGiaID,
	[NxbID] = @NxbID,
	[TheLoaiID] = @TheLoaiID,
	[TenSach] = @TenSach,
	[TomTat] = @TomTat,
	[TuKhoa] = @TuKhoa,
	[ThoiHan] = @ThoiHan,
	[TongLuotMuon] = @TongLuotMuon,
	[SoCuonCon] = @SoCuonCon,
	[CreatedDate] = @CreatedDate,
	[CreatedBy] = @CreatedBy,
	[ModifiedDate] = @ModifiedDate,
	[ModifiedBy] = @ModifiedBy
WHERE
	[DauSachID] = @DauSachID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DauSach_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DauSach_Delete]
GO

/* Procedure sproc_DauSach_Delete*/
CREATE PROCEDURE sproc_DauSach_Delete
	@DauSachID int
AS
DELETE
FROM
	[DauSach]
WHERE
	[DauSachID] = @DauSachID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DocGia_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DocGia_GetCount]
GO

/* Procedure sproc_DocGia_GetCount*/
CREATE PROCEDURE sproc_DocGia_GetCount
AS
SELECT
	COUNT(*)
FROM
	[DocGia]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DocGia_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DocGia_Get]
GO

/* Procedure sproc_DocGia_Get*/
CREATE PROCEDURE sproc_DocGia_Get
AS
SELECT
	--[DocGiaID],
	--[MaDocGia],
	--[HoTen],
	--[GioiTinh],
	--[NgaySinh],
	--[QueQuan],
	--[DienThoai],
	--[Email],
	--[NgayDangKy],
	--[NgayTaoThe],
	--[Hansd],
	--[TrangThai],
	--[Username],
	--[Password],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[DocGia]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DocGia_GetByDocGiaID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DocGia_GetByDocGiaID]
GO

/* Procedure sproc_DocGia_GetByDocGiaID*/
CREATE PROCEDURE sproc_DocGia_GetByDocGiaID
@DocGiaID int
AS
SELECT
	--[DocGiaID],
	--[MaDocGia],
	--[HoTen],
	--[GioiTinh],
	--[NgaySinh],
	--[QueQuan],
	--[DienThoai],
	--[Email],
	--[NgayDangKy],
	--[NgayTaoThe],
	--[Hansd],
	--[TrangThai],
	--[Username],
	--[Password],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[DocGia]
WHERE
	[DocGiaID] = @DocGiaID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DocGia_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DocGia_GetPaged]
GO

/* Procedure sproc_DocGia_GetPaged*/
CREATE PROCEDURE sproc_DocGia_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [DocGiaID]
FROM [DocGia]


-- query out
SELECT *
FROM [DocGia]
WHERE [DocGiaID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DocGia_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DocGia_Add]
GO

/* Procedure sproc_DocGia_Add*/
CREATE PROCEDURE sproc_DocGia_Add
	@DocGiaID int OUTPUT
	,@MaDocGia int
	,@HoTen varchar(50)
	,@GioiTinh varchar(10)
	,@NgaySinh datetime
	,@QueQuan varchar(50)
	,@DienThoai varchar(20)
	,@Email varchar(50)
	,@NgayDangKy datetime
	,@NgayTaoThe datetime
	,@Hansd datetime
	,@TrangThai varchar(50)
	,@Username varchar(50)
	,@Password varchar(50)
	,@CreatedDate smalldatetime
	,@CreatedBy nvarchar(50)
	,@ModifiedDate smalldatetime
	,@ModifiedBy nvarchar(50)

AS

	INSERT INTO [DocGia]
	(
		[DocGiaID],
		[MaDocGia],
		[HoTen],
		[GioiTinh],
		[NgaySinh],
		[QueQuan],
		[DienThoai],
		[Email],
		[NgayDangKy],
		[NgayTaoThe],
		[Hansd],
		[TrangThai],
		[Username],
		[Password],
		[CreatedDate],
		[CreatedBy],
		[ModifiedDate],
		[ModifiedBy]
	)
	VALUES
	(
		@DocGiaID,
		@MaDocGia,
		@HoTen,
		@GioiTinh,
		@NgaySinh,
		@QueQuan,
		@DienThoai,
		@Email,
		@NgayDangKy,
		@NgayTaoThe,
		@Hansd,
		@TrangThai,
		@Username,
		@Password,
		@CreatedDate,
		@CreatedBy,
		@ModifiedDate,
		@ModifiedBy
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_DocGia_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DocGia_Update]
GO

/* Procedure sproc_DocGia_Update*/
CREATE PROCEDURE sproc_DocGia_Update
	@MaDocGia int,
	@HoTen varchar(50),
	@GioiTinh varchar(10),
	@NgaySinh datetime,
	@QueQuan varchar(50),
	@DienThoai varchar(20),
	@Email varchar(50),
	@NgayDangKy datetime,
	@NgayTaoThe datetime,
	@Hansd datetime,
	@TrangThai varchar(50),
	@Username varchar(50),
	@Password varchar(50),
	@CreatedDate smalldatetime,
	@CreatedBy nvarchar(50),
	@ModifiedDate smalldatetime,
	@ModifiedBy nvarchar(50),
	@DocGiaID int

AS
UPDATE [DocGia]
SET
	[MaDocGia] = @MaDocGia,
	[HoTen] = @HoTen,
	[GioiTinh] = @GioiTinh,
	[NgaySinh] = @NgaySinh,
	[QueQuan] = @QueQuan,
	[DienThoai] = @DienThoai,
	[Email] = @Email,
	[NgayDangKy] = @NgayDangKy,
	[NgayTaoThe] = @NgayTaoThe,
	[Hansd] = @Hansd,
	[TrangThai] = @TrangThai,
	[Username] = @Username,
	[Password] = @Password,
	[CreatedDate] = @CreatedDate,
	[CreatedBy] = @CreatedBy,
	[ModifiedDate] = @ModifiedDate,
	[ModifiedBy] = @ModifiedBy
WHERE
	[DocGiaID] = @DocGiaID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DocGia_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DocGia_Delete]
GO

/* Procedure sproc_DocGia_Delete*/
CREATE PROCEDURE sproc_DocGia_Delete
	@DocGiaID int
AS
DELETE
FROM
	[DocGia]
WHERE
	[DocGiaID] = @DocGiaID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_GetCount]
GO

/* Procedure sproc_NhanVien_GetCount*/
CREATE PROCEDURE sproc_NhanVien_GetCount
AS
SELECT
	COUNT(*)
FROM
	[NhanVien]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Get]
GO

/* Procedure sproc_NhanVien_Get*/
CREATE PROCEDURE sproc_NhanVien_Get
AS
SELECT
	--[NhanVienID],
	--[MaNV],
	--[TenNV],
	--[GioiTinh],
	--[DiaChi],
	--[DienThoai],
	--[Username],
	--[Password]

*
FROM
	[NhanVien]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_GetByNhanVienID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_GetByNhanVienID]
GO

/* Procedure sproc_NhanVien_GetByNhanVienID*/
CREATE PROCEDURE sproc_NhanVien_GetByNhanVienID
@NhanVienID int
AS
SELECT
	--[NhanVienID],
	--[MaNV],
	--[TenNV],
	--[GioiTinh],
	--[DiaChi],
	--[DienThoai],
	--[Username],
	--[Password]

*
FROM
	[NhanVien]
WHERE
	[NhanVienID] = @NhanVienID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_GetPaged]
GO

/* Procedure sproc_NhanVien_GetPaged*/
CREATE PROCEDURE sproc_NhanVien_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [NhanVienID]
FROM [NhanVien]


-- query out
SELECT *
FROM [NhanVien]
WHERE [NhanVienID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Add]
GO

/* Procedure sproc_NhanVien_Add*/
CREATE PROCEDURE sproc_NhanVien_Add
	@NhanVienID int OUTPUT
	,@MaNV int
	,@TenNV varchar(50)
	,@GioiTinh varchar(10)
	,@DiaChi varchar(50)
	,@DienThoai varchar(20)
	,@Username varchar(50)
	,@Password varchar(50)

AS

	INSERT INTO [NhanVien]
	(
		[NhanVienID],
		[MaNV],
		[TenNV],
		[GioiTinh],
		[DiaChi],
		[DienThoai],
		[Username],
		[Password]
	)
	VALUES
	(
		@NhanVienID,
		@MaNV,
		@TenNV,
		@GioiTinh,
		@DiaChi,
		@DienThoai,
		@Username,
		@Password
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Update]
GO

/* Procedure sproc_NhanVien_Update*/
CREATE PROCEDURE sproc_NhanVien_Update
	@MaNV int,
	@TenNV varchar(50),
	@GioiTinh varchar(10),
	@DiaChi varchar(50),
	@DienThoai varchar(20),
	@Username varchar(50),
	@Password varchar(50),
	@NhanVienID int

AS
UPDATE [NhanVien]
SET
	[MaNV] = @MaNV,
	[TenNV] = @TenNV,
	[GioiTinh] = @GioiTinh,
	[DiaChi] = @DiaChi,
	[DienThoai] = @DienThoai,
	[Username] = @Username,
	[Password] = @Password
WHERE
	[NhanVienID] = @NhanVienID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Delete]
GO

/* Procedure sproc_NhanVien_Delete*/
CREATE PROCEDURE sproc_NhanVien_Delete
	@NhanVienID int
AS
DELETE
FROM
	[NhanVien]
WHERE
	[NhanVienID] = @NhanVienID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Nxb_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Nxb_GetCount]
GO

/* Procedure sproc_Nxb_GetCount*/
CREATE PROCEDURE sproc_Nxb_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Nxb]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Nxb_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Nxb_Get]
GO

/* Procedure sproc_Nxb_Get*/
CREATE PROCEDURE sproc_Nxb_Get
AS
SELECT
	--[NxbID],
	--[MaNxb],
	--[TenNxb],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[Nxb]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Nxb_GetByNxbID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Nxb_GetByNxbID]
GO

/* Procedure sproc_Nxb_GetByNxbID*/
CREATE PROCEDURE sproc_Nxb_GetByNxbID
@NxbID int
AS
SELECT
	--[NxbID],
	--[MaNxb],
	--[TenNxb],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[Nxb]
WHERE
	[NxbID] = @NxbID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Nxb_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Nxb_GetPaged]
GO

/* Procedure sproc_Nxb_GetPaged*/
CREATE PROCEDURE sproc_Nxb_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [NxbID]
FROM [Nxb]


-- query out
SELECT *
FROM [Nxb]
WHERE [NxbID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Nxb_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Nxb_Add]
GO

/* Procedure sproc_Nxb_Add*/
CREATE PROCEDURE sproc_Nxb_Add
	@NxbID int OUTPUT
	,@MaNxb int
	,@TenNxb varchar(50)
	,@CreatedDate smalldatetime
	,@CreatedBy nvarchar(50)
	,@ModifiedDate smalldatetime
	,@ModifiedBy nvarchar(50)

AS

	INSERT INTO [Nxb]
	(
		[NxbID],
		[MaNxb],
		[TenNxb],
		[CreatedDate],
		[CreatedBy],
		[ModifiedDate],
		[ModifiedBy]
	)
	VALUES
	(
		@NxbID,
		@MaNxb,
		@TenNxb,
		@CreatedDate,
		@CreatedBy,
		@ModifiedDate,
		@ModifiedBy
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Nxb_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Nxb_Update]
GO

/* Procedure sproc_Nxb_Update*/
CREATE PROCEDURE sproc_Nxb_Update
	@MaNxb int,
	@TenNxb varchar(50),
	@CreatedDate smalldatetime,
	@CreatedBy nvarchar(50),
	@ModifiedDate smalldatetime,
	@ModifiedBy nvarchar(50),
	@NxbID int

AS
UPDATE [Nxb]
SET
	[MaNxb] = @MaNxb,
	[TenNxb] = @TenNxb,
	[CreatedDate] = @CreatedDate,
	[CreatedBy] = @CreatedBy,
	[ModifiedDate] = @ModifiedDate,
	[ModifiedBy] = @ModifiedBy
WHERE
	[NxbID] = @NxbID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Nxb_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Nxb_Delete]
GO

/* Procedure sproc_Nxb_Delete*/
CREATE PROCEDURE sproc_Nxb_Delete
	@NxbID int
AS
DELETE
FROM
	[Nxb]
WHERE
	[NxbID] = @NxbID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_SoMuon_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_SoMuon_GetCount]
GO

/* Procedure sproc_SoMuon_GetCount*/
CREATE PROCEDURE sproc_SoMuon_GetCount
AS
SELECT
	COUNT(*)
FROM
	[SoMuon]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_SoMuon_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_SoMuon_Get]
GO

/* Procedure sproc_SoMuon_Get*/
CREATE PROCEDURE sproc_SoMuon_Get
AS
SELECT
	--[SoMuonID],
	--[CuonSachID],
	--[DocGiaID],
	--[NgayMuon],
	--[NgayTra],
	--[TienPhat],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[SoMuon]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_SoMuon_GetBySoMuonID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_SoMuon_GetBySoMuonID]
GO

/* Procedure sproc_SoMuon_GetBySoMuonID*/
CREATE PROCEDURE sproc_SoMuon_GetBySoMuonID
@SoMuonID int
AS
SELECT
	--[SoMuonID],
	--[CuonSachID],
	--[DocGiaID],
	--[NgayMuon],
	--[NgayTra],
	--[TienPhat],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[SoMuon]
WHERE
	[SoMuonID] = @SoMuonID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_SoMuon_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_SoMuon_GetPaged]
GO

/* Procedure sproc_SoMuon_GetPaged*/
CREATE PROCEDURE sproc_SoMuon_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [SoMuonID]
FROM [SoMuon]


-- query out
SELECT *
FROM [SoMuon]
WHERE [SoMuonID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_SoMuon_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_SoMuon_Add]
GO

/* Procedure sproc_SoMuon_Add*/
CREATE PROCEDURE sproc_SoMuon_Add
	@SoMuonID int OUTPUT
	,@CuonSachID int
	,@DocGiaID int
	,@NgayMuon smalldatetime
	,@NgayTra smalldatetime
	,@TienPhat money
	,@CreatedDate smalldatetime
	,@CreatedBy nvarchar(50)
	,@ModifiedDate smalldatetime
	,@ModifiedBy nvarchar(50)

AS

	INSERT INTO [SoMuon]
	(
		[SoMuonID],
		[CuonSachID],
		[DocGiaID],
		[NgayMuon],
		[NgayTra],
		[TienPhat],
		[CreatedDate],
		[CreatedBy],
		[ModifiedDate],
		[ModifiedBy]
	)
	VALUES
	(
		@SoMuonID,
		@CuonSachID,
		@DocGiaID,
		@NgayMuon,
		@NgayTra,
		@TienPhat,
		@CreatedDate,
		@CreatedBy,
		@ModifiedDate,
		@ModifiedBy
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_SoMuon_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_SoMuon_Update]
GO

/* Procedure sproc_SoMuon_Update*/
CREATE PROCEDURE sproc_SoMuon_Update
	@CuonSachID int,
	@DocGiaID int,
	@NgayMuon smalldatetime,
	@NgayTra smalldatetime,
	@TienPhat money,
	@CreatedDate smalldatetime,
	@CreatedBy nvarchar(50),
	@ModifiedDate smalldatetime,
	@ModifiedBy nvarchar(50),
	@SoMuonID int

AS
UPDATE [SoMuon]
SET
	[CuonSachID] = @CuonSachID,
	[DocGiaID] = @DocGiaID,
	[NgayMuon] = @NgayMuon,
	[NgayTra] = @NgayTra,
	[TienPhat] = @TienPhat,
	[CreatedDate] = @CreatedDate,
	[CreatedBy] = @CreatedBy,
	[ModifiedDate] = @ModifiedDate,
	[ModifiedBy] = @ModifiedBy
WHERE
	[SoMuonID] = @SoMuonID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_SoMuon_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_SoMuon_Delete]
GO

/* Procedure sproc_SoMuon_Delete*/
CREATE PROCEDURE sproc_SoMuon_Delete
	@SoMuonID int
AS
DELETE
FROM
	[SoMuon]
WHERE
	[SoMuonID] = @SoMuonID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_TacGia_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TacGia_GetCount]
GO

/* Procedure sproc_TacGia_GetCount*/
CREATE PROCEDURE sproc_TacGia_GetCount
AS
SELECT
	COUNT(*)
FROM
	[TacGia]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_TacGia_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TacGia_Get]
GO

/* Procedure sproc_TacGia_Get*/
CREATE PROCEDURE sproc_TacGia_Get
AS
SELECT
	--[TacGiaID],
	--[MaTacGia],
	--[TenTacGia],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[TacGia]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_TacGia_GetByTacGiaID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TacGia_GetByTacGiaID]
GO

/* Procedure sproc_TacGia_GetByTacGiaID*/
CREATE PROCEDURE sproc_TacGia_GetByTacGiaID
@TacGiaID int
AS
SELECT
	--[TacGiaID],
	--[MaTacGia],
	--[TenTacGia],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[TacGia]
WHERE
	[TacGiaID] = @TacGiaID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_TacGia_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TacGia_GetPaged]
GO

/* Procedure sproc_TacGia_GetPaged*/
CREATE PROCEDURE sproc_TacGia_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [TacGiaID]
FROM [TacGia]


-- query out
SELECT *
FROM [TacGia]
WHERE [TacGiaID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_TacGia_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TacGia_Add]
GO

/* Procedure sproc_TacGia_Add*/
CREATE PROCEDURE sproc_TacGia_Add
	@TacGiaID int OUTPUT
	,@MaTacGia int
	,@TenTacGia varchar(50)
	,@CreatedDate smalldatetime
	,@CreatedBy nvarchar(50)
	,@ModifiedDate smalldatetime
	,@ModifiedBy nvarchar(50)

AS

	INSERT INTO [TacGia]
	(
		[TacGiaID],
		[MaTacGia],
		[TenTacGia],
		[CreatedDate],
		[CreatedBy],
		[ModifiedDate],
		[ModifiedBy]
	)
	VALUES
	(
		@TacGiaID,
		@MaTacGia,
		@TenTacGia,
		@CreatedDate,
		@CreatedBy,
		@ModifiedDate,
		@ModifiedBy
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_TacGia_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TacGia_Update]
GO

/* Procedure sproc_TacGia_Update*/
CREATE PROCEDURE sproc_TacGia_Update
	@MaTacGia int,
	@TenTacGia varchar(50),
	@CreatedDate smalldatetime,
	@CreatedBy nvarchar(50),
	@ModifiedDate smalldatetime,
	@ModifiedBy nvarchar(50),
	@TacGiaID int

AS
UPDATE [TacGia]
SET
	[MaTacGia] = @MaTacGia,
	[TenTacGia] = @TenTacGia,
	[CreatedDate] = @CreatedDate,
	[CreatedBy] = @CreatedBy,
	[ModifiedDate] = @ModifiedDate,
	[ModifiedBy] = @ModifiedBy
WHERE
	[TacGiaID] = @TacGiaID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_TacGia_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TacGia_Delete]
GO

/* Procedure sproc_TacGia_Delete*/
CREATE PROCEDURE sproc_TacGia_Delete
	@TacGiaID int
AS
DELETE
FROM
	[TacGia]
WHERE
	[TacGiaID] = @TacGiaID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_TheLoai_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TheLoai_GetCount]
GO

/* Procedure sproc_TheLoai_GetCount*/
CREATE PROCEDURE sproc_TheLoai_GetCount
AS
SELECT
	COUNT(*)
FROM
	[TheLoai]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_TheLoai_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TheLoai_Get]
GO

/* Procedure sproc_TheLoai_Get*/
CREATE PROCEDURE sproc_TheLoai_Get
AS
SELECT
	--[TheLoaiID],
	--[MaTheLoai],
	--[TenTheLoai],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[TheLoai]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_TheLoai_GetByTheLoaiID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TheLoai_GetByTheLoaiID]
GO

/* Procedure sproc_TheLoai_GetByTheLoaiID*/
CREATE PROCEDURE sproc_TheLoai_GetByTheLoaiID
@TheLoaiID int
AS
SELECT
	--[TheLoaiID],
	--[MaTheLoai],
	--[TenTheLoai],
	--[CreatedDate],
	--[CreatedBy],
	--[ModifiedDate],
	--[ModifiedBy]

*
FROM
	[TheLoai]
WHERE
	[TheLoaiID] = @TheLoaiID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_TheLoai_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TheLoai_GetPaged]
GO

/* Procedure sproc_TheLoai_GetPaged*/
CREATE PROCEDURE sproc_TheLoai_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [TheLoaiID]
FROM [TheLoai]


-- query out
SELECT *
FROM [TheLoai]
WHERE [TheLoaiID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_TheLoai_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TheLoai_Add]
GO

/* Procedure sproc_TheLoai_Add*/
CREATE PROCEDURE sproc_TheLoai_Add
	@TheLoaiID int OUTPUT
	,@MaTheLoai int
	,@TenTheLoai varchar(50)
	,@CreatedDate smalldatetime
	,@CreatedBy nvarchar(50)
	,@ModifiedDate smalldatetime
	,@ModifiedBy nvarchar(50)

AS

	INSERT INTO [TheLoai]
	(
		[TheLoaiID],
		[MaTheLoai],
		[TenTheLoai],
		[CreatedDate],
		[CreatedBy],
		[ModifiedDate],
		[ModifiedBy]
	)
	VALUES
	(
		@TheLoaiID,
		@MaTheLoai,
		@TenTheLoai,
		@CreatedDate,
		@CreatedBy,
		@ModifiedDate,
		@ModifiedBy
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_TheLoai_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TheLoai_Update]
GO

/* Procedure sproc_TheLoai_Update*/
CREATE PROCEDURE sproc_TheLoai_Update
	@MaTheLoai int,
	@TenTheLoai varchar(50),
	@CreatedDate smalldatetime,
	@CreatedBy nvarchar(50),
	@ModifiedDate smalldatetime,
	@ModifiedBy nvarchar(50),
	@TheLoaiID int

AS
UPDATE [TheLoai]
SET
	[MaTheLoai] = @MaTheLoai,
	[TenTheLoai] = @TenTheLoai,
	[CreatedDate] = @CreatedDate,
	[CreatedBy] = @CreatedBy,
	[ModifiedDate] = @ModifiedDate,
	[ModifiedBy] = @ModifiedBy
WHERE
	[TheLoaiID] = @TheLoaiID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_TheLoai_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_TheLoai_Delete]
GO

/* Procedure sproc_TheLoai_Delete*/
CREATE PROCEDURE sproc_TheLoai_Delete
	@TheLoaiID int
AS
DELETE
FROM
	[TheLoai]
WHERE
	[TheLoaiID] = @TheLoaiID
GO

