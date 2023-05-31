using Doge.Model;
using Doge.Orders;
using Doge.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Doge.WebApp
{
    public partial class _Default : Page
    {
        public IService1 service { get; set; }
        private List<OrderModel> orders;

        private void ShowOrders()
        {
            long ticks = DateTime.Now.Ticks;
            orders = Global.Service.GetOrders().Select(o => new OrderModel
            {
                DeliverAddress = o.DeliverAddress,
                OrderId = o.OrderId,
                RequiredShippedDateTime = new DateTime(
                o.RequiredShippedTimestamp > ticks ?
                o.RequiredShippedTimestamp - ticks :
                0),
                Status = o.RequiredShippedTimestamp >= ticks ? "On Time" : "Delayed"
            }).ToList();
            DataList1.DataSource = orders;
            DataList1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowOrders();
            }
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            ShowOrders();
        }
    }
}