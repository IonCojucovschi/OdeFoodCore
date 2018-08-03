using System;
using System.ComponentModel.DataAnnotations;



namespace OdeFood.Mdoels
{
    public class Restaurant
    {
        public int ID { get; set; }
        [Required, MaxLength(10)]
        public string Name { get; set; }
        [Required]
        public CuisineType TypeFood { get; set; }
    }
}
