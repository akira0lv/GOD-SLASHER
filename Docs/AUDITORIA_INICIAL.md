# Auditoria inicial — 29/10/2026

## Evidência e alcance
Repositório: https://github.com/akira0lv/GOD-SLASHER
Commit inspecionado: e21074654c8dd23db182d4907b7f27d0bd94ece4 (`chore: estado inicial do God Slasher`).
Consulta remota da árvore completa e leitura dos 96 arquivos textuais de Source/, Config/, descritor e configurações da raiz. A captura do Windows mostra main sem alterações e acompanhando origin/main nesse commit. Isso não garante que a pasta permaneça sem alterações depois da captura.

O projeto real está em `E:\HD LEVI 1TB\Games\God Slasher\God_Slasher`. A pasta superior não é a raiz Git.
A captura confirma UnrealEditor.exe e Build.version 5.7.4 em `E:\Epic Games\UE5.7\UE_5.7`, Git 2.56.0.windows.3 e Git LFS 3.8.1.

## Estrutura e configurações
- Descritor: God_Slasher.uproject. Módulo Runtime God_Slasher, loading phase Default.
- EngineAssociation é um GUID de instalação local; não foi substituído por uma versão textual.
- Targets God_Slasher (Game) e God_SlasherEditor (Editor), BuildSettingsVersion.V6 e Unreal5_7.
- Dependências do módulo: Core, CoreUObject, Engine, InputCore, EnhancedInput, AIModule, StateTreeModule, GameplayStateTreeModule, UMG e Slate.
- Plugins declarados: ModelingToolsEditorMode (Editor), StateTree e GameplayStateTree.
- DefaultEngine.ini aponta mapa inicial e de jogo para /Game/ThirdPerson/Lvl_ThirdPerson e GameMode global para /Game/ThirdPerson/Blueprints/BP_ThirdPersonGameMode.
- EnhancedPlayerInput e EnhancedInputComponent são as classes de input configuradas.
- Render usa DX12/SM6, Lumen, virtual shadow maps, ray tracing e Substrate. Desempenho em hardware real não foi medido.
- Há entradas duplicadas de DefaultGraphicsRHI e AutoExposure. Foram registradas e preservadas; não são diagnóstico de falha de compilação.
- Há configuração Android File Server com token no arquivo versionado. O valor não é reproduzido aqui. Revisar necessidade e tratar a credencial conforme uso antes de distribuição; não houve alteração automática.

## Classes e componentes reais
AGod_SlasherCharacter deriva de ACharacter e é abstract. Usa cápsula, SkeletalMesh e CharacterMovement herdados, CameraBoom (USpringArmComponent) e FollowCamera (UCameraComponent). C++ define cápsula raio 42/meia altura 96, velocidade 500, JumpZVelocity 500 e AirControl 0,35. Esses valores podem ser sobrescritos em Blueprint; não medem a altura final do modelo.

AGod_SlasherGameMode deriva de AGameModeBase e tem construtor vazio. As atribuições efetivas de pawn/controller do Blueprint global precisam ser abertas no Editor.
AGod_SlasherPlayerController adiciona os arrays DefaultMappingContexts/MobileExcludedMappingContexts no subsistema Enhanced Input do jogador local, prioridade 0. Cria widget de controles touch quando aplicável.

Variantes já existentes, preservadas:
- Combat: ACombatCharacter, ACombatGameMode, ACombatPlayerController, IA com StateTree/EQS, interfaces de dano/ataque/ativação, notifies e UI. Character cria câmera com lag de posição/rotação e LifeBar. Há combo e ataque carregado; isso não equivale ao sistema elemental final.
- Platforming: APlatformingCharacter, APlatformingGameMode, APlatformingPlayerController e UAnimNotify_EndDash. O código já contém dash, double jump, wall jump e coyote time. Não foi integrado ou modificado nesta etapa.
- SideScrolling: character, game mode, player controller, camera manager, NPC/IA, plataformas e interações.

As três variantes de Character derivam diretamente de ACharacter, não de AGod_SlasherCharacter. O inventário completo de declarações com herança está em INVENTARIO_CPP.md.

## Input Actions e Mapping Contexts
Arquivos identificados na árvore remota (nome não comprova bindings internos):
- Content/Input/Actions: IA_Jump, IA_Look, IA_MouseLook, IA_Move.
- Content/Input: IMC_Default, IMC_MouseLook.
- Content/Variant_Combat/Input/Actions: IA_ChargedAttack, IA_ComboAttack, IA_ToggleCameraSide; contexto IMC_Combat na pasta Input.
- Content/Variant_Platforming/Input/Actions: IA_Dash; contexto IMC_Platforming.
- Content/Variant_SideScrolling/Input/Actions: IA_Drop, IA_Interact, IA_Mover; contexto IMC_SideScroller.

O C++ base vincula JumpAction Started/Completed a Jump/StopJumping; MoveAction, MouseLookAction e LookAction usam Triggered. Os ponteiros são configuráveis em Blueprint. Teclas, modifiers, triggers internos, assets atribuídos e overrides por mapa aguardam inspeção no Editor. Não se assumiu que IMC_Combat ou IA_Dash estejam ativos no mapa padrão.

## Git, LFS e organização
- Remoto origin: https://github.com/akira0lv/GOD-SLASHER.git. O primeiro commit já existe; a próxima alteração é um commit de organização.
- .gitattributes contém as regras corretas para *.uasset e *.umap: filter=lfs diff=lfs merge=lfs -text. Mantido sem alteração.
- Nenhum caminho Binaries/, Intermediate/, Saved/, DerivedDataCache/ ou .vs/ aparece na árvore versionada consultada.
- .gitignore existente já exclui essas pastas. O patch acrescenta temporários, caches e /Backup/, sem apagar arquivos.
- AGENTS.md e Docs/ estavam ausentes na árvore remota.
- Os binários da árvore têm tamanho compatível com ponteiros LFS. A disponibilidade e a integridade de todos os objetos LFS não foram validadas neste ambiente.

## Compilação e limites
Não compilado nesta sessão: o ambiente de execução é Linux, não tem a instalação Unreal do disco E:, UnrealEditor/UnrealBuildTool disponíveis no PATH ou toolchain Win64 confirmado. O .vsconfig declara componentes C++ e SDK, mas não prova que estejam instalados.
Não foram executados Unreal Header Tool, build C++, compilação de Blueprints, PIE, cook ou testes multiplayer. A confirmação requer a execução local documentada em COMPILACAO_E_REVISAO.md.
Busca textual não encontrou HasAuthority, RPCs Server/NetMulticast, Replicated ou GetLifetimeReplicatedProps no Source examinado. Isso não exclui funções de rede herdadas do engine nem lógica de Blueprints; multiplayer autoritativo de combate ainda não foi demonstrado.

## Alterações preparadas
Somente .gitignore, AGENTS.md e documentação Docs/. Nenhuma mecânica, configuração de gameplay, referência binária, engine association ou histórico foi alterado. Nada publicado no GitHub. O patch é aplicável localmente após git apply --check; alterações concorrentes ou arquivos já existentes podem impedir aplicação e devem ser conciliados, nunca sobrescritos à força.
