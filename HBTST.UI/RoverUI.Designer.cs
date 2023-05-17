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
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.labelTotalPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWorldAreaAdd = new System.Windows.Forms.Button();
            this.pagination1 = new HBTST.UI.Components.Pagination();
            this.buttonSimulation = new System.Windows.Forms.Button();
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
            this.dataGridViewRoverList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewRoverList.Location = new System.Drawing.Point(25, 116);
            this.dataGridViewRoverList.Name = "dataGridViewRoverList";
            this.dataGridViewRoverList.ReadOnly = true;
            this.dataGridViewRoverList.Size = new System.Drawing.Size(685, 278);
            this.dataGridViewRoverList.TabIndex = 0;
            this.dataGridViewRoverList.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(25, 400);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(117, 32);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(339, 403);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(117, 32);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Location = new System.Drawing.Point(200, 413);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentPage.TabIndex = 9;
            this.labelCurrentPage.Text = "1";
            // 
            // labelTotalPage
            // 
            this.labelTotalPage.AutoSize = true;
            this.labelTotalPage.Location = new System.Drawing.Point(237, 413);
            this.labelTotalPage.Name = "labelTotalPage";
            this.labelTotalPage.Size = new System.Drawing.Size(13, 13);
            this.labelTotalPage.TabIndex = 10;
            this.labelTotalPage.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // buttonWorldAreaAdd
            // 
            this.buttonWorldAreaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonWorldAreaAdd.Location = new System.Drawing.Point(390, 22);
            this.buttonWorldAreaAdd.Name = "buttonWorldAreaAdd";
            this.buttonWorldAreaAdd.Size = new System.Drawing.Size(140, 51);
            this.buttonWorldAreaAdd.TabIndex = 15;
            this.buttonWorldAreaAdd.Text = "World Area Managment";
            this.buttonWorldAreaAdd.UseVisualStyleBackColor = true;
            this.buttonWorldAreaAdd.Click += new System.EventHandler(this.buttonWorldAreaAdd_Click);
            // 
            // pagination1
            // 
            this.pagination1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pagination1.Location = new System.Drawing.Point(25, 464);
            this.pagination1.Name = "pagination1";
            this.pagination1.PageNumber = 0;
            this.pagination1.Size = new System.Drawing.Size(431, 82);
            this.pagination1.TabIndex = 13;
            // 
            // buttonSimulation
            // 
            this.buttonSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSimulation.Location = new System.Drawing.Point(546, 22);
            this.buttonSimulation.Name = "buttonSimulation";
            this.buttonSimulation.Size = new System.Drawing.Size(140, 51);
            this.buttonSimulation.TabIndex = 16;
            this.buttonSimulation.Text = "Simülasyon";
            this.buttonSimulation.UseVisualStyleBackColor = true;
            this.buttonSimulation.Click += new System.EventHandler(this.buttonSimulation_Click);
            // 
            // RoverUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 558);
            this.Controls.Add(this.buttonSimulation);
            this.Controls.Add(this.buttonWorldAreaAdd);
            this.Controls.Add(this.pagination1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotalPage);
            this.Controls.Add(this.labelCurrentPage);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.dataGridViewRoverList);
            this.Controls.Add(this.buttonRoverDelete);
            this.Controls.Add(this.buttonRoverAdd);
            this.Name = "RoverUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rover";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoverUI_FormClosed);
            this.Load += new System.EventHandler(this.RoverUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoverList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRoverAdd;
        private System.Windows.Forms.Button buttonRoverDelete;
        public System.Windows.Forms.DataGridView dataGridViewRoverList;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.Label labelTotalPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Components.Pagination pagination1;
        private System.Windows.Forms.Button buttonWorldAreaAdd;
        private System.Windows.Forms.Button buttonSimulation;
    }
}