using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_events {
    public delegate void ChangedContainer(DateTime changedDT, FileHistory fileHistory);

    class MyFileSystemWatcher {
        public int SubscribersCount { get; private set; } = 0;

        public readonly string WatchingPath;
        private List<FileHistory> pathHistoryList;

        public MyFileSystemWatcher(string path) {
            this.WatchingPath = path;
            this.pathHistoryList = new List<FileHistory>();
        }

        public event ChangedContainer Changed 
            {
            add 
                {
                changed += value;
                SubscribersCount++;
            }
            remove {
                changed -= value;
                SubscribersCount--;
            }
        }
        private ChangedContainer changed;

        public  void CheckPath() {
            var now = DateTime.Now;
            FileInfo[] fileInfoArray= new DirectoryInfo(WatchingPath).GetFiles();

            var pathFileNames = fileInfoArray.Select(f => f.Name).ToArray();
            var historyFileNames= pathHistoryList.Select(f=>f.fileName).ToArray();

            var fileNamesForAdd = pathFileNames.Except(historyFileNames);
            foreach (var fnForAdd in fileNamesForAdd) {
                var fileHistory = new FileHistory(fnForAdd);
                fileHistory.AddChange(now, FileChangeTypes.created);
                changed?.Invoke(now, fileHistory);
                pathHistoryList.Add(fileHistory);
            }


            foreach (var fileInfo in fileInfoArray) {
                foreach (var fileHistory in pathHistoryList) {
                    if ((fileInfo.Name == fileHistory.fileName)
                    && (fileInfo.LastWriteTime > fileHistory.GetLastChangeTime())) {
                        fileHistory.AddChange(now, FileChangeTypes.updated);
                        changed?.Invoke(now, fileHistory);
                    }
                }
            }

            var fileNamesForDel = historyFileNames.Except(pathFileNames);

            foreach (var fnForDel in fileNamesForDel) {
                foreach (var fileHistory in pathHistoryList) {
                    if ((fileHistory.fileName== fnForDel)
                    &&(fileHistory.GetLastChangeType()!=FileChangeTypes.deleted)) {
                        fileHistory.AddChange(now, FileChangeTypes.deleted);
                        changed(now, fileHistory);

                    }
                }
            }

        }
    }
}
