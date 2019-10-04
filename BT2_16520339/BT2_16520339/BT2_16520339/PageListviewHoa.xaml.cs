using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT2_16520339
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageListviewHoa : ContentPage
	{

        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();

        public PageListviewHoa ()
		{
			InitializeComponent ();

            Hoas.Add(new hoa { TenHoa = "Đón Xuân", Gia = 50000, MoTa = "Hoa cúc các màu: trắng, vàng, cam", Hinh = "cuc_1.jpg" });
            Hoas.Add(new hoa { TenHoa = "Hồn nhiên", Gia = 60000, MoTa = "Hoa cúc vàng, cam, lá măng", Hinh = "cuc_2.jpg" });
            Hoas.Add(new hoa { TenHoa = "Tím thủy chung", Gia = 45000, MoTa = "Hoa cúc tím", Hinh = "cuc_3.jpg" });

            lsvHoa.ItemsSource = Hoas;
        }
	}
}