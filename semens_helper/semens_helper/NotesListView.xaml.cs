using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using SemensHelperCore;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace semens_helper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesListView : ContentPage
    {
        public SortedDictionary<long, string> DictNotes;
        public NotesListView()
        {
            InitializeComponent();
        }
        
    
        private  void ListViewNotes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
        }

        public void UpgradeUI()
        {
            var sql_lite = new HelperSqlLite();
            var list_notes = sql_lite.create_list_of_notes();
            this.DictNotes = sql_lite.get_notes_ui_list();
            var notes = new List<ListViewNotesSell>();
            foreach (var note in list_notes)
            {
                if (note.text.Length > 20)
                {
                    string text = note.text.Substring(0, 20).Replace('\n', ' ') + "...";
                    notes.Add(new ListViewNotesSell(text, note.StartDate_raw));
                }
                else
                {
                    string text = note.text.Replace('\n', ' ');
                    notes.Add(new ListViewNotesSell(text, note.StartDate_raw));
                }
            }
            ListViewNotes.ItemsSource = notes;
        }
        private async void OnAddNewNoteClicked(object sender, EventArgs e)
        {
            var NotePage = new NotePage();
            await Navigation.PushAsync(NotePage);
        }
        protected override void OnAppearing()
        {
            this.UpgradeUI();
        }
    }
}
