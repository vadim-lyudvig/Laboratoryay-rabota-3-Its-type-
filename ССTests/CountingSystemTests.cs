using Microsoft.VisualStudio.TestTools.UnitTesting;
using СС;
using System;
using System.Collections.Generic;
using System.Text;

namespace СС.Tests
{
    [TestClass()]
    public class CountingSystemTests
    {

        [TestMethod()]
        public void Add() // Сложение
        {
            var ss1 = new CountingSystem();
            ss1.number = "10";
            ss1.ss = "2";
            var ss2 = new CountingSystem();
            ss2.number = "10";
            ss2.ss = "10";
            var result = ss1 + ss2;
            Assert.AreEqual(result.number, "12");
        }

        [TestMethod()]
        public void Sub() // Разность
        {
            var ss1 = new CountingSystem();
            ss1.number = "50";
            ss1.ss = "10";
            var ss2 = new CountingSystem();
            ss2.number = "30";
            ss2.ss = "10";
            var result = ss1 - ss2;
            Assert.AreEqual(result.number, "20");
        }

        [TestMethod()]
        public void Mult() // Произведение
        {
            var ss1 = new CountingSystem();
            ss1.number = "A";
            ss1.ss = "16";
            var ss2 = new CountingSystem();
            ss2.number = "B";
            ss2.ss = "16";
            var result = ss1 * ss2;
            Assert.AreEqual(result.number, "110");
        }

        [TestMethod()]
        public void More() // Сравнение
        {
            var ss1 = new CountingSystem();
            ss1.number = "111";
            ss1.ss = "2";
            var ss2 = new CountingSystem();
            ss2.number = "80";
            ss2.ss = "10";
            Assert.AreEqual(ss2 > ss1, true);
        }

        [TestMethod()]
        public void Less() // Сравнение
        {
            var ss1 = new CountingSystem();
            ss1.number = "101";
            ss1.ss = "2";
            var ss2 = new CountingSystem();
            ss2.number = "001";
            ss2.ss = "2";
            Assert.AreEqual(ss2 < ss1, true);
        }

        [TestMethod()]
        public void Equal() // Сравнение
        {
            var ss1 = new CountingSystem();
            ss1.number = "FC";
            ss1.ss = "16";
            var ss2 = new CountingSystem();
            ss2.number = "FC";
            ss2.ss = "16";
            Assert.AreEqual(ss2 == ss1, true);
        }
    }
}