
namespace MediaBazaarProject.Presentation
{
    partial class CategoriesForm
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
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.lblExistingCategories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(30, 86);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(125, 27);
            this.tbCategoryName.TabIndex = 0;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(30, 140);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(125, 29);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Add category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 20;
            this.lbCategories.Location = new System.Drawing.Point(207, 35);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(271, 184);
            this.lbCategories.TabIndex = 2;
            // 
            // lblExistingCategories
            // 
            this.lblExistingCategories.AutoSize = true;
            this.lblExistingCategories.Location = new System.Drawing.Point(207, 13);
            this.lblExistingCategories.Name = "lblExistingCategories";
            this.lblExistingCategories.Size = new System.Drawing.Size(133, 20);
            this.lblExistingCategories.TabIndex = 3;
            this.lblExistingCategories.Text = "Existing categories";
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 251);
            this.Controls.Add(this.lblExistingCategories);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.tbCategoryName);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.Label lblExistingCategories;
    }
}