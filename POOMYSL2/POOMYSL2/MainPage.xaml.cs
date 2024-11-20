using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace POOMYSL2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int x = 0;
        public void Usun(object sender, EventArgs e)
        {
            if (x > 0)  
            {
                x--;
                ilosc.Text = x.ToString() + " Polubień";
            }
        }

        public void Polub(object sender ,EventArgs e)
        {
            x++;
            ilosc.Text = x.ToString()+" Polubień";
        }
    }
}
