using RC.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RC.Modules
{ 
    public class UserControl<Type> where Type : User
    {
        public static List<Type> UsersByNames(string name, List<Type> users) //could be used for name,surname and patronymic as well
        {
            Regex regex = new Regex(String.Format($"^{name.ToLower()}$"));
            List<Type> needUsers = new List<Type>();
            foreach (Type user in users)
            {
                if (regex.IsMatch(user.Name.ToLower()) ||
                    regex.IsMatch(user.Surname.ToLower()) ||
                    regex.IsMatch(user.Patronymic.ToLower()))
                {
                    needUsers.Add(user);
                }
            }
            return needUsers;
        }
    }
}