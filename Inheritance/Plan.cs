﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Plan
    {
        public enum Renewal
        {
            Monthly,
            SixMonth,
            Annual,
            TwoYear,
            ThreeYear,
        }

        public Renewal renewal;

        public Plan()
        {

        }

        public void ChangeRenewal(Plan.Renewal renew)
        {
            renewal = renew;
        }
    }
}
