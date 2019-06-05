using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_events {
    public delegate void  MethodContainer();


    class MyFileSystemWatcher {
        public string WatchingPath { get; private set; }
        public Guid Uid { get; private set; }

        public MyFileSystemWatcher(string path) {
            this.WatchingPath = path;
            this.Uid = Guid.NewGuid();
        }

        public event MethodContainer FileCreated;
        public event MethodContainer FileUpdated;
        public event MethodContainer FileDeleted;
    }
}
