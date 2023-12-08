using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.DomainClass;

namespace DAL.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DatLich> DatLiches { get; set; } = null!;
        public virtual DbSet<DatLichChiTiet> DatLichChiTiets { get; set; } = null!;
        public virtual DbSet<DichVu> DichVus { get; set; } = null!;
        public virtual DbSet<GiamGium> GiamGia { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<HopDong> HopDongs { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<LichLamViec> LichLamViecs { get; set; } = null!;
        public virtual DbSet<LoaiThietBi> LoaiThietBis { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<PhieuThongKe> PhieuThongKes { get; set; } = null!;
        public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; } = null!;
        public virtual DbSet<Pt> Pts { get; set; } = null!;
        public virtual DbSet<ThanhToan> ThanhToans { get; set; } = null!;
        public virtual DbSet<ThietBi> ThietBis { get; set; } = null!;
        public virtual DbSet<ThongKeThietBi> ThongKeThietBis { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source= LAPTOP-7HORMRAF\\SQLEXPRESS01 ;Initial Catalog= GYMDB;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatLich>(entity =>
            {
                entity.HasKey(e => e.MaPhieuDatLich)
                    .HasName("PK__DatLich__B0D4EED2F3EF8FB6");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.DatLiches)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DatLich__NgayDat__619B8048");
            });

            modelBuilder.Entity<DatLichChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaDatLichCt)
                    .HasName("PK__DatLichC__32FD8C0527A0C4F3");

                entity.HasOne(d => d.MaPhieuDatLichNavigation)
                    .WithMany(p => p.DatLichChiTiets)
                    .HasForeignKey(d => d.MaPhieuDatLich)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DatLichCh__GhiCh__6477ECF3");
            });

            modelBuilder.Entity<DichVu>(entity =>
            {
                entity.HasKey(e => e.MaDichVu)
                    .HasName("PK__DichVu__C0E6DE8F963CA6CD");

                entity.HasOne(d => d.MaHopDongNavigation)
                    .WithMany(p => p.DichVus)
                    .HasForeignKey(d => d.MaHopDong)
                    .HasConstraintName("FK__DichVu__GhiChu__4D94879B");
            });

            modelBuilder.Entity<GiamGium>(entity =>
            {
                entity.HasKey(e => e.MaGiamGia)
                    .HasName("PK__GiamGia__EF9458E43BC4B872");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13B0E215241");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaKhachH__5629CD9C");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__TrangTha__5535A963");

                entity.HasOne(d => d.MaThanhToanNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaThanhToan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaThanhT__571DF1D5");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonCt)
                    .HasName("PK__HoaDonCH__38C56E64A305F687");

                entity.HasOne(d => d.MaDichVuNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaDichVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonCHi__MaDic__5AEE82B9");

                entity.HasOne(d => d.MaGiamGiaNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaGiamGia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonCHi__MaGia__5BE2A6F2");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonCHi__MaDic__59FA5E80");
            });

            modelBuilder.Entity<HopDong>(entity =>
            {
                entity.HasKey(e => e.MaHopDong)
                    .HasName("PK__HopDong__36DD43420F1E6BCA");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HopDong__NgayKet__4AB81AF0");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E541B4F5A7");
            });

            modelBuilder.Entity<LichLamViec>(entity =>
            {
                entity.HasKey(e => e.MaLich)
                    .HasName("PK__LichLamV__728A9AE98DC8A3B9");

                entity.HasOne(d => d.MaPtNavigation)
                    .WithMany(p => p.LichLamViecs)
                    .HasForeignKey(d => d.MaPt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichLamVie__MaPT__5EBF139D");
            });

            modelBuilder.Entity<LoaiThietBi>(entity =>
            {
                entity.HasKey(e => e.MaLoaiThietBi)
                    .HasName("PK__LoaiThie__3C8A372850F3143B");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA473E464C8C");
            });

            modelBuilder.Entity<PhieuThongKe>(entity =>
            {
                entity.HasKey(e => e.MaPhieu)
                    .HasName("PK__PhieuTho__2660BFE0CFB23BC3");
            });

            modelBuilder.Entity<PhuongThucThanhToan>(entity =>
            {
                entity.HasKey(e => e.MaPhuongThuc)
                    .HasName("PK__PhuongTh__35F7404E6F38DC02");
            });

            modelBuilder.Entity<Pt>(entity =>
            {
                entity.HasKey(e => e.MaPt)
                    .HasName("PK__PT__2725E7F62BB03CB2");
            });

            modelBuilder.Entity<ThanhToan>(entity =>
            {
                entity.HasKey(e => e.MaThanhToan)
                    .HasName("PK__ThanhToa__D4B25844D8E134E0");

                entity.HasOne(d => d.MaPhuongThucNavigation)
                    .WithMany(p => p.ThanhToans)
                    .HasForeignKey(d => d.MaPhuongThuc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThanhToan__Trang__52593CB8");
            });

            modelBuilder.Entity<ThietBi>(entity =>
            {
                entity.HasKey(e => e.MaThietBi)
                    .HasName("PK__ThietBi__8AEC71F7DC11F044");

                entity.HasOne(d => d.MaLoaiThietBiNavigation)
                    .WithMany(p => p.ThietBis)
                    .HasForeignKey(d => d.MaLoaiThietBi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThietBi__MaLoaiT__3A81B327");
            });

            modelBuilder.Entity<ThongKeThietBi>(entity =>
            {
                entity.HasKey(e => e.MaPhieuChiTiet)
                    .HasName("PK__ThongKeT__210272B74C9FCDC8");

                entity.HasOne(d => d.MaPhieuNavigation)
                    .WithMany(p => p.ThongKeThietBis)
                    .HasForeignKey(d => d.MaPhieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongKeTh__NhaCu__3F466844");

                entity.HasOne(d => d.MaThietBiNavigation)
                    .WithMany(p => p.ThongKeThietBis)
                    .HasForeignKey(d => d.MaThietBi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongKeTh__MaThi__403A8C7D");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdDangNhap)
                    .HasName("PK__Users__A9CE73E763436F65");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
