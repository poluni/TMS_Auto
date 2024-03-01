using NLog;
using NLogExample.Core;

namespace NLogExample.Tests;

[SetUpFixture]
public class BaseSuite
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    [OneTimeSetUp]
    public static void SuiteSetup()
    {
        new NLogConfig().Config();
        Logger.Info("NLog setted up.");
    }
}