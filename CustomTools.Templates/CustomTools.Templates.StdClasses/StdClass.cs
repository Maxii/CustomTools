// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 $if$($year$>2012)- $year$ $endif$$registeredorganization$
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.$fileinputextension$
// COMMENT - one line to give a brief idea of what the file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace $rootnamespace$ {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CodeEnv.Master.Common;
    using CodeEnv.Master.Common.Resources;

    public class $safeitemname$ {

        public $safeitemname$() { }

        public override string ToString() {
            return new ObjectAnalyzer().ToString(this);
        }

    }
}

