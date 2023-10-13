using Crisp.APIProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crisp.APIProject.Tests
{
    [TestClass]
    public class ApiTest : EnvironmentVariables

    {
        HttpClient client = new HttpClient();

        /// <summary>
        /// Test Case 1: Happy Path - Get Patient with ID 111
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetPatient_ID_111()
        {
            var request = await client.GetStringAsync($"{APIBase}?Id=111");
            Console.WriteLine(request);
            Assert.IsTrue(request.Contains("Jenn D."));
            Assert.IsTrue(request.Contains("111"));
            Assert.IsTrue(request.Contains("1934-06-01"));
            Assert.IsTrue(request.Contains("CA"));
        }

        /// <summary>
        /// Test Case 2: Happy Path - Get Patient with Name Jack
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetPatient_Name_Jack()
        {
            var request = await client.GetStringAsync($"{APIBase}?Name=Jack");
            Console.WriteLine(request);
            Assert.IsTrue(request.Contains("Jack"));
            Assert.IsTrue(request.Contains("222"));
            Assert.IsTrue(request.Contains("1956-05-01"));
            Assert.IsTrue(request.Contains("MD"));
        }

        /// <summary>
        /// Test Case 3: Happy Path - Get Patient with Address MD
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetPatient_Address_MD()
        {
            var request = await client.GetStringAsync($"{APIBase}?Address=MD");
            Console.WriteLine(request);
            Assert.IsTrue(request.Contains("Jack"));
            Assert.IsTrue(request.Contains("222"));
            Assert.IsTrue(request.Contains("1956-05-01"));
            Assert.IsTrue(request.Contains("MD"));
        }

        /// <summary>
        /// Test Case 4: Unhappy Path - Get Patient with Address Empty
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetPatient_Address_Empty()
        {
            var request = await client.GetStringAsync($"{APIBase}?Address=");
            Console.WriteLine(request);
            Assert.IsTrue(request.Contains("[]") && request.Length == 2);
        }

        /// <summary>
        /// Test Case 5: Unhappy Path - Get Patient with Invalid ID
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetPatient_Invalid_Id()
        {
            var request = await client.GetStringAsync($"{APIBase}?Id=*12");
            Console.WriteLine(request);
            Assert.IsTrue(request.Contains("[]") && request.Length == 2);
        }

        /// <summary>
        /// Test Case 6: Unhappy Path - Get Patient with DateOfBirth invalid format
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task GetPatient_DateOfBirth_Invalid_Format()
        {
            var request = await client.GetStringAsync($"{APIBase}?DateOfBirth=1934/06/01");
            Console.WriteLine(request);
            Assert.IsTrue(request.Contains("[]") && request.Length == 2);
        }
    }
}

