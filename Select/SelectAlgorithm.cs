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
    public partial class SelectAlgorithm : Form
    {
        public SelectAlgorithm(int[] array, int k)
        {
            InitializeComponent();

            Select(CopyArray(array), k, tcMain);
        }

        private int[] CopyArray(int[] a)
        {
            int[] copy = new int[a.Length];

            Array.Copy(a, copy, copy.Length);

            return copy;
        }

        private int Select(int[] arr, int k, TabControl tabControl)
        {
            if (arr.Length <= 10)
                return Find(CopyArray(arr), k);

            int pivotNumber = ChooseWisePivot(CopyArray(arr), tabControl);
            List<int> copy = arr.ToList();
            int pivotIndex = Partition(ref arr, pivotNumber);

            TabControl t = null;
            string page = "Partition";
            GUI_Manager.AddPage(tabControl, page);
            t = GUI_Manager.AddPartition(tabControl, page, copy, arr.ToList(), pivotIndex, pivotNumber, k);

            if (k <= pivotIndex)
            {
                int[] a1 = CreateArraySmaller_BiggerThanPivot(CopyArray(arr), pivotNumber, true);

                if (a1.Length <= 10)
                    GUI_Manager.AddFinalResult(t ?? tabControl, a1.ToList(), k);

                int right = Select(CopyArray(a1), k, t ?? tabControl);
                return right;
            }
            else
            {
                int[] a2 = CreateArraySmaller_BiggerThanPivot(CopyArray(arr), pivotNumber, false);

                if (a2.Length <= 10)
                    GUI_Manager.AddFinalResult(t ?? tabControl, a2.ToList(), k - pivotIndex);

                int left = Select(CopyArray(a2), k - pivotIndex, t ?? tabControl);
                return left;
            }
        }

        private int[] CreateArraySmaller_BiggerThanPivot(int[] arr, int p, bool smallerArray)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (smallerArray)
                {
                    if (arr[i] <= p)
                        list.Add(arr[i]);
                }
                else
                    if (arr[i] >= p)
                    list.Add(arr[i]);
            }

            return list.ToArray();
        }

        private int Partition(ref int[] arr, int p)
        {
            int r = arr.Length - 1;
            int l = 0;

            while (true)
            {
                while (arr[l] < p) l++;
                while (arr[r] >= p) r--;

                if (l >= r)
                    return l;
                else
                {
                    //Swap
                    int tmp = arr[l];

                    arr[l] = arr[r];
                    arr[r] = tmp;
                }
            }
        }

        private int ChooseWisePivot(int[] arr, TabControl tabControl)
        {
            GUI_Manager.AddArrayPage(tabControl, arr.ToList());

            string page = "Split Array";
            TabPage p = GUI_Manager.AddPage(tabControl, page);
            TreeView tv = GUI_Manager.CreateTreeView(p);

            List<int> b = new List<int>();

            int iMax = (int)Math.Ceiling(arr.Length / 5.0);
            int[] m = new int[iMax];
            int index = 0, i = 0;

            while (i != arr.Length)
            {
                b.Add(arr[i++]);

                if (b.Count == 5)
                {
                    page = index.ToString();

                    GUI_Manager.AddList(tv, b, page);

                    b.Sort();
                    m[index++] = b[2];
                    b.Clear();
                }
            }

            if (iMax != index)
            {
                page = index.ToString();

                GUI_Manager.AddList(tv, b, page);

                b.Sort();
                m[index] = b[(int)Math.Floor(b.Count / 2.0)];
            }

            tv.ExpandAll();

            TabControl tControl = null;
            int half = (int)Math.Ceiling(m.Length / 2.0) - 1;
            int meridian = -1;

            if (iMax > 10)
            {
               
                page = "Select Split Array";
                GUI_Manager.AddPage(tabControl, page);
                tControl = GUI_Manager.AddTabControl(tabControl, page);
                meridian = Select(CopyArray(m), half, tControl);
            }
            else
            {
                meridian = Select(CopyArray(m), half, tControl);
                GUI_Manager.AddSummarySplit(tabControl, m.ToList(), meridian);
            }

            return meridian;
        }

        private int Find(int[] arr, int k)
        {
            BubbleSort(ref arr);

            return arr[k];
        }

        private void BubbleSort(ref int[] arr)
        {
            var tmp = arr.ToList();

            tmp.Sort();

            for (int i = 0; i < arr.Length; i++)
                arr[i] = tmp[i];
        }
    }
}
