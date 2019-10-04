using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT2_16520339
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DisplayList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListviewHoa());
        }

        private void DisplayGroup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListviewGroup());
        }
    }
}
