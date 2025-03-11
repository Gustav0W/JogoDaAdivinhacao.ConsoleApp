# Jogo da Adivinha��o

![](https://i.imgur.com/N93CPlS.gif)

### Introdu��o

Um jogo onde voc� deve adivinhar o n�mero de 1 a 20 que foi escolhido pelo sistema aleatoriamente.

## Jogabilidade
- Permite escolher a dificuldade
- Inserir o n�mero e apertar enter quando for seguir em frente
- Permite rejogar sem ter que reiniciar o programa

## Como Utilizar
1. Clone o reposit�rio ou baixe o c�digo fonte.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta ra�z.
3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.
```
dotnet restore
```
4. Em seguida compile com o comando:
```
dotnet build --configuration Release
```
5. Execute com o comando:
```
dotnet run
```
6. Voc� ver� esse terminal:
```
Console.WriteLine("=============================");
Console.WriteLine("     Jogo da Adivinha��o     ");
Console.WriteLine("=============================");

//Dificuldade
Console.WriteLine("Escolha um nivel de dificuldade  ");
Console.WriteLine("---------------------------------");
Console.WriteLine("1 - F�cil (10 tentativas)");
Console.WriteLine("2 - M�dio (5 tentativas)");
Console.WriteLine("3 - Dif�cil (3 tentativas)");
Console.Write("Digite sua escolha: ");
```
