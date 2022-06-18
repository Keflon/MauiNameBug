using System.Collections.ObjectModel;

namespace MauiNameBug;

public partial class MainPage : ContentPage
{
	public ObservableCollection<string> TestItemCollection { get; }

    public MainPage()
	{
		TestItemCollection = new ObservableCollection<string>();

		// The strings are irrelevant because the DataTemplate used to represent them
		// does not display them.
		TestItemCollection.Add("Hello");
		TestItemCollection.Add("Hello");
		TestItemCollection.Add("Hello");

        InitializeComponent();
    }
}

