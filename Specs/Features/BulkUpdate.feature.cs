﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("BulkUpdate")]
    public partial class BulkUpdateFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BulkUpdate.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BulkUpdate", "\tIn order to be efficient\r\n\tAs a supervisor\r\n\tI want to be able to bulk add and c" +
                    "hange rejects", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to use bulk update to add packs")]
        public virtual void IShouldBeAbleToUseBulkUpdateToAddPacks()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to use bulk update to add packs", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I am at the rejects tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("There are 0 rejects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I bulk update packs 1 - 10 to Good", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And("Save Changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("Refresh", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Status",
                        "Pack Number"});
            table1.AddRow(new string[] {
                        "Good",
                        "1"});
            table1.AddRow(new string[] {
                        "Good",
                        "2"});
            table1.AddRow(new string[] {
                        "Good",
                        "3"});
            table1.AddRow(new string[] {
                        "Good",
                        "4"});
            table1.AddRow(new string[] {
                        "Good",
                        "5"});
            table1.AddRow(new string[] {
                        "Good",
                        "6"});
            table1.AddRow(new string[] {
                        "Good",
                        "7"});
            table1.AddRow(new string[] {
                        "Good",
                        "8"});
            table1.AddRow(new string[] {
                        "Good",
                        "9"});
            table1.AddRow(new string[] {
                        "Good",
                        "10"});
#line 12
 testRunner.Then("I should see packs", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I should be able to use bulk update to override packs")]
        public virtual void IShouldBeAbleToUseBulkUpdateToOverridePacks()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to use bulk update to override packs", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("I am at the rejects tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Status",
                        "Pack Number"});
            table2.AddRow(new string[] {
                        "Good",
                        "1"});
            table2.AddRow(new string[] {
                        "Good",
                        "2"});
            table2.AddRow(new string[] {
                        "Good",
                        "3"});
            table2.AddRow(new string[] {
                        "Good",
                        "4"});
            table2.AddRow(new string[] {
                        "Good",
                        "5"});
            table2.AddRow(new string[] {
                        "Good",
                        "6"});
            table2.AddRow(new string[] {
                        "Good",
                        "7"});
            table2.AddRow(new string[] {
                        "Good",
                        "8"});
            table2.AddRow(new string[] {
                        "Good",
                        "9"});
            table2.AddRow(new string[] {
                        "Good",
                        "10"});
#line 27
 testRunner.And("There are rejects", ((string)(null)), table2, "And ");
#line 39
 testRunner.When("I bulk update packs 5 - 8 to Pulled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.And("Save Changes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("Refresh", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Status",
                        "Pack Number"});
            table3.AddRow(new string[] {
                        "Good",
                        "1"});
            table3.AddRow(new string[] {
                        "Good",
                        "2"});
            table3.AddRow(new string[] {
                        "Good",
                        "3"});
            table3.AddRow(new string[] {
                        "Good",
                        "4"});
            table3.AddRow(new string[] {
                        "Pulled",
                        "5"});
            table3.AddRow(new string[] {
                        "Pulled",
                        "6"});
            table3.AddRow(new string[] {
                        "Pulled",
                        "7"});
            table3.AddRow(new string[] {
                        "Pulled",
                        "8"});
            table3.AddRow(new string[] {
                        "Good",
                        "9"});
            table3.AddRow(new string[] {
                        "Good",
                        "10"});
#line 42
 testRunner.Then("I should see packs", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
