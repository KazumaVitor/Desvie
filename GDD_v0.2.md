# GDD – Desvie!

**Versão:** 0.2
**Nome do projeto:** Desvie!
**Gênero:** Ação / Arcade / Casual 2D
**Plataforma:** PC / Windows
**Engine:** Unity
**Linguagem:** C#
**Controle:** Teclado
**Desenvolvedor:** Vítor Tetsuya Kazuma

---

# 1. Visão Geral

**Desvie!** é um jogo 2D de ação e arcade baseado em reflexos, movimentação e desvio de obstáculos.

O jogador controla um personagem simples e deve atravessar três fases, desviando dos obstáculos presentes no cenário. A dificuldade aumenta progressivamente a cada fase.

A versão 0.2 acrescenta ao projeto a definição da **direção visual**, **identidade visual**, **planejamento dos sprites e animações**, **conceitos de cenário** e **level design das três fases**.

---

# 2. High Concept

Controlar um personagem em um cenário 2D, desviando de obstáculos e utilizando reflexos e movimentação para chegar ao final de cada fase.

Ao completar uma fase, o jogador recebe pontuação e desbloqueia a próxima fase, que apresenta desafios maiores.

O objetivo final é completar as três fases e obter a maior pontuação possível.

---

# 3. Gameplay

O jogador controla o personagem utilizando o teclado.

A principal ação consiste em movimentar o personagem para evitar obstáculos e alcançar a área de conclusão da fase.

### Controles planejados

* **A / Seta para esquerda:** movimentar para a esquerda;
* **D / Seta para direita:** movimentar para a direita.

Dependendo da implementação final, outros controles poderão ser adicionados.

---

# 4. Personagem Principal

O personagem será representado por um **humanoide simples e sem nome**.

A escolha por um personagem simples tem como objetivo facilitar a produção dos sprites e permitir que o foco do jogo permaneça na movimentação e no desvio dos obstáculos.

### Características visuais

* Corpo humanoide simples;
* Silhueta facilmente reconhecível;
* Poucos detalhes;
* Formas geométricas simples;
* Design adequado para um jogo 2D;
* Fácil reprodução como sprite dentro da Unity.

### Model Sheet

O model sheet deverá apresentar o personagem nas seguintes posições:

* Frente;
* Costas;
* Lado esquerdo;
* Lado direito.

As vistas laterais devem apresentar corretamente a orientação do personagem para facilitar a produção dos sprites.

---

# 5. Direção Visual

A direção visual de **Desvie!** será simples, colorida e objetiva.

O jogo utilizará elementos visuais com formas simples para facilitar a produção e manter uma identidade consistente.

### Características

* Estilo 2D;
* Visual minimalista;
* Cores contrastantes;
* Formas geométricas;
* Poucos detalhes;
* Cenários simples;
* Obstáculos facilmente identificáveis;
* Interface limpa.

A prioridade visual será a **clareza do gameplay**, permitindo que o jogador identifique rapidamente o personagem, os obstáculos e o caminho da fase.

---

# 6. Identidade Visual

A identidade visual será baseada em um estilo arcade simples.

Os elementos principais deverão possuir aparência facilmente reconhecível.

### Elementos da identidade

**Personagem:** humanoide simples e de fácil identificação.

**Obstáculos:** formas geométricas como blocos, barreiras e objetos pontiagudos.

**Cenário:** ambientes simples, com poucos elementos decorativos.

**Área de chegada:** elemento visual destacado para indicar ao jogador onde termina a fase.

**Interface:** textos e indicadores simples, priorizando a leitura rápida.

---

# 7. Concept Art

O concept art deverá representar os principais elementos visuais que serão utilizados no jogo.

### Elementos planejados

1. Personagem principal;
2. Obstáculos;
3. Área de chegada;
4. Cenário;
5. Elementos básicos da interface.

O concept art terá como objetivo definir previamente a aparência dos elementos antes da implementação na Unity.

---

# 8. Planejamento dos Sprites

Os sprites serão produzidos de forma simples para manter o projeto dentro do escopo definido.

### Sprites do personagem

* Idle/parado;
* Movimento para esquerda;
* Movimento para direita;
* Animação de derrota.

### Sprites dos obstáculos

* Bloco;
* Barreira;
* Espinho;
* Obstáculo móvel.

### Sprites do cenário

* Piso;
* Paredes;
* Plataformas;
* Área de chegada;
* Elementos decorativos simples.

---

# 9. Planejamento das Animações

As animações previstas para o personagem são:

### Idle

Pequena animação enquanto o personagem permanece parado.

### Movimento

Animação utilizada durante a movimentação do personagem.

### Movimento para esquerda

Sprite ou animação com orientação para o lado esquerdo.

### Movimento para direita

Sprite ou animação com orientação para o lado direito.

### Derrota

Animação simples utilizada quando o personagem colide com um obstáculo.

Caso o tempo de desenvolvimento seja limitado, algumas animações poderão ser simplificadas.

---

# 10. Conceito de Cenário

O cenário será composto por uma área principal de movimentação, onde os obstáculos serão distribuídos de acordo com a dificuldade de cada fase.

A estrutura visual deverá permitir que o jogador identifique claramente:

* Área de movimentação;
* Obstáculos;
* Limites do cenário;
* Caminho disponível;
* Área de chegada.

O cenário será simples para evitar excesso de elementos visuais que possam atrapalhar a leitura dos obstáculos.

---

# 11. Level Design

O level design foi planejado para apresentar uma progressão gradual de dificuldade.

As três fases seguem a seguinte estrutura:

**Fase 1 → Introdução**
↓
**Fase 2 → Desenvolvimento**
↓
**Fase 3 → Desafio Final**

Cada fase introduz ou aumenta a quantidade, velocidade, proximidade ou complexidade dos obstáculos.

---

# 12. Fase 1 – Introdução

A primeira fase será utilizada para apresentar ao jogador as mecânicas básicas.

### Características

* Poucos obstáculos;
* Espaços maiores para movimentação;
* Obstáculos simples;
* Padrões fáceis de entender;
* Baixa dificuldade;
* Caminho relativamente aberto.

### Objetivo

Ensinar o jogador a:

* Movimentar o personagem;
* Identificar obstáculos;
* Realizar desvios;
* Alcançar a área de chegada.

### Recompensa

Ao completar a fase:

* Pontuação é registrada;
* Fase 2 é desbloqueada.

---

# 13. Fase 2 – Desenvolvimento

A segunda fase aumenta o nível de desafio apresentado ao jogador.

### Características

* Maior quantidade de obstáculos;
* Espaços menores para movimentação;
* Obstáculos mais próximos;
* Maior necessidade de atenção;
* Possibilidade de obstáculos móveis;
* Padrões mais variados.

### Objetivo

Exigir maior precisão e tempo de reação do jogador.

### Recompensa

Ao completar a fase:

* Pontuação é registrada;
* Fase 3 é desbloqueada.

---

# 14. Fase 3 – Desafio Final

A terceira fase será o maior desafio do jogo.

### Características

* Maior quantidade de obstáculos;
* Caminhos mais estreitos;
* Obstáculos móveis;
* Padrões mais complexos;
* Menor espaço para erros;
* Maior exigência de reflexo e precisão.

### Objetivo

Utilizar tudo que foi aprendido nas fases anteriores para chegar ao final.

### Recompensa

Ao completar a fase:

* Pontuação final;
* Tela de conclusão;
* Indicação de que o jogo foi finalizado.

---

# 15. Progressão dos Desafios

A dificuldade será aumentada gradualmente.

| Elemento                 | Fase 1           | Fase 2    | Fase 3    |
| ------------------------ | ---------------- | --------- | --------- |
| Quantidade de obstáculos | Baixa            | Média     | Alta      |
| Espaço disponível        | Grande           | Médio     | Pequeno   |
| Complexidade             | Baixa            | Média     | Alta      |
| Obstáculos móveis        | Poucos ou nenhum | Possíveis | Presentes |
| Padrões                  | Simples          | Variados  | Complexos |
| Precisão necessária      | Baixa            | Média     | Alta      |
| Dificuldade              | Fácil            | Média     | Difícil   |

A progressão tem como objetivo evitar que o jogador encontre uma dificuldade elevada logo no início.

---

# 16. Mapa / Sketch das Fases

O planejamento das fases seguirá uma estrutura simples.

### Fase 1

```text
┌───────────────────────────┐
│                           │
│        OBSTÁCULO          │
│                           │
│    ↓       ↓       ↓      │
│                           │
│        PERSONAGEM         │
│                           │
│                           │
│             →             │
│                       🏁  │
└───────────────────────────┘
```

**Objetivo:** apresentar o funcionamento básico do jogo.

### Fase 2

```text
┌───────────────────────────┐
│      ↓       ↓            │
│                           │
│  ███          ███         │
│                           │
│        ↓   ↓              │
│                           │
│    PERSONAGEM             │
│                           │
│        ███       →   🏁   │
└───────────────────────────┘
```

**Objetivo:** aumentar a quantidade de obstáculos e reduzir os espaços disponíveis.

### Fase 3

```text
┌───────────────────────────┐
│  ↓   ███   ↓   ███        │
│                           │
│      ↓       ↓            │
│ ███                   ███ │
│                           │
│       PERSONAGEM          │
│                           │
│   ███   ↓   ███   ↓      │
│                       🏁  │
└───────────────────────────┘
```

**Objetivo:** apresentar o maior nível de desafio, utilizando obstáculos em posições variadas e espaços mais estreitos.

---

# 17. Core Loop

O core loop definido na versão 0.1 permanece como base do projeto:

**Iniciar fase → movimentar personagem → observar obstáculos → desviar → chegar ao final → receber recompensa → avançar para a próxima fase → enfrentar desafio maior.**

Esse ciclo se repete até que o jogador complete as três fases ou seja derrotado e precise reiniciar.

---

# 18. Sistema de Recompensa

O sistema de recompensa também permanece definido na versão 0.1.

### Recompensas principais

* Pontuação;
* Desbloqueio da próxima fase;
* Mensagem de conclusão;
* Pontuação final ao terminar a terceira fase.

A progressão pode ser representada da seguinte forma:

**Desafio → Vitória → Pontuação → Desbloqueio → Novo desafio**

---

# 19. Interface

A interface deverá apresentar informações essenciais ao jogador.

### Menu principal

* Nome do jogo;
* Botão iniciar;
* Botão sair.

### Durante a fase

* Número da fase;
* Pontuação.

### Game Over

* Mensagem de derrota;
* Pontuação;
* Botão para reiniciar.

### Conclusão da fase

* Mensagem de fase concluída;
* Pontuação;
* Opção para continuar.

### Final do jogo

* Mensagem de conclusão;
* Pontuação final;
* Opção para reiniciar ou voltar ao menu.

---

# 20. Fluxo de Gameplay

```text
MENU
  ↓
INICIAR
  ↓
FASE 1
  ↓
DESVIAR DOS OBSTÁCULOS
  ↓
┌───────────────┐
│               │
DERROTA       VITÓRIA
│               │
↓               ↓
REINICIAR     PONTUAÇÃO
                ↓
          DESBLOQUEAR FASE 2
                ↓
              FASE 2
                ↓
             DESVIAR
                ↓
          DESBLOQUEAR FASE 3
                ↓
              FASE 3
                ↓
             DESVIAR
                ↓
          PONTUAÇÃO FINAL
                ↓
           JOGO CONCLUÍDO
```

---

# 21. Áudio

O áudio será simples e terá como objetivo fornecer feedback ao jogador.

### Efeitos sonoros planejados

* Seleção de botão;
* Início da fase;
* Colisão;
* Derrota;
* Conclusão da fase;
* Conclusão do jogo.

Também poderá ser utilizada uma música de fundo simples, caso o tempo de desenvolvimento permita.

---

# 22. Tecnologia

* **Engine:** Unity;
* **Versão:** Unity 2D;
* **Linguagem:** C#;
* **Plataforma:** Windows;
* **Controle:** Teclado;
* **Versionamento:** Git;
* **Repositório:** GitHub.

---

# 23. Escopo da Versão 0.2

A versão 0.2 acrescenta ao projeto:

* Definição da direção visual;
* Identidade visual;
* Concept art;
* Model sheet do personagem;
* Planejamento dos sprites;
* Planejamento das animações;
* Conceito de cenário;
* Level design das três fases;
* Mapa/sketch das fases;
* Progressão dos desafios;
* Planejamento da interface;
* Definição visual dos obstáculos.

A implementação completa desses elementos será realizada nas próximas versões do projeto.

---

# 24. O que não faz parte do escopo

Para manter o projeto simples e viável dentro do prazo, não estão previstos:

* Multiplayer;
* Sistema online;
* Loja;
* Inventário;
* Vários personagens;
* Sistema de equipamentos;
* Mundo aberto;
* História extensa;
* Chefes complexos;
* Habilidades complexas;
* Sistemas avançados de progressão.

---

# 25. Critérios de Level Design

As fases deverão seguir alguns princípios:

1. A primeira fase deve ser fácil de compreender;
2. Os obstáculos devem ser visualmente identificáveis;
3. O jogador deve possuir espaço suficiente para realizar os desvios;
4. A dificuldade deve aumentar progressivamente;
5. A fase 2 deve exigir mais atenção que a fase 1;
6. A fase 3 deve representar o maior desafio;
7. A área de chegada deve ser visualmente destacada;
8. Os obstáculos não devem bloquear completamente o caminho sem possibilidade de desvio;
9. O cenário não deve possuir elementos decorativos que prejudiquem a leitura dos obstáculos;
10. O jogador deve conseguir entender visualmente o caminho da fase.

---

# 26. Critérios Visuais

Os elementos gráficos devem:

* Ser simples de produzir;
* Possuir boa leitura em tela;
* Utilizar formas facilmente reconhecíveis;
* Manter uma identidade visual consistente;
* Diferenciar personagem e obstáculos;
* Facilitar a identificação da área de chegada;
* Ser adequados para implementação como sprites 2D.

---

# 27. Referências

As referências utilizadas para o projeto são jogos 2D de arcade, reflexo e desvio de obstáculos.

As referências serão utilizadas principalmente para observar:

* Movimentação;
* Organização dos obstáculos;
* Progressão de dificuldade;
* Organização das fases;
* Interface;
* Sistema de pontuação;
* Feedback visual;
* Feedback sonoro.

As referências servem como inspiração para o projeto, sem reprodução direta de personagens, cenários ou elementos protegidos.

---

# 28. Atualizações da Versão 0.2

Em relação à versão 0.1, esta versão apresenta maior detalhamento da direção visual e do level design.

### Principais atualizações

* Definição da identidade visual;
* Definição do estilo gráfico 2D;
* Planejamento do personagem;
* Model sheet;
* Planejamento dos sprites;
* Planejamento das animações;
* Conceito dos cenários;
* Planejamento das três fases;
* Sketch das fases;
* Progressão visual e de dificuldade;
* Definição dos tipos de obstáculos;
* Planejamento da interface;
* Detalhamento do fluxo de gameplay.

A estrutura principal do jogo, incluindo o core loop, sistema de recompensa e três fases, permanece definida desde a versão 0.1.

---

# 29. Resumo da Versão 0.2

**Desvie!** possui agora uma direção visual e um planejamento de level design definidos.

O jogo será desenvolvido em 2D, utilizando uma identidade visual simples e objetiva, com um personagem humanoide sem nome, obstáculos geométricos e cenários minimalistas.

O level design será dividido em três fases:

**Fase 1:** introdução e aprendizado.
**Fase 2:** aumento da quantidade e complexidade dos obstáculos.
**Fase 3:** desafio final com maior exigência de reflexo e precisão.

O projeto mantém como base o seguinte core loop:

**Iniciar → Desviar → Chegar ao final → Receber recompensa → Avançar → Enfrentar novo desafio.**

A principal recompensa será composta por **pontuação e desbloqueio da próxima fase**.

A versão 0.2 estabelece a base visual e estrutural necessária para iniciar a implementação do protótipo jogável na versão 0.3.
