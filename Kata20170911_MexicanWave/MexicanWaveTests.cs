using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170911_MexicanWave
{
    [TestClass]
    public class MexicanWaveTests
    {
        [TestMethod]
        public void input_empyt_should_return_empty_list()
        {
            StringWaveShouldBe(new List<string>(), "");
        }

        private static void StringWaveShouldBe(List<string> expected, string str)
        {
            var kata = new Kata();
            var actual = kata.wave(str);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public List<string> wave(string str)
        {
            return new List<string>();
        }
    }
}
