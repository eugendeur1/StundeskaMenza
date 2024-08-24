namespace RWA_Project
{
    partial class Form6
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            txtName = new TextBox();
            txtTitle = new TextBox();
            txtYearOfStudy = new TextBox();
            txtFakultetId = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(705, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(236, 355);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 1);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(578, 355);
            dataGridView2.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(149, 390);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(149, 438);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 3;
            // 
            // txtYearOfStudy
            // 
            txtYearOfStudy.Location = new Point(149, 484);
            txtYearOfStudy.Name = "txtYearOfStudy";
            txtYearOfStudy.Size = new Size(100, 23);
            txtYearOfStudy.TabIndex = 4;
            // 
            // txtFakultetId
            // 
            txtFakultetId.Location = new Point(149, 533);
            txtFakultetId.Name = "txtFakultetId";
            txtFakultetId.Size = new Size(100, 23);
            txtFakultetId.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(360, 449);
            button1.Name = "button1";
            button1.Size = new Size(132, 45);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 590);
            Controls.Add(button1);
            Controls.Add(txtFakultetId);
            Controls.Add(txtYearOfStudy);
            Controls.Add(txtTitle);
            Controls.Add(txtName);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form6";
            Text = "Add New Student Form";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox txtName;
        private TextBox txtTitle;
        private TextBox txtYearOfStudy;
        private TextBox txtFakultetId;
        private Button button1;
    }
}