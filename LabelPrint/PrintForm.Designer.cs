namespace LabelPrint
{
    partial class PrintForm
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
            this.PrintFormNumberStartLabel = new System.Windows.Forms.Label();
            this.PrintFormNumberFinishLabel = new System.Windows.Forms.Label();
            this.PrintFormCode128PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrintFormCode128PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintFormNumberStartLabel
            // 
            this.PrintFormNumberStartLabel.AutoSize = true;
            this.PrintFormNumberStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintFormNumberStartLabel.Location = new System.Drawing.Point(258, 446);
            this.PrintFormNumberStartLabel.Name = "PrintFormNumberStartLabel";
            this.PrintFormNumberStartLabel.Size = new System.Drawing.Size(57, 20);
            this.PrintFormNumberStartLabel.TabIndex = 0;
            this.PrintFormNumberStartLabel.Text = "label1";
            // 
            // PrintFormNumberFinishLabel
            // 
            this.PrintFormNumberFinishLabel.AutoSize = true;
            this.PrintFormNumberFinishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintFormNumberFinishLabel.Location = new System.Drawing.Point(544, 446);
            this.PrintFormNumberFinishLabel.Name = "PrintFormNumberFinishLabel";
            this.PrintFormNumberFinishLabel.Size = new System.Drawing.Size(57, 20);
            this.PrintFormNumberFinishLabel.TabIndex = 1;
            this.PrintFormNumberFinishLabel.Text = "label2";
            // 
            // PrintFormCode128PictureBox
            // 
            this.PrintFormCode128PictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.PrintFormCode128PictureBox.Location = new System.Drawing.Point(548, 134);
            this.PrintFormCode128PictureBox.Name = "PrintFormCode128PictureBox";
            this.PrintFormCode128PictureBox.Size = new System.Drawing.Size(286, 48);
            this.PrintFormCode128PictureBox.TabIndex = 2;
            this.PrintFormCode128PictureBox.TabStop = false;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LabelPrint.Properties.Resources.Box_Label_EC_RESO_128;
            this.ClientSize = new System.Drawing.Size(917, 600);
            this.Controls.Add(this.PrintFormCode128PictureBox);
            this.Controls.Add(this.PrintFormNumberFinishLabel);
            this.Controls.Add(this.PrintFormNumberStartLabel);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            ((System.ComponentModel.ISupportInitialize)(this.PrintFormCode128PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrintFormNumberStartLabel;
        private System.Windows.Forms.Label PrintFormNumberFinishLabel;
        private System.Windows.Forms.PictureBox PrintFormCode128PictureBox;
    }
}