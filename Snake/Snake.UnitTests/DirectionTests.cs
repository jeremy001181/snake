using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.UnitTests
{
    [TestFixture]
    class DirectionTests
    {
        [Test]
        public void Should_grow_by_one_when_snake_ate_an_apple() {
            var snake = new Snake(2);
            var apple = new Apple();

            snake.Eat(apple);

            Assert.AreEqual(3, snake.Length);
        }
    }
}
