namespace DATA_UI
{
    partial class ActorForm
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
            this.nameLBL = new System.Windows.Forms.Label();
            this.imagePB = new System.Windows.Forms.PictureBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.invLB = new System.Windows.Forms.ListBox();
            this.statLB = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.Location = new System.Drawing.Point(7, 10);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(90, 27);
            this.nameLBL.TabIndex = 0;
            this.nameLBL.Text = "[NAME]";
            // 
            // imagePB
            // 
            this.imagePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagePB.Location = new System.Drawing.Point(12, 40);
            this.imagePB.Name = "imagePB";
            this.imagePB.Size = new System.Drawing.Size(256, 256);
            this.imagePB.TabIndex = 1;
            this.imagePB.TabStop = false;
            // 
            // closeBTN
            // 
            this.closeBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Location = new System.Drawing.Point(319, 273);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 2;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // invLB
            // 
            this.invLB.BackColor = System.Drawing.Color.Black;
            this.invLB.ForeColor = System.Drawing.Color.White;
            this.invLB.FormattingEnabled = true;
            this.invLB.ItemHeight = 15;
            this.invLB.Location = new System.Drawing.Point(274, 140);
            this.invLB.Name = "invLB";
            this.invLB.Size = new System.Drawing.Size(120, 124);
            this.invLB.TabIndex = 4;
            // 
            // statLB
            // 
            this.statLB.BackColor = System.Drawing.Color.Black;
            this.statLB.ForeColor = System.Drawing.Color.White;
            this.statLB.FormattingEnabled = true;
            this.statLB.ItemHeight = 15;
            this.statLB.Location = new System.Drawing.Point(274, 40);
            this.statLB.Name = "statLB";
            this.statLB.Size = new System.Drawing.Size(120, 94);
            this.statLB.TabIndex = 5;
            // 
            // ActorForm
            // 
            this.AcceptButton = this.closeBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.closeBTN;
            this.ClientSize = new System.Drawing.Size(407, 308);
            this.Controls.Add(this.statLB);
            this.Controls.Add(this.invLB);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.imagePB);
            this.Controls.Add(this.nameLBL);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ActorForm";
            this.Text = "Stats";
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.PictureBox imagePB;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.ListBox invLB;
        private System.Windows.Forms.ListBox statLB;
    }
}