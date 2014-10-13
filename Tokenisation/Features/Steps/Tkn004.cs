using TechTalk.SpecFlow;

namespace CTShirts.Web.AcceptanceTests.Tokenisation.Features.Steps
{
    [Binding]
    public class Tkn004 : BaseSteps
    {
        [AfterScenario]
        public static void AfterEachScenario()
        {
            CleanUp();
        }

    }
}