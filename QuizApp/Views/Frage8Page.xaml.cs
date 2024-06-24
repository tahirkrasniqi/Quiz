using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage8Page : ContentPage
    {
        public Frage8Page()
        {
            InitializeComponent();
            BindingContext = new Frage8PageViewModel();
        }
    }
}
