namespace Head_Orientation_Recognition
{
    partial class MainForm
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
            this.LoadMainDataSetButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TimesOfPCA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PCA_LearningRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PCA_TrainButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NeuronsInHLayers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadDataSetButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MPOverallAccuracyBox = new System.Windows.Forms.TextBox();
            this.BackpropagationTrainButton = new System.Windows.Forms.Button();
            this.BackpropagationTestButton = new System.Windows.Forms.Button();
            this.MPConfusionMatrix = new System.Windows.Forms.DataGridView();
            this.MLNumOfLayersUpDown = new System.Windows.Forms.NumericUpDown();
            this.MPLearningRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.MLNumOfEpocksUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RB_MaxErrorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.LoadMainDataSetButton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RBOverallAccuracyBox = new System.Windows.Forms.TextBox();
            this.RBTrainButton = new System.Windows.Forms.Button();
            this.RBTestButton = new System.Windows.Forms.Button();
            this.RBConfusionMatrix = new System.Windows.Forms.DataGridView();
            this.RBNumOfKUpDown = new System.Windows.Forms.NumericUpDown();
            this.RBLearningRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.RBNumOfEpocksUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TimesOfMLP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TimesOfRBF = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCA_LearningRateUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronsInHLayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MPConfusionMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MLNumOfLayersUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MPLearningRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MLNumOfEpocksUpDown)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RB_MaxErrorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBConfusionMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBNumOfKUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBLearningRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBNumOfEpocksUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadMainDataSetButton
            // 
            this.LoadMainDataSetButton.Location = new System.Drawing.Point(8, 13);
            this.LoadMainDataSetButton.Name = "LoadMainDataSetButton";
            this.LoadMainDataSetButton.Size = new System.Drawing.Size(195, 23);
            this.LoadMainDataSetButton.TabIndex = 0;
            this.LoadMainDataSetButton.Text = "Load DataSet";
            this.LoadMainDataSetButton.UseVisualStyleBackColor = true;
            this.LoadMainDataSetButton.Click += new System.EventHandler(this.LoadMainDataSetButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 353);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TimesOfPCA);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.PCA_LearningRateUpDown);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PCA_TrainButton);
            this.tabPage1.Controls.Add(this.LoadMainDataSetButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PCA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TimesOfPCA
            // 
            this.TimesOfPCA.Enabled = false;
            this.TimesOfPCA.Location = new System.Drawing.Point(266, 99);
            this.TimesOfPCA.Name = "TimesOfPCA";
            this.TimesOfPCA.ReadOnly = true;
            this.TimesOfPCA.Size = new System.Drawing.Size(100, 20);
            this.TimesOfPCA.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Time";
            // 
            // PCA_LearningRateUpDown
            // 
            this.PCA_LearningRateUpDown.DecimalPlaces = 7;
            this.PCA_LearningRateUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            this.PCA_LearningRateUpDown.Location = new System.Drawing.Point(311, 50);
            this.PCA_LearningRateUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PCA_LearningRateUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            this.PCA_LearningRateUpDown.Name = "PCA_LearningRateUpDown";
            this.PCA_LearningRateUpDown.Size = new System.Drawing.Size(84, 20);
            this.PCA_LearningRateUpDown.TabIndex = 58;
            this.PCA_LearningRateUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            458752});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Learning Rate";
            // 
            // PCA_TrainButton
            // 
            this.PCA_TrainButton.Enabled = false;
            this.PCA_TrainButton.Location = new System.Drawing.Point(234, 13);
            this.PCA_TrainButton.Name = "PCA_TrainButton";
            this.PCA_TrainButton.Size = new System.Drawing.Size(195, 23);
            this.PCA_TrainButton.TabIndex = 50;
            this.PCA_TrainButton.Text = "Train";
            this.PCA_TrainButton.UseVisualStyleBackColor = true;
            this.PCA_TrainButton.Click += new System.EventHandler(this.PCA_TrainButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TimesOfMLP);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.NeuronsInHLayers);
            this.tabPage2.Controls.Add(this.LoadDataSetButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.MPOverallAccuracyBox);
            this.tabPage2.Controls.Add(this.BackpropagationTrainButton);
            this.tabPage2.Controls.Add(this.BackpropagationTestButton);
            this.tabPage2.Controls.Add(this.MPConfusionMatrix);
            this.tabPage2.Controls.Add(this.MLNumOfLayersUpDown);
            this.tabPage2.Controls.Add(this.MPLearningRateUpDown);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.MLNumOfEpocksUpDown);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multilayer Perceptron";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NeuronsInHLayers
            // 
            this.NeuronsInHLayers.AllowUserToAddRows = false;
            this.NeuronsInHLayers.AllowUserToDeleteRows = false;
            this.NeuronsInHLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NeuronsInHLayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.NeuronsInHLayers.Location = new System.Drawing.Point(450, 100);
            this.NeuronsInHLayers.Name = "NeuronsInHLayers";
            this.NeuronsInHLayers.Size = new System.Drawing.Size(172, 207);
            this.NeuronsInHLayers.TabIndex = 61;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hiden Layer";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "#Neurons";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // LoadDataSetButton
            // 
            this.LoadDataSetButton.Location = new System.Drawing.Point(25, 19);
            this.LoadDataSetButton.Name = "LoadDataSetButton";
            this.LoadDataSetButton.Size = new System.Drawing.Size(195, 23);
            this.LoadDataSetButton.TabIndex = 60;
            this.LoadDataSetButton.Text = "Load DataSet From PCA";
            this.LoadDataSetButton.UseVisualStyleBackColor = true;
            this.LoadDataSetButton.Click += new System.EventHandler(this.LoadDataSetButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Over All Accuracy";
            // 
            // MPOverallAccuracyBox
            // 
            this.MPOverallAccuracyBox.Location = new System.Drawing.Point(545, 73);
            this.MPOverallAccuracyBox.Name = "MPOverallAccuracyBox";
            this.MPOverallAccuracyBox.ReadOnly = true;
            this.MPOverallAccuracyBox.Size = new System.Drawing.Size(60, 20);
            this.MPOverallAccuracyBox.TabIndex = 59;
            // 
            // BackpropagationTrainButton
            // 
            this.BackpropagationTrainButton.Enabled = false;
            this.BackpropagationTrainButton.Location = new System.Drawing.Point(226, 19);
            this.BackpropagationTrainButton.Name = "BackpropagationTrainButton";
            this.BackpropagationTrainButton.Size = new System.Drawing.Size(195, 23);
            this.BackpropagationTrainButton.TabIndex = 49;
            this.BackpropagationTrainButton.Text = "Train";
            this.BackpropagationTrainButton.UseVisualStyleBackColor = true;
            this.BackpropagationTrainButton.Click += new System.EventHandler(this.BackpropagationTrainButton_Click);
            // 
            // BackpropagationTestButton
            // 
            this.BackpropagationTestButton.Enabled = false;
            this.BackpropagationTestButton.Location = new System.Drawing.Point(427, 19);
            this.BackpropagationTestButton.Name = "BackpropagationTestButton";
            this.BackpropagationTestButton.Size = new System.Drawing.Size(195, 23);
            this.BackpropagationTestButton.TabIndex = 50;
            this.BackpropagationTestButton.Text = "Test";
            this.BackpropagationTestButton.UseVisualStyleBackColor = true;
            this.BackpropagationTestButton.Click += new System.EventHandler(this.BackpropagationTestButton_Click);
            // 
            // MPConfusionMatrix
            // 
            this.MPConfusionMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MPConfusionMatrix.Location = new System.Drawing.Point(25, 100);
            this.MPConfusionMatrix.Name = "MPConfusionMatrix";
            this.MPConfusionMatrix.Size = new System.Drawing.Size(416, 207);
            this.MPConfusionMatrix.TabIndex = 57;
            // 
            // MLNumOfLayersUpDown
            // 
            this.MLNumOfLayersUpDown.Location = new System.Drawing.Point(341, 48);
            this.MLNumOfLayersUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MLNumOfLayersUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MLNumOfLayersUpDown.Name = "MLNumOfLayersUpDown";
            this.MLNumOfLayersUpDown.Size = new System.Drawing.Size(100, 20);
            this.MLNumOfLayersUpDown.TabIndex = 51;
            this.MLNumOfLayersUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MLNumOfLayersUpDown.ValueChanged += new System.EventHandler(this.MLNumOfLayersUpDown_ValueChanged);
            // 
            // MPLearningRateUpDown
            // 
            this.MPLearningRateUpDown.DecimalPlaces = 3;
            this.MPLearningRateUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.MPLearningRateUpDown.Location = new System.Drawing.Point(527, 48);
            this.MPLearningRateUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MPLearningRateUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.MPLearningRateUpDown.Name = "MPLearningRateUpDown";
            this.MPLearningRateUpDown.Size = new System.Drawing.Size(84, 20);
            this.MPLearningRateUpDown.TabIndex = 56;
            this.MPLearningRateUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Number of Layers";
            // 
            // MLNumOfEpocksUpDown
            // 
            this.MLNumOfEpocksUpDown.Location = new System.Drawing.Point(341, 74);
            this.MLNumOfEpocksUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MLNumOfEpocksUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MLNumOfEpocksUpDown.Name = "MLNumOfEpocksUpDown";
            this.MLNumOfEpocksUpDown.Size = new System.Drawing.Size(100, 20);
            this.MLNumOfEpocksUpDown.TabIndex = 55;
            this.MLNumOfEpocksUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Number of Epochs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Learning Rate";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TimesOfRBF);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.RB_MaxErrorNumericUpDown);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.LoadMainDataSetButton2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.RBOverallAccuracyBox);
            this.tabPage3.Controls.Add(this.RBTrainButton);
            this.tabPage3.Controls.Add(this.RBTestButton);
            this.tabPage3.Controls.Add(this.RBConfusionMatrix);
            this.tabPage3.Controls.Add(this.RBNumOfKUpDown);
            this.tabPage3.Controls.Add(this.RBLearningRateUpDown);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.RBNumOfEpocksUpDown);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(647, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Radial-Basis Function";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RB_MaxErrorNumericUpDown
            // 
            this.RB_MaxErrorNumericUpDown.DecimalPlaces = 3;
            this.RB_MaxErrorNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.RB_MaxErrorNumericUpDown.Location = new System.Drawing.Point(527, 73);
            this.RB_MaxErrorNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RB_MaxErrorNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.RB_MaxErrorNumericUpDown.Name = "RB_MaxErrorNumericUpDown";
            this.RB_MaxErrorNumericUpDown.Size = new System.Drawing.Size(84, 20);
            this.RB_MaxErrorNumericUpDown.TabIndex = 74;
            this.RB_MaxErrorNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Max Error";
            // 
            // LoadMainDataSetButton2
            // 
            this.LoadMainDataSetButton2.Location = new System.Drawing.Point(25, 19);
            this.LoadMainDataSetButton2.Name = "LoadMainDataSetButton2";
            this.LoadMainDataSetButton2.Size = new System.Drawing.Size(195, 23);
            this.LoadMainDataSetButton2.TabIndex = 72;
            this.LoadMainDataSetButton2.Text = "Load DataSet";
            this.LoadMainDataSetButton2.UseVisualStyleBackColor = true;
            this.LoadMainDataSetButton2.Click += new System.EventHandler(this.LoadMainDataSetButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Over All Accuracy";
            // 
            // RBOverallAccuracyBox
            // 
            this.RBOverallAccuracyBox.Location = new System.Drawing.Point(545, 100);
            this.RBOverallAccuracyBox.Name = "RBOverallAccuracyBox";
            this.RBOverallAccuracyBox.ReadOnly = true;
            this.RBOverallAccuracyBox.Size = new System.Drawing.Size(60, 20);
            this.RBOverallAccuracyBox.TabIndex = 71;
            // 
            // RBTrainButton
            // 
            this.RBTrainButton.Enabled = false;
            this.RBTrainButton.Location = new System.Drawing.Point(226, 19);
            this.RBTrainButton.Name = "RBTrainButton";
            this.RBTrainButton.Size = new System.Drawing.Size(195, 23);
            this.RBTrainButton.TabIndex = 61;
            this.RBTrainButton.Text = "Train";
            this.RBTrainButton.UseVisualStyleBackColor = true;
            this.RBTrainButton.Click += new System.EventHandler(this.RBTrainButton_Click);
            // 
            // RBTestButton
            // 
            this.RBTestButton.Enabled = false;
            this.RBTestButton.Location = new System.Drawing.Point(427, 19);
            this.RBTestButton.Name = "RBTestButton";
            this.RBTestButton.Size = new System.Drawing.Size(195, 23);
            this.RBTestButton.TabIndex = 62;
            this.RBTestButton.Text = "Test";
            this.RBTestButton.UseVisualStyleBackColor = true;
            this.RBTestButton.Click += new System.EventHandler(this.RBTestButton_Click);
            // 
            // RBConfusionMatrix
            // 
            this.RBConfusionMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RBConfusionMatrix.Location = new System.Drawing.Point(25, 100);
            this.RBConfusionMatrix.Name = "RBConfusionMatrix";
            this.RBConfusionMatrix.Size = new System.Drawing.Size(416, 207);
            this.RBConfusionMatrix.TabIndex = 69;
            // 
            // RBNumOfKUpDown
            // 
            this.RBNumOfKUpDown.Location = new System.Drawing.Point(341, 48);
            this.RBNumOfKUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.RBNumOfKUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RBNumOfKUpDown.Name = "RBNumOfKUpDown";
            this.RBNumOfKUpDown.Size = new System.Drawing.Size(100, 20);
            this.RBNumOfKUpDown.TabIndex = 63;
            this.RBNumOfKUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // RBLearningRateUpDown
            // 
            this.RBLearningRateUpDown.DecimalPlaces = 3;
            this.RBLearningRateUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.RBLearningRateUpDown.Location = new System.Drawing.Point(527, 48);
            this.RBLearningRateUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RBLearningRateUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.RBLearningRateUpDown.Name = "RBLearningRateUpDown";
            this.RBLearningRateUpDown.Size = new System.Drawing.Size(84, 20);
            this.RBLearningRateUpDown.TabIndex = 68;
            this.RBLearningRateUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "K";
            // 
            // RBNumOfEpocksUpDown
            // 
            this.RBNumOfEpocksUpDown.Location = new System.Drawing.Point(341, 74);
            this.RBNumOfEpocksUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RBNumOfEpocksUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RBNumOfEpocksUpDown.Name = "RBNumOfEpocksUpDown";
            this.RBNumOfEpocksUpDown.Size = new System.Drawing.Size(100, 20);
            this.RBNumOfEpocksUpDown.TabIndex = 67;
            this.RBNumOfEpocksUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Number of Epochs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Learning Rate";
            // 
            // TimesOfMLP
            // 
            this.TimesOfMLP.Enabled = false;
            this.TimesOfMLP.Location = new System.Drawing.Point(62, 77);
            this.TimesOfMLP.Name = "TimesOfMLP";
            this.TimesOfMLP.ReadOnly = true;
            this.TimesOfMLP.Size = new System.Drawing.Size(100, 20);
            this.TimesOfMLP.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Time";
            // 
            // TimesOfRBF
            // 
            this.TimesOfRBF.Enabled = false;
            this.TimesOfRBF.Location = new System.Drawing.Point(63, 77);
            this.TimesOfRBF.Name = "TimesOfRBF";
            this.TimesOfRBF.ReadOnly = true;
            this.TimesOfRBF.Size = new System.Drawing.Size(100, 20);
            this.TimesOfRBF.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Time";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Head Orientation Recognition";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCA_LearningRateUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronsInHLayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MPConfusionMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MLNumOfLayersUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MPLearningRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MLNumOfEpocksUpDown)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RB_MaxErrorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBConfusionMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBNumOfKUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBLearningRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RBNumOfEpocksUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadMainDataSetButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MPOverallAccuracyBox;
        private System.Windows.Forms.Button BackpropagationTrainButton;
        private System.Windows.Forms.Button BackpropagationTestButton;
        private System.Windows.Forms.DataGridView MPConfusionMatrix;
        private System.Windows.Forms.NumericUpDown MLNumOfLayersUpDown;
        private System.Windows.Forms.NumericUpDown MPLearningRateUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown MLNumOfEpocksUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button LoadDataSetButton;
        private System.Windows.Forms.Button PCA_TrainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PCA_LearningRateUpDown;
        private System.Windows.Forms.TextBox TimesOfPCA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button LoadMainDataSetButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RBOverallAccuracyBox;
        private System.Windows.Forms.Button RBTrainButton;
        private System.Windows.Forms.Button RBTestButton;
        private System.Windows.Forms.DataGridView RBConfusionMatrix;
        private System.Windows.Forms.NumericUpDown RBLearningRateUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RBNumOfEpocksUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown RB_MaxErrorNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown RBNumOfKUpDown;
        private System.Windows.Forms.DataGridView NeuronsInHLayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox TimesOfMLP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TimesOfRBF;
        private System.Windows.Forms.Label label13;
    }
}

