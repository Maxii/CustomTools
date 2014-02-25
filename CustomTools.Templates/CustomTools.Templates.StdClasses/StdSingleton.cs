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

#define DEBUG_LOG
#define DEBUG_WARN
#define DEBUG_ERROR

namespace $rootnamespace$ {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CodeEnv.Master.Common;
    using CodeEnv.Master.Common.LocalResources;
    using CodeEnv.Master.GameContent;

    /// <summary>
    /// SingletonPattern. COMMENT
    /// </summary>
    [Obsolete]
    public sealed class $safeitemname$ {

        #region Singleton Pattern
        private static readonly $safeitemname$ instance;

        /// <summary>
        /// Explicit static constructor that enables lazy instantiation by telling C# compiler
        /// not to mark type as beforefieldinit.
        /// </summary>
        static $safeitemname$() {
            // try, catch and resolve any possible exceptions here
            instance = new $safeitemname$();
        }

        /// <summary>
        /// Private constructor that prevents the creation of another externally requested instance of <see cref="$safeitemname$"/>.
        /// </summary>
        private $safeitemname$() {
            Initialize();
        }
        
        /// <summary>Returns the singleton instance of this class.</summary>
        public static $safeitemname$ Instance {
            get {return instance;}
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


