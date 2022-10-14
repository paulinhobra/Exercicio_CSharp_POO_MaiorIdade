MaiorIdade p1 = new MaiorIdade();
MaiorIdade p2 = new MaiorIdade();
MaiorIdade p3 = new MaiorIdade();

Console.WriteLine("Determine qual pessoa tem mais idade!");

Console.Write("Digite o nome da primeira pessoa: ");
p1.setNome(Console.ReadLine());
Console.Write("Digite a idade da primeira pessoa: ");
p1.setIdade(int.Parse(Console.ReadLine()));

Console.Write("Digite o nome da segunda pessoa: ");
p2.setNome(Console.ReadLine());
Console.Write("Digite a idade da segunda pessoa: ");
p2.setIdade(int.Parse(Console.ReadLine()));

Console.Write("Digite o nome da terceira pessoa: ");
p3.setNome(Console.ReadLine());
Console.Write("Digite a idade da terceira pessoa: ");
p3.setIdade(int.Parse(Console.ReadLine()));

if(p1.getIdade() > p2.getIdade() && p1.getIdade() > p3.getIdade()){
    p1.ExibirDados(p1.getNome(), p1.getIdade());    
}else if(p2.getIdade() > p1.getIdade() && p2.getIdade() > p3.getIdade()){
    p2.ExibirDados(p2.getNome(), p2.getIdade());
}else{
    p3.ExibirDados(p3.getNome(), p3.getIdade());
}

class MaiorIdade{
    private string Nome;
    private int Idade;

    public void setNome(string nomePessoa){
        this.Nome = nomePessoa;
    }

    public string getNome(){
        return this.Nome;
    }

    public void setIdade(int idadePessoa){
        this.Idade = idadePessoa;
    }

    public int getIdade(){
        return this.Idade;
    }

    public MaiorIdade(){
        this.Nome = this.getNome();
        this.Idade = this.getIdade();
    }

    public MaiorIdade(string nomePessoa, int idadePessoa){
        this.Nome = nomePessoa;
        this.Idade = idadePessoa;
    }

    public void ExibirDados(string pessoa, int idade){
        Console.WriteLine($"A pessoa com maior idade é o(a) {pessoa} com {idade} anos");
    }
}
