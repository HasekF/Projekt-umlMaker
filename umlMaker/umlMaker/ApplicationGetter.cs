using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Menu;
using umlMaker.Objects;

namespace umlMaker
{
    public static class ApplicationGetter
    {
        public static int WindowHeight { get; set; }
        public static int WindowWidth { get; set; }
        public static WorkSpace WorkSpace { get; set; } = new WorkSpace();

        public static List<Class> GetClasses()
        {
            return WorkSpace.ClassList;
        }
        public static List<Connection> GetConnections()
        {
            return WorkSpace.Connections;
        }
        public static Class? GetSelectedClass()
        {
            return WorkSpace.SelectedClass;
        }

    }
}
