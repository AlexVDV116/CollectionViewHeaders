using System.Collections.ObjectModel;
using CollectionViewHeaders.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewHeaders;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
    
}

public sealed record Person(int Id, string Name, string ImageName = "dotnet_bot.png");