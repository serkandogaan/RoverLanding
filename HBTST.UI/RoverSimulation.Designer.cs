namespace HBTST.UI
{
    partial class RoverSimulation
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
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoverAreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartingPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxArea = new System.Windows.Forms.ListBox();
            this.listBoxRover = new System.Windows.Forms.ListBox();
            this.buttonRoverAdd = new System.Windows.Forms.Button();
            this.listBoxRoverMoveCommand = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customTextBoxMoveCommand = new HBTST.UI.Components.CustomTextBox();
            this.customTextBoxY = new HBTST.UI.Components.CustomTextBox();
            this.customTextBoxX = new HBTST.UI.Components.CustomTextBox();
            this.customTextBox2 = new HBTST.UI.Components.CustomTextBox();
            this.customTextBox1 = new HBTST.UI.Components.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "N",
            "S",
            "W",
            "E"});
            this.comboBoxDirection.Location = new System.Drawing.Point(562, 12);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(138, 28);
            this.comboBoxDirection.TabIndex = 4;
            this.comboBoxDirection.Text = "Direction";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.RoverName,
            this.RoverAreaName,
            this.CreatedDate,
            this.StartingPosition,
            this.EndingPosition,
            this.Command});
            this.dataGridView1.Location = new System.Drawing.Point(418, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 191);
            this.dataGridView1.TabIndex = 6;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // RoverName
            // 
            this.RoverName.HeaderText = "RoverName";
            this.RoverName.Name = "RoverName";
            this.RoverName.ReadOnly = true;
            // 
            // RoverAreaName
            // 
            this.RoverAreaName.HeaderText = "RoverAreaName";
            this.RoverAreaName.Name = "RoverAreaName";
            this.RoverAreaName.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // StartingPosition
            // 
            this.StartingPosition.HeaderText = "StartingPosition";
            this.StartingPosition.Name = "StartingPosition";
            this.StartingPosition.ReadOnly = true;
            // 
            // EndingPosition
            // 
            this.EndingPosition.HeaderText = "EndingPosition";
            this.EndingPosition.Name = "EndingPosition";
            this.EndingPosition.ReadOnly = true;
            // 
            // Command
            // 
            this.Command.HeaderText = "Command";
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.Location = new System.Drawing.Point(650, 60);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 32);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxArea
            // 
            this.listBoxArea.FormattingEnabled = true;
            this.listBoxArea.Location = new System.Drawing.Point(12, 80);
            this.listBoxArea.Name = "listBoxArea";
            this.listBoxArea.Size = new System.Drawing.Size(147, 368);
            this.listBoxArea.TabIndex = 8;
            this.listBoxArea.SelectedIndexChanged += new System.EventHandler(this.listBoxArea_SelectedIndexChanged);
            // 
            // listBoxRover
            // 
            this.listBoxRover.FormattingEnabled = true;
            this.listBoxRover.Location = new System.Drawing.Point(190, 80);
            this.listBoxRover.Name = "listBoxRover";
            this.listBoxRover.Size = new System.Drawing.Size(147, 368);
            this.listBoxRover.TabIndex = 9;
            this.listBoxRover.SelectedIndexChanged += new System.EventHandler(this.listBoxRover_SelectedIndexChanged);
            // 
            // buttonRoverAdd
            // 
            this.buttonRoverAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRoverAdd.Location = new System.Drawing.Point(418, 213);
            this.buttonRoverAdd.Name = "buttonRoverAdd";
            this.buttonRoverAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonRoverAdd.TabIndex = 10;
            this.buttonRoverAdd.Text = "Listeye Ekle";
            this.buttonRoverAdd.UseVisualStyleBackColor = true;
            this.buttonRoverAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxRoverMoveCommand
            // 
            this.listBoxRoverMoveCommand.FormattingEnabled = true;
            this.listBoxRoverMoveCommand.Location = new System.Drawing.Point(418, 99);
            this.listBoxRoverMoveCommand.Name = "listBoxRoverMoveCommand";
            this.listBoxRoverMoveCommand.Size = new System.Drawing.Size(281, 108);
            this.listBoxRoverMoveCommand.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(529, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Listedeki Roverları Koş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(706, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Tüm Simülasyonlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customTextBoxMoveCommand
            // 
            this.customTextBoxMoveCommand.ForeColor = System.Drawing.Color.Gray;
            this.customTextBoxMoveCommand.Location = new System.Drawing.Point(419, 62);
            this.customTextBoxMoveCommand.Multiline = true;
            this.customTextBoxMoveCommand.Name = "customTextBoxMoveCommand";
            this.customTextBoxMoveCommand.OnlyNumber = false;
            this.customTextBoxMoveCommand.Placeholder = "Komut";
            this.customTextBoxMoveCommand.Size = new System.Drawing.Size(225, 30);
            this.customTextBoxMoveCommand.TabIndex = 5;
            this.customTextBoxMoveCommand.Text = "Komut";
            // 
            // customTextBoxY
            // 
            this.customTextBoxY.ForeColor = System.Drawing.Color.Gray;
            this.customTextBoxY.Location = new System.Drawing.Point(490, 12);
            this.customTextBoxY.Multiline = true;
            this.customTextBoxY.Name = "customTextBoxY";
            this.customTextBoxY.OnlyNumber = false;
            this.customTextBoxY.Placeholder = "Y";
            this.customTextBoxY.Size = new System.Drawing.Size(66, 30);
            this.customTextBoxY.TabIndex = 3;
            this.customTextBoxY.Text = "Y";
            // 
            // customTextBoxX
            // 
            this.customTextBoxX.ForeColor = System.Drawing.Color.Gray;
            this.customTextBoxX.Location = new System.Drawing.Point(418, 12);
            this.customTextBoxX.Multiline = true;
            this.customTextBoxX.Name = "customTextBoxX";
            this.customTextBoxX.OnlyNumber = false;
            this.customTextBoxX.Placeholder = "X";
            this.customTextBoxX.Size = new System.Drawing.Size(66, 30);
            this.customTextBoxX.TabIndex = 2;
            this.customTextBoxX.Text = "X";
            // 
            // customTextBox2
            // 
            this.customTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.customTextBox2.Location = new System.Drawing.Point(190, 12);
            this.customTextBox2.Multiline = true;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.OnlyNumber = false;
            this.customTextBox2.Placeholder = "Search Rover Name";
            this.customTextBox2.Size = new System.Drawing.Size(147, 30);
            this.customTextBox2.TabIndex = 1;
            this.customTextBox2.Text = "Search Rover Name";
            this.customTextBox2.TextChanged += new System.EventHandler(this.customTextBox2_TextChanged);
            // 
            // customTextBox1
            // 
            this.customTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.customTextBox1.Location = new System.Drawing.Point(12, 12);
            this.customTextBox1.Multiline = true;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.OnlyNumber = false;
            this.customTextBox1.Placeholder = "Search Area Name";
            this.customTextBox1.Size = new System.Drawing.Size(147, 30);
            this.customTextBox1.TabIndex = 0;
            this.customTextBox1.Text = "Search Area Name";
            this.customTextBox1.TextChanged += new System.EventHandler(this.customTextBox1_TextChanged);
            // 
            // RoverSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxRoverMoveCommand);
            this.Controls.Add(this.buttonRoverAdd);
            this.Controls.Add(this.listBoxRover);
            this.Controls.Add(this.listBoxArea);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customTextBoxMoveCommand);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.customTextBoxY);
            this.Controls.Add(this.customTextBoxX);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Name = "RoverSimulation";
            this.Text = "RoverSimulation";
            this.Load += new System.EventHandler(this.RoverSimulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.CustomTextBox customTextBox1;
        private Components.CustomTextBox customTextBox2;
        private Components.CustomTextBox customTextBoxX;
        private Components.CustomTextBox customTextBoxY;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private Components.CustomTextBox customTextBoxMoveCommand;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxArea;
        private System.Windows.Forms.ListBox listBoxRover;
        private System.Windows.Forms.Button buttonRoverAdd;
        private System.Windows.Forms.ListBox listBoxRoverMoveCommand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoverAreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartingPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
        private System.Windows.Forms.Button button2;
    }
}