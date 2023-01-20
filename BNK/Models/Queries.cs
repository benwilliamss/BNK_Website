
namespace BNK.Models
{
    public class Queries
    {  //need attributes to add - postit note that we stick to a property below 
        public int QueryID { get; set; }
        public string  Query {get; set;}
      
        public bool Status { get; set; }
        public int CustomerID { get; set; }

    }
}
