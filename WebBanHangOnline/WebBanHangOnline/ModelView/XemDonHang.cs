using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangOnline.Models;

namespace WebBanHangOnline.ModelView
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrdersDetail> ChiTietDonHang { get; set; }
    }
}
