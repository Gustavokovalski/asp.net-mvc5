using System;
using System.Runtime.Serialization;

namespace ControleFinancas.Controllers
{
    [Serializable]
    internal class MembershipCreate : Exception
    {
        public MembershipCreate()
        {
        }

        public MembershipCreate(string message) : base(message)
        {
        }

        public MembershipCreate(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MembershipCreate(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}