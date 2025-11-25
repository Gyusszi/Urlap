using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Urlap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_rendeles_Click(object sender, RoutedEventArgs e)
        {
            string teszta = (lst_teszta.SelectedItem as ListBoxItem)?.Content.ToString() ?? "Nincs kiválasztva";

			string meret = (cmb_meret.SelectedItem as ListBoxItem)?.Content.ToString() ?? "Nincs kiválasztva";

            string feltetek = "";
            if (cb_sajt.IsChecked == true) feltetek += "Sajt, ";
			if (cb_sonka.IsChecked == true) feltetek += "Sonka, ";
			if (cb_gomba.IsChecked == true) feltetek += "Gomba, ";
			if (cb_szalami.IsChecked == true) feltetek += "Szalámi, ";
			if (cb_kukorica.IsChecked == true) feltetek += "Kukorica, ";
			if (cb_parmezan.IsChecked == true) feltetek += "Parmezán, ";
            if (feltetek.EndsWith(", ")) feltetek = feltetek.Substring(0, feltetek.Length - 2);
            if (string.IsNullOrEmpty(feltetek)) feltetek = "Nincs feltét";

			string atvetel = rb_Hazhoz.IsChecked == true ? "Házhozszállítás" :
							 rb_Szemelyes.IsChecked == true ? "Személyes átvétel" :
							 "nincs kiválasztva";

            txt_osszegzes.Text = $"Rendelés összegzése:\n" +
							   $"- Tészta: {teszta}\n" +
							   $"- Méret: {meret}\n" +
							   $"- Feltétek: {feltetek}\n" +
							   $"- Átvétel: {atvetel}";
		}
	}

    }
