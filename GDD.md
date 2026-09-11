# GDD – Desvie!

**Versão:** 0.1
**Nome do projeto:** Desvie!
**Gênero:** Ação / Arcade / Casual 2D
**Plataforma:** PC / Windows
**Engine:** Unity
**Linguagem:** C#
**Controle:** Teclado
**Desenvolvedor:** Vítor Tetsuya Kazuma

---

# 1. Concepção do Jogo

## 1.1 Nome e gênero

**Desvie!** é um jogo 2D de ação e arcade baseado em reflexo e desvio de obstáculos.

O jogador controla um personagem e precisa atravessar diferentes fases evitando obstáculos até alcançar a área de chegada.

O jogo terá uma estrutura simples e progressiva, começando com desafios fáceis e aumentando a dificuldade ao longo das fases.

---

# 2. Integrantes, Papéis e Responsabilidades

## Desenvolvedor

**Vítor Tetsuya Kazuma**

Responsável pelo desenvolvimento geral do projeto, incluindo:

* Planejamento do jogo;
* Desenvolvimento na Unity;
* Programação em C#;
* Implementação das mecânicas;
* Criação e organização das fases;
* Implementação da interface;
* Testes;
* Controle de versão utilizando Git e GitHub.

---

# 3. High Concept

**Desvie!** é um jogo 2D no qual o jogador precisa utilizar seus reflexos e movimentação para desviar de obstáculos e chegar ao final de cada fase.

Ao completar uma fase, o jogador recebe uma recompensa através de pontuação e desbloqueia a próxima fase, que apresenta um desafio maior.

O objetivo é completar as três fases e obter a maior pontuação possível.

---

# 4. Público-Alvo

O jogo será direcionado principalmente para jogadores casuais e pessoas que gostam de jogos simples baseados em reflexo, atenção e desafios rápidos.

A experiência será projetada para ser fácil de compreender, permitindo que o jogador aprenda as mecânicas rapidamente.

---

# 5. Plataforma-Alvo

O jogo será desenvolvido para:

* **Plataforma:** PC / Windows;
* **Controle:** teclado;
* **Engine:** Unity.

---

# 6. Objetivo do Jogador

O objetivo principal do jogador é atravessar as fases desviando dos obstáculos e alcançar a área de chegada.

Para concluir o jogo, o jogador deverá:

1. Iniciar uma fase;
2. Controlar o personagem;
3. Desviar dos obstáculos;
4. Evitar colisões;
5. Chegar ao final da fase;
6. Receber a recompensa;
7. Desbloquear a próxima fase;
8. Repetir o processo até completar as três fases.

---

# 7. Mecânica Principal

A mecânica principal de **Desvie!** será a movimentação do personagem para evitar obstáculos.

O jogador deverá observar o posicionamento dos obstáculos e movimentar o personagem no momento adequado para passar por eles.

A movimentação será principalmente horizontal.

### Controles

* **A:** movimentar para esquerda;
* **D:** movimentar para direita;
* **Seta esquerda:** movimentar para esquerda;
* **Seta direita:** movimentar para direita.

---

# 8. Mecânicas Secundárias

Além da movimentação e do desvio, o jogo contará com:

* Sistema de colisão;
* Sistema de pontuação;
* Progressão entre fases;
* Aumento de dificuldade;
* Desbloqueio de fases;
* Reinício após derrota;
* Área de chegada;
* Tela de conclusão.

---

# 9. Obstáculos

Os obstáculos serão responsáveis por criar o desafio do jogo.

Eles poderão aparecer ou estar posicionados ao longo do caminho do jogador.

Inicialmente serão utilizados obstáculos simples, com possibilidade de pequenas variações de formato e comportamento.

### Exemplos:

* Blocos;
* Barreiras;
* Espinhos;
* Obstáculos móveis.

Caso o personagem entre em contato com um obstáculo, ocorrerá uma colisão e o jogador perderá a tentativa.

---

# 10. Core Loop

O core loop de **Desvie!** será baseado em desafio, habilidade, recompensa e progressão.

### Core Loop principal:

**Iniciar fase → movimentar personagem → observar obstáculos → desviar → chegar ao final → receber recompensa → avançar para a próxima fase → enfrentar desafio maior.**

Esse ciclo será repetido durante as três fases do jogo.

### Ciclo de tentativa:

**Tentar → desviar → vencer ou perder → aprender com os obstáculos → tentar novamente ou avançar.**

---

# 11. Sistema de Recompensa

O jogo terá um sistema de recompensa simples para incentivar a progressão do jogador.

Ao completar uma fase, o jogador receberá:

* **Pontuação;**
* **Desbloqueio da próxima fase;**
* Mensagem de fase concluída.

A principal recompensa será a possibilidade de avançar para uma nova fase com desafios maiores.

### Estrutura:

**Desafio → Vitória → Pontuação → Desbloqueio → Novo desafio.**

Ao completar a terceira fase, o jogador receberá sua pontuação final e verá uma tela de conclusão.

---

# 12. Sistema de Pontuação

A pontuação será utilizada como recompensa pelo desempenho do jogador.

O jogador receberá pontos ao concluir as fases.

A pontuação poderá levar em consideração o desempenho durante a fase, permitindo que o jogador tente melhorar seu resultado em novas tentativas.

Ao final da terceira fase, será apresentada a pontuação final.

---

# 13. Progressão dos Desafios

A dificuldade será aumentada gradualmente entre as três fases.

A progressão poderá ocorrer por meio de:

* Maior quantidade de obstáculos;
* Menor espaço para movimentação;
* Obstáculos mais próximos;
* Obstáculos móveis;
* Padrões de obstáculos mais complexos;
* Maior necessidade de reflexo e precisão.

A primeira fase será utilizada para introduzir as mecânicas, enquanto as fases seguintes aumentarão o desafio.

---

# 14. Estrutura das Fases

O jogo será composto inicialmente por três fases.

## Fase 1 – Introdução

A primeira fase apresentará as mecânicas básicas.

Características:

* Poucos obstáculos;
* Espaços maiores;
* Caminho simples;
* Baixa dificuldade.

Objetivo:

Permitir que o jogador aprenda a movimentação e o sistema de desvio.

Recompensa:

**Pontuação + desbloqueio da Fase 2.**

---

## Fase 2 – Desenvolvimento

A segunda fase aumentará a dificuldade.

Características:

* Maior quantidade de obstáculos;
* Espaços menores;
* Obstáculos mais próximos;
* Possibilidade de obstáculos móveis.

Objetivo:

Testar as habilidades adquiridas na primeira fase.

Recompensa:

**Pontuação + desbloqueio da Fase 3.**

---

## Fase 3 – Desafio Final

A terceira fase será o maior desafio do jogo.

Características:

* Maior quantidade de obstáculos;
* Caminhos mais estreitos;
* Obstáculos móveis;
* Padrões mais complexos;
* Maior necessidade de precisão.

Objetivo:

Utilizar as habilidades aprendidas nas fases anteriores para chegar ao final.

Recompensa:

**Pontuação final + conclusão do jogo.**

---

# 15. Condições de Vitória

O jogador vencerá uma fase quando conseguir atravessar todo o percurso e alcançar a área de chegada sem sofrer uma colisão que encerre a tentativa.

Ao vencer:

**Fase concluída → Pontuação → Próxima fase desbloqueada.**

O jogo será concluído após o jogador completar a terceira fase.

---

# 16. Condições de Derrota

O jogador perderá quando o personagem colidir com um obstáculo.

Após a colisão:

* A tentativa será encerrada;
* Será exibida uma mensagem de Game Over;
* O jogador poderá reiniciar a fase.

O reinício permitirá que o jogador tente novamente utilizando o conhecimento adquirido na tentativa anterior.

---

# 17. Direção Visual Inicial

A direção visual será baseada em um estilo **2D simples, colorido e de fácil leitura**.

Os elementos do jogo serão construídos de forma simples para facilitar sua produção e implementação na Unity.

### Características visuais:

* Formas simples;
* Cores contrastantes;
* Personagem facilmente identificável;
* Obstáculos facilmente reconhecíveis;
* Cenários simples;
* Interface limpa.

---

# 18. Personagem

O projeto contará inicialmente com um único personagem jogável.

O personagem será um humanoide simples e não terá um nome específico.

Seu design será desenvolvido para possuir uma silhueta facilmente reconhecível durante o gameplay.

O personagem deverá possuir:

* Vista frontal;
* Vista traseira;
* Vista lateral esquerda;
* Vista lateral direita.

---

# 19. Interface Inicial

A interface será simples e funcional.

### Menu Principal

* Nome do jogo;
* Botão **Iniciar**;
* Botão **Sair**.

### Durante a fase

* Número da fase;
* Pontuação.

### Game Over

* Mensagem de derrota;
* Pontuação;
* Botão **Reiniciar**.

### Conclusão

* Mensagem de fase concluída;
* Pontuação;
* Botão **Continuar**.

---

# 20. Áudio

O jogo contará com efeitos sonoros simples.

Estão previstos efeitos para:

* Início do jogo;
* Interações com a interface;
* Colisão;
* Game Over;
* Conclusão de fase;
* Conclusão do jogo.

Também poderá ser utilizada uma música simples durante o gameplay, dependendo do tempo disponível para desenvolvimento.

---

# 21. Animações

Serão utilizadas animações simples para melhorar a apresentação do personagem.

Inicialmente estão previstas:

* Idle;
* Movimento;
* Movimento para esquerda;
* Movimento para direita;
* Derrota.

As animações poderão ser simplificadas caso seja necessário priorizar as mecânicas principais.

---

# 22. Fluxo de Gameplay

O fluxo planejado será:

**Menu Principal**

↓

**Iniciar Jogo**

↓

**Fase 1**

↓

**Desviar dos obstáculos**

↓

**Chegar ao final**

↓

**Receber pontuação**

↓

**Desbloquear Fase 2**

↓

**Fase 2**

↓

**Desviar dos obstáculos**

↓

**Chegar ao final**

↓

**Receber pontuação**

↓

**Desbloquear Fase 3**

↓

**Fase 3**

↓

**Desviar dos obstáculos**

↓

**Chegar ao final**

↓

**Pontuação final**

↓

**Tela de conclusão**

---

# 23. Escopo Inicial

Para manter o projeto viável dentro do prazo acadêmico, o escopo inicial será limitado.

### Elementos previstos:

* 1 personagem;
* Movimentação;
* Obstáculos;
* Colisão;
* 3 fases;
* Progressão de dificuldade;
* Pontuação;
* Recompensa;
* Desbloqueio de fases;
* Menu;
* Game Over;
* Tela de conclusão;
* Sprites simples;
* Animações básicas;
* Efeitos sonoros simples.

### Elementos fora do escopo:

* Multiplayer;
* Sistema online;
* Loja;
* Inventário;
* Personagens adicionais;
* Chefes;
* Sistema de habilidades complexas;
* Mundo aberto;
* História extensa.

---

# 24. Referências

As referências utilizadas para o desenvolvimento de **Desvie!** serão jogos 2D de arcade e jogos baseados em reflexo e desvio de obstáculos.

Serão observados principalmente:

* Movimentação;
* Organização dos obstáculos;
* Progressão da dificuldade;
* Interface;
* Sistemas de pontuação;
* Sistemas de recompensa.

As referências servirão como inspiração para o projeto, sem reproduzir diretamente outro jogo.

---

# 25. Tecnologia

O projeto será desenvolvido utilizando:

* **Engine:** Unity;
* **Linguagem:** C#;
* **Plataforma:** Windows;
* **Controle:** teclado;
* **Versionamento:** Git;
* **Repositório:** GitHub.

---

# 26. Critérios para Considerar o Jogo Funcional

O protótipo será considerado funcional quando for possível:

1. Iniciar o jogo pelo menu;
2. Controlar o personagem;
3. Movimentar o personagem dentro da área jogável;
4. Apresentar obstáculos;
5. Detectar colisões;
6. Encerrar a tentativa após uma colisão;
7. Reiniciar a fase;
8. Chegar ao final de uma fase;
9. Exibir a pontuação;
10. Desbloquear a próxima fase;
11. Completar as três fases;
12. Aumentar progressivamente a dificuldade;
13. Exibir a tela de conclusão;
14. Executar corretamente em Windows.

---

# 27. Resumo do Projeto

**Desvie!** será um jogo 2D de ação e arcade focado em reflexo e desvio de obstáculos.

O jogador deverá atravessar três fases, cada uma apresentando um nível maior de dificuldade.

O jogo utilizará um core loop simples:

> **Iniciar → Desviar → Chegar ao final → Receber recompensa → Avançar → Enfrentar novo desafio.**

A recompensa será baseada principalmente em:

> **Pontuação + desbloqueio da próxima fase.**

A proposta é criar uma experiência simples, clara e possível de ser desenvolvida dentro do prazo acadêmico.
