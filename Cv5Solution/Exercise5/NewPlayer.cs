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
    public partial class NewPlayer : Form
    {
        private Hrac hrac;

        public NewPlayer()
        {
            InitializeComponent();
        }

        private void OkEvent(object sender, EventArgs e)
        {
            this.hrac = new Hrac(textBoxName.Text, (FotbalovyKlub)comboBoxClub.SelectedIndex, Convert.ToInt32(textBoxGoals.Text));
            this.Close();
        }

        private void StornoEvent(object sender, EventArgs e)
        {

        }

        internal Hrac GetHrac()
        {
            return this.hrac;
        }
    }
}
