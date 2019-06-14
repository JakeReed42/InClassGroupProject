using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class RequestType
    {
        [Key]
        [Required]
        public int RequestTypeID { get; set; }

        public string RequestTypeName { get; set; }

        public RequestType() { }

        public RequestType(string requestName)
        {
            this.RequestTypeName = requestName;
        }

        public static List<RequestType> PopulateRequestType()
        {
            List<RequestType> requestTypesList = new List<RequestType>();

            RequestType requestType = new RequestType("Time Off");
            requestTypesList.Add(requestType);

            requestType = new RequestType("Paid Time Off");
            requestTypesList.Add(requestType);

            requestType = new RequestType("Mileage Reimbursement");
            requestTypesList.Add(requestType);

            requestType = new RequestType("Purchase Reimbursement");
            requestTypesList.Add(requestType);

            return requestTypesList;
        }

    }
}
