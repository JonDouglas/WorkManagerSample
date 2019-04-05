using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Work;

namespace WorkManagerSample.Droid
{
    public class CalculatorWorker : Worker
    {
        public CalculatorWorker(Context context, WorkerParameters workerParameters) : base(context, workerParameters)
        {

        }
        public override Result DoWork()
        {
            var taxReturn = CalculateTaxes();
            Android.Util.Log.Debug("CalculatorWorker", $"Your Tax Return is: {taxReturn}");
            return Result.InvokeSuccess();
        }

        public double CalculateTaxes()
        {
            return 2000;
        }
    }
}