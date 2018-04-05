﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using AeroGear.Mobile.Core.Exception;
using Xamarin.Forms;

namespace AeroGear.Mobile.Core.Platform.Android
{
    public sealed class MobileCoreInitializer
    {
        /// <summary>
        /// Initializes Mobile core for Android.
        /// </summary>
        /// <param name="app">Xamarin.Forms.Application object</param>
        public static void Init(Application app)
        {
            Init(app, new Options());
        }

        /// <summary>
        /// Initializes Mobile core for Android.
        /// </summary>
        /// <param name="app">Xamarin.Forms.Application object</param>
        /// <param name="options">additional initialization options</param>
        public static void Init(Application app, Options options)
        {
            MobileCore.Init(new AndroidPlatformInjector(app.GetType().Assembly),options);
        }
    }
}