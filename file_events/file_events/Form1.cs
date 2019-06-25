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
        //private List<Subscriber> subscribers;
        private Subscriber subscriber;

        private void button1_Click(object sender, EventArgs e) {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                myFileSystemWatchers.Add(
                    new MyFileSystemWatcher(folderBrowserDialog.SelectedPath)
                    );

                cmbFolders.Items.Add(folderBrowserDialog.SelectedPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            myFileSystemWatchers = new List<MyFileSystemWatcher>();
            //subscribers = new List<Subscriber>();
            subscriber= new Subscriber();
        }

        private void timer_Tick(object sender, EventArgs e) {
            foreach (var watcher in myFileSystemWatchers) {
                if (watcher.SubscribersCount>=1) {
                    watcher.CheckPath();
                }
            }
        }

        private void btnAddSubscriber_Click(object sender, EventArgs e) {
            string selectedPathName = cmbFolders.GetItemText(cmbFolders.SelectedItem);
            MyFileSystemWatcher watcher = myFileSystemWatchers.First(w => w.WatchingPath == selectedPathName);
            watcher.Changed += subscriber.Message;
        }

        private void btnDelSubscriber_Click(object sender, EventArgs e) {
            string selectedPathName = cmbFolders.GetItemText(cmbFolders.SelectedItem);
            MyFileSystemWatcher watcher = myFileSystemWatchers.First(w => w.WatchingPath == selectedPathName);
            watcher.Changed -= subscriber.Message;
        }
    }
}
