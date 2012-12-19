// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 $if$($year$>2012)- $year$ $endif$$registeredorganization$
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.cs
// COMMENT - one line to give a brief idea of what this file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace $safeprojectname$ {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program {

        static void Main(string[] args) {
        }

        public override string ToString() {
            return new ObjectAnalyzer().ToString(this);
        }

    }
}
