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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Observer));
            this.airportLbl = new System.Windows.Forms.Label();
            this.airportCombo = new System.Windows.Forms.ComboBox();
            this.trainLbl = new System.Windows.Forms.Label();
            this.trainCombo = new System.Windows.Forms.ComboBox();
            this.airportGrp = new System.Windows.Forms.GroupBox();
            this.trainGrp = new System.Windows.Forms.GroupBox();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.informationGrp = new System.Windows.Forms.GroupBox();
            this.departureLbl = new System.Windows.Forms.Label();
            this.returnDateLbl = new System.Windows.Forms.Label();
            this.airportGrp.SuspendLayout();
            this.trainGrp.SuspendLayout();
            this.informationGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // airportLbl
            // 
            this.airportLbl.AutoSize = true;
            this.airportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.airportLbl.Location = new System.Drawing.Point(6, 42);
            this.airportLbl.Name = "airportLbl";
            this.airportLbl.Size = new System.Drawing.Size(157, 20);
            this.airportLbl.TabIndex = 3;
            this.airportLbl.Text = "Select closest airport";
            // 
            // airportCombo
            // 
            this.airportCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.airportCombo.FormattingEnabled = true;
            this.airportCombo.Location = new System.Drawing.Point(10, 75);
            this.airportCombo.Name = "airportCombo";
            this.airportCombo.Size = new System.Drawing.Size(245, 24);
            this.airportCombo.TabIndex = 2;
            // 
            // trainLbl
            // 
            this.trainLbl.AutoSize = true;
            this.trainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.trainLbl.Location = new System.Drawing.Point(6, 42);
            this.trainLbl.Name = "trainLbl";
            this.trainLbl.Size = new System.Drawing.Size(195, 20);
            this.trainLbl.TabIndex = 5;
            this.trainLbl.Text = "Select closest train station";
            // 
            // trainCombo
            // 
            this.trainCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.trainCombo.FormattingEnabled = true;
            this.trainCombo.Location = new System.Drawing.Point(8, 75);
            this.trainCombo.Name = "trainCombo";
            this.trainCombo.Size = new System.Drawing.Size(286, 24);
            this.trainCombo.TabIndex = 4;
            // 
            // airportGrp
            // 
            this.airportGrp.Controls.Add(this.airportCombo);
            this.airportGrp.Controls.Add(this.airportLbl);
            this.airportGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.airportGrp.Location = new System.Drawing.Point(12, 12);
            this.airportGrp.Name = "airportGrp";
            this.airportGrp.Size = new System.Drawing.Size(358, 159);
            this.airportGrp.TabIndex = 6;
            this.airportGrp.TabStop = false;
            this.airportGrp.Text = "Airport";
            // 
            // trainGrp
            // 
            this.trainGrp.Controls.Add(this.trainCombo);
            this.trainGrp.Controls.Add(this.trainLbl);
            this.trainGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.trainGrp.Location = new System.Drawing.Point(413, 12);
            this.trainGrp.Name = "trainGrp";
            this.trainGrp.Size = new System.Drawing.Size(316, 159);
            this.trainGrp.TabIndex = 7;
            this.trainGrp.TabStop = false;
            this.trainGrp.Text = "Train";
            // 
            // departureDate
            // 
            this.departureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.departureDate.Location = new System.Drawing.Point(10, 68);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(224, 20);
            this.departureDate.TabIndex = 4;
            this.departureDate.ValueChanged += new System.EventHandler(this.departureDate_ValueChanged);
            // 
            // returnDate
            // 
            this.returnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.returnDate.Location = new System.Drawing.Point(10, 139);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(224, 20);
            this.returnDate.TabIndex = 5;
            this.returnDate.ValueChanged += new System.EventHandler(this.returnDate_ValueChanged);
            // 
            // informationGrp
            // 
            this.informationGrp.Controls.Add(this.returnDateLbl);
            this.informationGrp.Controls.Add(this.departureLbl);
            this.informationGrp.Controls.Add(this.departureDate);
            this.informationGrp.Controls.Add(this.returnDate);
            this.informationGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.informationGrp.Location = new System.Drawing.Point(12, 196);
            this.informationGrp.Name = "informationGrp";
            this.informationGrp.Size = new System.Drawing.Size(717, 200);
            this.informationGrp.TabIndex = 8;
            this.informationGrp.TabStop = false;
            this.informationGrp.Text = "Information";
            // 
            // departureLbl
            // 
            this.departureLbl.AutoSize = true;
            this.departureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departureLbl.Location = new System.Drawing.Point(6, 45);
            this.departureLbl.Name = "departureLbl";
            this.departureLbl.Size = new System.Drawing.Size(120, 20);
            this.departureLbl.TabIndex = 6;
            this.departureLbl.Text = "Departure Date";
            // 
            // returnDateLbl
            // 
            this.returnDateLbl.AutoSize = true;
            this.returnDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.returnDateLbl.Location = new System.Drawing.Point(6, 116);
            this.returnDateLbl.Name = "returnDateLbl";
            this.returnDateLbl.Size = new System.Drawing.Size(97, 20);
            this.returnDateLbl.TabIndex = 7;
            this.returnDateLbl.Text = "Return Date";
            // 
            // Observer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 435);
            this.Controls.Add(this.informationGrp);
            this.Controls.Add(this.trainGrp);
            this.Controls.Add(this.airportGrp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Observer";
            this.Text = "Guide";
            this.Load += new System.EventHandler(this.Observer_Load);
            this.airportGrp.ResumeLayout(false);
            this.airportGrp.PerformLayout();
            this.trainGrp.ResumeLayout(false);
            this.trainGrp.PerformLayout();
            this.informationGrp.ResumeLayout(false);
            this.informationGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label airportLbl;
        private System.Windows.Forms.ComboBox airportCombo;
        private System.Windows.Forms.Label trainLbl;
        private System.Windows.Forms.ComboBox trainCombo;
        private System.Windows.Forms.GroupBox airportGrp;
        private System.Windows.Forms.GroupBox trainGrp;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.GroupBox informationGrp;
        private System.Windows.Forms.Label returnDateLbl;
        private System.Windows.Forms.Label departureLbl;
    }
}