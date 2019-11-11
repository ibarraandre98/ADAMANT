using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace AnalizadorLexico
{
    class Gramatica : Grammar
    {
        public Gramatica() : base(caseSensitive: false)
        {
            #region ER
            RegexBasedTerminal id = new RegexBasedTerminal("id", "[_a-zA-Z]+([0-9]+)?");
            RegexBasedTerminal numero = new RegexBasedTerminal("numero", "-?[0-9]+");
            RegexBasedTerminal numerodecimal = new RegexBasedTerminal("numero-decimal", "-?[0-9]+(\\.?[0-9]+)?");
            RegexBasedTerminal cualquier = new RegexBasedTerminal("cualquier", "\"[^\"]*\"");
            RegexBasedTerminal cualquiercar = new RegexBasedTerminal("cualquiercar", "\'.?\'");
            #endregion

            #region Terminales
            var reservadaabstracto = ToTerm("abstracto");
            var reservadacomo = ToTerm("como");
            var reservadaasincrono = ToTerm("asincrono");
            var reservadaespera = ToTerm("espera");
            var reservadachecado = ToTerm("checado");
            var reservadaconst = ToTerm("const");
            var reservadacontinuar = ToTerm("continuar");
            var reservadadefecto = ToTerm("defecto");
            var reservadadelegate = ToTerm("delegate");
            var reservadabase = ToTerm("base");
            var reservadaromper = ToTerm("romper");
            var reservadacaso = ToTerm("caso");
            var reservadahacer = ToTerm("hacer");
            var reservadasino = ToTerm("sino");
            var reservadaenumerar = ToTerm("enumerar");
            var reservadaevento = ToTerm("evento");
            var reservadaexplicito = ToTerm("explicito");
            var reservadaexterno = ToTerm("externo");
            var reservadafalso = ToTerm("falso", "tipodedato");
            var reservadafinalmente = ToTerm("finalmente");
            var reservadaarreglado = ToTerm("arreglado");
            var reservadapara = ToTerm("para");
            var reservadaparacadauno = ToTerm("paracadauno");
            var reservadaira = ToTerm("ira");
            var reservadasi = ToTerm("si");
            var reservadaimplicito = ToTerm("implicito");
            var reservadaen = ToTerm("en");
            var reservadainterface = ToTerm("interface");
            var reservadainterno = ToTerm("interno");
            var reservadaes = ToTerm("es");
            var reservadacerrado = ToTerm("cerrado");
            var reservadanuevo = ToTerm("nuevo");
            var reservadanulo = ToTerm("nulo");
            var reservadaoperador = ToTerm("operador");
            var reservadaatrapar = ToTerm("atrapar");
            var reservadafuera = ToTerm("fuera");
            var reservadaanular = ToTerm("anular");
            var reservadaparametros = ToTerm("parametros");
            var reservadaprivado = ToTerm("privado");
            var reservadaprotegido = ToTerm("protegido");
            var reservadapublico = ToTerm("publico");
            var reservadaleersolo = ToTerm("leersolo");
            var reservadareferencia = ToTerm("referencia");
            var reservadaretorno = ToTerm("retorno");
            var reservadasellado = ToTerm("sellado");
            var reservadatamañode = ToTerm("tamañode");
            var reservadaapilar_todo = ToTerm("apilar_todo");
            var reservadaestatico = ToTerm("estatico");
            var reservadainterruptor = ToTerm("interruptor");
            var reservadaeste = ToTerm("este");
            var reservadatirar = ToTerm("tirar");
            var reservadaverdadero = ToTerm("verdadero", "tipodedato");
            var reservadaintentar = ToTerm("intentar");
            var reservadatipo_de = ToTerm("tipo_de");
            var reservadanombre_espacio = ToTerm("nombre_espacio");
            var reservadanochecado = ToTerm("nochecado");
            var reservadainseguro = ToTerm("inseguro");
            var reservadavirtual = ToTerm("virtual");
            var reservadavacio = ToTerm("vacio");
            var reservadamientras = ToTerm("mientras");
            var reservadaflotante = ToTerm("flotante", "tipodedato");
            var reservadaentero = ToTerm("entero", "tipodedato");
            var reservadalargo = ToTerm("largo", "tipodedato");
            var reservadaobjeto = ToTerm("objeto");
            var reservadaobtener = ToTerm("obtener");
            var reservadaponer = ToTerm("poner");
            var reservadaparcial = ToTerm("parcial ");
            var reservadarendimiento = ToTerm("rendimiento");
            var reservadaañadir = ToTerm("añadir");
            var reservadaremover = ToTerm("remover");
            var reservadavalor = ToTerm("valor");
            var reservadaalias = ToTerm("alias");
            var reservadaascendiente = ToTerm("ascendiente");
            var reservadadescendiente = ToTerm("descendiente");
            var reservadade = ToTerm("de");
            var reservadagrupo = ToTerm("grupo");
            var reservadadentro = ToTerm("dentro");
            var reservadaordenpor = ToTerm("ordenpor");
            var reservadaseleccionar = ToTerm("seleccionar");
            var reservadadonde = ToTerm("donde");
            var reservadaunir = ToTerm("unir");
            var reservadaequitativo = ToTerm("equitativo");
            var reservadausando = ToTerm("usando");
            var reservadabooleano = ToTerm("booleano", "tipodedato");
            var reservadabyte = ToTerm("byte");
            var reservadacaracter = ToTerm("caracter", "tipodedato");
            var reservadadecimal = ToTerm("decimal");
            var reservadadoble = ToTerm("doble", "tipodedato");
            var reservadadinamico = ToTerm("dinamico");
            var reservadasbyte = ToTerm("sbyte");
            var reservadacorto = ToTerm("corto");
            var reservadavariable = ToTerm("variable");
            var reservadaclase = ToTerm("clase");
            var reservadaspacename = ToTerm("spacename");
            var reservadaotrocaso = ToTerm("otrocaso");
            var reservadapuntocoma = ToTerm(";");
            var reservadallaveabrir = ToTerm("{");
            var reservadallavecerrar = ToTerm("}");
            var reservadacadena = ToTerm("cadena", "tipodedato");
            var reservadaparentesisabrir = ToTerm("(");
            var reservadaparentesiscerrar = ToTerm(")");
            var reservadacorcheteabrir = ToTerm("[");
            var reservadacorchetecerrar = ToTerm("]");
            var reservadaargumento = ToTerm("argumento");
            var reservadaprincipal = ToTerm("principal");
            var reservadaigual = ToTerm("=");
            var reservadaigualigual = ToTerm("==");
            var reservadamayorque = ToTerm(">");
            var reservadadiferenteque = ToTerm("!=");
            var reservadamenorque = ToTerm("<");
            var reservadamenorigualque = ToTerm("<=");
            var reservadamayorigualque = ToTerm(">=");
            var reservadacomilladoble = ToTerm("\"");
            var reservadacomillasimple = ToTerm("'");
            var reservadaincremento = ToTerm("++");
            var reservadadecremento = ToTerm("--");
            var reservadasistema = ToTerm("sistema");
            var reservadadospuntos = ToTerm(":");
            var reservadapordefecto = ToTerm("pordefecto");
            var reservadaimprimir = ToTerm("imprimir");
            var reservadamas = ToTerm("+");
            var reservadamenos = ToTerm("-");
            var reservadapor = ToTerm("*");
            var reservadaentre = ToTerm("/");
            var reservadapotencia = ToTerm("^");
            var reservadaraiz = ToTerm("√");
            var reservadaasignacion = ToTerm("->");
            var reservadaas = ToTerm("asign");
            var reservadaain = ToTerm("<>in");
            var reservadaascad = ToTerm("asignC");

            #endregion
            #region No Terminales
            NonTerminal usando = new NonTerminal("Usando");
            NonTerminal librerias = new NonTerminal("Libreria");
            NonTerminal spacename = new NonTerminal("SpaceName");
            NonTerminal tipodevariable = new NonTerminal("TipoDeVariable");
            NonTerminal declaracion = new NonTerminal("Declaracion");
            NonTerminal clase = new NonTerminal("Clase");
            NonTerminal acceso = new NonTerminal("Acceso");
            NonTerminal voidmain = new NonTerminal("Voidmain");
            NonTerminal condicional = new NonTerminal("condicional");
            NonTerminal dentrovoid = new NonTerminal("dentrovoid");
            NonTerminal operadores = new NonTerminal("operadores");
            NonTerminal tipodedatonumerico = new NonTerminal("tipodedatonumerico");
            NonTerminal numvar = new NonTerminal("numvar");
            NonTerminal operadoresincrementos = new NonTerminal("opeincre");
            NonTerminal operadoresincrementossinpara = new NonTerminal("operadoresincrementossinpara");
            NonTerminal para = new NonTerminal("para");
            NonTerminal mientras = new NonTerminal("mientras");
            NonTerminal hacer = new NonTerminal("hacer");
            NonTerminal asignaciones = new NonTerminal("asignaciones");
            NonTerminal cualquierdato = new NonTerminal("cualquierdato");
            NonTerminal interruptor = new NonTerminal("interruptor");
            NonTerminal caso = new NonTerminal("caso");
            NonTerminal pordefecto = new NonTerminal("caso");
            NonTerminal impresion = new NonTerminal("impresion");
            NonTerminal operacion = new NonTerminal("operacion");
            NonTerminal asignacion = new NonTerminal("asignacion");
            NonTerminal ain = new NonTerminal("ain");
            NonTerminal condicionalsi = new NonTerminal("condicionalsi");
            NonTerminal condicionalsino = new NonTerminal("condicionalsino");
            NonTerminal impresionCompleja = new NonTerminal("impresionCompleja");
            NonTerminal dentroImpresion = new NonTerminal("dentroImpresion");
            NonTerminal asignacionCadena = new NonTerminal("asignacionCadena");
            NonTerminal dentroAsignacionCadena = new NonTerminal("dentroAsignacionCadena");

            //NonTerminal palabrasreservadas = new NonTerminal("palabrasreservadas");
            NonTerminal raiz = new NonTerminal("raiz");
            NonTerminal E = new NonTerminal("E");

            //NonTerminal 
            #endregion


            raiz.Rule = usando;
            raiz.ErrorRule = SyntaxError + ";";

            /*
            E.Rule = E + ToTerm("+") + E
            | E + ToTerm("-") + E
            | E + ToTerm("*") + E
            | E + ToTerm("/") + E
            | numero
            | numerodecimal
            | id
            | ToTerm("(") + E + ToTerm(")");*/


            #region Gramatica
            usando.Rule = usando + reservadausando + librerias + reservadapuntocoma
                | reservadausando + librerias + reservadapuntocoma
                | reservadausando + librerias + reservadapuntocoma + spacename
                | usando + reservadausando + librerias + reservadapuntocoma + spacename;


            librerias.Rule = reservadasistema;

            spacename.Rule = reservadaspacename + librerias + reservadallaveabrir + clase + reservadallavecerrar |
                reservadaspacename + librerias + reservadallaveabrir + Empty + reservadallavecerrar;

            clase.Rule = acceso + reservadaclase + librerias + reservadallaveabrir + voidmain + reservadallavecerrar
                | acceso + reservadaclase + librerias + reservadallaveabrir + Empty + reservadallavecerrar;

            voidmain.Rule = acceso + reservadaestatico + reservadavacio + reservadaprincipal + reservadaparentesisabrir + reservadacadena + reservadacorcheteabrir + reservadacorchetecerrar + reservadaargumento + reservadaparentesiscerrar + reservadallaveabrir + reservadallavecerrar
                | acceso + reservadaestatico + reservadavacio + reservadaprincipal + reservadaparentesisabrir + reservadacadena + reservadacorcheteabrir + reservadacorchetecerrar + reservadaargumento + reservadaparentesiscerrar + reservadallaveabrir + dentrovoid + reservadallavecerrar
                | acceso + reservadaestatico + reservadavacio + reservadaprincipal + reservadaparentesisabrir + reservadacadena + reservadacorcheteabrir + reservadacorchetecerrar + reservadaargumento + reservadaparentesiscerrar + reservadallaveabrir + Empty + reservadallavecerrar;

            dentrovoid.Rule =
                  dentrovoid + asignacion + dentrovoid
                | dentrovoid + declaracion + dentrovoid 
                | dentrovoid + condicional + dentrovoid
                | dentrovoid + para + dentrovoid
                | dentrovoid + mientras + dentrovoid
                | dentrovoid + hacer + dentrovoid
                | dentrovoid + interruptor + dentrovoid
                | dentrovoid + impresion +dentrovoid
                | dentrovoid + impresionCompleja + dentrovoid
                | dentrovoid + asignacionCadena + dentrovoid
                | asignacion
                | declaracion
                | condicional
                | para
                | mientras
                | hacer
                | interruptor
                | impresion
                | impresionCompleja
                | asignacionCadena
                | Empty;

            declaracion.Rule = reservadaentero + id + reservadaigual + numero + reservadapuntocoma
                | reservadalargo + id + reservadaigual + numero + reservadapuntocoma
                | reservadaflotante + id + reservadaigual + numerodecimal + reservadapuntocoma
                | reservadadoble + id + reservadaigual + numerodecimal + reservadapuntocoma
                | reservadabooleano + id + reservadaigual + reservadaverdadero + reservadapuntocoma
                | reservadabooleano + id + reservadaigual + reservadafalso + reservadapuntocoma
                | reservadacadena + id + reservadaigual + cualquier + reservadapuntocoma
                | reservadacaracter + id + reservadaigual + cualquiercar + reservadapuntocoma
                | reservadavariable + id + reservadaigual + numero + reservadapuntocoma
                | reservadavariable + id + reservadaigual + numero + reservadapuntocoma
                | reservadavariable + id + reservadaigual + numerodecimal + reservadapuntocoma
                | reservadavariable + id + reservadaigual + numerodecimal + reservadapuntocoma
                | reservadavariable + id + reservadaigual + reservadaverdadero + reservadapuntocoma
                | reservadavariable + id + reservadaigual + reservadafalso + reservadapuntocoma
                | reservadavariable + id + reservadaigual + cualquier + reservadapuntocoma
                | reservadavariable + id + reservadaigual + cualquiercar + reservadapuntocoma
                | reservadavariable + id + reservadaigual + reservadaain + reservadapuntocoma
                | reservadaentero + id + reservadaigual + reservadaain + reservadapuntocoma
                | reservadalargo + id + reservadaigual + reservadaain + reservadapuntocoma
                | reservadadoble + id + reservadaigual + reservadaain + reservadapuntocoma
                | reservadaflotante + id + reservadaigual + reservadaain + reservadapuntocoma
                | reservadacadena + id + reservadaigual + reservadaain + reservadapuntocoma
                | reservadacaracter + id + reservadaigual + reservadaain + reservadapuntocoma
                | reservadaentero + id + reservadapuntocoma
                | reservadalargo + id + reservadapuntocoma
                | reservadaflotante + id + reservadapuntocoma
                | reservadadoble + id + reservadapuntocoma
                | reservadabooleano + id + reservadapuntocoma
                | reservadacadena + id + reservadapuntocoma
                | reservadacaracter + id + reservadapuntocoma
                | reservadavariable + id + reservadapuntocoma;

            condicional.Rule = condicionalsi
                |condicionalsi + condicionalsino;

            condicionalsi.Rule = reservadasi + reservadaparentesisabrir + id + operadores + id + reservadaparentesiscerrar + reservadallaveabrir + dentrovoid + reservadallavecerrar;

            condicionalsino.Rule = reservadasino + reservadallaveabrir + dentrovoid + reservadallavecerrar;

            para.Rule = reservadapara + reservadaparentesisabrir + tipodedatonumerico + id + reservadaigual + numvar + reservadapuntocoma + id + operadores + numvar + reservadapuntocoma + id + operadoresincrementos + reservadaparentesiscerrar + reservadallaveabrir + Empty + reservadallavecerrar
                | reservadapara + reservadaparentesisabrir + tipodedatonumerico + id + reservadaigual + numvar + reservadapuntocoma + id + operadores + numvar + reservadapuntocoma + id + operadoresincrementos + reservadaparentesiscerrar + reservadallaveabrir + dentrovoid + reservadallavecerrar;

            mientras.Rule = reservadamientras + reservadaparentesisabrir + numvar + operadores + numvar + reservadaparentesiscerrar + reservadallaveabrir + Empty + reservadallavecerrar
                | reservadamientras + reservadaparentesisabrir + numvar + operadores + numvar + reservadaparentesiscerrar + reservadallaveabrir + dentrovoid + reservadallavecerrar;

            hacer.Rule = reservadahacer + reservadallaveabrir + Empty + reservadallavecerrar + reservadamientras + reservadaparentesisabrir + numvar + operadores + numvar + reservadaparentesiscerrar
                | reservadahacer + reservadallaveabrir + dentrovoid + reservadallavecerrar + reservadamientras + reservadaparentesisabrir + numvar + operadores + numvar + reservadaparentesiscerrar;

            interruptor.Rule = reservadainterruptor + reservadaparentesisabrir + numvar + reservadaparentesiscerrar + reservadallaveabrir + Empty + reservadallavecerrar
                | reservadainterruptor + reservadaparentesisabrir + numvar + reservadaparentesiscerrar + reservadallaveabrir + caso + reservadallavecerrar
                | reservadainterruptor + reservadaparentesisabrir + numvar + reservadaparentesiscerrar + reservadallaveabrir + pordefecto + reservadallavecerrar
                | reservadainterruptor + reservadaparentesisabrir + numvar + reservadaparentesiscerrar + reservadallaveabrir + caso + pordefecto + reservadallavecerrar
                | reservadainterruptor + reservadaparentesisabrir + numvar + reservadaparentesiscerrar + reservadallaveabrir + pordefecto + caso + reservadallavecerrar
                | reservadainterruptor + reservadaparentesisabrir + numvar + reservadaparentesiscerrar + reservadallaveabrir + caso + pordefecto + caso + reservadallavecerrar;

            pordefecto.Rule = reservadapordefecto + numero + reservadadospuntos + Empty + reservadaromper
                | reservadapordefecto + numerodecimal + reservadadospuntos + Empty + reservadaromper
                | reservadapordefecto + cualquier + reservadadospuntos + Empty + reservadaromper

                | reservadapordefecto + numero + reservadadospuntos + dentrovoid + reservadaromper
                | reservadapordefecto + numerodecimal + reservadadospuntos + dentrovoid + reservadaromper
                | reservadapordefecto + cualquier + reservadadospuntos + dentrovoid + reservadaromper;

            caso.Rule = reservadacaso + numero + reservadadospuntos + Empty + reservadaromper
                | reservadacaso + numerodecimal + reservadadospuntos + Empty + reservadaromper
                | reservadacaso + cualquier + reservadadospuntos + Empty + reservadaromper

                | reservadacaso + numero + reservadadospuntos + dentrovoid + reservadaromper
                | reservadacaso + numerodecimal + reservadadospuntos + dentrovoid + reservadaromper
                | reservadacaso + cualquier + reservadadospuntos + dentrovoid + reservadaromper


                |reservadacaso + numero + reservadadospuntos + Empty + reservadaromper + caso
                | reservadacaso + numerodecimal + reservadadospuntos + Empty + reservadaromper + caso
                | reservadacaso + cualquier + reservadadospuntos + Empty + reservadaromper + caso

                | reservadacaso + numero + reservadadospuntos + dentrovoid + reservadaromper + caso
                | reservadacaso + numerodecimal + reservadadospuntos + dentrovoid + reservadaromper + caso
                | reservadacaso + cualquier + reservadadospuntos + dentrovoid + reservadaromper + caso;

            operacion.Rule = operacion + reservadamas + operacion
                | operacion + reservadamenos + operacion
                | operacion + reservadapor + operacion
                | operacion + reservadaentre + operacion
                | id
                | numero
                | numerodecimal
                | reservadaparentesisabrir + operacion + reservadaparentesiscerrar
                | operacion + reservadaraiz + operacion
                | operacion + reservadapotencia + operacion;


            impresion.Rule = reservadaimprimir + reservadaparentesisabrir + operacion + reservadaparentesiscerrar + reservadapuntocoma
                |reservadaimprimir + reservadaparentesisabrir + cualquier + reservadaparentesiscerrar + reservadapuntocoma;

            impresionCompleja.Rule = reservadaimprimir + reservadaparentesisabrir + dentroImpresion + reservadaparentesiscerrar + reservadapuntocoma
                | reservadaimprimir + reservadaparentesisabrir + dentroImpresion + reservadaparentesiscerrar + reservadapuntocoma;

            dentroImpresion.Rule = cualquier + reservadamas + dentroImpresion
                | id + reservadamas + dentroImpresion
                | numero + reservadamas + dentroImpresion
                | cualquier
                | id
                | numero
                ;

            asignacion.Rule = reservadaas + id + reservadaigual + operacion + reservadapuntocoma
                | reservadaas + id + reservadaigual + numero + reservadapuntocoma;

            asignacionCadena.Rule = reservadaascad + id + reservadaigual + dentroAsignacionCadena + reservadapuntocoma;

            dentroAsignacionCadena.Rule = cualquier + reservadamas + dentroAsignacionCadena
                | id + reservadamas + dentroAsignacionCadena
                | cualquier
                | id;

            acceso.Rule = Empty
                | reservadapublico
                | reservadaprivado
                | reservadaprotegido
                | reservadadefecto;

            tipodevariable.Rule = reservadavariable
                | reservadaentero
                | reservadadoble
                | reservadaflotante
                | reservadalargo
                | reservadacadena
                | reservadabooleano
                | reservadacaracter;

            tipodedatonumerico.Rule = reservadaentero
                | reservadadoble
                | reservadaflotante
                | reservadalargo;

            operadores.Rule = reservadaigualigual
                 | reservadamayorque
                 | reservadadiferenteque
                 | reservadamenorque
                 | reservadamenorigualque
                 | reservadamayorigualque;

            numvar.Rule = numero
                | id;

            operadoresincrementos.Rule = reservadaincremento
                | reservadadecremento;

            operadoresincrementossinpara.Rule = id + reservadaincremento + reservadapuntocoma
                | id + reservadadecremento + reservadapuntocoma;

            cualquierdato.Rule = numero
                | numerodecimal
                | reservadafalso
                | reservadaverdadero
                | cualquiercar
                | cualquier;



            /*palabrasreservadas.ErrorRule = reservadaabstracto
                | reservadacomo
                | reservadaasincrono
                | reservadaespera
                | reservadachecado
                | reservadaconst;*/


            //de reservadamayorigualqueclaracion.Rule = declaracion + reservadaentero + id + reservadapuntocoma
            //    | reservadaentero + id + reservadapuntocoma
            //    | declaracion + reservadaentero + id + reservadaigual + numero + reservadapuntocoma
            //    | reservadaentero + id + reservadaigual + numero + reservadapuntocoma;
            #endregion

            #region Preferencias
            this.Root = raiz;
            #endregion
        }
    }
}
