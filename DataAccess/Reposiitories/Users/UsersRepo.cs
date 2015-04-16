﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Transactions;
using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Users
{
    public class UsersRepo : IDataRepository<User>
    {
        private DsaDataContext _db = new DsaDataContext();


        public IQueryable<User> ListAll()
        {
            return _db.Users.AsQueryable();
        }

        public void Create(User newItem)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                using (var context = new DsaDataContext())
                {
                    context.Database.Connection.Open();
                    try
                    {
                        context.Users.Add(newItem);
                        context.SaveChanges();
                        ts.Complete();
                    }
                    catch (Exception ex)
                    {
                        ts.Dispose();
                    }
                    finally
                    {
                        if (context.Database.Connection.State == ConnectionState.Open)
                        {
                            context.Database.Connection.Close();
                        }
                    }
                }
            }
        }

        public User Read(User itemToRead)
        {
            User result = _db.Users.Find(itemToRead.Username);
            return result;
        }

        public void Update(User updatedItem)
        {
            var o = _db.Users.Find(updatedItem.Username);

            if (o != null)
            {
                o.FirstName = updatedItem.FirstName;
                o.MiddleInitial = updatedItem.MiddleInitial;
                o.LastName = updatedItem.LastName;
                o.Email = updatedItem.Email;
                o.Mobile = updatedItem.Mobile;
                o.DateOfBirth = updatedItem.DateOfBirth;
                o.Address = updatedItem.Address;
                o.GenderID = updatedItem.GenderID;
                o.TownID = updatedItem.TownID;
                o.TypeID = updatedItem.TypeID;
                o.Blocked = updatedItem.Blocked;
                o.NoOfAttempts = updatedItem.NoOfAttempts;
                _db.SaveChanges();
            }
        }

        public void Delete(User itemToDelete)
        {
            try
            {
                var o = _db.Users.Find(itemToDelete.Username);
                if (o != null)
                {
                    o.Blocked = true;
                    _db.SaveChanges();
                }
            }
            catch
            {

                throw new Exception("Unable to disable record (Users cannot be deleted)");
            }
        }

        public IEnumerable<User> Search(string query)
        {
            IQueryable<User> result = _db.Users.Where(u => u.Username.Contains(query));
            return result;
        }

        /// <summary>
        ///     Gets a list of user-names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetUsernames()
        {
            return _db.Users.Select(u => u.Username).ToList();
        }

        /// <summary>
        ///     Gets the number of failed login attempts for the user account.
        /// </summary>
        /// <param name="username">The user-name.</param>
        /// <returns></returns>
        public int GetNoOfAttempts(string username)
        {
            return Read(new User
            {
                Username = username
            }).NoOfAttempts;
        }


        /// <summary>
        ///     Authenticates the specified user account.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        /// <param name="password">The string password.</param>
        /// <returns></returns>
        public bool Authenticate(string username, string password)
        {
            if (_db.Users.SingleOrDefault(o => o.Username == username && o.Password == password)
                != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///     Blocks the specified user account.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        public void Block(string username)
        {
            Read(new User
            {
                Username = username
            }).Blocked = true;
        }

        public bool DoeUserNameExist(string username)
        {
            bool ans;
            ans = _db.Users.Count(u => u.Username == username &&
                                       username != null) > 0;
            return ans;
        }

        /// <summary>
        ///     Increments the number of failed login attempts.
        /// </summary>
        /// <param name="username">The user-name.</param>
        public void IncrementNoOfAttempts(string username)
        {
            Read(new User { Username = username }).NoOfAttempts++;
        }

        /// <summary>
        ///     Resets the number of failed login attempts.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        public void ResetNoOfAttempts(string username)
        {
            Read(new User { Username = username }).NoOfAttempts = 0;
        }

        /// <summary>
        ///     Unblock the specified user account.
        /// </summary>
        /// <param name="username">The string user-name.</param>
        public void UnBlockUser(string username)
        {
            Read(new User { Username = username }).Blocked = false;
        }

        /// <summary>
        ///     A list of users and their assigned roles.
        /// </summary>
        /// <returns>IQueryable</returns>
        public IQueryable UserRoles()
        {
            return (from u in _db.Users
                    from r in u.Roles
                    group r.Name by u.Username
                        into urlist
                        select urlist);
        }
    }
}