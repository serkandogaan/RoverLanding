namespace HBTST.UI
{
    partial class RoverDeleteWarning
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteYes = new System.Windows.Forms.Button();
            this.buttonDeleteNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seçili Rover\'ı Silmek İstediğinizden Emin Misiniz?";
            // 
            // buttonDeleteYes
            // 
            this.buttonDeleteYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDeleteYes.Location = new System.Drawing.Point(64, 112);
            this.buttonDeleteYes.Name = "buttonDeleteYes";
            this.buttonDeleteYes.Size = new System.Drawing.Size(125, 39);
            this.buttonDeleteYes.TabIndex = 1;
            this.buttonDeleteYes.Text = "Evet";
            this.buttonDeleteYes.UseVisualStyleBackColor = true;
            this.buttonDeleteYes.Click += new System.EventHandler(this.buttonDeleteYes_Click);
            // 
            // buttonDeleteNo
            // 
            this.buttonDeleteNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDeleteNo.Location = new System.Drawing.Point(286, 112);
            this.buttonDeleteNo.Name = "buttonDeleteNo";
            this.buttonDeleteNo.Size = new System.Drawing.Size(125, 39);
            this.buttonDeleteNo.TabIndex = 2;
            this.buttonDeleteNo.Text = "Hayır";
            this.buttonDeleteNo.UseVisualStyleBackColor = true;
            this.buttonDeleteNo.Click += new System.EventHandler(this.buttonDeleteNo_Click);
            // 
            // RoverDeleteWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 187);
            this.Controls.Add(this.buttonDeleteNo);
            this.Controls.Add(this.buttonDeleteYes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RoverDeleteWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning";
            this.Load += new System.EventHandler(this.RoverDeleteWarning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteYes;
        private System.Windows.Forms.Button buttonDeleteNo;
    }
}