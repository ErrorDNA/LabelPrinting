using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GenCode128;

namespace LabelPrint
{
    public partial class LabelPrintMainForm : Form
    {
        public LabelPrintMainForm()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

            PrintForm PrintFrm = new PrintForm();

            PrintFrm.PrintFormNumberStartLabelText = LabelPrintMainFormNumberStart.Text;
            PrintFrm.PrintFormNumberFinishLabelText = LabelPrintMainFormNumberFinish.Text;
            string TextToEncode = LabelPrintMainFormNumberStart.Text + '-' + LabelPrintMainFormNumberFinish.Text;

            try
            {
                Image myimg = Code128Rendering.MakeBarcodeImage(TextToEncode, 1, true);
                PrintFrm.PrintFormCode128PictureBoxImage = myimg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Text);
            }

            PrintFrm.ShowDialog();


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
