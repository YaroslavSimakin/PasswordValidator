using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LabWork10
{
    public class PasswordValidator
    {
        public static bool Validate(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            if (password.Length < 8)
            {
                return false;
            }

            return Regex.IsMatch(password, "^[a-zA-Z0-9]+$");

        }
    }
}