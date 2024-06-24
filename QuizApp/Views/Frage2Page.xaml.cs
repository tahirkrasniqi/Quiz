using Microsoft.Maui.Controls;
using QuizApp.ViewModels;

namespace QuizApp.Views
{
    public partial class Frage2Page : ContentPage
    {
        public Frage2Page()
        {
            InitializeComponent();
            BindingContext = new Frage2PageViewModel();
        }
    }
}
