namespace HBTST.UI
{
    partial class RoverUI
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
            this.buttonRoverAdd = new System.Windows.Forms.Button();
            this.buttonRoverDelete = new System.Windows.Forms.Button();
            this.dataGridViewRoverList = new System.Windows.Forms.DataGridView();
            this.RoverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoverLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxWorldAreaX = new HBTST.UI.Components.CustomTextBox();
            this.textBoxWorldAreaY = new HBTST.UI.Components.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoverList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRoverAdd
            // 
            this.buttonRoverAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRoverAdd.Location = new System.Drawing.Point(25, 22);
            this.buttonRoverAdd.Name = "buttonRoverAdd";
            this.buttonRoverAdd.Size = new System.Drawing.Size(140, 51);
            this.buttonRoverAdd.TabIndex = 0;
            this.buttonRoverAdd.Text = "Rover Add";
            this.buttonRoverAdd.UseVisualStyleBackColor = true;
            this.buttonRoverAdd.Click += new System.EventHandler(this.buttonRoverAdd_Click);
            // 
            // buttonRoverDelete
            // 
            this.buttonRoverDelete.Enabled = false;
            this.buttonRoverDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRoverDelete.Location = new System.Drawing.Point(191, 22);
            this.buttonRoverDelete.Name = "buttonRoverDelete";
            this.buttonRoverDelete.Size = new System.Drawing.Size(182, 51);
            this.buttonRoverDelete.TabIndex = 3;
            this.buttonRoverDelete.Text = "Delete Selected Rover";
            this.buttonRoverDelete.UseVisualStyleBackColor = true;
            this.buttonRoverDelete.Click += new System.EventHandler(this.buttonRoverDelete_Click);
            // 
            // dataGridViewRoverList
            // 
            this.dataGridViewRoverList.AllowUserToAddRows = false;
            this.dataGridViewRoverList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewRoverList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoverList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoverID,
            this.RoverLocation,
            this.RoverName});
            this.dataGridViewRoverList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewRoverList.Location = new System.Drawing.Point(25, 116);
            this.dataGridViewRoverList.Name = "dataGridViewRoverList";
            this.dataGridViewRoverList.ReadOnly = true;
            this.dataGridViewRoverList.Size = new System.Drawing.Size(685, 148);
            this.dataGridViewRoverList.TabIndex = 0;
            this.dataGridViewRoverList.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // RoverID
            // 
            this.RoverID.HeaderText = "RoverID";
            this.RoverID.Name = "RoverID";
            this.RoverID.ReadOnly = true;
            this.RoverID.Width = 205;
            // 
            // RoverLocation
            // 
            this.RoverLocation.HeaderText = "RoverLocation";
            this.RoverLocation.Name = "RoverLocation";
            this.RoverLocation.ReadOnly = true;
            this.RoverLocation.Width = 205;
            // 
            // RoverName
            // 
            this.RoverName.HeaderText = "RoverName";
            this.RoverName.Name = "RoverName";
            this.RoverName.ReadOnly = true;
            this.RoverName.Width = 205;
            // 
            // textBoxWorldAreaX
            // 
            this.textBoxWorldAreaX.ForeColor = System.Drawing.Color.Gray;
            this.textBoxWorldAreaX.Location = new System.Drawing.Point(392, 22);
            this.textBoxWorldAreaX.Multiline = true;
            this.textBoxWorldAreaX.Name = "textBoxWorldAreaX";
            this.textBoxWorldAreaX.OnlyNumber = true;
            this.textBoxWorldAreaX.Placeholder = "Dünya Alanı X Boyutu";
            this.textBoxWorldAreaX.Size = new System.Drawing.Size(128, 35);
            this.textBoxWorldAreaX.TabIndex = 4;
            this.textBoxWorldAreaX.Text = "Dünya Alanı X Boyutu";
            // 
            // textBoxWorldAreaY
            // 
            this.textBoxWorldAreaY.ForeColor = System.Drawing.Color.Gray;
            this.textBoxWorldAreaY.Location = new System.Drawing.Point(582, 22);
            this.textBoxWorldAreaY.Multiline = true;
            this.textBoxWorldAreaY.Name = "textBoxWorldAreaY";
            this.textBoxWorldAreaY.OnlyNumber = true;
            this.textBoxWorldAreaY.Placeholder = "Dünya Alanı Y Boyutu";
            this.textBoxWorldAreaY.Size = new System.Drawing.Size(128, 35);
            this.textBoxWorldAreaY.TabIndex = 5;
            this.textBoxWorldAreaY.Text = "Dünya Alanı Y Boyutu";
            // 
            // RoverUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 337);
            this.Controls.Add(this.textBoxWorldAreaY);
            this.Controls.Add(this.textBoxWorldAreaX);
            this.Controls.Add(this.dataGridViewRoverList);
            this.Controls.Add(this.buttonRoverDelete);
            this.Controls.Add(this.buttonRoverAdd);
            this.Name = "RoverUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rover";
            this.Load += new System.EventHandler(this.RoverUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoverList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRoverAdd;
        private System.Windows.Forms.Button buttonRoverDelete;
        public System.Windows.Forms.DataGridView dataGridViewRoverList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoverLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoverName;
        private Components.CustomTextBox textBoxWorldAreaX;
        private Components.CustomTextBox textBoxWorldAreaY;
    }
}