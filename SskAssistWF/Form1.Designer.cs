
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(562, 312);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(64, 20);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "getDiff";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnGetDiff_Click);
            // 
            // textBoxPathSst
            // 
            this.textBoxPathSst.Location = new System.Drawing.Point(41, 206);
            this.textBoxPathSst.Name = "textBoxPathSst";
            this.textBoxPathSst.Size = new System.Drawing.Size(485, 20);
            this.textBoxPathSst.TabIndex = 1;
            this.textBoxPathSst.Text = "choose SST config";
            // 
            // textBoxPathPro
            // 
            this.textBoxPathPro.Location = new System.Drawing.Point(41, 180);
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
            this.btnChooseSst.Location = new System.Drawing.Point(533, 206);
            this.btnChooseSst.Name = "btnChooseSst";
            this.btnChooseSst.Size = new System.Drawing.Size(23, 20);
            this.btnChooseSst.TabIndex = 4;
            this.btnChooseSst.Text = "...";
            this.btnChooseSst.UseVisualStyleBackColor = true;
            this.btnChooseSst.Click += new System.EventHandler(this.BtnChooseSst_Click);
            // 
            // btnChoosePro
            // 
            this.btnChoosePro.Location = new System.Drawing.Point(533, 180);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.labelPro.Location = new System.Drawing.Point(9, 183);
            this.labelPro.Name = "labelPro";
            this.labelPro.Size = new System.Drawing.Size(32, 13);
            this.labelPro.TabIndex = 8;
            this.labelPro.Text = "Prod:";
            // 
            // labelSst
            // 
            this.labelSst.AutoSize = true;
            this.labelSst.Location = new System.Drawing.Point(11, 208);
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
            this.textBoxSqlStend.Location = new System.Drawing.Point(11, 427);
            this.textBoxSqlStend.Name = "textBoxSqlStend";
            this.textBoxSqlStend.Size = new System.Drawing.Size(492, 20);
            this.textBoxSqlStend.TabIndex = 12;
            this.textBoxSqlStend.Text = "select * from ism_text_file";
            // 
            // btnRunSqlStend
            // 
            this.btnRunSqlStend.Location = new System.Drawing.Point(523, 425);
            this.btnRunSqlStend.Name = "btnRunSqlStend";
            this.btnRunSqlStend.Size = new System.Drawing.Size(103, 23);
            this.btnRunSqlStend.TabIndex = 13;
            this.btnRunSqlStend.Text = "Run sql (Stend)";
            this.btnRunSqlStend.UseVisualStyleBackColor = true;
            this.btnRunSqlStend.Click += new System.EventHandler(this.btnRunSqlStend_Click);
            // 
            // btnRunSqlProd
            // 
            this.btnRunSqlProd.Location = new System.Drawing.Point(523, 454);
            this.btnRunSqlProd.Name = "btnRunSqlProd";
            this.btnRunSqlProd.Size = new System.Drawing.Size(103, 23);
            this.btnRunSqlProd.TabIndex = 16;
            this.btnRunSqlProd.Text = "Run sql (Prod)";
            this.btnRunSqlProd.UseVisualStyleBackColor = true;
            this.btnRunSqlProd.Click += new System.EventHandler(this.btnRunSqlProd_Click);
            // 
            // textBoxSqlProd
            // 
            this.textBoxSqlProd.Location = new System.Drawing.Point(11, 456);
            this.textBoxSqlProd.Name = "textBoxSqlProd";
            this.textBoxSqlProd.Size = new System.Drawing.Size(492, 20);
            this.textBoxSqlProd.TabIndex = 15;
            this.textBoxSqlProd.Text = "select * from monitor_stend.ism_text_file";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 87);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "from DB";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 157);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "from Configs";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sbp",
            "Ckps",
            "Cos",
            "Sdm",
            "Hdm"});
            this.comboBox1.Location = new System.Drawing.Point(80, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "Choose system";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 497);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

