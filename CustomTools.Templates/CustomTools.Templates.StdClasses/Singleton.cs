// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 $if$($year$>2012)- $year$ $endif$$registeredorganization$
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.$fileinputextension$
// SingletonPattern. COMMENT - one line to give a brief idea of what the file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace $rootnamespace$ {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CodeEnv.Master.Common;
    using CodeEnv.Master.Resources;

    /// <summary>
    /// SingletonPattern. COMMENT
    /// </summary>
    public sealed class $safeitemname$ {

        #region SingletonPattern
        private static readonly $safeitemname$ _instance;

        /// <summary>
        /// Explicit static constructor that enables lazy instantiation by telling C# compiler
        /// not to mark type as beforefieldinit.
        /// </summary>
        static $safeitemname$() {
            // try, catch and resolve any possible exceptions here
            _instance = new $safeitemname$();
        }

        /// <summary>
        /// Private constructor that prevents the creation of another externally requested instance of <see cref="$safeitemname$"/>.
        /// </summary>
        private $safeitemname$() {
            Initialize();
        }
        
        /// <summary>Returns the singleton instance of this class.</summary>
        public static $safeitemname$ Instance {
            get {return _instance;}
        }
        #endregion

        ///<summary>
        /// Called once from the constructor, this does all required initialization
        /// </summary>
        private void Initialize() {
            // Add initialization code here if any
        }

        public override string ToString() {
            return new ObjectAnalyzer().ToString(this);
        }

    }
}


