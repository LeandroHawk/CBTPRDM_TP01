using Microsoft.Maui.Controls;

namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOkClicked(object sender, EventArgs e)
        {
            string id = entryID.Text;
            string pass = entryPass.Text;

            if (id == "admin" && pass == "senha@dmin")
            {
                DisplayAlert("Login", "Logado com sucesso!", "OK");
            }
            else
            {
                DisplayAlert("Login", "Login não autorizado.", "Tentar novamente");
            }
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            entryID.Text = string.Empty;
            entryPass.Text = string.Empty;
            entryID.Focus();
        }

        private void OnCreditsClicked(object sender, EventArgs e)
        {
            DisplayAlert("Créditos", "Leandro Felix e Matheus Angelo", "Fechar");
        }
    }
}
