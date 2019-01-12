using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Select
{
    public static class GUI_Manager
    {
        public static TabPage AddPage(TabControl tc, string key)
        {
            tc.TabPages.Add(key, key);
            return tc.TabPages[key];
        }

        public static TreeView CreateTreeView(TabPage p)
        {
            TreeView tv = new TreeView()
            {
                Location = new Point(20, 30),
                Size = new Size(300, 400),
                Scrollable = true,
                BackColor = p.BackColor,
                BorderStyle = BorderStyle.Fixed3D
            };

            p.Controls.Add(tv);

            return tv;
        }

        public static void AddArrayPage(TabControl tc, List<int> items)
        {
            TabPage p = AddPage(tc, "Array");

            ListBox lbBefore = new ListBox()
            {
                Location = new Point(25, 50),
                Width = 150,
                Height = 400,
                ScrollAlwaysVisible = true
            };
            Label lBefore = new Label()
            {
                Location = new Point(20, 20),
                Font = new Font("Arial", 16, FontStyle.Bold),
                Text = "Array:"
            };

            int line = 0;
            items.ForEach(x => { lbBefore.Items.Add(line + ".\t" + x); line++; });

            p.Controls.Add(lBefore);
            p.Controls.Add(lbBefore);
        }

        public static void AddList(TreeView tv, List<int> items, string value)
        {
            TreeNode node = new TreeNode()
            {
                Text = value
            };

            node.Nodes.Add(string.Join(" ", items));
            items.Sort();
            int meridian = items[(int)Math.Floor(items.Count / 2.0)];
            node.Nodes.Add(string.Format("{0} Sorted, {1}", string.Join(" ", items), meridian));

            tv.Nodes.Add(node);
        }

        public static void AddList(TabControl tc, string page, List<int> items)
        {
            List<int> copy = new List<int>(items);

            TextBox tb = new TextBox();
            TextBox tbSorted = new TextBox();
            Label mid = new Label();

            tc.TabPages[page].Controls.Add(tb);
            tc.TabPages[page].Controls.Add(tbSorted);
            tc.TabPages[page].Controls.Add(mid);

            tb.Text = string.Join(" ", copy);
            tb.Width = tc.Width - 60;
            tb.Height = 25;
            tb.Location = new Point(20, 30);

            copy.Sort();

            tbSorted.Text = string.Join(" ", copy);
            tbSorted.Width = tc.Width - 60;
            tbSorted.Height = 25;
            tbSorted.Location = new Point(20, 70);

            mid.Text = copy[2].ToString();
            mid.Width = 100;
            mid.Height = 25;
            mid.Location = new Point(20, 110);
            mid.Font = new Font("Arial", 16, FontStyle.Bold);
        }

        public static void AddSummarySplit(TabControl tc, List<int> splitM, int meridian)
        {
            TabPage p = AddPage(tc, "Split Summary");

            ListBox lbBefore = new ListBox()
            {
                Location = new Point(25, 50),
                Width = 150,
                Height = 400,
                ScrollAlwaysVisible = true
            };
            ListBox lbAfter = new ListBox()
            {
                Location = new Point(200, 50),
                Width = 150,
                Height = 400,
                ScrollAlwaysVisible = true
            };
            Label lBefore = new Label()
            {
                Location = new Point(20, 20),
                Font = new Font("Arial", 16, FontStyle.Bold),
                Text = "Before:"
            };
            Label lAfter = new Label()
            {
                Location = new Point(195, 20),
                Font = new Font("Arial", 16, FontStyle.Bold),
                Text = "After:"
            };
            Label lIndex = new Label()
            {
                Location = new Point(370, 240),
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.Red,
                Text = string.Format("Meridian Value: {0}", meridian),
                Width = 600,
                Height = 500
            };

            int line = 1;
            splitM.ForEach(x => { lbBefore.Items.Add(line + ".\t" + x); line++; });
            line = 1;
            splitM.Sort();
            splitM.ForEach(x => { lbAfter.Items.Add(line + ".\t" + x); line++; });

            p.Controls.Add(lBefore);
            p.Controls.Add(lAfter);
            p.Controls.Add(lIndex);
            p.Controls.Add(lbBefore);
            p.Controls.Add(lbAfter);
        }

        public static TabControl AddTabControl(TabControl tc, string page)
        {
            TabControl tabControl = new TabControl();
            tc.TabPages[page].Controls.Add(tabControl);
            tabControl.Dock = DockStyle.Fill;
            return tabControl;
        }

        public static TabControl AddPartition(TabControl tc, string page, List<int> items, List<int> afterP, int pivotIndex, int pivotValue, int k)
        {
            TabControl tabControl = AddTabControl(tc, page);

            tc.TabPages[page].Controls.Add(tabControl);
            tabControl.Dock = DockStyle.Fill;

            var p = AddPage(tabControl, "Result");

            ListBox lbBefore = new ListBox()
            {
                Location = new Point(25, 50),
                Width = 150,
                Height = 400,
                ScrollAlwaysVisible = true
            };
            ListBox lbAfter = new ListBox()
            {
                Location = new Point(200, 50),
                Width = 150,
                Height = 400,
                ScrollAlwaysVisible = true
            };
            Label lBefore = new Label()
            {
                Location = new Point(20, 20),
                Font = new Font("Arial", 16, FontStyle.Bold),
                Text = "Before:"
            };
            Label lAfter = new Label()
            {
                Location = new Point(195, 20),
                Font = new Font("Arial", 16, FontStyle.Bold),
                Text = "After:"
            };
            Label lIndex = new Label()
            {
                Location = new Point(370, 140),
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.Red,
                Width = 600,
                Height = 500
            };

            string side = "Right";
            if (k <= pivotIndex)
                side = "Left";
            lIndex.Text = string.Format("K is: {0}\n\nPivot Index: {1}\nPivot Value: {2}\n\nWe Take The *{3}* Side", k, pivotIndex + 1, pivotValue, side);

            int line = 0;
            items.ForEach(x => { lbBefore.Items.Add(line + ".\t" + x); line++; });
            line = 0;
            afterP.ForEach(x => { lbAfter.Items.Add(line + ".\t" + x); line++; });

            p.Controls.Add(lBefore);
            p.Controls.Add(lAfter);
            p.Controls.Add(lIndex);
            p.Controls.Add(lbBefore);
            p.Controls.Add(lbAfter);

            return tabControl;
        }

        public static void AddFinalResult(TabControl tc, List<int> items, int k)
        {
            TabPage p = AddPage(tc, "Final Result");


            ListBox lbBefore = new ListBox()
            {
                Location = new Point(25, 50),
                Width = 150,
                Height = 400,
                ScrollAlwaysVisible = true
            };
            ListBox lbAfter = new ListBox()
            {
                Location = new Point(200, 50),
                Width = 150,
                Height = 400,
                ScrollAlwaysVisible = true
            };
            Label lBefore = new Label()
            {
                Location = new Point(20, 20),
                Font = new Font("Arial", 16, FontStyle.Bold),
                Text = "Before:"
            };
            Label lAfter = new Label()
            {
                Location = new Point(195, 20),
                Font = new Font("Arial", 16, FontStyle.Bold),
                Text = "After:"
            };
            Label lResult = new Label()
            {
                Location = new Point(370, 140),
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.Red,
                Width = 600,
                Height = 500
            };

            int counter = 0;
            items.ForEach(x => { lbBefore.Items.Add(counter + ".\t" + x); counter++; });
            counter = 0;
            items.Sort();
            items.ForEach(x => { lbAfter.Items.Add(counter + ".\t" + x); counter++; });

            lResult.Text = string.Format("K: {0}\n\nResult: {1}", k, items[k]);

            p.Controls.Add(lBefore);
            p.Controls.Add(lAfter);
            p.Controls.Add(lResult);
            p.Controls.Add(lbBefore);
            p.Controls.Add(lbAfter);
        }
    }
}
