

Console.Write("Crie uma senha: ");
int senhaGuardada = int.Parse(Console.ReadLine());  

Console.Write("Confirme a senha: ");
int senha1 = int.Parse(Console.ReadLine());

while (senhaGuardada != senha1 ){
    Console.Write ("Senha errada, digite novamente: ");
    senha1 = int.Parse(Console.ReadLine());
}
 
Console.WriteLine("Senha correta, acesso liberado !!!");

Console.WriteLine();

Console.WriteLine("Bem-vindo ao jogo de adivinhação de números!");
Console.WriteLine();
Console.WriteLine("Tente adivinhar o número entre 1 e 100");
Console.WriteLine();
Console.Write("Quantos jogadores vão jogar? ");
int numerojogadores = int.Parse(Console.ReadLine());
Console.WriteLine();
Random random = new Random();
int numeroaleatorio  = random.Next(1,101);

for (int jogador = 1; jogador <= numerojogadores; jogador++){
    Console.WriteLine("Jogador " + jogador + " Tente adivinhar um numero entre 1 e 100 ");
    Console.WriteLine();
    int tentativas = 0;
    bool acertou = false;

    while(tentativas < 3 && !acertou){
       Console.Write("Digite sua tentativa: ");
       int tentativa = int.Parse(Console.ReadLine()); 
       tentativas++;

       if (tentativa == numeroaleatorio){

        acertou = true;
        Console.WriteLine("Parabêns, você acertou o numero!");
        Console.WriteLine();

       }
       else if (tentativa < numeroaleatorio){

        Console.WriteLine("Tente um numero maior ");
        Console.WriteLine();
       }
       else {
         
         Console.WriteLine("Tente um numero menor ");
         Console.WriteLine();
       }
    }
    if(!acertou){
        Console.WriteLine("Jogador "+ jogador + " suas 3 tentativas acabaram.");
        Console.WriteLine();
    }

}
    Console.WriteLine("O numero correto era " + numeroaleatorio);

