using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Laboratorio_en_Clase.Data.Model
{
    internal class consolas
    {
        public int ID { get; set; }
        public string nombre_consola { get; set; }
        public string compania { get; set; }
        public DateTime anio_lanzamiento { get; set; }
        public int generacion { get; set; }

        public consolas(int id, string Nombre, string Compania, DateTime Anio_lazamiento, int Generacion)
        {
            ID = id;
            nombre_consola = Nombre;
            compania = Compania;
            anio_lanzamiento = Anio_lazamiento;
            generacion = Generacion;
        }
        public consolas()
        {

        }
    }


}
