// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 - 2013 Strategic Forge
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.$fileinputextension$
// Generic SingletonPattern. COMMENT - one line to give a brief idea of what the file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

#define DEBUG_LOG
#define DEBUG_LEVEL_WARN
#define DEBUG_LEVEL_ERROR

namespace $rootnamespace$ {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CodeEnv.Master.Common;
    using CodeEnv.Master.Common.LocalResources;

    /// <summary>
    /// Generic abstract Singleton.
    /// </summary>
    /// <typeparam name="T">The derived class type.</typeparam>
    public abstract class $safeitemname$<T> where T : class {

        #region Generic Singleton Pattern

        private static T instance;

        /// <summary>Returns the singleton instance of the derived class.</summary>
        public static T Instance {
            get {
                if (instance == null) {
                    instance = (T)Activator.CreateInstance(typeof(T), true);
                }
                return instance;
            }
        }

        #endregion

        ///<summary>
        /// IMPORTANT: This must be called from the PRIVATE constructor in the derived class.
        /// </summary>
        protected virtual void Initialize() {
            // TODO do any base class initialization here
        }

    }
}


