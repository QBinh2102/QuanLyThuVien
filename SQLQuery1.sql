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
(N'Phạm Văn C', 'c.pham@example.com', '0912345678', N'Đà Nẵng'),
(N'Lê Thị D', 'd.le@example.com', '0911111111', N'Hà Nội'),
(N'Ngô Văn E', 'e.ngo@example.com', '0922222222', N'Hải Dương'),
(N'Tạ Thị F', 'f.ta@example.com', '0933333333', N'Bắc Ninh'),
(N'Bùi Văn G', 'g.bui@example.com', '0944444444', N'Hưng Yên'),
(N'Lương Thị H', 'h.luong@example.com', '0955555555', N'Hà Tĩnh'),
(N'Đào Văn I', 'i.dao@example.com', '0966666666', N'Hải Phòng'),
(N'Trịnh Thị J', 'j.trinh@example.com', '0977777777', N'Quảng Ninh'),
(N'Nguyễn Văn K', 'k.nguyen@example.com', '0988888888', N'Nam Định'),
(N'Phan Thị L', 'l.phan@example.com', '0999999999', N'Hòa Bình');

-- Thêm dữ liệu mẫu cho bảng TheLoaiSach
INSERT INTO TheLoaiSach (tenTheLoai) VALUES
(N'Khoa học viễn tưởng'),
(N'Tiểu thuyết'),
(N'Lịch sử'),
(N'Truyện tranh'),
(N'Trinh thám'),
(N'Giáo dục'),
(N'Tâm lý học'),
(N'Kỹ năng sống'),
(N'Văn học cổ điển'),
(N'Công nghệ thông tin'),
(N'Nấu ăn'),
(N'Du lịch'),
(N'Thể thao');


-- Thêm dữ liệu mẫu cho bảng Sach
INSERT INTO Sach (tenSach, tacGia, idTheLoai, namXuatBan, soLuong, soLuongConLai, giaBia) VALUES
(N'Dune', N'Frank Herbert', 1, 1965, 5, 5, 250000),
(N'1984', N'George Orwell', 2, 1949, 3, 3, 180000),
(N'Lịch sử Việt Nam', N'Trần Văn Giàu', 3, 2000, 4, 4, 220000),
(N'Thám tử lừng danh Conan', N'Gosho Aoyama', 4, 1994, 10, 10, 45000),
(N'Mật mã Da Vinci', N'Dan Brown', 5, 2003, 6, 6, 150000),
(N'Hạt giống tâm hồn', N'Nhiều tác giả', 6, 2010, 7, 7, 120000),
(N'Tâm lý học về tiền', N'Morgan Housel', 7, 2021, 5, 5, 175000),
(N'Đắc nhân tâm', N'Dale Carnegie', 8, 1936, 8, 8, 98000),
(N'Truyện Kiều', N'Nguyễn Du', 9, 1813, 12, 12, 75000),
(N'Clean Code', N'Robert C. Martin', 10, 2008, 4, 4, 280000),
(N'100 món ăn ngon', N'Nguyễn Văn Tùng', 11, 2015, 3, 3, 60000),
(N'Việt Nam - Đất nước và con người', N'Trịnh Quốc Toàn', 12, 2018, 6, 6, 110000),
(N'Bóng đá hiện đại', N'Nguyễn Hữu Thắng', 13, 2020, 2, 2, 130000);


-- Thêm dữ liệu mẫu cho bảng NhanVien
INSERT INTO NhanVien (hoTen, username, password, email, soDienThoai, queQuan, vaiTro) VALUES
(N'Admin', 'admin', '123456', 'admin@example.com', '0909123456', N'Hà Nội', 1),
(N'Nhân viên 1', 'nv1', '123456', 'nv1@example.com', '0911223344', N'Hải Phòng', 0),
(N'Lê Văn N', 'nv2', '123456', 'nv2@example.com', '0912123456', N'Tuyên Quang', 0),
(N'Hà Thị O', 'nv3', '123456', 'nv3@example.com', '0913123456', N'Phú Thọ', 0),
(N'Đặng Văn P', 'nv4', '123456', 'nv4@example.com', '0914123456', N'Hưng Yên', 0),
(N'Nguyễn Thị Q', 'nv5', '123456', 'nv5@example.com', '0915123456', N'Hòa Bình', 0),
(N'Lý Văn R', 'nv6', '123456', 'nv6@example.com', '0916123456', N'Cao Bằng', 0),
(N'Tạ Thị S', 'nv7', '123456', 'nv7@example.com', '0917123456', N'Bắc Giang', 0),
(N'Phùng Văn T', 'nv8', '123456', 'nv8@example.com', '0918123456', N'Lạng Sơn', 0),
(N'Nguyễn Văn U', 'nv9', '123456', 'nv9@example.com', '0919123456', N'Thái Nguyên', 0),
(N'Hoàng Thị V', 'nv10', '123456', 'nv10@example.com', '0920123456', N'Bắc Ninh', 0),
(N'Đoàn Văn X', 'nv11', '123456', 'nv11@example.com', '0921123456', N'Hà Nam', 0);


-- Thêm dữ liệu mẫu cho bảng MuonTraSach
INSERT INTO MuonTraSach (idDocGia, idSach, idNhanVien, ngayMuon, ngayTra, trangThai) VALUES

(1, 1, 1, '2025-03-01', '2025-03-10', 'da_tra'),
(2, 2, 2, '2025-03-02', '2025-04-20', 'da_tra'),


(3, 3, 3, '2025-04-03', '2025-05-03', 'dang_muon'),
(4, 4, 4, '2025-04-04', '2025-05-03', 'dang_muon'),
(5, 5, 5, '2025-04-05', '2025-05-03', 'dang_muon'),
(6, 6, 6, '2025-04-06','2025-05-03', 'dang_muon'),


(7, 7, 7, '2025-04-01', '2025-04-10', 'da_tra'),
(8, 8, 8, '2025-03-20', '2025-03-28', 'da_tra'),
(9, 9, 9, '2025-04-10', '2025-04-22', 'da_tra'),


(10, 10, 10, '2025-03-01', '2025-03-25', 'da_tra'),
(11, 11, 11, '2025-04-01', '2025-04-20', 'tra_tre'),
(12, 12, 12, '2025-04-10', '2025-04-29', 'tra_tre'),

(1, 6, 4, '2024-10-01', '2024-10-10', 'da_tra'),
(1, 7, 5, '2024-09-15', '2024-09-25', 'da_tra'),


(1, 8, 6, '2024-08-01', '2024-08-25', 'tra_tre'),
(1, 9, 7, '2024-07-10', '2024-08-01', 'tra_tre');

-- Thêm dữ liệu mẫu cho bảng QuyDinh
INSERT INTO QuyDinh (soNgayTra, soSachMuonToiDa) VALUES
(14, 3);