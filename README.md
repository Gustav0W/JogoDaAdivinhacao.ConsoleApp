# Jogo da Adivinhação

![](https://i.imgur.com/N93CPlS.gif)

### Introdução

Um jogo onde você deve adivinhar o número de 1 a 20 que foi escolhido pelo sistema aleatoriamente.

## Jogabilidade
- Permite escolher a dificuldade
- Inserir o número e apertar enter quando for seguir em frente
- Permite rejogar sem ter que reiniciar o programa

## Como Utilizar
1. Clone o repositório ou baixe o código fonte.
```
git clone https://github.com/Gustav0W/JogoDaAdivinhacao.ConsoleApp
```  
2. Abra o terminal ou o prompt de comando e navegue até a pasta raíz.
```
cd JogoDaAdivinhacao.ConsoleApp
```
3. Utilize o comando abaixo para restaurar as dependências do projeto.
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
6. Você verá esse terminal:
```
Console.WriteLine("=============================");
Console.WriteLine("     Jogo da Adivinhação     ");
Console.WriteLine("=============================");

//Dificuldade
Console.WriteLine("Escolha um nivel de dificuldade  ");
Console.WriteLine("---------------------------------");
Console.WriteLine("1 - Fácil (10 tentativas)");
Console.WriteLine("2 - Médio (5 tentativas)");
Console.WriteLine("3 - Difícil (3 tentativas)");
Console.Write("Digite sua escolha: ");
```
