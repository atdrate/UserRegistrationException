﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationEx
{
    public class ValidLastName
    {
        public static void ValidateLastName()
        {
            try
            {
                Console.WriteLine("Enter Last Name");
                String lastName = Console.ReadLine();
                string pattern = "^[A-Z]{1}[a-z]{2,}$";
                if (Regex.IsMatch(lastName, pattern))
                {
                    Console.WriteLine("First Name : " + lastName);
                }
                else
                {
                    throw (new CustomException("Last name should be first letter capital and min 3 characters"));
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
