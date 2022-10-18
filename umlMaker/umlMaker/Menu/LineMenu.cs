using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Buttons;
using umlMaker.Buttons.Lines;

namespace umlMaker.Menu
{
    public class LineMenu : MenuParent
    {
        public LineMenu()
        {
            AddBox(new AssociationLine(), BoxPosition.UP);
            AddBox(new DirectAssociationLine(), BoxPosition.UP);
            AddBox(new DependencyLine(), BoxPosition.UP);
            AddBox(new InheritanceLine(), BoxPosition.UP);
            AddBox(new RealizationLine(), BoxPosition.UP);
            AddBox(new AggregationLine(), BoxPosition.UP);
            AddBox(new ContainmentLine(), BoxPosition.UP);
        }
    }
}
