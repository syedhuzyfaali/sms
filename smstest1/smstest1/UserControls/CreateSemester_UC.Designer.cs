namespace smstest1.UserControls
{
    partial class CreateSemester_UC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.semesterEnd = new System.Windows.Forms.DateTimePicker();
            this.semesterStart = new System.Windows.Forms.DateTimePicker();
            this.cboxSemesterTerm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxSemesterYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addSemBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnval = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.returnval);
            this.panel1.Controls.Add(this.semesterEnd);
            this.panel1.Controls.Add(this.semesterStart);
            this.panel1.Controls.Add(this.cboxSemesterTerm);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboxSemesterYear);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addSemBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(77, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 328);
            this.panel1.TabIndex = 1;
            // 
            // semesterEnd
            // 
            this.semesterEnd.Location = new System.Drawing.Point(286, 222);
            this.semesterEnd.Name = "semesterEnd";
            this.semesterEnd.Size = new System.Drawing.Size(200, 20);
            this.semesterEnd.TabIndex = 14;
            // 
            // semesterStart
            // 
            this.semesterStart.Location = new System.Drawing.Point(286, 181);
            this.semesterStart.Name = "semesterStart";
            this.semesterStart.Size = new System.Drawing.Size(200, 20);
            this.semesterStart.TabIndex = 13;
            // 
            // cboxSemesterTerm
            // 
            this.cboxSemesterTerm.FormattingEnabled = true;
            this.cboxSemesterTerm.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.cboxSemesterTerm.Location = new System.Drawing.Point(287, 136);
            this.cboxSemesterTerm.Name = "cboxSemesterTerm";
            this.cboxSemesterTerm.Size = new System.Drawing.Size(147, 21);
            this.cboxSemesterTerm.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "20";
            // 
            // cboxSemesterYear
            // 
            this.cboxSemesterYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSemesterYear.FormattingEnabled = true;
            this.cboxSemesterYear.Location = new System.Drawing.Point(337, 88);
            this.cboxSemesterYear.Name = "cboxSemesterYear";
            this.cboxSemesterYear.Size = new System.Drawing.Size(43, 24);
            this.cboxSemesterYear.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Semester End";
            // 
            // addSemBtn
            // 
            this.addSemBtn.Location = new System.Drawing.Point(247, 281);
            this.addSemBtn.Name = "addSemBtn";
            this.addSemBtn.Size = new System.Drawing.Size(113, 23);
            this.addSemBtn.TabIndex = 7;
            this.addSemBtn.Text = "Add Semester";
            this.addSemBtn.UseVisualStyleBackColor = true;
            this.addSemBtn.Click += new System.EventHandler(this.addSemBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semester Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Semester";
            // 
            // returnval
            // 
            this.returnval.AutoSize = true;
            this.returnval.Location = new System.Drawing.Point(554, 140);
            this.returnval.Name = "returnval";
            this.returnval.Size = new System.Drawing.Size(19, 13);
            this.returnval.TabIndex = 83;
            this.returnval.Text = "__";
            // 
            // CreateSemester_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CreateSemester_UC";
            this.Size = new System.Drawing.Size(750, 400);
            this.Load += new System.EventHandler(this.CreateSemester_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addSemBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker semesterEnd;
        private System.Windows.Forms.DateTimePicker semesterStart;
        private System.Windows.Forms.ComboBox cboxSemesterTerm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxSemesterYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label returnval;
    }
}
