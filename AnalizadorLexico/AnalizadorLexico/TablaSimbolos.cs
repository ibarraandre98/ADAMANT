using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class TablaSimbolos
    {
        public String tipo { get; set; }
        public String tipoDato { get; set; }
        public String variable { get; set; }
        public String valor { get; set; }
        

        public TablaSimbolos()
        {
            
        }
        public TablaSimbolos(String tipo, String tipoDato,String variable,String valor)
        {
            this.tipo = tipo;
            this.tipoDato = tipoDato;
            this.variable = variable;
            this.valor = valor;
        }

        public String toString()
        {
            return "El tipo es: " + tipo + " el tipo de dato es: " + tipoDato+ " la variable es: " + variable + " el valor es: " + valor;
        }
    }
}
