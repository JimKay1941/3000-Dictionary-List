using System;
using System.Globalization;
using System.Windows.Forms;

namespace _3000_Dictionary_List
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            object[] row = { Variables.Id.ToString(CultureInfo.InvariantCulture), Variables.FEseq, Variables.Zhuyin, Variables.Traditional, Variables.English, Variables.NumPinyin, Variables.CritPinyin, Variables.Simplified, Variables.Cji };
            dataGridFE_3000.Rows.Add(row); 
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //using (var FE = new Variables.Dictionary.GetLessonContext(Properties.Settings.Default.ChineseStudyConnectionString))
            using (var fe = new ChineseStudyDataContext())
            {
                var newrow = new _3000_Character
                {
                    FEseq = dataGridFE_3000.CurrentRow?.Cells[1].EditedFormattedValue.ToString(),
                    Zhuyin = dataGridFE_3000.CurrentRow?.Cells[2].EditedFormattedValue.ToString(),
                    Traditional = dataGridFE_3000.CurrentRow?.Cells[3].EditedFormattedValue.ToString(),
                    English = dataGridFE_3000.CurrentRow?.Cells[4].EditedFormattedValue.ToString(),
                    Numpinyin = dataGridFE_3000.CurrentRow?.Cells[5].EditedFormattedValue.ToString(),
                    CritPinyin = dataGridFE_3000.CurrentRow?.Cells[6].EditedFormattedValue.ToString(),
                    Simplified = dataGridFE_3000.CurrentRow?.Cells[7].EditedFormattedValue.ToString(),
                    Cji = dataGridFE_3000.CurrentRow?.Cells[8].EditedFormattedValue.ToString()
                };



                fe._3000_Characters.InsertOnSubmit(newrow);
                fe.SubmitChanges();
                Close();
            }
        }
    }
}
