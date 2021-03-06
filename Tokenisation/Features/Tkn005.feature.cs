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
    [NUnit.Framework.DescriptionAttribute("05: Logged in customer manages saved cards")]
    public partial class _05LoggedInCustomerManagesSavedCardsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Tkn005.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "05: Logged in customer manages saved cards", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("01: No saved cards")]
        public virtual void _01NoSavedCards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01: No saved cards", ((string[])(null)));
#line 3
  this.ScenarioSetup(scenarioInfo);
#line 4
    testRunner.Given("an online customer with no saved payment cards has logged in to their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
    testRunner.When("they view their account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
    testRunner.Then("they should not see payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02: One saved card, not expired")]
        public virtual void _02OneSavedCardNotExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02: One saved card, not expired", ((string[])(null)));
#line 8
  this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("an online customer with one saved payment card that has not expired", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
    testRunner.And("they log into their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.And("they view their account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
    testRunner.When("they view their payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "card_details"});
            table1.AddRow(new string[] {
                        "card type"});
            table1.AddRow(new string[] {
                        "masked card number"});
            table1.AddRow(new string[] {
                        "name on card"});
            table1.AddRow(new string[] {
                        "expiry date"});
            table1.AddRow(new string[] {
                        "option to remove card"});
#line 13
    testRunner.Then("they should see:", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03: One saved card, expired")]
        public virtual void _03OneSavedCardExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03: One saved card, expired", ((string[])(null)));
#line 21
  this.ScenarioSetup(scenarioInfo);
#line 22
    testRunner.Given("an online customer with one saved payment card that has expired", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
    testRunner.And("they log into their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.And("they view their account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
    testRunner.When("they view their payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "card_details"});
            table2.AddRow(new string[] {
                        "card type"});
            table2.AddRow(new string[] {
                        "masked card number"});
            table2.AddRow(new string[] {
                        "name on card"});
            table2.AddRow(new string[] {
                        "\"EXPIRED\""});
            table2.AddRow(new string[] {
                        "option to remove card"});
#line 26
    testRunner.Then("they should see:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04: More than one saved card, none expired")]
        public virtual void _04MoreThanOneSavedCardNoneExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04: More than one saved card, none expired", ((string[])(null)));
#line 34
  this.ScenarioSetup(scenarioInfo);
#line 35
    testRunner.Given("an online customer with at least two saved payment cards, none of which have expi" +
                    "red", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
    testRunner.And("they log into their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
    testRunner.And("they view their account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
    testRunner.When("they view their payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "card_details"});
            table3.AddRow(new string[] {
                        "card type"});
            table3.AddRow(new string[] {
                        "masked card number"});
            table3.AddRow(new string[] {
                        "name on card"});
            table3.AddRow(new string[] {
                        "expiry date"});
            table3.AddRow(new string[] {
                        "option to remove card"});
#line 39
    testRunner.Then("they should see:", ((string)(null)), table3, "Then ");
#line 46
    testRunner.And("they should see which card is the default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
    testRunner.And("they should be able to make another card the default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05: More than one saved card, some expired")]
        public virtual void _05MoreThanOneSavedCardSomeExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05: More than one saved card, some expired", ((string[])(null)));
#line 49
  this.ScenarioSetup(scenarioInfo);
#line 50
    testRunner.Given("an online customer with at least two saved payment cards, some of which have expi" +
                    "red", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
    testRunner.And("they log into their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
    testRunner.And("they view their account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
    testRunner.When("they view their payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "card_details"});
            table4.AddRow(new string[] {
                        "card type"});
            table4.AddRow(new string[] {
                        "masked card number"});
            table4.AddRow(new string[] {
                        "name on card"});
            table4.AddRow(new string[] {
                        "expiry date"});
            table4.AddRow(new string[] {
                        "option to remove card"});
#line 54
    testRunner.Then("they should see these details for valid cards:", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "card_details"});
            table5.AddRow(new string[] {
                        "card type"});
            table5.AddRow(new string[] {
                        "masked card number"});
            table5.AddRow(new string[] {
                        "name on card"});
            table5.AddRow(new string[] {
                        "\"EXPIRED\""});
            table5.AddRow(new string[] {
                        "option to remove card"});
#line 61
    testRunner.And("they should see these details for invalid cards:", ((string)(null)), table5, "And ");
#line 68
    testRunner.And("they should see which card is the default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
    testRunner.And("only valid cards should have the option to make one of them the default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06: More than one saved card, all expired")]
        public virtual void _06MoreThanOneSavedCardAllExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06: More than one saved card, all expired", ((string[])(null)));
#line 71
  this.ScenarioSetup(scenarioInfo);
#line 72
    testRunner.Given("an online customer with at least two saved payment cards, all of which have expir" +
                    "ed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
    testRunner.And("they log into their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
    testRunner.And("they view their account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
    testRunner.When("they view their payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "card_details"});
            table6.AddRow(new string[] {
                        "card type"});
            table6.AddRow(new string[] {
                        "masked card number"});
            table6.AddRow(new string[] {
                        "name on card"});
            table6.AddRow(new string[] {
                        "\"EXPIRED\""});
            table6.AddRow(new string[] {
                        "option to remove card"});
#line 76
    testRunner.Then("they should see:", ((string)(null)), table6, "Then ");
#line 83
    testRunner.And("they should see which card was the default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
    testRunner.And("no other card should have the option to make it the default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("07: Remove valid non-default card")]
        [NUnit.Framework.TestCaseAttribute("remove", "should", null)]
        [NUnit.Framework.TestCaseAttribute("not remove", "should not", null)]
        public virtual void _07RemoveValidNon_DefaultCard(string remove_Or_Not_Remove, string should_Or_Should_Not, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("07: Remove valid non-default card", exampleTags);
#line 86
  this.ScenarioSetup(scenarioInfo);
#line 87
    testRunner.Given("an online customer with at least one saved payment card, at least one of which ha" +
                    "s not expired", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 88
    testRunner.And("they log into their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
    testRunner.And("they view their account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
    testRunner.And("they view their payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
    testRunner.And("they choose to remove a valid card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
    testRunner.And("they see a confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
    testRunner.When(string.Format("they choose to \"{0}\" it", remove_Or_Not_Remove), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
    testRunner.Then("the message should be dismissed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
    testRunner.And(string.Format("the payment card \"{0}\" be removed from their account", should_Or_Should_Not), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("08: Remove valid default card")]
        [NUnit.Framework.TestCaseAttribute("remove", "should", null)]
        [NUnit.Framework.TestCaseAttribute("not remove", "should not", null)]
        public virtual void _08RemoveValidDefaultCard(string remove_Or_Not_Remove, string should_Or_Should_Not, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("08: Remove valid default card", exampleTags);
#line 102
  this.ScenarioSetup(scenarioInfo);
#line 103
    testRunner.Given("an online customer with at least one saved payment card, at least one of which ha" +
                    "s not expired and one of which is the default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
    testRunner.And("they log into their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
    testRunner.And("they view their account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
    testRunner.And("they view their payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
    testRunner.And("they choose to remove the default, valid card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
    testRunner.And("they see a confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
    testRunner.When(string.Format("they choose to \"{0}\" it", remove_Or_Not_Remove), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
    testRunner.Then("the message should be dismissed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
    testRunner.And(string.Format("the payment card \"{0}\" be removed from their account", should_Or_Should_Not), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
    testRunner.And(string.Format("the newest added non expired card \"{0}\" become the default", should_Or_Should_Not), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("09: Remove expired card")]
        public virtual void _09RemoveExpiredCard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("09: Remove expired card", ((string[])(null)));
#line 119
  this.ScenarioSetup(scenarioInfo);
#line 120
    testRunner.Given("an online customer with at least one saved payment card, at least one of which ha" +
                    "s expired", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 121
    testRunner.And("they log into their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
    testRunner.And("they view their account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
    testRunner.And("they view their payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
    testRunner.When("they choose to remove an expired card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
    testRunner.Then("the card should be removed immediately from their account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
