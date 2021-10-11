using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botella
{
    public class Agua : Botella
    {
        public TipoAgua tipo;

        #region Constructores
        public Agua(string marca, double precio,TipoAgua tipo) : this(marca,precio,500,tipo)
        {

        }

        public Agua(string marca, double precio, int capacidad,TipoAgua tipo) : base(marca, precio, capacidad)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Propiedades
        public override double Ganancia
        {
            get
            {
                return precio + (precio * 0.25);
            }
        }

        #endregion

        #region Metodos
        
        protected override void ServirMedida()
        {
            this.contenido = 0;
        }

        public override string ToString()
        {

            return $"{base.ToString()} \r\n TIPO: {this.tipo}";
        }

        public override bool Equals(object obj)
        {
            bool retorno;
            retorno = false;

            if(obj is Agua)
            {
                retorno = (Agua)obj == this;
            }


            return retorno;
        }

        #endregion

        #region Sobrecarga de operadores

        
        public static bool operator ==(Agua a,Agua b)
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

        public static bool operator !=(Agua a,Agua b)
        {
            return !(a == b);
        }

        #endregion

    }
}
