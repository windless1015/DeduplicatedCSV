using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindDifferentItems
{
    public partial class Form1 : Form
    {
        string mainCSVFilePath; //main file to be modified
        string referCSVFilePath; // refer file to be compared

        private class OneItem
        {
            public OneItem(int r, string s, string h)
            {
                rowNo = r;
                ad_group = s;
                hierarchy = h;
            }
            public int rowNo;
            public string ad_group;
            public string hierarchy;
        }

        public Form1()
        {
            InitializeComponent();
            mainCSVFilePath = "";
            referCSVFilePath = "";
        }

        private void btn_mainCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c://";
            openFileDialog.Filter = "CSV文件|*.csv*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mainCSVFilePath = openFileDialog.FileName;
                lb_main.Text = mainCSVFilePath;
            }  

        }

        private void btn_reference_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c://";
            openFileDialog.Filter = "CSV文件|*.csv*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                referCSVFilePath = openFileDialog.FileName;
                lb_ref.Text = referCSVFilePath;
            }
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            //mainCSVFilePath = @"D:\DownloadFiles\Google\598619591.csv";
            //referCSVFilePath = @"D:\DownloadFiles\Google\126902550.csv";
            if (mainCSVFilePath == "" || referCSVFilePath == "")
                return;
            List<OneItem> mainCSVList = new List<OneItem>();
            //read the AD Group data from the main file, from row 2
            var reader = new StreamReader(mainCSVFilePath);
            int count = 1;
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    count++;
                    string ad_group = csv.GetField(0); //the first colum value, ad_group
                    string hierachy = csv.GetField(1);
                    mainCSVList.Add(new OneItem(count, ad_group, hierachy));
                }
            }

            //read data from reference file
            List<OneItem> refCSVList = new List<OneItem>();
            //read the AD Group data from the main file, from row 2
            var refReader = new StreamReader(referCSVFilePath);
            int refCount = 1;
            using (var csv = new CsvReader(refReader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    refCount++;
                    string ad_group = csv.GetField(0); //the first colum value, ad_group
                    string hierachy = csv.GetField(1);
                    refCSVList.Add(new OneItem(refCount, ad_group, hierachy));
                }
            }

            //获取相同的部分
            List<OneItem> intersectList = GetIntersect(ref mainCSVList, ref refCSVList);
            for (int i = 0; i < intersectList.Count; i++)
            {
                OneItem item = intersectList[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.rowNo.ToString();
                lvi.SubItems.Add(item.ad_group);
                lv_same.Items.Add(lvi);
            }
            //不同部分
            List<OneItem> diffParts = GetDifferentPartFromMain(ref mainCSVList, ref refCSVList);
            for (int i = 0; i < diffParts.Count; i++)
            {
                OneItem item = diffParts[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.rowNo.ToString();
                lvi.SubItems.Add(item.ad_group);
                lv_different.Items.Add(lvi);
            }

            label_same_num.Text = "有效行数:" + intersectList.Count.ToString();
            label_diff_num.Text = "有效行数:" + diffParts.Count.ToString();


            //生成原始行数的新文件
            //GenerateOriNumberNewFile(ref diffParts);
            //生成新行数的新文件
            GenerateNewNumberNewFile(ref diffParts);
            //MessageBox.Show("你看看桌面有啥!");
        }

        List<OneItem> GetIntersect(ref List<OneItem> mainList, ref List<OneItem> refList)
        {
            List<OneItem> intersect = new List<OneItem>();
            //traverse the mainList, put every entry to search in the refList, I don't use the very compicated method, just use the  O(n^2) time complexity
            foreach (var item in mainList)
            {
                for (int i = 0; i < refList.Count; i++)
                {
                    if (item.ad_group == refList[i].ad_group)
                    {
                        intersect.Add(item);
                    }
                }
            }
            return intersect;
        }

        List<OneItem> GetDifferentPartFromMain(ref List<OneItem> mainList, ref List<OneItem> refList)
        {
            bool isSame = false;
            List<OneItem> diffPart = new List<OneItem>();
            foreach (var item in mainList)
            {
                isSame = false;
                for (int i = 0; i < refList.Count; i++)
                {
                    if (item.ad_group == refList[i].ad_group)
                    {
                        isSame = true;
                    }
                }
                if (!isSame)
                {
                    diffPart.Add(item);
                }

            }
            return diffPart;
        }

        //void GenerateOriNumberNewFile(ref List<OneItem> different)
        //{

        //    string desktopPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
        //    var writer = new StreamWriter(desktopPath+@"\原始编号.csv");
        //    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        //    {
        //        csv.WriteField("AD Group");
        //        csv.WriteField("LDAP Hierarchy");
        //        csv.NextRecord();
        //        foreach (var one in different)
        //        {
        //            csv.WriteField(one.rowNo);
        //            csv.WriteField(one.ad_group);
        //            csv.WriteField(one.hierarchy);
        //            csv.NextRecord();
        //        }
        //    }
        //}



        void GenerateNewNumberNewFile(ref List<OneItem> different)
        {

            string desktopPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
            var writer = new StreamWriter(desktopPath + @"\新编号.csv");
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteField("AD Group");
                csv.WriteField("LDAP Hierarchy");
                csv.NextRecord();
                foreach (var one in different)
                {
                    //csv.WriteField(count++);
                    csv.WriteField(one.ad_group);
                    csv.WriteField(one.hierarchy);
                    csv.NextRecord();
                }
            }
        }




    }
}
