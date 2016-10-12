using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra3EduardoMontes
{
    //Eduardo Montes de Oca Yglesias
    class CamelCase
    {
        //metodo calculate que retornara un int y resive por parametro un String
        public int calculate(String palabra) { 
            //integer que retornara la cantidad de palabras que hay en una frase
            int cantidadPalabras = 0;
            //for que recorera la frase o palabra que sera digitado por el usuario sin importar su longitud  
            for (int i = 0; i < palabra.Length; i++)
            {
                //condicion que detectara si hay mayusculas y que aumente la variable cantidadPalabras 
                if (char.IsUpper(palabra[i]))
                {
                    cantidadPalabras++;
                }
            }
            //condicion que detectara si hay minusculas y que aumente la variable cantidadPalabras
            //va fuera del for porque si no hagarraria toda las letras que esten en minuscula aumentando considerablemente cantidadPalabras y eso no es lo que queremos
            if (char.IsLower(palabra[0]))
            {
                cantidadPalabras++;
            }
            //retorne la cantidad de palabras ingresadas
            return cantidadPalabras;
        }

    }
}
