using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SolievAH.Sprint7.Projcet.V10.Forms
{
    public partial class FormStatistics : Form
    {
        int[] chartPrice;
        public FormStatistics(int [] Price)
        {
            InitializeComponent();
            chartPrice = Price;
        }

        private void buttonDone_SAH_Click(object sender, EventArgs e)
        {
            chartMid_SAH.Series[0].Points.DataBindY(chartPrice);
        }
    }
}
