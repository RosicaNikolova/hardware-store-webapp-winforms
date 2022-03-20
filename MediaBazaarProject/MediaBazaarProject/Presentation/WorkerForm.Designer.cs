
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
            this.lbxShiftEmployeeDay.ItemHeight = 17;
            this.lbxShiftEmployeeDay.Location = new System.Drawing.Point(333, 158);
            this.lbxShiftEmployeeDay.Name = "lbxShiftEmployeeDay";
            this.lbxShiftEmployeeDay.Size = new System.Drawing.Size(212, 106);
            this.lbxShiftEmployeeDay.TabIndex = 12;
            // 
            // lblshift
            // 
            this.lblshift.AutoSize = true;
            this.lblshift.Location = new System.Drawing.Point(365, 106);
            this.lblshift.Name = "lblshift";
            this.lblshift.Size = new System.Drawing.Size(142, 17);
            this.lblshift.TabIndex = 9;
            this.lblshift.Text = "Shifts for the date:";
            // 
            // dateWorker
            // 
            this.dateWorker.Location = new System.Drawing.Point(294, 42);
            this.dateWorker.MaxDate = new System.DateTime(2022, 3, 22, 0, 0, 0, 0);
            this.dateWorker.MinDate = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.dateWorker.Name = "dateWorker";
            this.dateWorker.Size = new System.Drawing.Size(286, 25);
            this.dateWorker.TabIndex = 8;
            this.dateWorker.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.dateWorker.ValueChanged += new System.EventHandler(this.dateWorker_ValueChanged);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(900, 382);
            this.Controls.Add(this.lbxShiftEmployeeDay);
            this.Controls.Add(this.lblshift);
            this.Controls.Add(this.dateWorker);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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