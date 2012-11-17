// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 $if$($year$>2012)- $year$ $endif$$registeredorganization$
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: $safeitemname$.$fileinputextension$
// TODO - one line to give a brief idea of what the file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace $rootnamespace$ {

    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

	/// <summary>
	/// Summary description for $safeitemname$
	/// </summary>
	[TestClass]
	public class $safeitemname$	{
        // Naming convention = [NameOfClassUT]ClassTests

        // Bug workaround used to call the [ClassInitialize] method
        private bool isClassInitCalled = false;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }


        /// <summary>
        /// Optional initialization code that is called once before the first test.
        /// </summary>
        /// <param name="testContext">The test context.</param>
        [ClassInitialize]
        public static void InitializeBeforeFirstTest(TestContext testContext) {
            // Optional initialization code
        }


        /// <summary>
        /// Optional initialization code that is called before each test.
        /// </summary>
        [TestInitialize]
        public void InitializeBeforeEachTest() {
            if (!isClassInitCalled) { InitializeBeforeFirstTest(null); }    // required if [ClassInitialize] method is used

            // Optional initialization code
        }

        #region Additional test attributes
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup]
        // public static void MyClassCleanup() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup]
        // public void MyTestCleanup() { }
        //

        // Other testing attributes can be found at: http://msdn.microsoft.com/en-us/library/microsoft.visualstudio.testtools.unittesting.aspx

        // 
        //  If the ClassUnderTest isn't a static class, create instances once as below, then inherit the ParentTestClass from the NestedTestClasses to use the instances.
        //
        //  protected ClassUnderTest target;
        //
        //  [ClassInitialize]
        //  Initialize() {
        //      testTarget = new ClassUnderTest();
        //  }
        //
        // OR
        //
        //  [TestInitialize]
        //  Initialize() {
        //      testTarget = new ClassUnderTest();
        //  }
        //
        #endregion

        [TestClass]
        public class NameOfMethod1Method {
            // Nested Class naming convention = [nameOfMethodUnderTest]Method

    		[TestMethod]
		    public void Condition1() {
                // Naming convention = [conditionTested]
                // Tests a specific condition of the above method

                // use TestContext.WriteLine(string); to write to the test output stream
                // see Pro Visual Studio 2010 Chapter 11 (iPad) for Database-based Testing
		    }

        }

        [TestClass]
        public class NameOfMethod2Method {
            // Nested Class naming convention = [nameOfMethodUnderTest]Method

    		[TestMethod]
		    public void Condition1() {
                // Naming convention = [conditionTested]
                // Tests a specific condition of the above method
		    }

	    }
    }   
}
