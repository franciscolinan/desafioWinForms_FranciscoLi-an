using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_FranciscoLiñan
{
    static class Utiles
    {
        public static bool ValidarCampo(String dato, String tipo)
        {
            switch (tipo)
            {
                case "int":
                    try
                    {
                        Convert.ToInt32(dato);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                case "float":
                    try
                    {
                        Convert.ToSingle(dato);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                default:
                    return false;
            }
        }
    }
}
