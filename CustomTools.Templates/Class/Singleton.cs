// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 $if$($year$>2012)- $year$ $endif$$registeredorganization$
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.$fileinputextension$
// SingletonPattern. TODO - one line to give a brief idea of what the file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace $rootnamespace$ {

    using System;

    /// <summary>
    /// SingletonPattern. TODO
    /// </summary>
    public sealed class $safeitemname$ {

        #region SingletonPattern
        private static readonly $safeitemname$ _instance = new $safeitemname$();

        /// <summary>
        /// Explicit static constructor that enables lazy instantiation by telling C# compiler
        /// not to mark type as beforefieldinit.
        /// </summary>
        private static $safeitemname$() {}

        /// <summary>
        /// Private constructor that prevents the creation of another externally requested instance of <see cref="$safeitemname$"/>.
        /// </summary>
        private $safeitemname$() {
            Initialize();
        }
        
        /// <summary>Returns the singleton instance.</summary>
        public static $safeitemname$ Instance {
            get {return _instance;}
        }
        #endregion

        ///<summary>
        /// Called once from the constructor, this does all required initialization.
        /// </summary>
        private void Initialize() {
            // TODO
        }

    }
}


