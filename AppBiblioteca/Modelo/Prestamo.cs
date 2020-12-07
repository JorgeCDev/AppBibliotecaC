using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca.Modelo
{
    public class Prestamo
    {
        private int PrestamoID;
        private int LibroID;
        private int UsuarioID;
        private DateTime fechaPrestamo;

        public Prestamo()
        {

        }
        public Prestamo(int prestamoID, int libroID, int usuarioID, DateTime fecha)
        {
            PrestamoID = prestamoID;
            LibroID = libroID;
            UsuarioID = usuarioID;
            this.fechaPrestamo = fecha;
        }

        public int Prestado
        {
            get
            {
                return PrestamoID;

            }

            set
            {
                PrestamoID = value;

            }

        }


        public int Libro
        {

            get
            {

                return LibroID;
            }
            set
            {
                LibroID = value;

            }


        }

        public int Usuario
        {
            get
            {
                return UsuarioID;
            }

            set
            {
                UsuarioID = value;
            }

        }

        public DateTime Fecha
        {
            get
            {
                return fechaPrestamo;
            }

            set
            {
                fechaPrestamo = value;
            }


        }





    }
}
