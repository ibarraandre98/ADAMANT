using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace AnalizadorLexico
{
    class RecorridoParseTree
    {
        private readonly ParseTree parseTree;

        public RecorridoParseTree(ParseTree parseTree)
        {
            this.parseTree = parseTree;
        }

        public List<ParseTreeNode> Recorrer()
        {
            var nodos = new List<ParseTreeNode>();
            Recorrer(parseTree.Root,nodos);
            return nodos;
        }

        private void Recorrer(ParseTreeNode raiz, List<ParseTreeNode> nodos)
        {
            nodos.Add(raiz);
            foreach (var nodo in raiz.ChildNodes)
            {
                Recorrer(nodo, nodos);
            }
        }

    }
}
