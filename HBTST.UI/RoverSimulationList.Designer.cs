namespace HBTST.UI
{
    partial class RoverSimulationList
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
            this.customTextBoxRoverName = new HBTST.UI.Components.CustomTextBox();
            this.customTextBoxAreaName = new HBTST.UI.Components.CustomTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customTextBoxRoverName
            // 
            this.customTextBoxRoverName.ForeColor = System.Drawing.Color.Gray;
            this.customTextBoxRoverName.Location = new System.Drawing.Point(12, 21);
            this.customTextBoxRoverName.Multiline = true;
            this.customTextBoxRoverName.Name = "customTextBoxRoverName";
            this.customTextBoxRoverName.OnlyNumber = false;
            this.customTextBoxRoverName.Placeholder = "Rover Name";
            this.customTextBoxRoverName.Size = new System.Drawing.Size(141, 30);
            this.customTextBoxRoverName.TabIndex = 0;
            this.customTextBoxRoverName.Text = "Rover Name";
            // 
            // customTextBoxAreaName
            // 
            this.customTextBoxAreaName.ForeColor = System.Drawing.Color.Gray;
            this.customTextBoxAreaName.Location = new System.Drawing.Point(159, 21);
            this.customTextBoxAreaName.Multiline = true;
            this.customTextBoxAreaName.Name = "customTextBoxAreaName";
            this.customTextBoxAreaName.OnlyNumber = false;
            this.customTextBoxAreaName.Placeholder = "Area Name";
            this.customTextBoxAreaName.Size = new System.Drawing.Size(141, 30);
            this.customTextBoxAreaName.TabIndex = 1;
            this.customTextBoxAreaName.Text = "Area Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 201);
            this.dataGridView1.TabIndex = 2;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(306, 31);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(512, 31);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 5;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStart.Location = new System.Drawing.Point(368, 9);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(72, 18);
            this.labelStart.TabIndex = 6;
            this.labelStart.Text = "Başlangıç";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEnd.Location = new System.Drawing.Point(583, 9);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(36, 18);
            this.labelEnd.TabIndex = 7;
            this.labelEnd.Text = "Bitiş";
            // 
            // RoverSimulationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customTextBoxAreaName);
            this.Controls.Add(this.customTextBoxRoverName);
            this.Name = "RoverSimulationList";
            this.Text = "RoverSimulationList";
            this.Load += new System.EventHandler(this.RoverSimulationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.CustomTextBox customTextBoxRoverName;
        private Components.CustomTextBox customTextBoxAreaName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
    }
}