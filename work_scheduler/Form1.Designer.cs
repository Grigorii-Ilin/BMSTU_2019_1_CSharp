namespace work_scheduler {
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
            this.dgvScheduleViewer = new System.Windows.Forms.DataGridView();
            this.paFilter = new System.Windows.Forms.Panel();
            this.rbBeforeDate = new System.Windows.Forms.RadioButton();
            this.rbWithoutTime = new System.Windows.Forms.RadioButton();
            this.rbOnlyWithTime = new System.Windows.Forms.RadioButton();
            this.rbOnlyEnded = new System.Windows.Forms.RadioButton();
            this.rbOnlyUnended = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.paSorting = new System.Windows.Forms.Panel();
            this.rbControlDateSorting = new System.Windows.Forms.RadioButton();
            this.rbAlphabetSorting = new System.Windows.Forms.RadioButton();
            this.rbWithoutSorting = new System.Windows.Forms.RadioButton();
            this.btSave = new System.Windows.Forms.Button();
            this.dtpDateSelector = new System.Windows.Forms.DateTimePicker();
            this.toDoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoWorkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toDoWorkingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleViewer)).BeginInit();
            this.paFilter.SuspendLayout();
            this.paSorting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDoItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoWorkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoWorkingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScheduleViewer
            // 
            this.dgvScheduleViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduleViewer.Location = new System.Drawing.Point(38, 26);
            this.dgvScheduleViewer.Name = "dgvScheduleViewer";
            this.dgvScheduleViewer.Size = new System.Drawing.Size(725, 256);
            this.dgvScheduleViewer.TabIndex = 0;
            // 
            // paFilter
            // 
            this.paFilter.Controls.Add(this.rbBeforeDate);
            this.paFilter.Controls.Add(this.rbWithoutTime);
            this.paFilter.Controls.Add(this.rbOnlyWithTime);
            this.paFilter.Controls.Add(this.rbOnlyEnded);
            this.paFilter.Controls.Add(this.rbOnlyUnended);
            this.paFilter.Controls.Add(this.rbShowAll);
            this.paFilter.Location = new System.Drawing.Point(38, 303);
            this.paFilter.Name = "paFilter";
            this.paFilter.Size = new System.Drawing.Size(183, 153);
            this.paFilter.TabIndex = 1;
            // 
            // rbBeforeDate
            // 
            this.rbBeforeDate.AutoSize = true;
            this.rbBeforeDate.Location = new System.Drawing.Point(14, 130);
            this.rbBeforeDate.Name = "rbBeforeDate";
            this.rbBeforeDate.Size = new System.Drawing.Size(104, 17);
            this.rbBeforeDate.TabIndex = 5;
            this.rbBeforeDate.Tag = "15";
            this.rbBeforeDate.Text = "Задачи до даты";
            this.rbBeforeDate.UseVisualStyleBackColor = true;
            this.rbBeforeDate.CheckedChanged += new System.EventHandler(this.rbBeforeDate_CheckedChanged);
            // 
            // rbWithoutTime
            // 
            this.rbWithoutTime.AutoSize = true;
            this.rbWithoutTime.Location = new System.Drawing.Point(14, 108);
            this.rbWithoutTime.Name = "rbWithoutTime";
            this.rbWithoutTime.Size = new System.Drawing.Size(115, 17);
            this.rbWithoutTime.TabIndex = 4;
            this.rbWithoutTime.Tag = "14";
            this.rbWithoutTime.Text = "Задачи без срока";
            this.rbWithoutTime.UseVisualStyleBackColor = true;
            this.rbWithoutTime.CheckedChanged += new System.EventHandler(this.rbWithoutTime_CheckedChanged);
            // 
            // rbOnlyWithTime
            // 
            this.rbOnlyWithTime.AutoSize = true;
            this.rbOnlyWithTime.Location = new System.Drawing.Point(14, 85);
            this.rbOnlyWithTime.Name = "rbOnlyWithTime";
            this.rbOnlyWithTime.Size = new System.Drawing.Size(118, 17);
            this.rbOnlyWithTime.TabIndex = 3;
            this.rbOnlyWithTime.Tag = "13";
            this.rbOnlyWithTime.Text = "Только со сроком";
            this.rbOnlyWithTime.UseVisualStyleBackColor = true;
            this.rbOnlyWithTime.CheckedChanged += new System.EventHandler(this.rbOnlyWithTime_CheckedChanged);
            // 
            // rbOnlyEnded
            // 
            this.rbOnlyEnded.AutoSize = true;
            this.rbOnlyEnded.Location = new System.Drawing.Point(14, 62);
            this.rbOnlyEnded.Name = "rbOnlyEnded";
            this.rbOnlyEnded.Size = new System.Drawing.Size(135, 17);
            this.rbOnlyEnded.TabIndex = 2;
            this.rbOnlyEnded.Tag = "12";
            this.rbOnlyEnded.Text = "Только завершенные";
            this.rbOnlyEnded.UseVisualStyleBackColor = true;
            this.rbOnlyEnded.CheckedChanged += new System.EventHandler(this.rbOnlyEnded_CheckedChanged);
            // 
            // rbOnlyUnended
            // 
            this.rbOnlyUnended.AutoSize = true;
            this.rbOnlyUnended.Location = new System.Drawing.Point(14, 39);
            this.rbOnlyUnended.Name = "rbOnlyUnended";
            this.rbOnlyUnended.Size = new System.Drawing.Size(147, 17);
            this.rbOnlyUnended.TabIndex = 1;
            this.rbOnlyUnended.Tag = "11";
            this.rbOnlyUnended.Text = "Только незавершенные";
            this.rbOnlyUnended.UseVisualStyleBackColor = true;
            this.rbOnlyUnended.CheckedChanged += new System.EventHandler(this.rbOnlyUnended_CheckedChanged);
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Checked = true;
            this.rbShowAll.Location = new System.Drawing.Point(14, 16);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(109, 17);
            this.rbShowAll.TabIndex = 0;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Tag = "10";
            this.rbShowAll.Text = "Показывать всё";
            this.rbShowAll.UseVisualStyleBackColor = true;
            this.rbShowAll.CheckedChanged += new System.EventHandler(this.rbShowAll_CheckedChanged);
            // 
            // paSorting
            // 
            this.paSorting.Controls.Add(this.rbControlDateSorting);
            this.paSorting.Controls.Add(this.rbAlphabetSorting);
            this.paSorting.Controls.Add(this.rbWithoutSorting);
            this.paSorting.Location = new System.Drawing.Point(249, 303);
            this.paSorting.Name = "paSorting";
            this.paSorting.Size = new System.Drawing.Size(156, 153);
            this.paSorting.TabIndex = 3;
            // 
            // rbControlDateSorting
            // 
            this.rbControlDateSorting.AutoSize = true;
            this.rbControlDateSorting.Location = new System.Drawing.Point(14, 62);
            this.rbControlDateSorting.Name = "rbControlDateSorting";
            this.rbControlDateSorting.Size = new System.Drawing.Size(134, 17);
            this.rbControlDateSorting.TabIndex = 2;
            this.rbControlDateSorting.Tag = "22";
            this.rbControlDateSorting.Text = "По сроку исполнения";
            this.rbControlDateSorting.UseVisualStyleBackColor = true;
            this.rbControlDateSorting.CheckedChanged += new System.EventHandler(this.rbControlDateSorting_CheckedChanged);
            // 
            // rbAlphabetSorting
            // 
            this.rbAlphabetSorting.AutoSize = true;
            this.rbAlphabetSorting.Location = new System.Drawing.Point(14, 39);
            this.rbAlphabetSorting.Name = "rbAlphabetSorting";
            this.rbAlphabetSorting.Size = new System.Drawing.Size(90, 17);
            this.rbAlphabetSorting.TabIndex = 1;
            this.rbAlphabetSorting.Tag = "21";
            this.rbAlphabetSorting.Text = "По алфавиту";
            this.rbAlphabetSorting.UseVisualStyleBackColor = true;
            this.rbAlphabetSorting.CheckedChanged += new System.EventHandler(this.rbAlphabetSorting_CheckedChanged);
            // 
            // rbWithoutSorting
            // 
            this.rbWithoutSorting.AutoSize = true;
            this.rbWithoutSorting.Checked = true;
            this.rbWithoutSorting.Location = new System.Drawing.Point(14, 16);
            this.rbWithoutSorting.Name = "rbWithoutSorting";
            this.rbWithoutSorting.Size = new System.Drawing.Size(106, 17);
            this.rbWithoutSorting.TabIndex = 0;
            this.rbWithoutSorting.TabStop = true;
            this.rbWithoutSorting.Tag = "20";
            this.rbWithoutSorting.Text = "Не сортировать";
            this.rbWithoutSorting.UseVisualStyleBackColor = true;
            this.rbWithoutSorting.CheckedChanged += new System.EventHandler(this.rbWithoutSorting_CheckedChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(428, 359);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(118, 23);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dtpDateSelector
            // 
            this.dtpDateSelector.Location = new System.Drawing.Point(411, 315);
            this.dtpDateSelector.Name = "dtpDateSelector";
            this.dtpDateSelector.Size = new System.Drawing.Size(200, 20);
            this.dtpDateSelector.TabIndex = 5;
            this.dtpDateSelector.Enter += new System.EventHandler(this.dtpDateSelector_Enter);
            // 
            // toDoItemBindingSource
            // 
            this.toDoItemBindingSource.DataSource = typeof(work_scheduler.ToDoItem);
            // 
            // toDoWorkingBindingSource
            // 
            this.toDoWorkingBindingSource.DataSource = typeof(work_scheduler.ToDoWorking);
            // 
            // toDoWorkingBindingSource1
            // 
            this.toDoWorkingBindingSource1.DataSource = typeof(work_scheduler.ToDoWorking);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 462);
            this.Controls.Add(this.dtpDateSelector);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.paSorting);
            this.Controls.Add(this.paFilter);
            this.Controls.Add(this.dgvScheduleViewer);
            this.Name = "Form1";
            this.Text = "Планировщик 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleViewer)).EndInit();
            this.paFilter.ResumeLayout(false);
            this.paFilter.PerformLayout();
            this.paSorting.ResumeLayout(false);
            this.paSorting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDoItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoWorkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDoWorkingBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScheduleViewer;
        private System.Windows.Forms.Panel paFilter;
        private System.Windows.Forms.RadioButton rbOnlyEnded;
        private System.Windows.Forms.RadioButton rbOnlyUnended;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbWithoutTime;
        private System.Windows.Forms.RadioButton rbOnlyWithTime;
        private System.Windows.Forms.RadioButton rbBeforeDate;
        private System.Windows.Forms.Panel paSorting;
        private System.Windows.Forms.RadioButton rbControlDateSorting;
        private System.Windows.Forms.RadioButton rbAlphabetSorting;
        private System.Windows.Forms.RadioButton rbWithoutSorting;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dtpDateSelector;
        private System.Windows.Forms.BindingSource toDoItemBindingSource;
        private System.Windows.Forms.BindingSource toDoWorkingBindingSource;
        private System.Windows.Forms.BindingSource toDoWorkingBindingSource1;
    }
}

