namespace ISS
{
    partial class ISSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ISSForm));
            this.buttonGetISSReading = new System.Windows.Forms.Button();
            this.picBackgroundImage = new System.Windows.Forms.PictureBox();
            this.lstISSLocations = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetISSReading
            // 
            this.buttonGetISSReading.BackColor = System.Drawing.Color.Black;
            this.buttonGetISSReading.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetISSReading.ForeColor = System.Drawing.Color.White;
            this.buttonGetISSReading.Location = new System.Drawing.Point(-4, 348);
            this.buttonGetISSReading.Name = "buttonGetISSReading";
            this.buttonGetISSReading.Size = new System.Drawing.Size(804, 90);
            this.buttonGetISSReading.TabIndex = 0;
            this.buttonGetISSReading.Text = "ISS LOCATION";
            this.buttonGetISSReading.UseVisualStyleBackColor = false;
            this.buttonGetISSReading.Click += new System.EventHandler(this.buttonGetISSReading_Click);
            // 
            // picBackgroundImage
            // 
            this.picBackgroundImage.BackColor = System.Drawing.SystemColors.Control;
            this.picBackgroundImage.ImageLocation = "";
            this.picBackgroundImage.Location = new System.Drawing.Point(-4, -12);
            this.picBackgroundImage.Name = "picBackgroundImage";
            this.picBackgroundImage.Size = new System.Drawing.Size(804, 469);
            this.picBackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBackgroundImage.TabIndex = 1;
            this.picBackgroundImage.TabStop = false;
            // 
            // lstISSLocations
            // 
            this.lstISSLocations.BackColor = System.Drawing.Color.Black;
            this.lstISSLocations.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lstISSLocations.ForeColor = System.Drawing.Color.White;
            this.lstISSLocations.FormattingEnabled = true;
            this.lstISSLocations.HorizontalScrollbar = true;
            this.lstISSLocations.ItemHeight = 17;
            this.lstISSLocations.Location = new System.Drawing.Point(-4, 253);
            this.lstISSLocations.Name = "lstISSLocations";
            this.lstISSLocations.Size = new System.Drawing.Size(804, 89);
            this.lstISSLocations.TabIndex = 3;
            // 
            // ISSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstISSLocations);
            this.Controls.Add(this.buttonGetISSReading);
            this.Controls.Add(this.picBackgroundImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ISSForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ISS Location Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetISSReading;
        private System.Windows.Forms.PictureBox picBackgroundImage;
        private System.Windows.Forms.ListBox lstISSLocations;
    }
}

