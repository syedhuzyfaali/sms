namespace smstest1.UserControls
{
    partial class AdminUserControl
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
            this.upgStd = new System.Windows.Forms.Button();
            this.semesterBtn = new System.Windows.Forms.Button();
            this.addClass = new System.Windows.Forms.Button();
            this.crsbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.feedbackbtn = new System.Windows.Forms.Button();
            this.LnameShow = new System.Windows.Forms.Label();
            this.FnameShow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upgStd
            // 
            this.upgStd.Location = new System.Drawing.Point(425, 129);
            this.upgStd.Name = "upgStd";
            this.upgStd.Size = new System.Drawing.Size(75, 23);
            this.upgStd.TabIndex = 32;
            this.upgStd.Text = "Upgrade Students";
            this.upgStd.UseVisualStyleBackColor = true;
            // 
            // semesterBtn
            // 
            this.semesterBtn.Location = new System.Drawing.Point(287, 350);
            this.semesterBtn.Name = "semesterBtn";
            this.semesterBtn.Size = new System.Drawing.Size(75, 23);
            this.semesterBtn.TabIndex = 31;
            this.semesterBtn.Text = "Semester";
            this.semesterBtn.UseVisualStyleBackColor = true;
            this.semesterBtn.Click += new System.EventHandler(this.semesterBtn_Click);
            // 
            // addClass
            // 
            this.addClass.Location = new System.Drawing.Point(287, 295);
            this.addClass.Name = "addClass";
            this.addClass.Size = new System.Drawing.Size(75, 23);
            this.addClass.TabIndex = 30;
            this.addClass.Text = "Create Class";
            this.addClass.UseVisualStyleBackColor = true;
            // 
            // crsbtn
            // 
            this.crsbtn.Location = new System.Drawing.Point(287, 241);
            this.crsbtn.Name = "crsbtn";
            this.crsbtn.Size = new System.Drawing.Size(75, 23);
            this.crsbtn.TabIndex = 29;
            this.crsbtn.Text = "Courses";
            this.crsbtn.UseVisualStyleBackColor = true;
            this.crsbtn.Click += new System.EventHandler(this.crsbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Admission";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // feedbackbtn
            // 
            this.feedbackbtn.Location = new System.Drawing.Point(287, 129);
            this.feedbackbtn.Name = "feedbackbtn";
            this.feedbackbtn.Size = new System.Drawing.Size(75, 23);
            this.feedbackbtn.TabIndex = 27;
            this.feedbackbtn.Text = "Feedback";
            this.feedbackbtn.UseVisualStyleBackColor = true;
            // 
            // LnameShow
            // 
            this.LnameShow.AutoSize = true;
            this.LnameShow.Location = new System.Drawing.Point(422, 81);
            this.LnameShow.Name = "LnameShow";
            this.LnameShow.Size = new System.Drawing.Size(35, 13);
            this.LnameShow.TabIndex = 26;
            this.LnameShow.Text = "label4";
            // 
            // FnameShow
            // 
            this.FnameShow.AutoSize = true;
            this.FnameShow.Location = new System.Drawing.Point(351, 81);
            this.FnameShow.Name = "FnameShow";
            this.FnameShow.Size = new System.Drawing.Size(35, 13);
            this.FnameShow.TabIndex = 25;
            this.FnameShow.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Admin ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Admin Name:";
            // 
            // idShow
            // 
            this.idShow.AutoSize = true;
            this.idShow.Location = new System.Drawing.Point(351, 28);
            this.idShow.Name = "idShow";
            this.idShow.Size = new System.Drawing.Size(35, 13);
            this.idShow.TabIndex = 22;
            this.idShow.Text = "label1";
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.upgStd);
            this.Controls.Add(this.semesterBtn);
            this.Controls.Add(this.addClass);
            this.Controls.Add(this.crsbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.feedbackbtn);
            this.Controls.Add(this.LnameShow);
            this.Controls.Add(this.FnameShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idShow);
            this.Name = "AdminUserControl";
            this.Size = new System.Drawing.Size(750, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upgStd;
        private System.Windows.Forms.Button semesterBtn;
        private System.Windows.Forms.Button addClass;
        private System.Windows.Forms.Button crsbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button feedbackbtn;
        private System.Windows.Forms.Label LnameShow;
        private System.Windows.Forms.Label FnameShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idShow;
    }
}
