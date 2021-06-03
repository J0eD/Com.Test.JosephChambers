using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Com.Test.JosephC
{
    [Binding]
    public sealed class WebSolutionSteps : BasePage
    {
        private readonly HomePage _home;
        private readonly TshirtPage _tshirtPage;
        private readonly ShoppingCartSummaryPage _shoppingCartSummaryPage;
        private readonly SelectedTShirtPage _selectedTshirt;
        private readonly OrderHistoryPage _orderHistoryPage;
        private readonly YourPersonalInformationPage _yourPersonalInformationPage;

        public WebSolutionSteps(HomePage homepage, TshirtPage tshirt, ShoppingCartSummaryPage shoppingCartSummary, SelectedTShirtPage selectetshirtpage, OrderHistoryPage orderHistory, YourPersonalInformationPage yourPersonalInformation)
        {
            _home = homepage;
            _tshirtPage = tshirt;
            _shoppingCartSummaryPage = shoppingCartSummary;
            _selectedTshirt = selectetshirtpage;
            _orderHistoryPage = orderHistory;
            _yourPersonalInformationPage = yourPersonalInformation;
        }
        /********************************************************************************************************************/


        [Given(@"The user has launched the website")]
        public void GivenTheUserHasLaunchedTheWebsite()
        {
            _home.LaunchWebsite();
        }

        [Given(@"The user enter their credentials if not already logged in")]
        public void GivenTheUserEnterTheirCredentialsIfNotAlreadyLoggedIn()
        {
            _home.CheckLogin();
        }


        [Given(@"The user clicks the Tshirt button on the navigation bar")]
        public void GivenTheUserClicksTheTshirtButtonOnTheNavigationBar()
        {
            _home.ClickTshirtCategory();
        }

        [Given(@"The user selects a tshirt displayed and proceeds to checkout")]
        public void GivenTheUserSelectsATshirtDisplayedAndProceedsToCheckout()
        {
            _tshirtPage.SelectATshirttoCheckout();
            _selectedTshirt.GotoCheckOut();

        }

        [Given(@"The user completes all mandatory fields in order to successfully checkout")]
        public void GivenTheUserCompletesAllMandatoryFieldsInOrderToSuccessfullyCheckout()
        {
            _shoppingCartSummaryPage.QuickCheckout();
            _shoppingCartSummaryPage.ClickUserAccountMenu();
        }

        [Then(@"The user should successfully be able to view their order in the order history section")]
        public void ThenTheUserShouldSuccessfullyBeAbleToViewTheirOrderInTheOrderHistorySection()
        {
            _orderHistoryPage.AssertNewShirtOrdered();
        }


        /********************************************************************************************************************/


        [Given(@"The user clicks their name in the top right of the screen")]
        public void GivenTheUserClicksTheirNameInTheTopRightOfTheScreen()
        {
            _home.ClickUserAccountMenu();
        }

        [Given(@"The user updates their first name")]
        public void GivenTheUserUpdatesTheirFirstNbame()
        {
            _yourPersonalInformationPage.EditFirstNameField();
        }

        [Then(@"The website should successfully update with the changes")]
        public void ThenTheWebsiteShouldSuccessfullyUpdateWithTheChanges()
        {
            _yourPersonalInformationPage.AssertUpdatedInformation();
        }


    }
}
