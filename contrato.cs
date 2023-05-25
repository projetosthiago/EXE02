namespace exe02;
class contrato


    {
        public string? Nome {get;set;}
        public string? email {get;set;}
        public string? telefone {get;set;}

        public virtual string MostrarDados(){
            string Tudo ="Nome: " + this.Nome + "Email: " + this.email + "Telefone: " + this.telefone;
            return Tudo;
        }
    }