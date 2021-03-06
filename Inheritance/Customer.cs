﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public MemberShip membership;

        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            membership = new MemberShip();
        }
    }
}
