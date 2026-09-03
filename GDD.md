# 11. GDD inicial

## 11.1 Visão geral do jogo

**Desvie!** será um jogo 2D de sobrevivência e pontuação desenvolvido utilizando a Unity e a linguagem C#. O jogador controla um personagem em uma área delimitada da tela e deve evitar obstáculos que surgem continuamente.

A partida não possui uma duração fixa. O objetivo é permanecer vivo pelo maior tempo possível e alcançar a maior pontuação.

## 11.2 Gameplay

O jogador controla o personagem horizontalmente utilizando as teclas **A/D** ou as setas esquerda/direita.

Os obstáculos aparecerão na parte superior da tela e se movimentarão em direção ao personagem. O jogador deverá observar a posição dos obstáculos e movimentar o personagem para evitar colisões.

Conforme o tempo de sobrevivência aumenta, a dificuldade também aumentará por meio da velocidade e/ou frequência dos obstáculos.

## 11.3 Personagem

O jogo contará inicialmente com um personagem jogável.

O personagem terá movimentação horizontal e permanecerá dentro dos limites da área de jogo. A representação visual será desenvolvida em estilo 2D simples, buscando uma identidade visual própria para o projeto.

## 11.4 Obstáculos

Os obstáculos serão os principais elementos responsáveis pelo desafio do jogo.

Eles surgirão na parte superior da tela e se deslocarão para baixo. Caso um obstáculo entre em contato com o personagem, será detectada uma colisão e a partida será encerrada.

Inicialmente será utilizado um tipo principal de obstáculo, podendo receber pequenas variações visuais ou de comportamento caso o tempo de desenvolvimento permita.

## 11.5 Sistema de pontuação

A pontuação aumentará conforme o jogador permanecer vivo durante a partida.

A pontuação será exibida na interface durante o gameplay. Ao ocorrer o Game Over, a pontuação final será apresentada ao jogador.

Também está prevista a possibilidade de registrar a maior pontuação alcançada para incentivar o jogador a tentar superar seu próprio recorde.

## 11.6 Progressão de dificuldade

A dificuldade será aumentada gradualmente durante a partida.

Inicialmente, os obstáculos terão uma velocidade e frequência menores. Com o passar do tempo, esses valores serão aumentados, exigindo maior atenção e tempo de reação do jogador.

A progressão será simples e automática, evitando a necessidade de criação de várias fases.

## 11.7 Cenas

O projeto contará inicialmente com pelo menos duas cenas:

**Cena 1 — Menu Principal**

* Nome do jogo;
* Botão para iniciar a partida;
* Botão para sair do jogo.

**Cena 2 — Gameplay**

* Personagem;
* Obstáculos;
* Pontuação;
* Área de jogo;
* Sistema de colisão;
* Game Over;
* Opção para reiniciar a partida.

## 11.8 Interface

A interface será simples e funcional, apresentando as informações necessárias para o jogador.

Durante a partida será exibida a pontuação atual. Após a derrota, será exibida uma tela de Game Over com a pontuação obtida e uma opção para reiniciar.

## 11.9 Direção visual

A direção visual será baseada em um estilo 2D simples e colorido, com formas e elementos fáceis de identificar.

O personagem, os obstáculos e os elementos principais da interface terão uma identidade visual própria. O cenário será simples para não prejudicar a visualização dos obstáculos durante a partida.

## 11.10 Áudio

O jogo contará com efeitos sonoros básicos para eventos importantes, como:

* Início da partida;
* Colisão;
* Game Over;
* Interações com a interface.

Também será utilizada uma música ou ambientação sonora durante o gameplay, caso seja possível dentro do cronograma.

## 11.11 Animações

Serão utilizadas animações simples para dar maior vida ao personagem e aos elementos do jogo.

Inicialmente estão previstas animações básicas, como movimento do personagem e possíveis efeitos visuais relacionados aos obstáculos ou à colisão.

## 11.12 Tecnologia

O projeto será desenvolvido utilizando:

* **Engine:** Unity;
* **Linguagem:** C#;
* **Plataforma-alvo:** Windows;
* **Controle:** teclado;
* **Versionamento:** Git e GitHub.

## 11.13 Critérios para considerar o jogo funcional

O protótipo será considerado funcional quando for possível:

1. Iniciar o jogo pelo menu;
2. Controlar o personagem;
3. Gerar e movimentar obstáculos;
4. Detectar colisões;
5. Encerrar a partida após uma colisão;
6. Exibir a pontuação;
7. Aumentar progressivamente a dificuldade;
8. Exibir a tela de Game Over;
9. Reiniciar uma nova partida;
10. Executar o jogo corretamente em Windows.
