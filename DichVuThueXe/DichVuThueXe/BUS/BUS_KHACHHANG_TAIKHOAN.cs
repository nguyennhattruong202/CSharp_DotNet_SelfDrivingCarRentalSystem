﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_KHACHHANG_TAIKHOAN
    {
        DAO_KHACHHANG_TAIKHOAN dAO_KHACHHANG_TAIKHOAN;

        public BUS_KHACHHANG_TAIKHOAN()
        {
            dAO_KHACHHANG_TAIKHOAN = new DAO_KHACHHANG_TAIKHOAN();
        }

        public int? getCheckDangNhap(String tk, String mk)
        {
            int? check = dAO_KHACHHANG_TAIKHOAN.getCheckTAIKHOANKH_DN(tk, mk);
            return check;
        }

        public KHACHHANG_TAIKHOAN getKH_TKLogin(String tk, String mk)
        {
            KHACHHANG_TAIKHOAN tkDN = dAO_KHACHHANG_TAIKHOAN.getKH_TKLogin(tk, mk);
            return tkDN;
        }

        public int? addKhachHang_TaiKhoan(int? makh, string taikhoan, string matkhau)
        {
            int? checkadd = dAO_KHACHHANG_TAIKHOAN.addKhachHang_TaiKhoan(makh, taikhoan, matkhau);
            return checkadd;
        }

        public int? SV_checkAccount_KH(int? makh, string taikhoan)
        {
            int? check = dAO_KHACHHANG_TAIKHOAN.SV_checkAccount_KH(makh, taikhoan);
            return check;
        }

    }
}
