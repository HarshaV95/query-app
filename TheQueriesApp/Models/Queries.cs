using System.ComponentModel.DataAnnotations;

namespace TheQueriesApp.Models
{
    public class Queries
    {

        public int Id { get; set; } 

        public string QuerieQuestion { get; set; }
        public string QuerieAnswer { get; set; }

        public Queries()
        {
            
        }
    }
}
