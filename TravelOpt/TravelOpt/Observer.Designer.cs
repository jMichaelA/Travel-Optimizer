namespace TravelOpt
{
    partial class Observer
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
            this.airportLbl = new System.Windows.Forms.Label();
            this.airportCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // airportLbl
            // 
            this.airportLbl.AutoSize = true;
            this.airportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.airportLbl.Location = new System.Drawing.Point(33, 39);
            this.airportLbl.Name = "airportLbl";
            this.airportLbl.Size = new System.Drawing.Size(159, 20);
            this.airportLbl.TabIndex = 3;
            this.airportLbl.Text = "Select desired airport";
            // 
            // airportCombo
            // 
            this.airportCombo.FormattingEnabled = true;
            this.airportCombo.Location = new System.Drawing.Point(37, 62);
            this.airportCombo.Name = "airportCombo";
            this.airportCombo.Size = new System.Drawing.Size(155, 21);
            this.airportCombo.TabIndex = 2;
            // 
            // Observer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 337);
            this.Controls.Add(this.airportLbl);
            this.Controls.Add(this.airportCombo);
            this.Name = "Observer";
            this.Text = "Guide";
            this.Load += new System.EventHandler(this.Observer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label airportLbl;
        private System.Windows.Forms.ComboBox airportCombo;
    }
}