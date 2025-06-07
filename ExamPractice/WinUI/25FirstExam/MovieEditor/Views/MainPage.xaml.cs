using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using MovieEditor.Models;

namespace MovieEditor.Views;


public sealed partial class MainPage : Page, INotifyPropertyChanged
{

    public event PropertyChangedEventHandler PropertyChanged;

    private Movie _currentMovie = new("Movie", true);

    public Movie CurrentMovie
    {
        get => _currentMovie;

        set
        {
            if (_currentMovie != value)
            {
                _currentMovie = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentMovie)));
            }
        }
    }

    public MainPage()
    {
        this.InitializeComponent();
    }


    private void ResetButton_Click(object sender, RoutedEventArgs e)
    {
        CurrentMovie = new Movie(_currentMovie.Description, false);
    }

}