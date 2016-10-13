using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LongestCommonSubsequence;

namespace LCSTest
{
    [TestClass]
    public class LCSTest
    {
        [TestMethod]
        public void find_lcs()
        {
            /* * | *  A  B  C  D  C  B  A
               ---------------------------
               * | 0  0  0  0  0  0  0  0    <---- (Initialise all to 0)
               ---------------------------
               D | 0  0  0  0  1  1  1  1
               ---------------------------
               C | 0  0  0  1  1  2  2  2
               ---------------------------
               B | 0  0  1  1  1  2  3  3
               ---------------------------
               A | 0  1  1  1  1  2  3  4
               ---------------------------
               A | 0  1  1  1  1  2  3  4
               ---------------------------
               B | 0  1  2  2  2  2  3  4
              ---------------------------
               C | 0  1  2  3  3  3  3  4
               ---------------------------
                   ^
                   |
               (initialise all to 0)               
             */

            var lcs = new LCS();
            string sequence=lcs.Find("ABCDCBA", "DCBAABC");
            Assert.AreEqual("DCBA", sequence);
        }
    }
}
