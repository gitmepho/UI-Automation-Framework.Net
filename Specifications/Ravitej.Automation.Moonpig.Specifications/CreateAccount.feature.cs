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
namespace Ravitej.Automation.Moonpig.Specifications
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Create Account")]
    [NUnit.Framework.CategoryAttribute("Create_Account")]
    public partial class CreateAccountFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateAccount.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Create Account", "\tIn order to place and track orders\r\n\tAs a moonpig.com customer\r\n\tI want to creat" +
                    "e an account", ProgrammingLanguage.CSharp, new string[] {
                        "Create_Account"});
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
        [NUnit.Framework.DescriptionAttribute("When Firstname is missing expected error should be displayed")]
        [NUnit.Framework.CategoryAttribute("Validations")]
        public virtual void WhenFirstnameIsMissingExpectedErrorShouldBeDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When Firstname is missing expected error should be displayed", new string[] {
                        "Validations"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I have entered Aluru in the surname field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And("I have entered ravitej.aluru@gmail.com in the email address fied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I have entered SecretPassword1 in the password field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.When("I click Create account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("only one error message should be displayed on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.And("the error message should be Please enter your first name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When Firstname is missing expected error should be displayed data trail")]
        [NUnit.Framework.CategoryAttribute("Validations")]
        public virtual void WhenFirstnameIsMissingExpectedErrorShouldBeDisplayedDataTrail()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When Firstname is missing expected error should be displayed data trail", new string[] {
                        "Validations"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Surname",
                        "Aluru"});
            table1.AddRow(new string[] {
                        "Email Address",
                        "ravitej.aluru@gmail.com"});
            table1.AddRow(new string[] {
                        "Password",
                        "SecretPassword1"});
#line 18
 testRunner.Given("I have entered following data", ((string)(null)), table1, "Given ");
#line 23
 testRunner.When("I click Create account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("only one error message should be displayed on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("the error message should be Please enter your first name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When Surname is missing expected error should be displayed")]
        [NUnit.Framework.CategoryAttribute("Validations")]
        public virtual void WhenSurnameIsMissingExpectedErrorShouldBeDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When Surname is missing expected error should be displayed", new string[] {
                        "Validations"});
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given("I have entered Ravitej in the firstname field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
 testRunner.And("I have entered ravitej.aluru@gmail.com in the email address fied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I have entered SecretPassword1 in the password field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("I click Create account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("only one error message should be displayed on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
 testRunner.And("the error message should be Please enter your last name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When Password is missing expected error should be displayed")]
        [NUnit.Framework.CategoryAttribute("Validations")]
        public virtual void WhenPasswordIsMissingExpectedErrorShouldBeDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When Password is missing expected error should be displayed", new string[] {
                        "Validations"});
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given("I have entered Ravitej in the firstname field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.And("I have entered Aluru in the surname field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("I have entered ravitej.aluru@gmail.com in the email address fied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When("I click Create account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("only one error message should be displayed on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.And("the error message should be Enter 6 characters or more including a letter and a n" +
                    "umber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When Email address is missing expected error should be displayed")]
        [NUnit.Framework.CategoryAttribute("Validations")]
        public virtual void WhenEmailAddressIsMissingExpectedErrorShouldBeDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When Email address is missing expected error should be displayed", new string[] {
                        "Validations"});
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
 testRunner.Given("I have entered Ravitej in the firstname field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.And("I have entered Aluru in the surname field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("I have entered SecretPassword1 in the password field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.When("I click Create account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("only one error message should be displayed on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.And("the error message should be Please enter a valid email address.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion