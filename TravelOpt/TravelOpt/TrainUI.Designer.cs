namespace TravelFactory
{
    partial class TrainUI
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
            this.departureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.departureLabel.Location = new System.Drawing.Point(13, 13);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(163, 25);
            this.departureLabel.TabIndex = 0;
            this.departureLabel.Text = "Departure Times:";
            // 
            // TrainUI
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 472);
            this.Controls.Add(this.departureLabel);
            this.Name = "TrainUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}