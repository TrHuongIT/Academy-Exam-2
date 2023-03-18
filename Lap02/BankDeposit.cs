using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap02
{
    internal class BankDeposit
    {
        //Yêu cầu 7
        private decimal tienGui;
        private decimal laiSuatNam;
        private int soThangGui;

        public BankDeposit(decimal tienGui, decimal laiSuatNam, int soThangGui)
        {
            this.tienGui = tienGui;
            this.laiSuatNam = laiSuatNam;
            this.soThangGui = soThangGui;
        }

        public decimal TinhTienLai()
        {
            decimal laiSuatThang = laiSuatNam / 12 / 100;
            decimal tienLaiThang = tienGui * laiSuatThang;
            decimal tienLai = tienLaiThang * soThangGui;
            return tienLai;
        }

        public decimal TinhTienGocVaLai()
        {
            decimal laiSuatThang = laiSuatNam / 12 / 100;
            decimal tienGocVaLai = tienGui;
            for (int i = 0; i < soThangGui; i++)
            {
                decimal tienLaiThang = tienGocVaLai * laiSuatThang;
                tienGocVaLai += tienLaiThang;
            }
            return tienGocVaLai;
        }
    }
}
