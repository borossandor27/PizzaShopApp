namespace PizzaShopApp
{
    partial class Form_Vevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vevo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Osszes_vevo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Vevo_cim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Vevo_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Vevo_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Osszes_vevo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_Osszes_vevo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regisztrált vevők";
            // 
            // dataGridView_Osszes_vevo
            // 
            this.dataGridView_Osszes_vevo.AllowUserToAddRows = false;
            this.dataGridView_Osszes_vevo.AllowUserToDeleteRows = false;
            this.dataGridView_Osszes_vevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Osszes_vevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Osszes_vevo.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Osszes_vevo.Name = "dataGridView_Osszes_vevo";
            this.dataGridView_Osszes_vevo.ReadOnly = true;
            this.dataGridView_Osszes_vevo.Size = new System.Drawing.Size(454, 431);
            this.dataGridView_Osszes_vevo.TabIndex = 0;
            this.dataGridView_Osszes_vevo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Osszes_vevo_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Vevo_cim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_Vevo_nev);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_Vevo_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(466, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiválasztott vevő";
            // 
            // textBox_Vevo_cim
            // 
            this.textBox_Vevo_cim.Location = new System.Drawing.Point(105, 106);
            this.textBox_Vevo_cim.Name = "textBox_Vevo_cim";
            this.textBox_Vevo_cim.Size = new System.Drawing.Size(183, 20);
            this.textBox_Vevo_cim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cím";
            // 
            // textBox_Vevo_nev
            // 
            this.textBox_Vevo_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Vevo_nev.Location = new System.Drawing.Point(105, 70);
            this.textBox_Vevo_nev.Name = "textBox_Vevo_nev";
            this.textBox_Vevo_nev.Size = new System.Drawing.Size(183, 20);
            this.textBox_Vevo_nev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név";
            // 
            // textBox_Vevo_id
            // 
            this.textBox_Vevo_id.Location = new System.Drawing.Point(105, 32);
            this.textBox_Vevo_id.Name = "textBox_Vevo_id";
            this.textBox_Vevo_id.ReadOnly = true;
            this.textBox_Vevo_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_Vevo_id.TabIndex = 1;
            this.textBox_Vevo_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosito";
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(487, 233);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(288, 39);
            this.button_Insert.TabIndex = 2;
            this.button_Insert.Text = "Új vevő";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(487, 311);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(288, 39);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(487, 389);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(288, 39);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "Módosítás";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // Form_Vevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Vevo";
            this.Text = "Vevő adatok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Vevo_FormClosing);
            this.Load += new System.EventHandler(this.Form_Vevo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Osszes_vevo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_Osszes_vevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Vevo_cim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Vevo_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Vevo_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
    }
}