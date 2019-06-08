using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_events {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private List<MyFileSystemWatcher> myFileSystemWatchers;

        private void button1_Click(object sender, EventArgs e) {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                //MessageBox.Show(folderBrowserDialog1.SelectedPath);
                myFileSystemWatchers.Add(
                    new MyFileSystemWatcher(folderBrowserDialog.SelectedPath)
                    );

                cmbFolders.Items.Add(folderBrowserDialog.SelectedPath);
                //cmbFolders.Invalidate();

                //cmbFolders.CreateControl();
            }

        }

        private void Form1_Load(object sender, EventArgs e) {
            myFileSystemWatchers = new List<MyFileSystemWatcher>();


            //this.Controls.Add(cmbFolders);
            //cmbFolders.DataSource = null;
            //cmbFolders.DataSource = myFileSystemWatchers;
            //cmbFolders.DisplayMember = "WatchingPath";
            //cmbFolders.ValueMember = "Uid";
            
            
        }
    }
}
