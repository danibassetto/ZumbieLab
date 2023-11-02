<!DOCTYPE html>
<h1>Projeto ZombieLab</h1>
<h1>Software CAMPEÃO do Dsin CoderChallenge 2023</h1>

<h2>Introdução</h2>
<p>ZombieLab representa uma inovadora solução de defesa projetada para detectar e proteger os sobreviventes contra as ameaças em nosso mundo apocalíptico. Sua função primordial reside na catalogação de potenciais hospedeiros, visando maximizar a eficácia das estratégias de defesa e contra-ataque com base em uma ampla gama de informações disponíveis.
O projeto foi proposto pela empresa DSIN no desafio CoderChallenge, na qual tivemos 7 dias para o desenvolvimento da aplicação.</p>

<h2>Tecnologias utilizadas</h2>
<p>O projeto é uma aplicação WEB MVC (Model-View-Controller) desenvolvida com C# e .NET 6. Para a parte visual foram utilizados recursos como: HTML5, CSS3, JavaScript, Razor e Bootstrap. Por fim, a camada de banco de dados foi feita com MySQL 8.0. Para melhorar e facilitar a experiência dos avaliadores, o projeto foi publicado no IIS de uma VM da Azure.</p>

<h2>Funcionalidades</h2>

<h3>1. Tela de Login</h3>
<p>Permite a conexão do usuário administrador e dos posteriores usuários cadastrados.</p>

![Tela de Login](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-login.png)

<h3>2. Tela Inicial</h3>
<p>Possui um menu lateral para navegação e exibe um texto introdutório. Além de informar a quantidade de possíveis hospedeiros catalogados.</p>

![Tela de Home](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-home.png)

<h3>3. Hospedeiro</h3>
<p>No menu lateral, ao clicar em "Hospedeiro", o usuário é redirecionado até a tela de gerenciamento de possíveis hospedeiros.</p>

![Hospedeiros](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-listagem-hospedeiro.png)

<h4>3.1 Adicionando um Hospedeiro</h4>
<p>Para adicionar um hospedeiro basta clicar no botão verde "Adicionar" na parte superior direita. Irá abrir a tela de cadastro, basta preencher os campos e clicar no botão azul "Adicionar" na parte inferior da tela.</p>

![Cadastro hospedeiro](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-cadastro-hospedeiro.png)

<h4>3.2 Visualizando a força, inteligência e velocidade do hospedeiro cadastrado</h4>
<p>Note que após cadastrar o hospedeiro foi gerado um novo registro na tabela. Ao clicar no ícone amarelo de gráfico dentro da coluna "Atributos" é possível visualizar um gráfico e os valores de força, inteligência e velocidade.</p>

![Atributos](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-atributos.png)

<h4>3.3 Visualizando o conteúdo do chip programado para ser implantado nos patos</h4>
<p>Para visualizar o score de periculosidade, pontos fracos, ataques e defesas propostos basta clicar no ícone cinza de processador, ao lado do ícone de gráfico. Os ataques e defesas são feitos para neutralizar os pontos fortes dos zumbis, visando derrotá-los. Note que essa tela muda conforme os dados cadastrados.</p>

![Chip Pato](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-chip-patos.png)

<h4>3.4 Editando e Excluindo um hospedeiro</h4>
<p>Para editar, basta clicar no ícone de lápis ao final da linha do hospedeiro em questão, enquanto para excluir basta clicar no ícone de lixo ao lado do lápis.</p>

<h3>4. Classificações e métricas do sistema</h3>
<p>Para visualizar a metodologia de classificação dos atributos do hospedeiro, assim como do score de periculosidade, ataques e defesas, basta ir em "Sobre" no menu lateral.</p>

![Classificação](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-classificacao.png)

<h3>5. Cadastrando, editando e excluindo um usuário</h3>
<p>Para cadastrar um novo usuário, basta clicar em "Olá, Admin!" > "Usuário" > Adicionar e informar os dados. Além disso, para editar e excluir basta clicar nos ícones de edição e exclusão. De forma semelhante ao hospedeiro.</p>

![Usuários](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-listagem-usuario.png)

<h3>6. Redefinindo a senha de usuário</h3>
<p>No menu lateral, clique em "Olá, ..." > "Redefinir Senha" e preencher os campos informados.</p>

![Redefinicão de senha](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-redefinicao-senha.png)

<h3>7. Envio de e-mail com nova senha no caso de esquecimento de senha</h3>
<p>Na tela de login, basta clicar em "Redefinir senha", informar o e-mail cadastrado no usuário em questão e logar com a nova senha encaminhada em seu e-mail.</p>

![Esqueceu a senha](https://github.com/danibassetto/ZumbieLab/blob/master/zombie-lab-esqueceu-senha.png)
