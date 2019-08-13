using classCalculatorLibraryProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace classCalculatorTestProject {
    [TestClass]
    public class UnitTest1 {
        Functions functions = new Functions();
        [TestMethod]
        public void TestMethodAdd() {

            // Add test case for total 5, and amount 3
            var answer = functions.Add(5, 3);

            Assert.AreEqual(8, answer);

            answer = functions.Add(5, -3);

            Assert.AreEqual(2, answer);
            answer = functions.Add(5, 0);

            Assert.AreEqual(5, answer);
            answer = functions.Add(5, -100);

            Assert.AreEqual(-95, answer);

            answer = functions.Add(5, 100);

            Assert.AreEqual(105, answer);
        }

        [TestMethod]
        public void TestMethodSub() {
            var answ = functions.Subtract(6, 4);
            Assert.AreEqual(2, answ);

            answ = functions.Subtract(6, -4);
            Assert.AreEqual(10, answ);

            answ = functions.Subtract(6, 0);
            Assert.AreEqual(6, answ);

            answ = functions.Subtract(6, -100);
            Assert.AreEqual(106, answ);

            answ = functions.Subtract(6, 100);
            Assert.AreEqual(-94, answ);
        }

        [TestMethod]
        public void TestMethodMult() {
            var answ = functions.Multiply(6, 4);
            Assert.AreEqual(24, answ);

            answ = functions.Multiply(-3, -3);
            Assert.AreEqual(9, answ);

            answ = functions.Multiply(3, -3);
            Assert.AreEqual(-9, answ);

            answ = functions.Multiply(3, 0);
            Assert.AreEqual(0, answ);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethodDiv() {
            var answ = functions.Divide(6, 3);

            Assert.AreEqual(2, answ);
            answ = functions.Divide(6, 0);

            Assert.Fail();

            answ = functions.Divide(6, -3);

            Assert.AreEqual(2, answ);
        }
    }
}
