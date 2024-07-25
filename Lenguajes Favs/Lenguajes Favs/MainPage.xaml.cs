using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Runtime.CompilerServices;


namespace Lenguajes_Favs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ir_ANGULAR_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://blog.hubspot.es/website/que-es-angular", BrowserLaunchMode.SystemPreferred);

           
        }

        private void ir_BOOTSTRAP_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.hostinger.mx/tutoriales/que-es-bootstrap", BrowserLaunchMode.SystemPreferred);
        }

        private void ir_cmasmas_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://lovtechnology.com/que-es-c-como-funciona-y-para-que-sirve/", BrowserLaunchMode.SystemPreferred);
        }

        private void ir_cshard_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://dotnet.microsoft.com/es-es/languages/csharp", BrowserLaunchMode.SystemPreferred);
        }

        private void ir_CSS3_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://developer.mozilla.org/es/docs/Learn/CSS/First_steps/What_is_CSS", BrowserLaunchMode.SystemPreferred);
        }

        private void ir_GITGUB_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.xataka.com/basics/que-github-que-que-le-ofrece-a-desarrolladores", BrowserLaunchMode.SystemPreferred);
        }
        
    } 
}
