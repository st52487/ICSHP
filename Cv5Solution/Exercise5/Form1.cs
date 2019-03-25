using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {

        private Hraci hraci;

        public Form1()
        {
           
            hraci = new Hraci();
            InitializeComponent();

        }

        private void RemoveClubEvent(object sender, EventArgs e)
        {
            hraci.Vymaz(listView1.FocusedItem.Index);
            ListAktualization();
        }

        private void EditClubEvent(object sender, EventArgs e)
        {
            int index = listView1.FocusedItem.Index;
            bool edit = true;
            NewPlayer editPlayer = new NewPlayer(hraci, edit, index)
            {
                Text = "Hráči"
            };
            editPlayer.ShowDialog();

            ListAktualization();
        }

        private void ShowClubsEvent(object sender, EventArgs e)
        {
            NejKluby bestClubs = new NejKluby(hraci)
            {
                Text = "Nejlepší kluby"
            };
            bestClubs.Show();
        }

        private void RegisterClubEvent(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Registrovan handler udalosti");
            hraci.SetRegistration(true);
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Zrušena registrace eventu udalosti");
            hraci.SetRegistration(false);
        }

        private void EndAppEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPlayerEvent(object sender, EventArgs e)
        {
            NewPlayer newPlayerDialog = new NewPlayer
            {
                Text = "Hráči"
            };
            newPlayerDialog.ShowDialog();
            
            hraci.Pridej(newPlayerDialog.GetHrac());
            ListAktualization();
            
        }

        private void ListAktualization()
        {
            listView1.Clear();
            ////////
            //this.listView1.Columns.Add(columnHeader1);
            //this.listView1.Columns.Add(columnHeader2);
            //this.listView1.Columns.Add(columnHeader3);
            //  this.listView1.View = View.Details;
            
            for (int i = 0; i < hraci.Pocet; i++)
            {
                listView1.Items.Add(hraci[i].ToString());
            }
        }
    }
}
