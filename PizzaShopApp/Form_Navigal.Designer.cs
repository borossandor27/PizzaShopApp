namespace PizzaShopApp
{
    partial class Form_Navigal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Navigal));
            this.button_Rendelés = new System.Windows.Forms.Button();
            this.button_Futar = new System.Windows.Forms.Button();
            this.button_Vevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Rendelés
            // 
            this.button_Rendelés.Location = new System.Drawing.Point(63, 40);
            this.button_Rendelés.Name = "button_Rendelés";
            this.button_Rendelés.Size = new System.Drawing.Size(103, 41);
            this.button_Rendelés.TabIndex = 0;
            this.button_Rendelés.Text = "Rendelés";
            this.button_Rendelés.UseVisualStyleBackColor = true;
            this.button_Rendelés.Click += new System.EventHandler(this.button_Rendelés_Click);
            // 
            // button_Futar
            // 
            this.button_Futar.Location = new System.Drawing.Point(403, 40);
            this.button_Futar.Name = "button_Futar";
            this.button_Futar.Size = new System.Drawing.Size(103, 41);
            this.button_Futar.TabIndex = 0;
            this.button_Futar.Text = "Futár";
            this.button_Futar.UseVisualStyleBackColor = true;
            this.button_Futar.Click += new System.EventHandler(this.button_Futar_Click);
            // 
            // button_Vevo
            // 
            this.button_Vevo.Location = new System.Drawing.Point(233, 40);
            this.button_Vevo.Name = "button_Vevo";
            this.button_Vevo.Size = new System.Drawing.Size(103, 41);
            this.button_Vevo.TabIndex = 0;
            this.button_Vevo.Text = "Vevő";
            this.button_Vevo.UseVisualStyleBackColor = true;
            this.button_Vevo.Click += new System.EventHandler(this.button_Vevo_Click);
            // 
            // Form_Navigal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 133);
            this.Controls.Add(this.button_Vevo);
            this.Controls.Add(this.button_Futar);
            this.Controls.Add(this.button_Rendelés);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Navigal";
            this.Text = "PizzaShop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Rendelés;
        private System.Windows.Forms.Button button_Futar;
        private System.Windows.Forms.Button button_Vevo;
    }
}

