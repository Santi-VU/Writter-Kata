using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Writter_Kata.Containers;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;
using Writter_Kata.Models.Factorys;
using Writter_Kata.Models.Formaters;

namespace WritterTests
{
    [TestClass]
    public class FormatersTests
    {
        [TestMethod]
        public void GetFormat_Ok()
        {
            JsonFormater json = new JsonFormater();
            TypeFormat expected = TypeFormat.json;
            TypeFormat current = json.GetFormat();

            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void GetFormat_Fail()
        {
            JsonFormater json = new JsonFormater();
            TypeFormat expected = TypeFormat.xml;
            TypeFormat current = json.GetFormat();

            Assert.AreNotEqual(expected, current);
        }
    }
}
