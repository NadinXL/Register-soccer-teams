using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC1_Teoria.Models
{
    public class Jugador
    {
        public string? Equipo {get;set;}
        public int Temporadas {get;set;}
        public string? Nombre {get;set;}
        public string? Edad {get;set;}
        public string? Categoria {get;set;}
        
        public string? Genero {get;set;}

        public double CalcularCostoTotal()
        {
            double costoInscripcion = Temporadas * 300;
            double impuesto = costoInscripcion * 0.19;
            return costoInscripcion + impuesto;
        }
    }
}