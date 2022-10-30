using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class ListadeJugadoresA
    {
        

        public DataTable DT { get; set; } = new DataTable();
        public int ultimocodigo { get; set; } = new int();

        

        public ListadeJugadoresA()
        {

            DT.TableName = "JugadoresA";
            DT.Columns.Add("Codigo", typeof(int));
            DT.Columns.Add("Nombre", typeof(string));
            DT.Columns.Add("Posicion", typeof(string));

            LeerDTdeArchivo();

            
        }

        public void LeerDTdeArchivo() {
            if (System.IO.File.Exists("Lista3.xml"))
            {
                DT.Clear();
                DT.ReadXml("Lista3.xml");
            }
        
        }


        public void cargar_datosDT(jugador jugador)
        {

            ultimocodigo = DT.Rows.Count;

            if (DT.Rows.Count == 0)
            {
                DT.Rows.Add();
                int Registronuevo = DT.Rows.Count - 1;
                DT.Rows[Registronuevo]["Codigo"] = ultimocodigo +1;
                DT.Rows[Registronuevo]["Nombre"] = jugador.Nombre;
                DT.Rows[Registronuevo]["Posicion"] = jugador.Posicion;

                DT.WriteXml("Lista3.xml");
            }
            else
            {

            for (int A = 0; A < DT.Rows.Count; A++)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {

                    if (Convert.ToInt32(DT.Rows[i]["Codigo"]) == ultimocodigo)
                    {
                        ultimocodigo = Convert.ToInt32(DT.Rows[i]["Codigo"]) + 1;

                    }
                }
            }
                DT.Rows.Add();
                int Registronuevo = DT.Rows.Count - 1;
                DT.Rows[Registronuevo]["Codigo"] = ultimocodigo;
                DT.Rows[Registronuevo]["Nombre"] = jugador.Nombre;
                DT.Rows[Registronuevo]["Posicion"] = jugador.Posicion;

                DT.WriteXml("Lista3.xml");

            }
        }
          
        public void borrar_datosDT(jugador jugador)
        {
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (Convert.ToInt32(DT.Rows[i]["Codigo"]) == jugador.Codigo)
                {
                    DT.Rows[i].Delete();

                    break;
                }
               
            }
            
            DT.WriteXml("Lista3.xml");


        }
        public void actualizar_datosDT(jugador jugador)
        {
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (Convert.ToInt32(DT.Rows[i]["Codigo"]) == jugador.Codigo)
                {
                    DT.Rows[i]["Nombre"] = jugador.Nombre;
                    DT.Rows[i]["Posicion"] = jugador.Posicion;

                    break;
                }

            }

            DT.WriteXml("Lista3.xml");


        }


        public void borrar_todo(jugador jugador)
        {   int n = DT.Rows.Count -1;

            do
            {
                if (DT.Rows.Count >= 1)
                {
                    DT.Rows.RemoveAt(n);
                    n--;
                }

            } while (DT.Rows.Count > 0); 

                 DT.WriteXml("Lista3.xml");


        }
    }
}
