using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPremier
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> premiers = new Dictionary<string, Premier>();
        public Form1()
        {
            InitializeComponent();
            GetPremiers();
            List<string> keys = new List<string>();
            lstPremiers.DataSource = premiers.Keys.ToList<string>();
            
        }
        private void FillOutFields(string key)
        {
            Premier premier = premiers[key];
            lblName.Text = premier.Name;
            lblBirth.Text = premier.Birth;
            lblRange.Text = premier.Range;
            picPremier.Image = Image.FromFile($"{key.ToLower()}.jpg");
        }
        private void GetPremiers()
        {
            premiers = new Dictionary<string, Premier>();
            foreach (var item in Premier.GetPremiers())
            {
                premiers.Add(item.GetKey(), item);
            }
        }

        private void lstPremiers_SelectedValueChanged(object sender, EventArgs e)
        {
            FillOutFields(lstPremiers.SelectedItem.ToString());
        }
    }
}
