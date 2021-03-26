using System.Collections.Generic;
namespace Hopfild
{
    partial class obraz
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent(string Nazzz)
        {
            this.Nazik = new System.Windows.Forms.Label();
            this.Risa = new System.Windows.Forms.Panel[100];
            this.SuspendLayout();
            // 
            // Nazik
            // 
            this.Nazik.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nazik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nazik.Location = new System.Drawing.Point(0, 0);
            this.Nazik.Name = "Nazik";
            this.Nazik.Size = new System.Drawing.Size(100, 13);
            this.Nazik.TabIndex = 0;
            this.Nazik.Text = Nazzz;
            this.Nazik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Risa
            //
            for (int y = 0, i = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++, i++)
                {
                    this.Risa[i] = new System.Windows.Forms.Panel();
                    this.Risa[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                    this.Risa[i].Location = new System.Drawing.Point(x * 10, y * 10 + 40);
                    this.Risa[i].BackColor = ((this.Vector[i] < 0) ? System.Drawing.Color.White : System.Drawing.Color.Black);
                    this.Risa[i].Name = "Risa";
                    this.Risa[i].Size = new System.Drawing.Size(10, 10);
                    this.Risa[i].TabIndex = 1;
                    this.Controls.Add(this.Risa[i]);
                }
            }
            // 
            // obraz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            this.Controls.Add(this.Nazik);
            this.Name = "obraz";
            this.Size = new System.Drawing.Size(100, 150);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Nazik;
        private System.Windows.Forms.Panel[] Risa;
    }
}
