# Plano de desenvolvimento

Prioridades permanentes, nesta ordem: movimento responsivo e fluido; combate elemental e combinações; mira precisa em terceira pessoa; C++ modular com ajustes em Blueprints; multiplayer autoritativo; preservação de Kamigami no Hakaimono.

## Etapa atual — organização
1. Aplicar e revisar o patch de documentação/ignore.
2. Confirmar objetos LFS locais, compilação Development Editor e abertura do mapa padrão.
3. Inspecionar BP_ThirdPersonGameMode, Default Pawn, PlayerController e World Settings; registrar caminhos e classes efetivas.
4. Abrir IA/IMC, mesh, AnimBlueprint, montages e notifies usados pelo pawn efetivo. Registrar teclas e overrides reais.
5. Revisar diff e preparar commit de organização, sem publicar automaticamente.

## Depois de uma nova autorização para mecânicas
- Escolher a base de personagem após comparar ThirdPerson, Combat e Platforming. Não eliminar variantes por conveniência.
- Medir resposta de movimento e mira; definir critérios de aceitação antes de alterar parâmetros.
- Projetar estado de movimento e regras elementais em componentes C++, parâmetros em Blueprints e autoridade do servidor.
- Implementar incrementalmente, com playtests, validação de colisão/câmera e testes em rede. Não prometer multiplayer apenas pela escolha de ACharacter.
- Usar documentação canônica fornecida pelo autor para elementos, combinações, nomes e progressão. Registrar propostas separadamente do cânone.

Wall-run/wall-jump não são prioridade da próxima rodada básica. Wall-jump já existe na variante Platforming e deve ser preservado, sem integração automática.
