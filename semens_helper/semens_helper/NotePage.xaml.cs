using SemensHelperCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semens_helper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotePage : ContentPage
    {
        public NotePage()
        {
            InitializeComponent();
        }
        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var CurentText = TextEditNote.Text;
            if (CurentText == ""){
                await Navigation.PopModalAsync();
            }
            else
            {
                var sql_lite = new HelperSqlLite();
                sql_lite.create_new_notes(CurentText);
                await Navigation.PopAsync();
            }
        }
        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {

        }
    }
}