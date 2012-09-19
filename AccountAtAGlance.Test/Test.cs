using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountAtAGlance.Model;
using NUnit.Framework;

namespace AccountAtAGlance.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Simple()
        {
            int a, b;
            a = 1;
            b = 2;

            Assert.AreNotEqual(a, b);
        }

        
    }
}
