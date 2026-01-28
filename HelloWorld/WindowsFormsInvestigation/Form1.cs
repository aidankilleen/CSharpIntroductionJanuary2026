using System.Diagnostics;
using System.Linq.Expressions;
using UserDaoLibrary;

namespace WindowsFormsInvestigation
{
    public partial class Form1 : Form
    {
        private UserDao dao = new UserDao("c:\\work\\training\\java\\users_production.db");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Is this working?");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var users = dao.GetAll();

            foreach (var user in users)
            {
                Debug.WriteLine(user);
                listUsers.Items.Add(user);
            }
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = listUsers.SelectedItem as User;
            if (selectedUser != null)
            {
                txtId.Text = $"{selectedUser.Id}";
                txtName.Text = selectedUser.Name;
                txtEmail.Text = selectedUser.Email;
                chkActive.Checked = selectedUser.Active;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnNew.Enabled = true;
                btnCreate.Enabled = false;

                lblStatus.Text = $"{selectedUser.Id}";
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnCreate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User userToUpdate = new User
            {
                Id = long.Parse(txtId.Text),
                Name = txtName.Text,
                Email = txtEmail.Text,
                Active = chkActive.Checked,
            };
            dao.Update(userToUpdate);

            // update the list
            int index = listUsers.SelectedIndex;
            listUsers.Items.RemoveAt(index);
            listUsers.Items.Insert(index, userToUpdate);



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listUsers.SelectedIndex;
            long id = long.Parse(txtId.Text);

            DialogResult result = MessageBox.Show(this,
                $"Delete user {id}?",
                "Are you sure?",
                MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                dao.Delete(id);
                listUsers.Items.RemoveAt(index);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            chkActive.Checked = false;

            btnCreate.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            User userToCreate = new User
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Active = chkActive.Checked,
            };

            User addedUser = dao.Add(userToCreate);
            listUsers.Items.Add(addedUser);

            btnCreate.Enabled = false;
            btnNew.Enabled = true;
            btnCancel.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            chkActive.Checked = false;

            btnNew.Enabled = true;
            btnCreate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            pbStatus.Visible = true;
            for (int i = 0; i <= 100; i++)
            {
                Debug.WriteLine($"working {i}");
                pbStatus.Value = i;

                Thread.Sleep(100);
            }
            pbStatus.Visible = false;
        }

        private void btnWorkSmarter_Click(object sender, EventArgs e)
        {
            pbStatus.Visible = true;
            btnWorkSmarter.Enabled = false;

            bwDoWork.RunWorkerAsync();
        }

        private void bwDoWork_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                bwDoWork.ReportProgress(i);
            }
        }

        private void bwDoWork_ProgressChanged(
            object sender,
            System.ComponentModel.ProgressChangedEventArgs e)
        {
            pbStatus.Value = e.ProgressPercentage;
        }

        private void bwDoWork_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            pbStatus.Visible = false;
            btnWorkSmarter.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            dao.Close();


            
        }
    }
}
