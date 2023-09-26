# Blog Pessoal com ASP.NET
Bem-vindo ao repositório do **Blog Pessoal** em ASP.NET! Este projeto permite que os usuários criem, gerenciem e compartilhem suas histórias e curiosidades online. Com recursos para criar publicações, associá-las por temas e atualizá-las, você poderá compartilhar suas experiências com o mundo. Este README fornecerá informações sobre como executar o projeto localmente e como começar a usá-lo.

## Executar o Projeto
Siga estas etapas para executar o Blog Pessoal em ASP.NET em sua máquina local:


Clone este repositório em sua máquina local.
```bash
git clone hhttps://github.com/MatheusSQueiroz/Blog.git
```
Abra o projeto no Visual Studio.(ou na sua IDE de preferência)
Configuração da Conexão com o Banco de Dados
Abra o arquivo appsettings.json no projeto.
Atualize a string de conexão com o banco de dados, substituindo <sua-string-de-conexao> pelo endereço do seu servidor SQL e outras informações necessárias.
```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=<seu-servidor>;Database=BlogPessoal;Trusted_Connection=True;"
}
```
### Execução do Projeto
No Visual Studio, pressione F5 ou clique em "Iniciar" para compilar e executar o projeto.
Acesso à Aplicação
Após a compilação bem-sucedida, você poderá acessar a aplicação em seu navegador preferido em (http://localhost:5000), onde porta é a porta em que a sua IDE iniciou a aplicação.

## Funcionalidades Principais
O Blog Pessoal em ASP.NET oferece as seguintes funcionalidades principais:

Criar Publicações: Os usuários podem criar novas publicações com título, conteúdo e associá-las a temas específicos.<br/>
Associar por Temas: Cada publicação pode ser associada a um ou mais temas, permitindo uma organização eficaz.<br/>
Atualizar Publicações: Os usuários podem editar e atualizar suas publicações existentes a qualquer momento.<br/>
Listar por Nome e/ou ID: As publicações podem ser listadas por nome e/ou ID para facilitar a pesquisa.<br/>
Compartilhar Histórias: Os usuários podem compartilhar suas histórias, experiências e curiosidades online.<br/>
## Contribuindo
Se você gostaria de contribuir para este projeto, sinta-se à vontade para abrir uma issue ou enviar um pull request. Aceitamos contribuições de todos os níveis de habilidade!
