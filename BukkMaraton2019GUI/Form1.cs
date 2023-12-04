using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace BukkMaraton2019GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combobox_tav.Items.Add("Mini - 16km");
            combobox_tav.Items.Add("R�vid - 38km");
            combobox_tav.Items.Add("Pedelec - 54km");
            combobox_tav.Items.Add("K�z�p - 57km");
            combobox_tav.Items.Add("Hossz� - 94km");
        }

        private void btn_szamol_Click(object sender, EventArgs e)
        {
            var idoMP = TimeSpan.Parse(txtbox_ido.Text).TotalSeconds;
            var idoH = TimeSpan.Parse(txtbox_ido.Text).TotalHours;
            var tavKM = 57;

            switch (combobox_tav.SelectedItem)
            {
                case "Mini - 16km":
                    tavKM = 16;
                    break;

                case "R�vid - 38km":
                    tavKM = 38;
                    break;

                case "Pedelec - 54km":
                    tavKM = 54;
                    break;

                case "K�z�p - 57km":
                    tavKM = 57;
                    break;

                case "Hossz� - 94km":
                    tavKM = 94;
                    break;
            }

            var tavM = tavKM * 1000; 

            var atlagsebessegKMH = Math.Round((double)tavKM / idoH, 2);
            var atlagsebessegMS = Math.Round((double)tavM / idoMP, 2);

            lbl_kmh_mezo.Text = Convert.ToString(atlagsebessegKMH);
            lbl_ms_mezo.Text = Convert.ToString(atlagsebessegMS);
        }
    }
}