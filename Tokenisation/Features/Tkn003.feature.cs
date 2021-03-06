﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("03: Logged in customer with saved cards wants to pay with alternative saved card")]
    public partial class _03LoggedInCustomerWithSavedCardsWantsToPayWithAlternativeSavedCardFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Tkn003.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "03: Logged in customer with saved cards wants to pay with alternative saved card", "As a logged in online customer with two or more saved payment cards\r\nI want to be" +
                    " able to pay with any of them\r\nso that I can complete my order quicker", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("01: All saved cards are valid")]
        public virtual void _01AllSavedCardsAreValid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01: All saved cards are valid", ((string[])(null)));
#line 6
 this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("an online customer with at least two saved payment cards, all of which are valid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("they add one or more items to their shopping bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("they are checking out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("they log in with their email and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("they are presented with payment options", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("they select the saved cards option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "details"});
            table1.AddRow(new string[] {
                        "card type"});
            table1.AddRow(new string[] {
                        "masked card number"});
            table1.AddRow(new string[] {
                        "name on card"});
            table1.AddRow(new string[] {
                        "expiry date"});
#line 13
 testRunner.Then("show:", ((string)(null)), table1, "Then ");
#line 19
 testRunner.And("show which card is currently selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("present an option for the customer to select another saved card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("when they select another saved card the dialogue is dismissed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("they see their newly selected payment card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02: Some saved cards have expired")]
        public virtual void _02SomeSavedCardsHaveExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02: Some saved cards have expired", ((string[])(null)));
#line 24
 this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given("an online customer with at least two saved payment cards, some of which have expi" +
                    "red", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And("they add one or more items to their shopping bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("they are checking out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("they log in with their email and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("they are presented with payment options", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("they select the saved cards option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "details"});
            table2.AddRow(new string[] {
                        "card type"});
            table2.AddRow(new string[] {
                        "masked card number"});
            table2.AddRow(new string[] {
                        "name on card"});
            table2.AddRow(new string[] {
                        "expiry date"});
#line 31
 testRunner.Then("show these details for valid cards:", ((string)(null)), table2, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "details"});
            table3.AddRow(new string[] {
                        "card type"});
            table3.AddRow(new string[] {
                        "masked card number"});
            table3.AddRow(new string[] {
                        "name on card"});
            table3.AddRow(new string[] {
                        "\"EXPIRED\""});
#line 37
 testRunner.And("show these details for invalid cards:", ((string)(null)), table3, "And ");
#line 43
 testRunner.And("show which card is currently selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("present an option adjacent to each valid card for the customer to select it as th" +
                    "e default payment card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("when they select another saved card the dialogue is dismissed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("they see their newly selected payment card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03: All saved cards have expired")]
        public virtual void _03AllSavedCardsHaveExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03: All saved cards have expired", ((string[])(null)));
#line 48
 this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.Given("an online customer with at least two saved payment cards, all of which have expir" +
                    "ed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("they add one or more items to their shopping bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("they are checking out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("they log in with their email and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("they are presented with payment options", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("they select the saved cards option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "details"});
            table4.AddRow(new string[] {
                        "card type"});
            table4.AddRow(new string[] {
                        "masked card number"});
            table4.AddRow(new string[] {
                        "name on card"});
            table4.AddRow(new string[] {
                        "\"EXPIRED\""});
#line 55
 testRunner.Then("show these details for each card:", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
