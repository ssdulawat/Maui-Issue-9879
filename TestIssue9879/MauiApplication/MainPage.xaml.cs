using ClassLibrary;

namespace MauiApplication {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            Generator testGenerator = new();

            extenalLabel.Text = testGenerator.Generate();
        }
    }
}