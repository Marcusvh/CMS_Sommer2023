using User_DLL;

namespace CMS_REST.Managers
{
    public class UserManager
    {
        public List<UserInfo> Users = new() { new UserInfo(), new UserInfo() };

        /// <summary>
        /// Return a list of all users in the database. Only authorized users can use this method.
        /// </summary>
        /// <returns>UserInfo List with all users</returns>
        /// <exception cref="ArgumentNullException">if there is no users or call is invalid</exception>
        public List<UserInfo> GetAllUsers()
        {
            if(Users.Count == 0 || Users == null) 
                throw new ArgumentNullException("No users");

            return Users;
        }
        /// <summary>
        /// Return a object of a single user by the supplied ID.
        /// </summary>
        /// <param name="id">ID of the wanted user</param>
        /// <returns>a UserInfo object of the user</returns>
        /// <exception cref="ArgumentOutOfRangeException">If the supplied ID do not exist</exception>
        /// <exception cref="ArgumentNullException">If the found user is null</exception>
        public UserInfo GetSingleUser(int id)
        {
            if(id <= 0 || id > Users.Count) // TODO change
                throw new ArgumentOutOfRangeException("Id do not exist");

            UserInfo user = Users.Find(k => k.ID == id);

            if (user == null)
                throw new ArgumentNullException("User do not exits");

            return user;
        }
    }
}
