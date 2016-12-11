using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace check
{
    public partial class Students : ContentPage
    {
        public Students()
        {
            InitializeComponent();
            guardar.Clicked += Guardar_Clicked;
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}
