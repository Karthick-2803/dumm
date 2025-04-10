﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public DateTime JoiningDate { get; set; }

        private DateTime? _terminationDate;
        public DateTime? TerminationDate
        {
            get { return _terminationDate; }
            set
            {
                if (value.HasValue)
                {
                    _terminationDate = (DateTime)value;
                }
                else
                {
                    _terminationDate = DateTime.MinValue;
                }
            }
        }

        public override string ToString()
        {
            return $"EmployeeID::{EmployeeID}\t FirstName::{FirstName}\t LastName::{LastName}\t DateOfBirth::{DateOfBirth}\t Gender::{Gender} \t mail::{Mail} \t phoneno:{PhoneNumber}\t Address::{Address} \t Position::{Position} \t JoiningDate::{JoiningDate} \t Terminationdate::{TerminationDate}";
        }

        public Employee()
        {
        }

        public Employee(int employeeID, string firstName, string lastName, DateTime dateOfBirth,
                       string gender, string mail, string phoneNumber, string address,
                       string position, DateTime joiningDate, DateTime terminationDate)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Mail = mail;
            PhoneNumber = phoneNumber;
            Address = address;
            Position = position;
            JoiningDate = joiningDate;
            TerminationDate = terminationDate;
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;
            if (today < DateOfBirth.AddYears(age))
                age--;
            return age;
        }
    }
}
