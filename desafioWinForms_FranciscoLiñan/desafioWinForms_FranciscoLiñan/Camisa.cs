﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_FranciscoLiñan
{
    class Camisa : Prenda
    {
        public void SetTipo(bool tipo)
        {
            this._tipo_corta = tipo;
        }

        public void SetCalidad(bool calidad)
        {
            this._calidad_premium = calidad;
        }

        override public float Precio(float precio_base)
        {
            float precio_total = precio_base;

            // Si es de tipo manga corta disminuye el precio un 10%
            //
            if (this._tipo_corta)
            {
                precio_total -= precio_total * 0.1f;
            }

            // Si es una prenda premium, aumenta el precio un 30%
            //
            if (this._calidad_premium)
            {
                precio_total += precio_total * 0.3f;
            }

            return precio_total;
        }
    }
}
