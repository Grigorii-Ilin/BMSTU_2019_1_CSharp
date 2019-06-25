namespace file_events {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnShowSelectPath = new System.Windows.Forms.Button();
            this.cmbFolders = new System.Windows.Forms.ComboBox();
            this.btnAddSubscriber = new System.Windows.Forms.Button();
            this.btnDelSubscriber = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.SelectedPath = "C:\\MY_DOC_HP\\BMSTU\\2019_1\\CSharp\\BMSTU_2019_1_CSharp\\file_events\\myexample";
            // 
            // btnShowSelectPath
            // 
            this.btnShowSelectPath.Location = new System.Drawing.Point(42, 29);
            this.btnShowSelectPath.Name = "btnShowSelectPath";
            this.btnShowSelectPath.Size = new System.Drawing.Size(132, 23);
            this.btnShowSelectPath.TabIndex = 0;
            this.btnShowSelectPath.Text = "Выбрать папку";
            this.btnShowSelectPath.UseVisualStyleBackColor = true;
            this.btnShowSelectPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFolders
            // 
            this.cmbFolders.FormattingEnabled = true;
            this.cmbFolders.Location = new System.Drawing.Point(42, 91);
            this.cmbFolders.Name = "cmbFolders";
            this.cmbFolders.Size = new System.Drawing.Size(725, 21);
            this.cmbFolders.TabIndex = 1;
            // 
            // btnAddSubscriber
            // 
            this.btnAddSubscriber.Location = new System.Drawing.Point(42, 148);
            this.btnAddSubscriber.Name = "btnAddSubscriber";
            this.btnAddSubscriber.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubscriber.TabIndex = 2;
            this.btnAddSubscriber.Text = "Добавить подписчика";
            this.btnAddSubscriber.UseVisualStyleBackColor = true;
            this.btnAddSubscriber.Click += new System.EventHandler(this.btnAddSubscriber_Click);
            // 
            // btnDelSubscriber
            // 
            this.btnDelSubscriber.Location = new System.Drawing.Point(158, 148);
            this.btnDelSubscriber.Name = "btnDelSubscriber";
            this.btnDelSubscriber.Size = new System.Drawing.Size(75, 23);
            this.btnDelSubscriber.TabIndex = 3;
            this.btnDelSubscriber.Text = "Удалить подписчика";
            this.btnDelSubscriber.UseVisualStyleBackColor = true;
            this.btnDelSubscriber.Click += new System.EventHandler(this.btnDelSubscriber_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelSubscriber);
            this.Controls.Add(this.btnAddSubscriber);
            this.Controls.Add(this.cmbFolders);
            this.Controls.Add(this.btnShowSelectPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnShowSelectPath;
        private System.Windows.Forms.ComboBox cmbFolders;
        private System.Windows.Forms.Button btnAddSubscriber;
        private System.Windows.Forms.Button btnDelSubscriber;
        private System.Windows.Forms.Timer timer;
    }
}

