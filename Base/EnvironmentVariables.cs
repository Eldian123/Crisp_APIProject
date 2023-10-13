using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crisp.APIProject.Base
{
    public class EnvironmentVariables
    {
        public static TestContext Context;
        //public static string APIBase => GetValue("apibaseurl");

        //I had some config issues so I could not use the runsettings file;
        public static string APIBase => "https://apimgmt-dev-crisp.azure-api.net/patients/query/";

        public static string GetValue(string param)
        {
            if (Context == null)
            {
                throw new Exception("TestContext is null. Make sure it is properly initialized.");
            }
            if (Context.Properties[param]==null)
            {
                throw new Exception($"Runsettings file does not contain a value for param {param}");
            }
            else
            {
                var value = Context.Properties[param].ToString();
                Console.WriteLine(value);
                return value;
            }
        }

        [TestInitialize]
        public static void ClassInit(TestContext con)
        {
            Context = con;
        }
    }
}
