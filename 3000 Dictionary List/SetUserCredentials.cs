using System;
using System.Windows.Forms;

namespace _3000_Dictionary_List
{
    public partial class SetUserCredentials : Form
    {
        public SetUserCredentials()
        {
            InitializeComponent();
        }

        private void SetUserCredentials_Load(object sender, EventArgs e)
        {
            textUserId.Text = Properties.Settings.Default.UserId;
            textSqlServer.Text = Properties.Settings.Default.SqlServer;
			textPassword1.Text = Properties.Settings.Default.Password;
			textPassword2.Text = Properties.Settings.Default.Password;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "";

            if (textPassword1.Text != textPassword2.Text)
            {
                txtStatus.Text = @"Passwords do not match. Please retype them.";
                return;
            }

            if (textPassword1.Text != "")
            {
                Properties.Settings.Default.Password = textPassword1.Text;
            }

            Properties.Settings.Default.UserId = textUserId.Text;
            Properties.Settings.Default.SqlServer = textSqlServer.Text;
			Properties.Settings.Default.Save();

            Properties.Settings.Default.UserConnectionString =
                "Data Source=" + Properties.Settings.Default.SqlServer +
                ";Initial Catalog=" + Properties.Settings.Default.UserId +
                ";Persist Security Info=True;User ID=" + Properties.Settings.Default.UserId +
                ";Password=" + Properties.Settings.Default.Password;

			Properties.Settings.Default.ChineseStudyConnection =
				 "Data Source=" + Properties.Settings.Default.SqlServer +
				";Initial Catalog=ChineseStudy"  +
				";Persist Security Info=True;User ID=" + Properties.Settings.Default.UserId +
				";Password=" + Properties.Settings.Default.Password;

            Properties.Settings.Default.Save();

			Close();
        }

        private void textUserPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buttonOK_Click(sender, e);
            }
        }
    }
}
