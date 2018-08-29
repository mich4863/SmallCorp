using System;
using System.Runtime.Serialization;

namespace SmallCorp.DataAccessBase
{
    [Serializable]
    internal class DataAccessException :Exception
    {
        public DataAccessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}