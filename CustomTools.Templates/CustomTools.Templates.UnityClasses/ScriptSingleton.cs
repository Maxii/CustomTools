// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 $if$($year$>2012)- $year$ $endif$$registeredorganization$
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.$fileinputextension$
// Singleton. COMMENT - one line to give a brief idea of what this file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

////#define DEBUG_LOG
////#define DEBUG_WARN
////#define DEBUG_ERROR

// default namespace

using System;
using System.Collections.Generic;
using System.Linq;
using CodeEnv.Master.Common;
using CodeEnv.Master.Common.LocalResources;
using CodeEnv.Master.GameContent;
using UnityEngine;

/// <summary>
/// Singleton. COMMENT 
/// </summary>
public class $safeitemname$ : AMonoSingleton<$safeitemname$> {

            public string DebugName { get { return GetType().Name; } }


public override bool IsPersistentAcrossScenes {
    get {
        // TODO return true if this Singleton is persistent. Default is false
        return base.IsPersistentAcrossScenes;
    }
}

#region Initialization

/// <summary>
/// Called on the first Instance call or from Awake, whichever comes first, this method is limited to initializing 
/// local references and values that don't rely on ANY other MonoBehaviour Awake methods having already run.
/// </summary>
protected override void InitializeOnInstance() {
    base.InitializeOnInstance();
    // TODO  
}

/// <summary>
/// Called from Awake after InitializeOnInstance, this method should be limited to initializing local references and values. 
/// Note: Other MonoBehaviour Awake methods may or may not have yet been called depending on ScriptExecutionOrder.
/// </summary>
protected override void InitializeOnAwake() {
    base.InitializeOnAwake();
    // TODO
}

#endregion

protected override void ExecutePriorToDestroy() {
    base.ExecutePriorToDestroy();
    // TODO tasks to execute before this extra copy of this persistent singleton is destroyed. Default does nothing
}

#region Cleanup

protected override void Cleanup() {
    // TODO
}

#endregion

public override string ToString() {
    return DebugName;
}

}

