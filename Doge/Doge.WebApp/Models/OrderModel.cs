using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doge.WebApp.Models
{
    public class OrderModel
    {
        private DateTime _date;
        public string OrderId { get; set; }
        public string DeliverAddress { get; set; }

        public string Status { get; set; }
        public string StatusClass { get
            {
                return Status == "On Time" ? "text-green-d1" : "text-danger-m3";
            }
        }
        public DateTime RequiredShippedDateTime
        {
            set
            {
                _date = value;
            }
            get
            {
                return _date;
            }
        }

        public string RemainingTime { 
            get {
                return string.Format("{0} days {1} hours {2} minutes {3} seconds.",
                    _date.Day-1, _date.Hour, _date.Minute, _date.Second
                    );
            }
        }
    }
}