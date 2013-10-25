﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Drawing;

namespace TrifleJS
{
    /// <summary>
    /// Browser class that represents an IE window
    /// </summary>
    public class Browser : System.Windows.Forms.WebBrowser
    {
        private const string IEEmulationPathx32 = @"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
        private const string IEEmulationPathx64 = @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";

        /// <summary>
        /// Emulate a version of IE using the relevant registry keys
        /// @see http://www.west-wind.com/weblog/posts/2011/May/21/Web-Browser-Control-Specifying-the-IE-Version
        /// </summary>
        /// <param name="ieVersion">The version of IE to emulate (IE7, IE8, IE9 etc)</param>
        public static void Emulate(string ieVersion)
        {
            System.UInt32 dWord;
            switch (ieVersion)
            {
                case "IE10_IgnoreDoctype": dWord = 0x2711u;
                    break;
                case "IE10": dWord = 0x02710u;
                    break;
                case "IE9_IgnoreDoctype": dWord = 0x270Fu;
                    break;
                case "IE9": dWord = 0x2328u;
                    break;
                case "IE8_IgnoreDoctype": dWord = 0x22B8u;
                    break;
                case "IE8": dWord = 0x1F40u;
                    break;
                case "IE7": dWord = 0x1B58u;
                    break;
                default:
                    throw new Exception("Incorrect IE version: " + ieVersion);
            }
            Utils.Debug("Setting Version to " + ieVersion);
            Utils.TryWriteRegistryKey(IEEmulationPathx32, "TrifleJS.exe", dWord, RegistryValueKind.DWord);
            Utils.TryWriteRegistryKey(IEEmulationPathx64, "TrifleJS.exe", dWord, RegistryValueKind.DWord);
        }

        /// <summary>
        /// Waits until window finishes loading and then takes a screenshot
        /// </summary>
        /// <param name="fileName">path where the screenshot is saved</param>
        public void RenderOnLoad(string fileName)
        {
            this.DocumentCompleted += delegate
            {
                Utils.Debug("WebBrowser#DocumentCompleted");
                this.Size = this.Document.Window.Size;
                this.ScrollBarsEnabled = false;
                Render(fileName);
                Console.WriteLine("Screenshot rendered to file: " + fileName);
            };
        }

        /// <summary>
        /// Takes a screenshot and saves into a file
        /// </summary>
        /// <param name="filename">path where the screenshot is saved</param>
        public void Render(string filename) {
            using (var pic = this.Render())
            {
                pic.Save(filename);
            }
        }

        /// <summary>
        /// Takes a screenshot and saves into a Bitmap of specific dimensions
        /// </summary>
        /// <param name="width">bitmap width</param>
        /// <param name="height">bitmap height</param>
        /// <returns></returns>
        public Bitmap Render(int width, int height) {
            Size originalSize = this.Size;
            this.Size = new Size(width, height);
            Bitmap output = this.Render();
            this.Size = originalSize;
            return output;
        }

        /// <summary>
        /// Takes a screenshot and saves into a Bitmap
        /// </summary>
        /// <returns></returns>
        public Bitmap Render() {
            Bitmap output = new Bitmap(this.Width, this.Height);
            NativeMethods.GetImage(this.ActiveXInstance, output, Color.White);
            return output;
        }

        /// <summary>
        /// Tries to parse a URL, otherwise returns null
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Uri TryParse(string url)
        {
            Uri uri;
            try { uri = new Uri(url); }
            catch { return null; }
            return uri;
        }

    }
}
