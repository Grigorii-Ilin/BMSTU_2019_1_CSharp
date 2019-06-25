using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_events {
    public class FileHistory {
        public readonly string fileName;
        private SortedDictionary<DateTime, FileChangeTypes> changesHistory;

        public FileHistory(string fileName) {
            this.fileName = fileName;
            this.changesHistory = new SortedDictionary<DateTime, FileChangeTypes>();
        }

        public void AddChange(DateTime dt, FileChangeTypes fileChangeType) {
            changesHistory[dt] = fileChangeType;
        }

        public DateTime GetLastChangeTime() {
            return changesHistory.Keys.Last();
        }

        public FileChangeTypes GetLastChangeType() {
            return changesHistory.Values.Last();
        }
    }
}
