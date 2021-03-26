using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hopfild
{
    public partial class obraz : UserControl
    {
        public int[] Vector = new int[100];
        public obraz(int[] v, string Naz)
        {
            for (int i = 0; i < 100; this.Vector[i] = v[i], i++) ;
            InitializeComponent(Naz);
        }
    }
}
