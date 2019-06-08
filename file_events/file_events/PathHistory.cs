using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_events {
    class PathHistory {
        public readonly string fileName;
        private Dictionary<DateTime, FileChangeTypes> changesHistory;

        PathHistory(string fileName) {
            this.fileName = fileName;
            this.changesHistory = new Dictionary<DateTime, FileChangeTypes>();
        }

        public void AddChange(DateTime dt, FileChangeTypes fileChangeType) {
            this.changesHistory[dt] = fileChangeType;
        }
    }
}
