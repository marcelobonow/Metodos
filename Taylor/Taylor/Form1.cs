using System;
using System.Collections.Generic;
using Deveel.Math;
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

            if (steps > 0)
            {
                var taylorResult = CalculateCosenoTaylor(steps, rads);

                LogToFile(taylorResult.ToString(), stepsString, radToCalculate);

                tbResult.Text = taylorResult.ToString();
                tbExpectedResult.Text = Math.Cos(rads).ToString();

                //var message = "Resultado: ";
                //var caption = "Resultado";
                //MessageBoxButtons buttons = MessageBoxButtons.OK;

                //message += "Esta no arquivo Taylor.txt, no desktop";
                //MessageBox.Show(message, caption, buttons);
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

            File.WriteAllText(textPath, "Resultado da série de Taylor de " + radToCalculate + " com " + stepsString + " passos: " + result.ToString());
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
        private double GetRads(string radsInput)
        {
            var success = double.TryParse(radsInput, out var steps);
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

        private BigDecimal CalculateCosenoTaylor(int steps, double rad)
        {

            var mathContext = new MathContext(1024, RoundingMode.HalfEven);
            var currentValue = new BigDecimal(0, mathContext);
            var expoResult = new BigDecimal(0, mathContext);
            var radAsBigInt = new BigDecimal(rad, mathContext);

            var stopWatch = Stopwatch.StartNew();

            for (var i = 0; i <= steps; i++)
            {
                if (stopWatch.ElapsedMilliseconds < 10000)
                {
                    expoResult = radAsBigInt.Pow(2 * i);
                    currentValue = currentValue.Add((expoResult.Divide(GetFactorial(2 * i), mathContext).Multiply(Math.Pow(-1, i), mathContext)), mathContext);

                }
                else
                {
                    var message = "Não foi calculado o Coseno até o final, pois estourou o tempo, calculou até o passo: "
                        + i.ToString();
                    var caption = "Stopwatch pop";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                    break;
                }
            }
            return currentValue;
        }

        private BigInteger GetFactorial(BigInteger value)
        {
            BigInteger result = 0;
            return Recfact(1, value, Stopwatch.StartNew());
        }

        private BigInteger Recfact(BigInteger start, BigInteger n, Stopwatch stopwatch)
        {
            if (stopwatch.ElapsedMilliseconds > 1000)
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
