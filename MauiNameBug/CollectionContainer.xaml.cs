namespace MauiNameBug;

public partial class CollectionContainer : ContentView
{
    public CollectionContainer()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create("ItemsSource", typeof(object), typeof(CollectionContainer), null, propertyChanged: OnItemsSourceChanged);

    public object ItemsSource
    {
        get { return GetValue(ItemsSourceProperty); }
        set { SetValue(ItemsSourceProperty, value); }
    }

    private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var self = (CollectionContainer)bindable;
    }
}