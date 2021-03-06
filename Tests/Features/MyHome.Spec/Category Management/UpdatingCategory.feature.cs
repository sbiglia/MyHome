﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MyHome.Spec.CategoryManagement
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class UpdatingCategoryFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UpdatingCategory.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UpdatingCategory", "In order to ensure user comfort\r\nI need to allow for the updating of categories", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "UpdatingCategory")))
            {
                MyHome.Spec.CategoryManagement.UpdatingCategoryFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        public virtual void ChangingTheNameOfACategoryToANewUniqueName(string testName, string categoryName, string categoryType, string newName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Changing the name of a category to a new unique name", exampleTags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given(string.Format("The category type is \'{0}\'", categoryType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.And(string.Format("a category with the name \'{0}\'", categoryName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.When(string.Format("I change the name to \'{0}\'", newName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("the category is updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Changing the name of a category to a new unique name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UpdatingCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "updateExpenseCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "updateExpenseCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryName", "food")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryType", "expense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:newName", "medicine")]
        public virtual void ChangingTheNameOfACategoryToANewUniqueName_UpdateExpenseCategory()
        {
            this.ChangingTheNameOfACategoryToANewUniqueName("updateExpenseCategory", "food", "expense", "medicine", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Changing the name of a category to a new unique name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UpdatingCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "updateIncomeCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "updateIncomeCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryName", "salary")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryType", "income")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:newName", "gift")]
        public virtual void ChangingTheNameOfACategoryToANewUniqueName_UpdateIncomeCategory()
        {
            this.ChangingTheNameOfACategoryToANewUniqueName("updateIncomeCategory", "salary", "income", "gift", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Changing the name of a category to a new unique name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UpdatingCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "updatePaymentMethod")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "updatePaymentMethod")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryName", "check")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryType", "paymentmethod")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:newName", "credit card")]
        public virtual void ChangingTheNameOfACategoryToANewUniqueName_UpdatePaymentMethod()
        {
            this.ChangingTheNameOfACategoryToANewUniqueName("updatePaymentMethod", "check", "paymentmethod", "credit card", ((string[])(null)));
        }
        
        public virtual void ChangingTheNameOfACategoryToANon_UniqueName(string testName, string categoryName, string categoryType, string newName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Changing the name of a category to a non-unique name", exampleTags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given(string.Format("The category type is \'{0}\'", categoryType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.And(string.Format("a category with the name \'{0}\'", categoryName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And(string.Format("the \'{0}\' already exists", newName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When(string.Format("I change the name to \'{0}\'", newName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("the handler returns an error indicator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.And(string.Format("the category name remains \'{0}\'", categoryName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Changing the name of a category to a non-unique name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UpdatingCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "updateNonUniqueExpenseCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "updateNonUniqueExpenseCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryName", "food")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryType", "expense")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:newName", "medicine")]
        public virtual void ChangingTheNameOfACategoryToANon_UniqueName_UpdateNonUniqueExpenseCategory()
        {
            this.ChangingTheNameOfACategoryToANon_UniqueName("updateNonUniqueExpenseCategory", "food", "expense", "medicine", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Changing the name of a category to a non-unique name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UpdatingCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "updateNonUniqueIncomeCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "updateNonUniqueIncomeCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryName", "salary")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryType", "income")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:newName", "gift")]
        public virtual void ChangingTheNameOfACategoryToANon_UniqueName_UpdateNonUniqueIncomeCategory()
        {
            this.ChangingTheNameOfACategoryToANon_UniqueName("updateNonUniqueIncomeCategory", "salary", "income", "gift", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Changing the name of a category to a non-unique name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UpdatingCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "updateNonUniquePaymentMethod")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "updateNonUniquePaymentMethod")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryName", "check")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryType", "paymentmethod")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:newName", "credit card")]
        public virtual void ChangingTheNameOfACategoryToANon_UniqueName_UpdateNonUniquePaymentMethod()
        {
            this.ChangingTheNameOfACategoryToANon_UniqueName("updateNonUniquePaymentMethod", "check", "paymentmethod", "credit card", ((string[])(null)));
        }
        
        public virtual void UpdatingACategory_WithABlankName(string testName, string categoryName, string categoryType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Updating a category - with a blank name", exampleTags);
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given(string.Format("The category type is \'{0}\'", categoryType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And(string.Format("a category with the name \'{0}\'", categoryName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.When("I have entered nothing for the name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("the handler returns an error indicator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.And(string.Format("the category name remains \'{0}\'", categoryName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Updating a category - with a blank name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UpdatingCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "blankNameExpenseCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "blankNameExpenseCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryName", "food")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryType", "expense")]
        public virtual void UpdatingACategory_WithABlankName_BlankNameExpenseCategory()
        {
            this.UpdatingACategory_WithABlankName("blankNameExpenseCategory", "food", "expense", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Updating a category - with a blank name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UpdatingCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "blankNameIncomeCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "blankNameIncomeCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryName", "salary")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryType", "income")]
        public virtual void UpdatingACategory_WithABlankName_BlankNameIncomeCategory()
        {
            this.UpdatingACategory_WithABlankName("blankNameIncomeCategory", "salary", "income", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Updating a category - with a blank name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "UpdatingCategory")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "blankNamePaymentMethod")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:testName", "blankNamePaymentMethod")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryName", "check")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:categoryType", "paymentmethod")]
        public virtual void UpdatingACategory_WithABlankName_BlankNamePaymentMethod()
        {
            this.UpdatingACategory_WithABlankName("blankNamePaymentMethod", "check", "paymentmethod", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
