using System;
using TechTalk.SpecFlow;
using FrameworkExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Frameworks_3._5_Extensions_Specs
{
    [Binding]
    public class IsNullOrEmptySteps
    {
        private string input;
        private bool result; 

        [Given(@"an input string object whose value is null")]
        public void GivenAnInputStringObjectWhoseValueIsNull()
        {
            this.input = null;
        }
        
        [Given(@"an input string object whose value is empty")]
        public void GivenAnInputStringObjectWhoseValueIsEmpty()
        {
            this.input = string.Empty;
        }
        
        [When(@"I call IsNullOrEmpty on this string")]
        public void WhenICallIsNullOrEmptyOnThisString()
        {
            this.result = input.IsNullOrEmpty();
        }
        
        [Then(@"the result should be true")]
        public void ThenTheResultShouldBeTrue()
        {
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }
    }
}
