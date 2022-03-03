
namespace DlaOksVideoConverter
{
    partial class btnConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnConvert));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lbxFileToConvert = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.dataGridFiles = new System.Windows.Forms.DataGridView();
            this.btnConverFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(0, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(0, 0);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 0;
            // 
            // lbxFileToConvert
            // 
            this.lbxFileToConvert.FormattingEnabled = true;
            this.lbxFileToConvert.Location = new System.Drawing.Point(28, 48);
            this.lbxFileToConvert.Name = "lbxFileToConvert";
            this.lbxFileToConvert.Size = new System.Drawing.Size(442, 186);
            this.lbxFileToConvert.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Files to convert:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Files to Convert";
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(15, 255);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(190, 35);
            this.btnSelectFiles.TabIndex = 3;
            this.btnSelectFiles.Text = "Select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // dataGridFiles
            // 
            this.dataGridFiles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiles.Location = new System.Drawing.Point(12, 31);
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.Size = new System.Drawing.Size(610, 200);
            this.dataGridFiles.TabIndex = 4;
            // 
            // btnConverFiles
            // 
            this.btnConverFiles.BackColor = System.Drawing.Color.Teal;
            this.btnConverFiles.Location = new System.Drawing.Point(501, 255);
            this.btnConverFiles.Name = "btnConverFiles";
            this.btnConverFiles.Size = new System.Drawing.Size(150, 34);
            this.btnConverFiles.TabIndex = 5;
            this.btnConverFiles.Text = "Convert";
            this.btnConverFiles.UseVisualStyleBackColor = false;
            this.btnConverFiles.Click += new System.EventHandler(this.btnConverFiles_Click);
            // 
            // btnConvert
            // 
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(681, 302);
            this.Controls.Add(this.btnConverFiles);
            this.Controls.Add(this.dataGridFiles);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnConvert";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.ListBox lbxFileToConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.DataGridView dataGridFiles;
        private System.Windows.Forms.Button btnConverFiles;
    }
}

