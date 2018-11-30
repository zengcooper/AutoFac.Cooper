using System;
using System.Collections.Generic;
using System.Text;

namespace Cooper.Service.Service
{
    public class AliPayService : IPayService
    {
        public string Pay()
        {
            return "支付宝支付";
        }
    }
}
