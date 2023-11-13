using System.Net.Mime;
using System.Reactive;
using ReactiveUI;

namespace TextInput.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _firstName;
    private string _secondName;
    private string _adress;
    private int _repeat;
    
    public string FirstName
    {
        get => _firstName;
        set => this.RaiseAndSetIfChanged(ref _firstName, value);
    }
    public string SecondName
    {
        get => _secondName;
        set => this.RaiseAndSetIfChanged(ref _secondName, value);
    }
    
    public string Adress
    {
        get => _adress;
        set => this.RaiseAndSetIfChanged(ref _adress, value);
    }
    public int Repeat
    {
        get => _repeat;
        set => this.RaiseAndSetIfChanged(ref _repeat, value);
    }

    private string _allInfo;

    public string AllInfo
    {
        get => _allInfo;
        set => this.RaiseAndSetIfChanged(ref _allInfo, value);
    }
    public ReactiveCommand<Unit, Unit> WriteText { get; }

    public MainWindowViewModel()
    {
        WriteText = ReactiveCommand.Create((() =>
        {
            for (int i = 0; i < Repeat; i++)
            {
                AllInfo += FirstName + "\n" + SecondName + "\n" + Adress + "\n";
            }
        }));
    }
}