using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage10Page : ContentPage
    {
        public Frage10Page()
        {
            InitializeComponent();
            BindingContext = new Frage10PageViewModel();
        }
    }
}
