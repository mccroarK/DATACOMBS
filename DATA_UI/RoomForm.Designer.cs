namespace DATA_UI
{
    partial class RoomForm
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
            this.thingLB = new System.Windows.Forms.ListBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // thingLB
            // 
            this.thingLB.BackColor = System.Drawing.Color.Black;
            this.thingLB.ForeColor = System.Drawing.Color.White;
            this.thingLB.FormattingEnabled = true;
            this.thingLB.ItemHeight = 15;
            this.thingLB.Location = new System.Drawing.Point(12, 12);
            this.thingLB.Name = "thingLB";
            this.thingLB.Size = new System.Drawing.Size(313, 139);
            this.thingLB.TabIndex = 0;
            // 
            // closeBTN
            // 
            this.closeBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Location = new System.Drawing.Point(250, 157);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 1;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // RoomForm
            // 
            this.AcceptButton = this.closeBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.closeBTN;
            this.ClientSize = new System.Drawing.Size(337, 189);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.thingLB);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox thingLB;
        private System.Windows.Forms.Button closeBTN;
    }
}