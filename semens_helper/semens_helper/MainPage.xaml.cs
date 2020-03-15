using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace semens_helper
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNotesCliked(object sender, EventArgs e)
        {
            var NotesListPage = new NotesListView();
            await Navigation.PushAsync(NotesListPage);
        }
        private void OnSlayerClicked(object sender, EventArgs e)
        {

        }
        private void OnUserClicked(object sender, EventArgs e)
        {

        }
    }
}
