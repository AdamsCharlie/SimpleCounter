using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleCounter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CounterPage : ContentPage
    {
        public CounterPage()
        {
            InitializeComponent();
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            Incrementer.Value = 0;
        }  
    }
}