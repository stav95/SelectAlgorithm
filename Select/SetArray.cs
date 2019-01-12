using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Select
{
    public partial class SetArray : Form
    {
        public SetArray()
        {
            InitializeComponent();

            nudSelect.Maximum = nudLength.Value - 1;
            nudLength.ValueChanged += NudLength_ValueChanged;
        }

        private void NudLength_ValueChanged(object sender, EventArgs e)
        {
            nudSelect.Maximum = nudLength.Value - 1;
        }

        private void btnGenerateArray_Click(object sender, EventArgs e)
        {
            List<int> ls = GenerateList(int.Parse(nudMinValue.Value.ToString()),
                                        int.Parse(nudMaxValue.Value.ToString()),
                                        int.Parse(nudLength.Value.ToString()),
                                        true);

            tbArray.Text = string.Join(Environment.NewLine, ls);

            SortArray();
        }

        private void btnSortArray_Click(object sender, EventArgs e)
        {
            SortArray();
        }

        private List<int> GenerateList(int min, int max, int length, bool onlyUniq)
        {
            List<int> ls = new List<int>();
            Random ran = new Random();

            max++;
            while (ls.Count != length)
            {
                int n = ran.Next(min, max);

                if (ls.Contains(n) && onlyUniq)
                    continue;

                ls.Add(n);
            }

            return ls;
        }

        private void SortArray()
        {
            List<int> ls = new List<int>();

            tbArray.Text.Split('\n').ToList().ForEach(x => ls.Add(int.Parse(x)));

            ls = ls.Distinct().ToList();
            ls.Sort();

            tbSortedArray.Text = "";

            StringBuilder sb = new StringBuilder();
            int i = 0;
            for (; i < ls.Count - 1; i++)
                sb.Append(i.ToString() + ".\t" + ls[i] + Environment.NewLine);
            sb.Append(i.ToString() + ".\t" + ls[i]);

            tbSortedArray.Text = sb.ToString();
        }

        private void btnStartAlgorithm_Click(object sender, EventArgs e)
        {
            List<int> ls = new List<int>();

            tbArray.Text.Split('\n').ToList().ForEach(x => ls.Add(int.Parse(x)));

            ls = ls.Distinct().ToList();

            SelectAlgorithm sa = new SelectAlgorithm(ls.ToArray(), int.Parse(nudSelect.Value.ToString()));

            sa.Show();
        }
    }
}
