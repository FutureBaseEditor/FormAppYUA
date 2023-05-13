namespace FormAppYUS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Good = new System.Windows.Forms.Button();
            this.Cheap = new System.Windows.Forms.Button();
            this.Fast = new System.Windows.Forms.Button();
            this.trackBarGood = new System.Windows.Forms.TrackBar();
            this.trackBarCheap = new System.Windows.Forms.TrackBar();
            this.trackBarFast = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCheap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFast)).BeginInit();
            this.SuspendLayout();
            // 
            // Good
            // 
            this.Good.BackColor = System.Drawing.Color.Brown;
            this.Good.ForeColor = System.Drawing.Color.White;
            this.Good.Location = new System.Drawing.Point(12, 12);
            this.Good.Name = "Good";
            this.Good.Size = new System.Drawing.Size(149, 94);
            this.Good.TabIndex = 0;
            this.Good.Text = "Good";
            this.Good.UseVisualStyleBackColor = false;
            this.Good.Click += new System.EventHandler(this.Good_Click);
            // 
            // Cheap
            // 
            this.Cheap.BackColor = System.Drawing.Color.Brown;
            this.Cheap.ForeColor = System.Drawing.Color.White;
            this.Cheap.Location = new System.Drawing.Point(167, 12);
            this.Cheap.Name = "Cheap";
            this.Cheap.Size = new System.Drawing.Size(149, 94);
            this.Cheap.TabIndex = 1;
            this.Cheap.Text = "Cheap";
            this.Cheap.UseVisualStyleBackColor = false;
            this.Cheap.Click += new System.EventHandler(this.Cheap_Click);
            // 
            // Fast
            // 
            this.Fast.BackColor = System.Drawing.Color.Brown;
            this.Fast.ForeColor = System.Drawing.Color.White;
            this.Fast.Location = new System.Drawing.Point(322, 12);
            this.Fast.Name = "Fast";
            this.Fast.Size = new System.Drawing.Size(149, 94);
            this.Fast.TabIndex = 2;
            this.Fast.Text = "Fast";
            this.Fast.UseVisualStyleBackColor = false;
            this.Fast.Click += new System.EventHandler(this.Fast_Click);
            // 
            // trackBarGood
            // 
            this.trackBarGood.BackColor = System.Drawing.Color.Brown;
            this.trackBarGood.Location = new System.Drawing.Point(58, 121);
            this.trackBarGood.Maximum = 1;
            this.trackBarGood.Name = "trackBarGood";
            this.trackBarGood.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGood.Size = new System.Drawing.Size(56, 258);
            this.trackBarGood.TabIndex = 3;
            this.trackBarGood.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarGood.ValueChanged += new System.EventHandler(this.trackBarGood_ValueChanged);
            // 
            // trackBarCheap
            // 
            this.trackBarCheap.BackColor = System.Drawing.Color.Brown;
            this.trackBarCheap.Location = new System.Drawing.Point(213, 121);
            this.trackBarCheap.Maximum = 1;
            this.trackBarCheap.Name = "trackBarCheap";
            this.trackBarCheap.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarCheap.Size = new System.Drawing.Size(56, 258);
            this.trackBarCheap.TabIndex = 4;
            this.trackBarCheap.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarCheap.ValueChanged += new System.EventHandler(this.trackBarCheap_ValueChanged);
            // 
            // trackBarFast
            // 
            this.trackBarFast.BackColor = System.Drawing.Color.Brown;
            this.trackBarFast.Location = new System.Drawing.Point(368, 121);
            this.trackBarFast.Maximum = 1;
            this.trackBarFast.Name = "trackBarFast";
            this.trackBarFast.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarFast.Size = new System.Drawing.Size(56, 258);
            this.trackBarFast.TabIndex = 5;
            this.trackBarFast.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarFast.ValueChanged += new System.EventHandler(this.trackBarFast_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.trackBarFast);
            this.Controls.Add(this.trackBarCheap);
            this.Controls.Add(this.trackBarGood);
            this.Controls.Add(this.Fast);
            this.Controls.Add(this.Cheap);
            this.Controls.Add(this.Good);
            this.Name = "Form1";
            this.Text = "Good/Cheap/Fast";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCheap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Good;
        private Button Cheap;
        private Button Fast;
        private TrackBar trackBarGood;
        private TrackBar trackBarCheap;
        private TrackBar trackBarFast;
    }
}