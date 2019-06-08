using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_events {
    public delegate void  ChangedContainer();


    class MyFileSystemWatcher {
        Dictionary<string, DateTime> filenamesWithDates;
        public int SubscribersCount { get; set; } = 0;

        public string WatchingPath { get; private set; }
        //public Guid Uid { get; private set; }

        public MyFileSystemWatcher(string path) {
            filenamesWithDates = new Dictionary<string, DateTime>();

            WatchingPath = path;
            //this.Uid = Guid.NewGuid();
        }

        //public event ChangedContainer FileCreated;
        //public event ChangedContainer FileUpdated;
        //public event ChangedContainer FileDeleted;
        public event ChangedContainer Changed;

        public  void CheckPath() {
            //string[] filenames = Directory.GetFiles(WatchingPath);

            //foreach (var filename in filenames) {
            //    if (!filenamesWithDates.ContainsKey(filename)) {
            //        filenamesWithDates[filename] = DateTime.Now;

            //        FileCreated();
            //    }
            //}
            FileInfo[] fiArr= new DirectoryInfo(WatchingPath).GetFiles();

            foreach (var fi in fiArr) {
                if (!filenamesWithDates.ContainsKey(fi.Name)) {
                    filenamesWithDates[fi.Name] = fi.LastWriteTime;

                    FileCreated();
                }
            }

            foreach (var fi in fiArr) {
                if (filenamesWithDates.ContainsKey(fi.Name) 
                && filenamesWithDates[fi.Name] != fi.LastWriteTime) {
                    filenamesWithDates[fi.Name] = fi.LastWriteTime;

                    FileUpdated();
                }
            }

            //var keysTmp = new List<string>();
            //foreach (var k in filenamesWithDates.Keys) {
            //    if (!fiArr.Any(fi=>fi.Name==k)){
            //        keysTmp.app
            //    }
            //}

            var keys = filenamesWithDates.Keys.ToArray();
            //var fileNames = fiArr.SelectMany(fi => fi.Name).ToArray(); 
            var fileNames = fiArr.Select(fi => fi.Name).ToArray();
            var keysForDelete = keys.Except(fileNames);

            foreach (var k in keysForDelete) {
                filenamesWithDates.Remove(k);

                FileDeleted();
            }

        }
    }
}
