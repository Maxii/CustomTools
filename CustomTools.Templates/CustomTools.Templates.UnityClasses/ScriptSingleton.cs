﻿// --------------------------------------------------------------------------------------------------------------------
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

#define DEBUG_LOG
#define DEBUG_WARN
#define DEBUG_ERROR

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
public class $safeitemname$ : AMonoBaseSingleton<$safeitemname$> {

    protected override void Awake() {
        base.Awake();

    }


    public override string ToString() {
        return new ObjectAnalyzer().ToString(this);
    }

}

