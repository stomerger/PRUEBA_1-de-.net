using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaVehiculos
{
    class Automovil : Vehiculo
    {
        private string _marca;
        private int _año;
        private int _kilometraje;

        public string Marca => _marca;

        public int Año => _año;

        public int Kilometraje => _kilometraje;

        public Automovil(string marca, int año, int kilometraje,int idMotor, TipoMotor tipoMotor, int cilindrada,
                        int numRuedas, TipoRecubrimiento tipoRecubrimiento, int minDurometro, int maxDurometro,
                        TipoMezclador tipoMezclador, double capacidad) :
                        base(marca, año, kilometraje, idMotor, tipoMotor, cilindrada, numRuedas, tipoRecubrimiento,
                        minDurometro, maxDurometro, tipoMezclador, capacidad)
        {

            this._marca = marca;
            this._año = año;
            this._kilometraje = kilometraje;
        }

        
    }
}
