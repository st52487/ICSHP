﻿using System;
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
    public partial class NejKluby : Form
    {
        private FotbalovyKlub[] klub;
        private int countOfGoals;
        internal NejKluby(Hraci hraci)
        {
            InitializeComponent();
            hraci.NajdiNejlepsiKluby(out this.klub, out this.countOfGoals);
            textBoxGoals.Text = countOfGoals.ToString();
            for (int i = 0; i < klub.Length; i++)
            {
                richTextBoxClubs.AppendText(klub[i].ToString());
            }
        }
    }
}
