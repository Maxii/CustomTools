// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 $if$($year$>2012)- $year$ $endif$$registeredorganization$
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.$fileinputextension$
// COMMENT - one line to give a brief idea of what this file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

// default namespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;
using CodeEnv.Master.Common;
using CodeEnv.Master.Common.Resources;
using CodeEnv.Master.Common.Unity;

/// <summary>
/// COMMENT 
/// </summary>
public class $safeitemname$ : MonoBehaviourBase {

    void Awake() {

    }

    void Start() {
        // Keep at a minimum, an empty Start method so that instances receive the OnDestroy event
    }

    void Update() {

    }

    void LateUpdate() {

    }

    public override string ToString() {
        return new ObjectAnalyzer().ToString(this);
    }

}

