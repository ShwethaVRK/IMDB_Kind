namespace Shwetha
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actor_Movie
    {
        public int Id { get; set; }
        public Nullable<int> ActorId { get; set; }
        public Nullable<int> MovieId { get; set; }
    
        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
