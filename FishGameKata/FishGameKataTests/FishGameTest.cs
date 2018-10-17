using System;
using FishsGameKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FishGameKataTests
{
    [TestClass]
    public class FishGameTest
    {
        [TestMethod]
        public void FishTest1()
        {
            GameFish game = new GameFish();
            string fishs = "";
            Assert.AreEqual(1, game.Fish(fishs));
        }

        [TestMethod]
        public void FishTest2()
        {
            GameFish game = new GameFish();
            string fishs = "0";
            Assert.AreEqual(1, game.Fish(fishs));
        }

        [TestMethod]
        public void FishTest3()
        {
            GameFish game = new GameFish();
            string fishs = "5";
            Assert.AreEqual(1, game.Fish(fishs));
        }

        [TestMethod]
        public void FishTest4()
        {
            GameFish game = new GameFish();
            string fishs = "1111";
            Assert.AreEqual(2, game.Fish(fishs));
        }

        [TestMethod]
        public void FishTest5()
        {
            GameFish game = new GameFish();
            string fishs = "11112222";
            Assert.AreEqual(3, game.Fish(fishs));
        }

        [TestMethod]
        public void FishTest6()
        {
            GameFish game = new GameFish();
            string fishs = "111122223333";
            Assert.AreEqual(4, game.Fish(fishs));
        }

        [TestMethod]
        public void FishTest7()
        {
            GameFish game = new GameFish();
            string fishs = "111111111111";
            Assert.AreEqual(3, game.Fish(fishs));
        }

        [TestMethod]
        public void FishTest8()
        {
            GameFish game = new GameFish();
            string fishs = "111111111111111111112222222222";
            Assert.AreEqual(5, game.Fish(fishs));
        }

        [TestMethod]
        public void FishTest9()
        {
            GameFish game = new GameFish();
            string fishs = "151128241212192113722321331";
            Assert.AreEqual(5, game.Fish(fishs));
        }
    }
}
