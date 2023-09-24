using System.Net.Http.Headers;

namespace ReviewApp.Models
{
    public class Review
    {
        public   int Id { get; set; }
        
        public string Product { get; set; }
        public string Descripition { get; set; }
        public DateTime Date { get; set; }

         


        public   Review()
        {
            
        }
    }
}
