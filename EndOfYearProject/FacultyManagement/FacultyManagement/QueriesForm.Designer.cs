namespace FacultyManagement
{
    partial class QueriesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLongSubjects = new System.Windows.Forms.Button();
            this.btnSpecificSubject = new System.Windows.Forms.Button();
            this.btnExpTeachers = new System.Windows.Forms.Button();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToResizeColumns = false;
            this.dgvFaculty.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.PowderBlue;
            this.dgvFaculty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFaculty.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaculty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaculty.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFaculty.Location = new System.Drawing.Point(12, 12);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.RowTemplate.Height = 24;
            this.dgvFaculty.Size = new System.Drawing.Size(786, 238);
            this.dgvFaculty.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(617, 332);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLongSubjects
            // 
            this.btnLongSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLongSubjects.Location = new System.Drawing.Point(12, 266);
            this.btnLongSubjects.Name = "btnLongSubjects";
            this.btnLongSubjects.Size = new System.Drawing.Size(123, 72);
            this.btnLongSubjects.TabIndex = 4;
            this.btnLongSubjects.Text = "Subjects with at least 3 semesters";
            this.btnLongSubjects.UseVisualStyleBackColor = true;
            this.btnLongSubjects.Click += new System.EventHandler(this.btnLongSubjects_Click);
            // 
            // btnSpecificSubject
            // 
            this.btnSpecificSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecificSubject.Location = new System.Drawing.Point(160, 267);
            this.btnSpecificSubject.Name = "btnSpecificSubject";
            this.btnSpecificSubject.Size = new System.Drawing.Size(123, 31);
            this.btnSpecificSubject.TabIndex = 5;
            this.btnSpecificSubject.Text = "Specific subject";
            this.btnSpecificSubject.UseVisualStyleBackColor = true;
            this.btnSpecificSubject.Click += new System.EventHandler(this.btnSpecificSubject_Click);
            // 
            // btnExpTeachers
            // 
            this.btnExpTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpTeachers.Location = new System.Drawing.Point(313, 267);
            this.btnExpTeachers.Name = "btnExpTeachers";
            this.btnExpTeachers.Size = new System.Drawing.Size(123, 71);
            this.btnExpTeachers.TabIndex = 6;
            this.btnExpTeachers.Text = "Teachers with 10-15 years of experience";
            this.btnExpTeachers.UseVisualStyleBackColor = true;
            this.btnExpTeachers.Click += new System.EventHandler(this.btnExpTeachers_Click);
            // 
            // cbSubjects
            // 
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(160, 314);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(123, 24);
            this.cbSubjects.TabIndex = 7;
            // 
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 386);
            this.Controls.Add(this.cbSubjects);
            this.Controls.Add(this.btnExpTeachers);
            this.Controls.Add(this.btnSpecificSubject);
            this.Controls.Add(this.btnLongSubjects);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvFaculty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QueriesForm";
            this.Load += new System.EventHandler(this.QueriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLongSubjects;
        private System.Windows.Forms.Button btnSpecificSubject;
        private System.Windows.Forms.Button btnExpTeachers;
        private System.Windows.Forms.ComboBox cbSubjects;
    }
}