using Food_Menu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Food_Menu
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenOrder (object sender, EventArgs e)
        {
            if(OrderView.TranslationX >= 150)
            {
                Action<double> callback = InputTransparent => OrderView.TranslationX = InputTransparent;
                OrderView.Animate("anim", callback, 150, 0, 16, 300, Easing.CubicInOut);
            }
        }

        private void CloseOrder(object sender, EventArgs e)
        {
            if (OrderView.TranslationX == 0)
            {
                Action<double> callback = InputTransparent => OrderView.TranslationX = InputTransparent;
                OrderView.Animate("anim", callback, 0, 150, 16, 300, Easing.CubicInOut);
            }
        }

        private void AddOrder(object sender, EventArgs e)
        {
            var item = (sender as Button).BindingContext as Food;
            vm.AddOrder(item);
        }

      
    }
}
