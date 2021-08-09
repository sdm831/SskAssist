
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
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(759, 121);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(85, 25);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "getDiff";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnGetDiff_Click);
            // 
            // textBoxPathSst
            // 
            this.textBoxPathSst.Location = new System.Drawing.Point(55, 123);
            this.textBoxPathSst.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPathSst.Name = "textBoxPathSst";
            this.textBoxPathSst.Size = new System.Drawing.Size(645, 22);
            this.textBoxPathSst.TabIndex = 1;
            this.textBoxPathSst.Text = "choose SST config";
            // 
            // textBoxPathPro
            // 
            this.textBoxPathPro.Location = new System.Drawing.Point(55, 91);
            this.textBoxPathPro.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPathPro.Name = "textBoxPathPro";
            this.textBoxPathPro.Size = new System.Drawing.Size(645, 22);
            this.textBoxPathPro.TabIndex = 2;
            this.textBoxPathPro.Tag = "tag";
            this.textBoxPathPro.Text = "choose Prod config";
            // 
            // textBoxPathDest
            // 
            this.textBoxPathDest.Location = new System.Drawing.Point(159, 44);
            this.textBoxPathDest.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPathDest.Name = "textBoxPathDest";
            this.textBoxPathDest.Size = new System.Drawing.Size(645, 22);
            this.textBoxPathDest.TabIndex = 3;
            this.textBoxPathDest.Text = "choose destination directory";
            // 
            // btnChooseSst
            // 
            this.btnChooseSst.Location = new System.Drawing.Point(711, 123);
            this.btnChooseSst.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseSst.Name = "btnChooseSst";
            this.btnChooseSst.Size = new System.Drawing.Size(31, 25);
            this.btnChooseSst.TabIndex = 4;
            this.btnChooseSst.Text = "...";
            this.btnChooseSst.UseVisualStyleBackColor = true;
            this.btnChooseSst.Click += new System.EventHandler(this.BtnChooseSst_Click);
            // 
            // btnChoosePro
            // 
            this.btnChoosePro.Location = new System.Drawing.Point(711, 91);
            this.btnChoosePro.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoosePro.Name = "btnChoosePro";
            this.btnChoosePro.Size = new System.Drawing.Size(31, 25);
            this.btnChoosePro.TabIndex = 5;
            this.btnChoosePro.Text = "...";
            this.btnChoosePro.UseVisualStyleBackColor = true;
            this.btnChoosePro.Click += new System.EventHandler(this.btnChoosePro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Проверка разницы конфигов Прома и Стенда";
            // 
            // btnChooseDest
            // 
            this.btnChooseDest.Location = new System.Drawing.Point(813, 44);
            this.btnChooseDest.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseDest.Name = "btnChooseDest";
            this.btnChooseDest.Size = new System.Drawing.Size(31, 25);
            this.btnChooseDest.TabIndex = 7;
            this.btnChooseDest.Text = "...";
            this.btnChooseDest.UseVisualStyleBackColor = true;
            this.btnChooseDest.Click += new System.EventHandler(this.btnChooseDest_Click);
            // 
            // labelPro
            // 
            this.labelPro.AutoSize = true;
            this.labelPro.Location = new System.Drawing.Point(12, 94);
            this.labelPro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPro.Name = "labelPro";
            this.labelPro.Size = new System.Drawing.Size(42, 17);
            this.labelPro.TabIndex = 8;
            this.labelPro.Text = "Prod:";
            // 
            // labelSst
            // 
            this.labelSst.AutoSize = true;
            this.labelSst.Location = new System.Drawing.Point(15, 125);
            this.labelSst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSst.Name = "labelSst";
            this.labelSst.Size = new System.Drawing.Size(35, 17);
            this.labelSst.TabIndex = 9;
            this.labelSst.Text = "SST";
            // 
            // labelDest
            // 
            this.labelDest.AutoSize = true;
            this.labelDest.Location = new System.Drawing.Point(11, 47);
            this.labelDest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDest.Name = "labelDest";
            this.labelDest.Size = new System.Drawing.Size(138, 17);
            this.labelDest.TabIndex = 10;
            this.labelDest.Text = "Destination directory";
            // 
            // textBoxSqlStend
            // 
            this.textBoxSqlStend.Location = new System.Drawing.Point(15, 243);
            this.textBoxSqlStend.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSqlStend.Name = "textBoxSqlStend";
            this.textBoxSqlStend.Size = new System.Drawing.Size(655, 22);
            this.textBoxSqlStend.TabIndex = 12;
            this.textBoxSqlStend.Text = "select * from monitor_stend.ism_model_status";
            // 
            // btnRunSqlStend
            // 
            this.btnRunSqlStend.Location = new System.Drawing.Point(697, 240);
            this.btnRunSqlStend.Margin = new System.Windows.Forms.Padding(4);
            this.btnRunSqlStend.Name = "btnRunSqlStend";
            this.btnRunSqlStend.Size = new System.Drawing.Size(137, 28);
            this.btnRunSqlStend.TabIndex = 13;
            this.btnRunSqlStend.Text = "Run sql (Stend)";
            this.btnRunSqlStend.UseVisualStyleBackColor = true;
            this.btnRunSqlStend.Click += new System.EventHandler(this.btnRunSqlStend_Click);
            // 
            // btnRunSqlProd
            // 
            this.btnRunSqlProd.Location = new System.Drawing.Point(697, 276);
            this.btnRunSqlProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnRunSqlProd.Name = "btnRunSqlProd";
            this.btnRunSqlProd.Size = new System.Drawing.Size(137, 28);
            this.btnRunSqlProd.TabIndex = 16;
            this.btnRunSqlProd.Text = "Run sql (Prod)";
            this.btnRunSqlProd.UseVisualStyleBackColor = true;
            this.btnRunSqlProd.Click += new System.EventHandler(this.btnRunSqlProd_Click);
            // 
            // textBoxSqlProd
            // 
            this.textBoxSqlProd.Location = new System.Drawing.Point(15, 278);
            this.textBoxSqlProd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSqlProd.Name = "textBoxSqlProd";
            this.textBoxSqlProd.Size = new System.Drawing.Size(655, 22);
            this.textBoxSqlProd.TabIndex = 15;
            this.textBoxSqlProd.Text = "select * from monitor_prod.ism_model_status";
            // 
            // radioBtnFromDb
            // 
            this.radioBtnFromDb.AutoSize = true;
            this.radioBtnFromDb.Location = new System.Drawing.Point(15, 436);
            this.radioBtnFromDb.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnFromDb.Name = "radioBtnFromDb";
            this.radioBtnFromDb.Size = new System.Drawing.Size(80, 21);
            this.radioBtnFromDb.TabIndex = 19;
            this.radioBtnFromDb.TabStop = true;
            this.radioBtnFromDb.Text = "from DB";
            this.radioBtnFromDb.UseVisualStyleBackColor = true;
            this.radioBtnFromDb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnFromFiles
            // 
            this.radioBtnFromFiles.AutoSize = true;
            this.radioBtnFromFiles.Location = new System.Drawing.Point(15, 460);
            this.radioBtnFromFiles.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnFromFiles.Name = "radioBtnFromFiles";
            this.radioBtnFromFiles.Size = new System.Drawing.Size(90, 21);
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
            this.comboBoxChooseSystem.Location = new System.Drawing.Point(107, 435);
            this.comboBoxChooseSystem.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChooseSystem.Name = "comboBoxChooseSystem";
            this.comboBoxChooseSystem.Size = new System.Drawing.Size(160, 24);
            this.comboBoxChooseSystem.TabIndex = 21;
            this.comboBoxChooseSystem.Tag = "";
            this.comboBoxChooseSystem.Text = "Choose system";
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetData.Location = new System.Drawing.Point(388, 425);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(95, 43);
            this.btnGetData.TabIndex = 22;
            this.btnGetData.Text = "getData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 612);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

