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

    public class $safeitemname$ : MonoBehaviour {

        #region MonoBehaviour Singleton Pattern

        private static $safeitemname$ _instance;
        public static $safeitemname$ Instance {
            get {
                if (_instance == null) {
                    // Instance is required for the first time, so look for it                        
                    Type thisType = typeof($safeitemname$);
                    _instance = GameObject.FindObjectOfType(thisType) as $safeitemname$;
                    if (_instance == null) {
                        // an instance of this singleton doesn't yet exist so create a temporary one
                    System.Diagnostics.StackFrame stackFrame = new System.Diagnostics.StackTrace().GetFrame(2);
                    string callerIdMessage = " Called by {0}.{1}().".Inject(stackFrame.GetFileName(), stackFrame.GetMethod().Name);
                    D.Warn("No instance of {0} found, so a temporary one has been created. Called by {1}.", thisType.Name, callerIdMessage);

                        GameObject tempGO = new GameObject(thisType.Name, thisType);
                        _instance = tempGO.GetComponent<$safeitemname$>();
                        if (_instance == null) {
                            D.Error("Problem during the creation of {0}.", thisType.Name);
                        }
                    }
                    _instance.Initialize();
                }
                return _instance;
            }
        }

        void Awake() {
            // If no other MonoBehaviour has requested Instance in an Awake() call executing
            // before this one, then we are it. There is no reason to search for an object
            if (_instance == null) {
                _instance = this as $safeitemname$;
                _instance.Initialize();
            }
        }

        // Make sure Instance isn't referenced anymore
        void OnApplicationQuit() {
            _instance = null;
        }
        #endregion

        private void Initialize() {
            // do any required initialization here as you would normally do in Awake()
        }

        public override string ToString() {
            return new ObjectAnalyzer().ToString(this);
        }

    }


