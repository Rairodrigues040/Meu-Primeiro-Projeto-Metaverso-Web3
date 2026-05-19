================================================================
         MEU PRIMEIRO AMBIENTE VR - Quintal de uma Casa no Campo
================================================================

Autor:    Raí Rodrigues
Trilha:   1
Curso:    Residência em TIC 29 - Web 3.0
Projeto:  [T1] Atividade 3 de 3 - Metaverso - Projeto "Meu Primeiro Ambiente VR"

----------------------------------------------------------------
DESCRIÇÃO
----------------------------------------------------------------

Este projeto recria o quintal de uma casa no campo em Realidade
Virtual, desenvolvido com Unity e Meta XR SDK.

A inspiração veio da vivência com família no interior, buscando
trazer um ambiente rural autêntico e imersivo para o mundo VR.

Além da ambientação 3D, o projeto possui interação com objetos
do cenário. O usuário pode pegar frutas espalhadas pelo ambiente
utilizando as mãos virtuais do Meta XR Simulator ou do Meta Quest.
Ao pegar as frutas, um som é reproduzido em tempo real utilizando
scripts em C#, aumentando a sensação de imersão da experiência VR.

----------------------------------------------------------------
ELEMENTOS DA CENA
----------------------------------------------------------------

- Animais espalhados pelo quintal
- Campos de flores e matos
- Árvores
- Mesa com frutas interativas
- Casa com estilo rústico
- Plano de chão (terreno do quintal/grama)
- Skybox de ambiente externo/céu

----------------------------------------------------------------
INTERAÇÃO IMPLEMENTADA
----------------------------------------------------------------

Foi implementada uma interação funcional utilizando C# e o
Meta XR SDK.

As frutas do cenário podem ser seguradas pelo jogador tanto
de perto quanto à distância utilizando o sistema de interação
das mãos virtuais do Meta XR.

Quando a fruta é pega:
- o sistema detecta a interação do jogador;
- um som é emitido utilizando AudioSource;
- uma mensagem é exibida no Console da Unity para fins de teste.

A lógica foi implementada utilizando:
- Grabbable (Meta XR SDK)
- AudioSource
- Scripts C#

----------------------------------------------------------------
EXPLICAÇÃO DO SCRIPT C#
----------------------------------------------------------------

O script "FrutaInteracao.cs" foi criado para detectar quando
uma fruta é segurada pelo jogador.

Funcionamento da lógica:
- O método Start() busca os componentes AudioSource e Grabbable;
- O Update() monitora continuamente se a fruta está sendo segurada;
- Quando a fruta é pega, o método AoPegarFruta() é chamado;
- O método reproduz o som configurado no AudioSource;
- Uma mensagem é enviada ao Console da Unity para depuração.

A variável booleana "jaPegou" impede que o som seja reproduzido
várias vezes continuamente enquanto a fruta permanece segurada.

----------------------------------------------------------------
TECNOLOGIAS UTILIZADAS
----------------------------------------------------------------

- Unity (versão compatível com Meta XR SDK)
- Meta XR SDK
- Oculus Interaction SDK
- Plataforma alvo: Android (Meta Quest)
- Movimentação via teclado/mouse no PC (Unity Editor)

----------------------------------------------------------------
COMO EXECUTAR O PROJETO
----------------------------------------------------------------

1. Clone ou baixe o repositório
2. Abra o projeto no Unity Hub
3. Certifique-se de que o Meta XR SDK está instalado
4. Abra a cena principal em: Assets/Scenes/
5. Pressione Play no Unity Editor para explorar o ambiente

Movimentação:
- W / A / S / D → movimentação
- Mouse → rotação da câmera

Interação:
- Aproximar a mão virtual da fruta
- Segurar a fruta utilizando o sistema de grab
- O som será reproduzido automaticamente

----------------------------------------------------------------
ESTRUTURA DE PASTAS
----------------------------------------------------------------

Assets/
  ├── ithappy/         → Assets do pacote ithappy
  ├── Modelos 3D/      → Modelos 3D utilizados
  ├── Oculus/          → Integração Meta XR SDK
  ├── Scenes/          → Cena principal
  ├── Scripts/         → Scripts C#
  ├── Skybox/          → Skybox e materiais
  ├── Audio/           → Som utilizado
  ├── Texturas/        → Texturas utilizadas
  └── XR/              → Configurações XR

ProjectSettings/
Packages/

----------------------------------------------------------------
CONFIGURAÇÕES DE BUILD
----------------------------------------------------------------

- Plataforma: Android (Meta Quest)
- XR Plugin Management: habilitado
- Meta XR SDK: configurado

----------------------------------------------------------------
PROCESSO DE CRIAÇÃO E DIFICULDADES
----------------------------------------------------------------

Durante o desenvolvimento do projeto, uma das principais
dificuldades foi configurar corretamente o sistema de interação
do Meta XR SDK para permitir que os objetos emitiseem som ao ser segurados.

Também foi necessário compreender:
- reprodução de áudio em objetos 3D;
- comunicação entre scripts e componentes da Unity.

----------------------------------------------------------------
REFLEXÃO SOBRE O APRENDIZADO
----------------------------------------------------------------

Este projeto permitiu compreender na prática conceitos
fundamentais de desenvolvimento XR com Unity, como:
- interação em VR;
- manipulação de objetos;
- organização de cenas 3D;
- uso de scripts C#;
- integração com Meta XR SDK.

Além do aprendizado técnico, o projeto também demonstrou
como experiências pessoais podem ser transformadas em
ambientes virtuais imersivos.