using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceLib29aug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceLib29aug.Tests
{
    [TestClass()]
    public class DiceResultTests
    {
        //unit test af modelklassen diceresult, vi tester
        //på om de givne constraints virker som forventet

        [TestMethod()]
        public void DiceTestConstructor()
        {
            //testc data - Arrange
            DiceResult diceTest = new DiceResult("Kuno", 4);

            Assert.AreEqual(4, diceTest.DiceValue);
            Assert.AreEqual("Kuno", diceTest.PlayerName);
        }

        [TestMethod()]
        public void DiceTestValid()
        {
            //test data - Arrange
            DiceResult diceTest = new DiceResult("Ken",3);
            DiceResult diceTest1 = new DiceResult("Lone", 6);

            Assert.AreEqual(3, diceTest.DiceValue);
            Assert.AreEqual("Ken", diceTest.PlayerName);

            Assert.AreEqual(6, diceTest1.DiceValue);
            Assert.AreEqual("Lone", diceTest1.PlayerName);
        }
        [TestMethod()]
        public void DiceTestInvalid()
        {
            //test data - Arrange
            DiceResult diceTest = new DiceResult("Ken", 3);

            //test null ex
            Assert.ThrowsException<ArgumentNullException>(() => diceTest.PlayerName = null);
            //test over/under grænsen - kast ex!
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => diceTest.PlayerName = "Bo");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => diceTest.DiceValue = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => diceTest.DiceValue = 7);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //test data - Arrange
            DiceResult diceTest = new DiceResult("Ken", 3);

            string testSize = diceTest.ToString();
            Assert.AreEqual("Player name is: Ken & Dice value is: 3", testSize);
            //return $"Dice value is: {DiceValue} & Player name is: {PlayerName}";

        }
    }
}