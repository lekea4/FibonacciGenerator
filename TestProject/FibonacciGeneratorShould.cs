using FluentAssertions;
using NUnit.Framework;

namespace TestProject
{
    public class FibonacciGeneratorShould
    {
        //Specification 
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        public void ReturnFibNumber0WhenFibIndexIs0(int fibIndex, int expectedFibNumber )
        {
            var generator = new FibonacciGenerator();
            var fibNumber = generator.GetFibNumber(fibIndex);
            fibNumber.Should().Be(expectedFibNumber);
        }


    }

    public class FibonacciGenerator
    {
        public int GetFibNumber(int fibIndex)
        {
            if(fibIndex > 1) return GetFibNumber(fibIndex-1) + GetFibNumber(fibIndex-2);
            if (fibIndex ==  1) return 1;
            return 0;

        }
    }


    /* 
     *Specifications of the Code
     
    fib(n) = fib(n-1) + fib(n-2): n > 1 ;
    
    fib(n) = m;

    where: n = fib index and m = fib number; 

    fib(0) = 0; 
    fib(1) = 1;
    fib(2) = 1;
    fib(3) = 2;
    fib(4) = 3;
    fib(5) = 5;
    fib(6) = 8;
    fib(7) = 13;

     
     */
}