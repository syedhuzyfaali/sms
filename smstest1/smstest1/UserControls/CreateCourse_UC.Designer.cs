namespace smstest1.UserControls
{
    partial class CreateCourse_UC
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
            this.viewCourses = new System.Windows.Forms.Button();
            this.addCrsBtn = new System.Windows.Forms.Button();
            this.InputDesc = new System.Windows.Forms.TextBox();
            this.InputCoursename = new System.Windows.Forms.TextBox();
            this.crsDesc = new System.Windows.Forms.Label();
            this.crsName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseCrdHrs = new System.Windows.Forms.NumericUpDown();
            this.courseFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.returnval = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseCrdHrs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.returnval);
            this.panel1.Controls.Add(this.courseFee);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.courseCrdHrs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.viewCourses);
            this.panel1.Controls.Add(this.addCrsBtn);
            this.panel1.Controls.Add(this.InputDesc);
            this.panel1.Controls.Add(this.InputCoursename);
            this.panel1.Controls.Add(this.crsDesc);
            this.panel1.Controls.Add(this.crsName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(93, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 335);
            this.panel1.TabIndex = 12;
            // 
            // viewCourses
            // 
            this.viewCourses.Location = new System.Drawing.Point(439, 16);
            this.viewCourses.Name = "viewCourses";
            this.viewCourses.Size = new System.Drawing.Size(105, 23);
            this.viewCourses.TabIndex = 32;
            this.viewCourses.Text = "View All Courses";
            this.viewCourses.UseVisualStyleBackColor = true;
            // 
            // addCrsBtn
            // 
            this.addCrsBtn.Location = new System.Drawing.Point(225, 287);
            this.addCrsBtn.Name = "addCrsBtn";
            this.addCrsBtn.Size = new System.Drawing.Size(75, 23);
            this.addCrsBtn.TabIndex = 31;
            this.addCrsBtn.Text = "Add Course";
            this.addCrsBtn.UseVisualStyleBackColor = true;
            this.addCrsBtn.Click += new System.EventHandler(this.addCrsBtn_Click);
            // 
            // InputDesc
            // 
            this.InputDesc.Location = new System.Drawing.Point(229, 123);
            this.InputDesc.Multiline = true;
            this.InputDesc.Name = "InputDesc";
            this.InputDesc.Size = new System.Drawing.Size(199, 81);
            this.InputDesc.TabIndex = 25;
            // 
            // InputCoursename
            // 
            this.InputCoursename.Location = new System.Drawing.Point(229, 96);
            this.InputCoursename.Name = "InputCoursename";
            this.InputCoursename.Size = new System.Drawing.Size(200, 20);
            this.InputCoursename.TabIndex = 20;
            // 
            // crsDesc
            // 
            this.crsDesc.AutoSize = true;
            this.crsDesc.Location = new System.Drawing.Point(123, 126);
            this.crsDesc.Name = "crsDesc";
            this.crsDesc.Size = new System.Drawing.Size(96, 13);
            this.crsDesc.TabIndex = 15;
            this.crsDesc.Text = "Course Description";
            // 
            // crsName
            // 
            this.crsName.AutoSize = true;
            this.crsName.Location = new System.Drawing.Point(123, 96);
            this.crsName.Name = "crsName";
            this.crsName.Size = new System.Drawing.Size(71, 13);
            this.crsName.TabIndex = 11;
            this.crsName.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Course Credit Hours";
            // 
            // courseCrdHrs
            // 
            this.courseCrdHrs.DecimalPlaces = 1;
            this.courseCrdHrs.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.courseCrdHrs.Location = new System.Drawing.Point(229, 210);
            this.courseCrdHrs.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.courseCrdHrs.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.courseCrdHrs.Name = "courseCrdHrs";
            this.courseCrdHrs.Size = new System.Drawing.Size(120, 20);
            this.courseCrdHrs.TabIndex = 35;
            this.courseCrdHrs.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // courseFee
            // 
            this.courseFee.Location = new System.Drawing.Point(229, 238);
            this.courseFee.Name = "courseFee";
            this.courseFee.Size = new System.Drawing.Size(200, 20);
            this.courseFee.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Course Fee / Crd Hrs";
            // 
            // returnval
            // 
            this.returnval.AutoSize = true;
            this.returnval.Location = new System.Drawing.Point(513, 160);
            this.returnval.Name = "returnval";
            this.returnval.Size = new System.Drawing.Size(19, 13);
            this.returnval.TabIndex = 84;
            this.returnval.Text = "__";
            // 
            // CreateCourse_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CreateCourse_UC";
            this.Size = new System.Drawing.Size(750, 400);
            this.Load += new System.EventHandler(this.CreateCourse_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseCrdHrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewCourses;
        private System.Windows.Forms.Button addCrsBtn;
        private System.Windows.Forms.TextBox InputDesc;
        private System.Windows.Forms.TextBox InputCoursename;
        private System.Windows.Forms.Label crsDesc;
        private System.Windows.Forms.Label crsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown courseCrdHrs;
        private System.Windows.Forms.Label returnval;
    }
}
