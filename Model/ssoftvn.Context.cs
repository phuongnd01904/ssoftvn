﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SSOFTEntities : DbContext
    {
        public SSOFTEntities()
            : base("name=SSOFTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BaoCaoQuyCa> BaoCaoQuyCas { get; set; }
        public DbSet<BH_DonBanHang> BH_DonBanHang { get; set; }
        public DbSet<BH_DonBanHang_ChiTiet> BH_DonBanHang_ChiTiet { get; set; }
        public DbSet<BH_DonMuaHang> BH_DonMuaHang { get; set; }
        public DbSet<BH_DonMuaHang_ChiTiet> BH_DonMuaHang_ChiTiet { get; set; }
        public DbSet<BH_MuaHang> BH_MuaHang { get; set; }
        public DbSet<BH_MuaHang_ChiTiet> BH_MuaHang_ChiTiet { get; set; }
        public DbSet<CauHinhBangLuong> CauHinhBangLuongs { get; set; }
        public DbSet<CauHinhHomThu> CauHinhHomThus { get; set; }
        public DbSet<CHBangLuongTheoMucDoanhThu> CHBangLuongTheoMucDoanhThus { get; set; }
        public DbSet<CHGiamTruBangLuong> CHGiamTruBangLuongs { get; set; }
        public DbSet<ChietKhauMacDinh_NhanVien> ChietKhauMacDinh_NhanVien { get; set; }
        public DbSet<CongDoan_DichVu> CongDoan_DichVu { get; set; }
        public DbSet<CongNoDauKi> CongNoDauKis { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<DanhSachThi> DanhSachThis { get; set; }
        public DbSet<DanhSachThi_ChiTiet> DanhSachThi_ChiTiet { get; set; }
        public DbSet<DieuChuyenKho> DieuChuyenKhoes { get; set; }
        public DbSet<DieuChuyenKho_ChiTiet> DieuChuyenKho_ChiTiet { get; set; }
        public DbSet<DieuKienChuyenNhom> DieuKienChuyenNhoms { get; set; }
        public DbSet<DinhLuongDichVu> DinhLuongDichVus { get; set; }
        public DbSet<DinhMucHangHoaXuatKhoChoDichVu> DinhMucHangHoaXuatKhoChoDichVus { get; set; }
        public DbSet<DM_ChucVu> DM_ChucVu { get; set; }
        public DbSet<DM_DacDiemKhachHang> DM_DacDiemKhachHang { get; set; }
        public DbSet<DM_DoiTuong> DM_DoiTuong { get; set; }
        public DbSet<DM_DonVi> DM_DonVi { get; set; }
        public DbSet<DM_DonViTinh> DM_DonViTinh { get; set; }
        public DbSet<DM_GiaBan> DM_GiaBan { get; set; }
        public DbSet<DM_GiaBan_ChiTiet> DM_GiaBan_ChiTiet { get; set; }
        public DbSet<DM_HangHoa> DM_HangHoa { get; set; }
        public DbSet<DM_HinhThucThanhToan> DM_HinhThucThanhToan { get; set; }
        public DbSet<DM_HinhThucVanChuyen> DM_HinhThucVanChuyen { get; set; }
        public DbSet<DM_Kho> DM_Kho { get; set; }
        public DbSet<DM_KhoanPhuCap> DM_KhoanPhuCap { get; set; }
        public DbSet<DM_KhuVuc> DM_KhuVuc { get; set; }
        public DbSet<DM_KhuyenMai> DM_KhuyenMai { get; set; }
        public DbSet<DM_KhuyenMai_ChiTiet> DM_KhuyenMai_ChiTiet { get; set; }
        public DbSet<DM_LienHe> DM_LienHe { get; set; }
        public DbSet<DM_LoaiChungTu> DM_LoaiChungTu { get; set; }
        public DbSet<DM_LoaiGiaPhong> DM_LoaiGiaPhong { get; set; }
        public DbSet<DM_LoaiNhapXuat> DM_LoaiNhapXuat { get; set; }
        public DbSet<DM_LoaiPhieuThanhToan> DM_LoaiPhieuThanhToan { get; set; }
        public DbSet<DM_LoaiPhong> DM_LoaiPhong { get; set; }
        public DbSet<DM_LoHang> DM_LoHang { get; set; }
        public DbSet<DM_LopHoc> DM_LopHoc { get; set; }
        public DbSet<DM_LyDoHuyLichHen> DM_LyDoHuyLichHen { get; set; }
        public DbSet<DM_MaVach> DM_MaVach { get; set; }
        public DbSet<DM_MayChamCong> DM_MayChamCong { get; set; }
        public DbSet<DM_NganHang> DM_NganHang { get; set; }
        public DbSet<DM_NhanVien> DM_NhanVien { get; set; }
        public DbSet<DM_NhomDoiTuong> DM_NhomDoiTuong { get; set; }
        public DbSet<DM_NhomHangHoa> DM_NhomHangHoa { get; set; }
        public DbSet<DM_NhomThe> DM_NhomThe { get; set; }
        public DbSet<DM_NoiDungQuanTam> DM_NoiDungQuanTam { get; set; }
        public DbSet<DM_PhanLoaiHangHoaDichVu> DM_PhanLoaiHangHoaDichVu { get; set; }
        public DbSet<DM_QuanHuyen> DM_QuanHuyen { get; set; }
        public DbSet<DM_QuocGia> DM_QuocGia { get; set; }
        public DbSet<DM_ThueSuat> DM_ThueSuat { get; set; }
        public DbSet<DM_TichDiem> DM_TichDiem { get; set; }
        public DbSet<DM_TienTe> DM_TienTe { get; set; }
        public DbSet<DM_TinhThanh> DM_TinhThanh { get; set; }
        public DbSet<DM_TrangThai> DM_TrangThai { get; set; }
        public DbSet<DM_TyGia> DM_TyGia { get; set; }
        public DbSet<DM_ViTri> DM_ViTri { get; set; }
        public DbSet<DM_VungMien> DM_VungMien { get; set; }
        public DbSet<DoiTuong_DacDiem> DoiTuong_DacDiem { get; set; }
        public DbSet<DonViQuiDoi> DonViQuiDois { get; set; }
        public DbSet<Gara_Anh_QTSuaChua> Gara_Anh_QTSuaChua { get; set; }
        public DbSet<Gara_ChietKhauSuaChua> Gara_ChietKhauSuaChua { get; set; }
        public DbSet<Gara_HangXe> Gara_HangXe { get; set; }
        public DbSet<Gara_HinhThucSuaChua> Gara_HinhThucSuaChua { get; set; }
        public DbSet<Gara_LoaiXe> Gara_LoaiXe { get; set; }
        public DbSet<Gara_QuaTrinhSuaChua> Gara_QuaTrinhSuaChua { get; set; }
        public DbSet<Gara_TinhTrangXe_QTSuaChua> Gara_TinhTrangXe_QTSuaChua { get; set; }
        public DbSet<Gara_VatDungGiayTo_QTSuaChua> Gara_VatDungGiayTo_QTSuaChua { get; set; }
        public DbSet<Gara_Xe> Gara_Xe { get; set; }
        public DbSet<GiaoCaLamViec> GiaoCaLamViecs { get; set; }
        public DbSet<HangDoiTraLai> HangDoiTraLais { get; set; }
        public DbSet<HangDoiTraLaiChiTiet> HangDoiTraLaiChiTiets { get; set; }
        public DbSet<HangTraLaiNCCChiTiet> HangTraLaiNCCChiTiets { get; set; }
        public DbSet<HangTraLaiNhaCungCap> HangTraLaiNhaCungCaps { get; set; }
        public DbSet<HoaDonBan> HoaDonBans { get; set; }
        public DbSet<HoaDonBan_ChietKhauThanhToan> HoaDonBan_ChietKhauThanhToan { get; set; }
        public DbSet<HoaDonBanChiTiet> HoaDonBanChiTiets { get; set; }
        public DbSet<HoaDonBanLe> HoaDonBanLes { get; set; }
        public DbSet<HoaDonBanLe_DacDiemKhachHang> HoaDonBanLe_DacDiemKhachHang { get; set; }
        public DbSet<HoaDonBanLeChiTiet> HoaDonBanLeChiTiets { get; set; }
        public DbSet<HoaDonDichVu> HoaDonDichVus { get; set; }
        public DbSet<Hotel_CheckIn> Hotel_CheckIn { get; set; }
        public DbSet<Hotel_CheckIn_ChiTiet> Hotel_CheckIn_ChiTiet { get; set; }
        public DbSet<Hotel_DatPhong> Hotel_DatPhong { get; set; }
        public DbSet<Hotel_DatPhong_ChiTiet> Hotel_DatPhong_ChiTiet { get; set; }
        public DbSet<Hotel_DonGiaPhong> Hotel_DonGiaPhong { get; set; }
        public DbSet<Hotel_HoaDonSuDungDichVu> Hotel_HoaDonSuDungDichVu { get; set; }
        public DbSet<HRS_DonGiaViTri> HRS_DonGiaViTri { get; set; }
        public DbSet<KH_Anh> KH_Anh { get; set; }
        public DbSet<KH_KiemKe> KH_KiemKe { get; set; }
        public DbSet<KH_KiemKeChiTiet> KH_KiemKeChiTiet { get; set; }
        public DbSet<KH_NhapKho> KH_NhapKho { get; set; }
        public DbSet<KH_NhapKho_ChiTiet> KH_NhapKho_ChiTiet { get; set; }
        public DbSet<KH_XuatKho> KH_XuatKho { get; set; }
        public DbSet<KH_XuatKho_ChiTiet> KH_XuatKho_ChiTiet { get; set; }
        public DbSet<Kho_DonVi> Kho_DonVi { get; set; }
        public DbSet<Kho_KhuyenMai> Kho_KhuyenMai { get; set; }
        public DbSet<KhoanChiPhi_DoanhThu> KhoanChiPhi_DoanhThu { get; set; }
        public DbSet<KhoanThuChi> KhoanThuChis { get; set; }
        public DbSet<KhoanThuChi_ChiPhiDoanhThu> KhoanThuChi_ChiPhiDoanhThu { get; set; }
        public DbSet<KhoaSoLieu> KhoaSoLieux { get; set; }
        public DbSet<KhuVuc_DonVi> KhuVuc_DonVi { get; set; }
        public DbSet<KhuyenMaiTangKem> KhuyenMaiTangKems { get; set; }
        public DbSet<LichHenKhachHang> LichHenKhachHangs { get; set; }
        public DbSet<LichNhacBaoHanh_XeBan> LichNhacBaoHanh_XeBan { get; set; }
        public DbSet<LichNhacBaoHanh_XeBan_ChiTiet> LichNhacBaoHanh_XeBan_ChiTiet { get; set; }
        public DbSet<LichNhacBaoHanh_XeSuaChua> LichNhacBaoHanh_XeSuaChua { get; set; }
        public DbSet<LichNhacBaoHanh_XeSuaChua_ChiTiet> LichNhacBaoHanh_XeSuaChua_ChiTiet { get; set; }
        public DbSet<MaChungTu> MaChungTus { get; set; }
        public DbSet<MoHinhKhuVuc> MoHinhKhuVucs { get; set; }
        public DbSet<MonAnChoThucHien> MonAnChoThucHiens { get; set; }
        public DbSet<NguonKhachHang> NguonKhachHangs { get; set; }
        public DbSet<NguyenLieu_ChungTuChiTiet> NguyenLieu_ChungTuChiTiet { get; set; }
        public DbSet<Nhan_LichHenKhachHang> Nhan_LichHenKhachHang { get; set; }
        public DbSet<NhanVien_LichHenKhachHang> NhanVien_LichHenKhachHang { get; set; }
        public DbSet<NhanVienThucHien> NhanVienThucHiens { get; set; }
        public DbSet<NhanVienTuVan> NhanVienTuVans { get; set; }
        public DbSet<NhatKyBaoHanh_NhomHH_HangHoa> NhatKyBaoHanh_NhomHH_HangHoa { get; set; }
        public DbSet<NhatKyHoatDong_NhomHangHoa> NhatKyHoatDong_NhomHangHoa { get; set; }
        public DbSet<NhatKySuDung_PhieuThanhToan> NhatKySuDung_PhieuThanhToan { get; set; }
        public DbSet<NhatKySuDungThe> NhatKySuDungThes { get; set; }
        public DbSet<NhatKyThayDoiNhomKhachHang> NhatKyThayDoiNhomKhachHangs { get; set; }
        public DbSet<NhomDoiTuong_DonVi> NhomDoiTuong_DonVi { get; set; }
        public DbSet<NhomHangHoa_DonVi> NhomHangHoa_DonVi { get; set; }
        public DbSet<NS_ChamCong_ChiTiet> NS_ChamCong_ChiTiet { get; set; }
        public DbSet<NS_HoSoLuong> NS_HoSoLuong { get; set; }
        public DbSet<NS_HoSoLuongDoanhThu> NS_HoSoLuongDoanhThu { get; set; }
        public DbSet<NS_KyHieuChamCong> NS_KyHieuChamCong { get; set; }
        public DbSet<NS_LuongDoanhThu> NS_LuongDoanhThu { get; set; }
        public DbSet<NS_LuongDoanhThu_ChiTiet> NS_LuongDoanhThu_ChiTiet { get; set; }
        public DbSet<NS_PhuCapNhanVien> NS_PhuCapNhanVien { get; set; }
        public DbSet<NS_QuaTrinhCongTac> NS_QuaTrinhCongTac { get; set; }
        public DbSet<PhanHoiKhachHang> PhanHoiKhachHangs { get; set; }
        public DbSet<PhanLoaiChamSocKhachHang> PhanLoaiChamSocKhachHangs { get; set; }
        public DbSet<PhanLoaiLichHen> PhanLoaiLichHens { get; set; }
        public DbSet<PhieuChi> PhieuChis { get; set; }
        public DbSet<PhieuChiChiTiet> PhieuChiChiTiets { get; set; }
        public DbSet<PhieuThanhToan> PhieuThanhToans { get; set; }
        public DbSet<PhieuThu> PhieuThus { get; set; }
        public DbSet<PhieuThuChiTiet> PhieuThuChiTiets { get; set; }
        public DbSet<QuyenMacDinh> QuyenMacDinhs { get; set; }
        public DbSet<SanPhamChinh> SanPhamChinhs { get; set; }
        public DbSet<SanPhamTangKem> SanPhamTangKems { get; set; }
        public DbSet<SoDuKhoiTao> SoDuKhoiTaos { get; set; }
        public DbSet<SoTichDiem> SoTichDiems { get; set; }
        public DbSet<SuDungDiemTich> SuDungDiemTiches { get; set; }
        public DbSet<sys_CauHinhPhanMem> sys_CauHinhPhanMem { get; set; }
        public DbSet<sys_Company> sys_Company { get; set; }
        public DbSet<sys_NguoiDung> sys_NguoiDung { get; set; }
        public DbSet<sys_NguoiDungNhom> sys_NguoiDungNhom { get; set; }
        public DbSet<sys_NhatKyNguoiDung> sys_NhatKyNguoiDung { get; set; }
        public DbSet<sys_NhomNguoiDung> sys_NhomNguoiDung { get; set; }
        public DbSet<sys_PhimTat> sys_PhimTat { get; set; }
        public DbSet<sys_Quyen> sys_Quyen { get; set; }
        public DbSet<sys_QuyenNhom> sys_QuyenNhom { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TaiKhoanNhanTin> TaiKhoanNhanTins { get; set; }
        public DbSet<TaiLieu> TaiLieux { get; set; }
        public DbSet<TaiLieu_PhanLoai> TaiLieu_PhanLoai { get; set; }
        public DbSet<TangGiaTriThe> TangGiaTriThes { get; set; }
        public DbSet<tblTinNhanSM> tblTinNhanSMS { get; set; }
        public DbSet<TheKhachHang> TheKhachHangs { get; set; }
        public DbSet<TheKhachHang_DonViSuDung> TheKhachHang_DonViSuDung { get; set; }
        public DbSet<TheKhachHangChiTiet> TheKhachHangChiTiets { get; set; }
        public DbSet<TheoDoiLopHoc> TheoDoiLopHocs { get; set; }
        public DbSet<TheoDoiLopHocChiTiet> TheoDoiLopHocChiTiets { get; set; }
        public DbSet<ThuDienTu> ThuDienTus { get; set; }
        public DbSet<TinNhan> TinNhans { get; set; }
        public DbSet<TongHopNhapXuat> TongHopNhapXuats { get; set; }
        public DbSet<TonKhoKhoiTao> TonKhoKhoiTaos { get; set; }
        public DbSet<TonQuyChiTiet_DonVi> TonQuyChiTiet_DonVi { get; set; }
        public DbSet<TonQuyKhoiTao> TonQuyKhoiTaos { get; set; }
        public DbSet<TonToiThieu> TonToiThieux { get; set; }
        public DbSet<TuVanKhachHang> TuVanKhachHangs { get; set; }
        public DbSet<ViTriHangTrongKho> ViTriHangTrongKhoes { get; set; }
    }
}
