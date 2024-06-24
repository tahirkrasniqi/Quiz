using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage4Page : ContentPage
    {
        public Frage4Page()
        {
            InitializeComponent();
            BindingContext = new Frage4PageViewModel();
        }
    }
}
