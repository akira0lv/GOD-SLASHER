# Compilação e revisão local

Feche o Unreal Editor após salvar o trabalho para evitar conflito com Live Coding. Os comandos abaixo não fazem commit, push, reset, clean ou exclusão. A compilação gera/atualiza arquivos locais de build e logs.

## Verificar pré-requisitos

Abra PowerShell e execute:

```powershell
$projeto = 'E:\HD LEVI 1TB\Games\God Slasher\God_Slasher'
$ue = 'E:\Epic Games\UE5.7\UE_5.7'
Get-Content -LiteralPath "$ue\Engine\Build\Build.version"
Get-Content -LiteralPath "$projeto\Source\God_SlasherEditor.Target.cs"
Test-Path -LiteralPath "$ue\Engine\Build\BatchFiles\Build.bat"
git -C "$projeto" status --short --branch
git -C "$projeto" lfs ls-files
```

`git lfs ls-files` lista ponteiros/objetos locais; não demonstra upload completo. Se houver assets faltando, resolver a obtenção dos objetos antes do teste no Editor. Não rodar migração de histórico automaticamente.

## Compilar o target real

```powershell
& "$ue\Engine\Build\BatchFiles\Build.bat" God_SlasherEditor Win64 Development "-Project=$projeto\God_Slasher.uproject" -WaitMutex -NoHotReloadFromIDE
$buildExit = $LASTEXITCODE
Write-Host "Código de saída da compilação: $buildExit"
```

O target foi confirmado em Source/God_SlasherEditor.Target.cs. Código 0 é necessário para sucesso, mas não substitui abrir o Editor/compilar Blueprints. Se houver erro, preservar o log e diagnosticar a primeira causa; não apagar caches nem trocar engine/toolchain por tentativa.

## Verificação no Editor

Abrir God_Slasher.uproject, verificar mapa Lvl_ThirdPerson, GameMode e World Settings; compilar Blueprints relevantes; testar movimentação, câmera, salto e input existente em PIE. Registrar resultado, engine, toolchain e erros. Não alterar mecânicas nesta etapa.

## Revisar antes de preparar commit

```powershell
git -C "$projeto" diff --check
git -C "$projeto" diff -- .gitignore
git -C "$projeto" status --short
git -C "$projeto" ls-files -- Binaries Intermediate Saved DerivedDataCache .vs Backup
```

A última saída deve estar vazia. Se não estiver, investigar sem remover arquivos nem alterar o índice automaticamente.
Confirmar atributos de um asset real (substituir pelo caminho existente obtido com git ls-files '*.uasset'):

```powershell
git -C "$projeto" check-attr filter diff merge text -- Content/Input/Actions/IA_Jump.uasset
```

Esperado: filter/diff/merge=lfs, text=unset. Depois da revisão e das verificações locais:

```powershell
git -C "$projeto" add -- .gitignore AGENTS.md Docs/README.md Docs/AUDITORIA_INICIAL.md Docs/INVENTARIO_CPP.md Docs/COMPILACAO_E_REVISAO.md Docs/PLANO.md
git -C "$projeto" diff --cached --check
git -C "$projeto" diff --cached --stat
git -C "$projeto" diff --cached
```

Este documento não executa nenhum desses comandos. Revise também arquivos que já estavam no índice antes da tarefa. Título sugerido para um futuro commit: `chore: document Unreal baseline and development rules`. Não executar push automaticamente.
