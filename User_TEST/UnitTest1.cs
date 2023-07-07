using CMS_REST.Managers;
using User_DLL;

namespace User_TEST
{
    [TestClass]
    public class UnitTest1
    {
        private UserManager _userManager = new();

        [TestMethod]
        public void GetAllUsers_ShouldReturnNullException_UserManager()
        {
            _userManager.GetAllUsers();

            Assert.Fail();

        }
        [TestMethod]
        public void GetAllUsers_ShouldReturnNullExceptionByRole_UserManager()
        {
            Assert.IsTrue(true); // TODO
        }

        [TestMethod]
        public void GetAllUsers_ShouldReturnFullList_UserManager()
        {
            int count = _userManager.GetAllUsers().Count;

            Assert.IsTrue(2 <= count); // TODO, do a better one
        }

        [TestMethod]
        public void GetSingleUser_ShouldReturnNullException_UserManager()
        {
            _userManager.GetSingleUser(1);
            Assert.Fail();
        }
        [TestMethod]
        public void GetSingleUser_ShouldReturnNullExceptionByRole_UserManager()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(999)]
        public void GetSingleUser_ShouldReturnOutOfRangeException_UserManager(int id)
        {
            _userManager.GetSingleUser(id);
            Assert.Fail();
        }
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void GetSingleUser_ShouldReturnCorrectUser_UserManager(int id)
        {
            UserInfo user = _userManager.GetSingleUser(id);
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void CreateUser_ShouldReturnNullException_UserManager()
        {
        }
        [TestMethod]
        public void CreateUser_ShouldReturnNullExceptionByRole_UserManager()
        {
        }
        // some kind of SQL fail exception
        //[TestMethod]
        //public void CreateUser_ShouldReturn_UserManager()
        //{
        //}
        [TestMethod]
        public void CreateUser_ShouldReturnSuccess_UserManager()
        {
        }

        [TestMethod]
        public void UpdateUser_ShouldReturnOutOfRangeException_UserManager()
        {
        }
        [TestMethod]
        public void UpdateUser_ShouldReturnNullException_UserManager()
        {
        }
        [TestMethod]
        public void UpdateUser_ShouldReturnNullExceptionByRole_UserManager()
        {
        }
        // some kind of sql fail exception
        //[TestMethod]
        //public void UpdateUser_ShouldReturn_UserManager()
        //{
        //}
        [TestMethod]
        public void UpdateUser_ShouldReturnSuccess_UserManager()
        {
        }

        [TestMethod]
        public void DeleteUser_ShouldReturnNullException_UserManager()
        {
        }
        [TestMethod]
        public void DeleteUser_ShouldReturnNullExceptionByRole_UserManager()
        {
        }
        // some kind of sql fail exception
        //[TestMethod]
        //public void UpdateUser_ShouldReturn_UserManager()
        //{
        //}
        [TestMethod]
        public void DeleteUser_ShouldReturnSuccess_UserManager()
        {
        }

    }
}