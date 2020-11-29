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
    }
}
