using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LottoBayernAnalyzer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.Text = AssemblyInfo.OneStringInfo;
        }


        #region Event Handlers


        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                var data = Data.Lotto6from49.GetArchiveData(
                    Properties.Resources.Lotto6from49ArchiveUrl,
                    Properties.Resources.Lotto6from49Filename);
            }
            catch (Exception ex)
            {
                MsgBox.Error("Error getting data: {0}", ex.Message);
            }
        }


        private void ImgType_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.Lotto6from49Url);
        }


        #endregion
    }
}
