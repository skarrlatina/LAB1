namespace Lab_1
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_StudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_StudentSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_StudentGender = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown_StudentCourse = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDown_StudentGroup = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddStudent = new System.Windows.Forms.Button();
            this.btn_WriteToFile = new System.Windows.Forms.Button();
            this.studentCollection = new System.Windows.Forms.ListBox();
            this.btn_ReadFromFile = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StudentCourse)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StudentGroup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 261);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_StudentName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 45);
            this.panel1.TabIndex = 2;
            // 
            // textBox_StudentName
            // 
            this.textBox_StudentName.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_StudentName.Location = new System.Drawing.Point(157, 0);
            this.textBox_StudentName.Name = "textBox_StudentName";
            this.textBox_StudentName.Size = new System.Drawing.Size(171, 38);
            this.textBox_StudentName.TabIndex = 2;
            this.textBox_StudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_StudentSurname);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 45);
            this.panel2.TabIndex = 3;
            // 
            // textBox_StudentSurname
            // 
            this.textBox_StudentSurname.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_StudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_StudentSurname.Location = new System.Drawing.Point(154, 0);
            this.textBox_StudentSurname.Name = "textBox_StudentSurname";
            this.textBox_StudentSurname.Size = new System.Drawing.Size(174, 38);
            this.textBox_StudentSurname.TabIndex = 2;
            this.textBox_StudentSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox_StudentGender);
            this.panel3.Location = new System.Drawing.Point(3, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 45);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_StudentGender
            // 
            this.comboBox_StudentGender.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox_StudentGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.comboBox_StudentGender.FormattingEnabled = true;
            this.comboBox_StudentGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_StudentGender.Location = new System.Drawing.Point(154, 0);
            this.comboBox_StudentGender.Name = "comboBox_StudentGender";
            this.comboBox_StudentGender.Size = new System.Drawing.Size(174, 39);
            this.comboBox_StudentGender.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDown_StudentCourse);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 45);
            this.panel4.TabIndex = 5;
            // 
            // numericUpDown_StudentCourse
            // 
            this.numericUpDown_StudentCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.numericUpDown_StudentCourse.Location = new System.Drawing.Point(154, 0);
            this.numericUpDown_StudentCourse.Name = "numericUpDown_StudentCourse";
            this.numericUpDown_StudentCourse.Size = new System.Drawing.Size(174, 38);
            this.numericUpDown_StudentCourse.TabIndex = 4;
            this.numericUpDown_StudentCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Course:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.numericUpDown_StudentGroup);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(3, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 45);
            this.panel5.TabIndex = 6;
            // 
            // numericUpDown_StudentGroup
            // 
            this.numericUpDown_StudentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.numericUpDown_StudentGroup.Location = new System.Drawing.Point(154, 0);
            this.numericUpDown_StudentGroup.Name = "numericUpDown_StudentGroup";
            this.numericUpDown_StudentGroup.Size = new System.Drawing.Size(174, 38);
            this.numericUpDown_StudentGroup.TabIndex = 5;
            this.numericUpDown_StudentGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Group:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddStudent.Location = new System.Drawing.Point(378, 27);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Size = new System.Drawing.Size(166, 60);
            this.btn_AddStudent.TabIndex = 2;
            this.btn_AddStudent.Text = "ADD STUDENT";
            this.btn_AddStudent.UseVisualStyleBackColor = true;
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // btn_WriteToFile
            // 
            this.btn_WriteToFile.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_WriteToFile.Location = new System.Drawing.Point(378, 89);
            this.btn_WriteToFile.Name = "btn_WriteToFile";
            this.btn_WriteToFile.Size = new System.Drawing.Size(166, 60);
            this.btn_WriteToFile.TabIndex = 3;
            this.btn_WriteToFile.Text = "WRITE TO FILE";
            this.btn_WriteToFile.UseVisualStyleBackColor = true;
            this.btn_WriteToFile.Click += new System.EventHandler(this.btn_WriteToFile_Click);
            // 
            // studentCollection
            // 
            this.studentCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentCollection.FormattingEnabled = true;
            this.studentCollection.ItemHeight = 20;
            this.studentCollection.Location = new System.Drawing.Point(550, 27);
            this.studentCollection.Name = "studentCollection";
            this.studentCollection.Size = new System.Drawing.Size(407, 284);
            this.studentCollection.TabIndex = 4;
            // 
            // btn_ReadFromFile
            // 
            this.btn_ReadFromFile.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ReadFromFile.Location = new System.Drawing.Point(378, 151);
            this.btn_ReadFromFile.Name = "btn_ReadFromFile";
            this.btn_ReadFromFile.Size = new System.Drawing.Size(166, 60);
            this.btn_ReadFromFile.TabIndex = 5;
            this.btn_ReadFromFile.Text = "READ FROM FILE";
            this.btn_ReadFromFile.UseVisualStyleBackColor = true;
            this.btn_ReadFromFile.Click += new System.EventHandler(this.btn_ReadFromFile_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(378, 251);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(166, 60);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 332);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_ReadFromFile);
            this.Controls.Add(this.studentCollection);
            this.Controls.Add(this.btn_WriteToFile);
            this.Controls.Add(this.btn_AddStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StudentCourse)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StudentGroup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_StudentName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_StudentSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_StudentGender;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddStudent;
        private System.Windows.Forms.Button btn_WriteToFile;
        private System.Windows.Forms.NumericUpDown numericUpDown_StudentCourse;
        private System.Windows.Forms.NumericUpDown numericUpDown_StudentGroup;
        private System.Windows.Forms.ListBox studentCollection;
        private System.Windows.Forms.Button btn_ReadFromFile;
        private System.Windows.Forms.Button btn_Clear;
    }
}

