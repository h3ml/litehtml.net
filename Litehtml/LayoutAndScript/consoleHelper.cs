using Litehtml.Script;
using System;
using System.Diagnostics;

namespace Litehtml
{
    class consoleHelper : IConsole
    {
        void IConsole.assert(object expression, object message)
        {
            throw new NotImplementedException();
        }

        void IConsole.clear()
        {
            throw new NotImplementedException();
        }

        void IConsole.count(string label)
        {
            throw new NotImplementedException();
        }

        void IConsole.error(object message)
        {
            Debug.WriteLine(message);
        }

        void IConsole.group(string label)
        {
            throw new NotImplementedException();
        }

        void IConsole.groupCollapsed(string label)
        {
            throw new NotImplementedException();
        }

        void IConsole.groupEnd()
        {
            throw new NotImplementedException();
        }

        void IConsole.info(object message)
        {
            throw new NotImplementedException();
        }

        void IConsole.log(object message)
        {
            throw new NotImplementedException();
        }

        void IConsole.table(object tabledata, object[] tablecolumns)
        {
            throw new NotImplementedException();
        }

        void IConsole.time(string label)
        {
            throw new NotImplementedException();
        }

        void IConsole.timeEnd(string label)
        {
            throw new NotImplementedException();
        }

        void IConsole.trace(string label)
        {
            throw new NotImplementedException();
        }

        void IConsole.warn(object message)
        {
            throw new NotImplementedException();
        }
    }
}
