# Sobre
Estudo sobre o livro [C# 8.0 and .NET Core 3.0 – Modern Cross-Platform Development](https://www.amazon.com.br/8-0-NET-Core-3-0-Cross-Platform/dp/1788478126)

O objetivo é fazer um estudo amplo sobre o c# e .net core para atualizar e melhorar a desempenho no desenvolvimento, trabalho com .net c# desde 2013 e muita coisa surgiu, onde acabamos pegando as atualizações de forma picada, acabando não utilizando o que há de melhor na línguagem.

# Ambiente de desenvolvimento
Com o .net se tornando multiplataforma, resolvi realizar o estudo todo em um ambiente linux. Para quem sabe no futuro eu adote o Linux como plataforma definitiva.

## Máquina virtual
Para o estudo criei uma máquina virtual com a distribuição [Lubuntu](https://lubuntu.net/). Uma distribuição oficial da Ubuntu mais enxuta, sem muitos recursos, com as configurações abaixo a mesma está rodando sem travar:
- Memória: 1GB;
- Disco: 127GB;

## Softwares
### GIT
```sh 
apt-get install git 
```

### Visual Code
1 - Atualize o índice de pacotes e instale as dependências digitando:
```sh 
sudo apt update
sudo apt install software-properties-common apt-transport-https wget
```

2 - Em seguida, importe a chave Microsoft GPG usando o seguinte comando wget:
```sh
wget -q https://packages.microsoft.com/keys/microsoft.asc -O- | sudo apt-key add -
```

3 - E habilite o repositório do Visual Studio Code digitando:
```sh
sudo add-apt-repository "deb [arch=amd64] https://packages.microsoft.com/repos/vscode stable main"
```

4 - Assim que o repositório apt estiver habilitado, instale a versão mais recente do Visual Studio Code com:
```sh
sudo apt update
sudo apt install code
```

5 - Extensões

- C# for Visual Studio Code
(ms-vscode.csharp)

- C# XML Documentation
(k--kato.docomment Studio Code.)

- C# Extensions
(jchannon.csharpextensions)

- REST Client
(humao.rest-client)

- ILSpy .NET Decompiler
(icsharpcode.ilspy-vscode)

- SharpPad
(jmazouri.sharppad)


### .Net SDK
1 - A instalação com APT pode ser feita com alguns comandos. Antes de instalar o .NET, execute os comandos a seguir para adicionar a chave de assinatura do pacote da Microsoft à lista de chaves confiáveis e adicionar o repositório de pacotes:
```sh
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.debsudo apt install code

sudo dpkg -i packages-microsoft-prod.deb
```

2 - Instalar SDK:
```sh
sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-3.1
```

# Entendendo o .Net
## Compilação
Quando uma aplicação .NET é compilada ela é convertida de sua linguagem escrita (Visual Basic .NET, C# ou outra compatível) para a Microsoft Intermediate Language (MSIL). MSIL é uma linguagem de baixo-nível que a CLR (Common Language Runtime) pode ler e entender. Porque todos os executáveis e DLLs existem como MSIL podem ser interoperalizados livremente. A Common Language Specification (CLS) define os padrões mínimos que os compiladores das linguagens precisam estar em conformidade. Com isso a CLS assegura que qualquer código fonte compilado nos padrões CLS pode ser interoperado pelo .NET Framework.

# Referências
- https://git-scm.com/download/linux
- https://linuxize.com/post/how-to-install-visual-studio-code-on-ubuntu-18-04/
- https://docs.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu#2004-
- https://docs.microsoft.com/pt-br/archive/msdn-magazine/2017/september/net-standard-demystifying-net-core-and-net-standard
- http://www.macoratti.net/13/01/aspn_7cor1.htm
- https://www.eduardopires.net.br/2017/06/net-standard-voce-precisa-conhecer/
- https://juliobattisti.com.br/tutoriais/almirrivas/vbdotnet001.asp?imprime=sim
- 
