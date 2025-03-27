-- Bảng độc giả
CREATE TABLE DocGia (
    id INT IDENTITY(1,1) PRIMARY KEY,
    hoTen NVARCHAR(255) NOT NULL,
    email NVARCHAR(255) UNIQUE NOT NULL,
    soDienThoai NVARCHAR(20),
    diaChi NVARCHAR(MAX),
    ngayTao DATETIME DEFAULT GETDATE(),
    active BIT DEFAULT 1,
    soSachDangMuon INT DEFAULT 0
);
GO

-- Bảng thể loại sách
CREATE TABLE TheLoaiSach (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tenTheLoai NVARCHAR(255) UNIQUE NOT NULL
);
GO

-- Bảng sách (Gộp tác giả)
CREATE TABLE Sach (
    id INT IDENTITY(1,1) PRIMARY KEY,
    tenSach NVARCHAR(255) NOT NULL,
    tacGia NVARCHAR(255) NOT NULL,
    idTheLoai INT,
    namXuatBan INT,
    soLuong INT DEFAULT 1,
    soLuongConLai INT DEFAULT 1,
    giaBia DECIMAL(10,2) NOT NULL DEFAULT 0,
    FOREIGN KEY (idTheLoai) REFERENCES TheLoaiSach(id) ON DELETE SET NULL
);
GO

-- Bảng nhân viên
CREATE TABLE NhanVien (
    id INT IDENTITY(1,1) PRIMARY KEY,
    hoTen NVARCHAR(255) NOT NULL,
    username NVARCHAR(50) UNIQUE NOT NULL,
    password NVARCHAR(255) NOT NULL,
    email NVARCHAR(255) UNIQUE NOT NULL,
    soDienThoai NVARCHAR(20),
    queQuan NVARCHAR(255), -- Thêm quê quán
    vaiTro BIT DEFAULT 1,  -- 1: Quản lý, 0: Nhân viên thường
    ngayTao DATETIME DEFAULT GETDATE(),
	active BIT DEFAULT 1,
);
GO

-- Bảng mượn - trả sách
CREATE TABLE MuonTraSach (
    id INT IDENTITY(1,1) PRIMARY KEY,
    idDocGia INT,
    idSach INT,
    idNhanVien INT,
    ngayMuon DATE NOT NULL,
    ngayTra DATE NULL,
    trangThai NVARCHAR(20) DEFAULT 'dang_muon',
    FOREIGN KEY (idDocGia) REFERENCES DocGia(id) ON DELETE CASCADE,
    FOREIGN KEY (idSach) REFERENCES Sach(id) ON DELETE CASCADE,
    FOREIGN KEY (idNhanVien) REFERENCES NhanVien(id) ON DELETE SET NULL
);
GO

-- Bảng quy định
CREATE TABLE QuyDinh (
    id INT IDENTITY(1,1) PRIMARY KEY,
    soNgayTra INT NOT NULL,
    soSachMuonToiDa INT NOT NULL
);
GO

-- Thêm dữ liệu mẫu cho bảng DocGia
INSERT INTO DocGia (hoTen, email, soDienThoai, diaChi) VALUES
(N'Nguyễn Văn A', 'a.nguyen@example.com', '0123456789', N'Hà Nội'),
(N'Trần Thị B', 'b.tran@example.com', '0987654321', N'TP. Hồ Chí Minh'),
(N'Phạm Văn C', 'c.pham@example.com', '0912345678', N'Đà Nẵng');

-- Thêm dữ liệu mẫu cho bảng TheLoaiSach
INSERT INTO TheLoaiSach (tenTheLoai) VALUES
(N'Khoa học viễn tưởng'),
(N'Tiểu thuyết'),
(N'Lịch sử');

-- Thêm dữ liệu mẫu cho bảng Sach
INSERT INTO Sach (tenSach, tacGia, idTheLoai, namXuatBan, soLuong, soLuongConLai, giaBia) VALUES
(N'Dune', N'Frank Herbert', 1, 1965, 5, 5, 250000),
(N'1984', N'George Orwell', 2, 1949, 3, 3, 180000),
(N'Lịch sử Việt Nam', N'Trần Văn Giàu', 3, 2000, 4, 4, 220000);
GO

-- Thêm dữ liệu mẫu cho bảng NhanVien
INSERT INTO NhanVien (hoTen, username, password, email, soDienThoai, queQuan, vaiTro) VALUES
(N'Admin', 'admin', '123456', 'admin@example.com', '0909123456', N'Hà Nội', 1),
(N'Nhân viên 1', 'nv1', '123456', 'nv1@example.com', '0911223344', N'Hải Phòng', 0);

-- Thêm dữ liệu mẫu cho bảng MuonTraSach
INSERT INTO MuonTraSach (idDocGia, idSach, idNhanVien, ngayMuon, trangThai) VALUES
(1, 1, 1, '2025-03-01', 'dang_muon'),
(2, 2, 2, '2025-03-02', 'dang_muon');

-- Thêm dữ liệu mẫu cho bảng QuyDinh
INSERT INTO QuyDinh (soNgayTra, soSachMuonToiDa) VALUES
(14, 3);