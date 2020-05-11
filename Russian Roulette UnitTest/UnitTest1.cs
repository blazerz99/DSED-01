using System;
using Russian_Roulette_Assessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Russian_Roulette_UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        Gameplay myGameplay = new Gameplay(); // making an instance of the class for all the test method




        [TestMethod]
        public void TestConditionWin()
        {
            myGameplay.SavedPups = 4;
            bool expected = true;
            bool actual = myGameplay.ConditionWin();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestSkip()
        {
            myGameplay.Play();

            var Actual = myGameplay.Skip();

            Assert.AreEqual("Skipped Door", Actual);

        }


    }
}
