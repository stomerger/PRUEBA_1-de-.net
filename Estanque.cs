using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaVehiculos
{
    class Estanque : VehiculoComponentes
    {
        private readonly double _capacidad;
        private double _litros;

        public Estanque(double capacidad)
        {
            _capacidad = capacidad;
        }

        public double Capacidad => _capacidad;

        public bool MitadCombustible()
        {
            return _litros > 10.5 && _litros <= 50.0;
        }

        public bool BajoCombustible()
        {
            return _litros <= 10.5;

        }
    }
}
