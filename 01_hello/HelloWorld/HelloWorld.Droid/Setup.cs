﻿using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using Acr.UserDialogs;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;

namespace HelloWorld.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup (Context applicationContext) : base (applicationContext)
        {
          
        }

        protected override IMvxApplication CreateApp ()
        {
            return new Core.App ();
        }

        protected override IMvxTrace CreateDebugTrace ()
        {
            return new DebugTrace ();
        }

        protected override void InitializeIoC()
        {
            base.InitializeIoC();
               UserDialogs.Init(() => Mvx.Resolve<IMvxAndroidCurrentTopActivity>().Activity);
        }
    }
}
