using System.Windows.Input;
using Microsoft.Maui.Controls;
using QuizApp.Views;

namespace QuizApp.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand StartCommand { get; }

        public MainPageViewModel()
        {
            StartCommand = new Command(OnStart);
        }

        private async void OnStart()
        {
            // Navigiere zur ersten Frage
            if (Application.Current?.MainPage?.Navigation != null)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EndePage());
            }
            else
            {
                // Optional: Fehlerbehandlung oder Fallback-Logik
                // z.B. eine Fehlermeldung anzeigen oder Log-Eintrag erstellen
            }

        }
    }
}
