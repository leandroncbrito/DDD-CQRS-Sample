using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Exceptions
{
    public class QueryHandlerNofFoundException : Exception
    {
        public QueryHandlerNofFoundException(Type queryType) 
            : base(string.Format("Handler não encontrado para a Query '{0}'", queryType))
        {

        }
    }
}
