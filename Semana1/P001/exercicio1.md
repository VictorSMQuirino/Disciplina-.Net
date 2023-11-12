### Verificando instalação
Para verificar se o .NET SDK está corretamente instalado basta executar o seguinte comando:
```
dotnet --version
```
Esse comando exivbirá a versão do dotnet, caso esteja instalado no sistema.

### Removendo o .NET SDK
Para remover o .NET SDK do sistema basta executar os seguintes comandos:

Windows:
``` 
dotnet --uninstall-sdk
```
Linux:
``` 
sudo apt-get remove --purge dotnet-sdk-*
```

### Atualizando versão
Para atualizar a versão instalado do .NET SDK:

Windows: baixar e instalar a versão mais recente no site da micsoroft

Linux: Executar os seguintes comandos:
```
sudo apt-get update
sudo apt-get upgrade dotnet-sdk-*
```