
using System.Collections.Generic;

namespace BlazorApp2.Data
{
    public class SingletonServise
    {
        List<Person> users = new List<Person>();

        public List<Person> GetUser()
        {
            return users;
        }
        public void SetUser(List<Person> newUser)
        {
            users = newUser;
        }
    }

}
