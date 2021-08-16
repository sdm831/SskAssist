
namespace SskAssistWF
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.textBoxPathSst = new System.Windows.Forms.TextBox();
            this.textBoxPathPro = new System.Windows.Forms.TextBox();
            this.textBoxPathDest = new System.Windows.Forms.TextBox();
            this.btnChooseSst = new System.Windows.Forms.Button();
            this.btnChoosePro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseDest = new System.Windows.Forms.Button();
            this.labelPro = new System.Windows.Forms.Label();
            this.labelSst = new System.Windows.Forms.Label();
            this.labelDest = new System.Windows.Forms.Label();
            this.textBoxSqlStend = new System.Windows.Forms.TextBox();
            this.btnRunSqlStend = new System.Windows.Forms.Button();
            this.btnRunSqlProd = new System.Windows.Forms.Button();
            this.textBoxSqlProd = new System.Windows.Forms.TextBox();
            this.radioBtnFromDb = new System.Windows.Forms.RadioButton();
            this.radioBtnFromFiles = new System.Windows.Forms.RadioButton();
            this.comboBoxChooseSystem = new System.Windows.Forms.ComboBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnGenNewConfig = new System.Windows.Forms.Button();
            this.btnGetDiff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(16, 135);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(64, 33);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "old Diff";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnGetDiff_Click);
            // 
            // textBoxPathSst
            // 
            this.textBoxPathSst.Location = new System.Drawing.Point(41, 100);
            this.textBoxPathSst.Name = "textBoxPathSst";
            this.textBoxPathSst.Size = new System.Drawing.Size(485, 20);
            this.textBoxPathSst.TabIndex = 1;
            this.textBoxPathSst.Text = "choose SST config";
            // 
            // textBoxPathPro
            // 
            this.textBoxPathPro.Location = new System.Drawing.Point(41, 74);
            this.textBoxPathPro.Name = "textBoxPathPro";
            this.textBoxPathPro.Size = new System.Drawing.Size(485, 20);
            this.textBoxPathPro.TabIndex = 2;
            this.textBoxPathPro.Tag = "tag";
            this.textBoxPathPro.Text = "choose Prod config";
            // 
            // textBoxPathDest
            // 
            this.textBoxPathDest.Location = new System.Drawing.Point(119, 36);
            this.textBoxPathDest.Name = "textBoxPathDest";
            this.textBoxPathDest.Size = new System.Drawing.Size(485, 20);
            this.textBoxPathDest.TabIndex = 3;
            this.textBoxPathDest.Text = "choose destination directory";
            // 
            // btnChooseSst
            // 
            this.btnChooseSst.Location = new System.Drawing.Point(533, 100);
            this.btnChooseSst.Name = "btnChooseSst";
            this.btnChooseSst.Size = new System.Drawing.Size(23, 20);
            this.btnChooseSst.TabIndex = 4;
            this.btnChooseSst.Text = "...";
            this.btnChooseSst.UseVisualStyleBackColor = true;
            this.btnChooseSst.Click += new System.EventHandler(this.BtnChooseSst_Click);
            // 
            // btnChoosePro
            // 
            this.btnChoosePro.Location = new System.Drawing.Point(533, 74);
            this.btnChoosePro.Name = "btnChoosePro";
            this.btnChoosePro.Size = new System.Drawing.Size(23, 20);
            this.btnChoosePro.TabIndex = 5;
            this.btnChoosePro.Text = "...";
            this.btnChoosePro.UseVisualStyleBackColor = true;
            this.btnChoosePro.Click += new System.EventHandler(this.btnChoosePro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Проверка разницы конфигов Прома и Стенда";
            // 
            // btnChooseDest
            // 
            this.btnChooseDest.Location = new System.Drawing.Point(610, 36);
            this.btnChooseDest.Name = "btnChooseDest";
            this.btnChooseDest.Size = new System.Drawing.Size(23, 20);
            this.btnChooseDest.TabIndex = 7;
            this.btnChooseDest.Text = "...";
            this.btnChooseDest.UseVisualStyleBackColor = true;
            this.btnChooseDest.Click += new System.EventHandler(this.btnChooseDest_Click);
            // 
            // labelPro
            // 
            this.labelPro.AutoSize = true;
            this.labelPro.Location = new System.Drawing.Point(9, 76);
            this.labelPro.Name = "labelPro";
            this.labelPro.Size = new System.Drawing.Size(32, 13);
            this.labelPro.TabIndex = 8;
            this.labelPro.Text = "Prod:";
            // 
            // labelSst
            // 
            this.labelSst.AutoSize = true;
            this.labelSst.Location = new System.Drawing.Point(11, 102);
            this.labelSst.Name = "labelSst";
            this.labelSst.Size = new System.Drawing.Size(28, 13);
            this.labelSst.TabIndex = 9;
            this.labelSst.Text = "SST";
            // 
            // labelDest
            // 
            this.labelDest.AutoSize = true;
            this.labelDest.Location = new System.Drawing.Point(8, 38);
            this.labelDest.Name = "labelDest";
            this.labelDest.Size = new System.Drawing.Size(103, 13);
            this.labelDest.TabIndex = 10;
            this.labelDest.Text = "Destination directory";
            // 
            // textBoxSqlStend
            // 
            this.textBoxSqlStend.Location = new System.Drawing.Point(11, 285);
            this.textBoxSqlStend.Name = "textBoxSqlStend";
            this.textBoxSqlStend.Size = new System.Drawing.Size(492, 20);
            this.textBoxSqlStend.TabIndex = 12;
            this.textBoxSqlStend.Text = "select * from monitor_stend.ism_model_status";
            // 
            // btnRunSqlStend
            // 
            this.btnRunSqlStend.Location = new System.Drawing.Point(523, 283);
            this.btnRunSqlStend.Name = "btnRunSqlStend";
            this.btnRunSqlStend.Size = new System.Drawing.Size(103, 23);
            this.btnRunSqlStend.TabIndex = 13;
            this.btnRunSqlStend.Text = "Run sql (Stend)";
            this.btnRunSqlStend.UseVisualStyleBackColor = true;
            this.btnRunSqlStend.Click += new System.EventHandler(this.btnRunSqlStend_Click);
            // 
            // btnRunSqlProd
            // 
            this.btnRunSqlProd.Location = new System.Drawing.Point(523, 312);
            this.btnRunSqlProd.Name = "btnRunSqlProd";
            this.btnRunSqlProd.Size = new System.Drawing.Size(103, 23);
            this.btnRunSqlProd.TabIndex = 16;
            this.btnRunSqlProd.Text = "Run sql (Prod)";
            this.btnRunSqlProd.UseVisualStyleBackColor = true;
            this.btnRunSqlProd.Click += new System.EventHandler(this.btnRunSqlProd_Click);
            // 
            // textBoxSqlProd
            // 
            this.textBoxSqlProd.Location = new System.Drawing.Point(11, 314);
            this.textBoxSqlProd.Name = "textBoxSqlProd";
            this.textBoxSqlProd.Size = new System.Drawing.Size(492, 20);
            this.textBoxSqlProd.TabIndex = 15;
            this.textBoxSqlProd.Text = "select * from monitor_prod.ism_model_status";
            // 
            // radioBtnFromDb
            // 
            this.radioBtnFromDb.AutoSize = true;
            this.radioBtnFromDb.Location = new System.Drawing.Point(11, 354);
            this.radioBtnFromDb.Name = "radioBtnFromDb";
            this.radioBtnFromDb.Size = new System.Drawing.Size(63, 17);
            this.radioBtnFromDb.TabIndex = 19;
            this.radioBtnFromDb.TabStop = true;
            this.radioBtnFromDb.Text = "from DB";
            this.radioBtnFromDb.UseVisualStyleBackColor = true;
            this.radioBtnFromDb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnFromFiles
            // 
            this.radioBtnFromFiles.AutoSize = true;
            this.radioBtnFromFiles.Location = new System.Drawing.Point(11, 374);
            this.radioBtnFromFiles.Name = "radioBtnFromFiles";
            this.radioBtnFromFiles.Size = new System.Drawing.Size(69, 17);
            this.radioBtnFromFiles.TabIndex = 20;
            this.radioBtnFromFiles.TabStop = true;
            this.radioBtnFromFiles.Text = "from Files";
            this.radioBtnFromFiles.UseVisualStyleBackColor = true;
            this.radioBtnFromFiles.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBoxChooseSystem
            // 
            this.comboBoxChooseSystem.FormattingEnabled = true;
            this.comboBoxChooseSystem.Items.AddRange(new object[] {
            "Sbp",
            "Ckps",
            "Cos",
            "Sdm",
            "Hdm"});
            this.comboBoxChooseSystem.Location = new System.Drawing.Point(93, 363);
            this.comboBoxChooseSystem.Name = "comboBoxChooseSystem";
            this.comboBoxChooseSystem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseSystem.TabIndex = 21;
            this.comboBoxChooseSystem.Tag = "";
            this.comboBoxChooseSystem.Text = "Choose system";
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetData.Location = new System.Drawing.Point(227, 357);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(71, 35);
            this.btnGetData.TabIndex = 22;
            this.btnGetData.Text = "getData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnGenNewConfig
            // 
            this.btnGenNewConfig.Location = new System.Drawing.Point(260, 135);
            this.btnGenNewConfig.Name = "btnGenNewConfig";
            this.btnGenNewConfig.Size = new System.Drawing.Size(105, 33);
            this.btnGenNewConfig.TabIndex = 23;
            this.btnGenNewConfig.Text = "Get New Config";
            this.btnGenNewConfig.UseVisualStyleBackColor = true;
            this.btnGenNewConfig.Click += new System.EventHandler(this.btnGenNewConfig_Click);
            // 
            // btnGetDiff
            // 
            this.btnGetDiff.Location = new System.Drawing.Point(119, 135);
            this.btnGetDiff.Name = "btnGetDiff";
            this.btnGetDiff.Size = new System.Drawing.Size(64, 33);
            this.btnGetDiff.TabIndex = 24;
            this.btnGetDiff.Text = "Compare";
            this.btnGetDiff.UseVisualStyleBackColor = true;
            this.btnGetDiff.Click += new System.EventHandler(this.btnGetDiff_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 497);
            this.Controls.Add(this.btnGetDiff);
            this.Controls.Add(this.btnGenNewConfig);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.comboBoxChooseSystem);
            this.Controls.Add(this.radioBtnFromFiles);
            this.Controls.Add(this.radioBtnFromDb);
            this.Controls.Add(this.btnRunSqlProd);
            this.Controls.Add(this.textBoxSqlProd);
            this.Controls.Add(this.btnRunSqlStend);
            this.Controls.Add(this.textBoxSqlStend);
            this.Controls.Add(this.labelDest);
            this.Controls.Add(this.labelSst);
            this.Controls.Add(this.labelPro);
            this.Controls.Add(this.btnChooseDest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChoosePro);
            this.Controls.Add(this.btnChooseSst);
            this.Controls.Add(this.textBoxPathDest);
            this.Controls.Add(this.textBoxPathPro);
            this.Controls.Add(this.textBoxPathSst);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox textBoxPathSst;
        private System.Windows.Forms.TextBox textBoxPathPro;
        private System.Windows.Forms.TextBox textBoxPathDest;
        private System.Windows.Forms.Button btnChooseSst;
        private System.Windows.Forms.Button btnChoosePro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseDest;
        private System.Windows.Forms.Label labelPro;
        private System.Windows.Forms.Label labelSst;
        private System.Windows.Forms.Label labelDest;
        private System.Windows.Forms.TextBox textBoxSqlStend;
        private System.Windows.Forms.Button btnRunSqlStend;
        private System.Windows.Forms.Button btnRunSqlProd;
        private System.Windows.Forms.TextBox textBoxSqlProd;
        private System.Windows.Forms.RadioButton radioBtnFromDb;
        private System.Windows.Forms.RadioButton radioBtnFromFiles;
        private System.Windows.Forms.ComboBox comboBoxChooseSystem;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnGenNewConfig;
        private System.Windows.Forms.Button btnGetDiff;
    }
}

