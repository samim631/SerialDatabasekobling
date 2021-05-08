using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialDatabasekobling
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softSensDBDataSet1.DataAcqusitionUnits' table. You can move, or remove it, as needed.
            this.dataAcqusitionUnitsTableAdapter1.Fill(this.softSensDBDataSet1.DataAcqusitionUnits);
            // TODO: This line of code loads data into the 'softSensDBDataSet.DataAcqusitionUnits' table. You can move, or remove it, as needed.
            this.dataAcqusitionUnitsTableAdapter.Fill(this.softSensDBDataSet.DataAcqusitionUnits);
            // TODO: This line of code loads data into the 'softSensDBDataSet.LOCATION' table. You can move, or remove it, as needed.
            this.lOCATIONTableAdapter.Fill(this.softSensDBDataSet.LOCATION);
            // TODO: This line of code loads data into the 'softSensDBDataSet.InstrumentLog' table. You can move, or remove it, as needed.
            this.instrumentLogTableAdapter.Fill(this.softSensDBDataSet.InstrumentLog);
            // TODO: This line of code loads data into the 'softSensDBDataSet.RemoteDataCollectors' table. You can move, or remove it, as needed.
            this.remoteDataCollectorsTableAdapter.Fill(this.softSensDBDataSet.RemoteDataCollectors);
            // TODO: This line of code loads data into the 'softSensDBDataSet.Manufaturers' table. You can move, or remove it, as needed.
            this.manufaturersTableAdapter.Fill(this.softSensDBDataSet.Manufaturers);
            // TODO: This line of code loads data into the 'softSensDBDataSet.Insturments' table. You can move, or remove it, as needed.
            this.insturmentsTableAdapter.Fill(this.softSensDBDataSet.Insturments);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
