namespace PizzaShopApp
{
    partial class Form_Rendeles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rendeles));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Vevo = new System.Windows.Forms.ComboBox();
            this.numeric_Mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Fizetendo = new System.Windows.Forms.TextBox();
            this.comboBox_Futar_neve = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Pizza = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picture_Pizza = new System.Windows.Forms.PictureBox();
            this.picture_Vevo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Futar_telefonszama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_Tetelek = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Listaba = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Mennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Pizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Vevo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vevő neve";
            // 
            // comboBox_Vevo
            // 
            this.comboBox_Vevo.FormattingEnabled = true;
            this.comboBox_Vevo.Location = new System.Drawing.Point(82, 20);
            this.comboBox_Vevo.Name = "comboBox_Vevo";
            this.comboBox_Vevo.Size = new System.Drawing.Size(149, 21);
            this.comboBox_Vevo.TabIndex = 1;
            this.comboBox_Vevo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Vevo_SelectedIndexChanged);
            // 
            // numeric_Mennyiseg
            // 
            this.numeric_Mennyiseg.Location = new System.Drawing.Point(96, 47);
            this.numeric_Mennyiseg.Name = "numeric_Mennyiseg";
            this.numeric_Mennyiseg.Size = new System.Drawing.Size(145, 20);
            this.numeric_Mennyiseg.TabIndex = 3;
            this.numeric_Mennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "db";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mennyiség";
            // 
            // textBox_Fizetendo
            // 
            this.textBox_Fizetendo.Location = new System.Drawing.Point(428, 314);
            this.textBox_Fizetendo.Name = "textBox_Fizetendo";
            this.textBox_Fizetendo.Size = new System.Drawing.Size(120, 20);
            this.textBox_Fizetendo.TabIndex = 6;
            // 
            // comboBox_Futar_neve
            // 
            this.comboBox_Futar_neve.FormattingEnabled = true;
            this.comboBox_Futar_neve.Location = new System.Drawing.Point(104, 29);
            this.comboBox_Futar_neve.Name = "comboBox_Futar_neve";
            this.comboBox_Futar_neve.Size = new System.Drawing.Size(145, 21);
            this.comboBox_Futar_neve.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Futár neve";
            // 
            // comboBox_Pizza
            // 
            this.comboBox_Pizza.FormattingEnabled = true;
            this.comboBox_Pizza.Location = new System.Drawing.Point(96, 20);
            this.comboBox_Pizza.Name = "comboBox_Pizza";
            this.comboBox_Pizza.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Pizza.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pizza neve";
            // 
            // picture_Pizza
            // 
            this.picture_Pizza.Location = new System.Drawing.Point(59, 123);
            this.picture_Pizza.Name = "picture_Pizza";
            this.picture_Pizza.Size = new System.Drawing.Size(152, 140);
            this.picture_Pizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Pizza.TabIndex = 11;
            this.picture_Pizza.TabStop = false;
            // 
            // picture_Vevo
            // 
            this.picture_Vevo.Image = global::PizzaShopApp.Properties.Resources.Vevo_Vidor;
            this.picture_Vevo.Location = new System.Drawing.Point(82, 47);
            this.picture_Vevo.Name = "picture_Vevo";
            this.picture_Vevo.Size = new System.Drawing.Size(125, 164);
            this.picture_Vevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Vevo.TabIndex = 2;
            this.picture_Vevo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Futár telefonszáma";
            // 
            // textBox_Futar_telefonszama
            // 
            this.textBox_Futar_telefonszama.Location = new System.Drawing.Point(104, 62);
            this.textBox_Futar_telefonszama.Name = "textBox_Futar_telefonszama";
            this.textBox_Futar_telefonszama.Size = new System.Drawing.Size(145, 20);
            this.textBox_Futar_telefonszama.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ft";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fizetendő";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picture_Vevo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Vevo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 269);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vevő";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Listaba);
            this.groupBox2.Controls.Add(this.picture_Pizza);
            this.groupBox2.Controls.Add(this.numeric_Mennyiseg);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox_Pizza);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 269);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_Tetelek);
            this.groupBox3.Location = new System.Drawing.Point(588, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 269);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendelés tételek";
            // 
            // listBox_Tetelek
            // 
            this.listBox_Tetelek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Tetelek.FormattingEnabled = true;
            this.listBox_Tetelek.Location = new System.Drawing.Point(3, 16);
            this.listBox_Tetelek.Name = "listBox_Tetelek";
            this.listBox_Tetelek.Size = new System.Drawing.Size(194, 250);
            this.listBox_Tetelek.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_Futar_neve);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox_Futar_telefonszama);
            this.groupBox4.Location = new System.Drawing.Point(12, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 100);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Futár";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(383, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "Rendelés rögzítés";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_Listaba
            // 
            this.button_Listaba.Location = new System.Drawing.Point(115, 82);
            this.button_Listaba.Name = "button_Listaba";
            this.button_Listaba.Size = new System.Drawing.Size(75, 23);
            this.button_Listaba.TabIndex = 12;
            this.button_Listaba.Text = "Listába";
            this.button_Listaba.UseVisualStyleBackColor = true;
            // 
            // Form_Rendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Fizetendo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Rendeles";
            this.Text = "Rendelés";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Rendeles_FormClosing);
            this.Load += new System.EventHandler(this.Form_Rendeles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Mennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Pizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Vevo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Vevo;
        private System.Windows.Forms.PictureBox picture_Vevo;
        private System.Windows.Forms.NumericUpDown numeric_Mennyiseg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Fizetendo;
        private System.Windows.Forms.ComboBox comboBox_Futar_neve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Pizza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture_Pizza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Futar_telefonszama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox_Tetelek;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Listaba;
    }
}