
namespace SerialDatabasekobling
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tagnameLabel;
            System.Windows.Forms.Label tagDescriptionLabel;
            System.Windows.Forms.Label lowerRangeValueLabel;
            System.Windows.Forms.Label upperRangeValueLabel;
            System.Windows.Forms.Label alarmLowLabel;
            System.Windows.Forms.Label alarmHighLabel;
            System.Windows.Forms.Label dAUIDLabel;
            System.Windows.Forms.Label channelLabel;
            System.Windows.Forms.Label manufacturerIDLabel;
            System.Windows.Forms.Label observationLabel;
            System.Windows.Forms.Label dAUIDLabel1;
            System.Windows.Forms.Label deviceNameLabel;
            System.Windows.Forms.Label baudRateLabel;
            System.Windows.Forms.Label cOMPortLabel;
            System.Windows.Forms.Label installationDataLabel;
            System.Windows.Forms.Label configUpdateLabel;
            System.Windows.Forms.Label rDCIDLabel;
            System.Windows.Forms.Label manufacturerIDLabel2;
            System.Windows.Forms.Label manufacturerIDLabel3;
            System.Windows.Forms.Label locationIDLabel1;
            System.Windows.Forms.Label logIDLabel;
            System.Windows.Forms.Label tagnameLabel1;
            System.Windows.Forms.Label logTimestampLabel;
            System.Windows.Forms.Label logValueLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.Label locationIDLabel;
            System.Windows.Forms.Label locationNameLabel;
            System.Windows.Forms.Label manufacturerIDLabel1;
            System.Windows.Forms.Label companyNameLabel;
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.softSensDBDataSet = new SerialDatabasekobling.SoftSensDBDataSet();
            this.insturmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insturmentsTableAdapter = new SerialDatabasekobling.SoftSensDBDataSetTableAdapters.InsturmentsTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.manufaturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufaturersTableAdapter = new SerialDatabasekobling.SoftSensDBDataSetTableAdapters.ManufaturersTableAdapter();
            this.remoteDataCollectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remoteDataCollectorsTableAdapter = new SerialDatabasekobling.SoftSensDBDataSetTableAdapters.RemoteDataCollectorsTableAdapter();
            this.remoteDataCollectorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentLogTableAdapter = new SerialDatabasekobling.SoftSensDBDataSetTableAdapters.InstrumentLogTableAdapter();
            this.logIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insturmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new SerialDatabasekobling.SoftSensDBDataSetTableAdapters.TableAdapterManager();
            this.tagnameTextBox = new System.Windows.Forms.TextBox();
            this.tagDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.lowerRangeValueTextBox = new System.Windows.Forms.TextBox();
            this.upperRangeValueTextBox = new System.Windows.Forms.TextBox();
            this.alarmLowTextBox = new System.Windows.Forms.TextBox();
            this.alarmHighTextBox = new System.Windows.Forms.TextBox();
            this.dAUIDTextBox = new System.Windows.Forms.TextBox();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.lOCATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOCATIONTableAdapter = new SerialDatabasekobling.SoftSensDBDataSetTableAdapters.LOCATIONTableAdapter();
            this.manufaturersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataAcqusitionUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataAcqusitionUnitsTableAdapter = new SerialDatabasekobling.SoftSensDBDataSetTableAdapters.DataAcqusitionUnitsTableAdapter();
            this.deviceNameTextBox = new System.Windows.Forms.TextBox();
            this.baudRateTextBox = new System.Windows.Forms.TextBox();
            this.cOMPortTextBox = new System.Windows.Forms.TextBox();
            this.installationDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.configUpdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.manufacturerIDTextBox2 = new System.Windows.Forms.TextBox();
            this.instrumentLogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logIDTextBox = new System.Windows.Forms.TextBox();
            this.tagnameTextBox1 = new System.Windows.Forms.TextBox();
            this.logTimestampDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.logValueTextBox = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.button2New = new System.Windows.Forms.Button();
            this.button3Connect = new System.Windows.Forms.Button();
            this.button4Disconnect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button5Cancel = new System.Windows.Forms.Button();
            this.button6Save = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox3X = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBox5Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxVa = new System.Windows.Forms.ListBox();
            this.listBox2Vb = new System.Windows.Forms.ListBox();
            this.listBox3Vab = new System.Windows.Forms.ListBox();
            this.timerSerialReceiver = new System.Windows.Forms.Timer(this.components);
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDCDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDCDNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDCIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dAUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baudRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDCIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softSensDBDataSet1 = new SerialDatabasekobling.SoftSensDBDataSet1();
            this.dataAcqusitionUnitsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataAcqusitionUnitsTableAdapter1 = new SerialDatabasekobling.SoftSensDBDataSet1TableAdapters.DataAcqusitionUnitsTableAdapter();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.Tagname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowerRangeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upperRangeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmLowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmHighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.channelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.observationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tagnameLabel = new System.Windows.Forms.Label();
            tagDescriptionLabel = new System.Windows.Forms.Label();
            lowerRangeValueLabel = new System.Windows.Forms.Label();
            upperRangeValueLabel = new System.Windows.Forms.Label();
            alarmLowLabel = new System.Windows.Forms.Label();
            alarmHighLabel = new System.Windows.Forms.Label();
            dAUIDLabel = new System.Windows.Forms.Label();
            channelLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel = new System.Windows.Forms.Label();
            observationLabel = new System.Windows.Forms.Label();
            dAUIDLabel1 = new System.Windows.Forms.Label();
            deviceNameLabel = new System.Windows.Forms.Label();
            baudRateLabel = new System.Windows.Forms.Label();
            cOMPortLabel = new System.Windows.Forms.Label();
            installationDataLabel = new System.Windows.Forms.Label();
            configUpdateLabel = new System.Windows.Forms.Label();
            rDCIDLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel2 = new System.Windows.Forms.Label();
            manufacturerIDLabel3 = new System.Windows.Forms.Label();
            locationIDLabel1 = new System.Windows.Forms.Label();
            logIDLabel = new System.Windows.Forms.Label();
            tagnameLabel1 = new System.Windows.Forms.Label();
            logTimestampLabel = new System.Windows.Forms.Label();
            logValueLabel = new System.Windows.Forms.Label();
            locationIDLabel = new System.Windows.Forms.Label();
            locationNameLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel1 = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insturmentsBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufaturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insturmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufaturersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentLogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnitsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            this.bindingSource1.DataSource = this.softSensDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // softSensDBDataSet
            // 
            this.softSensDBDataSet.DataSetName = "SoftSensDBDataSet";
            this.softSensDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insturmentsBindingSource
            // 
            this.insturmentsBindingSource.DataMember = "Insturments";
            this.insturmentsBindingSource.DataSource = this.bindingSource1;
            // 
            // insturmentsTableAdapter
            // 
            this.insturmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 448);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Controls.Add(this.comboBox6);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(observationLabel);
            this.tabPage1.Controls.Add(manufacturerIDLabel);
            this.tabPage1.Controls.Add(channelLabel);
            this.tabPage1.Controls.Add(this.channelTextBox);
            this.tabPage1.Controls.Add(dAUIDLabel);
            this.tabPage1.Controls.Add(this.dAUIDTextBox);
            this.tabPage1.Controls.Add(alarmHighLabel);
            this.tabPage1.Controls.Add(this.alarmHighTextBox);
            this.tabPage1.Controls.Add(alarmLowLabel);
            this.tabPage1.Controls.Add(this.alarmLowTextBox);
            this.tabPage1.Controls.Add(upperRangeValueLabel);
            this.tabPage1.Controls.Add(this.upperRangeValueTextBox);
            this.tabPage1.Controls.Add(lowerRangeValueLabel);
            this.tabPage1.Controls.Add(this.lowerRangeValueTextBox);
            this.tabPage1.Controls.Add(tagDescriptionLabel);
            this.tabPage1.Controls.Add(this.tagDescriptionTextBox);
            this.tabPage1.Controls.Add(tagnameLabel);
            this.tabPage1.Controls.Add(this.tagnameTextBox);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(904, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Instrument";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.bindingNavigator2);
            this.tabPage4.Controls.Add(this.radioButton1);
            this.tabPage4.Controls.Add(this.button6Save);
            this.tabPage4.Controls.Add(this.button5Cancel);
            this.tabPage4.Controls.Add(this.comboBox4);
            this.tabPage4.Controls.Add(this.comboBox3);
            this.tabPage4.Controls.Add(this.comboBox2);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.button4Disconnect);
            this.tabPage4.Controls.Add(this.button3Connect);
            this.tabPage4.Controls.Add(this.button2New);
            this.tabPage4.Controls.Add(this.buttonChange);
            this.tabPage4.Controls.Add(locationIDLabel1);
            this.tabPage4.Controls.Add(manufacturerIDLabel3);
            this.tabPage4.Controls.Add(manufacturerIDLabel2);
            this.tabPage4.Controls.Add(this.manufacturerIDTextBox2);
            this.tabPage4.Controls.Add(rDCIDLabel);
            this.tabPage4.Controls.Add(configUpdateLabel);
            this.tabPage4.Controls.Add(this.configUpdateDateTimePicker);
            this.tabPage4.Controls.Add(installationDataLabel);
            this.tabPage4.Controls.Add(this.installationDataDateTimePicker);
            this.tabPage4.Controls.Add(cOMPortLabel);
            this.tabPage4.Controls.Add(this.cOMPortTextBox);
            this.tabPage4.Controls.Add(baudRateLabel);
            this.tabPage4.Controls.Add(this.baudRateTextBox);
            this.tabPage4.Controls.Add(deviceNameLabel);
            this.tabPage4.Controls.Add(this.deviceNameTextBox);
            this.tabPage4.Controls.Add(dAUIDLabel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(904, 422);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "DAU";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.bindingNavigator3);
            this.tabPage5.Controls.Add(logValueLabel);
            this.tabPage5.Controls.Add(this.logValueTextBox);
            this.tabPage5.Controls.Add(logTimestampLabel);
            this.tabPage5.Controls.Add(this.logTimestampDateTimePicker);
            this.tabPage5.Controls.Add(tagnameLabel1);
            this.tabPage5.Controls.Add(this.tagnameTextBox1);
            this.tabPage5.Controls.Add(logIDLabel);
            this.tabPage5.Controls.Add(this.logIDTextBox);
            this.tabPage5.Controls.Add(this.dataGridView6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(782, 422);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "InstrumentLog";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chart1);
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.button2);
            this.tabPage6.Controls.Add(this.button1);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Controls.Add(this.listBox3Vab);
            this.tabPage6.Controls.Add(this.listBox2Vb);
            this.tabPage6.Controls.Add(this.listBoxVa);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.textBox5Result);
            this.tabPage6.Controls.Add(this.textBoxY);
            this.tabPage6.Controls.Add(this.textBox3X);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(782, 422);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "Loop";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tagname,
            this.tagDescriptionDataGridViewTextBoxColumn,
            this.lowerRangeValueDataGridViewTextBoxColumn,
            this.upperRangeValueDataGridViewTextBoxColumn,
            this.alarmLowDataGridViewTextBoxColumn,
            this.alarmHighDataGridViewTextBoxColumn,
            this.dAUIDDataGridViewTextBoxColumn,
            this.channelDataGridViewTextBoxColumn,
            this.manufacturerIDDataGridViewTextBoxColumn,
            this.observationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.insturmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 94);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logIDDataGridViewTextBoxColumn,
            this.tagnameDataGridViewTextBoxColumn1,
            this.logTimestampDataGridViewTextBoxColumn,
            this.logValueDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.instrumentLogBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(0, 292);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(443, 127);
            this.dataGridView6.TabIndex = 0;
            // 
            // manufaturersBindingSource
            // 
            this.manufaturersBindingSource.DataMember = "Manufaturers";
            this.manufaturersBindingSource.DataSource = this.bindingSource1;
            // 
            // manufaturersTableAdapter
            // 
            this.manufaturersTableAdapter.ClearBeforeFill = true;
            // 
            // remoteDataCollectorsBindingSource
            // 
            this.remoteDataCollectorsBindingSource.DataMember = "RemoteDataCollectors";
            this.remoteDataCollectorsBindingSource.DataSource = this.bindingSource1;
            // 
            // remoteDataCollectorsTableAdapter
            // 
            this.remoteDataCollectorsTableAdapter.ClearBeforeFill = true;
            // 
            // remoteDataCollectorsBindingSource1
            // 
            this.remoteDataCollectorsBindingSource1.DataMember = "RemoteDataCollectors";
            this.remoteDataCollectorsBindingSource1.DataSource = this.bindingSource1;
            // 
            // instrumentLogBindingSource
            // 
            this.instrumentLogBindingSource.DataMember = "InstrumentLog";
            this.instrumentLogBindingSource.DataSource = this.bindingSource1;
            // 
            // instrumentLogTableAdapter
            // 
            this.instrumentLogTableAdapter.ClearBeforeFill = true;
            // 
            // logIDDataGridViewTextBoxColumn
            // 
            this.logIDDataGridViewTextBoxColumn.DataPropertyName = "LogID";
            this.logIDDataGridViewTextBoxColumn.HeaderText = "LogID";
            this.logIDDataGridViewTextBoxColumn.Name = "logIDDataGridViewTextBoxColumn";
            // 
            // tagnameDataGridViewTextBoxColumn1
            // 
            this.tagnameDataGridViewTextBoxColumn1.DataPropertyName = "Tagname";
            this.tagnameDataGridViewTextBoxColumn1.HeaderText = "Tagname";
            this.tagnameDataGridViewTextBoxColumn1.Name = "tagnameDataGridViewTextBoxColumn1";
            // 
            // logTimestampDataGridViewTextBoxColumn
            // 
            this.logTimestampDataGridViewTextBoxColumn.DataPropertyName = "LogTimestamp";
            this.logTimestampDataGridViewTextBoxColumn.HeaderText = "LogTimestamp";
            this.logTimestampDataGridViewTextBoxColumn.Name = "logTimestampDataGridViewTextBoxColumn";
            // 
            // logValueDataGridViewTextBoxColumn
            // 
            this.logValueDataGridViewTextBoxColumn.DataPropertyName = "LogValue";
            this.logValueDataGridViewTextBoxColumn.HeaderText = "LogValue";
            this.logValueDataGridViewTextBoxColumn.Name = "logValueDataGridViewTextBoxColumn";
            // 
            // insturmentsBindingSource1
            // 
            this.insturmentsBindingSource1.DataMember = "Insturments";
            this.insturmentsBindingSource1.DataSource = this.softSensDBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DataAcqusitionUnitsTableAdapter = this.dataAcqusitionUnitsTableAdapter;
            this.tableAdapterManager.InstrumentLogTableAdapter = this.instrumentLogTableAdapter;
            this.tableAdapterManager.InsturmentsTableAdapter = this.insturmentsTableAdapter;
            this.tableAdapterManager.LOCATIONTableAdapter = this.lOCATIONTableAdapter;
            this.tableAdapterManager.Log_AOTableAdapter = null;
            this.tableAdapterManager.Log_DITableAdapter = null;
            this.tableAdapterManager.Log_DOTableAdapter = null;
            this.tableAdapterManager.Log1_AlTableAdapter = null;
            this.tableAdapterManager.ManufaturersTableAdapter = this.manufaturersTableAdapter;
            this.tableAdapterManager.RemoteDataCollectorsTableAdapter = this.remoteDataCollectorsTableAdapter;
            this.tableAdapterManager.UpdateOrder = SerialDatabasekobling.SoftSensDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tagnameLabel
            // 
            tagnameLabel.AutoSize = true;
            tagnameLabel.Location = new System.Drawing.Point(3, 42);
            tagnameLabel.Name = "tagnameLabel";
            tagnameLabel.Size = new System.Drawing.Size(55, 13);
            tagnameLabel.TabIndex = 1;
            tagnameLabel.Text = "Tagname:";
            // 
            // tagnameTextBox
            // 
            this.tagnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insturmentsBindingSource1, "Tagname", true));
            this.tagnameTextBox.Location = new System.Drawing.Point(126, 42);
            this.tagnameTextBox.Name = "tagnameTextBox";
            this.tagnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.tagnameTextBox.TabIndex = 2;
            // 
            // tagDescriptionLabel
            // 
            tagDescriptionLabel.AutoSize = true;
            tagDescriptionLabel.Location = new System.Drawing.Point(3, 74);
            tagDescriptionLabel.Name = "tagDescriptionLabel";
            tagDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            tagDescriptionLabel.TabIndex = 3;
            tagDescriptionLabel.Text = "Tag Description:";
            // 
            // tagDescriptionTextBox
            // 
            this.tagDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insturmentsBindingSource1, "TagDescription", true));
            this.tagDescriptionTextBox.Location = new System.Drawing.Point(126, 74);
            this.tagDescriptionTextBox.Name = "tagDescriptionTextBox";
            this.tagDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.tagDescriptionTextBox.TabIndex = 4;
            // 
            // lowerRangeValueLabel
            // 
            lowerRangeValueLabel.AutoSize = true;
            lowerRangeValueLabel.Location = new System.Drawing.Point(3, 105);
            lowerRangeValueLabel.Name = "lowerRangeValueLabel";
            lowerRangeValueLabel.Size = new System.Drawing.Size(104, 13);
            lowerRangeValueLabel.TabIndex = 5;
            lowerRangeValueLabel.Text = "Lower Range Value:";
            // 
            // lowerRangeValueTextBox
            // 
            this.lowerRangeValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insturmentsBindingSource1, "LowerRangeValue", true));
            this.lowerRangeValueTextBox.Location = new System.Drawing.Point(126, 102);
            this.lowerRangeValueTextBox.Name = "lowerRangeValueTextBox";
            this.lowerRangeValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowerRangeValueTextBox.TabIndex = 6;
            // 
            // upperRangeValueLabel
            // 
            upperRangeValueLabel.AutoSize = true;
            upperRangeValueLabel.Location = new System.Drawing.Point(3, 132);
            upperRangeValueLabel.Name = "upperRangeValueLabel";
            upperRangeValueLabel.Size = new System.Drawing.Size(104, 13);
            upperRangeValueLabel.TabIndex = 7;
            upperRangeValueLabel.Text = "Upper Range Value:";
            // 
            // upperRangeValueTextBox
            // 
            this.upperRangeValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insturmentsBindingSource1, "UpperRangeValue", true));
            this.upperRangeValueTextBox.Location = new System.Drawing.Point(126, 128);
            this.upperRangeValueTextBox.Name = "upperRangeValueTextBox";
            this.upperRangeValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.upperRangeValueTextBox.TabIndex = 8;
            // 
            // alarmLowLabel
            // 
            alarmLowLabel.AutoSize = true;
            alarmLowLabel.Location = new System.Drawing.Point(3, 154);
            alarmLowLabel.Name = "alarmLowLabel";
            alarmLowLabel.Size = new System.Drawing.Size(59, 13);
            alarmLowLabel.TabIndex = 9;
            alarmLowLabel.Text = "Alarm Low:";
            // 
            // alarmLowTextBox
            // 
            this.alarmLowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insturmentsBindingSource1, "AlarmLow", true));
            this.alarmLowTextBox.Location = new System.Drawing.Point(126, 154);
            this.alarmLowTextBox.Name = "alarmLowTextBox";
            this.alarmLowTextBox.Size = new System.Drawing.Size(100, 20);
            this.alarmLowTextBox.TabIndex = 10;
            // 
            // alarmHighLabel
            // 
            alarmHighLabel.AutoSize = true;
            alarmHighLabel.Location = new System.Drawing.Point(3, 182);
            alarmHighLabel.Name = "alarmHighLabel";
            alarmHighLabel.Size = new System.Drawing.Size(61, 13);
            alarmHighLabel.TabIndex = 11;
            alarmHighLabel.Text = "Alarm High:";
            // 
            // alarmHighTextBox
            // 
            this.alarmHighTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insturmentsBindingSource1, "AlarmHigh", true));
            this.alarmHighTextBox.Location = new System.Drawing.Point(126, 179);
            this.alarmHighTextBox.Name = "alarmHighTextBox";
            this.alarmHighTextBox.Size = new System.Drawing.Size(100, 20);
            this.alarmHighTextBox.TabIndex = 12;
            // 
            // dAUIDLabel
            // 
            dAUIDLabel.AutoSize = true;
            dAUIDLabel.Location = new System.Drawing.Point(263, 49);
            dAUIDLabel.Name = "dAUIDLabel";
            dAUIDLabel.Size = new System.Drawing.Size(44, 13);
            dAUIDLabel.TabIndex = 13;
            dAUIDLabel.Text = "DAUID:";
            // 
            // dAUIDTextBox
            // 
            this.dAUIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insturmentsBindingSource1, "DAUID", true));
            this.dAUIDTextBox.Location = new System.Drawing.Point(356, 50);
            this.dAUIDTextBox.Name = "dAUIDTextBox";
            this.dAUIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dAUIDTextBox.TabIndex = 14;
            // 
            // channelLabel
            // 
            channelLabel.AutoSize = true;
            channelLabel.Location = new System.Drawing.Point(263, 81);
            channelLabel.Name = "channelLabel";
            channelLabel.Size = new System.Drawing.Size(49, 13);
            channelLabel.TabIndex = 15;
            channelLabel.Text = "Channel:";
            // 
            // channelTextBox
            // 
            this.channelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.insturmentsBindingSource1, "Channel", true));
            this.channelTextBox.Location = new System.Drawing.Point(356, 74);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(100, 20);
            this.channelTextBox.TabIndex = 16;
            // 
            // manufacturerIDLabel
            // 
            manufacturerIDLabel.AutoSize = true;
            manufacturerIDLabel.Location = new System.Drawing.Point(263, 102);
            manufacturerIDLabel.Name = "manufacturerIDLabel";
            manufacturerIDLabel.Size = new System.Drawing.Size(87, 13);
            manufacturerIDLabel.TabIndex = 17;
            manufacturerIDLabel.Text = "Manufacturer ID:";
            // 
            // observationLabel
            // 
            observationLabel.AutoSize = true;
            observationLabel.Location = new System.Drawing.Point(263, 128);
            observationLabel.Name = "observationLabel";
            observationLabel.Size = new System.Drawing.Size(67, 13);
            observationLabel.TabIndex = 19;
            observationLabel.Text = "Observation:";
            // 
            // lOCATIONBindingSource
            // 
            this.lOCATIONBindingSource.DataMember = "LOCATION";
            this.lOCATIONBindingSource.DataSource = this.softSensDBDataSet;
            // 
            // lOCATIONTableAdapter
            // 
            this.lOCATIONTableAdapter.ClearBeforeFill = true;
            // 
            // manufaturersBindingSource1
            // 
            this.manufaturersBindingSource1.DataMember = "Manufaturers";
            this.manufaturersBindingSource1.DataSource = this.softSensDBDataSet;
            // 
            // dataAcqusitionUnitsBindingSource
            // 
            this.dataAcqusitionUnitsBindingSource.DataMember = "FK_DataAcqusitionUnits_Manufaturers";
            this.dataAcqusitionUnitsBindingSource.DataSource = this.manufaturersBindingSource1;
            // 
            // dataAcqusitionUnitsTableAdapter
            // 
            this.dataAcqusitionUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // dAUIDLabel1
            // 
            dAUIDLabel1.AutoSize = true;
            dAUIDLabel1.Location = new System.Drawing.Point(13, 25);
            dAUIDLabel1.Name = "dAUIDLabel1";
            dAUIDLabel1.Size = new System.Drawing.Size(69, 13);
            dAUIDLabel1.TabIndex = 1;
            dAUIDLabel1.Text = "FIND Device";
            // 
            // deviceNameLabel
            // 
            deviceNameLabel.AutoSize = true;
            deviceNameLabel.Location = new System.Drawing.Point(13, 130);
            deviceNameLabel.Name = "deviceNameLabel";
            deviceNameLabel.Size = new System.Drawing.Size(75, 13);
            deviceNameLabel.TabIndex = 3;
            deviceNameLabel.Text = "Device Name:";
            // 
            // deviceNameTextBox
            // 
            this.deviceNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource, "DeviceName", true));
            this.deviceNameTextBox.Location = new System.Drawing.Point(106, 130);
            this.deviceNameTextBox.Name = "deviceNameTextBox";
            this.deviceNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.deviceNameTextBox.TabIndex = 4;
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Location = new System.Drawing.Point(313, 28);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new System.Drawing.Size(61, 13);
            baudRateLabel.TabIndex = 5;
            baudRateLabel.Text = "Baud Rate:";
            // 
            // baudRateTextBox
            // 
            this.baudRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource, "BaudRate", true));
            this.baudRateTextBox.Location = new System.Drawing.Point(406, 25);
            this.baudRateTextBox.Name = "baudRateTextBox";
            this.baudRateTextBox.Size = new System.Drawing.Size(121, 20);
            this.baudRateTextBox.TabIndex = 6;
            // 
            // cOMPortLabel
            // 
            cOMPortLabel.AutoSize = true;
            cOMPortLabel.Location = new System.Drawing.Point(313, 81);
            cOMPortLabel.Name = "cOMPortLabel";
            cOMPortLabel.Size = new System.Drawing.Size(53, 13);
            cOMPortLabel.TabIndex = 7;
            cOMPortLabel.Text = "COMPort:";
            // 
            // cOMPortTextBox
            // 
            this.cOMPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource, "COMPort", true));
            this.cOMPortTextBox.Location = new System.Drawing.Point(406, 81);
            this.cOMPortTextBox.Name = "cOMPortTextBox";
            this.cOMPortTextBox.Size = new System.Drawing.Size(121, 20);
            this.cOMPortTextBox.TabIndex = 8;
            // 
            // installationDataLabel
            // 
            installationDataLabel.AutoSize = true;
            installationDataLabel.Location = new System.Drawing.Point(13, 163);
            installationDataLabel.Name = "installationDataLabel";
            installationDataLabel.Size = new System.Drawing.Size(86, 13);
            installationDataLabel.TabIndex = 9;
            installationDataLabel.Text = "Installation Data:";
            // 
            // installationDataDateTimePicker
            // 
            this.installationDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataAcqusitionUnitsBindingSource, "InstallationData", true));
            this.installationDataDateTimePicker.Location = new System.Drawing.Point(106, 156);
            this.installationDataDateTimePicker.Name = "installationDataDateTimePicker";
            this.installationDataDateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.installationDataDateTimePicker.TabIndex = 10;
            // 
            // configUpdateLabel
            // 
            configUpdateLabel.AutoSize = true;
            configUpdateLabel.Location = new System.Drawing.Point(13, 194);
            configUpdateLabel.Name = "configUpdateLabel";
            configUpdateLabel.Size = new System.Drawing.Size(78, 13);
            configUpdateLabel.TabIndex = 11;
            configUpdateLabel.Text = "Config Update:";
            // 
            // configUpdateDateTimePicker
            // 
            this.configUpdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataAcqusitionUnitsBindingSource, "ConfigUpdate", true));
            this.configUpdateDateTimePicker.Location = new System.Drawing.Point(106, 188);
            this.configUpdateDateTimePicker.Name = "configUpdateDateTimePicker";
            this.configUpdateDateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.configUpdateDateTimePicker.TabIndex = 12;
            // 
            // rDCIDLabel
            // 
            rDCIDLabel.AutoSize = true;
            rDCIDLabel.Location = new System.Drawing.Point(313, 138);
            rDCIDLabel.Name = "rDCIDLabel";
            rDCIDLabel.Size = new System.Drawing.Size(44, 13);
            rDCIDLabel.TabIndex = 13;
            rDCIDLabel.Text = "RDCID:";
            // 
            // manufacturerIDLabel2
            // 
            manufacturerIDLabel2.AutoSize = true;
            manufacturerIDLabel2.Location = new System.Drawing.Point(313, 179);
            manufacturerIDLabel2.Name = "manufacturerIDLabel2";
            manufacturerIDLabel2.Size = new System.Drawing.Size(87, 13);
            manufacturerIDLabel2.TabIndex = 15;
            manufacturerIDLabel2.Text = "Manufacturer ID:";
            // 
            // manufacturerIDTextBox2
            // 
            this.manufacturerIDTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataAcqusitionUnitsBindingSource, "ManufacturerID", true));
            this.manufacturerIDTextBox2.Location = new System.Drawing.Point(406, 172);
            this.manufacturerIDTextBox2.Name = "manufacturerIDTextBox2";
            this.manufacturerIDTextBox2.Size = new System.Drawing.Size(121, 20);
            this.manufacturerIDTextBox2.TabIndex = 16;
            // 
            // manufacturerIDLabel3
            // 
            manufacturerIDLabel3.AutoSize = true;
            manufacturerIDLabel3.Location = new System.Drawing.Point(13, 220);
            manufacturerIDLabel3.Name = "manufacturerIDLabel3";
            manufacturerIDLabel3.Size = new System.Drawing.Size(87, 13);
            manufacturerIDLabel3.TabIndex = 17;
            manufacturerIDLabel3.Text = "Manufacturer ID:";
            // 
            // locationIDLabel1
            // 
            locationIDLabel1.AutoSize = true;
            locationIDLabel1.Location = new System.Drawing.Point(13, 243);
            locationIDLabel1.Name = "locationIDLabel1";
            locationIDLabel1.Size = new System.Drawing.Size(65, 13);
            locationIDLabel1.TabIndex = 19;
            locationIDLabel1.Text = "Location ID:";
            // 
            // instrumentLogBindingSource1
            // 
            this.instrumentLogBindingSource1.DataMember = "InstrumentLog";
            this.instrumentLogBindingSource1.DataSource = this.softSensDBDataSet;
            // 
            // logIDLabel
            // 
            logIDLabel.AutoSize = true;
            logIDLabel.Location = new System.Drawing.Point(3, 25);
            logIDLabel.Name = "logIDLabel";
            logIDLabel.Size = new System.Drawing.Size(42, 13);
            logIDLabel.TabIndex = 1;
            logIDLabel.Text = "Log ID:";
            // 
            // logIDTextBox
            // 
            this.logIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentLogBindingSource1, "LogID", true));
            this.logIDTextBox.Location = new System.Drawing.Point(91, 22);
            this.logIDTextBox.Name = "logIDTextBox";
            this.logIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.logIDTextBox.TabIndex = 2;
            // 
            // tagnameLabel1
            // 
            tagnameLabel1.AutoSize = true;
            tagnameLabel1.Location = new System.Drawing.Point(0, 54);
            tagnameLabel1.Name = "tagnameLabel1";
            tagnameLabel1.Size = new System.Drawing.Size(55, 13);
            tagnameLabel1.TabIndex = 3;
            tagnameLabel1.Text = "Tagname:";
            // 
            // tagnameTextBox1
            // 
            this.tagnameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentLogBindingSource1, "Tagname", true));
            this.tagnameTextBox1.Location = new System.Drawing.Point(91, 51);
            this.tagnameTextBox1.Name = "tagnameTextBox1";
            this.tagnameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.tagnameTextBox1.TabIndex = 4;
            // 
            // logTimestampLabel
            // 
            logTimestampLabel.AutoSize = true;
            logTimestampLabel.Location = new System.Drawing.Point(3, 98);
            logTimestampLabel.Name = "logTimestampLabel";
            logTimestampLabel.Size = new System.Drawing.Size(82, 13);
            logTimestampLabel.TabIndex = 5;
            logTimestampLabel.Text = "Log Timestamp:";
            // 
            // logTimestampDateTimePicker
            // 
            this.logTimestampDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.instrumentLogBindingSource1, "LogTimestamp", true));
            this.logTimestampDateTimePicker.Location = new System.Drawing.Point(91, 91);
            this.logTimestampDateTimePicker.Name = "logTimestampDateTimePicker";
            this.logTimestampDateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.logTimestampDateTimePicker.TabIndex = 6;
            // 
            // logValueLabel
            // 
            logValueLabel.AutoSize = true;
            logValueLabel.Location = new System.Drawing.Point(3, 127);
            logValueLabel.Name = "logValueLabel";
            logValueLabel.Size = new System.Drawing.Size(58, 13);
            logValueLabel.TabIndex = 7;
            logValueLabel.Text = "Log Value:";
            // 
            // logValueTextBox
            // 
            this.logValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentLogBindingSource1, "LogValue", true));
            this.logValueTextBox.Location = new System.Drawing.Point(91, 124);
            this.logValueTextBox.Name = "logValueTextBox";
            this.logValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.logValueTextBox.TabIndex = 8;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(106, 62);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(78, 21);
            this.buttonChange.TabIndex = 21;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // button2New
            // 
            this.button2New.Location = new System.Drawing.Point(190, 63);
            this.button2New.Name = "button2New";
            this.button2New.Size = new System.Drawing.Size(78, 21);
            this.button2New.TabIndex = 22;
            this.button2New.Text = "New";
            this.button2New.UseVisualStyleBackColor = true;
            // 
            // button3Connect
            // 
            this.button3Connect.Location = new System.Drawing.Point(406, 107);
            this.button3Connect.Name = "button3Connect";
            this.button3Connect.Size = new System.Drawing.Size(78, 21);
            this.button3Connect.TabIndex = 23;
            this.button3Connect.Text = "Conncet";
            this.button3Connect.UseVisualStyleBackColor = true;
            // 
            // button4Disconnect
            // 
            this.button4Disconnect.Location = new System.Drawing.Point(490, 107);
            this.button4Disconnect.Name = "button4Disconnect";
            this.button4Disconnect.Size = new System.Drawing.Size(78, 21);
            this.button4Disconnect.TabIndex = 24;
            this.button4Disconnect.Text = "Disconnect";
            this.button4Disconnect.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(406, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 26;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(106, 216);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 27;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(106, 245);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 28;
            // 
            // button5Cancel
            // 
            this.button5Cancel.Location = new System.Drawing.Point(106, 95);
            this.button5Cancel.Name = "button5Cancel";
            this.button5Cancel.Size = new System.Drawing.Size(78, 21);
            this.button5Cancel.TabIndex = 29;
            this.button5Cancel.Text = "Cancel";
            this.button5Cancel.UseVisualStyleBackColor = true;
            // 
            // button6Save
            // 
            this.button6Save.Location = new System.Drawing.Point(190, 95);
            this.button6Save.Name = "button6Save";
            this.button6Save.Size = new System.Drawing.Size(78, 21);
            this.button6Save.TabIndex = 30;
            this.button6Save.Text = "Save";
            this.button6Save.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(356, 100);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 21;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(356, 132);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 22;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(406, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3X
            // 
            this.textBox3X.Location = new System.Drawing.Point(34, 42);
            this.textBox3X.Name = "textBox3X";
            this.textBox3X.Size = new System.Drawing.Size(100, 20);
            this.textBox3X.TabIndex = 0;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(34, 68);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 1;
            // 
            // textBox5Result
            // 
            this.textBox5Result.Location = new System.Drawing.Point(140, 39);
            this.textBox5Result.Multiline = true;
            this.textBox5Result.Name = "textBox5Result";
            this.textBox5Result.Size = new System.Drawing.Size(206, 104);
            this.textBox5Result.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // listBoxVa
            // 
            this.listBoxVa.FormattingEnabled = true;
            this.listBoxVa.Location = new System.Drawing.Point(40, 238);
            this.listBoxVa.Name = "listBoxVa";
            this.listBoxVa.Size = new System.Drawing.Size(81, 160);
            this.listBoxVa.TabIndex = 5;
            // 
            // listBox2Vb
            // 
            this.listBox2Vb.FormattingEnabled = true;
            this.listBox2Vb.Location = new System.Drawing.Point(153, 238);
            this.listBox2Vb.Name = "listBox2Vb";
            this.listBox2Vb.Size = new System.Drawing.Size(81, 160);
            this.listBox2Vb.TabIndex = 6;
            // 
            // listBox3Vab
            // 
            this.listBox3Vab.FormattingEnabled = true;
            this.listBox3Vab.Location = new System.Drawing.Point(261, 238);
            this.listBox3Vab.Name = "listBox3Vab";
            this.listBox3Vab.Size = new System.Drawing.Size(81, 160);
            this.listBox3Vab.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Va";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vb";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vab";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Read File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Start Auto";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea21.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea21);
            legend21.Name = "Legend1";
            this.chart1.Legends.Add(legend21);
            this.chart1.Location = new System.Drawing.Point(383, 39);
            this.chart1.Name = "chart1";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.chart1.Series.Add(series21);
            this.chart1.Size = new System.Drawing.Size(358, 172);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.insturmentsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(904, 25);
            this.bindingNavigator1.TabIndex = 23;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerIDDataGridViewTextBoxColumn1,
            this.companyNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.manufaturersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // manufacturerIDDataGridViewTextBoxColumn1
            // 
            this.manufacturerIDDataGridViewTextBoxColumn1.DataPropertyName = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn1.HeaderText = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn1.Name = "manufacturerIDDataGridViewTextBoxColumn1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rDCIDDataGridViewTextBoxColumn,
            this.rDCDNameDataGridViewTextBoxColumn,
            this.rDCDescriptionDataGridViewTextBoxColumn,
            this.iPadressDataGridViewTextBoxColumn,
            this.manufacturerIDDataGridViewTextBoxColumn2,
            this.locationIDDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.remoteDataCollectorsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(252, 277);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(556, 150);
            this.dataGridView3.TabIndex = 1;
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "LocationID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "LocationID";
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            // 
            // manufacturerIDDataGridViewTextBoxColumn2
            // 
            this.manufacturerIDDataGridViewTextBoxColumn2.DataPropertyName = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn2.HeaderText = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn2.Name = "manufacturerIDDataGridViewTextBoxColumn2";
            // 
            // iPadressDataGridViewTextBoxColumn
            // 
            this.iPadressDataGridViewTextBoxColumn.DataPropertyName = "IPadress";
            this.iPadressDataGridViewTextBoxColumn.HeaderText = "IPadress";
            this.iPadressDataGridViewTextBoxColumn.Name = "iPadressDataGridViewTextBoxColumn";
            // 
            // rDCDescriptionDataGridViewTextBoxColumn
            // 
            this.rDCDescriptionDataGridViewTextBoxColumn.DataPropertyName = "RDCDescription";
            this.rDCDescriptionDataGridViewTextBoxColumn.HeaderText = "RDCDescription";
            this.rDCDescriptionDataGridViewTextBoxColumn.Name = "rDCDescriptionDataGridViewTextBoxColumn";
            // 
            // rDCDNameDataGridViewTextBoxColumn
            // 
            this.rDCDNameDataGridViewTextBoxColumn.DataPropertyName = "RDCDName";
            this.rDCDNameDataGridViewTextBoxColumn.HeaderText = "RDCDName";
            this.rDCDNameDataGridViewTextBoxColumn.Name = "rDCDNameDataGridViewTextBoxColumn";
            // 
            // rDCIDDataGridViewTextBoxColumn
            // 
            this.rDCIDDataGridViewTextBoxColumn.DataPropertyName = "RDCID";
            this.rDCIDDataGridViewTextBoxColumn.HeaderText = "RDCID";
            this.rDCIDDataGridViewTextBoxColumn.Name = "rDCIDDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(18, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 229);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox8);
            this.groupBox1.Controls.Add(this.comboBox7);
            this.groupBox1.Controls.Add(locationNameLabel);
            this.groupBox1.Controls.Add(locationIDLabel);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOCATION";
            // 
            // locationIDLabel
            // 
            locationIDLabel.AutoSize = true;
            locationIDLabel.Location = new System.Drawing.Point(6, 16);
            locationIDLabel.Name = "locationIDLabel";
            locationIDLabel.Size = new System.Drawing.Size(65, 13);
            locationIDLabel.TabIndex = 0;
            locationIDLabel.Text = "Location ID:";
            // 
            // locationNameLabel
            // 
            locationNameLabel.AutoSize = true;
            locationNameLabel.Location = new System.Drawing.Point(6, 35);
            locationNameLabel.Name = "locationNameLabel";
            locationNameLabel.Size = new System.Drawing.Size(82, 13);
            locationNameLabel.TabIndex = 2;
            locationNameLabel.Text = "Location Name:";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(94, 8);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 4;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(94, 42);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(324, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 243);
            this.panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox10);
            this.groupBox2.Controls.Add(this.comboBox9);
            this.groupBox2.Controls.Add(companyNameLabel);
            this.groupBox2.Controls.Add(manufacturerIDLabel1);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manufaturers";
            // 
            // manufacturerIDLabel1
            // 
            manufacturerIDLabel1.AutoSize = true;
            manufacturerIDLabel1.Location = new System.Drawing.Point(6, 16);
            manufacturerIDLabel1.Name = "manufacturerIDLabel1";
            manufacturerIDLabel1.Size = new System.Drawing.Size(87, 13);
            manufacturerIDLabel1.TabIndex = 0;
            manufacturerIDLabel1.Text = "Manufacturer ID:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(8, 42);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(85, 13);
            companyNameLabel.TabIndex = 2;
            companyNameLabel.Text = "Company Name:";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(99, 8);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 22;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(99, 39);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 21);
            this.comboBox10.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(661, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 105);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(661, 158);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 98);
            this.textBox2.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.bindingNavigator4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(782, 422);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Admin";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.bindingNavigator4.BindingSource = this.manufaturersBindingSource;
            this.bindingNavigator4.CountItem = this.bindingNavigatorCountItem3;
            this.bindingNavigator4.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.bindingNavigator4.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator4.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bindingNavigator4.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bindingNavigator4.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bindingNavigator4.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.bindingNavigatorPositionItem3;
            this.bindingNavigator4.Size = new System.Drawing.Size(808, 25);
            this.bindingNavigator4.TabIndex = 9;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Move previous";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Position";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem3.Text = "of {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Move last";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Delete";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.dataAcqusitionUnitsBindingSource1;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(904, 25);
            this.bindingNavigator2.TabIndex = 32;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dAUIDDataGridViewTextBoxColumn1,
            this.deviceNameDataGridViewTextBoxColumn,
            this.baudRateDataGridViewTextBoxColumn,
            this.cOMPortDataGridViewTextBoxColumn,
            this.installationDataDataGridViewTextBoxColumn,
            this.configUpdateDataGridViewTextBoxColumn,
            this.rDCIDDataGridViewTextBoxColumn1,
            this.manufacturerIDDataGridViewTextBoxColumn3,
            this.locationIDDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.dataAcqusitionUnitsBindingSource1;
            this.dataGridView4.Location = new System.Drawing.Point(0, 264);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(900, 150);
            this.dataGridView4.TabIndex = 33;
            // 
            // dAUIDDataGridViewTextBoxColumn1
            // 
            this.dAUIDDataGridViewTextBoxColumn1.DataPropertyName = "DAUID";
            this.dAUIDDataGridViewTextBoxColumn1.HeaderText = "DAUID";
            this.dAUIDDataGridViewTextBoxColumn1.Name = "dAUIDDataGridViewTextBoxColumn1";
            // 
            // deviceNameDataGridViewTextBoxColumn
            // 
            this.deviceNameDataGridViewTextBoxColumn.DataPropertyName = "DeviceName";
            this.deviceNameDataGridViewTextBoxColumn.HeaderText = "DeviceName";
            this.deviceNameDataGridViewTextBoxColumn.Name = "deviceNameDataGridViewTextBoxColumn";
            // 
            // baudRateDataGridViewTextBoxColumn
            // 
            this.baudRateDataGridViewTextBoxColumn.DataPropertyName = "BaudRate";
            this.baudRateDataGridViewTextBoxColumn.HeaderText = "BaudRate";
            this.baudRateDataGridViewTextBoxColumn.Name = "baudRateDataGridViewTextBoxColumn";
            // 
            // cOMPortDataGridViewTextBoxColumn
            // 
            this.cOMPortDataGridViewTextBoxColumn.DataPropertyName = "COMPort";
            this.cOMPortDataGridViewTextBoxColumn.HeaderText = "COMPort";
            this.cOMPortDataGridViewTextBoxColumn.Name = "cOMPortDataGridViewTextBoxColumn";
            // 
            // installationDataDataGridViewTextBoxColumn
            // 
            this.installationDataDataGridViewTextBoxColumn.DataPropertyName = "InstallationData";
            this.installationDataDataGridViewTextBoxColumn.HeaderText = "InstallationData";
            this.installationDataDataGridViewTextBoxColumn.Name = "installationDataDataGridViewTextBoxColumn";
            // 
            // configUpdateDataGridViewTextBoxColumn
            // 
            this.configUpdateDataGridViewTextBoxColumn.DataPropertyName = "ConfigUpdate";
            this.configUpdateDataGridViewTextBoxColumn.HeaderText = "ConfigUpdate";
            this.configUpdateDataGridViewTextBoxColumn.Name = "configUpdateDataGridViewTextBoxColumn";
            // 
            // rDCIDDataGridViewTextBoxColumn1
            // 
            this.rDCIDDataGridViewTextBoxColumn1.DataPropertyName = "RDCID";
            this.rDCIDDataGridViewTextBoxColumn1.HeaderText = "RDCID";
            this.rDCIDDataGridViewTextBoxColumn1.Name = "rDCIDDataGridViewTextBoxColumn1";
            // 
            // manufacturerIDDataGridViewTextBoxColumn3
            // 
            this.manufacturerIDDataGridViewTextBoxColumn3.DataPropertyName = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn3.HeaderText = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn3.Name = "manufacturerIDDataGridViewTextBoxColumn3";
            // 
            // locationIDDataGridViewTextBoxColumn1
            // 
            this.locationIDDataGridViewTextBoxColumn1.DataPropertyName = "LocationID";
            this.locationIDDataGridViewTextBoxColumn1.HeaderText = "LocationID";
            this.locationIDDataGridViewTextBoxColumn1.Name = "locationIDDataGridViewTextBoxColumn1";
            // 
            // softSensDBDataSet1
            // 
            this.softSensDBDataSet1.DataSetName = "SoftSensDBDataSet1";
            this.softSensDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataAcqusitionUnitsBindingSource1
            // 
            this.dataAcqusitionUnitsBindingSource1.DataMember = "DataAcqusitionUnits";
            this.dataAcqusitionUnitsBindingSource1.DataSource = this.softSensDBDataSet1;
            // 
            // dataAcqusitionUnitsTableAdapter1
            // 
            this.dataAcqusitionUnitsTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.BindingSource = this.instrumentLogBindingSource;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(782, 25);
            this.bindingNavigator3.TabIndex = 9;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            // 
            // Tagname
            // 
            this.Tagname.DataPropertyName = "Tagname";
            this.Tagname.HeaderText = "Tagname";
            this.Tagname.Name = "Tagname";
            // 
            // tagDescriptionDataGridViewTextBoxColumn
            // 
            this.tagDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TagDescription";
            this.tagDescriptionDataGridViewTextBoxColumn.HeaderText = "TagDescription";
            this.tagDescriptionDataGridViewTextBoxColumn.Name = "tagDescriptionDataGridViewTextBoxColumn";
            // 
            // lowerRangeValueDataGridViewTextBoxColumn
            // 
            this.lowerRangeValueDataGridViewTextBoxColumn.DataPropertyName = "LowerRangeValue";
            this.lowerRangeValueDataGridViewTextBoxColumn.HeaderText = "LRV";
            this.lowerRangeValueDataGridViewTextBoxColumn.Name = "lowerRangeValueDataGridViewTextBoxColumn";
            // 
            // upperRangeValueDataGridViewTextBoxColumn
            // 
            this.upperRangeValueDataGridViewTextBoxColumn.DataPropertyName = "UpperRangeValue";
            this.upperRangeValueDataGridViewTextBoxColumn.HeaderText = "URV";
            this.upperRangeValueDataGridViewTextBoxColumn.Name = "upperRangeValueDataGridViewTextBoxColumn";
            // 
            // alarmLowDataGridViewTextBoxColumn
            // 
            this.alarmLowDataGridViewTextBoxColumn.DataPropertyName = "AlarmLow";
            this.alarmLowDataGridViewTextBoxColumn.HeaderText = "AL";
            this.alarmLowDataGridViewTextBoxColumn.Name = "alarmLowDataGridViewTextBoxColumn";
            // 
            // alarmHighDataGridViewTextBoxColumn
            // 
            this.alarmHighDataGridViewTextBoxColumn.DataPropertyName = "AlarmHigh";
            this.alarmHighDataGridViewTextBoxColumn.HeaderText = "AH";
            this.alarmHighDataGridViewTextBoxColumn.Name = "alarmHighDataGridViewTextBoxColumn";
            // 
            // dAUIDDataGridViewTextBoxColumn
            // 
            this.dAUIDDataGridViewTextBoxColumn.DataPropertyName = "DAUID";
            this.dAUIDDataGridViewTextBoxColumn.DataSource = this.dataAcqusitionUnitsBindingSource1;
            this.dAUIDDataGridViewTextBoxColumn.DisplayMember = "DAUID";
            this.dAUIDDataGridViewTextBoxColumn.HeaderText = "DAUID";
            this.dAUIDDataGridViewTextBoxColumn.Name = "dAUIDDataGridViewTextBoxColumn";
            this.dAUIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dAUIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // channelDataGridViewTextBoxColumn
            // 
            this.channelDataGridViewTextBoxColumn.DataPropertyName = "Channel";
            this.channelDataGridViewTextBoxColumn.HeaderText = "Channel";
            this.channelDataGridViewTextBoxColumn.Name = "channelDataGridViewTextBoxColumn";
            // 
            // manufacturerIDDataGridViewTextBoxColumn
            // 
            this.manufacturerIDDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.DataSource = this.manufaturersBindingSource;
            this.manufacturerIDDataGridViewTextBoxColumn.DisplayMember = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.HeaderText = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.Name = "manufacturerIDDataGridViewTextBoxColumn";
            this.manufacturerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.manufacturerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // observationDataGridViewTextBoxColumn
            // 
            this.observationDataGridViewTextBoxColumn.DataPropertyName = "Observation";
            this.observationDataGridViewTextBoxColumn.HeaderText = "Observation";
            this.observationDataGridViewTextBoxColumn.Name = "observationDataGridViewTextBoxColumn";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "SoftSensDatabasekobling";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insturmentsBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufaturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataCollectorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insturmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufaturersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentLogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softSensDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAcqusitionUnitsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private SoftSensDBDataSet softSensDBDataSet;
        private System.Windows.Forms.BindingSource insturmentsBindingSource;
        private SoftSensDBDataSetTableAdapters.InsturmentsTableAdapter insturmentsTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingSource manufaturersBindingSource;
        private SoftSensDBDataSetTableAdapters.ManufaturersTableAdapter manufaturersTableAdapter;
        private System.Windows.Forms.BindingSource remoteDataCollectorsBindingSource;
        private SoftSensDBDataSetTableAdapters.RemoteDataCollectorsTableAdapter remoteDataCollectorsTableAdapter;
        private System.Windows.Forms.BindingSource remoteDataCollectorsBindingSource1;
        private System.Windows.Forms.BindingSource instrumentLogBindingSource;
        private SoftSensDBDataSetTableAdapters.InstrumentLogTableAdapter instrumentLogTableAdapter;
        private System.Windows.Forms.BindingSource insturmentsBindingSource1;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.TextBox dAUIDTextBox;
        private System.Windows.Forms.TextBox alarmHighTextBox;
        private System.Windows.Forms.TextBox alarmLowTextBox;
        private System.Windows.Forms.TextBox upperRangeValueTextBox;
        private System.Windows.Forms.TextBox lowerRangeValueTextBox;
        private System.Windows.Forms.TextBox tagDescriptionTextBox;
        private System.Windows.Forms.TextBox tagnameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logValueDataGridViewTextBoxColumn;
        private SoftSensDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SoftSensDBDataSetTableAdapters.LOCATIONTableAdapter lOCATIONTableAdapter;
        private System.Windows.Forms.BindingSource lOCATIONBindingSource;
        private System.Windows.Forms.BindingSource manufaturersBindingSource1;
        private SoftSensDBDataSetTableAdapters.DataAcqusitionUnitsTableAdapter dataAcqusitionUnitsTableAdapter;
        private System.Windows.Forms.BindingSource dataAcqusitionUnitsBindingSource;
        private System.Windows.Forms.TextBox manufacturerIDTextBox2;
        private System.Windows.Forms.DateTimePicker configUpdateDateTimePicker;
        private System.Windows.Forms.DateTimePicker installationDataDateTimePicker;
        private System.Windows.Forms.TextBox cOMPortTextBox;
        private System.Windows.Forms.TextBox baudRateTextBox;
        private System.Windows.Forms.TextBox deviceNameTextBox;
        private System.Windows.Forms.TextBox logValueTextBox;
        private System.Windows.Forms.BindingSource instrumentLogBindingSource1;
        private System.Windows.Forms.DateTimePicker logTimestampDateTimePicker;
        private System.Windows.Forms.TextBox tagnameTextBox1;
        private System.Windows.Forms.TextBox logIDTextBox;
        private System.Windows.Forms.Button button4Disconnect;
        private System.Windows.Forms.Button button3Connect;
        private System.Windows.Forms.Button button2New;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button button6Save;
        private System.Windows.Forms.Button button5Cancel;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox3Vab;
        private System.Windows.Forms.ListBox listBox2Vb;
        private System.Windows.Forms.ListBox listBoxVa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5Result;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBox3X;
        private System.Windows.Forms.Timer timerSerialReceiver;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDCDNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDCDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baudRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDCIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn1;
        private SoftSensDBDataSet1 softSensDBDataSet1;
        private System.Windows.Forms.BindingSource dataAcqusitionUnitsBindingSource1;
        private SoftSensDBDataSet1TableAdapters.DataAcqusitionUnitsTableAdapter dataAcqusitionUnitsTableAdapter1;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tagname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowerRangeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upperRangeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dAUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn manufacturerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationDataGridViewTextBoxColumn;
    }
}

