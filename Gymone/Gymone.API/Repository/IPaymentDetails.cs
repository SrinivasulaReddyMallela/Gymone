using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gymone.Entities;

namespace Gymone.API.Repository
{
   public interface IPaymentDetails
    {
        int InsertPaymentDetails(PaymentDetailsDTO objPD);
        int UpdatePaymentDetails(PaymentDetailsDTO objPD);
    }
}
