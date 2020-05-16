using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaVehiculos
{
    abstract class VehiculoComponentes
    {
        private double _estado;
        
        protected VehiculoComponentes()
        {
            _estado = 100.0;
        }

        public double Estado
        { 
            get => _estado; 
            set => double.TryParse(value.ToString(),out _estado); 
        }

    }
}
