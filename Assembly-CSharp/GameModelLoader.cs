//Type is in global namespace

public class GameModelLoader : IGameModelLoader
{
	private BindingFlags bindFlags; //Field offset: 0x10
	private BinaryReader br; //Field offset: 0x18
	private Object[] m; //Field offset: 0x20
	private int mIndex; //Field offset: 0x28

	public GameModelLoader() { }

	private void Create_Records() { }

	private void CreateArraySet() { }

	private void CreateDictionarySet() { }

	private void CreateListSet() { }

	private void LinkArray() { }

	private void LinkDictionary() { }

	private void LinkList() { }

	private void LinkModelDictionary() { }

	public override GameModel Load(Byte[] bytes) { }

	private void Read_a_AreaType_Array() { }

	private void Read_a_AudioClipReference_Array() { }

	private void Read_a_Bounds_Array() { }

	private void Read_a_Int32_Array() { }

	private void Read_a_Keyframe_Array() { }

	private void Read_a_PrefabReference_Array() { }

	private void Read_a_Single_Array() { }

	private void Read_a_SpriteReference_Array() { }

	private void Read_a_String_Array() { }

	private void Read_a_TargetType_Array() { }

	private void Read_a_TowerSet_Array() { }

	private void Read_a_TowerTypeImmunity_Array() { }

	private void Read_a_Vector3_Array() { }

	private void Read_String_v_Single_Dictionary() { }

	private void Set_v_AbilityBehaviorBuffModel_Fields(int start, int count) { }

	private void Set_v_AbilityBehaviorModel_Fields(int start, int count) { }

	private void Set_v_AbilityCooldownPercentageModModel_Fields(int start, int count) { }

	private void Set_v_AbilityCooldownScaleSupportModel_Fields(int start, int count) { }

	private void Set_v_AbilityCooldownTimeModModel_Fields(int start, int count) { }

	private void Set_v_AbilityCooldownZoneModel_Fields(int start, int count) { }

	private void Set_v_AbilityCreateTowerModel_Fields(int start, int count) { }

	private void Set_v_AbilityModel_Fields(int start, int count) { }

	private void Set_v_AbsorbTowerBuffsActionModel_Fields(int start, int count) { }

	private void Set_v_AccelerateModel_Fields(int start, int count) { }

	private void Set_v_AcidicMixtureCheckModel_Fields(int start, int count) { }

	private void Set_v_AcidicMixtureModel_Fields(int start, int count) { }

	private void Set_v_AcidPoolEmissionModel_Fields(int start, int count) { }

	private void Set_v_AcidPoolModel_Fields(int start, int count) { }

	private void Set_v_AcidPoolModModel_Fields(int start, int count) { }

	private void Set_v_ActivateAbilitiesOnAbilityModel_Fields(int start, int count) { }

	private void Set_v_ActivateAbilityAfterIntervalModel_Fields(int start, int count) { }

	private void Set_v_ActivateAttackCreateTowerPlacementModel_Fields(int start, int count) { }

	private void Set_v_ActivateAttackModel_Fields(int start, int count) { }

	private void Set_v_ActivateAttackModModel_Fields(int start, int count) { }

	private void Set_v_ActivateDamageModifierSupportZoneModel_Fields(int start, int count) { }

	private void Set_v_ActivatePierceSupportZoneModel_Fields(int start, int count) { }

	private void Set_v_ActivateRangeSupportZoneModel_Fields(int start, int count) { }

	private void Set_v_ActivateRateSupportZoneModel_Fields(int start, int count) { }

	private void Set_v_ActivateTempTargetPrioSupportZoneModel_Fields(int start, int count) { }

	private void Set_v_ActivateTowerDamageSupportZoneModel_Fields(int start, int count) { }

	private void Set_v_ActivateVisibilitySupportZoneModel_Fields(int start, int count) { }

	private void Set_v_AddAbilityToTowerModModel_Fields(int start, int count) { }

	private void Set_v_AddAcidicMixtureToProjectileModel_Fields(int start, int count) { }

	private void Set_v_AddAttackTowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_AddBehaviorModifierForTagModel_Fields(int start, int count) { }

	private void Set_v_AddBehaviorToBloonInZoneModel_Fields(int start, int count) { }

	private void Set_v_AddBehaviorToBloonModel_Fields(int start, int count) { }

	private void Set_v_AddBehaviorToTowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_AddBehaviorToTowerSupportModel_Fields(int start, int count) { }

	private void Set_v_AddBerserkerBrewToProjectileModel_Fields(int start, int count) { }

	private void Set_v_AddBonusDamagePerHitToBloonModel_Fields(int start, int count) { }

	private void Set_v_AddCorvusManaModel_Fields(int start, int count) { }

	private void Set_v_AddHeatActionModel_Fields(int start, int count) { }

	private void Set_v_AddHeatToBloonModel_Fields(int start, int count) { }

	private void Set_v_AddMakeshiftAreaModel_Fields(int start, int count) { }

	private void Set_v_AddSoundToShopMenuModel_Fields(int start, int count) { }

	private void Set_v_AddTagToBloonModel_Fields(int start, int count) { }

	private void Set_v_AdoraEmissionModel_Fields(int start, int count) { }

	private void Set_v_AdoraSunGodTransformationModel_Fields(int start, int count) { }

	private void Set_v_AdoraTrackTargetModel_Fields(int start, int count) { }

	private void Set_v_AdoraTransformSoundModel_Fields(int start, int count) { }

	private void Set_v_AgeingDestroyModel_Fields(int start, int count) { }

	private void Set_v_AgeModel_Fields(int start, int count) { }

	private void Set_v_AgeRandomModel_Fields(int start, int count) { }

	private void Set_v_AggressionModel_Fields(int start, int count) { }

	private void Set_v_AirUnitModel_Fields(int start, int count) { }

	private void Set_v_AlternateAnimationModel_Fields(int start, int count) { }

	private void Set_v_AlternateArcModModel_Fields(int start, int count) { }

	private void Set_v_AlternateProjectileModel_Fields(int start, int count) { }

	private void Set_v_AlternatingEjectEffectModel_Fields(int start, int count) { }

	private void Set_v_AmbushTechModel_Fields(int start, int count) { }

	private void Set_v_AmbushTechModModel_Fields(int start, int count) { }

	private void Set_v_AncestralMightModel_Fields(int start, int count) { }

	private void Set_v_AngleToMapCenterModel_Fields(int start, int count) { }

	private void Set_v_AnimateAirUnitOnFireModel_Fields(int start, int count) { }

	private void Set_v_AnimateOnBeastHandlerModel_Fields(int start, int count) { }

	private void Set_v_AnimateOnCollideModel_Fields(int start, int count) { }

	private void Set_v_AnimateParentTowerOnCollideModel_Fields(int start, int count) { }

	private void Set_v_AnimDamageStateModel_Fields(int start, int count) { }

	private void Set_v_ApplyModModel_Fields(int start, int count) { }

	private void Set_v_ApplyTowerSetImmunityModel_Fields(int start, int count) { }

	private void Set_v_ArcaneMetamorphosisModel_Fields(int start, int count) { }

	private void Set_v_ArcEmissionModel_Fields(int start, int count) { }

	private void Set_v_ArriveAtTargetModel_Fields(int start, int count) { }

	private void Set_v_ArtilleryCommandModel_Fields(int start, int count) { }

	private void Set_v_AssetPathModel_Fields(int start, int count) { }

	private void Set_v_Assets_Scripts_Models_Towers_Behaviors_CreateEffectOnExpireModel_Fields(int start, int count) { }

	private void Set_v_Assets_Scripts_Models_Towers_Projectiles_Behaviors_CreateEffectOnExpireModel_Fields(int start, int count) { }

	private void Set_v_AttackAirUnitModel_Fields(int start, int count) { }

	private void Set_v_AttackBehaviorModel_Fields(int start, int count) { }

	private void Set_v_AttackFilterModel_Fields(int start, int count) { }

	private void Set_v_AttackModel_Fields(int start, int count) { }

	private void Set_v_AttunementModel_Fields(int start, int count) { }

	private void Set_v_AutoTargetTrackModel_Fields(int start, int count) { }

	private void Set_v_BadImmunityModel_Fields(int start, int count) { }

	private void Set_v_BalanceModel_Fields(int start, int count) { }

	private void Set_v_BananaCashIncreaseSupportModel_Fields(int start, int count) { }

	private void Set_v_BananaCentralBuffModel_Fields(int start, int count) { }

	private void Set_v_BananaFarmerModModel_Fields(int start, int count) { }

	private void Set_v_BankDepositsModModel_Fields(int start, int count) { }

	private void Set_v_BankModel_Fields(int start, int count) { }

	private void Set_v_BankModModel_Fields(int start, int count) { }

	private void Set_v_BeastHandlerLeashModel_Fields(int start, int count) { }

	private void Set_v_BeastHandlerPetDisplayStepModel_Fields(int start, int count) { }

	private void Set_v_BeastHandlerPetModel_Fields(int start, int count) { }

	private void Set_v_BeastHandlerUpgradeLockModel_Fields(int start, int count) { }

	private void Set_v_BerserkerBrewCheckModel_Fields(int start, int count) { }

	private void Set_v_BerserkerBrewModel_Fields(int start, int count) { }

	private void Set_v_BigSqueezeFortifiedEffectModel_Fields(int start, int count) { }

	private void Set_v_BiohackModel_Fields(int start, int count) { }

	private void Set_v_BloodSacrificeModel_Fields(int start, int count) { }

	private void Set_v_BloonBehaviorActionModel_Fields(int start, int count) { }

	private void Set_v_BloonBehaviorModel_Fields(int start, int count) { }

	private void Set_v_BloonBehaviorModelWithTowerTracking_Fields(int start, int count) { }

	private void Set_v_BloonBehaviorTriggerModel_Fields(int start, int count) { }

	private void Set_v_BloonDistanceRateBonusModel_Fields(int start, int count) { }

	private void Set_v_BloonGroupModel_Fields(int start, int count) { }

	private void Set_v_BloonHealthModModel_Fields(int start, int count) { }

	private void Set_v_BloonModel_Fields(int start, int count) { }

	private void Set_v_BloonsInRangeAttackSpeedModel_Fields(int start, int count) { }

	private void Set_v_BloonSlapModel_Fields(int start, int count) { }

	private void Set_v_BonusCashZoneModel_Fields(int start, int count) { }

	private void Set_v_BonusLivesOnAbilityModel_Fields(int start, int count) { }

	private void Set_v_BonusLivesPerRoundModel_Fields(int start, int count) { }

	private void Set_v_BonusProjectileAfterIntervalModel_Fields(int start, int count) { }

	private void Set_v_BottleHotSauceBehaviorModel_Fields(int start, int count) { }

	private void Set_v_BountyHunterZoneModel_Fields(int start, int count) { }

	private void Set_v_BrewTargettingModel_Fields(int start, int count) { }

	private void Set_v_BrickellFreezeMinesAbilityBuffModel_Fields(int start, int count) { }

	private void Set_v_BrickellFreezeOtherMinesModel_Fields(int start, int count) { }

	private void Set_v_BuffBloonSpeedModel_Fields(int start, int count) { }

	private void Set_v_BuffIndicatorModel_Fields(int start, int count) { }

	private void Set_v_BurstWeaponBehaviorModel_Fields(int start, int count) { }

	private void Set_v_CallToArmsModel_Fields(int start, int count) { }

	private void Set_v_CallToArmsModModel_Fields(int start, int count) { }

	private void Set_v_CamoTrapModel_Fields(int start, int count) { }

	private void Set_v_CamoTrapModModel_Fields(int start, int count) { }

	private void Set_v_CanBuffIndicatorModel_Fields(int start, int count) { }

	private void Set_v_CantBeReflectedModel_Fields(int start, int count) { }

	private void Set_v_CarpetBombAbilityModel_Fields(int start, int count) { }

	private void Set_v_CarryProjectileModel_Fields(int start, int count) { }

	private void Set_v_CashbackZoneModel_Fields(int start, int count) { }

	private void Set_v_CashDropModel_Fields(int start, int count) { }

	private void Set_v_CashIncreaseModel_Fields(int start, int count) { }

	private void Set_v_CashIncreaseModModel_Fields(int start, int count) { }

	private void Set_v_CashModel_Fields(int start, int count) { }

	private void Set_v_CashModModel_Fields(int start, int count) { }

	private void Set_v_CashPerBananaFarmInRangeModel_Fields(int start, int count) { }

	private void Set_v_CashPerRoundModModel_Fields(int start, int count) { }

	private void Set_v_CenterElipsePatternModel_Fields(int start, int count) { }

	private void Set_v_CentralMarketBuffModel_Fields(int start, int count) { }

	private void Set_v_CeramicShockModModel_Fields(int start, int count) { }

	private void Set_v_ChangeDamageTypeModel_Fields(int start, int count) { }

	private void Set_v_ChangeProjectileDisplayModel_Fields(int start, int count) { }

	private void Set_v_ChangeProjectilePerEmitModel_Fields(int start, int count) { }

	private void Set_v_CheckAdoraCanFireModel_Fields(int start, int count) { }

	private void Set_v_CheckAirUnitOverTrackModel_Fields(int start, int count) { }

	private void Set_v_CheckIsOverTrackModel_Fields(int start, int count) { }

	private void Set_v_CheckTargetsWithoutOffsetsModel_Fields(int start, int count) { }

	private void Set_v_CheckTempleCanFireModel_Fields(int start, int count) { }

	private void Set_v_CheckTempleUnderLevelModel_Fields(int start, int count) { }

	private void Set_v_ChipMapBasedObjectModel_Fields(int start, int count) { }

	private void Set_v_ChurchillBaseRotationModel_Fields(int start, int count) { }

	private void Set_v_CircleFootprintModel_Fields(int start, int count) { }

	private void Set_v_CirclePatternCloseModel_Fields(int start, int count) { }

	private void Set_v_CirclePatternFirstModel_Fields(int start, int count) { }

	private void Set_v_CirclePatternLastModel_Fields(int start, int count) { }

	private void Set_v_CirclePatternModel_Fields(int start, int count) { }

	private void Set_v_CirclePatternStrongModel_Fields(int start, int count) { }

	private void Set_v_ClearHitBloonsModel_Fields(int start, int count) { }

	private void Set_v_ClearHitBloonsWhenNoLongerCollidingModel_Fields(int start, int count) { }

	private void Set_v_CloseTargetTrackModel_Fields(int start, int count) { }

	private void Set_v_ColdFrontModModel_Fields(int start, int count) { }

	private void Set_v_CollectCashZoneModel_Fields(int start, int count) { }

	private void Set_v_CollectCreatedProjectileModel_Fields(int start, int count) { }

	private void Set_v_CollideExtraPierceReductionModel_Fields(int start, int count) { }

	private void Set_v_CollideOnlyWithTargetModel_Fields(int start, int count) { }

	private void Set_v_CollisionGroupData_Fields(int start, int count) { }

	private void Set_v_CollisionGroupModel_Fields(int start, int count) { }

	private void Set_v_ComancheDefenceModel_Fields(int start, int count) { }

	private void Set_v_ComeOnEverybodyModModel_Fields(int start, int count) { }

	private void Set_v_ConditionalModel_Fields(int start, int count) { }

	private void Set_v_CorvusContinuousSpellModel_Fields(int start, int count) { }

	private void Set_v_CorvusInstantSpellModel_Fields(int start, int count) { }

	private void Set_v_CorvusOnSpellEndEffectsModel_Fields(int start, int count) { }

	private void Set_v_CorvusOnSpellEndModel_Fields(int start, int count) { }

	private void Set_v_CorvusSpellModel_Fields(int start, int count) { }

	private void Set_v_CorvusSpellProjectileModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectActionModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectAfterTimeModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectFromCollisionToCollisionModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnAbilityEndModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnAbilityModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnAbilityModModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnAirUnitDestroyModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnAirUnitModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnContactModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnExhaustedModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnExhaustFractionModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnGeraldoItemModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnParentOnAttackModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnPlaceModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnPopModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnPowerModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnRoundEndModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnSellModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectOnUpgradeModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectProjectileAfterTimeModel_Fields(int start, int count) { }

	private void Set_v_CreateEffectWhileAttackingModel_Fields(int start, int count) { }

	private void Set_v_CreateGreatWhiteEffectModel_Fields(int start, int count) { }

	private void Set_v_CreateLightningEffectModel_Fields(int start, int count) { }

	private void Set_v_CreateNearbyWaterModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectileOnBlockerCollideModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectileOnContactModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectileOnExhaustFractionModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectileOnExhaustPierceModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectileOnExpireModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectileOnIntervalModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectileOnTowerDestroyModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectilesAlongPathWhenCloseModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectilesInAreaModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectilesOnTrackOnExhaustFractionModel_Fields(int start, int count) { }

	private void Set_v_CreateProjectilesOnTrackOnExpireModel_Fields(int start, int count) { }

	private void Set_v_CreatePropsOnBloonActionModel_Fields(int start, int count) { }

	private void Set_v_CreateRopeEffectModel_Fields(int start, int count) { }

	private void Set_v_CreateSequencedTypedTowerCurrentIndexModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnAbilityModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnActionModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnAttachedModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnBloonDestroyedModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnBloonEnterTrackModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnBloonLeakModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnBreakArmourModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnDamageArmourModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnDamageBloonModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnDelayedCollisionModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnEndOfRoundModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnGeraldoItemModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnMonkeyMoneyActivatedModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnPickupModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnPowerModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnProjectileCollisionModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnProjectileCreatedModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnProjectileExhaustModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnProjectileExpireModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnSelectedModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnSellModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnSpawnBloonModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnTowerExpireModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnTowerPlaceModel_Fields(int start, int count) { }

	private void Set_v_CreateSoundOnUpgradeModel_Fields(int start, int count) { }

	private void Set_v_CreateTextEffectModel_Fields(int start, int count) { }

	private void Set_v_CreateTowerModel_Fields(int start, int count) { }

	private void Set_v_CreateTowersInSequenceAbilityIconModel_Fields(int start, int count) { }

	private void Set_v_CreateTowersInSequenceModel_Fields(int start, int count) { }

	private void Set_v_CreateTypedTowerCurrentIndexModel_Fields(int start, int count) { }

	private void Set_v_CreateTypedTowerModel_Fields(int start, int count) { }

	private void Set_v_CreditPopsToParentTowerModel_Fields(int start, int count) { }

	private void Set_v_CritMultiplierModel_Fields(int start, int count) { }

	private void Set_v_CritRollModel_Fields(int start, int count) { }

	private void Set_v_CritRollWithDistanceModel_Fields(int start, int count) { }

	private void Set_v_CrossTheStreamsModModel_Fields(int start, int count) { }

	private void Set_v_Curve_Fields(int start, int count) { }

	private void Set_v_CustomMapDataModel_Fields(int start, int count) { }

	private void Set_v_CycleAnimationModel_Fields(int start, int count) { }

	private void Set_v_DamageAllModel_Fields(int start, int count) { }

	private void Set_v_DamageBasedAttackSpeedModel_Fields(int start, int count) { }

	private void Set_v_DamageInRingRadiusModel_Fields(int start, int count) { }

	private void Set_v_DamageModel_Fields(int start, int count) { }

	private void Set_v_DamageModifierForBloonStateModel_Fields(int start, int count) { }

	private void Set_v_DamageModifierForBloonTypeModel_Fields(int start, int count) { }

	private void Set_v_DamageModifierForBloonTypeModModel_Fields(int start, int count) { }

	private void Set_v_DamageModifierForTagModel_Fields(int start, int count) { }

	private void Set_v_DamageModifierForTagModModel_Fields(int start, int count) { }

	private void Set_v_DamageModifierModel_Fields(int start, int count) { }

	private void Set_v_DamageModifierSupportModel_Fields(int start, int count) { }

	private void Set_v_DamageModifierUnstableConcoctionModel_Fields(int start, int count) { }

	private void Set_v_DamageModifierWrathModel_Fields(int start, int count) { }

	private void Set_v_DamageOverTimeCustomModel_Fields(int start, int count) { }

	private void Set_v_DamageOverTimeForTagModel_Fields(int start, int count) { }

	private void Set_v_DamageOverTimeModel_Fields(int start, int count) { }

	private void Set_v_DamageOverTimeModModel_Fields(int start, int count) { }

	private void Set_v_DamageOverTimeZoneModel_Fields(int start, int count) { }

	private void Set_v_DamagePercentOfMaxModel_Fields(int start, int count) { }

	private void Set_v_DamageReductionModel_Fields(int start, int count) { }

	private void Set_v_DamageStateModel_Fields(int start, int count) { }

	private void Set_v_DamageSupportModel_Fields(int start, int count) { }

	private void Set_v_DamageTowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_DamageTypeModModel_Fields(int start, int count) { }

	private void Set_v_DamageTypeSupportModel_Fields(int start, int count) { }

	private void Set_v_DamageUpModel_Fields(int start, int count) { }

	private void Set_v_DamageUpTagTowersModel_Fields(int start, int count) { }

	private void Set_v_DamageUpTowersModel_Fields(int start, int count) { }

	private void Set_v_DarkshiftModel_Fields(int start, int count) { }

	private void Set_v_DartlingMaintainLastPosModel_Fields(int start, int count) { }

	private void Set_v_DartTimeModel_Fields(int start, int count) { }

	private void Set_v_DartTimeModModel_Fields(int start, int count) { }

	private void Set_v_DashForwardsActionModel_Fields(int start, int count) { }

	private void Set_v_DelayBloonChildrenSpawningModel_Fields(int start, int count) { }

	private void Set_v_DelayedShutoffModel_Fields(int start, int count) { }

	private void Set_v_DeployModel_Fields(int start, int count) { }

	private void Set_v_DesperadoMarkModel_Fields(int start, int count) { }

	private void Set_v_DestroyChildTowersOnUpgradeModel_Fields(int start, int count) { }

	private void Set_v_DestroyProjectileIfModelChangedModel_Fields(int start, int count) { }

	private void Set_v_DestroyProjectileIfTowerDestroyedModel_Fields(int start, int count) { }

	private void Set_v_DestroyProjectilesInRadiusActionModel_Fields(int start, int count) { }

	private void Set_v_DestroyWhenHitImmuneModel_Fields(int start, int count) { }

	private void Set_v_DiscountZoneModel_Fields(int start, int count) { }

	private void Set_v_DiscountZoneModModel_Fields(int start, int count) { }

	private void Set_v_DisplayModel_Fields(int start, int count) { }

	private void Set_v_DistributeCashModel_Fields(int start, int count) { }

	private void Set_v_DistributeToChildrenBloonModifierModel_Fields(int start, int count) { }

	private void Set_v_DistributeToChildrenSetModel_Fields(int start, int count) { }

	private void Set_v_DontDestroyOnContinueModel_Fields(int start, int count) { }

	private void Set_v_DoorGunnerModel_Fields(int start, int count) { }

	private void Set_v_DoorGunnerModModel_Fields(int start, int count) { }

	private void Set_v_DrainLivesActionModel_Fields(int start, int count) { }

	private void Set_v_DrawSubtowerRangeCircleModel_Fields(int start, int count) { }

	private void Set_v_DroneIdleModel_Fields(int start, int count) { }

	private void Set_v_DroneSupportModel_Fields(int start, int count) { }

	private void Set_v_DroneSwarmModel_Fields(int start, int count) { }

	private void Set_v_DruidOfWrathBuffModel_Fields(int start, int count) { }

	private void Set_v_DruidVengeanceEffectModel_Fields(int start, int count) { }

	private void Set_v_DuplicateProjectilePerEmitModel_Fields(int start, int count) { }

	private void Set_v_EatBloonModel_Fields(int start, int count) { }

	private void Set_v_EatBloonModModel_Fields(int start, int count) { }

	private void Set_v_EchoModel_Fields(int start, int count) { }

	private void Set_v_EffectModel_Fields(int start, int count) { }

	private void Set_v_EjectAnimationModel_Fields(int start, int count) { }

	private void Set_v_EjectEffectModel_Fields(int start, int count) { }

	private void Set_v_EjectEffectWithOffsetsModel_Fields(int start, int count) { }

	private void Set_v_EmberModel_Fields(int start, int count) { }

	private void Set_v_EmergencyUnlockModel_Fields(int start, int count) { }

	private void Set_v_EmergencyUnlockModModel_Fields(int start, int count) { }

	private void Set_v_EmissionArcCountModModel_Fields(int start, int count) { }

	private void Set_v_EmissionArcRotationOffDisplayDirectionModel_Fields(int start, int count) { }

	private void Set_v_EmissionArcRotationOffTowerDirectionModel_Fields(int start, int count) { }

	private void Set_v_EmissionAtClosestPathSegmentModel_Fields(int start, int count) { }

	private void Set_v_EmissionBehaviorModel_Fields(int start, int count) { }

	private void Set_v_EmissionCamoIfTargetIsCamoModel_Fields(int start, int count) { }

	private void Set_v_EmissionClosestOffsetModel_Fields(int start, int count) { }

	private void Set_v_EmissionModel_Fields(int start, int count) { }

	private void Set_v_EmissionOverTimeModel_Fields(int start, int count) { }

	private void Set_v_EmissionRotationOffBloonDirectionModel_Fields(int start, int count) { }

	private void Set_v_EmissionRotationOffDisplayModel_Fields(int start, int count) { }

	private void Set_v_EmissionRotationOffDisplayOnEmitModel_Fields(int start, int count) { }

	private void Set_v_EmissionRotationOffProjectileDirectionModel_Fields(int start, int count) { }

	private void Set_v_EmissionRotationOffTowerDirectionModel_Fields(int start, int count) { }

	private void Set_v_EmissionRotationZeroModel_Fields(int start, int count) { }

	private void Set_v_EmissionsPerRoundFilterModel_Fields(int start, int count) { }

	private void Set_v_EmissionWithOffsetsModel_Fields(int start, int count) { }

	private void Set_v_EmitOnDamageModel_Fields(int start, int count) { }

	private void Set_v_EmitOnDestroyModel_Fields(int start, int count) { }

	private void Set_v_EmitOnPopModel_Fields(int start, int count) { }

	private void Set_v_EndOfRoundClearBypassModel_Fields(int start, int count) { }

	private void Set_v_EnergisingTotemAnimStateModel_Fields(int start, int count) { }

	private void Set_v_EnergisingTotemBehaviorModel_Fields(int start, int count) { }

	private void Set_v_EntityBehaviorModel_Fields(int start, int count) { }

	private void Set_v_EntityModel_Fields(int start, int count) { }

	private void Set_v_EruptionModel_Fields(int start, int count) { }

	private void Set_v_ExpireProjectileAtScreenEdgeModel_Fields(int start, int count) { }

	private void Set_v_ExpireProjectileOnBossSpawnedModel_Fields(int start, int count) { }

	private void Set_v_ExpireProjectileOnParentDestroyedModel_Fields(int start, int count) { }

	private void Set_v_ExpireTowerAfterAbilityModel_Fields(int start, int count) { }

	private void Set_v_EziliSupportModel_Fields(int start, int count) { }

	private void Set_v_FadeProjectileModel_Fields(int start, int count) { }

	private void Set_v_FallToGroundModel_Fields(int start, int count) { }

	private void Set_v_FertilizerBehaviorModel_Fields(int start, int count) { }

	private void Set_v_FighterMovementModel_Fields(int start, int count) { }

	private void Set_v_FighterPilotPatternCloseModel_Fields(int start, int count) { }

	private void Set_v_FighterPilotPatternFirstModel_Fields(int start, int count) { }

	private void Set_v_FighterPilotPatternLastModel_Fields(int start, int count) { }

	private void Set_v_FighterPilotPatternStrongModel_Fields(int start, int count) { }

	private void Set_v_FigureEightPatternModel_Fields(int start, int count) { }

	private void Set_v_FilterAllExceptTargetModel_Fields(int start, int count) { }

	private void Set_v_FilterAllModel_Fields(int start, int count) { }

	private void Set_v_FilterBloonIfDamageTypeModel_Fields(int start, int count) { }

	private void Set_v_FilterBloonsToWithinAngleModel_Fields(int start, int count) { }

	private void Set_v_FilterFrozenBloonsModel_Fields(int start, int count) { }

	private void Set_v_FilterGlueLevelModel_Fields(int start, int count) { }

	private void Set_v_FilterIfAttackHasTargetModel_Fields(int start, int count) { }

	private void Set_v_FilterInBaseTowerIdModel_Fields(int start, int count) { }

	private void Set_v_FilterInOwnedByModel_Fields(int start, int count) { }

	private void Set_v_FilterInSetModel_Fields(int start, int count) { }

	private void Set_v_FilterInTowerTiersModel_Fields(int start, int count) { }

	private void Set_v_FilterInvisibleModel_Fields(int start, int count) { }

	private void Set_v_FilterInvisibleSubIntelModel_Fields(int start, int count) { }

	private void Set_v_FilterMarkedToPopModel_Fields(int start, int count) { }

	private void Set_v_FilterMoabModel_Fields(int start, int count) { }

	private void Set_v_FilterModel_Fields(int start, int count) { }

	private void Set_v_FilterMutatedTargetModel_Fields(int start, int count) { }

	private void Set_v_FilterOfftrackModel_Fields(int start, int count) { }

	private void Set_v_FilterOnlyCamoInModel_Fields(int start, int count) { }

	private void Set_v_FilterOutBloonModel_Fields(int start, int count) { }

	private void Set_v_FilterOutOffscreenModel_Fields(int start, int count) { }

	private void Set_v_FilterOutTagModel_Fields(int start, int count) { }

	private void Set_v_FilterOveridingMutatedTargetModel_Fields(int start, int count) { }

	private void Set_v_FilterParagonModel_Fields(int start, int count) { }

	private void Set_v_FilterParentTowerRangeModel_Fields(int start, int count) { }

	private void Set_v_FilterProjectileCollisionIfTowerPausedModel_Fields(int start, int count) { }

	private void Set_v_FilterTargetAngleFilterModel_Fields(int start, int count) { }

	private void Set_v_FilterTargetAngleModel_Fields(int start, int count) { }

	private void Set_v_FilterTowerByPlaceableAreaModel_Fields(int start, int count) { }

	private void Set_v_FilterTowerParentModel_Fields(int start, int count) { }

	private void Set_v_FilterWithChanceModel_Fields(int start, int count) { }

	private void Set_v_FilterWithTagModel_Fields(int start, int count) { }

	private void Set_v_FilterWithTagsModel_Fields(int start, int count) { }

	private void Set_v_FinalStrikeModel_Fields(int start, int count) { }

	private void Set_v_FindDeploymentLocationModel_Fields(int start, int count) { }

	private void Set_v_FireAlternateWeaponModel_Fields(int start, int count) { }

	private void Set_v_FireballActionModel_Fields(int start, int count) { }

	private void Set_v_FireFromAirUnitModel_Fields(int start, int count) { }

	private void Set_v_FireWhenAlternateWeaponIsReadyModel_Fields(int start, int count) { }

	private void Set_v_FlagshipAttackSpeedIncreaseModel_Fields(int start, int count) { }

	private void Set_v_FlightBoostAbilityModel_Fields(int start, int count) { }

	private void Set_v_FlipFollowPathModel_Fields(int start, int count) { }

	private void Set_v_FollowPathModel_Fields(int start, int count) { }

	private void Set_v_FollowTouchSettingModel_Fields(int start, int count) { }

	private void Set_v_FootprintModel_Fields(int start, int count) { }

	private void Set_v_FreeplayBloonGroupModel_Fields(int start, int count) { }

	private void Set_v_FreeTowerModModel_Fields(int start, int count) { }

	private void Set_v_FreeUpgradeSupportModel_Fields(int start, int count) { }

	private void Set_v_FreezeModel_Fields(int start, int count) { }

	private void Set_v_FreezeModifierForTagsModel_Fields(int start, int count) { }

	private void Set_v_FreezeModifierModModel_Fields(int start, int count) { }

	private void Set_v_FreezeNearbyWaterModel_Fields(int start, int count) { }

	private void Set_v_FrostboundModel_Fields(int start, int count) { }

	private void Set_v_GameModel_Fields(int start, int count) { }

	private void Set_v_GenerateArmourActionModel_Fields(int start, int count) { }

	private void Set_v_GenerateShieldActionModel_Fields(int start, int count) { }

	private void Set_v_GeraldoChangeTowerBehaviorModel_Fields(int start, int count) { }

	private void Set_v_GeraldoCreateProjectileModel_Fields(int start, int count) { }

	private void Set_v_GeraldoItemBehaviorModel_Fields(int start, int count) { }

	private void Set_v_GeraldoItemModel_Fields(int start, int count) { }

	private void Set_v_GeraldoUpgradeTowerModel_Fields(int start, int count) { }

	private void Set_v_GlueTrapModel_Fields(int start, int count) { }

	private void Set_v_GlueTrapModModel_Fields(int start, int count) { }

	private void Set_v_GoldenBloonModel_Fields(int start, int count) { }

	private void Set_v_GorgonStormModModel_Fields(int start, int count) { }

	private void Set_v_GrantCamoDetectForAbilityModModel_Fields(int start, int count) { }

	private void Set_v_GrappleEmissionModel_Fields(int start, int count) { }

	private void Set_v_GreatWhiteDisplayStepModel_Fields(int start, int count) { }

	private void Set_v_GreatWhiteLimitProjectileModel_Fields(int start, int count) { }

	private void Set_v_GroundZeroBombBuffModel_Fields(int start, int count) { }

	private void Set_v_GrowBlockModel_Fields(int start, int count) { }

	private void Set_v_GrowModel_Fields(int start, int count) { }

	private void Set_v_GyrfalconPatternModel_Fields(int start, int count) { }

	private void Set_v_HasSpellcastProjectileModel_Fields(int start, int count) { }

	private void Set_v_HasteModel_Fields(int start, int count) { }

	private void Set_v_HasUpgradeableProjectilesModel_Fields(int start, int count) { }

	private void Set_v_HauntModel_Fields(int start, int count) { }

	private void Set_v_HealOnTowerSellActionModel_Fields(int start, int count) { }

	private void Set_v_HealthPercentTriggerModel_Fields(int start, int count) { }

	private void Set_v_HealthyBananasModModel_Fields(int start, int count) { }

	private void Set_v_HeatItUpDamageBuffModel_Fields(int start, int count) { }

	private void Set_v_HeightOffsetProjectileModel_Fields(int start, int count) { }

	private void Set_v_HeliMovementModel_Fields(int start, int count) { }

	private void Set_v_HeroCostToLevelModModel_Fields(int start, int count) { }

	private void Set_v_HeroDetailsModel_Fields(int start, int count) { }

	private void Set_v_HeroModel_Fields(int start, int count) { }

	private void Set_v_HeroXPBonusModModel_Fields(int start, int count) { }

	private void Set_v_HeroXpInjectionModModel_Fields(int start, int count) { }

	private void Set_v_HexManagerModel_Fields(int start, int count) { }

	private void Set_v_HexModel_Fields(int start, int count) { }

	private void Set_v_HideAttackDisplayIfPausedModel_Fields(int start, int count) { }

	private void Set_v_IgnoreAllMutatorsTowerModel_Fields(int start, int count) { }

	private void Set_v_IgnoreBlockersModModel_Fields(int start, int count) { }

	private void Set_v_IgnoreCollisionAfterCollideModel_Fields(int start, int count) { }

	private void Set_v_IgnoreDmgImmunityModel_Fields(int start, int count) { }

	private void Set_v_IgnoreImmunityForBloonTypeModModel_Fields(int start, int count) { }

	private void Set_v_IgnoreInsufficientPierceModel_Fields(int start, int count) { }

	private void Set_v_IgnoreThrowMarkerModel_Fields(int start, int count) { }

	private void Set_v_IgnoreTowersBlockerModel_Fields(int start, int count) { }

	private void Set_v_ImfLoanCollectionModel_Fields(int start, int count) { }

	private void Set_v_ImfLoanModel_Fields(int start, int count) { }

	private void Set_v_ImfLoanModModel_Fields(int start, int count) { }

	private void Set_v_ImmunityModel_Fields(int start, int count) { }

	private void Set_v_IncreaseBloonWorthModel_Fields(int start, int count) { }

	private void Set_v_IncreaseBloonWorthSimBehaviorModel_Fields(int start, int count) { }

	private void Set_v_IncreaseBloonWorthWithTierModel_Fields(int start, int count) { }

	private void Set_v_IncreaseRangeModel_Fields(int start, int count) { }

	private void Set_v_IncreaseRangeModModel_Fields(int start, int count) { }

	private void Set_v_IncreaseTowerWorthOverRoundsModel_Fields(int start, int count) { }

	private void Set_v_IncreaseWorthTextEffectModel_Fields(int start, int count) { }

	private void Set_v_InstantDamageEmissionModel_Fields(int start, int count) { }

	private void Set_v_InstantModel_Fields(int start, int count) { }

	private void Set_v_JarOfPicklesBehaviorModel_Fields(int start, int count) { }

	private void Set_v_JungleVineEffectModel_Fields(int start, int count) { }

	private void Set_v_JungleVineLimitProjectileModel_Fields(int start, int count) { }

	private void Set_v_KeepInBoundsModel_Fields(int start, int count) { }

	private void Set_v_KeepTowerZAtTerrainHeightModel_Fields(int start, int count) { }

	private void Set_v_KineticChargeProjectileModel_Fields(int start, int count) { }

	private void Set_v_KnockbackModel_Fields(int start, int count) { }

	private void Set_v_KnockbackModModel_Fields(int start, int count) { }

	private void Set_v_KnowledgeModel_Fields(int start, int count) { }

	private void Set_v_LatchToBloonModel_Fields(int start, int count) { }

	private void Set_v_LeakDangerAttackSpeedModel_Fields(int start, int count) { }

	private void Set_v_LeapingSwordModel_Fields(int start, int count) { }

	private void Set_v_LifeBasedAttackSpeedModel_Fields(int start, int count) { }

	private void Set_v_LifeRegenModel_Fields(int start, int count) { }

	private void Set_v_LightningModel_Fields(int start, int count) { }

	private void Set_v_LimitByHauntSpellModel_Fields(int start, int count) { }

	private void Set_v_LimitProjectileModel_Fields(int start, int count) { }

	private void Set_v_LinearTravelModel_Fields(int start, int count) { }

	private void Set_v_LineEffectModel_Fields(int start, int count) { }

	private void Set_v_LineProjectileEmissionModel_Fields(int start, int count) { }

	private void Set_v_LinkDisplayScaleToTowerRangeModel_Fields(int start, int count) { }

	private void Set_v_LinkProjectileRadiusToTowerRangeModel_Fields(int start, int count) { }

	private void Set_v_LivesModel_Fields(int start, int count) { }

	private void Set_v_LivesModModel_Fields(int start, int count) { }

	private void Set_v_LoadAlchemistBrewInfoModel_Fields(int start, int count) { }

	private void Set_v_LockInPlaceSettingModel_Fields(int start, int count) { }

	private void Set_v_LongArmOfLightModel_Fields(int start, int count) { }

	private void Set_v_MagusPerfectusGraveyardModel_Fields(int start, int count) { }

	private void Set_v_MagusPerfectusGraveyardStateManagerModel_Fields(int start, int count) { }

	private void Set_v_MalevolenceModel_Fields(int start, int count) { }

	private void Set_v_MapBorderReboundModel_Fields(int start, int count) { }

	private void Set_v_MarkedToPopModel_Fields(int start, int count) { }

	private void Set_v_MarkedToPopProjectileBehaviorModel_Fields(int start, int count) { }

	private void Set_v_MerchantShipModel_Fields(int start, int count) { }

	private void Set_v_MinibossImmunityModel_Fields(int start, int count) { }

	private void Set_v_MoabBarrageBloonBehaviorModel_Fields(int start, int count) { }

	private void Set_v_MoabBarrageModel_Fields(int start, int count) { }

	private void Set_v_MoabMineModel_Fields(int start, int count) { }

	private void Set_v_MoabMineModModel_Fields(int start, int count) { }

	private void Set_v_MoabShoveZoneModel_Fields(int start, int count) { }

	private void Set_v_MoabTakedownModel_Fields(int start, int count) { }

	private void Set_v_Model_Fields(int start, int count) { }

	private void Set_v_ModModel_Fields(int start, int count) { }

	private void Set_v_MonkeyBoostModel_Fields(int start, int count) { }

	private void Set_v_MonkeyBoostModModel_Fields(int start, int count) { }

	private void Set_v_MonkeyCityIncomeSupportModel_Fields(int start, int count) { }

	private void Set_v_MonkeyCityModel_Fields(int start, int count) { }

	private void Set_v_MonkeyFanClubModel_Fields(int start, int count) { }

	private void Set_v_MonkeyMoneyModModel_Fields(int start, int count) { }

	private void Set_v_MonkeyopolisModel_Fields(int start, int count) { }

	private void Set_v_MonkeyopolisUpgradeCostModel_Fields(int start, int count) { }

	private void Set_v_MonkeySubParagonSupportModel_Fields(int start, int count) { }

	private void Set_v_MonkeyTempleModel_Fields(int start, int count) { }

	private void Set_v_MorphBloonModel_Fields(int start, int count) { }

	private void Set_v_MorphTowerModel_Fields(int start, int count) { }

	private void Set_v_MultiEmissionModel_Fields(int start, int count) { }

	private void Set_v_MultiHookManagerModel_Fields(int start, int count) { }

	private void Set_v_MutateCreateProjectileOnExhaustPierceOnAbilityModel_Fields(int start, int count) { }

	private void Set_v_MutateDamageOnAbilityModel_Fields(int start, int count) { }

	private void Set_v_MutateProjectileOnAbilityModel_Fields(int start, int count) { }

	private void Set_v_MutateRemoveAllAttacksOnAbilityActivateModel_Fields(int start, int count) { }

	private void Set_v_MutationImunityTowerModel_Fields(int start, int count) { }

	private void Set_v_MutatorModModel_Fields(int start, int count) { }

	private void Set_v_NecroEmissionFilterModel_Fields(int start, int count) { }

	private void Set_v_NecromancerEmissionModel_Fields(int start, int count) { }

	private void Set_v_NecromancerTargetTrackWithinRangeModel_Fields(int start, int count) { }

	private void Set_v_NecromancerZoneModel_Fields(int start, int count) { }

	private void Set_v_NourishmentModel_Fields(int start, int count) { }

	private void Set_v_ObynGlobalSupportModel_Fields(int start, int count) { }

	private void Set_v_OffsetModel_Fields(int start, int count) { }

	private void Set_v_OnMonkeyKnowledgePurchaseModModel_Fields(int start, int count) { }

	private void Set_v_OrbitingTowerModel_Fields(int start, int count) { }

	private void Set_v_OrbitModel_Fields(int start, int count) { }

	private void Set_v_OverclockModel_Fields(int start, int count) { }

	private void Set_v_OverclockPermanentModel_Fields(int start, int count) { }

	private void Set_v_OverheatTriggerModel_Fields(int start, int count) { }

	private void Set_v_OverloadModel_Fields(int start, int count) { }

	private void Set_v_OverrideCamoDetectionModel_Fields(int start, int count) { }

	private void Set_v_PaintStripperModModel_Fields(int start, int count) { }

	private void Set_v_ParagonAssetSwapModel_Fields(int start, int count) { }

	private void Set_v_ParagonDegreeDataModel_Fields(int start, int count) { }

	private void Set_v_ParagonOfPowerModModel_Fields(int start, int count) { }

	private void Set_v_ParagonSacrificeBonusModel_Fields(int start, int count) { }

	private void Set_v_ParagonTowerModel_Fields(int start, int count) { }

	private void Set_v_ParallelEmissionModel_Fields(int start, int count) { }

	private void Set_v_PatBuffIndicatorModel_Fields(int start, int count) { }

	private void Set_v_PathMovementFromScreenCenterModel_Fields(int start, int count) { }

	private void Set_v_PathMovementFromScreenCenterPatternModel_Fields(int start, int count) { }

	private void Set_v_PathMovementModel_Fields(int start, int count) { }

	private void Set_v_PatrolPointsSettingModel_Fields(int start, int count) { }

	private void Set_v_PauseAllOtherAttacksModel_Fields(int start, int count) { }

	private void Set_v_PauseOtherAttacksModel_Fields(int start, int count) { }

	private void Set_v_PerRoundCashBonusTowerModel_Fields(int start, int count) { }

	private void Set_v_PetBehaviorModel_Fields(int start, int count) { }

	private void Set_v_PetCreateEffectOnPlaceModel_Fields(int start, int count) { }

	private void Set_v_PetCreateEffectOnSellModel_Fields(int start, int count) { }

	private void Set_v_PetModel_Fields(int start, int count) { }

	private void Set_v_PetModelSynced_Fields(int start, int count) { }

	private void Set_v_PetRabbitBehaviorModel_Fields(int start, int count) { }

	private void Set_v_PetRabbitMergeModel_Fields(int start, int count) { }

	private void Set_v_PhayzeBehaviorModel_Fields(int start, int count) { }

	private void Set_v_PhayzeTimerActionModel_Fields(int start, int count) { }

	private void Set_v_PhoenixRebirthModel_Fields(int start, int count) { }

	private void Set_v_PickupModel_Fields(int start, int count) { }

	private void Set_v_PierceFromLivesGainedModel_Fields(int start, int count) { }

	private void Set_v_PiercePercentageSupportModel_Fields(int start, int count) { }

	private void Set_v_PierceSupportModel_Fields(int start, int count) { }

	private void Set_v_PierceTowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_PierceUpTowersModel_Fields(int start, int count) { }

	private void Set_v_PlacementAreaTypeHeightSettingModel_Fields(int start, int count) { }

	private void Set_v_PlacementAreaTypeRangeBuffModel_Fields(int start, int count) { }

	private void Set_v_PlacementBehaviorModel_Fields(int start, int count) { }

	private void Set_v_PlaceProjectileAtModel_Fields(int start, int count) { }

	private void Set_v_PlayAnimationIndexModel_Fields(int start, int count) { }

	private void Set_v_PlayAnimTriggerActionModel_Fields(int start, int count) { }

	private void Set_v_PopEffectModel_Fields(int start, int count) { }

	private void Set_v_PoplustSupportModel_Fields(int start, int count) { }

	private void Set_v_PowerBehaviorModel_Fields(int start, int count) { }

	private void Set_v_PowerDetailsModel_Fields(int start, int count) { }

	private void Set_v_PowerModel_Fields(int start, int count) { }

	private void Set_v_PowerModModel_Fields(int start, int count) { }

	private void Set_v_PowerProjectileModel_Fields(int start, int count) { }

	private void Set_v_PreEmptiveStrikeLauncherModel_Fields(int start, int count) { }

	private void Set_v_PreGamePrepModModel_Fields(int start, int count) { }

	private void Set_v_PrinceOfDarknessEmissionModel_Fields(int start, int count) { }

	private void Set_v_PrinceOfDarknessZombieBuffModel_Fields(int start, int count) { }

	private void Set_v_PrioritiseRotationModel_Fields(int start, int count) { }

	private void Set_v_ProjectileBehaviorModel_Fields(int start, int count) { }

	private void Set_v_ProjectileBehaviorWithOverlayModel_Fields(int start, int count) { }

	private void Set_v_ProjectileBlockerCollisionReboundModel_Fields(int start, int count) { }

	private void Set_v_ProjectileCreateEffectOnEmitModel_Fields(int start, int count) { }

	private void Set_v_ProjectileFilterModel_Fields(int start, int count) { }

	private void Set_v_ProjectileHeightModel_Fields(int start, int count) { }

	private void Set_v_ProjectileModel_Fields(int start, int count) { }

	private void Set_v_ProjectileOverTimeModel_Fields(int start, int count) { }

	private void Set_v_ProjectilePierceModModel_Fields(int start, int count) { }

	private void Set_v_ProjectileRadiusModModel_Fields(int start, int count) { }

	private void Set_v_ProjectileRadiusSupportModel_Fields(int start, int count) { }

	private void Set_v_ProjectileRangePercentageModModel_Fields(int start, int count) { }

	private void Set_v_ProjectileSetAnimationOnContactModel_Fields(int start, int count) { }

	private void Set_v_ProjectileSizeTowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_ProjectileSpeedModModel_Fields(int start, int count) { }

	private void Set_v_ProjectileSpeedSupportModel_Fields(int start, int count) { }

	private void Set_v_ProjectileSpeedTowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_ProjectileTrackTargetModModel_Fields(int start, int count) { }

	private void Set_v_ProjectileZeroRotationModel_Fields(int start, int count) { }

	private void Set_v_PsiBloonBehaviorModel_Fields(int start, int count) { }

	private void Set_v_PsiEffectModel_Fields(int start, int count) { }

	private void Set_v_PsiLimitProjectileModel_Fields(int start, int count) { }

	private void Set_v_PsiPsionicScreamModel_Fields(int start, int count) { }

	private void Set_v_PursuitSettingCustomModel_Fields(int start, int count) { }

	private void Set_v_PursuitSettingModel_Fields(int start, int count) { }

	private void Set_v_PushBackIncreaseModModel_Fields(int start, int count) { }

	private void Set_v_PushBackModel_Fields(int start, int count) { }

	private void Set_v_PyrotechnicsSupportFilterModel_Fields(int start, int count) { }

	private void Set_v_PyrotechnicsSupportModel_Fields(int start, int count) { }

	private void Set_v_RandomAngleOffsetModel_Fields(int start, int count) { }

	private void Set_v_RandomArcEmissionModel_Fields(int start, int count) { }

	private void Set_v_RandomEmissionModel_Fields(int start, int count) { }

	private void Set_v_RandomPositionBasicModel_Fields(int start, int count) { }

	private void Set_v_RandomPositionModel_Fields(int start, int count) { }

	private void Set_v_RandomRangeTravelStraitModel_Fields(int start, int count) { }

	private void Set_v_RandomRateModel_Fields(int start, int count) { }

	private void Set_v_RandomRotationWeaponBehaviorModel_Fields(int start, int count) { }

	private void Set_v_RandomTargetModel_Fields(int start, int count) { }

	private void Set_v_RandomTargetSpreadModel_Fields(int start, int count) { }

	private void Set_v_RangeModModel_Fields(int start, int count) { }

	private void Set_v_RangeReductionZoneModel_Fields(int start, int count) { }

	private void Set_v_RangeSupportModel_Fields(int start, int count) { }

	private void Set_v_RangeTowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_RateBasedAnimationOffsetModel_Fields(int start, int count) { }

	private void Set_v_RateSupportBombExpertModel_Fields(int start, int count) { }

	private void Set_v_RateSupportExplosiveModel_Fields(int start, int count) { }

	private void Set_v_RateSupportModel_Fields(int start, int count) { }

	private void Set_v_ReanimateMoabsActionModel_Fields(int start, int count) { }

	private void Set_v_RecoveryModel_Fields(int start, int count) { }

	private void Set_v_RectangleFootprintModel_Fields(int start, int count) { }

	private void Set_v_RecurringRangsModModel_Fields(int start, int count) { }

	private void Set_v_RedeployModel_Fields(int start, int count) { }

	private void Set_v_RedirectBloonSpawnActionModel_Fields(int start, int count) { }

	private void Set_v_ReflectProjectilesInRadiusActionModel_Fields(int start, int count) { }

	private void Set_v_RefreshPierceModel_Fields(int start, int count) { }

	private void Set_v_RejuvPotionBehaviorModel_Fields(int start, int count) { }

	private void Set_v_ReloadTimeTowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_RemoveAllDotActionModel_Fields(int start, int count) { }

	private void Set_v_RemoveAllMutatorsActionModel_Fields(int start, int count) { }

	private void Set_v_RemoveBloonModifiersModel_Fields(int start, int count) { }

	private void Set_v_RemoveDamageTypeModifierModel_Fields(int start, int count) { }

	private void Set_v_RemoveMutatorOnUpgradeModel_Fields(int start, int count) { }

	private void Set_v_RemoveMutatorsFromBloonModel_Fields(int start, int count) { }

	private void Set_v_RemovePermaBrewModel_Fields(int start, int count) { }

	private void Set_v_RepelModel_Fields(int start, int count) { }

	private void Set_v_ResetRateOnInitialiseModel_Fields(int start, int count) { }

	private void Set_v_RestockGeraldoInventoryOnUpgradeModel_Fields(int start, int count) { }

	private void Set_v_RetargetIncreaseModModel_Fields(int start, int count) { }

	private void Set_v_RetargetOnContactModel_Fields(int start, int count) { }

	private void Set_v_RoadSpikesModel_Fields(int start, int count) { }

	private void Set_v_RoadSpikesPierceModModel_Fields(int start, int count) { }

	private void Set_v_RosaliaMovementModel_Fields(int start, int count) { }

	private void Set_v_RotateModel_Fields(int start, int count) { }

	private void Set_v_RotateToDefaultPositionTowerModel_Fields(int start, int count) { }

	private void Set_v_RotateToMiddleOfTargetsModel_Fields(int start, int count) { }

	private void Set_v_RotateToParentModel_Fields(int start, int count) { }

	private void Set_v_RotateToPointerModel_Fields(int start, int count) { }

	private void Set_v_RotateToTargetAirUnitModel_Fields(int start, int count) { }

	private void Set_v_RotateToTargetAttackOffsetModel_Fields(int start, int count) { }

	private void Set_v_RotateToTargetModel_Fields(int start, int count) { }

	private void Set_v_RoundBasedAttackSpeedModel_Fields(int start, int count) { }

	private void Set_v_SaudaAfflictionDamageModifierModel_Fields(int start, int count) { }

	private void Set_v_SavedSubTowerModel_Fields(int start, int count) { }

	private void Set_v_ScaleDamageWithTimeModel_Fields(int start, int count) { }

	private void Set_v_ScaleProjectileModel_Fields(int start, int count) { }

	private void Set_v_ScaleProjectileOverTimeModel_Fields(int start, int count) { }

	private void Set_v_SeeInvisibilityPotionBehaviorModel_Fields(int start, int count) { }

	private void Set_v_SelectParentOnSelectedModel_Fields(int start, int count) { }

	private void Set_v_SelfStackingSupportCompoundingModel_Fields(int start, int count) { }

	private void Set_v_SellStackedTowersModel_Fields(int start, int count) { }

	private void Set_v_SellTriggerModel_Fields(int start, int count) { }

	private void Set_v_SendToBankModel_Fields(int start, int count) { }

	private void Set_v_SetInvulnerableActionModel_Fields(int start, int count) { }

	private void Set_v_SetSpeedPercentActionModel_Fields(int start, int count) { }

	private void Set_v_SetSpriteFromPierceModel_Fields(int start, int count) { }

	private void Set_v_SetTriggerOnAirUnitFireModel_Fields(int start, int count) { }

	private void Set_v_SharpeningStoneBehaviorModel_Fields(int start, int count) { }

	private void Set_v_SheRaTargetModel_Fields(int start, int count) { }

	private void Set_v_ShopTowerDetailsModel_Fields(int start, int count) { }

	private void Set_v_ShowCashIconInsteadModel_Fields(int start, int count) { }

	private void Set_v_ShowDamageTextModel_Fields(int start, int count) { }

	private void Set_v_ShowTextOnHitModel_Fields(int start, int count) { }

	private void Set_v_SimTowerDiscountModModel_Fields(int start, int count) { }

	private void Set_v_SimulationBehaviorModel_Fields(int start, int count) { }

	private void Set_v_SingleEmissionModel_Fields(int start, int count) { }

	private void Set_v_SingleEmmisionTowardsTargetModel_Fields(int start, int count) { }

	private void Set_v_SkimBloonsModel_Fields(int start, int count) { }

	private void Set_v_SlowBloonsZoneModel_Fields(int start, int count) { }

	private void Set_v_SlowForBloonModel_Fields(int start, int count) { }

	private void Set_v_SlowMaimMoabModel_Fields(int start, int count) { }

	private void Set_v_SlowMinusAbilityDurationModel_Fields(int start, int count) { }

	private void Set_v_SlowModel_Fields(int start, int count) { }

	private void Set_v_SlowModifierForTagModel_Fields(int start, int count) { }

	private void Set_v_SlowModifierForTagModModel_Fields(int start, int count) { }

	private void Set_v_SlowModifierModModel_Fields(int start, int count) { }

	private void Set_v_SlowOnPopModel_Fields(int start, int count) { }

	private void Set_v_SmartTargetTrackModel_Fields(int start, int count) { }

	private void Set_v_SoulBarrierModel_Fields(int start, int count) { }

	private void Set_v_SoundModel_Fields(int start, int count) { }

	private void Set_v_SpawnBloonsActionModel_Fields(int start, int count) { }

	private void Set_v_SpawnBloonsUntilArmourBreaksActionModel_Fields(int start, int count) { }

	private void Set_v_SpawnChildrenModel_Fields(int start, int count) { }

	private void Set_v_SpawnDeathAnimModel_Fields(int start, int count) { }

	private void Set_v_SpawnZombieOnBloonDestroyedModel_Fields(int start, int count) { }

	private void Set_v_SpearModel_Fields(int start, int count) { }

	private void Set_v_SpikeaggedonModel_Fields(int start, int count) { }

	private void Set_v_SpikeParagonDamageZoneModel_Fields(int start, int count) { }

	private void Set_v_SpinModel_Fields(int start, int count) { }

	private void Set_v_SpiritOfTheForestModel_Fields(int start, int count) { }

	private void Set_v_SpiritTowerModel_Fields(int start, int count) { }

	private void Set_v_SpiritTowerMovementModel_Fields(int start, int count) { }

	private void Set_v_SpiritTowerSupportModel_Fields(int start, int count) { }

	private void Set_v_SpiritualWillModel_Fields(int start, int count) { }

	private void Set_v_StandoffModel_Fields(int start, int count) { }

	private void Set_v_StartingCashModModel_Fields(int start, int count) { }

	private void Set_v_StartingShieldModModel_Fields(int start, int count) { }

	private void Set_v_StartOfRoundRateBuffModel_Fields(int start, int count) { }

	private void Set_v_StormModel_Fields(int start, int count) { }

	private void Set_v_StripChildrenModel_Fields(int start, int count) { }

	private void Set_v_StunTowersInRadiusActionModel_Fields(int start, int count) { }

	private void Set_v_SubCommanderSupportModel_Fields(int start, int count) { }

	private void Set_v_SubmergedTargetModel_Fields(int start, int count) { }

	private void Set_v_SubmergeEffectModel_Fields(int start, int count) { }

	private void Set_v_SubmergeModel_Fields(int start, int count) { }

	private void Set_v_SubTowerFilterModel_Fields(int start, int count) { }

	private void Set_v_SuperMonkeyStormModModel_Fields(int start, int count) { }

	private void Set_v_SupportMaxRangeModModel_Fields(int start, int count) { }

	private void Set_v_SupportModel_Fields(int start, int count) { }

	private void Set_v_SupportRemoveFilterOutTagModel_Fields(int start, int count) { }

	private void Set_v_SupportShinobiTacticsModel_Fields(int start, int count) { }

	private void Set_v_SupportStackCounterModel_Fields(int start, int count) { }

	private void Set_v_SupportStackingRangeModel_Fields(int start, int count) { }

	private void Set_v_SwapProjectileModel_Fields(int start, int count) { }

	private void Set_v_SwitchAnimStateForBloonTypeModel_Fields(int start, int count) { }

	private void Set_v_SwitchDisplayModel_Fields(int start, int count) { }

	private void Set_v_SwitchTargetSupplierOnUpgradeModel_Fields(int start, int count) { }

	private void Set_v_SwordChargeModel_Fields(int start, int count) { }

	private void Set_v_SyncCamoDetectionWithTowerModel_Fields(int start, int count) { }

	private void Set_v_SyncProjectileMovementToTowerModel_Fields(int start, int count) { }

	private void Set_v_SyncTargetPriorityWithSubTowersModel_Fields(int start, int count) { }

	private void Set_v_SyphonFundingModel_Fields(int start, int count) { }

	private void Set_v_SyphonManaFromGraveyardsModel_Fields(int start, int count) { }

	private void Set_v_SyphonModel_Fields(int start, int count) { }

	private void Set_v_TakeAimModel_Fields(int start, int count) { }

	private void Set_v_TargetCamoModel_Fields(int start, int count) { }

	private void Set_v_TargetCloseAirUnitModel_Fields(int start, int count) { }

	private void Set_v_TargetCloseModel_Fields(int start, int count) { }

	private void Set_v_TargetClosePrioCamoModel_Fields(int start, int count) { }

	private void Set_v_TargetCloseSharedRangeModel_Fields(int start, int count) { }

	private void Set_v_TargetDesperadoCloseModel_Fields(int start, int count) { }

	private void Set_v_TargetDesperadoFirstModel_Fields(int start, int count) { }

	private void Set_v_TargetDesperadoLastModel_Fields(int start, int count) { }

	private void Set_v_TargetDesperadoModel_Fields(int start, int count) { }

	private void Set_v_TargetDesperadoStrongModel_Fields(int start, int count) { }

	private void Set_v_TargetDivideAndConquerModel_Fields(int start, int count) { }

	private void Set_v_TargetedPineapplesModModel_Fields(int start, int count) { }

	private void Set_v_TargetEliteTargettingModel_Fields(int start, int count) { }

	private void Set_v_TargetFirstAirUnitModel_Fields(int start, int count) { }

	private void Set_v_TargetFirstModel_Fields(int start, int count) { }

	private void Set_v_TargetFirstPrioCamoModel_Fields(int start, int count) { }

	private void Set_v_TargetFirstSharedRangeModel_Fields(int start, int count) { }

	private void Set_v_TargetFirstWithPreferenceModel_Fields(int start, int count) { }

	private void Set_v_TargetFriendlyModel_Fields(int start, int count) { }

	private void Set_v_TargetGrapplableModel_Fields(int start, int count) { }

	private void Set_v_TargetIndependantModel_Fields(int start, int count) { }

	private void Set_v_TargetInFrontOfAirUnitModel_Fields(int start, int count) { }

	private void Set_v_TargetLastAirUnitModel_Fields(int start, int count) { }

	private void Set_v_TargetLastModel_Fields(int start, int count) { }

	private void Set_v_TargetLastPrioCamoModel_Fields(int start, int count) { }

	private void Set_v_TargetLastSharedRangeModel_Fields(int start, int count) { }

	private void Set_v_TargetLeftHandModel_Fields(int start, int count) { }

	private void Set_v_TargetMoabModel_Fields(int start, int count) { }

	private void Set_v_TargetPointerModel_Fields(int start, int count) { }

	private void Set_v_TargetRightHandModel_Fields(int start, int count) { }

	private void Set_v_TargetSelectedPointModel_Fields(int start, int count) { }

	private void Set_v_TargetSelectedPointOrDefaultModel_Fields(int start, int count) { }

	private void Set_v_TargetStrongAirUnitModel_Fields(int start, int count) { }

	private void Set_v_TargetStrongModel_Fields(int start, int count) { }

	private void Set_v_TargetStrongPrioCamoModel_Fields(int start, int count) { }

	private void Set_v_TargetStrongSharedRangeModel_Fields(int start, int count) { }

	private void Set_v_TargetSuppliedPositionModel_Fields(int start, int count) { }

	private void Set_v_TargetSupplierModel_Fields(int start, int count) { }

	private void Set_v_TargetSupplierSupportModel_Fields(int start, int count) { }

	private void Set_v_TargetTrackModel_Fields(int start, int count) { }

	private void Set_v_TargetTrackOrDefaultAcidPoolModel_Fields(int start, int count) { }

	private void Set_v_TargetTrackOrDefaultModel_Fields(int start, int count) { }

	private void Set_v_TargetWererabbitModel_Fields(int start, int count) { }

	private void Set_v_TargetZoneDefenceModel_Fields(int start, int count) { }

	private void Set_v_TCBOOModModel_Fields(int start, int count) { }

	private void Set_v_TechBotLinkModel_Fields(int start, int count) { }

	private void Set_v_TechBotUnlinkModel_Fields(int start, int count) { }

	private void Set_v_TempleTowerMutatorGroupModel_Fields(int start, int count) { }

	private void Set_v_TempleTowerMutatorGroupTierOneModel_Fields(int start, int count) { }

	private void Set_v_TempleTowerMutatorGroupTierTwoModel_Fields(int start, int count) { }

	private void Set_v_TheBlazingSunModel_Fields(int start, int count) { }

	private void Set_v_ThriveModel_Fields(int start, int count) { }

	private void Set_v_ThriveModModel_Fields(int start, int count) { }

	private void Set_v_ThrowBloonsActionModel_Fields(int start, int count) { }

	private void Set_v_ThrowMarkerOffsetModel_Fields(int start, int count) { }

	private void Set_v_TierFiveCountModModel_Fields(int start, int count) { }

	private void Set_v_TimeTriggerModel_Fields(int start, int count) { }

	private void Set_v_TinyTornadoesModModel_Fields(int start, int count) { }

	private void Set_v_TowerBasedShopItemModel_Fields(int start, int count) { }

	private void Set_v_TowerBehaviorBuffModel_Fields(int start, int count) { }

	private void Set_v_TowerBehaviorModel_Fields(int start, int count) { }

	private void Set_v_TowerBehaviorWithOverlayModel_Fields(int start, int count) { }

	private void Set_v_TowerCreateParagonTowerModel_Fields(int start, int count) { }

	private void Set_v_TowerCreateTowerModel_Fields(int start, int count) { }

	private void Set_v_TowerDetailsModel_Fields(int start, int count) { }

	private void Set_v_TowerExpireModel_Fields(int start, int count) { }

	private void Set_v_TowerExpireModModel_Fields(int start, int count) { }

	private void Set_v_TowerExpireOnParentDestroyedModel_Fields(int start, int count) { }

	private void Set_v_TowerExpireOnParentUpgradedModel_Fields(int start, int count) { }

	private void Set_v_TowerFilterModel_Fields(int start, int count) { }

	private void Set_v_TowerModel_Fields(int start, int count) { }

	private void Set_v_TowerMutatorGroupModel_Fields(int start, int count) { }

	private void Set_v_TowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_TowerRadiusModel_Fields(int start, int count) { }

	private void Set_v_TowerSellModModel_Fields(int start, int count) { }

	private void Set_v_TowerXpModModel_Fields(int start, int count) { }

	private void Set_v_TrackTargetModel_Fields(int start, int count) { }

	private void Set_v_TrackTargetOrOrbitTowerModel_Fields(int start, int count) { }

	private void Set_v_TrackTargetWithinTimeModel_Fields(int start, int count) { }

	private void Set_v_TradeEmpireBuffModel_Fields(int start, int count) { }

	private void Set_v_TrampleModel_Fields(int start, int count) { }

	private void Set_v_TranceBloonModel_Fields(int start, int count) { }

	private void Set_v_TranceTotemSpawnerModel_Fields(int start, int count) { }

	private void Set_v_TravelAlongPathModel_Fields(int start, int count) { }

	private void Set_v_TravelCurvyModel_Fields(int start, int count) { }

	private void Set_v_TravelStraitModel_Fields(int start, int count) { }

	private void Set_v_TravelStraitSlowdownModel_Fields(int start, int count) { }

	private void Set_v_TravelTowardsEmitTowerModel_Fields(int start, int count) { }

	private void Set_v_TurboDurationIncreaseModModel_Fields(int start, int count) { }

	private void Set_v_TurboModel_Fields(int start, int count) { }

	private void Set_v_UCAVModel_Fields(int start, int count) { }

	private void Set_v_UnstableConcoctionSplashModel_Fields(int start, int count) { }

	private void Set_v_UpgradeableProjectileModel_Fields(int start, int count) { }

	private void Set_v_UpgradeCostModModel_Fields(int start, int count) { }

	private void Set_v_UpgradeModel_Fields(int start, int count) { }

	private void Set_v_UpgradePathModel_Fields(int start, int count) { }

	private void Set_v_UseAttackRotationModel_Fields(int start, int count) { }

	private void Set_v_UseParentEjectModel_Fields(int start, int count) { }

	private void Set_v_UseParentVisibilityModel_Fields(int start, int count) { }

	private void Set_v_UsePresetTargetModel_Fields(int start, int count) { }

	private void Set_v_UseTowerRangeModel_Fields(int start, int count) { }

	private void Set_v_VagrantWeaponBehaviorModel_Fields(int start, int count) { }

	private void Set_v_VigilanteTowerBehaviorModel_Fields(int start, int count) { }

	private void Set_v_VineRuptureModel_Fields(int start, int count) { }

	private void Set_v_VisibilitySupportModel_Fields(int start, int count) { }

	private void Set_v_VisionModel_Fields(int start, int count) { }

	private void Set_v_WaitForSecondsActionModel_Fields(int start, int count) { }

	private void Set_v_WallOfTreesModel_Fields(int start, int count) { }

	private void Set_v_WanderModel_Fields(int start, int count) { }

	private void Set_v_WeaponBehaviorModel_Fields(int start, int count) { }

	private void Set_v_WeaponCreateTowerModel_Fields(int start, int count) { }

	private void Set_v_WeaponModel_Fields(int start, int count) { }

	private void Set_v_WeaponRateAnimationSpeedModel_Fields(int start, int count) { }

	private void Set_v_WeaponRateMinModel_Fields(int start, int count) { }

	private void Set_v_WeaponReloadPercentageModModel_Fields(int start, int count) { }

	private void Set_v_WeaponReloadPercentageOnTargetPrioModModel_Fields(int start, int count) { }

	private void Set_v_WeaponReloadReductionModModel_Fields(int start, int count) { }

	private void Set_v_WererabbitEmissionModel_Fields(int start, int count) { }

	private void Set_v_WindChanceTowerMutatorModel_Fields(int start, int count) { }

	private void Set_v_WindModel_Fields(int start, int count) { }

	private void Set_v_WindModModel_Fields(int start, int count) { }

	private void Set_v_WindZoneModel_Fields(int start, int count) { }

	private void Set_v_WingmonkeyModModel_Fields(int start, int count) { }

	private void Set_v_WingmonkeyPatternModel_Fields(int start, int count) { }

	private void Set_v_ZeroRotationModel_Fields(int start, int count) { }

	private void Set_v_ZeroRotationOnAbilityModel_Fields(int start, int count) { }

}

