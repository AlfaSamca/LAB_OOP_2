using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LAB_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestAdd_and_Delete()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            Assert.AreEqual(linkedList.Count, 0);
            linkedList.Add("physics");
            Assert.AreEqual(linkedList.Count, 1);
            linkedList.Add("mathematics");
            Assert.AreEqual(linkedList.Count, 2);
            linkedList.Add("chemistry");
            Assert.AreEqual(linkedList.Count, 3);

            linkedList.Delete("chemistry");
            Assert.AreEqual(linkedList.Count, 2);
            linkedList.Delete("physics");
            Assert.AreEqual(linkedList.Count, 1);
            linkedList.Delete("mathematics");
            Assert.AreEqual(linkedList.Count, 0);
        }
        [TestMethod]

        public void TestIsEmpty_and_Clear()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            
            linkedList.Add("physics");            
            linkedList.Add("mathematics");         
            linkedList.Add("chemistry");
            Assert.AreEqual(linkedList.IsEmpty, false);
            linkedList.Clear();
            Assert.AreEqual(linkedList.IsEmpty, true);
        }
        [TestMethod]

        public void TestAppendFirst()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AppendFirst("physics");
            foreach (string i in linkedList)
            {
                Assert.AreEqual(i, "physics");
            }

            linkedList.AppendFirst("mathematics");
            foreach (string i in linkedList)
            {
                Assert.AreEqual(i, "mathematics");
                break;
            }
            linkedList.AppendFirst("chemistry");
            foreach (string i in linkedList)
            {
                Assert.AreEqual(i, "chemistry");
                break;
            }
        }
        [TestMethod]

        public void TestContains()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AppendFirst("physics");
            Assert.AreEqual(linkedList.Contains("physics"), true);
            Assert.AreEqual(linkedList.Contains("mathematics"), false);
        }
    }
}
