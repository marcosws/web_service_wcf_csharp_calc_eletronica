using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wcf_CalculoEletronica_Cliente_Win
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void rbResistencia_CheckedChanged(object sender, EventArgs e)
        {
            gbResistencia.Enabled = false;
            gbCorrente.Enabled = true;
            gbTensao.Enabled = true;
        }

        private void rbCorrente_CheckedChanged(object sender, EventArgs e)
        {
            gbResistencia.Enabled = true;
            gbCorrente.Enabled = false;
            gbTensao.Enabled = true;
        }

        private void rbTensao_CheckedChanged(object sender, EventArgs e)
        {
            gbResistencia.Enabled = true;
            gbCorrente.Enabled = true;
            gbTensao.Enabled = false;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            ServiceReferenceCalc.CalculoEletronicaClient calc = new ServiceReferenceCalc.CalculoEletronicaClient();

            if (rbResistencia.Checked == true)
            {
                double tensao = 0;
                double corrente = 0;
                double resultado = 0;
                string UnidadeTensao = "V";
                string UnidadeCorrente = "A";
                try
                {
                    tensao = double.Parse(ValorTensao.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor de tensão que ser Numerico!");
                }

                try
                {
                    corrente = double.Parse(ValorCorrente.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor de corrente que ser Numerico!");
                }

                if (cbTensao.SelectedIndex == 0) // Micro Volt (µV)
                {
                    tensao = calc.ConverteMicroParaUnidade(tensao);
                    UnidadeTensao = "µV";
                }
                else if (cbTensao.SelectedIndex == 1) // Mili Volt (mV)
                {
                    tensao = calc.ConverteMiliParaUnidade(tensao);
                    UnidadeTensao = "mV";
                }

                if (cbCorrente.SelectedIndex == 0) // Micro Ampere (µA)
                {
                    corrente = calc.ConverteMicroParaUnidade(corrente);
                    UnidadeCorrente = "µA";
                }
                else if (cbCorrente.SelectedIndex == 1) // Mili Ampere (mA)
                {
                    corrente = calc.ConverteMiliParaUnidade(corrente);
                    UnidadeCorrente = "mA";
                }
     
                resultado = calc.Calcular(tensao: tensao, corrente: corrente, resistencia: 0);
                ResultadoTexto.Text += "Calculando a Resistência em Ohm (Ω)";
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += "Formula: Resistência (Ω) = Tensão (V) / Corrente (A)";
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += "Resultado : Ω " + resultado + " = V " + tensao + " / A " + corrente;
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += UnidadeTensao + " " + ValorTensao.Text;
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += UnidadeCorrente + " " + ValorCorrente.Text;
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += calc.FormataValorResistencia(resultado);
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += "===========================================================";
                ResultadoTexto.Text += System.Environment.NewLine;
            }
            else if (rbCorrente.Checked == true)
            {
                double tensao = 0;
                double resistencia = 0;
                double resultado = 0;
                string UnidadeTensao = "V";
                string UnidadeResistencia = "Ω";

                try
                {
                    tensao = double.Parse(ValorTensao.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor de tensão que ser Numerico!");
                }

                try
                {
                    resistencia = double.Parse(ValorResistencia.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor de resistência que ser Numerico!");
                }

                if (cbTensao.SelectedIndex == 0) // Micro Volt (µV)
                {
                    tensao = calc.ConverteMicroParaUnidade(tensao);
                    UnidadeTensao = "µV";
                }
                else if (cbTensao.SelectedIndex == 1) // Mili Volt (mV)
                {
                    tensao = calc.ConverteMiliParaUnidade(tensao);
                    UnidadeTensao = "mV";
                }

                if (cbResistencia.SelectedIndex == 0) // Micro Ohm (µΩ)
                {
                    resistencia = calc.ConverteMicroParaUnidade(resistencia);
                    UnidadeResistencia = "µΩ";
                }
                else if (cbResistencia.SelectedIndex == 1) // Mili Ohm (mΩ)
                {
                    resistencia = calc.ConverteMiliParaUnidade(resistencia);
                    UnidadeResistencia = "mΩ";
                }
                else if (cbResistencia.SelectedIndex == 3) // Kilo Ohm (kΩ)
                {
                    resistencia = calc.ConverteKiloParaUnidade(resistencia);
                    UnidadeResistencia = "kΩ";
                }
                else if (cbResistencia.SelectedIndex == 4) // Mega Ohm (MΩ)
                {
                    resistencia = calc.ConverteMegaParaUnidade(resistencia);
                    UnidadeResistencia = "MΩ";
                }

                resultado = calc.Calcular(tensao: tensao, corrente: 0, resistencia: resistencia);
                ResultadoTexto.Text += "Calculando a Corrente em Ampere (A)";
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += "Formula: Corrente (A) = Tensão (V) / Resistência (Ω)";
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += "Resultado : A " + resultado + " = V " + tensao + " / Ω " + resistencia;
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += UnidadeTensao + " " + ValorTensao.Text;
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += UnidadeResistencia + " " + ValorResistencia.Text;
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += calc.FormataValorCorrente(resultado);
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += "===========================================================";
                ResultadoTexto.Text += System.Environment.NewLine;
            }
            else if(rbTensao.Checked == true)
            {
                double corrente = 0;
                double resistencia = 0;
                double resultado = 0;
                string UnidadeCorrente = "A";
                string UnidadeResistencia = "Ω";

                try
                {
                    corrente = double.Parse(ValorCorrente.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor de corrente que ser Numerico!");
                }

                try
                {
                    resistencia = double.Parse(ValorResistencia.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor de resistência que ser Numerico!");
                }

                if (cbCorrente.SelectedIndex == 0) // Micro Ampere (µA)
                {
                    corrente = calc.ConverteMicroParaUnidade(corrente);
                    UnidadeCorrente = "µA";
                }
                else if (cbCorrente.SelectedIndex == 1) // Mili Ampere (mA)
                {
                    corrente = calc.ConverteMiliParaUnidade(corrente);
                    UnidadeCorrente = "mA";
                }

                if (cbResistencia.SelectedIndex == 0) // Micro Ohm (µΩ)
                {
                    resistencia = calc.ConverteMicroParaUnidade(resistencia);
                    UnidadeResistencia = "µΩ";
                }
                else if (cbResistencia.SelectedIndex == 1) // Mili Ohm (mΩ)
                {
                    resistencia = calc.ConverteMiliParaUnidade(resistencia);
                    UnidadeResistencia = "mΩ";
                }
                else if (cbResistencia.SelectedIndex == 3) // Kilo Ohm (kΩ)
                {
                    resistencia = calc.ConverteKiloParaUnidade(resistencia);
                    UnidadeResistencia = "kΩ";
                }
                else if (cbResistencia.SelectedIndex == 4) // Mega Ohm (MΩ)
                {
                    resistencia = calc.ConverteMegaParaUnidade(resistencia);
                    UnidadeResistencia = "MΩ";
                }

                resultado = calc.Calcular(tensao: 0, corrente: corrente, resistencia: resistencia);
                ResultadoTexto.Text += "Calculando a Tensão em Volt (V)";
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += "Formula: Tensão (V) = Resistência (Ω) * Corrente (A)";
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += "Resultado : V " + resultado + " = Ω " + resistencia + " * A " + corrente;
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += UnidadeResistencia + " " + ValorResistencia.Text;
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += UnidadeCorrente + " " + ValorCorrente.Text;
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += calc.FormataValorTensao(resultado);
                ResultadoTexto.Text += System.Environment.NewLine;
                ResultadoTexto.Text += "===========================================================";
                ResultadoTexto.Text += System.Environment.NewLine;

            }

            
        }

        private void frmCalculo_Load(object sender, EventArgs e)
        {
            cbResistencia.SelectedIndex = 2;
            cbCorrente.SelectedIndex = 2;
            cbTensao.SelectedIndex = 2;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ResultadoTexto.Clear();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
