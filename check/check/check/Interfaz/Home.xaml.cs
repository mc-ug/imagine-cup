using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace check
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();


            stu.Clicked += Stu_Clicked;
            teach.Clicked += Teach_Clicked;
        }

        private async void Stu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Students());
        }

        private async void Teach_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teacher());
        }
    }
}
