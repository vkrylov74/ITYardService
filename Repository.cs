!!!!Changes!!!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITYardService
{
    public class UserRepository
    {
        private static Dictionary<Guid, User> _users = new Dictionary<Guid, User>();
        public List<User> All()
        {
            return _users.Values.ToList();
        }

        //GetById
        public User GetById(Guid id)
        {
            if (_users.ContainsKey(id))
            {
                return _users[id];
            }
            return null;
        }

        //Insert
        public void Insert(User user)
        {
            _users.Add(user._id, user);
        }

        //Update
        public void Update(Guid id, string userName, string password)
        {
            if (_users.ContainsKey(id))
            {
                _users[id]._userName = userName;
                _users[id]._password = password;
            }
        }

        //Delete
        public void Delete(Guid id)
        {
            if (_users.ContainsKey(id))
            {
                _users.Remove(id);
            }
        }

        //Try to write count property
        public int Count
        {
            get
            {
                return _users.Count;
            }
        }
    }
}
