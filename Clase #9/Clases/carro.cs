using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase__9.Clases
{
    public  class carro
    {
        public string marca { get;}
        public int modelo { get;}
        public string color { get; set;}
        public string dueño { get; set;}
        private int encendido = 0;
        private int velocidad = 0;
        public int velmax { get; set;}
       
        public int Encender(int e)
        {
            encendido = e;
            return encendido;
        }
        public carro(string m, int mod , string col)
        {
            marca = m;
            modelo = mod;
            color = col;    
        }
      
        public int aceleracion()
        {
            
            velocidad += 15;
            return velocidad;
        }
    
    }

    
}//acciones que debemos hacer se llamas constructores (constructor)
