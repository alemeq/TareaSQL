using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TareaXamarin.ViewModels;
using TareaXamarin.Models;

namespace TareaXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentasPage : ContentPage
    {
        public VentasPage()
        {
            InitializeComponent();
        }

        private void BInsert_Clicked(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            VentasViewModel.Instance.AddNewVenta(dProducto.Text, Int32.Parse(dCantidad.Text), DatePicker.Date);
            StatusMessage.Text = VentasViewModel.Instance.EstadoMensaje;
        }

        private void BListar_Clicked(object sender, EventArgs e)
        {
            var allVentas = VentasViewModel.Instance.GetAllVentas();
            listaventas.ItemsSource = allVentas;
            StatusMessage.Text = VentasViewModel.Instance.EstadoMensaje;
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}