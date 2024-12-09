<!DOCTYPE html>
<html lang="pt-BR">
<head>
  <meta charset="UTF-8">
</head>
<body>
  <h1>📝Rastrea - Aplicação de Rastreamento</h1>
  <p>Bem-vindo ao <strong>Rastrea</strong>, uma aplicação de rastreamento desenvolvida com .NET MAUI para permitir que os clientes de uma empresa de logística acompanhem o status de seus pacotes em tempo real de forma prática e eficiente. 🚚</p>

  <h2>👥Autores</h2>
  <table>
    <thead>
      <tr>
        <th>Prontuário</th>
        <th>Nome Completo</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>CB3021521</td>
        <td>Gabriel Martins Alves da Silva (Ariel)</td>
      </tr>
      <tr>
        <td>CB3020282</td>
        <td>Ronald Pereira Evangelista</td>
      </tr>
    </tbody>
  </table>

  <h2>📜Funcionalidades</h2>
  <ul>
    <li>Inserir o código de rastreamento do pacote.</li>
    <li>Exibir informações detalhadas do pacote, incluindo:</li>
    <ul>
      <li>Status atual do pacote.</li>
      <li>Data de envio e data prevista de entrega.</li>
      <li>Localização atual.</li>
      <li>Histórico completo de eventos.</li>
    </ul>
    <li>Navegar entre a página inicial e a página de resultados de forma intuitiva.</li>
  </ul>

  <h2>🛠️Tecnologias Utilizadas</h2>
  <ul>
    <li><strong>Framework:</strong> .NET MAUI</li>
    <li><strong>Linguagem:</strong> C#</li>
    <li><strong>Padrão de Arquitetura:</strong> MVVM (Model-View-ViewModel)</li>
  </ul>

  <h2>📋Requisitos</h2>
  <p>Para executar o projeto, você precisa ter os seguintes itens instalados em sua máquina:</p>
  <ul>
    <li>Visual Studio 2022 (ou mais recente) com suporte para desenvolvimento de aplicativos móveis (.NET MAUI).</li>
  </ul>

  <h2>🔍 Detalhes do Projeto</h2>
  <p>O <strong>Rastrea</strong> foi desenvolvido para atender às necessidades de uma empresa de logística, permitindo que seus clientes rastreiem o status de seus pacotes de forma confiável. O aplicativo possui as seguintes implementações técnicas:</p>
  <ul>
    <li>Uma <strong>página inicial</strong> que permite aos clientes inserir o código de rastreamento do pacote.</li>
    <li>Uma <strong>página de resultados</strong> que exibe informações detalhadas do pacote usando controles XAML apropriados.</li>
    <li>Modelo para representar informações de pacotes, incluindo ID do pacote, status, datas e histórico.</li>
    <li>ViewModel para gerenciar a lógica de rastreamento, que permite buscar informações simuladas do pacote com base no código fornecido.</li>
    <li>Interface de usuário intuitiva, projetada para facilitar a navegação entre as telas.</li>
  </ul>

  <h2>🚀 Simulação de Rastreamento</h2>
  <p>As informações de rastreamento são simuladas para fins de desenvolvimento e testes. Os dados fictícios fornecem uma experiência realista de rastreamento de pacotes.</p>

  <h2>📦 Estrutura do Código</h2>
  <ul>
    <li><strong>Model:</strong> Define a estrutura de dados do pacote (ID, status, datas, histórico).</li>
    <li><strong>ViewModel:</strong> Gerencia a lógica de entrada de dados e a busca de informações do pacote.</li>
    <li><strong>Views:</strong> Páginas XAML para a interface do usuário (página inicial e página de resultados).</li>
  </ul>

  <h2>Entrega</h2>
  <ul>
    <li><a href="">Video</a></li>
  </ul>
</body>
</html>
