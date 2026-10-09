using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ControleEstoqueWindowsForm.Validacoes
{
    public static class Formatador
    {
        public static void Aplicar(TextBox caixa, Func<string, string> formatar)
        {
            string formatado = formatar(caixa.Text);

            if (caixa.Text != formatado)
            {
                caixa.Text = formatado;
                caixa.SelectionStart = caixa.Text.Length;
            }
        }

        public static string SomenteNumeros(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "";
            }

            return Regex.Replace(texto, "[^0-9]", "");
        }
        public static string FormatarCpf(string texto)
        {
            string numeros = SomenteNumeros(texto);

            if (numeros.Length > 11)
            {
                numeros = numeros.Substring(0, 11);
            }

            if (numeros.Length <= 3)
            {
                return numeros;
            }
            else if (numeros.Length <= 6)
            {
                return numeros.Substring(0, 3) + "." + numeros.Substring(3);
            }
            else if (numeros.Length <= 9)
            {
                return numeros.Substring(0, 3) + "." + numeros.Substring(3, 3) + "." + numeros.Substring(6);
            }
            else
            {
                return numeros.Substring(0, 3) + "." + numeros.Substring(3, 3) + "." + numeros.Substring(6, 3) + "-" + numeros.Substring(9);
            }
        }
        public static string FormatarTelefone(string texto)
        {
            string numeros = SomenteNumeros(texto);

            if (numeros.Length > 11)
            {
                numeros = numeros.Substring(0, 11);
            }

            if (numeros.Length == 0)
            {
                return "";
            }
            else if (numeros.Length <= 2)
            {
                return "(" + numeros;
            }
            else if (numeros.Length <= 6)
            {
                return "(" + numeros.Substring(0, 2) + ") " + numeros.Substring(2);
            }
            else if (numeros.Length <= 10)
            {
                return "(" + numeros.Substring(0, 2) + ") " + numeros.Substring(2, 4) + "-" + numeros.Substring(6);
            }
            else
            {
                return "(" + numeros.Substring(0, 2) + ") " + numeros.Substring(2, 5) + "-" + numeros.Substring(7);
            }
        }
        public static string FormatarPlaca(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "";
            }

            string placa = Regex.Replace(texto.ToUpper(), "[^A-Z0-9]", "");

            if (placa.Length > 7)
            {
                placa = placa.Substring(0, 7);
            }

            return placa;
        }
        public static string FormatarAno(string texto)
        {
            string numeros = SomenteNumeros(texto);

            if (numeros.Length > 4)
            {
                numeros = numeros.Substring(0, 4);
            }

            return numeros;
        }

        public static string FormatarQuantidade(string texto)
        {
            string numeros = SomenteNumeros(texto);

            if (numeros.Length > 9)
            {
                numeros = numeros.Substring(0, 9);
            }

            return numeros;
        }

        public static string FormatarEmail(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "";
            }

            return texto.Replace(" ", "").ToLower();
        }

        public static string FormatarNome(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "";
            }

            string nome = Regex.Replace(texto, "[0-9]", "");

            // troca vários espaços seguidos por um só
            nome = Regex.Replace(nome, @"\s+", " ");

            return nome.Trim();
        }
        public static string FormatarValor(string texto)
        {
            decimal valor;
            if (decimal.TryParse(texto, out valor))
            {
                return valor.ToString("N2");
            }

            // se não for um número válido, deixa como está
            // para a validação do Salvar avisar o usuário
            return texto;
        }
    }
}