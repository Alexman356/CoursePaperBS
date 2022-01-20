using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CoursePaper
{
    [TestClass]
    public class Test
    {
        private string number = "890583455135";
        private string[] names = new string[] { "Анна", "Виктория", "Григорий", "Григорий2", "Григяорий",
            "Евгений", "Женя", "Игнат", "Катя Евдокимова"};

        BinarySearch binarySearch;

        [TestInitialize]
        public void Init()
        {
            Contact[] contacts = new Contact[names.Length];

            contacts = names.Select(name => new Contact(name, number)).ToArray();

            binarySearch = new BinarySearch(contacts);
        }

        [TestMethod]
        public void Test1()
        {
            string searchedName = "Григорий";

            Contact actual = binarySearch.Search(searchedName);
            Contact expected = new Contact("Григорий", number);

            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void Test2()
        {
            string searchedName = "Григорий2";

            Contact actual = binarySearch.Search(searchedName);
            Contact expected = new Contact("Григорий2", number);

            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void Test3()
        {
            string searchedName = "григорий2";

            Contact actual = binarySearch.Search(searchedName);
            Contact expected = new Contact("Григорий2", number);

            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void Test4()
        {
            string searchedName = "Катя Евдокимова";

            Contact actual = binarySearch.Search(searchedName);
            Contact expected = new Contact("Катя Евдокимова", number);

            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void Test5()
        {
            string searchedName = "Никита";

            Contact actual = binarySearch.Search(searchedName);
            Contact expected = null;

            Assert.ReferenceEquals(expected, actual);
        }

        [TestMethod]
        public void Test6()
        {
            string searchedName = null;

            Contact actual = binarySearch.Search(searchedName);
            Contact expected = null;

            Assert.ReferenceEquals(expected, actual);
        }
    }
}