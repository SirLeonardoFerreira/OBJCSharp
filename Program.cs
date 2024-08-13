using System;
namespace Atividade {
    class Program {
        static void Main (String[] args){
            float val_pag;
            Console.WriteLine("Infome o nome: ");
            String var_nome = Console.ReadLine();
            Console.WriteLine("Informe o endereço: ");
            String var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisíca (f) ou Pessoa Jurídica (j)? ");
            String var_tipo = Console.ReadLine();

            if (var_tipo == "f"){
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;

                Console.WriteLine("Informe o CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe o RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_imposto(val_pag);

                Console.WriteLine("---------------- Pessoa Fisíca ----------------");
                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereço ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);
                Console.WriteLine("Valor da compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar .: " + pf.total.ToString("C"));
            }

            if (var_tipo == "j"){
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;

                Console.WriteLine("Informe o CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe o IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_imposto(val_pag);

                Console.WriteLine("---------------- Pessoa Jurídica ----------------");
                Console.WriteLine("Nome ..........: " + pj.nome);
                Console.WriteLine("Endereço ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                Console.WriteLine("IE ............: " + pj.ie);
                Console.WriteLine("Valor da compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar .: " + pj.total.ToString("C"));
            }
        }
    }
}