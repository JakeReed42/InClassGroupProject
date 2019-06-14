using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class RequestResponse
    {
        [Key]
        [Required]
        public int RequestResponseID {get;set;}

        public string RequestResponseComment { get; set; }

        public string RequestResponseStatus { get; set; }

        public int RequestID { get; set; }
        [ForeignKey("RequestID")]
        public Request Request { get; set; }

    public RequestResponse()
        { }

    public RequestResponse(string requestResponseComment, string requestStatus, int requestID)
        {
            this.RequestResponseComment = requestResponseComment;
            this.RequestResponseStatus = requestStatus;
            this.RequestID = requestID;
        }


        public static List<RequestResponse> PopulateRequestResponse()
        {
            List<RequestResponse> requestResponsesList = new List<RequestResponse>();
            RequestResponse requestResponse = new RequestResponse("Enjoy the party", "Approved", 1);
            requestResponsesList.Add(requestResponse);

            return requestResponsesList;
        }
    }
}
