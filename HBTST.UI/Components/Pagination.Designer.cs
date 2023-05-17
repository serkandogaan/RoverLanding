namespace HBTST.UI.Components
{
    partial class Pagination
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.customPaginationPageNumber = new System.Windows.Forms.Label();
            this.customPaginationTotalPageNumber = new System.Windows.Forms.Label();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPrevPage.Enabled = false;
            this.buttonPrevPage.Location = new System.Drawing.Point(3, 17);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(121, 40);
            this.buttonPrevPage.TabIndex = 0;
            this.buttonPrevPage.Text = "<";
            this.buttonPrevPage.UseVisualStyleBackColor = false;
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // customPaginationPageNumber
            // 
            this.customPaginationPageNumber.AutoSize = true;
            this.customPaginationPageNumber.Location = new System.Drawing.Point(130, 31);
            this.customPaginationPageNumber.Name = "customPaginationPageNumber";
            this.customPaginationPageNumber.Size = new System.Drawing.Size(13, 13);
            this.customPaginationPageNumber.TabIndex = 1;
            this.customPaginationPageNumber.Text = "1";
            // 
            // customPaginationTotalPageNumber
            // 
            this.customPaginationTotalPageNumber.AutoSize = true;
            this.customPaginationTotalPageNumber.Location = new System.Drawing.Point(171, 31);
            this.customPaginationTotalPageNumber.Name = "customPaginationTotalPageNumber";
            this.customPaginationTotalPageNumber.Size = new System.Drawing.Size(13, 13);
            this.customPaginationTotalPageNumber.TabIndex = 2;
            this.customPaginationTotalPageNumber.Text = "1";
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNextPage.Location = new System.Drawing.Point(212, 17);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(121, 40);
            this.buttonNextPage.TabIndex = 3;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.UseVisualStyleBackColor = false;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // Pagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.customPaginationTotalPageNumber);
            this.Controls.Add(this.customPaginationPageNumber);
            this.Controls.Add(this.buttonPrevPage);
            this.Name = "Pagination";
            this.Size = new System.Drawing.Size(339, 82);
            this.Load += new System.EventHandler(this.Pagination_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonPrevPage;
        public System.Windows.Forms.Label customPaginationPageNumber;
        public System.Windows.Forms.Label customPaginationTotalPageNumber;
        public System.Windows.Forms.Button buttonNextPage;
    }
}
