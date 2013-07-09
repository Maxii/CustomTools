// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 - 2013 Strategic Forge
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.$fileinputextension$
// Singleton Pattern for MonoBehaviours. Intended for use in External Assemblies only.
// Scripts should inherit from MonoBehaviourBaseSingleton.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

// default namespace

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CodeEnv.Master.Common;
    using CodeEnv.Master.Common.LocalResources;
    using UnityEngine;

[Obsolete]
    public class $safeitemname$ : MonoBehaviour {

        #region MonoBehaviour Singleton Pattern

        private static $safeitemname$ instance = null;
        public static $safeitemname$ Instance {
            get {
                if (instance == null) {
                    // Instance is required for the first time, so look for it                        
                    Type thisType = typeof($safeitemname$);
                    instance = GameObject.FindObjectOfType(thisType) as $safeitemname$;
                    if (instance == null) {
                        // an instance of this singleton doesn't yet exist so create a temporary one
                        Debug.LogWarning("No instance of {0} found, so a temporary one has been created.".Inject(thisType.ToString()));
                        GameObject tempGO = new GameObject("Temp Instance of {0}.".Inject(thisType.ToString()), thisType);
                        instance = tempGO.GetComponent<$safeitemname$>();
                        if (instance == null) {
                            Debug.LogError("Problem during the creation of {0}.".Inject(thisType.ToString()));
                        }
                    }
                    instance.Initialize();
                }
                return instance;
            }
        }

        void Awake() {
            // If no other MonoBehaviour has requested Instance in an Awake() call executing
            // before this one, then we are it. There is no reason to search for an object
            if (instance == null) {
                instance = this as $safeitemname$;
                instance.Initialize();
            }
        }

        // Make sure Instance isn't referenced anymore
        void OnApplicationQuit() {
            instance = null;
        }
        #endregion

        private void Initialize() {
            // do any required initialization here as you would normally do in Awake()
        }

        public override string ToString() {
            return new ObjectAnalyzer().ToString(this);
        }

    }


