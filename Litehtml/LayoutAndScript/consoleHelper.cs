using System;
using System.Diagnostics;

namespace Litehtml
{
    class consoleHelper : Console
    {
        void Console.assert(object expression, object message)
        {
            throw new NotImplementedException();
        }

        void Console.clear()
        {
            throw new NotImplementedException();
        }

        void Console.count(string label)
        {
            throw new NotImplementedException();
        }

        void Console.error(object message)
        {
            Debug.WriteLine(message);
        }

        void Console.group(string label)
        {
            throw new NotImplementedException();
        }

        void Console.groupCollapsed(string label)
        {
            throw new NotImplementedException();
        }

        void Console.groupEnd()
        {
            throw new NotImplementedException();
        }

        void Console.info(object message)
        {
            throw new NotImplementedException();
        }

        void Console.log(object message)
        {
            throw new NotImplementedException();
        }

        void Console.table(object tabledata, object[] tablecolumns)
        {
            throw new NotImplementedException();
        }

        void Console.time(string label)
        {
            throw new NotImplementedException();
        }

        void Console.timeEnd(string label)
        {
            throw new NotImplementedException();
        }

        void Console.trace(string label)
        {
            throw new NotImplementedException();
        }

        void Console.warn(object message)
        {
            throw new NotImplementedException();
        }
    }
}
