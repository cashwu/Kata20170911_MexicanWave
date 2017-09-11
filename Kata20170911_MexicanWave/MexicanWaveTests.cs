using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void input_ab_should_return_Ab_aB()
        {
            StringWaveShouldBe(new List<string>{ "Ab", "aB" }, "ab");
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
            return Enumerable.Range(0, str.Length)
                .Select(i => string.Concat(str.Select((c, idx) => i == idx ? char.ToUpper(c) : c)))
                .ToList();
        }
    }
}
