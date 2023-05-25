namespace exe02;
class Program
{
    static void Main(string[] args)
    {
        PessoaJuridica n1 = new PessoaJuridica();
        PessoaFisica n2 = new PessoaFisica();

        n1.Nome = "Thiago Menezes";
        n1.email = "thiago.teixeira@etec.sp.gov.br";
        n1.telefone = "11914136627";
        n1.cpf = "000000000-00";
        n1.Idade = "16";

        n2.Nome = "Thiago Menezes";
        n2.email = "thiago.teixeira@etec.sp.gov.br";
        n2.telefone = "11914136627";
        n2.NomeDaEmprsa = "Meneze's Comapany";
        n2.Cnpj = "XX.XXX.XXX/0001-XX";
        n2.IE = "********";
        
        Console.WriteLine(n1.MostrarDados());
        Console.WriteLine(n2.MostrarDados());
    }
}
