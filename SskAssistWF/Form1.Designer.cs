
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxPathNew = new System.Windows.Forms.TextBox();
            this.textBoxPathOld = new System.Windows.Forms.TextBox();
            this.textBoxPathDest = new System.Windows.Forms.TextBox();
            this.btnChooseSst = new System.Windows.Forms.Button();
            this.btnChoosePro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseDest = new System.Windows.Forms.Button();
            this.labelOld = new System.Windows.Forms.Label();
            this.labelNew = new System.Windows.Forms.Label();
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseDiff = new System.Windows.Forms.Button();
            this.textBoxPathDiff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxPathNew
            // 
            this.textBoxPathNew.Location = new System.Drawing.Point(41, 100);
            this.textBoxPathNew.Name = "textBoxPathNew";
            this.textBoxPathNew.Size = new System.Drawing.Size(674, 20);
            this.textBoxPathNew.TabIndex = 1;
            this.textBoxPathNew.Text = "choose New config";
            // 
            // textBoxPathOld
            // 
            this.textBoxPathOld.Location = new System.Drawing.Point(41, 74);
            this.textBoxPathOld.Name = "textBoxPathOld";
            this.textBoxPathOld.Size = new System.Drawing.Size(674, 20);
            this.textBoxPathOld.TabIndex = 2;
            this.textBoxPathOld.Tag = "tag";
            this.textBoxPathOld.Text = "choose Old config";
            // 
            // textBoxPathDest
            // 
            this.textBoxPathDest.Location = new System.Drawing.Point(119, 36);
            this.textBoxPathDest.Name = "textBoxPathDest";
            this.textBoxPathDest.Size = new System.Drawing.Size(596, 20);
            this.textBoxPathDest.TabIndex = 3;
            this.textBoxPathDest.Text = "choose destination directory";
            // 
            // btnChooseSst
            // 
            this.btnChooseSst.Location = new System.Drawing.Point(721, 100);
            this.btnChooseSst.Name = "btnChooseSst";
            this.btnChooseSst.Size = new System.Drawing.Size(23, 20);
            this.btnChooseSst.TabIndex = 4;
            this.btnChooseSst.Text = "...";
            this.btnChooseSst.UseVisualStyleBackColor = true;
            this.btnChooseSst.Click += new System.EventHandler(this.BtnChooseNew_Click);
            // 
            // btnChoosePro
            // 
            this.btnChoosePro.Location = new System.Drawing.Point(721, 74);
            this.btnChoosePro.Name = "btnChoosePro";
            this.btnChoosePro.Size = new System.Drawing.Size(23, 20);
            this.btnChoosePro.TabIndex = 5;
            this.btnChoosePro.Text = "...";
            this.btnChoosePro.UseVisualStyleBackColor = true;
            this.btnChoosePro.Click += new System.EventHandler(this.btnChooseOld_Click);
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
            this.btnChooseDest.Location = new System.Drawing.Point(721, 36);
            this.btnChooseDest.Name = "btnChooseDest";
            this.btnChooseDest.Size = new System.Drawing.Size(23, 20);
            this.btnChooseDest.TabIndex = 7;
            this.btnChooseDest.Text = "...";
            this.btnChooseDest.UseVisualStyleBackColor = true;
            this.btnChooseDest.Click += new System.EventHandler(this.btnChooseDest_Click);
            // 
            // labelOld
            // 
            this.labelOld.AutoSize = true;
            this.labelOld.Location = new System.Drawing.Point(11, 77);
            this.labelOld.Name = "labelOld";
            this.labelOld.Size = new System.Drawing.Size(26, 13);
            this.labelOld.TabIndex = 8;
            this.labelOld.Text = "Old:";
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Location = new System.Drawing.Point(7, 103);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(32, 13);
            this.labelNew.TabIndex = 9;
            this.labelNew.Text = "New:";
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
            this.textBoxSqlStend.Enabled = false;
            this.textBoxSqlStend.Location = new System.Drawing.Point(42, 172);
            this.textBoxSqlStend.Name = "textBoxSqlStend";
            this.textBoxSqlStend.Size = new System.Drawing.Size(28, 20);
            this.textBoxSqlStend.TabIndex = 12;
            this.textBoxSqlStend.Text = "select * from monitor_stend.ism_model_status";
            this.textBoxSqlStend.Visible = false;
            // 
            // btnRunSqlStend
            // 
            this.btnRunSqlStend.Enabled = false;
            this.btnRunSqlStend.Location = new System.Drawing.Point(137, 172);
            this.btnRunSqlStend.Name = "btnRunSqlStend";
            this.btnRunSqlStend.Size = new System.Drawing.Size(56, 23);
            this.btnRunSqlStend.TabIndex = 13;
            this.btnRunSqlStend.Text = "Run sql (Stend)";
            this.btnRunSqlStend.UseVisualStyleBackColor = true;
            this.btnRunSqlStend.Visible = false;
            this.btnRunSqlStend.Click += new System.EventHandler(this.btnRunSqlStend_Click);
            // 
            // btnRunSqlProd
            // 
            this.btnRunSqlProd.Enabled = false;
            this.btnRunSqlProd.Location = new System.Drawing.Point(76, 172);
            this.btnRunSqlProd.Name = "btnRunSqlProd";
            this.btnRunSqlProd.Size = new System.Drawing.Size(55, 23);
            this.btnRunSqlProd.TabIndex = 16;
            this.btnRunSqlProd.Text = "Run sql (Prod)";
            this.btnRunSqlProd.UseVisualStyleBackColor = true;
            this.btnRunSqlProd.Visible = false;
            this.btnRunSqlProd.Click += new System.EventHandler(this.btnRunSqlProd_Click);
            // 
            // textBoxSqlProd
            // 
            this.textBoxSqlProd.Enabled = false;
            this.textBoxSqlProd.Location = new System.Drawing.Point(8, 172);
            this.textBoxSqlProd.Name = "textBoxSqlProd";
            this.textBoxSqlProd.Size = new System.Drawing.Size(28, 20);
            this.textBoxSqlProd.TabIndex = 15;
            this.textBoxSqlProd.Text = "select * from monitor_prod.ism_model_status";
            this.textBoxSqlProd.Visible = false;
            // 
            // radioBtnFromDb
            // 
            this.radioBtnFromDb.AutoSize = true;
            this.radioBtnFromDb.Enabled = false;
            this.radioBtnFromDb.Location = new System.Drawing.Point(209, 172);
            this.radioBtnFromDb.Name = "radioBtnFromDb";
            this.radioBtnFromDb.Size = new System.Drawing.Size(63, 17);
            this.radioBtnFromDb.TabIndex = 19;
            this.radioBtnFromDb.TabStop = true;
            this.radioBtnFromDb.Text = "from DB";
            this.radioBtnFromDb.UseVisualStyleBackColor = true;
            this.radioBtnFromDb.Visible = false;
            this.radioBtnFromDb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnFromFiles
            // 
            this.radioBtnFromFiles.AutoSize = true;
            this.radioBtnFromFiles.Enabled = false;
            this.radioBtnFromFiles.Location = new System.Drawing.Point(209, 185);
            this.radioBtnFromFiles.Name = "radioBtnFromFiles";
            this.radioBtnFromFiles.Size = new System.Drawing.Size(69, 17);
            this.radioBtnFromFiles.TabIndex = 20;
            this.radioBtnFromFiles.TabStop = true;
            this.radioBtnFromFiles.Text = "from Files";
            this.radioBtnFromFiles.UseVisualStyleBackColor = true;
            this.radioBtnFromFiles.Visible = false;
            this.radioBtnFromFiles.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBoxChooseSystem
            // 
            this.comboBoxChooseSystem.Enabled = false;
            this.comboBoxChooseSystem.FormattingEnabled = true;
            this.comboBoxChooseSystem.Items.AddRange(new object[] {
            "Sbp",
            "Ckps",
            "Cos",
            "Sdm",
            "Hdm"});
            this.comboBoxChooseSystem.Location = new System.Drawing.Point(291, 174);
            this.comboBoxChooseSystem.Name = "comboBoxChooseSystem";
            this.comboBoxChooseSystem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseSystem.TabIndex = 21;
            this.comboBoxChooseSystem.Tag = "";
            this.comboBoxChooseSystem.Text = "Choose system";
            this.comboBoxChooseSystem.Visible = false;
            // 
            // btnGetData
            // 
            this.btnGetData.Enabled = false;
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetData.Location = new System.Drawing.Point(420, 171);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(57, 27);
            this.btnGetData.TabIndex = 22;
            this.btnGetData.Text = "getData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Visible = false;
            // 
            // btnGenNewConfig
            // 
            this.btnGenNewConfig.Location = new System.Drawing.Point(528, 137);
            this.btnGenNewConfig.Name = "btnGenNewConfig";
            this.btnGenNewConfig.Size = new System.Drawing.Size(105, 26);
            this.btnGenNewConfig.TabIndex = 23;
            this.btnGenNewConfig.Text = "Get New Config";
            this.btnGenNewConfig.UseVisualStyleBackColor = true;
            this.btnGenNewConfig.Click += new System.EventHandler(this.btnGenNewConfig_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(757, 82);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(64, 33);
            this.btnCompare.TabIndex = 24;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Diff";
            // 
            // btnChooseDiff
            // 
            this.btnChooseDiff.Location = new System.Drawing.Point(499, 140);
            this.btnChooseDiff.Name = "btnChooseDiff";
            this.btnChooseDiff.Size = new System.Drawing.Size(23, 20);
            this.btnChooseDiff.TabIndex = 26;
            this.btnChooseDiff.Text = "...";
            this.btnChooseDiff.UseVisualStyleBackColor = true;
            this.btnChooseDiff.Click += new System.EventHandler(this.btnChooseDiff_Click);
            // 
            // textBoxPathDiff
            // 
            this.textBoxPathDiff.Location = new System.Drawing.Point(41, 140);
            this.textBoxPathDiff.Name = "textBoxPathDiff";
            this.textBoxPathDiff.Size = new System.Drawing.Size(452, 20);
            this.textBoxPathDiff.TabIndex = 25;
            this.textBoxPathDiff.Text = "choose Diff file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseDiff);
            this.Controls.Add(this.textBoxPathDiff);
            this.Controls.Add(this.btnCompare);
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
            this.Controls.Add(this.labelNew);
            this.Controls.Add(this.labelOld);
            this.Controls.Add(this.btnChooseDest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChoosePro);
            this.Controls.Add(this.btnChooseSst);
            this.Controls.Add(this.textBoxPathDest);
            this.Controls.Add(this.textBoxPathOld);
            this.Controls.Add(this.textBoxPathNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SskAssist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPathNew;
        private System.Windows.Forms.TextBox textBoxPathOld;
        private System.Windows.Forms.TextBox textBoxPathDest;
        private System.Windows.Forms.Button btnChooseSst;
        private System.Windows.Forms.Button btnChoosePro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseDest;
        private System.Windows.Forms.Label labelOld;
        private System.Windows.Forms.Label labelNew;
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
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChooseDiff;
        private System.Windows.Forms.TextBox textBoxPathDiff;
    }
}

