using System;
using Atomo.Data;
using System.Configuration;

namespace SIIO.DA
{
    public class BaseDA
    {
        protected ReflectionBase rb = new ReflectionBase();

        public BaseDA()
        {
            rb.Conn = ConfigurationManager.ConnectionStrings["CONNECTION_STRING"].ConnectionString;
        }
    }
}
