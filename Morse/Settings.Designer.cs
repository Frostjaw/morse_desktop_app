namespace Morse
{
    partial class Settings
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
            this.frequency_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dotDuration_trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.frequency_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotDuration_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // frequency_trackBar
            // 
            this.frequency_trackBar.Location = new System.Drawing.Point(296, 125);
            this.frequency_trackBar.Name = "frequency_trackBar";
            this.frequency_trackBar.Size = new System.Drawing.Size(168, 45);
            this.frequency_trackBar.TabIndex = 1;
            this.frequency_trackBar.Scroll += new System.EventHandler(this.frequency_trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(343, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Частота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(331, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Длина точки";
            // 
            // dotDuration_trackBar
            // 
            this.dotDuration_trackBar.Location = new System.Drawing.Point(296, 244);
            this.dotDuration_trackBar.Maximum = 2;
            this.dotDuration_trackBar.Name = "dotDuration_trackBar";
            this.dotDuration_trackBar.Size = new System.Drawing.Size(168, 45);
            this.dotDuration_trackBar.TabIndex = 4;
            this.dotDuration_trackBar.Scroll += new System.EventHandler(this.dotDuration_trackBar_Scroll);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dotDuration_trackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frequency_trackBar);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.frequency_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotDuration_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar frequency_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar dotDuration_trackBar;
    }
}