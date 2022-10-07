using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Assignment_2;

namespace BDD.StepDefinitions
{
    [Binding]
    public class StringUtilityStepDefinitions
    {
        private ScenarioContext _scenarioContext;
        private StringUtility _stringUtility;
        private string _text;
        public StringUtilityStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _stringUtility = new StringUtility();
        }
        [Given(@"the text string is ""([^""]*)""")]
        public void GivenTheTextStringIs(string text)
        {
            _text = text;
        }

        [When(@"I request the conversion of every letter in the text into lowercase")]
        public void WhenIRequestTheConversionOfEveryLetterInTheTextIntoLowercase()
        {
            _scenarioContext["LowerCaseResult"] = _stringUtility.LowercaseString(_text);
        }

        [Then(@"the result of the conversion to lowercase will be ""([^""]*)""")]
        public void ThenTheResultOfTheConversionToLowercaseWillBe(string text)
        {
            Assert.AreEqual(text, (string)_scenarioContext["LowerCaseResult"]);
        }

        [When(@"I request the conversion of every letter in the text into uppercase")]
        public void WhenIRequestTheConversionOfEveryLetterInTheTextIntoUppercase()
        {
            _scenarioContext["UpperCaseResult"] = _stringUtility.CapitalizeString(_text);
        }

        [Then(@"the result of the conversion to uppercase will be ""([^""]*)""")]
        public void ThenTheResultOfTheConversionToUppercaseWillBe(string text)
        {
            Assert.AreEqual(text, (string)_scenarioContext["UpperCaseResult"]);
        }

        [When(@"I request the reseravtion of the text")]
        public void WhenIRequestTheReseravtionOfTheText()
        {
            _scenarioContext["ReservationResult"] = _stringUtility.ReverseString(_text);
        }

        [Then(@"the result of the reservation will be ""([^""]*)""")]
        public void ThenTheResultOfTheReservationWillBe(string text)
        {
            Assert.AreEqual(text, (string)_scenarioContext["ReservationResult"]);
        }

    }
}
