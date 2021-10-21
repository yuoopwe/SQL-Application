
namespace dbtry
{
    partial class Form1
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
            this.dbData = new System.Windows.Forms.DataGridView();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.taskIdTextBox = new System.Windows.Forms.TextBox();
            this.taskIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbData)).BeginInit();
            this.SuspendLayout();
            // 
            // dbData
            // 
            this.dbData.AllowUserToAddRows = false;
            this.dbData.AllowUserToDeleteRows = false;
            this.dbData.AllowUserToOrderColumns = true;
            this.dbData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbData.Location = new System.Drawing.Point(25, 127);
            this.dbData.MultiSelect = false;
            this.dbData.Name = "dbData";
            this.dbData.ReadOnly = true;
            this.dbData.RowTemplate.Height = 25;
            this.dbData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbData.Size = new System.Drawing.Size(763, 311);
            this.dbData.TabIndex = 0;
            this.dbData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbData_CellClick);
            this.dbData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbData_CellContentClick);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(252, 44);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(427, 44);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(585, 44);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(100, 23);
            this.subjectTextBox.TabIndex = 3;
            this.subjectTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(182, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(358, 47);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(533, 47);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 15);
            this.subjectLabel.TabIndex = 6;
            this.subjectLabel.Text = "Subject";
            this.subjectLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(585, 76);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Refresh";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(252, 76);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(76, 76);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 4;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(427, 76);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Update";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // taskIdTextBox
            // 
            this.taskIdTextBox.AcceptsTab = true;
            this.taskIdTextBox.Location = new System.Drawing.Point(76, 44);
            this.taskIdTextBox.Name = "taskIdTextBox";
            this.taskIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.taskIdTextBox.TabIndex = 8;
            this.taskIdTextBox.TextChanged += new System.EventHandler(this.taskIdTextBox_TextChanged);
            // 
            // taskIdLabel
            // 
            this.taskIdLabel.AutoSize = true;
            this.taskIdLabel.Location = new System.Drawing.Point(28, 50);
            this.taskIdLabel.Name = "taskIdLabel";
            this.taskIdLabel.Size = new System.Drawing.Size(42, 15);
            this.taskIdLabel.TabIndex = 9;
            this.taskIdLabel.Text = "Task Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskIdLabel);
            this.Controls.Add(this.taskIdTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.dbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbData;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox taskIdTextBox;
        private System.Windows.Forms.Label taskIdLabel;
    }
}

