using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProgrami
{
    public class AuthorModel
    {
        public string _uid;
        public string _firstName;
        public string _lastName;
        public List<BookModel> _books = new List<BookModel>();

        public AuthorModel(string uid, string firstName, string lastName)
        {
            _uid = uid;
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
