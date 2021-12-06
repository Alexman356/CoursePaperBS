
namespace Course_paper
{
    class ContactDatabase
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public ContactDatabase(string _name, string _number)
        {
            Name = _name;
            Number = _number;
        }
    }
}