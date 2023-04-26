using System.Windows.Input;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;

namespace FitCare.ViewModels;

public class MainViewModel : ReactiveObject
{
    private int _counter;
    public int Counter
    {
        get => _counter;
        set => this.RaiseAndSetIfChanged(ref _counter, value);
    }
    public ReactiveCommand<Unit,Unit> ClickCommand;

    public MainViewModel()
    {
        ClickCommand = ReactiveCommand.CreateFromObservable(Click);

    }

    private IObservable<Unit> Click()
    {
        Counter++;
        return Observable.Return(Unit.Default);
    }
}