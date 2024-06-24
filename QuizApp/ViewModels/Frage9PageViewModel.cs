﻿using System.Windows.Input;
using Microsoft.Maui.Controls;
using QuizApp.Views;

namespace QuizApp.ViewModels
{
    public class Frage9PageViewModel
    {
        public ICommand NextCommand { get; }

        public Frage9PageViewModel()
        {
            NextCommand = new Command<string>(OnNext);
        }

        private async void OnNext(string nextPage)
        {
            // Navigiere zur nächsten Frage
            switch (nextPage)
            {
                case "frage10.html":
                    if (Application.Current?.MainPage?.Navigation != null)
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new EndePage());
                    }
                    else
                    {
                        // Optional: Fehlerbehandlung oder Fallback-Logik
                        // z.B. eine Fehlermeldung anzeigen oder Log-Eintrag erstellen
                    }

                    break;
                    // Füge weitere Cases für andere Fragen hinzu
            }
        }
    }
}
