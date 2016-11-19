// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 - 2013 Strategic Forge
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.$fileinputextension$
// Singleton. COMMENT - one line to give a brief idea of what the file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

////#define DEBUG_LOG
////#define DEBUG_WARN
////#define DEBUG_ERROR

namespace $rootnamespace$ {

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
public class $safeitemname$ : AGenericSingleton<$safeitemname$> {

        private $safeitemname$() {
            Initialize();
}

protected override void Initialize() {
    // TODO do any initialization here
    // WARNING: Do not use Instance or _instance in here as this is still part of Constructor
}

public override string ToString() {
    return new ObjectAnalyzer().ToString(this);
}

    }
}


