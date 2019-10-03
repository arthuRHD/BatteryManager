namespace BattaeryManager
{
    partial class BatteryManager
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryManager));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btn_low = new System.Windows.Forms.Button();
            this.btn_high = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.Location = new System.Drawing.Point(164, 216);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(219, 49);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // btn_low
            // 
            this.btn_low.BackColor = System.Drawing.Color.Gold;
            this.btn_low.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_low.BackgroundImage")));
            this.btn_low.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_low.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_low.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_low.Image = ((System.Drawing.Image)(resources.GetObject("btn_low.Image")));
            this.btn_low.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_low.Location = new System.Drawing.Point(45, 39);
            this.btn_low.Name = "btn_low";
            this.btn_low.Size = new System.Drawing.Size(128, 130);
            this.btn_low.TabIndex = 1;
            this.btn_low.UseVisualStyleBackColor = false;
            this.btn_low.Click += new System.EventHandler(this.btn_low_Click);
            // 
            // btn_high
            // 
            this.btn_high.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_high.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_high.BackgroundImage")));
            this.btn_high.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_high.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_high.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_high.Location = new System.Drawing.Point(206, 39);
            this.btn_high.Name = "btn_high";
            this.btn_high.Size = new System.Drawing.Size(129, 130);
            this.btn_high.TabIndex = 2;
            this.btn_high.UseVisualStyleBackColor = false;
            this.btn_high.Click += new System.EventHandler(this.btn_high_Click);
            // 
            // BatteryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 265);
            this.Controls.Add(this.btn_high);
            this.Controls.Add(this.btn_low);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatteryManager";
            this.Text = "Battery Manager";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btn_low;
        private System.Windows.Forms.Button btn_high;
    }
}

