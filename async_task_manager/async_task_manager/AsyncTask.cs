using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace async_task_manager {
    

    public class AsyncTask {
        public delegate double CalculateHandler();

        //delegate double DiskriminantFunction(double a, double b, double c);

        public Func<double, double, double, double> DiskriminantTaskBody;

        //ManualResetEvent manualResetEvent;

        //public static AutoResetEvent AutoResetEvent = new AutoResetEvent(true);

        public AsyncTask() {
            DiskriminantTaskBody = (a, b, c) => b * b - 4 * a * c;
        }

        public double GetDiskriminant() {
            var rand = new Random();

            //double a = rand.NextDouble() * 10.0 - 3.0;
            //double b = rand.NextDouble() * 21.0 - 15.0;
            //double c = rand.NextDouble() * 33.0 - 19.5;

            double discriminant = DiskriminantTaskBody(
                rand.NextDouble() * 10.0 - 3.0,
                rand.NextDouble() * 21.0 - 15.0,
                rand.NextDouble() * 33.0 - 19.5
                );

            //AutoResetEvent.Set();

            return discriminant;
        }

        public double GetDiskriminantAsync() {
            var rand = new Random();

            double discriminant = DiskriminantTaskBody(
                rand.NextDouble() * 10.0 - 3.0,
                rand.NextDouble() * 21.0 - 15.0,
                rand.NextDouble() * 33.0 - 19.5
                );

            return discriminant;
        }

        public event CalculateHandler GetDiskriminantComplete; 
    }
}
