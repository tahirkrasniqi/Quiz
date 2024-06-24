using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage9Page : ContentPage
    {
        public Frage9Page()
        {
            InitializeComponent();
            BindingContext = new Frage9PageViewModel();
        }
    }
}
