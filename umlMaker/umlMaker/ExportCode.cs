using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using umlMaker.Buttons.Lines;
using umlMaker.Objects;
using umlMaker.SubObjects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace umlMaker
{
    public class ExportCode
    {
        private string Text = "";

        public void Export(string dirPath)
        {
            foreach (var item in ApplicationGetter.GetClasses())
            {
                List<Attributes> attributes = new List<Attributes>();
                List<Operations> operations = new List<Operations>();
                List<Attributes> constructorAttributes = new List<Attributes>();
                string inher = "";

                foreach (var connection in ApplicationGetter.GetConnections())
                {

                    if(connection.To == item && connection.LineType.GetType() == new AggregationLine().GetType())
                    {
                        attributes.Add(new Attributes() { Name = connection.From.Name, Visibility = Visibility.PUBLIC, DataType = connection.From.Name });
                    }
                    if(connection.To == item && connection.LineType.GetType() == new InheritanceLine().GetType())
                    {
                        if (inher == "")
                            inher += " : ";
                        else
                            inher += ", ";
                        inher += connection.From.Name;
                    }
                    if (connection.To == item && connection.LineType.GetType() == new RealizationLine().GetType())
                    {
                        if (inher == "")
                            inher += " : ";
                        else
                            inher += ", ";
                        inher += connection.From.Name;
                        foreach (var attr in connection.From.Attributes)
                        {
                            attributes.Add(attr);
                        }
                        foreach (var oper in connection.From.Operations)
                        {
                            operations.Add(oper);
                        }
                    }
                    if (connection.From == item && connection.LineType.GetType() == new DependencyLine().GetType())
                    {
                        Attributes a = new Attributes() { Name = connection.To.Name, Visibility = Visibility.PUBLIC, DataType = connection.To.Name };
                        attributes.Add(a);
                        constructorAttributes.Add(a);
                    }
                }
                ExportClass(item, attributes, operations, constructorAttributes, inher);

                StreamWriter sw = new StreamWriter(dirPath + "\\" + item.Name + ".cs");
                sw.Write(Text);
                sw.Close();
            }
        }
        private void ExportClass(Class @class, List<Attributes> attributes, List<Operations> operations, List<Attributes> constructorAttributes, string inher)
        {
            Text = "";
            AddLine("using System;");
            AddLine("using System.Collections.Generic;");
            AddLine("using System.Linq;");
            AddLine("using System.Text;");
            AddLine("using System.Threading.Tasks;");
            NewLine();
            AddLine("namespace UML_Export");
            AddLine("{");
                AddLine("public " + GetClassType(@class.ClassType) + " " + @class.Name + inher, 1);
                AddLine("{", 1);
                foreach (var item in @class.Attributes)
                {
                    DrawAttribute(item);
                }
                foreach (var item in attributes)
                {
                    DrawAttribute(item);
                }
                NewLine();
                DrawConstructor(@class.Name, constructorAttributes);
                NewLine();
                foreach (var item in @class.Operations)
                {
                    DrawOperation(@class, item);
                }
                foreach (var item in operations)
                {
                    DrawOperation(@class, item);
                }
                AddLine("}", 1);
            AddLine("}");


        }
        private void DrawTab(int count)
        {
            Text += "".PadLeft(count*4,' ');
        }
        private void NewLine()
        {
            Text += "\r\n";
        }
        private void AddLine(string line, int tabs = 0)
        {
            DrawTab(tabs);
            Text += line;
            NewLine();
        }
        private void DrawConstructor(string className, List<Attributes> constructorAttributes)
        {
            if(constructorAttributes.Count != 0)
            {
                DrawTab(2);
                string att = "";
                foreach (var item in constructorAttributes)
                {
                    att += item.DataType + " " + item.Name.ToLower() + ", ";
                }
                att = att.Substring(0, att.Length - 2);
                AddLine("public " + className + "(" + att + ")");
                AddLine("{",2);
                NewLine();
                foreach (var item in constructorAttributes)
                {
                    AddLine(item.Name + " = " + item.Name.ToLower() + ";", 3);
                }
                AddLine("}",2);
                NewLine();

            }
        }
        public string GetVisibility(Visibility visibility)
        {
            if (visibility == Visibility.PUBLIC)
                return "public";
            else if (visibility == Visibility.PROTECTED)
                return "protected";
            else
                return "private";
        }
        public string GetClassType(ClassType classType)
        {
            if (classType == ClassType.CLASS)
                return "class";
            else if (classType == ClassType.INTERFACE)
                return "interface";
            else
                return "abstract class";
        }
        private void DrawAttribute(Attributes attribute)
        {
            DrawTab(2);
            Text += GetVisibility(attribute.Visibility) + " " + attribute.DataType + " " + attribute.Name;
            if (attribute.Visibility == Visibility.PUBLIC)
                Text += " {get; set; }";
            else
                Text += ";";
            NewLine();
        }
        private void DrawOperation(Class @class, Operations operations)
        {
            DrawTab(2);
            Text += GetVisibility(operations.Visibility) + " " + operations.ReturnType + " " + operations.Name + "(" + operations.Parametrs + ")";
            if(@class.ClassType == ClassType.INTERFACE)
            {
                Text += ";";
            }
            else
            {
                NewLine();
                AddLine("{", 2);
                NewLine();
                AddLine("throw new NotImplementedException();", 3);
                NewLine();
                AddLine("}", 2);
                NewLine();
            }

        }
    }
}
