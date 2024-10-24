/*
# Name: Derick Bellofatto
# email: Bellofdk@mail.uc.edu
# Assignment Title: Assignment 07
# Due Date: 10/31/2024
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project creates a method that validates password requirements.
# Citations: Adapted code in order to check for special characters(1.1)https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
# Anything else that's relevant: N/A
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bellofdk_Assignment07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePassword("Password98"));
            Console.WriteLine(ValidatePassword("Password!"));
            Console.WriteLine(ValidatePassword("!@#$%^&*"));
            Console.WriteLine(ValidatePassword("z"));
            Console.WriteLine(ValidatePassword("ABCDEFGH98!"));
        }
        /// <summary>
        /// Validates each requirement of the password outlined in the change request
        /// </summary>
        /// <param name="password">String being validated as a password</param>
        /// <returns></returns>
        static bool ValidatePassword(string password)
        {
            // if the Password Length is not between 8 & 13 method will return false
            if (password.Length < 8 && password.Length > 13) { return false;}

            // If the Password contains a Space method will return false
            if (password.Contains(" ") == true) { return false; }

            // If the Password does not contain a special character method will return false
            if (hasSpecialChar(password) == false) { return false; }

            // If the Password does not contain a Upper Case character method will return false
            if (password.Any(char.IsUpper) == false) { return false; }

            // If the Password does not contain a Lower Case character method will return false
            if (password.Any(char.IsLower) == false) { return false; }

            // If all requirements are met, method will return true
            return true;
        }

        //Found on Stack overflow as a seperate module
        /// <summary>
        /// Checks for special characters and returns a boolean depending on the result. Slight edits made to specialChar to reflect Assignment
        /// See reference (1.1)
        /// </summary>
        /// <param name="input">String to be checked for Special Characters</param>
        /// <returns></returns>
        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"!@#$%^&*()";
            //I assume this splits each character
            foreach (var item in specialChar)
            {
                //if the input contains any of the characters from "specialChar" it returns true
                if (input.Contains(item)) 
                {;
                    return true; 
                }
            }
            //otherwise returns false
            return false;
        }
    }
    }

