using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Botella;

namespace Entidades.Establecimieto
{
    public sealed class Bar
    {
        private List<Entidades.Botella.Botella> botellas;
        private int capacidadMaximaBotellas;
        private string nombre;
        private double recaudacion;

        #region Propiedades

        public List<Botella.Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }


        public string MostrarBar
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("Nombre: {0}\r\n", this.nombre);
                sb.AppendFormat("Cantidad actual: {0}\r\n", this.Botellas.Count.ToString());
                sb.AppendFormat("Cantidad maxima: {0}\r\n", this.capacidadMaximaBotellas.ToString());
                sb.AppendFormat("Recaudación: {0}\r\n", this.recaudacion);

                return sb.ToString();
            }
        }




        #endregion

        #region Constructores

        public Bar()
        {
            this.botellas = new List<Botella.Botella>();
            this.capacidadMaximaBotellas = 5;
            this.nombre = "Sin nombre";
        }

        public Bar(int capacidad):this()
        {
            this.capacidadMaximaBotellas = capacidad;
        }

        public Bar(int capacidad,string nombre):this(capacidad)
        {          
            this.nombre = nombre;
        }

        #endregion

        #region Metodos

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.MostrarBar);
            foreach (Botella.Botella item in this.Botellas)
            {
                sb.AppendLine(item.ToString());
            }
           
            return sb.ToString();
        }

        public void OrdenarBotellas(Ordenamiento o)
        {
            if(o==Ordenamiento.Ganancia)
            {
                this.botellas.Sort(OrdenarPorGanancia);
            }

            if(o==Ordenamiento.Marca)
            {
                this.botellas.Sort(OrdenarPorMarca);
            }

            if(o==Ordenamiento.PorcentajeContenido)
            {
                this.botellas.Sort(OrdernarPorContenido);
            }
        }

        private static int OrdernarPorContenido(Botella.Botella a,Botella.Botella b)
        {
            int retorno;
            retorno = 0;
            
            if(a is not null && b is not null)
            {
                if(a.PorcentajeContenido >b.PorcentajeContenido)
                {
                    retorno = 1;
                }

                if(a.PorcentajeContenido < b.PorcentajeContenido)
                {
                    retorno = -1;
                }
                
            }

            return retorno;
        }

        private int OrdenarPorGanancia(Botella.Botella a, Botella.Botella b)
        {
            int retorno;
            retorno = 0;

            if (a is not null && b is not null)
            {
                if (a.Ganancia > b.Ganancia)
                {
                    retorno = 1;
                }

                if (a.Ganancia < b.Ganancia)
                {
                    retorno = -1;
                }

            }

            return retorno;
        }

        private static int OrdenarPorMarca(Botella.Botella a, Botella.Botella b)
        {
            return ((string)a).CompareTo((string)b);
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Retorna la recaudacion del bar recibido por parametro
        /// </summary>
        /// <param name="b"></param>
        public static explicit operator Double (Bar b)
        {
            return b.recaudacion;
        }

        public static bool operator ==(Bar a,Botella.Botella b)
        {
            bool retorno;
            retorno = false;

            if(a is not null && b is not null)
            {
                foreach (Botella.Botella item in a.Botellas)
                {
                    if(b == item)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Bar a,Botella.Botella b)
        {
            return !(a == b);
        }

        public static Bar operator +(Bar a, double g)
        {
            if(a is not null)
            {
                a.recaudacion += g;
            }

            return a;
        }

        public static Bar operator + (Bar a,Botella.Botella b)
        {
            if(a.botellas.Count<a.capacidadMaximaBotellas)
            {
                if(!(a==b))
                {
                    a.botellas.Add(b);
                }
            }
            return a;
        }

        public static Bar operator - (Bar a,Botella.Botella b)
        {
            if(a is not null && b is not null)
            {
                if(a==b)
                {
                    b--;
                    a += b.Ganancia;
                    if(b.PorcentajeContenido==0)
                    {
                        a.Botellas.Remove(b);
                    }
                }
            }
            return a;
        }


        #endregion
    }
}
