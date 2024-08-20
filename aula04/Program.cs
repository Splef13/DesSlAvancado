class Program{
    public static void Main (string [] args){
        Pessoa objPessoa = new Pessoa("Rafael");
        Console.WriteLine("Antes do método (Classe): " + objPessoa.ToString());
        AlterarNomeClasse(objPessoa);
        Console.WriteLine("Depois do método (Classe): " + objPessoa.ToString());

        PessoaStruct pessoaStruct = new PessoaStruct("Miguel");
        Console.WriteLine("Antes do método (struct): " + pessoaStruct.ToString());
        AlteraNomeStruct(pessoaStruct);
        Console.WriteLine("Depois do método (struct): " + pessoaStruct.ToString());
    }

    public static void AlterarNomeClasse(Pessoa objAux){
        objAux.Nome = "Almeida";
    }

    public static void AlteraNomeStruct(PessoaStruct objAux){
        objAux.NomeStruct = "Talita";
    }
}