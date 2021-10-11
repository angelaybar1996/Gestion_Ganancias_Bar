using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botella
{
    public class Cerveza : Botella
    {

        public int medida;
        public TipoCerveza tipo;

        #region Constructores
        public Cerveza(string marca, double precio,int capacidad,TipoCerveza tipo) : this(marca, precio,capacidad,tipo,capacidad*1/3)
        {
        }

        public Cerveza(string marca, double precio, int capacidad,TipoCerveza tipo,int medida) : base(marca, precio, capacidad)
        {
            this.tipo = tipo;
            this.medida = medida;
        }

        #endregion

        #region Propiedades
        public override double Ganancia
        {
            get
            {
                return precio + (precio *0.50);
            }
        }

        #endregion

        #region Metodos
        protected override void ServirMedida()
        {
            
            if(this.contenido> this.medida)
            {
                this.contenido -= this.medida;
            }
            else
            {
                this.contenido = 0;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\r\n TIPO: {this.tipo} \r\n MEDIDA: {this.medida}cc";
        }

        public override bool Equals(object obj)
        {
            bool retorno;
            retorno = false;

            if(obj is Cerveza)
            {
                retorno = (Cerveza)obj == this;
            }

            return retorno;
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(Cerveza a, Cerveza b)
        {
            bool retorno;
            retorno = false;

            if(a is not null && b is not null)
            {
                if(a==(Botella)b && a.tipo==b.tipo)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Cerveza a, Cerveza b)
        {
            return !(a == b);
        }
        #endregion
    }
}

