using Gymone.API.Repository;
using Gymone.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Gymone.API.Controllers
{
    [Route("api/[controller]")]
    public class PaymentListingController : BaseController
    {

        private readonly ILogger<PaymentListingController> _logger;
        private readonly IPaymentlisting ipaymentlisting;
        public PaymentListingController(IPaymentlisting _IPaymentlisting, ILogger<PaymentListingController> logger)
        {
            ipaymentlisting = _IPaymentlisting;
            _logger = logger;
        }
        [HttpGet]
        [Route("AllPaymentDetails/{MemberID}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<PaymentlistingDTO> AllPaymentDetails(string MemberID)
        {
            try
            {
                return ipaymentlisting.AllPaymentDetails(MemberID);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "AllPaymentDetails", 1);
                return new List<PaymentlistingDTO>();
            }
        }
        [HttpGet]
        [Route("AllPaymentDetails")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<PaymentlistingDTO> AllPaymentDetails()
        {
            try
            {
                return ipaymentlisting.AllPaymentDetails();
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "AllPaymentDetails", 1);
                return new List<PaymentlistingDTO>();
            }
        }
        [HttpGet]
        [Route("ListofMemberNo/{Memberno}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<PaymentAutocompDTO> ListofMemberNo(string Memberno)
        {
            try
            {
                return ipaymentlisting.ListofMemberNo(Memberno);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "ListofMemberNo", 1);
                return new List<PaymentAutocompDTO>();
            }
        }
        [HttpGet]
        [Route("ListofMemberName/{Membername}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<PaymentAutocompDTO> ListofMemberName(string Membername)
        {
            try
            {
                return ipaymentlisting.ListofMemberName(Membername);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(1, ex, "ListofMemberName", 1);
                return new List<PaymentAutocompDTO>();
            }
        }

    }
}
