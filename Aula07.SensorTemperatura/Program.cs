using Aula07.SensorTemperatura;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sensor = new SensorTemperatura.SensorTemperatura();

            // Inscrevendo os consumidores no evento
            sensor.AlarmeDisparado += EnviarAlertaNoConsole;
            sensor.AlarmeDisparado += DesligarMaquinasEmergencia;

            sensor.ChecarTemperatura(25.0);
            sensor.ChecarTemperatura(60.5);
            sensor.ChecarTemperatura(85.3); // dispara o alarme
            sensor.ChecarTemperatura(92.0); // dispara o alarme
        }

        static void EnviarAlertaNoConsole(object? sender, double temperatura)
        {
            Console.WriteLine($"[CONSUMIDOR 1 - ALERTA] ⚠️ Temperatura crítica de {temperatura}°C detectada!");
        }

        static void DesligarMaquinasEmergencia(object? sender, double temperatura)
        {
            Console.WriteLine("[CONSUMIDOR 2 - SEGURANÇA] 🚨 Comando de emergência enviado: DESLIGANDO MÁQUINAS.");
        }
    }
}