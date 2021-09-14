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
    public class CloudWritterTests
    {
        [TestMethod]
        public void CreateCloudWritter_Ok()
        {
            FactoryContainer container = new FactoryContainer();

            IWrittable expected = container.GetWritterCloud().CreateWritter(TypeFormat.json);
            IWrittable current = container.GetWritterCloud().CreateWritter(TypeFormat.json);

            Assert.AreEqual(current, expected);
        }
        [TestMethod]
        public void CreateCloudWritter_Fail()
        {
            FactoryContainer container = new FactoryContainer();

            IWrittable expected = container.GetWritterCloud().CreateWritter(TypeFormat.json);
            IWrittable current = container.GetWritterCloud().CreateWritter(TypeFormat.xml);

            Assert.AreNotEqual(current, expected);
        }
    }
}
