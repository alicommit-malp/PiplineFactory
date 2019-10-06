using System;
using core;
using core.data.Domain;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            new RequestHandler().HandleRequest(new DataDtoDomain()
            {
                Value = "http://youtube.com/adasdads"
            });
        }
    }
}
