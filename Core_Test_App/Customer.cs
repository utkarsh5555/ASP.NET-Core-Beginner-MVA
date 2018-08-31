using System.ComponentModel.DataAnnotations;

namespace Core_Test_App
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required, StringLength(49)]
        public string Name { get; set; }        
    }
}