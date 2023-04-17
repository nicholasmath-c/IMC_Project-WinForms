using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_Project
{
    public partial class CalculadoraIMC : Form
    {
        public CalculadoraIMC()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //----------BOTÃO DE CÁLCULO----------
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //--------------VALIDAÇÕES--------------

            //Validações campo: ALTURA
            if (txtAltura.Text == " ,")
            {
                MessageBox.Show("Informe a sua altura");
                return;
            }
            string primeiroDigitoAltura = txtAltura.Text.Substring(0, 1);
            if (!float.TryParse(primeiroDigitoAltura, out float result))
            {
                MessageBox.Show("Insira um valor válido na altura");
                return;
            }

            //Validações campo: PESO
            if (txtPeso.Text == "  ,")
            {
                MessageBox.Show("Informe o seu peso");
                return;
            }
            string primeiroDigitoPeso = txtPeso.Text.Substring(0, 1);
            string segundoDigitoPeso = txtPeso.Text.Substring(1, 1);
            if (!float.TryParse(primeiroDigitoPeso, out float result1) || !float.TryParse(segundoDigitoPeso, out float result2))
            {
                MessageBox.Show("Insira um valor válido no peso");
                return;
            }

            //Validações campo: IDADE
            if (numIdade.Value == 0)
            {
                MessageBox.Show("Informe a sua idade");
                return;
            }
            if(numIdade.Value < 5)
            {
                MessageBox.Show("Nossa calculadora de IMC só possui precisão a partir dos 5 anos de idade, por favor, insira uma idade de 5 ou mais");
                return;
            }

            //Validações campo: GENERO
            if(!rdbMasculino.Checked && !rdbFeminino.Checked)
            {
                MessageBox.Show("Informe o seu gênero");
                return;
            }

            //---------------ATRIBUINDO VALORES---------------
            float.TryParse(txtAltura.Text, out float altura);
            float.TryParse(txtPeso.Text, out float peso);
            int idade = Convert.ToInt32(numIdade.Value);
            char genero = rdbMasculino.Checked ? 'm' : 'f';
            string faixa_etaria = idade <= 12 ? "crianca" : idade > 12 && idade <= 17 ? "adolescente" : idade >= 18 && idade < 65 ? "adulto" : "idoso";
            float imc = CalcularIMC(altura, peso);
            float diferencaPeso = 0f;
            bool dica = false;

            //---------------DEFININDO A CLASSIFICAÇÃO-------------
            CalculoClassificacao calculoClassificacao = new CalculoClassificacao();
            string classificacao = string.Empty;

            switch (faixa_etaria)
            {
                case "crianca":
                    {
                        classificacao = calculoClassificacao.Crianca(imc, idade, genero);
                        diferencaPeso = calculoClassificacao.CriancaDiferencaPesoIdeal(imc,altura,peso,genero);
                        dica = true;
                        break;
                    }
                case "adolescente":
                    {
                        classificacao = calculoClassificacao.Adolescente(imc, idade, genero);
                        diferencaPeso = calculoClassificacao.AdolescenteDiferencaPesoIdeal(imc, altura, peso, genero);
                        dica = true;
                        break;
                    }
                case "adulto":
                    {
                        classificacao = calculoClassificacao.Adulto(imc);
                        diferencaPeso = calculoClassificacao.AdultoDiferencaPesoIdeal(imc, altura, peso);
                        dica = true;
                        break;
                    }
                case "idoso":
                    {
                        classificacao = calculoClassificacao.Idoso(imc);
                        diferencaPeso = calculoClassificacao.IdosoDiferencaPesoIdeal(imc, altura, peso);
                        dica = true;
                        break;
                    }
            }

            //EXBINDO RESULTADOS
            txtIMC.Text = imc.ToString("F");
            txtClassificacao.Text = classificacao;
            if (dica)
            {
                lblDica.Visible = true;
                txtDica.Text = "Para chegar no peso ideal para você, precisa de " + diferencaPeso.ToString("F") + "Kg";
                txtDica.Visible = true;
                dica = false;
            }
            else
            {
                lblDica.Visible = false;
                txtDica.Visible = false;
            }
        }

        //----------BOTÃO DE LIMPAR CAMPOS----------
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //----------FUNÇÕES----------
        public float CalcularIMC(float altura, float peso)
        {
            float imc = peso / (altura * altura);
            return imc;
        }

        class CalculoClassificacao
        {
            public string Crianca(float imc, int idade, char genero)
            {
                string[] listaClassificacoes = { "Desnutrição Grave", "Desnutrição Aguda", "Normal", "Sobrepeso", "Obesidade" };
                string classificacaoFinal = string.Empty;

                if(genero == 'm')
                {
                    switch (idade)
                    {
                        case 5: classificacaoFinal = imc < 12.1f ? listaClassificacoes[0] : imc >= 12.1f && imc < 13f ? listaClassificacoes[1] : imc >= 13f && imc < 16.7f ? listaClassificacoes[2] : imc >= 16.7f && imc < 18.4f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 6: classificacaoFinal = imc < 12.1f ? listaClassificacoes[0] : imc >= 12.1f && imc < 13f ? listaClassificacoes[1] : imc >= 13f && imc < 16.9f ? listaClassificacoes[2] : imc >= 16.9f && imc < 18.6f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 7: classificacaoFinal = imc < 12.3f ? listaClassificacoes[0] : imc >= 12.3f && imc < 13.2f ? listaClassificacoes[1] : imc >= 13.2f && imc < 17.1f ? listaClassificacoes[2] : imc >= 17.1f && imc < 19.1f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 8: classificacaoFinal = imc < 12.4f ? listaClassificacoes[0] : imc >= 12.4f && imc < 13.3f ? listaClassificacoes[1] : imc >= 13.3f && imc < 17.5f ? listaClassificacoes[2] : imc >= 17.5f && imc < 19.8f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 9: classificacaoFinal = imc < 12.6f ? listaClassificacoes[0] : imc >= 12.6f && imc < 13.5f ? listaClassificacoes[1] : imc >= 13.5f && imc < 18f ? listaClassificacoes[2] : imc >= 18f && imc < 20.6f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 10: classificacaoFinal = imc < 12.8f ? listaClassificacoes[0] : imc >= 12.8f && imc < 13.7f ? listaClassificacoes[1] : imc >= 13.7f && imc < 18.6f ? listaClassificacoes[2] : imc >= 18.6f && imc < 21.5f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 11: classificacaoFinal = imc < 13.1f ? listaClassificacoes[0] : imc >= 13.1f && imc < 14.1f ? listaClassificacoes[1] : imc >= 14.1f && imc < 19.3f ? listaClassificacoes[2] : imc >= 19.3f && imc < 22.6f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 12: classificacaoFinal = imc < 13.4f ? listaClassificacoes[0] : imc >= 13.4f && imc < 14.5f ? listaClassificacoes[1] : imc >= 14.5f && imc < 20f ? listaClassificacoes[2] : imc >= 20f && imc < 23.7f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                    }
                }
                else
                {
                    switch (idade)
                    {
                        case 5: classificacaoFinal = imc < 11.8f ? listaClassificacoes[0] : imc >= 11.8f && imc < 12.7f ? listaClassificacoes[1] : imc >= 12.7f && imc < 17f ? listaClassificacoes[2] : imc >= 17f && imc < 19f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 6: classificacaoFinal = imc < 11.7f ? listaClassificacoes[0] : imc >= 11.7f && imc < 12.7f ? listaClassificacoes[1] : imc >= 12.7f && imc < 17.1f ? listaClassificacoes[2] : imc >= 17.1f && imc < 19.2f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 7: classificacaoFinal = imc < 11.8f ? listaClassificacoes[0] : imc >= 11.8f && imc < 12.7f ? listaClassificacoes[1] : imc >= 12.7f && imc < 17.4f ? listaClassificacoes[2] : imc >= 17.4f && imc < 19.9f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 8: classificacaoFinal = imc < 11.9f ? listaClassificacoes[0] : imc >= 11.9f && imc < 12.9f ? listaClassificacoes[1] : imc >= 12.9f && imc < 17.7f ? listaClassificacoes[2] : imc >= 17.7f && imc < 20.7f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 9: classificacaoFinal = imc < 12.1f ? listaClassificacoes[0] : imc >= 12.1f && imc < 13.1f ? listaClassificacoes[1] : imc >= 13.1f && imc < 18.4f ? listaClassificacoes[2] : imc >= 18.4f && imc < 21.6f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 10: classificacaoFinal = imc < 12.4f ? listaClassificacoes[0] : imc >= 12.4f && imc < 13.5f ? listaClassificacoes[1] : imc >= 13.5f && imc < 19.1f ? listaClassificacoes[2] : imc >= 19.1f && imc < 22.7f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 11: classificacaoFinal = imc < 12.7f ? listaClassificacoes[0] : imc >= 12.7f && imc < 13.9f ? listaClassificacoes[1] : imc >= 13.9f && imc < 20f ? listaClassificacoes[2] : imc >= 20f && imc < 23.8f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 12: classificacaoFinal = imc < 13.2f ? listaClassificacoes[0] : imc >= 13.2f && imc < 14.4f ? listaClassificacoes[1] : imc >= 14.4f && imc < 20.9f ? listaClassificacoes[2] : imc >= 20.9f && imc < 25.1f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                    }
                }

                return classificacaoFinal;
            }

            public float CriancaDiferencaPesoIdeal(float imc, float altura, float peso, char genero)
            {
                float imcIdeal = 0f;
                float pesoIdeal = 0f;
                float diferencaPeso = 0f;
                

                if(genero == 'm')
                {
                    imcIdeal = 16.5f;
                    pesoIdeal = imcIdeal * (altura * altura);
                    diferencaPeso = pesoIdeal - peso;
                }
                else
                {
                    imcIdeal = 16.8f;
                    pesoIdeal = imcIdeal * (altura * altura);
                    diferencaPeso = pesoIdeal - peso;
                }

                return diferencaPeso;
            }

            public string Adolescente(float imc, int idade, char genero)
            {
                string[] listaClassificacoes = { "Desnutrição Grave", "Desnutrição Aguda", "Normal", "Sobrepeso", "Obesidade" };
                string classificacaoFinal = string.Empty;

                if(genero == 'm')
                {
                    switch (idade)
                    {
                        case 13: classificacaoFinal = imc < 13.8f ? listaClassificacoes[0] : imc >= 13.8f && imc < 14.9f ? listaClassificacoes[1] : imc >= 14.9f && imc < 20.9f ? listaClassificacoes[2] : imc >= 20.9f && imc < 24.9f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 14: classificacaoFinal = imc < 14.3f ? listaClassificacoes[0] : imc >= 14.3f && imc < 15.5f ? listaClassificacoes[1] : imc >= 15.5f && imc < 21.9f ? listaClassificacoes[2] : imc >= 21.9f && imc < 26f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 15: classificacaoFinal = imc < 14.7f ? listaClassificacoes[0] : imc >= 14.7f && imc < 16f ? listaClassificacoes[1] : imc >= 16f && imc < 22.8f ? listaClassificacoes[2] : imc >= 22.8f && imc < 27.1f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 16: classificacaoFinal = imc < 15.1f ? listaClassificacoes[0] : imc >= 15.1f && imc < 16.5f ? listaClassificacoes[1] : imc >= 16.5f && imc < 23.6f ? listaClassificacoes[2] : imc >= 23.6f && imc < 28f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 17: classificacaoFinal = imc < 15.4f ? listaClassificacoes[0] : imc >= 15.4f && imc < 16.9f ? listaClassificacoes[1] : imc >= 16.9f && imc < 24.4f ? listaClassificacoes[2] : imc >= 24.4f && imc < 28.7f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                    }
                }
                else
                {
                    switch (idade)
                    {
                        case 13: classificacaoFinal = imc < 13.6f ? listaClassificacoes[0] : imc >= 13.6f && imc < 14.9f ? listaClassificacoes[1] : imc >= 14.9f && imc < 21.9 ? listaClassificacoes[2] : imc >= 21.9 && imc < 26.3f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 14: classificacaoFinal = imc < 14f ? listaClassificacoes[0] : imc >= 14f && imc < 15.4f ? listaClassificacoes[1] : imc >= 15.4f && imc < 22.8 ? listaClassificacoes[2] : imc >= 22.8 && imc < 27.4f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 15: classificacaoFinal = imc < 14.4f ? listaClassificacoes[0] : imc >= 14.4f && imc < 15.9f ? listaClassificacoes[1] : imc >= 15.9f && imc < 23.6f ? listaClassificacoes[2] : imc >= 23.6f && imc < 28.3f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 16: classificacaoFinal = imc < 14.6f ? listaClassificacoes[0] : imc >= 14.6f && imc < 16.2f ? listaClassificacoes[1] : imc >= 16.2f && imc < 24.2f ? listaClassificacoes[2] : imc >= 24.2f && imc < 28.9f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                        case 17: classificacaoFinal = imc < 14.7f ? listaClassificacoes[0] : imc >= 14.7f && imc < 16.4f ? listaClassificacoes[1] : imc >= 16.4f && imc < 24.6f ? listaClassificacoes[2] : imc >= 24.6f && imc < 29.5f ? listaClassificacoes[3] : listaClassificacoes[4]; break;
                    }
                }

                return classificacaoFinal;
            }

            public float AdolescenteDiferencaPesoIdeal(float imc, float altura, float peso, char genero)
            {
                float imcIdeal = 0f;
                float pesoIdeal = 0f;
                float diferencaPeso = 0f;


                if (genero == 'm')
                {
                    imcIdeal = 19.5f;
                    pesoIdeal = imcIdeal * (altura * altura);
                    diferencaPeso = pesoIdeal - peso;
                }
                else
                {
                    imcIdeal = 19.75f;
                    pesoIdeal = imcIdeal * (altura * altura);
                    diferencaPeso = pesoIdeal - peso;
                }

                return diferencaPeso;
            }

            public string Adulto(float imc)
            {
                string[] listaClassificacoes = { "Baixo Peso", "Peso Normal", "Sobrepeso", "Obesidade Grau I", "Obesidade Grau II", "Obesidade Grau III" };
               
                string classificacaoFinal = imc < 18.5f ? listaClassificacoes[0] : imc >= 18.5 && imc < 25 ? listaClassificacoes[1] : imc >= 25 && imc < 30 ? listaClassificacoes[2] : imc >= 30 && imc < 35 ? listaClassificacoes[3] : imc >= 35 && imc < 40 ? listaClassificacoes[4] : listaClassificacoes[5];

                return classificacaoFinal;
            }

            public float AdultoDiferencaPesoIdeal(float imc, float altura, float peso)
            {
                float imcIdeal = 0f;
                float pesoIdeal = 0f;
                float diferencaPeso = 0f;

                imcIdeal = 21.75f;
                pesoIdeal = imcIdeal * (altura * altura);
                diferencaPeso = pesoIdeal - peso;

                return diferencaPeso;
            }

            public string Idoso(float imc)
            {
                string[] listaClassificacoes = { "Baixo Peso", "Peso Noramal", "Sobrepeso", "Obesidade" };

                string classificacaoFinal = imc < 23 ? listaClassificacoes[0] : imc >= 23 && imc < 28 ? listaClassificacoes[1] : imc >= 28 && imc < 30 ? listaClassificacoes[2] : listaClassificacoes[3];
                
                return classificacaoFinal;
            }

            public float IdosoDiferencaPesoIdeal(float imc, float altura, float peso)
            {
                float imcIdeal = 0f;
                float pesoIdeal = 0f;
                float diferencaPeso = 0f;

                imcIdeal = 25.5f;
                pesoIdeal = imcIdeal * (altura * altura);
                diferencaPeso = pesoIdeal - peso;

                return diferencaPeso;
            }
        }

        public void LimparCampos()
        {
            foreach(var item in Controls)
            {
                if(item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = string.Empty;
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
                if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
                
                txtPeso.Mask = "00.00";
                txtIMC.Text = "0";
                txtClassificacao.Text = "Nenhuma";
                lblDica.Visible = false;
                txtDica.Visible = false;
                txtDica.Text = "Para chegar no peso ideal para você, é preciso";
            }
        }

        //FRONT-END
        private void txtAltura_Enter(object sender, EventArgs e)
        {
            if(txtAltura.Text == "Metros")
            {
                txtAltura.Text = "";
                txtAltura.ForeColor = Color.FromArgb(15,15,15);
            }
        }
        private void txtAltura_Leave(object sender, EventArgs e)
        {
            if (txtAltura.Text != "Metros")
            {
                txtAltura.Text = "Metros";
                txtAltura.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                int digitCount = txtPeso.Text.Replace(txtPeso.PromptChar.ToString(), "").Length;

                if(digitCount >= 5)
                {
                    txtPeso.Mask = "000.00";
                    txtPeso.Select(txtPeso.Text.Length, 0);
                }
            }
        }
        private void txtPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                string txt = txtPeso.Text.Replace(txtPeso.PromptChar.ToString(), "");

                txtPeso.Mask = "00.00";
                txtPeso.Text = txt;
            }
        }
        private void numIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //IGNORE
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void numIdade_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void lblIMC_Click(object sender, EventArgs e)
        {

        }
    }
}
