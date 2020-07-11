using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metodi;

namespace Test
{
    [TestClass]
    public class Test_MaxMinMedia
    {
        [DataTestMethod]
        [DataRow(5, 2, 5)]
        [DataRow(3, 4, 4)]
        [DataRow(7, 7, 7)]
        public void TestMax(int n1, int n2, int aspettato)
        {
            int max = Metodi_MaxMinMedia.Max(n1, n2);
            Assert.AreEqual(aspettato, max);
        }

        [DataTestMethod]
        [DataRow(5, 2, 2)]
        [DataRow(3, 4, 3)]
        [DataRow(7, 7, 7)]
        public void TestMin(int n1, int n2, int aspettato)
        {
            int min = Metodi_MaxMinMedia.Min(n1, n2);
            Assert.AreEqual(aspettato, min);
        }

        [DataTestMethod]
        [DataRow(5, 2, 3.5)]
        [DataRow(3, 4, 3.5)]
        [DataRow(7, 7, 7)]
        public void TestMedia(int n1, int n2, double aspettato)
        {
            double media = Metodi_MaxMinMedia.Media(n1, n2);
            Assert.AreEqual(aspettato, media);
        }
    }
}
