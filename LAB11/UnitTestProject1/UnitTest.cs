using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LAB11;
namespace LAB11
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]


        public void TestCalculationValues()
        {

            //double[] exMas1 = { -58.4, 45.5, 18.5, 31.17 };
            //double[] exMas2 = { 24.98, 35.62, 22, 7.04 };

            double[] values1 = { -58.4, 45.5, 18.5, 31.17 };
            double[] values2 = { 24.98, 35.62, 22, 7.04 };
            double[] values3 = { -1767.4123999999997, 1625.3899999999999, 731.525 };
            Mas mas1 = new Mas();
            Mas mas2 = new Mas();
            Mas expectedMas = new Mas();

            mas1.addRange(mas1, values1);
            mas2.addRange(mas2, values2);
            expectedMas.addRange(expectedMas, values3);

            Mas actualMas = new Mas();
            actualMas = actualMas.calcMas(mas1, mas2);
            CollectionAssert.AreEqual(expectedMas.Matrix, actualMas.Matrix, "Ожидаемые значения не получены");
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestEmptyMas()
        {
            Mas mas1 = new Mas();
            Mas mas2 = new Mas();
            Mas expectedMas = new Mas();
            Mas actualMas = new Mas();
            actualMas = actualMas.calcMas(mas1, mas2);
            CollectionAssert.AreEqual(expectedMas.Matrix, actualMas.Matrix, "Ожидаемые значения не получены");

        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestNotEqualCount()
        {
            Mas mas1 = new Mas();
            Mas mas2 = new Mas();
            mas1 = mas1.rndMas(2);
            mas2 = mas2.rndMas(5);
           
            Mas actualMas = new Mas();
            actualMas = actualMas.calcMas(mas1, mas2);
            CollectionAssert.AreEqual(mas1.Matrix, actualMas.Matrix, "Ожидаемые значения не получены");

        }
    }
} 
