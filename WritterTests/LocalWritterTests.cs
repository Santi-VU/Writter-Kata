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
    public class WritterTests
    {
        [TestMethod]
        public void CreateLocalWritter_Ok()
        {
            FactoryContainer container = new FactoryContainer();

            IWrittable expected = container.GetWritterFactory().CreateWritter(TypeFormat.json);
            IWrittable current = container.GetWritterFactory().CreateWritter(TypeFormat.json);

            Assert.AreEqual(current, expected);
        }
        [TestMethod]
        public void CreateLocalWritter_Fail()
        {
            FactoryContainer container = new FactoryContainer();

            IWrittable expected = container.GetWritterFactory().CreateWritter(TypeFormat.json);
            IWrittable current = container.GetWritterFactory().CreateWritter(TypeFormat.xml);

            Assert.AreNotEqual(current, expected);
        }
    }
}
