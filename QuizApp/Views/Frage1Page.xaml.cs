using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage1Page : ContentPage
    {
        public Frage1Page()
        {
            InitializeComponent();
            BindingContext = new Frage1PageViewModel();
        }
    }
}
