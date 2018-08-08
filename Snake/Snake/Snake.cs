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
            BodyParts = new List<BodyPart>(Enumerable.Repeat(new BodyPart(), length));
        }

        public int Length { get; private set; }
        public IList<BodyPart> BodyParts { get; internal set; }

        public void Eat(Apple apple)
        {
            Length++;
        }
    }
}
