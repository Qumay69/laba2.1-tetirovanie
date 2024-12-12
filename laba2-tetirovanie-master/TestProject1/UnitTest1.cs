using NUnit.Framework;
using LogicExpressions;
using Microsoft.Playwright;

namespace LogicExpressions.Tests
{
   
    [TestFixture]
    public class ProgramTests
    {
        [TestCase(0, 0, 0, ExpectedResult = true)]
        [TestCase(0, 0, 1, ExpectedResult = true)]
        [TestCase(0, 1, 0, ExpectedResult = true)]
        [TestCase(0, 1, 1, ExpectedResult = false)]
        [TestCase(1, 0, 0, ExpectedResult = true)]
        [TestCase(1, 0, 1, ExpectedResult = false)]
        [TestCase(1, 1, 0, ExpectedResult = true)]
        [TestCase(1, 1, 1, ExpectedResult = false)]
        public bool TestExpression1(int X, int Y, int Z)
        {
            return Program.Expression1(X, Y, Z);
        }

        [TestCase(0, 0, 0, ExpectedResult = false)]
        [TestCase(0, 0, 1, ExpectedResult = true)]
        [TestCase(0, 1, 0, ExpectedResult = true)]
        [TestCase(0, 1, 1, ExpectedResult = true)]
        [TestCase(1, 0, 0, ExpectedResult = true)]
        [TestCase(1, 0, 1, ExpectedResult = true)]
        [TestCase(1, 1, 0, ExpectedResult = true)]
        [TestCase(1, 1, 1, ExpectedResult = true)]
        public bool TestExpression2(int X, int Y, int Z)
        {
            return Program.Expression2(X, Y, Z);
        }
    }
}

