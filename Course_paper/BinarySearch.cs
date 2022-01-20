using System;
using System.Linq;

namespace CoursePaper
{
    class BinarySearch
    {
        private readonly string[] names;
        private readonly Contact[] contacts;

        public BinarySearch(Contact[] contacts)
        {
            names = contacts.Select(contact => contact.Name.ToLower()).ToArray();

            this.contacts = contacts;
        }

        public Contact Search(string searchedName)
        {
            int index = -1;

            if (searchedName != null)
            {
                index = SearchName(searchedName.ToLower());
            }

            if (index == -1)
            {
                return null;
            }

            Contact contact = new Contact(contacts[index].Name, contacts[index].Number);

            return contact;
        }

        private int SearchName(string searchedName)
        {
            int index = -1;
            int left = 0;
            int right = names.Length - 1;

            while (left <= right)
            {
                index = Iteration(searchedName, ref left, ref right);

                bool NameIsFound = index != -1;

                if (NameIsFound)
                {
                    return index;
                }
            }

            return index;
        }

        private int Iteration(string searchedName, ref int left, ref int right)
        {
            int middle = left + (right - left) / 2;

            if (IsSearchedName(searchedName, middle))
            {
                return middle;
            }

            string middleName = names[middle];
            char[] searchedNameLetters = searchedName.ToCharArray();
            char[] middleNameLetters = middleName.ToCharArray();

            if (searchedNameLetters.Length < middleNameLetters.Length)
            {
                Array.Resize(ref searchedNameLetters, middleNameLetters.Length);
            }

            if (searchedNameLetters.Length > middleNameLetters.Length)
            {
                Array.Resize(ref middleNameLetters, searchedNameLetters.Length);
            }

            for (int i = 0; i < searchedNameLetters.Length; i++)
            {
                bool LettersAreEqual = searchedNameLetters[i] == middleNameLetters[i];

                if (LettersAreEqual)
                {
                    continue;
                }

                bool isStepToLeft = searchedNameLetters[i] < middleNameLetters[i];

                if (isStepToLeft)
                {
                    right = middle - 1;
                    break;
                }

                if (!isStepToLeft)
                {
                    left = middle + 1;
                    break;
                }
            }

            return -1;
        }

        private bool IsSearchedName(string searchedName, int index)
        {
            char[] currentNameLetters = names[index].ToCharArray();
            char[] searchedNameLetters = searchedName.ToCharArray();

            if (searchedNameLetters.Length != currentNameLetters.Length)
            {
                return false;
            }

            for (int i = 0; i < searchedNameLetters.Length; i++)
            {
                if (searchedNameLetters[i] != currentNameLetters[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}