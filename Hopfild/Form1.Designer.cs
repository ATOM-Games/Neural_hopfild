using System.Collections.Generic;
namespace Hopfild
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Zapomit = new System.Windows.Forms.Button();
            this.GRu = new System.Windows.Forms.GroupBox();
            this.Rizaza = new System.Windows.Forms.Panel[100];
            this.Learn = new System.Windows.Forms.Button();
            this.Raspoznat = new System.Windows.Forms.Button();
            this.Obrazaas = new System.Windows.Forms.Panel();
            this.Default = new System.Windows.Forms.Button();
            this.Textetes = new System.Windows.Forms.TextBox();
            this.ThisObrazes = new List<obraz>();
            this.GRu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zapomit
            // 
            this.Zapomit.Location = new System.Drawing.Point(435, 12);
            this.Zapomit.Name = "Zapomit";
            this.Zapomit.Size = new System.Drawing.Size(153, 23);
            this.Zapomit.TabIndex = 0;
            this.Zapomit.Text = "Запомнить";
            this.Zapomit.UseVisualStyleBackColor = true;
            this.Zapomit.Click += new System.EventHandler(this.Zapomit_Click);
            // 
            // GRu
            // 
            
            // 
            // Rizaza
            //
            for (int y = 0, i = 0; y < 10; y++) {
                for (int x = 0; x < 10; i++, x++)
                {
                    this.Rizaza[i] = new System.Windows.Forms.Panel();
                    this.Rizaza[i].BackColor = System.Drawing.Color.White;
                    this.Rizaza[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.Rizaza[i].Location = new System.Drawing.Point(36 * x + 25, 36 * y + 25);
                    this.Rizaza[i].Name = "Rizaza";
                    this.Rizaza[i].Size = new System.Drawing.Size(35, 35);
                    this.Rizaza[i].TabIndex = i;
                    this.Rizaza[i].Click += new System.EventHandler(this.SmenCvet);
                    this.GRu.Controls.Add(this.Rizaza[i]);
                }
            }


            this.GRu.Location = new System.Drawing.Point(12, 12);
            this.GRu.Name = "GRu";
            this.GRu.Size = new System.Drawing.Size(400, 400);
            this.GRu.TabIndex = 1;
            this.GRu.TabStop = false;
            this.GRu.Text = "Рисуй здесь";
            this.GRu.DoubleClick += new System.EventHandler(this.GRu_DoubleClick);
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(435, 69);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(178, 23);
            this.Learn.TabIndex = 2;
            this.Learn.Text = "Учить";
            this.Learn.UseVisualStyleBackColor = true;
            this.Learn.Click += new System.EventHandler(this.Learn_Click);
            // 
            // Raspoznat
            // 
            this.Raspoznat.Location = new System.Drawing.Point(435, 98);
            this.Raspoznat.Name = "Raspoznat";
            this.Raspoznat.Size = new System.Drawing.Size(178, 23);
            this.Raspoznat.TabIndex = 3;
            this.Raspoznat.Text = "Распознать";
            this.Raspoznat.UseVisualStyleBackColor = true;
            this.Raspoznat.Click += new System.EventHandler(this.Raspoznat_Click);
            // 
            // Obrazaas
            // 
            this.Obrazaas.AutoScroll = true;
            this.Obrazaas.Location = new System.Drawing.Point(433, 127);
            this.Obrazaas.Name = "Obrazaas";
            this.Obrazaas.Size = new System.Drawing.Size(180, 285);
            this.Obrazaas.TabIndex = 4;
            // 
            // Default
            // 
            this.Default.Location = new System.Drawing.Point(594, 12);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(19, 23);
            this.Default.TabIndex = 5;
            this.Default.Text = "x";
            this.Default.UseVisualStyleBackColor = true;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // Textetes
            // 
            this.Textetes.Location = new System.Drawing.Point(435, 42);
            this.Textetes.Name = "Textetes";
            this.Textetes.Size = new System.Drawing.Size(178, 20);
            this.Textetes.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 432);
            this.Controls.Add(this.Textetes);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.Obrazaas);
            this.Controls.Add(this.Raspoznat);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.GRu);
            this.Controls.Add(this.Zapomit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GRu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zapomit;
        private System.Windows.Forms.GroupBox GRu;
        private System.Windows.Forms.Panel[] Rizaza;
        private System.Windows.Forms.Button Learn;
        private System.Windows.Forms.Button Raspoznat;
        public System.Windows.Forms.Panel Obrazaas;
        private List<obraz> ThisObrazes;
        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.TextBox Textetes;
        
    }
}

