using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTai3_QuanLyMuonSach
{
    class Sach
    {
        private int _id;
        private string _name;
        private string _tacgia;
        private Decimal _sl;
        private DateTime _ngaynhap;
        private string _tinhtrang;
        private string _nxb;
        private string _loai;



        public Sach()
        {
        }

        public Sach(int id, string name, string tacgia, Decimal sl, DateTime ngaynhap, string tinhtrang, string nxb, string loai)
        {
            _id = id;
            _name = name;
            _tacgia = tacgia;
            _sl = sl;
            _ngaynhap = ngaynhap;
            _tinhtrang = tinhtrang;
            _nxb = nxb;
            _loai = loai;

        }

        public string Tacgia
        {
            get { return _tacgia; }
            set { _tacgia = value; }
        }

        public string Nxb
        {
            get { return _nxb; }
            set { _nxb = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public Decimal Sl
        {
            get { return _sl; }
            set { _sl = value; }
        }
        public DateTime Ngaynhap
        {
            get { return _ngaynhap; }
            set { _ngaynhap = value; }
        }
        public string Tinhtrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }

        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
    }
}
