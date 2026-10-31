using System;
using System.Collections.Generic;
using System.Text;

namespace Aula07.SensorTemperatura
{
    internal class SensorTemperatura
    {
        public event EventHandler<double>? AlarmeDisparado;

        public void ChecarTemperatura(double temperaturaAtual)
        {
            Console.WriteLine($"[SENSOR] Medindo temperatura: {temperaturaAtual}°C...");
            Thread.Sleep(800); // Simula uma pequena leitura de hardware

            // Se passar do limite crítico de 80°C, o evento é acionado
            if (temperaturaAtual > 80.0)
            {
                OnAlarmeDisparado(temperaturaAtual);
            }
        }

        protected void OnAlarmeDisparado(double temp)
        {
            // O operador ?. garante que o evento só é chamado se houver inscritos
            // (evita NullReferenceException)
            AlarmeDisparado?.Invoke(this, temp);
        }
    }
}
