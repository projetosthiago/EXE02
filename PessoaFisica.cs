namespace exe02;
class PessoaFisica: contrato
{
    public string? Idade {get;set;}
    public string? Cpf {get;set;}

    public override string MostrarDados()
    {
        return base.MostrarDados() + "Idade: "+ this.Idade + "cpf: "+ this.Cpf;
    }
}