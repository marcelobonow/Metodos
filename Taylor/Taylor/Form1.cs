using System;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Taylor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bCalculate_Click(object sender, EventArgs e)
        {
            var stepsString = tbEntrySteps.Text;
            var radToCalculate = tbEntryRad.Text;

            var steps = GetSteps(stepsString);
            var rads = GetRads(radToCalculate);

            var factorialResult = GetFactorial(steps).ToString();

            LogToFile(factorialResult, stepsString, radToCalculate);

            var message = "Resultado: ";
            var caption = "Resultado";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            message += "Esta no arquivo Taylor.txt, no desktop";
            message += "\nResultado do fatorial lento: " + factorial((uint)steps).ToString();
            MessageBox.Show(message, caption, buttons);
            if (steps > 0)
            {

            }

        }

        private void LogToFile(string result, string stepsString, string radToCalculate)
        {
            var textPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "Taylor.txt";
            if (!File.Exists(textPath))
            {
                var file = File.Create(textPath);
                file.Close();
            }

            File.WriteAllText(textPath, "Resultado fatorial de " + radToCalculate + " com " + stepsString + " passos: " + result.ToString());
        }

        private int GetSteps(string stepsInput)
        {
            var success = int.TryParse(stepsInput, out var steps);
            if (success)
            {
                return steps;
            }
            else
            {
                var message = "O valor que você inseriu para a quantidade passos é inválido. Tente novamente";
                var caption = "Valor de passos inválido";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);

                return 0;
            }
        }
        private decimal GetRads(string radsInput)
        {
            var success = decimal.TryParse(radsInput, out var steps);
            if (success)
            {
                return steps;
            }
            else
            {
                var message = "O valor que você inseriu para o ângulo é inválido. Tente novamente";
                var caption = "Valor do ângulo inválido";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);

                return 0;
            }
        }

        private decimal CalculateCosenoTaylor(int steps, decimal rad)
        {
            decimal currentValue;
            for (int i = 0; i <= steps; i++)
            {
                //currentValue += ((-1) ^ i) * ((rad ^ (2 * i)) / ( ;
            }
            return 0;
        }

        private BigInteger GetFactorial(BigInteger value)
        {
            BigInteger result = new BigInteger();
            Console.WriteLine("Tamanho: " + Marshal.SizeOf(result).ToString());
            return Recfact(1, value, Stopwatch.StartNew());
        }

        private BigInteger Recfact(BigInteger start, BigInteger n, Stopwatch stopwatch)
        {
            if (stopwatch.ElapsedMilliseconds > 10000)
            {
                var message = "Não foi calculado o fatorial pois estourou o tempo";
                var caption = "Stopwatch pop";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
                Close();
                return 0;
            }
            else
            {
                BigInteger i;
                if (n <= 16)
                {
                    BigInteger r = start;
                    for (i = start + 1; i < start + n; i++) r *= i;
                    return r;
                }
                i = n / 2;
                return Recfact(start, i, stopwatch) * Recfact(start + i, n - i, stopwatch);
            }
        }
    }
}
