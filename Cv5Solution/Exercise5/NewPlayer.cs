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
        private bool edit = false;
        private Hraci hraci;
        private int index;

        public NewPlayer()
        {
            InitializeComponent();
        }

        internal NewPlayer(Hraci hraci, bool edit, int index)
        {
            InitializeComponent();
            textBoxName.Text = hraci[index].Jmeno;
            comboBoxClub.Select((int)hraci[index].Klub,1);
            textBoxGoals.Text = hraci[index].GolPocet.ToString();
            this.edit = edit;
            this.hraci = hraci;
            this.index = index;
        }

        private void OkEvent(object sender, EventArgs e)
        {
            if (!edit)
            {
                this.hrac = new Hrac(textBoxName.Text, (FotbalovyKlub)comboBoxClub.SelectedIndex, Convert.ToInt32(textBoxGoals.Text));
            }
            else
            {
                hraci[index] = new Hrac(textBoxName.Text, (FotbalovyKlub)comboBoxClub.SelectedIndex, Convert.ToInt32(textBoxGoals.Text));
            }
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
