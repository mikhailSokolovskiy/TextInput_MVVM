using System.Net.Mime;
using System.Reactive;
using ReactiveUI;

namespace TextInput.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _caption;
    
    public string Caption
    {
        get => _caption;
        set => this.RaiseAndSetIfChanged(ref _caption, value);
    }

    private string _newText;

    public string NewText
    {
        get => _newText;
        set => this.RaiseAndSetIfChanged(ref _newText, value);
    }
    public ReactiveCommand<Unit, Unit> WriteText { get; }

    public MainWindowViewModel()
    {
        WriteText = ReactiveCommand.Create((() =>
        {
            NewText = Caption;
        }));
    }
}