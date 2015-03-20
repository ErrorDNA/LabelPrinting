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
    public partial class PrintForm : Form
    {

        public string PrintFormNumberStartLabelText
        {
            get { return PrintFormNumberStartLabel.Text; }
            set { PrintFormNumberStartLabel.Text = value; }
        }

        public string PrintFormNumberFinishLabelText
        {
            get { return PrintFormNumberFinishLabel.Text; }
            set { PrintFormNumberFinishLabel.Text = value; }
        }

        public Image PrintFormCode128PictureBoxImage
        {
            get { return PrintFormCode128PictureBox.Image; }
            set { PrintFormCode128PictureBox.Image = value; }
        }

        public PrintForm()
        {
            InitializeComponent();
        }

    }
}
