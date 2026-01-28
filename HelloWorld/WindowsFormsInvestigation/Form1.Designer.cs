namespace WindowsFormsInvestigation
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
            btnTest = new Button();
            listUsers = new ListBox();
            txtId = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            chkActive = new CheckBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            btnNew = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(104, 62);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(164, 49);
            btnTest.TabIndex = 0;
            btnTest.Text = "Press Me";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // listUsers
            // 
            listUsers.FormattingEnabled = true;
            listUsers.ItemHeight = 15;
            listUsers.Location = new Point(73, 156);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(210, 289);
            listUsers.TabIndex = 1;
            listUsers.SelectedIndexChanged += listUsers_SelectedIndexChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(364, 161);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(197, 23);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(364, 206);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 23);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(364, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 23);
            txtEmail.TabIndex = 4;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(364, 316);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(59, 19);
            chkActive.TabIndex = 5;
            chkActive.Text = "Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(367, 377);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 35);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(482, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 35);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Enabled = false;
            btnCreate.Location = new Point(601, 377);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 35);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(601, 316);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 35);
            btnNew.TabIndex = 9;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(707, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 559);
            Controls.Add(btnCancel);
            Controls.Add(btnNew);
            Controls.Add(btnCreate);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(chkActive);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(listUsers);
            Controls.Add(btnTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTest;
        private ListBox listUsers;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtEmail;
        private CheckBox chkActive;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private Button btnNew;
        private Button btnCancel;
    }
}
