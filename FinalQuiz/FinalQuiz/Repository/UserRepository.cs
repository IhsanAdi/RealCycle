using FinalQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalQuiz.Repository
{
    public class UserRepository
    {
        static Entities db = new Entities();

        public static List<User> get()
        {
            Entities db = new Entities();
            return db.Users.ToList();
        }

        public static List<User> getMember()
        {
            Entities db = new Entities();
            return db.Users.Where(x => x.Role == "Member").ToList();
        }

        public static User searchUser(String email)
        {
            User user = db.Users.Where(x => x.Email.Equals(email)).FirstOrDefault();
            return user;
        }

        public static List<User> all()
        {
            var db = new Entities();
            return db.Users.ToList();
        }

        public static void register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User findUserByEmail(String email)
        {
            User user = db.Users.Find(email);
            return user;
        }

        public static User find(int id)
        {
            var db = new Entities();
            if (db.Users.Where(x => x.UserId == id).Any())
            {
                return db.Users.Find(id);
            }

            return null;
        }

        public static bool find(string email, string password = "")
        {
            var db = new Entities();
            var user = db.Users.AsQueryable();

            user = user.Where(x => x.Email == email);
            if (password != "")
            {
                user = user.Where(x => x.Password == password);
            }

            return user.Any();
        }

        public static User find(Dictionary<string, string> clauses)
        {
            var db = new Entities();
            var user = db.Users.AsQueryable();

            string email =  clauses["email"];
            string password = clauses["password"];

            if (find(email, password))
            {
                user = user.Where(x => x.Email == email);
                user = user.Where(x => x.Password == password);

                return user.First();
            }

            return null;
        }

        public static void deleteUser(String email)
        {
            User user = searchUser(email);
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public static void setAsAdmin(String email)
        {
            User user = searchUser(email);
            user.Role = "Admin";
            db.SaveChanges();
        }

        public static void updatePassword(String email, String oldPassword, String newPassword, String confPassword)
        {
            User user = searchUser(email);
            if (user != null)
            {
                user.Password = newPassword;
            }
            db.SaveChanges();
        }
    }
}