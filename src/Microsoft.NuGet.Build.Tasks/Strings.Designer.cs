﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.NuGet.Build.Tasks {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.NuGet.Build.Tasks.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to The preprocessor token &apos;{0}&apos; has been given more than one value. Choosing &apos;{1}&apos; as the value..
        /// </summary>
        internal static string DuplicatePreprocessorToken {
            get {
                return ResourceManager.GetString("DuplicatePreprocessorToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project &apos;{0}&apos; was referenced more than once in the {1} property. Ignoring all but the first..
        /// </summary>
        internal static string DuplicateProjectReference {
            get {
                return ResourceManager.GetString("DuplicateProjectReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lock file {0} couldn&apos;t be found. Run a NuGet package restore to generate this file..
        /// </summary>
        internal static string LockFileNotFound {
            get {
                return ResourceManager.GetString("LockFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your project is not referencing the &quot;{0}&quot; framework. Add a reference to &quot;{0}&quot; in the &quot;frameworks&quot; section of your project.json, and then re-run NuGet restore..
        /// </summary>
        internal static string MissingFramework {
            get {
                return ResourceManager.GetString("MissingFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project.json is referencing the project &apos;{0}&apos;, but an output path was not specified on an item in the {1} property..
        /// </summary>
        internal static string MissingProjectReference {
            get {
                return ResourceManager.GetString("MissingProjectReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your project.json doesn&apos;t list &apos;{0}&apos; as a targeted runtime. You should add &apos;{1}&apos; inside your &quot;runtimes&quot; section in your project.json, and then re-run NuGet restore..
        /// </summary>
        internal static string MissingRuntimeInRuntimesSection {
            get {
                return ResourceManager.GetString("MissingRuntimeInRuntimesSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your project.json doesn&apos;t have a runtimes section. You should add &apos;{0}&apos; to your project.json and then re-run NuGet restore..
        /// </summary>
        internal static string MissingRuntimesSection {
            get {
                return ResourceManager.GetString("MissingRuntimesSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No targets could be found in the lock file. Make sure you have a supports or runtimes section i your project.json file..
        /// </summary>
        internal static string NoTargetsInLockFile {
            get {
                return ResourceManager.GetString("NoTargetsInLockFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package {0} with version {1} could not be found in {2}. Run a NuGet package restore to download the package..
        /// </summary>
        internal static string PackageFolderNotFound {
            get {
                return ResourceManager.GetString("PackageFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} property must be set in order to consume preprocessed content..
        /// </summary>
        internal static string PreprocessedDirectoryNotSet {
            get {
                return ResourceManager.GetString("PreprocessedDirectoryNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The token &apos;{0}&apos; is unrecognized..
        /// </summary>
        internal static string UnspecifiedToken {
            get {
                return ResourceManager.GetString("UnspecifiedToken", resourceCulture);
            }
        }
    }
}
