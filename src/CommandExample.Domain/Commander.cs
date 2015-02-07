using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandExample.Domain
{
    // I am cheating by using a static here. Use singleton via injection
    public static class Commander
    {
        public static Dictionary<Type, Type> Mappings = new Dictionary<Type, Type>();

        static Commander()
        {
            var type = typeof (IRequest<>);
            var types = typeof (IRequest<>).Assembly.GetTypes().Where(type.IsAssignableFrom);
            //Mappings.Add();            
        }

        public static void Process<T>(T request)
        {
        }
    }
}