using System.Reactive.Disposables;
using FitCare.ViewModels;
using ReactiveUI;
using ReactiveUI.Maui;

namespace FitCare;

public partial class MainPage : ReactiveContentPage<MainViewModel>
{

    public MainPage()
    {
        InitializeComponent();

        ViewModel = new MainViewModel();
        this.WhenActivated(disposable =>
        {
           
        });
    }
    
}