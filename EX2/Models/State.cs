using System.Collections.Generic;

namespace EX2.Models
{
    public class State
    {

        public State(string name)
        {
            this.Name = name;
            this.Edges = new List<Edge>();
        }

        public string Name { get; set; }
        public List<Edge> Edges { get; set; }
    }
}
