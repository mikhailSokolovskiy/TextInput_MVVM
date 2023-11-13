using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Mime;
using System.Reactive;
using DynamicData.Kernel;
using ReactiveUI;
using TextInput.Models;

namespace TextInput.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _firstName;
    private string _secondName;
    private string _adress;
    private int _repeat = 1;

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
    public ObservableCollection<Person> PersonList { get; set; }

    public MainWindowViewModel()
    {
        PersonList = new ObservableCollection<Person>(new List<Person>());

        WriteText = ReactiveCommand.Create((() =>
        {
            if (Repeat == 0) Repeat = 1;
            for (int i = 0; i < Repeat; i++)
            {
                PersonList.Add(new Person(i+FirstName, SecondName, Adress));
            }
        }));
    }
}