namespace LB03StudentGrades_JohnBaradaFINALFINALFINAL
{
    partial class frmStudentGrades
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblResult = new Label();
            txtName = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(49, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 22);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(49, 63);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(703, 358);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result";
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(130, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(424, 29);
            txtName.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(560, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(156, 51);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmStudentGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(txtName);
            Controls.Add(lblResult);
            Controls.Add(lblName);
            Name = "frmStudentGrades";
            Text = "Student Grades";
            Load += frmStudentGrades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblResult;
        private TextBox txtName;
        private Button btnSearch;
    }
}