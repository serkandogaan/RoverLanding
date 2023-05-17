namespace HBTST.UI
{
    partial class WordlAreaManagment
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
            this.buttonWorldAdd = new System.Windows.Forms.Button();
            this.buttonWorldDelete = new System.Windows.Forms.Button();
            this.dataGridViewWorld = new System.Windows.Forms.DataGridView();
            this.customWorldName = new HBTST.UI.Components.CustomTextBox();
            this.pagination1 = new HBTST.UI.Components.Pagination();
            this.textBoxWorldAreaX = new HBTST.UI.Components.CustomTextBox();
            this.textBoxWorldAreaY = new HBTST.UI.Components.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWorldAdd
            // 
            this.buttonWorldAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonWorldAdd.Location = new System.Drawing.Point(146, 12);
            this.buttonWorldAdd.Name = "buttonWorldAdd";
            this.buttonWorldAdd.Size = new System.Drawing.Size(140, 62);
            this.buttonWorldAdd.TabIndex = 1;
            this.buttonWorldAdd.Text = "World Add";
            this.buttonWorldAdd.UseVisualStyleBackColor = true;
            this.buttonWorldAdd.Click += new System.EventHandler(this.buttonWorldAdd_Click);
            // 
            // buttonWorldDelete
            // 
            this.buttonWorldDelete.Enabled = false;
            this.buttonWorldDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonWorldDelete.Location = new System.Drawing.Point(146, 80);
            this.buttonWorldDelete.Name = "buttonWorldDelete";
            this.buttonWorldDelete.Size = new System.Drawing.Size(140, 55);
            this.buttonWorldDelete.TabIndex = 4;
            this.buttonWorldDelete.Text = "Delete Selected Rover Area";
            this.buttonWorldDelete.UseVisualStyleBackColor = true;
            this.buttonWorldDelete.Click += new System.EventHandler(this.buttonWorldDelete_Click);
            // 
            // dataGridViewWorld
            // 
            this.dataGridViewWorld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorld.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewWorld.Name = "dataGridViewWorld";
            this.dataGridViewWorld.Size = new System.Drawing.Size(462, 253);
            this.dataGridViewWorld.TabIndex = 8;
            this.dataGridViewWorld.SelectionChanged += new System.EventHandler(this.dataGridViewWorld_SelectionChanged);
            // 
            // customWorldName
            // 
            this.customWorldName.ForeColor = System.Drawing.Color.Gray;
            this.customWorldName.Location = new System.Drawing.Point(12, 100);
            this.customWorldName.Multiline = true;
            this.customWorldName.Name = "customWorldName";
            this.customWorldName.OnlyNumber = false;
            this.customWorldName.Placeholder = "Dünya Alanı Adı";
            this.customWorldName.Size = new System.Drawing.Size(128, 35);
            this.customWorldName.TabIndex = 10;
            this.customWorldName.Text = "Dünya Alanı Adı";
            // 
            // pagination1
            // 
            this.pagination1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pagination1.Location = new System.Drawing.Point(12, 410);
            this.pagination1.Name = "pagination1";
            this.pagination1.PageNumber = 0;
            this.pagination1.Size = new System.Drawing.Size(462, 82);
            this.pagination1.TabIndex = 9;
            this.pagination1.NextPage += new HBTST.UI.Components.ButtonNext(this.Gets);
            this.pagination1.PrevPage += new HBTST.UI.Components.ButtonPrev(this.Gets);
            this.pagination1.Load += new System.EventHandler(this.pagination1_Load);
            // 
            // textBoxWorldAreaX
            // 
            this.textBoxWorldAreaX.ForeColor = System.Drawing.Color.Gray;
            this.textBoxWorldAreaX.Location = new System.Drawing.Point(12, 12);
            this.textBoxWorldAreaX.Multiline = true;
            this.textBoxWorldAreaX.Name = "textBoxWorldAreaX";
            this.textBoxWorldAreaX.OnlyNumber = true;
            this.textBoxWorldAreaX.Placeholder = "Dünya Alanı X Boyutu";
            this.textBoxWorldAreaX.Size = new System.Drawing.Size(128, 35);
            this.textBoxWorldAreaX.TabIndex = 7;
            this.textBoxWorldAreaX.Text = "Dünya Alanı X Boyutu";
            // 
            // textBoxWorldAreaY
            // 
            this.textBoxWorldAreaY.ForeColor = System.Drawing.Color.Gray;
            this.textBoxWorldAreaY.Location = new System.Drawing.Point(12, 59);
            this.textBoxWorldAreaY.Multiline = true;
            this.textBoxWorldAreaY.Name = "textBoxWorldAreaY";
            this.textBoxWorldAreaY.OnlyNumber = true;
            this.textBoxWorldAreaY.Placeholder = "Dünya Alanı Y Boyutu";
            this.textBoxWorldAreaY.Size = new System.Drawing.Size(128, 35);
            this.textBoxWorldAreaY.TabIndex = 6;
            this.textBoxWorldAreaY.Text = "Dünya Alanı Y Boyutu";
            // 
            // WordlAreaManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 503);
            this.Controls.Add(this.customWorldName);
            this.Controls.Add(this.pagination1);
            this.Controls.Add(this.dataGridViewWorld);
            this.Controls.Add(this.textBoxWorldAreaX);
            this.Controls.Add(this.textBoxWorldAreaY);
            this.Controls.Add(this.buttonWorldDelete);
            this.Controls.Add(this.buttonWorldAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WordlAreaManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordlAreaManagment";
            this.Load += new System.EventHandler(this.WordlAreaManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWorldAdd;
        private System.Windows.Forms.Button buttonWorldDelete;
        private Components.CustomTextBox textBoxWorldAreaY;
        private Components.CustomTextBox textBoxWorldAreaX;
        private System.Windows.Forms.DataGridView dataGridViewWorld;
        private Components.Pagination pagination1;
        private Components.CustomTextBox customWorldName;
    }
}