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
            this.dgvScheduleViewer = new System.Windows.Forms.DataGridView();
            this.paEndedAndNotEndedFilter = new System.Windows.Forms.Panel();
            this.rbWithoutTime = new System.Windows.Forms.RadioButton();
            this.rbOnlyWithTime = new System.Windows.Forms.RadioButton();
            this.rbOnlyEnded = new System.Windows.Forms.RadioButton();
            this.rbOnlyUnended = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.rbBeforeDate = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleViewer)).BeginInit();
            this.paEndedAndNotEndedFilter.SuspendLayout();
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
            // paEndedAndNotEndedFilter
            // 
            this.paEndedAndNotEndedFilter.Controls.Add(this.rbBeforeDate);
            this.paEndedAndNotEndedFilter.Controls.Add(this.rbWithoutTime);
            this.paEndedAndNotEndedFilter.Controls.Add(this.rbOnlyWithTime);
            this.paEndedAndNotEndedFilter.Controls.Add(this.rbOnlyEnded);
            this.paEndedAndNotEndedFilter.Controls.Add(this.rbOnlyUnended);
            this.paEndedAndNotEndedFilter.Controls.Add(this.rbShowAll);
            this.paEndedAndNotEndedFilter.Location = new System.Drawing.Point(38, 303);
            this.paEndedAndNotEndedFilter.Name = "paEndedAndNotEndedFilter";
            this.paEndedAndNotEndedFilter.Size = new System.Drawing.Size(202, 153);
            this.paEndedAndNotEndedFilter.TabIndex = 1;
            // 
            // rbWithoutTime
            // 
            this.rbWithoutTime.AutoSize = true;
            this.rbWithoutTime.Location = new System.Drawing.Point(14, 108);
            this.rbWithoutTime.Name = "rbWithoutTime";
            this.rbWithoutTime.Size = new System.Drawing.Size(115, 17);
            this.rbWithoutTime.TabIndex = 4;
            this.rbWithoutTime.Text = "Задачи без срока";
            this.rbWithoutTime.UseVisualStyleBackColor = true;
            // 
            // rbOnlyWithTime
            // 
            this.rbOnlyWithTime.AutoSize = true;
            this.rbOnlyWithTime.Location = new System.Drawing.Point(14, 85);
            this.rbOnlyWithTime.Name = "rbOnlyWithTime";
            this.rbOnlyWithTime.Size = new System.Drawing.Size(118, 17);
            this.rbOnlyWithTime.TabIndex = 3;
            this.rbOnlyWithTime.Text = "Только со сроком";
            this.rbOnlyWithTime.UseVisualStyleBackColor = true;
            // 
            // rbOnlyEnded
            // 
            this.rbOnlyEnded.AutoSize = true;
            this.rbOnlyEnded.Location = new System.Drawing.Point(14, 62);
            this.rbOnlyEnded.Name = "rbOnlyEnded";
            this.rbOnlyEnded.Size = new System.Drawing.Size(135, 17);
            this.rbOnlyEnded.TabIndex = 2;
            this.rbOnlyEnded.Text = "Только завершенные";
            this.rbOnlyEnded.UseVisualStyleBackColor = true;
            // 
            // rbOnlyUnended
            // 
            this.rbOnlyUnended.AutoSize = true;
            this.rbOnlyUnended.Location = new System.Drawing.Point(14, 39);
            this.rbOnlyUnended.Name = "rbOnlyUnended";
            this.rbOnlyUnended.Size = new System.Drawing.Size(147, 17);
            this.rbOnlyUnended.TabIndex = 1;
            this.rbOnlyUnended.Text = "Только незавершенные";
            this.rbOnlyUnended.UseVisualStyleBackColor = true;
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
            this.rbShowAll.Text = "Показывать всё";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(321, 294);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // rbBeforeDate
            // 
            this.rbBeforeDate.AutoSize = true;
            this.rbBeforeDate.Location = new System.Drawing.Point(14, 130);
            this.rbBeforeDate.Name = "rbBeforeDate";
            this.rbBeforeDate.Size = new System.Drawing.Size(104, 17);
            this.rbBeforeDate.TabIndex = 5;
            this.rbBeforeDate.Text = "Задачи до даты";
            this.rbBeforeDate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 462);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.paEndedAndNotEndedFilter);
            this.Controls.Add(this.dgvScheduleViewer);
            this.Name = "Form1";
            this.Text = "Планировщик 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduleViewer)).EndInit();
            this.paEndedAndNotEndedFilter.ResumeLayout(false);
            this.paEndedAndNotEndedFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScheduleViewer;
        private System.Windows.Forms.Panel paEndedAndNotEndedFilter;
        private System.Windows.Forms.RadioButton rbOnlyEnded;
        private System.Windows.Forms.RadioButton rbOnlyUnended;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbWithoutTime;
        private System.Windows.Forms.RadioButton rbOnlyWithTime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RadioButton rbBeforeDate;
    }
}

