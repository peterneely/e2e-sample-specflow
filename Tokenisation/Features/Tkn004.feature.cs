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
    [NUnit.Framework.DescriptionAttribute("04: Logged in customer with saved cards wants to pay with new card")]
    public partial class _04LoggedInCustomerWithSavedCardsWantsToPayWithNewCardFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Tkn004.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "04: Logged in customer with saved cards wants to pay with new card", "As a logged in online customer with one or more saved payment cards\r\nI want to be" +
                    " able to add another\r\nso that I can pay with the correct card", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("01: Customer wants to pay with new card")]
        [NUnit.Framework.TestCaseAttribute("1", "hide", null)]
        [NUnit.Framework.TestCaseAttribute("2", "show", null)]
        [NUnit.Framework.TestCaseAttribute("3", "show", null)]
        public virtual void _01CustomerWantsToPayWithNewCard(string number, string show_Or_Hide, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01: Customer wants to pay with new card", exampleTags);
#line 6
  this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given(string.Format("an online customer with \"{0}\" saved payment card adds one or more items to their " +
                        "shopping bag", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
    testRunner.And("they are checking out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
    testRunner.And("they log in with their email and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
    testRunner.And("they are presented with payment options", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.When("they select the new payment method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
    testRunner.Then("they see the default form for entering new payment card details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
    testRunner.And("they must be presented with the option to save their card details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.And("this option is selected by default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
    testRunner.And(string.Format("\"{0}\" the option to select another saved card", show_Or_Hide), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
    testRunner.And("the option to make a payment is enabled only when required form fields are comple" +
                    "ted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02: Customer pays with new card and wants to save it")]
        [NUnit.Framework.TestCaseAttribute("approved", "saved", "their order has been created and their details have been saved", null)]
        [NUnit.Framework.TestCaseAttribute("declined", "not saved", "their payment has been declined", null)]
        public virtual void _02CustomerPaysWithNewCardAndWantsToSaveIt(string response, string saved_Or_Not, string message, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02: Customer pays with new card and wants to save it", exampleTags);
#line 24
  this.ScenarioSetup(scenarioInfo);
#line 25
    testRunner.Given("an online customer with at least one saved payment cards adds one or more items t" +
                    "o their shopping bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
    testRunner.And("they checkout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
    testRunner.And("they login with their email and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.And("they are presented with payment options", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
    testRunner.And("they select the new payment method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
    testRunner.And("they see the default form for entering new payment card details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
    testRunner.And("an option to save their card details is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.And("they complete all required form fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
    testRunner.When("they select the option to make a payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
    testRunner.And(string.Format("their payment is \"{0}\"", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
    testRunner.Then(string.Format("the card details are \"{0}\" to their account as the default payment card", saved_Or_Not), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
    testRunner.And(string.Format("they are informed that \"{0}\"", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03: Customer pays with new card but does not want to save it")]
        [NUnit.Framework.TestCaseAttribute("approved", "their order has been created", null)]
        [NUnit.Framework.TestCaseAttribute("declined", "their payment has been declined", null)]
        public virtual void _03CustomerPaysWithNewCardButDoesNotWantToSaveIt(string response, string message, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03: Customer pays with new card but does not want to save it", exampleTags);
#line 43
  this.ScenarioSetup(scenarioInfo);
#line 44
    testRunner.Given("an online customer with at least one saved payment cards adds one or more items t" +
                    "o their shopping bag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
    testRunner.And("they checkout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
    testRunner.And("they login with their email and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
    testRunner.And("they are presented with payment options", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
    testRunner.And("they select the new payment method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
    testRunner.And("they see the default form for entering new payment card details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
    testRunner.And("an option to save their card details is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
    testRunner.And("they de-select this option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
    testRunner.And("they complete all required form fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
    testRunner.When("they select the option to make a payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
    testRunner.And(string.Format("their payment is \"{0}\"", response), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
    testRunner.Then("the card details are not saved to their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
    testRunner.And(string.Format("they are informed that \"{0}\"", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
