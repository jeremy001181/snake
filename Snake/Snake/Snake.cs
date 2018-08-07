using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public Snake(int length)
        {
            this.Length = length;
        }

        public int Length { get; private set; }

        public void Eat(Apple apple)
        {
            Length++;
        }
    }
}
