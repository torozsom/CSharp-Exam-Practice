using System.ComponentModel;

namespace MovieEditor.Models;

public class Movie : INotifyPropertyChanged
{

    public event PropertyChangedEventHandler PropertyChanged;


    private string _description;
    public string Description
    {
        get => _description;

        set
        {
            if (_description != value)
            {
                _description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
            }
        }
    }

    private bool _seen;
    public bool Seen
    {
        get => _seen;

        set
        {
            if (_seen != value)
            {
                _seen = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Seen)));
            }
        }
    }


    public Movie(string description, bool seen)
    {
        Description = description;
        Seen = seen;
    }

}