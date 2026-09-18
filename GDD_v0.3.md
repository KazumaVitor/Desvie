# GDD — Desvie!

## Versão 0.3 — Protótipo Jogável

**Nome do projeto:** Desvie!
**Versão:** v0.3
**Gênero:** Jogo 2D / Ação / Desvio de obstáculos
**Plataforma:** PC / Windows
**Engine:** Unity
**Linguagem:** C#

---

## 1. Conceito do Jogo

**Desvie!** é um jogo 2D simples em que o jogador controla um personagem dentro de uma área limitada. O objetivo é movimentar o personagem, desviar dos obstáculos e chegar até a área de finalização sem colidir.

Caso o personagem colida com um obstáculo, a partida termina com uma condição de derrota. Caso consiga chegar ao final da fase, uma mensagem de vitória é apresentada.

---

## 2. Objetivo do Jogador

O objetivo principal é:

**Movimentar → Desviar → Sobreviver → Chegar ao final → Vencer**

O jogador deve utilizar os controles de movimento para atravessar a área e evitar os obstáculos presentes no cenário.

---

## 3. Controles

O personagem pode ser movimentado utilizando:

* **W** ou **Seta para cima:** movimentar para cima;
* **S** ou **Seta para baixo:** movimentar para baixo;
* **A** ou **Seta para esquerda:** movimentar para a esquerda;
* **D** ou **Seta para direita:** movimentar para a direita.

---

## 4. Mecânica Principal

A principal mecânica do jogo é o **desvio de obstáculos**.

O jogador deve observar a posição dos obstáculos e escolher um caminho para atravessar o cenário sem colidir.

O personagem possui movimentação em quatro direções, permitindo maior liberdade para navegar pela área jogável.

---

## 5. Obstáculos

Foram implementados obstáculos no cenário utilizando objetos 2D com colisores.

Os obstáculos funcionam como barreiras físicas que impedem o personagem de atravessar suas posições.

A colisão entre o jogador e um obstáculo ativa a condição de derrota.

---

## 6. Condição de Derrota

Quando o personagem colide com um obstáculo, o jogo apresenta a mensagem:

**DERROTA!**

Após a derrota, o jogo é interrompido para indicar o fim da tentativa atual.

---

## 7. Condição de Vitória

Foi criada uma área de finalização no cenário.

Quando o personagem entra na área de chegada, o jogo apresenta a mensagem:

**VITÓRIA!**

Após alcançar o final, a partida é interrompida, indicando que o objetivo da fase foi concluído.

---

## 8. Área Jogável

O cenário possui limites físicos em suas extremidades para impedir que o personagem saia da área de jogo.

Foram utilizadas paredes nas partes:

* Superior;
* Inferior;
* Esquerda;
* Direita.

Esses limites mantêm o jogador dentro do espaço destinado à fase.

---

## 9. Física e Colisões

O protótipo utiliza o sistema de física 2D da Unity.

Foram implementados:

* Rigidbody 2D no jogador;
* Box Collider 2D no jogador;
* Box Collider 2D nos obstáculos;
* Collider configurado como Trigger na área de finalização;
* Colisões entre jogador e obstáculos;
* Detecção de entrada na área de finalização.

---

## 10. Estrutura do Cenário

O cenário atual possui:

* **Player:** personagem controlado pelo jogador;
* **Obstacles:** grupo contendo os obstáculos;
* **Walls:** grupo contendo os limites da área;
* **Ground:** área inferior do cenário;
* **Finish:** área de chegada;
* **DefeatText:** mensagem de derrota;
* **VictoryText:** mensagem de vitória.

A hierarquia foi organizada para facilitar a manutenção do projeto.

---

## 11. Prefabs

Foram criados os primeiros Prefabs do projeto:

* **Player**
* **Obstacle**
* **Finish**

Os Prefabs permitem reutilizar os elementos no desenvolvimento das próximas versões do jogo.

---

## 12. Identidade Visual

O protótipo utiliza uma identidade visual simples e funcional, com diferentes cores para facilitar a identificação dos elementos:

* Personagem: azul;
* Obstáculos: vermelho;
* Área de chão: cinza/escura;
* Área de chegada: verde.

A proposta visual poderá ser refinada nas próximas versões.

---

## 13. Core Loop

O ciclo principal de gameplay é:

**Movimentar → Desviar dos obstáculos → Evitar colisões → Alcançar o final → Vitória**

Caso ocorra uma colisão:

**Movimentar → Colidir com obstáculo → Derrota**

---

## 14. Progressão Planejada

O projeto continuará utilizando três fases planejadas:

### Fase 1 — Introdução

Apresentação das mecânicas básicas e dos controles.

### Fase 2 — Desenvolvimento

Aumento da quantidade e da disposição dos obstáculos, exigindo maior atenção do jogador.

### Fase 3 — Desafio Final

Fase com maior concentração de obstáculos e maior dificuldade para concluir o percurso.

A implementação dessas fases será desenvolvida nas próximas versões do projeto.

---

## 15. Estado Atual do Protótipo

Na versão **v0.3**, o protótipo jogável possui:

* [x] Movimentação do personagem;
* [x] Controles em quatro direções;
* [x] Obstáculos;
* [x] Física 2D;
* [x] Colisões;
* [x] Condição de derrota;
* [x] Área de finalização;
* [x] Condição de vitória;
* [x] Limites da área jogável;
* [x] Primeiros Prefabs;
* [x] Hierarquia organizada.

---

## 16. Próximos Passos

Para as próximas versões, estão planejadas melhorias como:

* Implementação das três fases;
* Melhor organização do level design;
* Aumento gradual da dificuldade;
* Melhorias visuais;
* Animações do personagem;
* Aprimoramento da interface;
* Sistema de pontuação;
* Tela de conclusão;
* Ajustes de gameplay e balanceamento.

---

## 17. Versão

**v0.3 — Protótipo Jogável**

Esta versão representa a primeira versão funcional do jogo, contendo as principais mecânicas necessárias para testar o gameplay básico de **Desvie!**.
