using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class GramaticaOperaciones : Grammar
    {
        public GramaticaOperaciones() : base(caseSensitive: false)
        {
            #region 
            RegexBasedTerminal numero = new RegexBasedTerminal("numero", "-?[0-9]+(\\,?[0-9])?");
            //RegexBasedTerminal numerodecimal = new RegexBasedTerminal("numero decimal", "-?[0-9]+.[0-9]+");
            RegexBasedTerminal variable = new RegexBasedTerminal("variable", "[a-zA-Z]+[0-9]*");
            #endregion

            #region
            var mas = ToTerm("+");
            var menos = ToTerm("-");
            var por = ToTerm("*");
            var div = ToTerm("/");
            var parentesisizquierdo = ToTerm("(");
            var parentesisderecho = ToTerm(")");
            var raizcuad = ToTerm("√");
            var potencia = ToTerm("^");
            #endregion

            #region
            NonTerminal raiz = new NonTerminal("raiz"),
            E = new NonTerminal("E"), add = new NonTerminal("add"), muldiv = new NonTerminal("muldiv"),
            potraiz = new NonTerminal("potraiz"), parentesis = new NonTerminal("parentesis"), vars = new NonTerminal("vars"),
            nodos = new NonTerminal("nodos");

            #endregion

            #region Gramatica
            raiz.Rule = nodos;
            //E.Rule = E + mas + E
            //    |E + menos + E
            //    |E + por + E
            //    |E + div + E
            //    |variable
            //    |numero
            //    ;

            nodos.Rule = nodos + mas + nodos
                | nodos + menos + nodos
                | nodos + por + nodos
                | nodos + div + nodos
                | variable
                | numero
                | parentesisizquierdo + nodos + parentesisderecho
                | nodos + raizcuad + nodos
                | nodos + potencia + nodos
                ;

            #endregion

            #region Preferencias
            this.Root = raiz;
            this.RegisterOperators(20, Associativity.Left, mas, menos);
            this.RegisterOperators(30, Associativity.Left, por, div);
            //this.MarkPunctuation(parentesisizquierdo,parentesisderecho);
            #endregion
        }
    }
}
