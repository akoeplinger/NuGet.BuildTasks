﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.NuGet.Build.Tasks.Tests.ProjectReferences {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.NuGet.Build.Tasks.Tests.ProjectReferences.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {
        ///  &quot;locked&quot;: false,
        ///  &quot;version&quot;: 2,
        ///  &quot;targets&quot;: {
        ///    &quot;.NETFramework,Version=v4.5.2&quot;: {
        ///      &quot;ClassLibrary2/1.0.0&quot;: {
        ///        &quot;type&quot;: &quot;project&quot;,
        ///        &quot;framework&quot;: &quot;.NETFramework,Version=v4.5.2&quot;
        ///      },
        ///    },
        ///    &quot;.NETFramework,Version=v4.5.2/win&quot;: {
        ///      &quot;ClassLibrary2/1.0.0&quot;: {
        ///        &quot;type&quot;: &quot;project&quot;,
        ///        &quot;framework&quot;: &quot;.NETFramework,Version=v4.5.2&quot;
        ///      },
        ///    }
        ///  },
        ///  &quot;libraries&quot;: {
        ///    &quot;ClassLibrary2/1.0.0&quot;: {
        ///      &quot;type&quot;: &quot;project&quot;,
        ///      &quot;path&quot;: &quot;../ClassLibrary2/p [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LockFileWithCSProjReference {
            get {
                return ResourceManager.GetString("LockFileWithCSProjReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;locked&quot;: false,
        ///  &quot;version&quot;: 2,
        ///  &quot;targets&quot;: {
        ///    &quot;.NETFramework,Version=v4.5.2&quot;: {
        ///      &quot;XProjClassLib/1.0.0&quot;: {
        ///        &quot;type&quot;: &quot;project&quot;,
        ///        &quot;framework&quot;: &quot;.NETFramework,Version=v4.5.2&quot;,
        ///        &quot;compile&quot;: {
        ///          &quot;net452/XProjClassLib.dll&quot;: { }
        ///        },
        ///        &quot;runtime&quot;: {
        ///          &quot;net452/XProjClassLib.dll&quot;: { }
        ///        }
        ///      }
        ///    },
        ///    &quot;.NETFramework,Version=v4.5.2/win&quot;: {
        ///      &quot;XProjClassLib/1.0.0&quot;: {
        ///        &quot;type&quot;: &quot;project&quot;,
        ///        &quot;framework&quot;: &quot;.NETFram [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LockFileWithXProjReference {
            get {
                return ResourceManager.GetString("LockFileWithXProjReference", resourceCulture);
            }
        }
    }
}
