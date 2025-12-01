namespace Notes.Views;

public partial class AllNotesPage : ContentPage
{
    public AllNotesPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var notes = new List<Models.Note>();

        var files = Directory.EnumerateFiles(FileSystem.AppDataDirectory, "*.notes.txt");
        foreach (var filename in files)
        {
            notes.Add(new Models.Note
            {
                Filename = filename,
                Text = File.ReadAllText(filename),
                Date = File.GetCreationTime(filename)
            });
        }

        notesCollection.ItemsSource = notes
            .OrderBy(d => d.Date)
            .ToList();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NotePage));
    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            var note = (Models.Note)e.CurrentSelection[0];
            await Shell.Current.GoToAsync($"{nameof(NotePage)}?{nameof(NotePage.ItemId)}={note.Filename}");
            notesCollection.SelectedItem = null;
        }
    }
}