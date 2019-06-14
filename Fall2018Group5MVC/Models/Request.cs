using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fall2018Group5MVC.Models
{
    public class Request
    {
        [Key]
        [Required]
        public int RequestID { get; set; }

        // do we want this to be a set list of types?
      

        public String RequestComment { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime RequestDateTime { get; set; }

        [Required]
        public string EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }

        [Required]
        public string ManagerID { get; set; }
        [ForeignKey("ManagerID")]
        public Manager Manager { get; set; }

        [Required]
        public int RequestTypeID { get; set; }
        [ForeignKey("RequestTypeID")]
        public RequestType RequestType { get; set; }




        public Request()
        { }

        public Request(int requestType, string requestComment, DateTime requestDateTime)
        {
            this.RequestTypeID = requestType;
            this.RequestComment = requestComment;
            this.RequestDateTime = requestDateTime;
        }

        public static List<Request> PopulateRequest()
        {
            List<Request> requestList = new List<Request>();

            Request request = new Request(1, "Son's birthday party", new DateTime(2018, 12, 27));
            requestList.Add(request);
          

            return requestList;
        }

    }
    
}
