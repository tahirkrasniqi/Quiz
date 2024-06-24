using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage6Page : ContentPage
    {
        public Frage6Page()
        {
            InitializeComponent();
            BindingContext = new Frage6PageViewModel();
        }
    }
}
