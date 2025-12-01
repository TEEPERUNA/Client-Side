namespace Notes.Views;

public partial class AllNotesPage : ContentPage
{
    public AllNotesPage()
    {
        InitializeComponent();
        BindingContext = new ViewModels.NotesViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        // P‰ivitet‰‰n lista aina kun sivu tulee n‰kyviin
        if (BindingContext is ViewModels.NotesViewModel notesVm)
        {
            notesVm.ReloadNotes();
        }
    }
}