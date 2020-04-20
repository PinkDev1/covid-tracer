﻿using Android.App;
using Android.Content;
using Android.OS;
using CovidTracer.Services;

namespace CovidTracer.Droid
{
    /** Runs the tracer service inside an Android service. */
    [Service]
    public class AndroidTracerService : Service
    {
        public AndroidTracerService()
        {
        }

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override StartCommandResult OnStartCommand(
            Intent intent, StartCommandFlags flags, int startId)
        {
            MainActivity.TracerService.Start();

            return StartCommandResult.Sticky;
        }
    }
}
