﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SaasEcom.Data.Models;

namespace SaasEcom.Web.Areas.Dashboard.ViewModels
{
    public class SubscriptionViewModel
    {
        public Subscription Subscription { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}