using System;
using System.Collections.Generic;
using System.Linq;
using Coypu;
using CTShirts.Infrastructure.Extensions;
using CTShirts.Web.AcceptanceTests.Tokenisation.Support.Fakes.Cards;
using TechTalk.SpecFlow;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Pages
{
    public class PaymentPage : BasePage
    {
        private ElementScope _saveCardDetailsOption;

        public ElementScope SaveCardDetailsOption
        {
            get
            {
                if (_saveCardDetailsOption != null) return _saveCardDetailsOption;
                return _saveCardDetailsOption = Browser.FindField("save_card_details");
            }
        }

        public override string AbsolutePath
        {
            get { return "/payment.aspx"; }
        }

        public void ContinueToPageTwo()
        {
            Browser.ClickButton("ctl00_contentBody_ConfirmAddresses");
        }

        public void SelectCard()
        {
            Browser.FindField("ctl00_contentBody_card_visa", IncludeHidden).Click();
        }

        public bool CanEnterCardDetails()
        {
            return Browser.FindField("card_number").Exists();
        }

        public void EnterDetails(PaymentCard card)
        {
            if (card == null) return;

            Browser.FillIn("card_number").With(card.Number);

            Browser.FindCss("#select_month .selectedTxt").Click();
            Browser.FindCss("#newList_4 a", card.ExpiryMonth.String()).Click();

            Browser.FindCss("#select_year .selectedTxt").Click();
            Browser.FindCss("#newList_5 a", card.ExpiryYear.String()).Click();

            Browser.FillIn("card_security_number").With(card.SecurityNumber);

            Browser.FillIn("card_name").With(card.Name);
        }

        public bool SaveCardDetailsSelected(bool selected)
        {
            return SaveCardDetailsOption.Exists() && SaveCardDetailsOption.Selected == selected;
        }

        public void SelectSaveCardDetails(bool selected)
        {
            if (selected) SaveCardDetailsOption.Check();
            else SaveCardDetailsOption.Uncheck();
        }

        public void SubmitPayment()
        {
            Browser.ClickButton("submit");
        }

        public bool PaymentDeclined()
        {
            return Browser.Location.AbsolutePath.ToLower().StartsWith(AbsolutePath.ToLower());
        }

        public bool CardNotExpired()
        {
            return Browser.HasContent("Expiry: ");
        }

        public bool CardDetailsExist(Table table)
        {
            var details = table.Rows.Select(r => r.Values.FirstOrDefault());
            var actions = new Dictionary<string, Func<bool>>()
            {
                {"card type", () => Browser.FindId("lblStoredCardType").Exists()},
                {"masked card number", () => Browser.HasContent("xxxx xxxx")},
                {"name on card", () => Browser.FindId("lblStoredCardHoldersName").Exists()},
                {"expiry date", CardNotExpired},
                {"CVV input field", () => Browser.FindField("token_card_security_number").Exists()}
            };
            foreach (var detail in details)
            {
                Func<bool> action;
                var actionExists = actions.TryGetValue(detail, out action);
                var elementExists = false;
                if (actionExists) elementExists = action();
                if (!actionExists || !elementExists) return false;
            }
            return true;
        }
    }
}