using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJobA = new Job();
            Job testJobB = new Job();
            Assert.IsTrue(testJobA.Id == testJobB.Id - 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testJobType = new PositionType("Quality control");
            CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");

            Job testJob = new Job("Product tester", testEmployer, testLocation, testJobType, testCoreCompetency);

            Assert.AreEqual(testJob.Name, "Product tester");
            Assert.AreEqual(testJob.EmployerName.Value, "ACME");
            Assert.AreEqual(testJob.EmployerLocation.Value, "Desert");
            Assert.AreEqual(testJob.JobType.Value, "Quality control");
            Assert.AreEqual(testJob.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testJobType = new PositionType("Quality control");
            CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");

            Job testJobA = new Job("Product tester", testEmployer, testLocation, testJobType, testCoreCompetency);
            Job testJobB = new Job("Product tester", testEmployer, testLocation, testJobType, testCoreCompetency);

            Assert.IsFalse(testJobA.Equals(testJobB));
        }

        [TestMethod]
        public void TestJobToString1()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testJobType = new PositionType("Quality control");
            CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");

            Job testJob = new Job("Product tester", testEmployer, testLocation, testJobType, testCoreCompetency);
            string testString = testJob.ToString();

            Assert.IsTrue(testString.StartsWith("\n"));
            Assert.IsTrue(testString.EndsWith("\n"));
        }

        [TestMethod]
        public void TestJobToString2()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testJobType = new PositionType("Quality control");
            CoreCompetency testCoreCompetency = new CoreCompetency("Persistence");

            Job testJob = new Job("Product tester", testEmployer, testLocation, testJobType, testCoreCompetency);
            string testString = testJob.ToString();

            Assert.IsTrue(testString.Contains("ID: "+testJob.Id+"\n"));
            Assert.IsTrue(testString.Contains("Name: Product tester\n"));
            Assert.IsTrue(testString.Contains("Employer: ACME\n"));
            Assert.IsTrue(testString.Contains("Location: Desert\n"));
            Assert.IsTrue(testString.Contains("Position Type: Quality control\n"));
            Assert.IsTrue(testString.Contains("Core Competency: Persistence\n"));
        }

        [TestMethod]
        public void TestJobToString3()
        {
            Job testJob = new Job();
            string testString = testJob.ToString();

            Assert.IsTrue(testString.Contains("Name: Data not available\n"));
            Assert.IsTrue(testString.Contains("Employer: Data not available\n"));
            Assert.IsTrue(testString.Contains("Location: Data not available\n"));
            Assert.IsTrue(testString.Contains("Position Type: Data not available\n"));
            Assert.IsTrue(testString.Contains("Core Competency: Data not available\n"));
        }

      
    }
}
