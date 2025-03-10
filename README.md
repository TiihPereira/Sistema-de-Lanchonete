# Sistema de Lanchonete

## Instalação e Execução

### 1. Instalação do Banco de Dados
Para configurar o banco de dados do sistema, siga os passos abaixo:

1. **Baixar e instalar o MySQL Workbench**
   - Faça o download do [MySQL Workbench](https://dev.mysql.com/downloads/installer/)
   - Selecionar a opção: [(mysql-installer-community-8.0.41.0.msi)]
   - Siga as instruções do instalador para concluir a instalação

2. **Configurar o Banco de Dados**
   - Abra o MySQL Workbench
   - Conecte-se ao servidor MySQL
   - Execute os scripts SQL localizados na pasta `database/` do projeto para criar e popular o banco de dados

### 2. Execução da Aplicação

1. **Abrir o Projeto**
   - Certifique-se de ter o [Visual Studio](https://visualstudio.microsoft.com/) instalado
   - Clone o repositório do projeto e abra o arquivo `.sln` no Visual Studio

2. **Configurar a Conexão com o Banco**
   - No arquivo de configuração, ajuste a string de conexão do MySQL conforme necessário

3. **Compilar e Rodar**
   - Execute o projeto pressionando `F5` no Visual Studio

---

## Escolhas Técnicas e de Design

### Tecnologia Utilizada
- **C# com Windows Forms**: Escolhido por sua facilidade de desenvolvimento para aplicações desktop e ampla compatibilidade com o ambiente Windows.
- **MySQL**: Banco de dados relacional confiável e de fácil integração com aplicações C#.

### Design da Aplicação
- **Interface Simples e Intuitiva**: O layout foi projetado para ser minimalista e funcional, permitindo uma fácil navegação.
- **Separação em Camadas (DAO, BO)**: Organização do código para facilitar manutenção e futuras melhorias.

---

Desenvolvido para facilitar o gerenciamento de pedidos em lanchonetes, proporcionando um controle eficiente das vendas.

