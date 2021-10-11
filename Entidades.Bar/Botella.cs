using System;
using System.Text;

namespace Entidades.Botella
{
    public abstract class Botella
    {
        protected int capacidad;
        protected int contenido;
        protected string marca;
        protected double precio;


        #region Propiedades

        public abstract double Ganancia { get; }

        public double PorcentajeContenido
        {
            get
            {
                double porcentaje;
                porcentaje = (double)this.contenido / this.capacidad * 100;
                return (int)porcentaje;


                //return this.contenido;
            }
        }

        #endregion

        #region Constructores

        public Botella(string marca, double precio) : this(marca, precio,1000)
        {
            
        }

        public Botella(string marca, double precio,int capacidad)
        {
            this.marca = marca;
            this.precio = precio;
            this.capacidad = capacidad;
            this.contenido = capacidad;
        }


        #endregion

        #region Métodos
        protected abstract void ServirMedida();

        private static string ObtenerDatos(Botella b)
        {
            StringBuilder sb = new StringBuilder();

            if(b is not null)
            {
                sb.AppendFormat(" CAPACIDAD: {0}cc\r\n", b.capacidad.ToString());
                sb.AppendFormat("CONTENIDO: {0}%\r\n", b.PorcentajeContenido.ToString());
                sb.AppendFormat("MARCA: {0}\r\n", (String)b);//aca utilizo la conversion de string que me retorna la marca
                sb.AppendFormat("PRECIO: ${0}\r\n", b.precio.ToString());
                sb.AppendLine("---------------------");
                sb.AppendLine("");
            }
            return sb.ToString();
                       
        }

        #endregion
    
        #region Conversion 
      
        /// <summary>
        /// Retornara la marca de la botella que recibe como parametro
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator String(Botella a)
        {          
            return a.marca;
        }

        #endregion
                     
        #region Sobrecarga de operadores 
    
        public static bool operator ==(Botella a, Botella b)
        {
            bool retorno;
            retorno = false;

            if (a is not null && b is not null)
            {
                if (String.Compare(a.marca, b.marca) == 0 &&
                    a.capacidad == b.capacidad)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

       
        public static bool operator !=(Botella a, Botella b)
        {
            return !(a == b);
        }

        public static Botella operator --(Botella a)
        {          
            if(a is not null)
            {

             a.ServirMedida();
                           
            }
            return a;
        }
        #endregion

        #region Sobrescritura  
        public override bool Equals(object obj)
        {
            Botella a = obj as Botella;

            return a != null && this == a;
        }

        public override int GetHashCode()
        {
            return (marca,capacidad).GetHashCode();
        }

        public override string ToString()
        {

            return ObtenerDatos(this);
        }

        #endregion



    }
}
