using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;



namespace Pcampeonato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lstbxLista.Items.Clear();
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            int[,] matInt = new int[4, 3];
            string texto = "";
            int totalFeitos = 0, totalRecebidos = 0;

            for (var j = 0; j < 4; j++)
            {
                int k = 0;

                var inputFeitos = Interaction.InputBox($"Gols feitos pelo time {j + 1}: ", "Entrada de dados");
                if (!int.TryParse(inputFeitos, out matInt[j, 0]))
                {
                    MessageBox.Show("Favor inserir um número inteiro");
                    j--;
                    continue;
                }

                totalFeitos += matInt[j, 0];

                var inputRecebidos = "";
                while (k == 0)
                {
                    inputRecebidos = Interaction.InputBox($"Gols recebidos pelo time {j + 1}: ", "Entrada de dados");
                    if (!int.TryParse(inputRecebidos, out matInt[j, 1]))
                    {
                        MessageBox.Show("Favor inserir um número inteiro");
                        continue;
                    }
                    else
                    {
                        k = 1;
                    }
                }
                totalRecebidos += matInt[j, 1];


                matInt[j, 2] = matInt[j, 0] - matInt[j, 1];
                texto = $"Time {j + 1} Gols feitos: {matInt[j, 0]}  Gols recebidos: {matInt[j, 1]}  Saldo de Gols: {matInt[j, 2]}";
                lstbxLista.Items.Add(texto);
            }

            lstbxLista.Items.Add("\n --------------------------------\n");
            lstbxLista.Items.Add($"Total gols feitos: {totalFeitos}\n");
            lstbxLista.Items.Add($"Total gols recebidos: {totalRecebidos}");

        }
    }
}

