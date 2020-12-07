using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca.Modelo
{
    public class Usuario
    {

        private int UsuarioID;
        private string Nombre;
        private string ApePaterno;
        private string ApeMaterno;
        private int CiudadID;
        private int TipoUsuarioID;
        private bool Moroso;

        public Usuario()
        {

        }

        public Usuario(int usuarioID, string nombre, string apePaterno, string apeMaterno, int ciudadID, int tipoUsuarioID, bool moroso)
        {
            UsuarioID = usuarioID;
            Nombre = nombre;
            ApePaterno = apePaterno;
            ApeMaterno = apeMaterno;
            CiudadID = ciudadID;
            TipoUsuarioID = tipoUsuarioID;
            Moroso = moroso;
        }

        public int ID
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

        public string Nom
        { get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }
                
        public string Paterno
        {

            get
            {
                return ApePaterno;



            }
            set
            {
                ApePaterno = value;
            }
        }

        public string Materno
        {

            get
            {
                return ApeMaterno;

            }


            set
            {
                ApeMaterno = value;
            }

        }

        public int Ciudad
        {
            get
            {
                return CiudadID;
            }

            set
            {
                CiudadID = value;
            }
        }

        public int TipoUsuario
        {
            get
            {
                return TipoUsuarioID;
            }

            set
            {
                TipoUsuarioID = value;
            }

        }

        public bool Mora
        {
            get
            {
                return Moroso;

            }
            set
            {
                Moroso = value;
            }
        }

        public string NombreCompleto()
        {


            return Nombre + " " + ApePaterno + " " + ApeMaterno; 


        }

        public string TipoANombre()
        {

            return TipoUsuarioID == 1 ? "ESTUDIANTE" : TipoUsuarioID == 2 ? "MAESTRO" :TipoUsuarioID==3? "EXTERNO":" ";
         
        }













        }

        


    
}
