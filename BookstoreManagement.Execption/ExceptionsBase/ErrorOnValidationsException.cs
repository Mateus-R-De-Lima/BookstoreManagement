using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Execption.ExceptionsBase
{
    public class ErrorOnValidationsException: BookstoreManagementExeption
    {
        public List<string> Errors { get; set; }

        public ErrorOnValidationsException(List<string> errorMessages)
        {
            Errors = errorMessages;
        }
    }
}
