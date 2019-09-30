using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;
using LeetSpeak.Models;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void Does_t_become_7_true()
    {
      LeetSpeakTranslator testLST = new LeetSpeakTranslator();
      Assert.AreEqual("7", testLST.Translate("t"));
    }
    [TestMethod]
    public void Does_example_string_match()
    {
      LeetSpeakTranslator testLST = new LeetSpeakTranslator();
      Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 \"S7ring\" 3x3rciz3z? 1 d0!", testLST.Translate("Don't you love these \"String\" exercises? I do!"));
    }
  }
}
