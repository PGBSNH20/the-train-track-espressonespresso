using System;
using System.Collections.Generic;
using System.IO;

namespace TrainEngine
{
    public class Train : ITrain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public bool Operated { get; set; }

        public Train(int id, string name, int maxSpeed, bool operated)
        {
            Id = id;
            Name = name;
            MaxSpeed = maxSpeed;
            Operated = operated;
        }
    }


}
