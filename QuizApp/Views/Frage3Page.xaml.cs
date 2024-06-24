using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage3Page : ContentPage
    {
        public Frage3Page()
        {
            InitializeComponent();
            BindingContext = new Frage3PageViewModel();
        }
    }
}
