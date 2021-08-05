
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
            this.btnConnectStend = new System.Windows.Forms.Button();
            this.textBoxSqlStend = new System.Windows.Forms.TextBox();
            this.btnRunSqlStend = new System.Windows.Forms.Button();
            this.btnRunSqlProd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConnectProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(550, 125);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(64, 20);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "getDiff";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnGetDiff_Click);
            // 
            // textBoxPathSst
            // 
            this.textBoxPathSst.Location = new System.Drawing.Point(41, 75);
            this.textBoxPathSst.Name = "textBoxPathSst";
            this.textBoxPathSst.Size = new System.Drawing.Size(547, 20);
            this.textBoxPathSst.TabIndex = 1;
            this.textBoxPathSst.Text = "choose SST config";
            // 
            // textBoxPathPro
            // 
            this.textBoxPathPro.Location = new System.Drawing.Point(41, 49);
            this.textBoxPathPro.Name = "textBoxPathPro";
            this.textBoxPathPro.Size = new System.Drawing.Size(547, 20);
            this.textBoxPathPro.TabIndex = 2;
            this.textBoxPathPro.Tag = "tag";
            this.textBoxPathPro.Text = "choose Prod config";
            // 
            // textBoxPathDest
            // 
            this.textBoxPathDest.Location = new System.Drawing.Point(41, 100);
            this.textBoxPathDest.Name = "textBoxPathDest";
            this.textBoxPathDest.Size = new System.Drawing.Size(547, 20);
            this.textBoxPathDest.TabIndex = 3;
            this.textBoxPathDest.Text = "choose destination directory";
            // 
            // btnChooseSst
            // 
            this.btnChooseSst.Location = new System.Drawing.Point(592, 75);
            this.btnChooseSst.Name = "btnChooseSst";
            this.btnChooseSst.Size = new System.Drawing.Size(23, 20);
            this.btnChooseSst.TabIndex = 4;
            this.btnChooseSst.Text = "...";
            this.btnChooseSst.UseVisualStyleBackColor = true;
            this.btnChooseSst.Click += new System.EventHandler(this.BtnChooseSst_Click);
            // 
            // btnChoosePro
            // 
            this.btnChoosePro.Location = new System.Drawing.Point(592, 49);
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
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Проверка разницы конфигов Прома и Стенда";
            // 
            // btnChooseDest
            // 
            this.btnChooseDest.Location = new System.Drawing.Point(591, 100);
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
            this.labelPro.Location = new System.Drawing.Point(9, 52);
            this.labelPro.Name = "labelPro";
            this.labelPro.Size = new System.Drawing.Size(32, 13);
            this.labelPro.TabIndex = 8;
            this.labelPro.Text = "Prod:";
            // 
            // labelSst
            // 
            this.labelSst.AutoSize = true;
            this.labelSst.Location = new System.Drawing.Point(11, 77);
            this.labelSst.Name = "labelSst";
            this.labelSst.Size = new System.Drawing.Size(28, 13);
            this.labelSst.TabIndex = 9;
            this.labelSst.Text = "SST";
            // 
            // labelDest
            // 
            this.labelDest.AutoSize = true;
            this.labelDest.Location = new System.Drawing.Point(8, 102);
            this.labelDest.Name = "labelDest";
            this.labelDest.Size = new System.Drawing.Size(29, 13);
            this.labelDest.TabIndex = 10;
            this.labelDest.Text = "Dest";
            // 
            // btnConnectStend
            // 
            this.btnConnectStend.Location = new System.Drawing.Point(2, 179);
            this.btnConnectStend.Name = "btnConnectStend";
            this.btnConnectStend.Size = new System.Drawing.Size(125, 23);
            this.btnConnectStend.TabIndex = 11;
            this.btnConnectStend.Text = "Connect to BD Stend";
            this.btnConnectStend.UseVisualStyleBackColor = false;
            this.btnConnectStend.Click += new System.EventHandler(this.btnConnectStend_Click);
            // 
            // textBoxSqlStend
            // 
            this.textBoxSqlStend.Location = new System.Drawing.Point(133, 181);
            this.textBoxSqlStend.Name = "textBoxSqlStend";
            this.textBoxSqlStend.Size = new System.Drawing.Size(433, 20);
            this.textBoxSqlStend.TabIndex = 12;
            this.textBoxSqlStend.Text = "select * from ism_text_file";
            this.textBoxSqlStend.TextChanged += new System.EventHandler(this.textBoxSqlStend_TextChanged);
            // 
            // btnRunSqlStend
            // 
            this.btnRunSqlStend.Location = new System.Drawing.Point(572, 179);
            this.btnRunSqlStend.Name = "btnRunSqlStend";
            this.btnRunSqlStend.Size = new System.Drawing.Size(57, 23);
            this.btnRunSqlStend.TabIndex = 13;
            this.btnRunSqlStend.Text = "Run sql";
            this.btnRunSqlStend.UseVisualStyleBackColor = true;
            this.btnRunSqlStend.Click += new System.EventHandler(this.btnRunSqlStend_Click);
            // 
            // btnRunSqlProd
            // 
            this.btnRunSqlProd.Location = new System.Drawing.Point(572, 217);
            this.btnRunSqlProd.Name = "btnRunSqlProd";
            this.btnRunSqlProd.Size = new System.Drawing.Size(57, 23);
            this.btnRunSqlProd.TabIndex = 16;
            this.btnRunSqlProd.Text = "Run sql";
            this.btnRunSqlProd.UseVisualStyleBackColor = true;
            this.btnRunSqlProd.Click += new System.EventHandler(this.btnRunSqlProd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "sql";
            // 
            // btnConnectProd
            // 
            this.btnConnectProd.Location = new System.Drawing.Point(2, 216);
            this.btnConnectProd.Name = "btnConnectProd";
            this.btnConnectProd.Size = new System.Drawing.Size(125, 23);
            this.btnConnectProd.TabIndex = 14;
            this.btnConnectProd.Text = "Connect to BD Prod";
            this.btnConnectProd.UseVisualStyleBackColor = false;
            this.btnConnectProd.Click += new System.EventHandler(this.btnConnectProd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 309);
            this.Controls.Add(this.btnRunSqlProd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConnectProd);
            this.Controls.Add(this.btnRunSqlStend);
            this.Controls.Add(this.textBoxSqlStend);
            this.Controls.Add(this.btnConnectStend);
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
        private System.Windows.Forms.Button btnConnectStend;
        private System.Windows.Forms.TextBox textBoxSqlStend;
        private System.Windows.Forms.Button btnRunSqlStend;
        private System.Windows.Forms.Button btnRunSqlProd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConnectProd;
    }
}

