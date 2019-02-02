using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(String msg) :base(msg){
        }
    }
}
