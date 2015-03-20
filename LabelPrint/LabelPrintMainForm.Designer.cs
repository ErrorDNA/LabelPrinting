namespace LabelPrint
{
    partial class LabelPrintMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.OrderNumber = new System.Windows.Forms.TextBox();
            this.BoxNumber = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.OrderName = new System.Windows.Forms.TextBox();
            this.CountItemsInBox = new System.Windows.Forms.TextBox();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.NumberStart = new System.Windows.Forms.TextBox();
            this.NumberFinish = new System.Windows.Forms.TextBox();
            this.TotalCount = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказ №";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Короб №";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заказчик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Наименование заказа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество экземпляров в коробе";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Серия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Нумерация с №";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "по №";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Общий тираж";
            // 
            // OrderNumber
            // 
            this.OrderNumber.Location = new System.Drawing.Point(15, 38);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(154, 20);
            this.OrderNumber.TabIndex = 9;
            // 
            // BoxNumber
            // 
            this.BoxNumber.Location = new System.Drawing.Point(219, 38);
            this.BoxNumber.Name = "BoxNumber";
            this.BoxNumber.Size = new System.Drawing.Size(154, 20);
            this.BoxNumber.TabIndex = 10;
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(15, 93);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(358, 20);
            this.CustomerName.TabIndex = 11;
            // 
            // OrderName
            // 
            this.OrderName.Location = new System.Drawing.Point(15, 144);
            this.OrderName.Name = "OrderName";
            this.OrderName.Size = new System.Drawing.Size(358, 20);
            this.OrderName.TabIndex = 12;
            // 
            // CountItemsInBox
            // 
            this.CountItemsInBox.Location = new System.Drawing.Point(15, 197);
            this.CountItemsInBox.Name = "CountItemsInBox";
            this.CountItemsInBox.Size = new System.Drawing.Size(154, 20);
            this.CountItemsInBox.TabIndex = 13;
            // 
            // SerialNumber
            // 
            this.SerialNumber.Location = new System.Drawing.Point(219, 197);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(154, 20);
            this.SerialNumber.TabIndex = 14;
            // 
            // NumberStart
            // 
            this.NumberStart.Location = new System.Drawing.Point(15, 250);
            this.NumberStart.Name = "NumberStart";
            this.NumberStart.Size = new System.Drawing.Size(154, 20);
            this.NumberStart.TabIndex = 15;
            // 
            // NumberFinish
            // 
            this.NumberFinish.Location = new System.Drawing.Point(219, 250);
            this.NumberFinish.Name = "NumberFinish";
            this.NumberFinish.Size = new System.Drawing.Size(154, 20);
            this.NumberFinish.TabIndex = 16;
            // 
            // TotalCount
            // 
            this.TotalCount.Location = new System.Drawing.Point(15, 300);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(154, 20);
            this.TotalCount.TabIndex = 17;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(303, 297);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 18;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(303, 328);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // LabelPrintMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 363);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.TotalCount);
            this.Controls.Add(this.NumberFinish);
            this.Controls.Add(this.NumberStart);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.CountItemsInBox);
            this.Controls.Add(this.OrderName);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.BoxNumber);
            this.Controls.Add(this.OrderNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LabelPrintMainForm";
            this.Text = "Печать этикеток на короба";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OrderNumber;
        private System.Windows.Forms.TextBox BoxNumber;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox OrderName;
        private System.Windows.Forms.TextBox CountItemsInBox;
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.TextBox NumberStart;
        private System.Windows.Forms.TextBox NumberFinish;
        private System.Windows.Forms.TextBox TotalCount;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

