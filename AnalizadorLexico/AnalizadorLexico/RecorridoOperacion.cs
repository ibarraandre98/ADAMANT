using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    class RecorridoOperacion
    {
        public static String resolverOperacion(ParseTreeNode root)
        {
            //MessageBox.Show(root.ChildNodes.ElementAt(0).ToString());
            //MessageBox.Show("El resultado es: " + expresion(root.ChildNodes.ElementAt(0)));
            String retorno = expresion(root.ChildNodes.ElementAt(0)).ToString();
            return retorno;
        }

        private static Double expresion(ParseTreeNode root)
        {
            switch (root.ChildNodes.Count)
            {
                case 1://Nodo hoja
                    String[] numero = root.ChildNodes.ElementAt(0).ToString().Split(' ');
                    return Convert.ToDouble(numero[0]);

                case 3://Nodo binario
                    switch (root.ChildNodes.ElementAt(1).ToString().Substring(0, 1))
                    {
                        case "+": //E + E
                            return expresion(root.ChildNodes.ElementAt(0)) + expresion(root.ChildNodes.ElementAt(2));
                        case "-":
                            return expresion(root.ChildNodes.ElementAt(0)) - expresion(root.ChildNodes.ElementAt(2));
                        case "*":
                            return expresion(root.ChildNodes.ElementAt(0)) * expresion(root.ChildNodes.ElementAt(2));
                        case "/":
                            return expresion(root.ChildNodes.ElementAt(0)) / expresion(root.ChildNodes.ElementAt(2));
                        case "^":
                            return Math.Pow(expresion(root.ChildNodes.ElementAt(0)), expresion(root.ChildNodes.ElementAt(2)));
                        case "√":
                            return Math.Pow(expresion(root.ChildNodes.ElementAt(2)), 1 / expresion(root.ChildNodes.ElementAt(0)));
                        default:
                            return expresion(root.ChildNodes.ElementAt(1));
                    }
            }
            return 0.0;
        }
    }
}
