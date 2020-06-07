using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace Rise_Set_Time
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }



        private async void btnGet_Click(object sender, EventArgs e)
        {
            string lat = txtlat.Text;
            string lon = txtlon.Text;
            var resp = await API_Helper.RGet(lat, lon);
            var dat = JsonConvert.DeserializeObject<dynamic>(resp);

            DateTime sunrise1 = Convert.ToDateTime(dat.results.sunrise);
            DateTime sunset1 = Convert.ToDateTime(dat.results.sunset);
            lblrise.Text = "Sunrise is at " + sunrise1.ToShortTimeString();
            lblset.Text = "Sunset is at " + sunset1.ToShortTimeString();


        }
    }
}
