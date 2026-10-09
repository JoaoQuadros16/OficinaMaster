using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ControleEstoqueWindowsForm.Validacoes
{
    public static class Validador
    {
        public static bool ValidarCPF(string cpf, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(cpf))
            {
                mensagemErro = "O CPF não pode estar vazio.";
                return false;
            }

            cpf = Regex.Replace(cpf, "[^0-9]", "");

            if (cpf.Length != 11)
            {
                mensagemErro = "O CPF deve conter 11 dígitos.";
                return false;
            }

            bool todosIguais = true;
            for (int i = 1; i < cpf.Length; i++)
            {
                if (cpf[i] != cpf[0])
                {
                    todosIguais = false;
                    break;
                }
            }

            if (todosIguais)
            {
                mensagemErro = "CPF inválido.";
                return false;
            }
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += (cpf[i] - '0') * (10 - i);
            }

            int resto = soma % 11;
            int primeiroDigito = resto < 2 ? 0 : 11 - resto;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += (cpf[i] - '0') * (11 - i);
            }

            resto = soma % 11;
            int segundoDigito = resto < 2 ? 0 : 11 - resto;

            if (cpf[9] - '0' != primeiroDigito || cpf[10] - '0' != segundoDigito)
            {
                mensagemErro = "CPF inválido.";
                return false;
            }

            return true;
        }
        public static bool CampoObrigatorio(string valor, string nomeCampo, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(valor))
            {
                mensagemErro = $"O campo {nomeCampo} é obrigatório.";
                return false;
            }
            return true;
        }
        public static bool ValidarEmail(string email, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(email))
            {
                mensagemErro = "Informe o e-mail.";
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensagemErro = "E-mail inválido. Exemplo: nome@gmail.com";
                return false;
            }

            return true;
        }

        public static bool ValidarNome(string nome, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(nome))
            {
                mensagemErro = "Informe o nome.";
                return false;
            }

            if (Regex.IsMatch(nome, "[0-9]"))
            {
                mensagemErro = "O nome não pode conter números.";
                return false;
            }

            return true;
        }
        public static bool ValidarTelefone(string telefone, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(telefone))
            {
                mensagemErro = "Informe o telefone.";
                return false;
            }

            string numeros = Regex.Replace(telefone, "[^0-9]", "");

            if (numeros.Length != 10 && numeros.Length != 11)
            {
                mensagemErro = "Telefone inválido. Informe o DDD + número.";
                return false;
            }

            return true;
        }
        public static bool ValidarPlaca(string placa, out string mensagemErro)
        {
            mensagemErro = string.Empty;

            if (string.IsNullOrWhiteSpace(placa))
            {
                mensagemErro = "O campo Placa é obrigatório.";
                return false;
            }

            placa = Regex.Replace(placa.ToUpper(), "[^A-Z0-9]", "");

            // Modelo antigo (ABC1234) ou Mercosul (ABC1D23)
            if (!Regex.IsMatch(placa, "^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$"))
            {
                mensagemErro = "Placa inválida. Exemplos: ABC1234 ou ABC1D23.";
                return false;
            }

            return true;
        }
    }
}
