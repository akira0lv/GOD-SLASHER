# Inventário C++

Declarações com herança extraídas dos headers no commit auditado. Forward declarations foram excluídas.

| Arquivo | Declaração |
|---|---|
| `Source/God_Slasher/God_SlasherCharacter.h` | `class AGod_SlasherCharacter : public ACharacter` |
| `Source/God_Slasher/God_SlasherGameMode.h` | `class AGod_SlasherGameMode : public AGameModeBase` |
| `Source/God_Slasher/God_SlasherPlayerController.h` | `class AGod_SlasherPlayerController : public APlayerController` |
| `Source/God_Slasher/Variant_Combat/AI/CombatAIController.h` | `class ACombatAIController : public AAIController` |
| `Source/God_Slasher/Variant_Combat/AI/CombatEnemy.h` | `class ACombatEnemy : public ACharacter, public ICombatAttacker, public ICombatDamageable` |
| `Source/God_Slasher/Variant_Combat/AI/CombatEnemySpawner.h` | `class ACombatEnemySpawner : public AActor, public ICombatActivatable` |
| `Source/God_Slasher/Variant_Combat/AI/CombatStateTreeUtility.h` | `struct FStateTreeCharacterGroundedCondition : public FStateTreeConditionCommonBase` |
| `Source/God_Slasher/Variant_Combat/AI/CombatStateTreeUtility.h` | `struct FStateTreeIsInDangerCondition : public FStateTreeConditionCommonBase` |
| `Source/God_Slasher/Variant_Combat/AI/CombatStateTreeUtility.h` | `struct FStateTreeComboAttackTask : public FStateTreeTaskCommonBase` |
| `Source/God_Slasher/Variant_Combat/AI/CombatStateTreeUtility.h` | `struct FStateTreeChargedAttackTask : public FStateTreeTaskCommonBase` |
| `Source/God_Slasher/Variant_Combat/AI/CombatStateTreeUtility.h` | `struct FStateTreeWaitForLandingTask : public FStateTreeTaskCommonBase` |
| `Source/God_Slasher/Variant_Combat/AI/CombatStateTreeUtility.h` | `struct FStateTreeFaceActorTask : public FStateTreeTaskCommonBase` |
| `Source/God_Slasher/Variant_Combat/AI/CombatStateTreeUtility.h` | `struct FStateTreeFaceLocationTask : public FStateTreeTaskCommonBase` |
| `Source/God_Slasher/Variant_Combat/AI/CombatStateTreeUtility.h` | `struct FStateTreeSetCharacterSpeedTask : public FStateTreeTaskCommonBase` |
| `Source/God_Slasher/Variant_Combat/AI/CombatStateTreeUtility.h` | `struct FStateTreeGetPlayerInfoTask : public FStateTreeTaskCommonBase` |
| `Source/God_Slasher/Variant_Combat/AI/EnvQueryContext_Danger.h` | `class GOD_SLASHER_API UEnvQueryContext_Danger : public UEnvQueryContext` |
| `Source/God_Slasher/Variant_Combat/AI/EnvQueryContext_Player.h` | `class UEnvQueryContext_Player : public UEnvQueryContext` |
| `Source/God_Slasher/Variant_Combat/Animation/AnimNotify_CheckChargedAttack.h` | `class UAnimNotify_CheckChargedAttack : public UAnimNotify` |
| `Source/God_Slasher/Variant_Combat/Animation/AnimNotify_CheckCombo.h` | `class UAnimNotify_CheckCombo : public UAnimNotify` |
| `Source/God_Slasher/Variant_Combat/Animation/AnimNotify_DoAttackTrace.h` | `class UAnimNotify_DoAttackTrace : public UAnimNotify` |
| `Source/God_Slasher/Variant_Combat/CombatCharacter.h` | `class ACombatCharacter : public ACharacter, public ICombatAttacker, public ICombatDamageable` |
| `Source/God_Slasher/Variant_Combat/CombatGameMode.h` | `class ACombatGameMode : public AGameModeBase` |
| `Source/God_Slasher/Variant_Combat/CombatPlayerController.h` | `class ACombatPlayerController : public APlayerController` |
| `Source/God_Slasher/Variant_Combat/Gameplay/CombatActivationVolume.h` | `class ACombatActivationVolume : public AActor` |
| `Source/God_Slasher/Variant_Combat/Gameplay/CombatCheckpointVolume.h` | `class ACombatCheckpointVolume : public AActor` |
| `Source/God_Slasher/Variant_Combat/Gameplay/CombatDamageableBox.h` | `class ACombatDamageableBox : public AActor, public ICombatDamageable` |
| `Source/God_Slasher/Variant_Combat/Gameplay/CombatDummy.h` | `class ACombatDummy : public AActor, public ICombatDamageable` |
| `Source/God_Slasher/Variant_Combat/Gameplay/CombatLavaFloor.h` | `class ACombatLavaFloor : public AActor` |
| `Source/God_Slasher/Variant_Combat/Interfaces/CombatActivatable.h` | `class UCombatActivatable : public UInterface` |
| `Source/God_Slasher/Variant_Combat/Interfaces/CombatAttacker.h` | `class UCombatAttacker : public UInterface` |
| `Source/God_Slasher/Variant_Combat/Interfaces/CombatDamageable.h` | `class UCombatDamageable : public UInterface` |
| `Source/God_Slasher/Variant_Combat/UI/CombatLifeBar.h` | `class UCombatLifeBar : public UUserWidget` |
| `Source/God_Slasher/Variant_Platforming/Animation/AnimNotify_EndDash.h` | `class UAnimNotify_EndDash : public UAnimNotify` |
| `Source/God_Slasher/Variant_Platforming/PlatformingCharacter.h` | `class APlatformingCharacter : public ACharacter` |
| `Source/God_Slasher/Variant_Platforming/PlatformingGameMode.h` | `class APlatformingGameMode : public AGameModeBase` |
| `Source/God_Slasher/Variant_Platforming/PlatformingPlayerController.h` | `class APlatformingPlayerController : public APlayerController` |
| `Source/God_Slasher/Variant_SideScrolling/AI/SideScrollingAIController.h` | `class ASideScrollingAIController : public AAIController` |
| `Source/God_Slasher/Variant_SideScrolling/AI/SideScrollingNPC.h` | `class ASideScrollingNPC : public ACharacter, public ISideScrollingInteractable` |
| `Source/God_Slasher/Variant_SideScrolling/AI/SideScrollingStateTreeUtility.h` | `struct FStateTreeGetPlayerTask : public FStateTreeTaskCommonBase` |
| `Source/God_Slasher/Variant_SideScrolling/Gameplay/SideScrollingJumpPad.h` | `class ASideScrollingJumpPad : public AActor` |
| `Source/God_Slasher/Variant_SideScrolling/Gameplay/SideScrollingMovingPlatform.h` | `class ASideScrollingMovingPlatform : public AActor, public ISideScrollingInteractable` |
| `Source/God_Slasher/Variant_SideScrolling/Gameplay/SideScrollingPickup.h` | `class ASideScrollingPickup : public AActor` |
| `Source/God_Slasher/Variant_SideScrolling/Gameplay/SideScrollingSoftPlatform.h` | `class ASideScrollingSoftPlatform : public AActor` |
| `Source/God_Slasher/Variant_SideScrolling/Interfaces/SideScrollingInteractable.h` | `class USideScrollingInteractable : public UInterface` |
| `Source/God_Slasher/Variant_SideScrolling/SideScrollingCameraManager.h` | `class ASideScrollingCameraManager : public APlayerCameraManager` |
| `Source/God_Slasher/Variant_SideScrolling/SideScrollingCharacter.h` | `class ASideScrollingCharacter : public ACharacter` |
| `Source/God_Slasher/Variant_SideScrolling/SideScrollingGameMode.h` | `class ASideScrollingGameMode : public AGameModeBase` |
| `Source/God_Slasher/Variant_SideScrolling/SideScrollingPlayerController.h` | `class ASideScrollingPlayerController : public APlayerController` |
| `Source/God_Slasher/Variant_SideScrolling/UI/SideScrollingUI.h` | `class USideScrollingUI : public UUserWidget` |
