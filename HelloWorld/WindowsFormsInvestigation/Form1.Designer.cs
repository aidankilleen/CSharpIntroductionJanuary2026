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
            statusStrip1 = new StatusStrip();
            pbStatus = new ToolStripProgressBar();
            lblStatus = new ToolStripStatusLabel();
            btnWork = new Button();
            bwDoWork = new System.ComponentModel.BackgroundWorker();
            btnWorkSmarter = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listUsers
            // 
            listUsers.FormattingEnabled = true;
            listUsers.ItemHeight = 15;
            listUsers.Location = new Point(73, 81);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(210, 364);
            listUsers.TabIndex = 1;
            listUsers.SelectedIndexChanged += listUsers_SelectedIndexChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(367, 88);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(257, 23);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(367, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(257, 23);
            txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(367, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 23);
            txtEmail.TabIndex = 4;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(367, 262);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(59, 19);
            chkActive.TabIndex = 5;
            chkActive.Text = "Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(314, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(423, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Enabled = false;
            btnCreate.Location = new Point(532, 410);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 35);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(641, 410);
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
            btnCancel.Location = new Point(750, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { pbStatus, lblStatus });
            statusStrip1.Location = new Point(0, 537);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(892, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // pbStatus
            // 
            pbStatus.Name = "pbStatus";
            pbStatus.Size = new Size(100, 16);
            pbStatus.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(118, 17);
            lblStatus.Text = "toolStripStatusLabel1";
            // 
            // btnWork
            // 
            btnWork.Location = new Point(396, 479);
            btnWork.Name = "btnWork";
            btnWork.Size = new Size(116, 23);
            btnWork.TabIndex = 12;
            btnWork.Text = "Do Work";
            btnWork.UseVisualStyleBackColor = true;
            btnWork.Click += btnWork_Click;
            // 
            // bwDoWork
            // 
            bwDoWork.WorkerReportsProgress = true;
            bwDoWork.DoWork += bwDoWork_DoWork;
            bwDoWork.ProgressChanged += bwDoWork_ProgressChanged;
            bwDoWork.RunWorkerCompleted += bwDoWork_RunWorkerCompleted;
            // 
            // btnWorkSmarter
            // 
            btnWorkSmarter.Location = new Point(545, 479);
            btnWorkSmarter.Name = "btnWorkSmarter";
            btnWorkSmarter.Size = new Size(116, 23);
            btnWorkSmarter.TabIndex = 13;
            btnWorkSmarter.Text = "Work Smart";
            btnWorkSmarter.UseVisualStyleBackColor = true;
            btnWorkSmarter.Click += btnWorkSmarter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 559);
            Controls.Add(btnWorkSmarter);
            Controls.Add(btnWork);
            Controls.Add(statusStrip1);
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
            Name = "Form1";
            Text = "User Manager";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private StatusStrip statusStrip1;
        private ToolStripProgressBar pbStatus;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripStatusLabel lblStatus;
        private Button btnWork;
        private System.ComponentModel.BackgroundWorker bwDoWork;
        private Button btnWorkSmarter;
    }
}
