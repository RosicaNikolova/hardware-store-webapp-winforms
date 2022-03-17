
namespace MediaBazaarProject
{
    partial class WorkerForm
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
            this.lbxShiftEmployeeDay = new System.Windows.Forms.ListBox();
            this.lblshift = new System.Windows.Forms.Label();
            this.dateWorker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbxShiftEmployeeDay
            // 
            this.lbxShiftEmployeeDay.FormattingEnabled = true;
            this.lbxShiftEmployeeDay.ItemHeight = 20;
            this.lbxShiftEmployeeDay.Location = new System.Drawing.Point(316, 147);
            this.lbxShiftEmployeeDay.Name = "lbxShiftEmployeeDay";
            this.lbxShiftEmployeeDay.Size = new System.Drawing.Size(189, 124);
            this.lbxShiftEmployeeDay.TabIndex = 12;
            // 
            // lblshift
            // 
            this.lblshift.AutoSize = true;
            this.lblshift.Location = new System.Drawing.Point(343, 98);
            this.lblshift.Name = "lblshift";
            this.lblshift.Size = new System.Drawing.Size(130, 20);
            this.lblshift.TabIndex = 9;
            this.lblshift.Text = "Shifts for the date:";
            // 
            // dateWorker
            // 
            this.dateWorker.Location = new System.Drawing.Point(280, 34);
            this.dateWorker.MaxDate = new System.DateTime(2022, 3, 22, 0, 0, 0, 0);
            this.dateWorker.MinDate = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.dateWorker.Name = "dateWorker";
            this.dateWorker.Size = new System.Drawing.Size(255, 27);
            this.dateWorker.TabIndex = 8;
            this.dateWorker.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.dateWorker.ValueChanged += new System.EventHandler(this.dateWorker_ValueChanged);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxShiftEmployeeDay);
            this.Controls.Add(this.lblshift);
            this.Controls.Add(this.dateWorker);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxShiftEmployeeDay;
        private System.Windows.Forms.Label lblshift;
        private System.Windows.Forms.DateTimePicker dateWorker;
    }
}