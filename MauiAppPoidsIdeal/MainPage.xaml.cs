namespace MauiAppPoidsIdeal
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void femmebtn(object sender, EventArgs e)
        {

            double taille = double.Parse(TaillefEntry.Text);
            double poids = taille - 100 - (taille - 150)/2.5;
            PoidsfLabel.Text = $"{poids} kg";
        }

        private void hommebtn(object sender, EventArgs e)
        {
            double taille = double.Parse(TaillehEntry.Text);
            double poids = taille - 100 - (taille - 150)/4;
            PoidshLabel.Text = $"{poids} kg";
        }
    }
}
