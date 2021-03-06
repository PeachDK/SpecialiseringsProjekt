﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SpecialiseringsProjekt;
using Xamarin.Forms;
using ZXing.Mobile;

[assembly: Dependency(typeof(SpecialiseringsProjekt.Droid.QR))]

namespace SpecialiseringsProjekt.Droid
{
    public class QR : IQR
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions()
            {
                AutoRotate = false,
                TryHarder = true,
                UseFrontCameraIfAvailable = false,

            };
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",

            };

            var scanResult = await scanner.Scan(optionsDefault);
            return scanResult.Text;
        }
    }
}