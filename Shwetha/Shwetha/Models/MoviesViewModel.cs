using System;
using System.Collections.Generic;


namespace Shwetha.Models
{
    public class MoviesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime YearofRelease { get; set; }
        public string Plot { get; set; }
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public List<int?> ActorId { get; set; }
        public List<string> ActorName { get; set; }
    }
}