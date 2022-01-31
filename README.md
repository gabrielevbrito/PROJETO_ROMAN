# PROJETO_ROMAN
💻 | O Roman é um projeto que consiste em um sistema de sugestões de projetos entre professores, com descrição e temática.

# Clonar Repositório do Github 😺
Para clonar o repostirório do GitHub você precisara verificar se a instalação do git foi feita, e se tudo estiver certo você exacutará o seguinte comando no terminal do Git:
`git clone http://github.com/gabrielevbrito/Roman`

# Criar o Banco de Dados 
Para Criar o banco de dados após a clonagem do repositório para a sua máquina, você deverá abrir o SQL Server Management Studio (caso já o tenha instalado, caso contrário, o instale).

No SQL:

Adicione os arquivos:

__DiretorioOndeORepositorioFoiClonado\Roman\BD\Roman_01_DDL.sql__

__DiretorioOndeORepositorioFoiClonado\Roman\BD\Roman_01_DML.sql__

__DiretorioOndeORepositorioFoiClonado\Roman\BD\Roman_01_DQL.sql__

Agora, com os arquivos adicionados você deve ir no arquivo denominado DDL e clicar em Executar, assim serão criados o banco e tabelas.

Em seguida, abra o arquivo denominado DML e clique em executar, assim você irá adicionar os valores as tabelas.

Por fim, realize o mesmo processo com o arquivo DQL para ver as tabelas, deverá aparecer um modelo semelhante a este, mas com seus dados:

<table>
<tr>
  <th>Id_Projeto</th>
  <th>Id_Tema</th>
  <th>Descricao_Projeto</th>
  <th>Id_Usuario</th>
</tr>
<tr>
  <td>1</td>
  <td>1</td>
  <td>Sp Medical Group</td>
  <td>1</td>
</tr>
  <tr>
  <td>2</td>
  <td>1</td>
  <td>Gufi</td>
  <td>2</td>
</tr>
  <tr>
  <td>3</td>
  <td>2</td>
  <td>Roman</td>
  <td>1</td>
</tr>
  <tr>
  <td>4</td>
  <td>3</td>
  <td>WishList</td>
  <td>1</td>
</tr>
</table>

# Importar a coleção para o Postman
Primeiramente, verifique se o Postman está instalado, caso esteja, clique no botão de importar e selecione o arquivo:

__DiretorioOndeORepositorioFoiClonado\Roman\Back-End\Postman\Senai_Roman_webAPI.postman_collection__

O arquivo importado deve possuir a seguinta coleção:
*	Login:
    *	Login
*	Projetos:
    *	Projetos.Listar
    *	Projetos.Cadastrar

# Executar a API
Primeiramente acesse o arquivo RomanContext, em seguida, mude o lugar onde está escrito "options builder" para como está em seu computador, seu banco com a sua senha de acesso.

Ex: `optionsBuilder.UseSqlServer("Data Source=NOTE0113F1\\SQLEXPRESS; initial catalog=Roman; user Id=sa; pwd=Senai@132;"); }`
Após isso, para executar a API temos 2 opções:
__Primeira__: Você pode abrir o local do arquivo (__DiretorioOndeORepositorioFoiClonado\Roman\Back-End\Senai_Roman_webAPI__) e na parte superior onde fica a rota dele digitar cmd e depois colocar um dotnet run e dar enter.

__Segunda__: Abra o arquivo (__DiretorioOndeORepositorioFoiClonado\Roman\Back-End\Senai_Roman_webAPI\Senai_WishList_webAPI.sln__) no Visual Studio e clique em executar Senai_WishList_webAPI.

Após realizar a execução da API você já pode testar os métodos no Postman.

# Rodar a Aplicação Mobile

Primeiramente instale as dependêcias do projeto e para isso você deverá acessar:

__DiretorioOndeORepositorioFoiClonado\Roman\Mobile\Roman__

E na parte superior digitar cmd e colocar o comando `npm i` ou `npm instal`
Após isso a aplicação pode ser executada de duas maneiras sendo elas:

__Primeira__: Você pode abrir o local do arquivo (__DiretorioOndeORepositorioFoiClonado\Roman\Mobile\Roman__) e na parte superior onde fica a rota dele digitar cmd e depois colocar um npx react-native run-android e dar enter.

__Segunda__: Você pode abrir o local do arquivo (__DiretorioOndeORepositorioFoiClonado\Roman\Mobile\Roman__) no Visual Studio Code e abrir o prompt de comando (ctrl + ') e digitar o comando `npx react-native run-android`.

O projeto será aberto junto do Android Studio (Verifique se já esta instalado).

# Membros do Grupo e Professores:
### Professores:


<table>
<tr>
  <th>Nome</th>
  <th>Username</th>
</tr>
<tr>
  <td>Saulo</td>
  <td>Saulomsantos</td>
</tr>
<tr>
  <td>Lucas</td>
  <td>Lucas Aragão Feliciano</td>
</tr>
</table>


### Alunos:

<table>
<tr>
  <th>Nome</th>
  <th>Username</th>
</tr>
<tr>
  <td>Gabriele Brito</td>
  <td>Gabriele-Brito</td>
</tr>
<tr>
  <td>Leonardo Souza</td>
  <td>Leonardo-Souza-de-Castro</td>
</tr>
<tr>
  <td>Livia Negrini</td>
  <td>livianegrini</td>
</tr>
</table>

