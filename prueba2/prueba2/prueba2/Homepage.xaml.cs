using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace prueba2
{
    public class Actividad : ContentPage
    {
        private Image icono = new Image();
        private Label nombre = new Label();
        public Actividad(string source, string nombreActividad)
        {
            icono.Source = source;
            nombre.Text = nombreActividad;
            nombre.TextColor = Color.Black;
            nombre.VerticalTextAlignment = TextAlignment.End;
            nombre.HorizontalTextAlignment = TextAlignment.Center;

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                DisplayAlert(nombre.Text, "Holaaaaa", "Ok");
            };
            icono.GestureRecognizers.Add(tapGestureRecognizer);
        }
        public Image Icono
        {
            get
            {
                return icono;
            }

            set
            {
                icono = value;
            }
        }

        public Label Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }

    public partial class Homepage : ContentPage
    {
        public List<Actividad> Actividades = new List<Actividad>()
        {
            new Actividad("icon.png","FB"),
            new Actividad("icon.png","Twitter"),
            new Actividad("icon.png","Insta"),
            new Actividad("icon.png","People")
        };

        public Homepage()
        {
            InitializeComponent();
            UpdateGrid();
        }

        public void UpdateGrid()
        {
            int row = 0, column = 0;
            gActividades.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            gActividades.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            foreach (Actividad aux in Actividades)
            {
                gActividades.Children.Add(aux.Icono, row, column);
                gActividades.Children.Add(aux.Nombre, row, column);

                if (column == 1)
                {
                    column = 0;
                    row++;
                    gActividades.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                }

                else
                    column++;
            }
        }
    }
}   
