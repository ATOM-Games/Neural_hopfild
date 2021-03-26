using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hopfild
{
    public partial class Form1 : Form
    {
        public int[] MegaObraz = new int[100];

        public Form1()
        {
            InitializeComponent();
            Cleanmega();
        }

        private void Zapomit_Click(object sender, EventArgs e)
        {
            AddObraz(this.MegaObraz, this.Textetes.Text);
        }

        private void Default_Click(object sender, EventArgs e)
        {

        }

        private void Learn_Click(object sender, EventArgs e)
        {

        }

        private void Raspoznat_Click(object sender, EventArgs e)
        {
            Rasoznanie();
        }
        
        public void AddObraz(int[] dd, string ss) {
            this.Obrazaas.VerticalScroll.Value = 0;
            obraz Aba = new obraz(dd, ss);
            Aba.Location = new System.Drawing.Point(0, 150 * ThisObrazes.Count());
            Aba.Name = "Default";
            Aba.Size = new System.Drawing.Size(100, 150);
            Aba.TabIndex = 5;
            Aba.Text = "x";
            this.ThisObrazes.Add(Aba);
            this.Obrazaas.Controls.Add(Aba);
        }

        private void SmenCvet(object sender, EventArgs e)
        {
            Panel pan = ((Panel)sender);
            if (this.MegaObraz[pan.TabIndex] < 0)
            {
                this.MegaObraz[pan.TabIndex] = 1;
                this.Rizaza[pan.TabIndex].BackColor = Color.Black;
            } else {
                this.MegaObraz[pan.TabIndex] = -1;
                this.Rizaza[pan.TabIndex].BackColor = Color.White;
            }
        }

        public void Cleanmega() {
            for (int i = 0; i < 100; i++) {
                MegaObraz[i] = -1;
                this.Rizaza[i].BackColor = Color.White;
            }
        }

        private void GRu_DoubleClick(object sender, EventArgs e) { Cleanmega(); }

        public void Rasoznanie() {
            int[] ttt = ABC_libka.Raspoznat(MegaObraz, this.ThisObrazes);
            UstMeg(ABC_libka.yy);
        }


        public void UstMeg(int[] d) {
            string s="";
            for (int i = 0; i < 100; i++)
            {
                MegaObraz[i] = d[i];
                s+=( (d[i]<0) ? "0" : "1" );
                s += (i % 10 == 9) ? "\n" : " ";
                this.Rizaza[i].BackColor = (d[i]<0) ? Color.White : Color.Black;
            }
            MessageBox.Show(s);
        }
    }
}
