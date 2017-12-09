using System;

namespace EX2.Models
{
    public class Edge
    {
        public Edge(string name, State node)
        {
            this.Name = name;
            this.Node = node;
        }

        public string Name { get; set; }
        public State Node { get; set; }
    }
}