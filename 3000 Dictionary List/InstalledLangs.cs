using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace _3000_Dictionary_List
{
    public partial class InstalledLangs : Form
    {
        int _index;
        public InstalledLangs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate_number(Known.Text) != true)
            {
                Known.Text = @"0";
                Say.Text = @"Known has invalid value";
                return;
            }
            Say.Text = "";

            Properties.Settings.Default.Know = Convert.ToInt32(Known.Text);

            if (Properties.Settings.Default.Know > _index)
            {
                Say.Text = @"Know value out of range";
                return;
            }

            Properties.Settings.Default.Studying = Convert.ToInt32(Studying.Text);

            if (Properties.Settings.Default.Studying > _index)
            {
                Say.Text = @"Studying value out of range";
                return;
            }


            Properties.Settings.Default.Save();
            Close();
        }

        private void InstalledLangs_Load(object sender, EventArgs e)
        {
            Known.Text = Properties.Settings.Default.Know.ToString(CultureInfo.InvariantCulture);
            Studying.Text = Properties.Settings.Default.Studying.ToString(CultureInfo.InvariantCulture);

            listLangs.BeginUpdate();
            listLangs.Items.Clear();

            _index = 0;

            foreach (var langString in from InputLanguage lang in InputLanguage.InstalledInputLanguages select _index.ToString(CultureInfo.InvariantCulture) + " : " + lang.LayoutName)
            {
                listLangs.Items.Add(langString);

                _index++;
            }

            _index--;

            listLangs.EndUpdate();
        }

        private static bool validate_number(string textbox)
        {
            if (textbox.Length != 1)
            {
                return false;
            }
            switch (textbox[0])
            {
                case '9':
                case '8':
                case '7':
                case '6':
                case '5':
                case '4':
                case '3':
                case '2':
                case '1':
                case '0':
                    return true;
            }
            return false;
        }
    }
}
