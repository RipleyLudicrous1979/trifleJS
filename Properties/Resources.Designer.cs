﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5472
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrifleJS.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TrifleJS.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to var isCommonJS = typeof window == &quot;undefined&quot;;
        ///
        ////**
        ///* Top level namespace for Jasmine, a lightweight JavaScript BDD/spec/testing framework.
        ///*
        ///* @namespace
        ///*/
        ///var jasmine = {};
        ///if (isCommonJS) exports.jasmine = jasmine;
        ////**
        ///* @private
        ///*/
        ///jasmine.unimplementedMethod_ = function() {
        ///    throw new Error(&quot;unimplemented method&quot;);
        ///};
        ///
        ////**
        ///* Use &lt;code&gt;jasmine.undefined&lt;/code&gt; instead of &lt;code&gt;undefined&lt;/code&gt;, since &lt;code&gt;undefined&lt;/code&gt; is just
        ///* a plain old variable and may be redefined by some [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string jasmine {
            get {
                return ResourceManager.GetString("jasmine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to jasmine.ConsoleReporter = function(print, doneCallback, showColors) {
        ///    //inspired by mhevery&apos;s jasmine-node reporter
        ///    //https://github.com/mhevery/jasmine-node
        ///
        ///    doneCallback = doneCallback || function() { };
        ///
        ///    var ansi = {
        ///        green: &apos;\033[32m&apos;,
        ///        red: &apos;\033[31m&apos;,
        ///        yellow: &apos;\033[33m&apos;,
        ///        none: &apos;\033[0m&apos;
        ///    },
        ///    language = {
        ///        spec: &quot;spec&quot;,
        ///        failure: &quot;failure&quot;
        ///    };
        ///
        ///    function coloredStr(color, str) {
        ///        return showColors ? (ansi[c [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string jasmine_console {
            get {
                return ResourceManager.GetString("jasmine_console", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///// Launch tests
        ///var jasmineEnv = jasmine.getEnv();
        ///
        ///// Add a ConsoleReporter to 
        ///// 1) print with colors on the console 
        ///// 2) exit when finished
        ///jasmineEnv.addReporter(new jasmine.ConsoleReporter(function(msg) {
        ///    // Apply color
        ///    var ansi = {
        ///        green: &apos;\033[32m&apos;,
        ///        red: &apos;\033[31m&apos;,
        ///        yellow: &apos;\033[33m&apos;,
        ///        none: &apos;\033[0m&apos;,
        ///        newline: &apos;\n&apos;
        ///    };
        ///    msg = msg.replace(ansi.newline, &apos;&apos;).replace(ansi.none, &apos;&apos;);
        ///    var printInColor = function(color, message) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string run_jasmine {
            get {
                return ResourceManager.GetString("run_jasmine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to describe(&quot;phantom global object&quot;, function() {
        ///    it(&quot;should exist&quot;, function() {
        ///        expect(typeof phantom).toEqual(&apos;object&apos;);
        ///    });
        ///
        ///    it(&quot;should have args property&quot;, function() {
        ///        expect(phantom.hasOwnProperty(&apos;args&apos;)).toBeTruthy();
        ///    });
        ///
        ///    it(&quot;should have args as an array&quot;, function() {
        ///        expect(typeof phantom.args).toEqual(&apos;object&apos;);
        ///    });
        ///
        ///    it(&quot;should have libraryPath property&quot;, function() {
        ///        expect(phantom.hasOwnProperty(&apos;libraryPath&apos;)).toBeTruthy( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string spec_phantom {
            get {
                return ResourceManager.GetString("spec_phantom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///* trifle.core.js
        ///*
        ///* By: Steven de Salas
        ///* On: Sep 2013
        ///* 
        ///*
        ///* Generates the core running environment for
        ///* javascript code to execute under
        ///* 
        ///*/
        ///
        ///(function(GLOBAL) {
        ///
        ///    // Save imported params
        ///    var API = {
        ///        trifle: GLOBAL.trifle,
        ///        module: GLOBAL.module,
        ///        console: GLOBAL.console,
        ///        window: GLOBAL.window
        ///    };
        ///
        ///    delete GLOBAL.trifle;
        ///    delete GLOBAL.module;
        ///    delete GLOBAL.console;
        ///    delete GLOBAL.window;
        ///
        ///    // Initialise window objec [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string triflejs_core {
            get {
                return ResourceManager.GetString("triflejs_core", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///// Initialise Namespace
        ///this.trifle = this.trifle || {};
        ///
        ///// Wrap code to avoid global vars
        ///(function(trifle) {
        ///
        ///    // Define namespace
        ///    trifle.modules = trifle.modules || {};
        ///
        ///    // WebPage Class
        ///    // Define Constructor
        ///    var WebPage = trifle.modules.WebPage = function() {
        ///        console.xdebug(&quot;new WebPage()&quot;);
        ///        // Instantiate a V8 WebPage object and stores it in internal API property
        ///        this.API = trifle.module[&apos;WebPage&apos;]();
        ///        // Fire Initialized event
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string triflejs_modules {
            get {
                return ResourceManager.GetString("triflejs_modules", resourceCulture);
            }
        }
    }
}
