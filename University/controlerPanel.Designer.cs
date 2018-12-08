namespace University
{
    partial class controlerPanel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chooseUnit = new System.Windows.Forms.CheckBox();
            this.addOrRemove = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chooseUnit);
            this.groupBox1.Controls.Add(this.addOrRemove);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(262, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کنترل انتخاب واحد و حذف و اضافه";
            // 
            // chooseUnit
            // 
            this.chooseUnit.AutoSize = true;
            this.chooseUnit.Location = new System.Drawing.Point(86, 41);
            this.chooseUnit.Name = "chooseUnit";
            this.chooseUnit.Size = new System.Drawing.Size(92, 28);
            this.chooseUnit.TabIndex = 1;
            this.chooseUnit.Text = "انتخاب واحد";
            this.chooseUnit.UseVisualStyleBackColor = true;
            this.chooseUnit.CheckedChanged += new System.EventHandler(this.chooseUnit_CheckedChanged);
            // 
            // addOrRemove
            // 
            this.addOrRemove.AutoSize = true;
            this.addOrRemove.Location = new System.Drawing.Point(82, 75);
            this.addOrRemove.Name = "addOrRemove";
            this.addOrRemove.Size = new System.Drawing.Size(96, 28);
            this.addOrRemove.TabIndex = 0;
            this.addOrRemove.Text = "حذف و اضافه";
            this.addOrRemove.UseVisualStyleBackColor = true;
            this.addOrRemove.CheckedChanged += new System.EventHandler(this.addOrRemove_CheckedChanged);
            // 
            // controlerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.groupBox1);
            this.Name = "controlerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "controlerPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.controlerPanel_Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox addOrRemove;
        private System.Windows.Forms.CheckBox chooseUnit;
    }
}