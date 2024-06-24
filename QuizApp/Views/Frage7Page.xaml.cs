using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage7Page : ContentPage
    {
        public Frage7Page()
        {
            InitializeComponent();
            BindingContext = new Frage7PageViewModel();
        }
    }
}
