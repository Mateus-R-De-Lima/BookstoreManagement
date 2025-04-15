using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Communication.Responses
{
    public class ResponseErros
    {
        public List<String> ErrorMessages { get; set; } = [];

        public ResponseErros(string error)
        {
            ErrorMessages = [error];
        }

        public ResponseErros(List<string> errorMessages)
        {
            ErrorMessages = errorMessages;
        }
    }
}
