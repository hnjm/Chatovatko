using Premy.Chatovatko.Client.Libs.UserData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Premy.Chatovatko.Client.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThreadsList : ContentPage
	{
        private App app;
		public ThreadsList (App app, SettingsCapsula settings)
		{
			InitializeComponent ();
            this.app = app;
		}

        private void addThread_Clicked(object sender, EventArgs e)
        {

        }
    }
}
