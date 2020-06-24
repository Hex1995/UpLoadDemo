using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpLoad.Lib;

namespace UpLoad.Win
{
    public partial class UpLoad : Form
    {
        public UpLoad()
        {
            InitializeComponent();
        }
        string[] filepath=new string[] { };
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog rfd = new OpenFileDialog();
            rfd.Multiselect = true;
            var res = rfd.ShowDialog();


            if (res== DialogResult.OK)
            {
                filepath = rfd.FileNames;
            }
            if (filepath.Count()>0)
            {
                WriteMsg("选择的文件有：\r\n");
                foreach (var item in filepath)
                {
                    WriteMsg(item +">>>>>>>>>>大小："+ FileHelper.GetFileSizeString(item) + "\r\n");
                }
            }


        }


        public void WriteMsg(string msg)
        {
            RicMsg.AppendText(msg);
        }
    }
}
