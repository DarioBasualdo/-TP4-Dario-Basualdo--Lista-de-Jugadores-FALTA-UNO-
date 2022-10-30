using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class ListadeJugadoresB
    {
        public DataTable DTb { get; set; } = new DataTable();
        public int ultimocodigob { get; set; } = new int();

        public ListadeJugadoresB() 
        {

            DTb.TableName = "JugadoresB";
            DTb.Columns.Add("Codigo" , typeof(int));
            DTb.Columns.Add("Nombre" , typeof(string));
            DTb.Columns.Add("Posicion" , typeof (string));

            LeerDTdeArchivo();

        }

        public void LeerDTdeArchivo()
        {
            if (System.IO.File.Exists("Listab.xml"))
            {
                DTb.Clear();
                DTb.ReadXml("Listab.xml");
            }

        }


        public void cargar_datosDT(jugador jugador)
        {

            ultimocodigob = DTb.Rows.Count;

            if (DTb.Rows.Count == 0)
            {
                DTb.Rows.Add();
                int Registronuevo = DTb.Rows.Count - 1;
                DTb.Rows[Registronuevo]["Codigo"] = ultimocodigob + 1;
                DTb.Rows[Registronuevo]["Nombre"] = jugador.Nombre;
                DTb.Rows[Registronuevo]["Posicion"] = jugador.Posicion;

                DTb.WriteXml("Listab.xml");
            }
            else
            {

                for (int A = 0; A < DTb.Rows.Count; A++)
                {
                    for (int i = 0; i < DTb.Rows.Count; i++)
                    {

                        if (Convert.ToInt32(DTb.Rows[i]["Codigo"]) == ultimocodigob)
                        {
                            ultimocodigob = Convert.ToInt32(DTb.Rows[i]["Codigo"]) + 1;

                        }
                    }
                }
                DTb.Rows.Add();
                int Registronuevo = DTb.Rows.Count - 1;
                DTb.Rows[Registronuevo]["Codigo"] = ultimocodigob;
                DTb.Rows[Registronuevo]["Nombre"] = jugador.Nombre;
                DTb.Rows[Registronuevo]["Posicion"] = jugador.Posicion;

                DTb.WriteXml("Listab.xml");

            }
        }
        public void borrar_datosDT(jugador jugador)
        {
            for (int i = 0; i < DTb.Rows.Count; i++)
            {
                if (Convert.ToInt32(DTb.Rows[i]["Codigo"]) == jugador.Codigo)
                {
                    DTb.Rows[i].Delete();

                    break;
                }

            }

            DTb.WriteXml("Listab.xml");


        }
        public void actualizar_datosDT(jugador jugador)
        {
            for (int i = 0; i < DTb.Rows.Count; i++)
            {
                if (Convert.ToInt32(DTb.Rows[i]["Codigo"]) == jugador.Codigo)
                {
                    DTb.Rows[i]["Nombre"] = jugador.Nombre;
                    DTb.Rows[i]["Posicion"] = jugador.Posicion;

                    break;
                }

            }

            DTb.WriteXml("Listab.xml");


        }

        public void borrar_todo(jugador jugador)
        {
            int n = DTb.Rows.Count - 1;

            do
            {
                if (DTb.Rows.Count >= 1)
                {
                    DTb.Rows.RemoveAt(n);
                    n--;
                }

            } while (DTb.Rows.Count > 0);


            DTb.WriteXml("Listab.xml");


        }


    }
}
