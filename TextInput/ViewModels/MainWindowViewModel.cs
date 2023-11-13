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
}