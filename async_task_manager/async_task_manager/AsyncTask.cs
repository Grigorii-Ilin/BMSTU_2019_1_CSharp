using System;
using System.Collections.Generic;
using System.Text;

namespace async_task_manager {
    public class MyAsyncTask {
        public Func<double, double, double, double> DiskriminantTaskBody = (a, b, c) => b * b - 4 * a * c;

    }
}
