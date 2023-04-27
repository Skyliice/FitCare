using System.Globalization;
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
        CalendarView.CalendarCulture = new CultureInfo("ru-RU");
        CalendarView.SelectedDate = DateTime.Today;
        this.WhenActivated(disposable =>
        {
           
        });
    }
    
}