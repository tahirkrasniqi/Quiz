using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage5Page : ContentPage
    {
        public Frage5Page()
        {
            InitializeComponent();
            BindingContext = new Frage5PageViewModel();
        }
    }
}
