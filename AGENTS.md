# GOD SLASHER — instruções de desenvolvimento

## Escopo e prioridades permanentes
Projeto Unreal Engine 5.7.4, C++ e Blueprints, universo Kamigami no Hakaimono.
1. Movimentação extremamente responsiva e fluida.
2. Combate elemental com combinações de magias.
3. Mira precisa em terceira pessoa.
4. C++ modular com Blueprints para ajustes.
5. Arquitetura preparada para multiplayer autoritativo.
6. Preservação do universo Kamigami no Hakaimono.

## Antes de editar
- Ler estas instruções, Docs/ e instruções mais específicas nos diretórios afetados.
- Inspecionar a estrutura real, `.uproject`, módulos, targets, configurações, classes e assets. Nunca inventar nomes de arquivos/classes ou presumir que variantes estão ativas.
- Conferir `git status --short --branch`, remoto, diff e arquivos já preparados no índice. Preservar trabalho do usuário.
- A fase atual é organização e validação da base. Não implementar novas mecânicas sem uma nova solicitação.
- O protótipo web anterior não é o projeto Unreal. Não copiar sua arquitetura ou assumir que suas mecânicas já foram migradas.

## Preservação e Git
- Não apagar arquivos existentes, usar git reset, git clean, force push ou reescrever histórico. Solicitar confirmação antes de qualquer operação com possibilidade de perda de dados.
- Não publicar, fazer push, criar PR ou alterar o remoto automaticamente.
- Não recriar o repositório: ele já existe e tem commit inicial.
- `.uasset` e `.umap` usam Git LFS. Verificar os atributos efetivos; não converter binários em texto ou editar seus bytes manualmente.
- Não versionar Binaries, Intermediate, Saved, DerivedDataCache, caches de IDE, temporários ou backups locais. Não excluir fisicamente esses diretórios para 'limpar' o Git.
- Não ignorar Source, Config, Content, Build, Plugins ou descritores de projeto indiscriminadamente. Dependências de plugins binários exigem revisão específica antes de decidir distribuição.
- Preparar somente os arquivos desta tarefa, com caminhos explícitos. Revisar diff e índice antes de qualquer commit. Não misturar alterações de outras tarefas.

## Implementação futura
- Reutilizar classes/componentes existentes quando adequado. Documentar a escolha entre as variantes antes de consolidá-las; nunca removê-las automaticamente.
- Colocar regras e estado de gameplay em C++ modular. Expor parâmetros e hooks apropriados para ajustes em Blueprints.
- Planejar autoridade do servidor para dano, recursos, cooldowns e validação de ações. Considerar prediction/reconciliation do movimento; não apresentar a existência de ACharacter como prova de multiplayer concluído.
- Não alterar referências de assets, EngineAssociation, mapas padrão ou plugins sem entender dependências e registrar a necessidade.
- Preservar nomes e regras canônicas do universo. Distinguir lore confirmado, proposta e conteúdo provisório; não inventar cânone para preencher lacunas.

## Validação e entrega
- Executar a compilação do target real God_SlasherEditor, Win64, Development, quando Unreal e toolchain estiverem disponíveis. Instruções em Docs/COMPILACAO_E_REVISAO.md.
- Verificar Blueprints, bindings de Enhanced Input e World Settings no Editor. Inspeção de nomes/ponteiros LFS não equivale a abrir o asset.
- Relatar arquivos alterados, testes realmente executados, falhas e próximos passos. Nunca afirmar compilação, teste de rede ou teste no Editor sem executá-lo.
