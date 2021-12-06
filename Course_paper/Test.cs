using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Course_paper
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test1()
        {
            List<ContactDatabase> _data = new List<ContactDatabase>();
            string[] contact = new string[4] {"Анна", "Виктория", "Григорий", "Евгений"};
            for (int i = 0; i < contact.Length; i++)
            {
                ContactDatabase contact_data = new ContactDatabase(contact[i], "513");
                _data.Add(contact_data);
            }
            BinarySearch.Wanted_char_array = "Григорий".ToCharArray();
            int status = BinarySearch.SearchContact(_data);
            Assert.AreEqual(2, status);
        }
        [TestMethod]

        public void Test2()
        {
            List<ContactDatabase> _data = new List<ContactDatabase>();
            string[] contact = new string[8] { "Анна", "Виктория", "Григорий", "Григяорий", "Евгений", "Женя", "Игнат", "Катя" };
            for (int i = 0; i < contact.Length; i++)
            {
                ContactDatabase contact_data = new ContactDatabase(contact[i], "513");
                _data.Add(contact_data);
            }
            BinarySearch.Wanted_char_array = "Григяорий".ToCharArray();
            int status = BinarySearch.SearchContact(_data);
            Assert.AreEqual(3, status);
        }

        [TestMethod]
        public void Test3()
        {
            List<ContactDatabase> _data = new List<ContactDatabase>();
            string[] contact = new string[8] { "Анна", "Виктория", "Григорий", "Григяорий", "Евгений", "Женя", "Игнат", "Катя" };
            for (int i = 0; i < contact.Length; i++)
            {
                ContactDatabase contact_data = new ContactDatabase(contact[i], "513");
                _data.Add(contact_data);
            }
            BinarySearch.Wanted_char_array = "Никита".ToCharArray();
            int status = BinarySearch.SearchContact(_data);
            Assert.AreEqual(-1, status);
        }
    }
}
