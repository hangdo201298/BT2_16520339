using System;
using System.Collections.Generic;
using System.Text;

namespace BT2_16520339
{
    public class LoaiHoa : List<hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }

        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Hoa cúc")
                {
                    new hoa{TenHoa = "Đón Xuân", Gia = 50000, MoTa = "Hoa cúc các màu: trắng, vàng, cam", Hinh = "cuc_9.jpg"},
                    new hoa{TenHoa = "Hồn nhiên", Gia = 60000, MoTa = "Hoa cúc vàng, cam, lá măng", Hinh = "cuc_2.jpg"},
                    new hoa{TenHoa = "Tím thủy chung", Gia = 45000, MoTa = "Hoa cúc tím", Hinh = "cuc_3.jpg"}
                },
                new LoaiHoa("Hoa cưới")
                {
                    new hoa{TenHoa = "Dây tơ hồng", Gia = 250000, MoTa = "Hoa hồng màu hồng đậm, hoa hồng xanh, các loại lá măng ", Hinh = "cuoi_1.jpg"},
                    new hoa{TenHoa = "Cầu thủy tinh", Gia = 220000, MoTa = "Hoa hồng và hoa thủy tiên trắng", Hinh = "cuoi_2.jpg"},
                    new hoa{TenHoa = "Duyên thầm", Gia = 260000, MoTa = "Hoa cúc trắng, baby, lá măng", Hinh = "cuoi_3.jpg"}
                }
            };
            Loaihoas = l;
        }
    }
}
