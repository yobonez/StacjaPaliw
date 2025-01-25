﻿namespace StacjaPaliwLogic.Models
{
    // TODO: Employee session id?
    public class Employee
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }

        public Employee() { }
        public Employee(string _nickname, string _password)
        {
            nickname = _nickname;
            password = _password;
        }
    }
}
