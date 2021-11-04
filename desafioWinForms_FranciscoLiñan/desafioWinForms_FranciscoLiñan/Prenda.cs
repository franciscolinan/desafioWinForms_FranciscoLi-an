using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_FranciscoLiñan
{
    abstract class Prenda
    {
        protected bool _tipo_corta;
        protected bool _calidad_premium;

        public abstract float Precio(float precio_base);
    }
}
