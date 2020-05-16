using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaVehiculos
{
    enum TipoMezclador
    {
        CARBURADOR, INYECTOR
    }
    class Mezclador : VehiculoComponentes
    {
        private TipoMezclador _tipo;

        public Mezclador(TipoMezclador tipo)
        {
            _tipo = tipo;
        }

        public Mezclador(string tipo)
        {
            Tipo = tipo;
        }

        public string Tipo
        {
            get { return _tipo.ToString(); }
            set
            {
                bool resultado = Enum.TryParse(value, out _tipo);
                if (!resultado)
                    Console.WriteLine("No se pudo convertir convertir el tipo en un Mezclador");
            }
        }

    }
}
