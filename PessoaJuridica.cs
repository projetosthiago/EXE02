namespace exe02;
class PessoaJuridica: contrato
{
    public string? NomeDaEmpresa {get;set;}
    public string? Cnpj {get;set;}
    public string? IE {get;set;}

    public override string MostrarDados()
    {
        return base.MostrarDados() + "Nome Da Empresa: "+ this.NomeDaEmpresa + "Cnpj: "+ this.Cnpj + "IE: " + this.IE;
    }
}