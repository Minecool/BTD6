namespace Assets.Scripts.Simulation.Corvus.TowerManager;

public class CorvusManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<CorvusInstantSpell, CorvusInstantSpellTiming>, Boolean> <>9__88_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<CorvusInstantSpell, CorvusInstantSpellTiming>, CorvusInstantSpell> <>9__88_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<CorvusInstantSpell, CorvusInstantSpellTiming>, Boolean> <>9__89_0; //Field offset: 0x18
		public static Func<KeyValuePair`2<CorvusContinuousSpell, CorvusContinuousSpellTiming>, CorvusSpell> <>9__105_0; //Field offset: 0x20
		public static Func<KeyValuePair`2<CorvusContinuousSpell, CorvusContinuousSpellTiming>, CorvusSpellTiming`1<CorvusContinuousSpell>> <>9__105_1; //Field offset: 0x28
		public static Func<KeyValuePair`2<CorvusInstantSpell, CorvusInstantSpellTiming>, CorvusSpell> <>9__105_2; //Field offset: 0x30
		public static Func<KeyValuePair`2<CorvusInstantSpell, CorvusInstantSpellTiming>, CorvusSpellTiming`1<CorvusInstantSpell>> <>9__105_3; //Field offset: 0x38
		public static Func<KeyValuePair`2<CorvusInstantSpell, CorvusCooldownSpellTiming>, CorvusSpell> <>9__105_4; //Field offset: 0x40
		public static Func<KeyValuePair`2<CorvusInstantSpell, CorvusCooldownSpellTiming>, CorvusSpellTiming`1<CorvusInstantSpell>> <>9__105_5; //Field offset: 0x48
		public static Func<KeyValuePair`2<CorvusInstantSpell, CorvusInstantSpellTiming>, Boolean> <>9__126_0; //Field offset: 0x50
		public static Func<KeyValuePair`2<CorvusInstantSpell, CorvusInstantSpellTiming>, CorvusInstantSpell> <>9__126_1; //Field offset: 0x58
		public static Func<Attack, String> <>9__129_0; //Field offset: 0x60
		public static Func<KeyValuePair`2<CorvusContinuousSpell, CorvusContinuousSpellTiming>, CorvusContinuousSpell> <>9__135_0; //Field offset: 0x68
		public static Func<KeyValuePair`2<CorvusContinuousSpell, CorvusContinuousSpellTiming>, Int32> <>9__151_0; //Field offset: 0x70

		private static <>c() { }

		public <>c() { }

		internal bool <CancelAllSpellsExceptOverload>b__126_0(KeyValuePair<CorvusInstantSpell, CorvusInstantSpellTiming> x) { }

		internal CorvusInstantSpell <CancelAllSpellsExceptOverload>b__126_1(KeyValuePair<CorvusInstantSpell, CorvusInstantSpellTiming> x) { }

		internal int <ConsumeContinuousSpellMana>b__151_0(KeyValuePair<CorvusContinuousSpell, CorvusContinuousSpellTiming> x) { }

		internal bool <EndRecoveryState>b__89_0(KeyValuePair<CorvusInstantSpell, CorvusInstantSpellTiming> x) { }

		internal bool <EnterRecoveryState>b__88_0(KeyValuePair<CorvusInstantSpell, CorvusInstantSpellTiming> x) { }

		internal CorvusInstantSpell <EnterRecoveryState>b__88_1(KeyValuePair<CorvusInstantSpell, CorvusInstantSpellTiming> x) { }

		internal CorvusSpell <GetSaveMetaData>b__105_0(KeyValuePair<CorvusContinuousSpell, CorvusContinuousSpellTiming> x) { }

		internal CorvusSpellTiming<CorvusContinuousSpell> <GetSaveMetaData>b__105_1(KeyValuePair<CorvusContinuousSpell, CorvusContinuousSpellTiming> x) { }

		internal CorvusSpell <GetSaveMetaData>b__105_2(KeyValuePair<CorvusInstantSpell, CorvusInstantSpellTiming> x) { }

		internal CorvusSpellTiming<CorvusInstantSpell> <GetSaveMetaData>b__105_3(KeyValuePair<CorvusInstantSpell, CorvusInstantSpellTiming> x) { }

		internal CorvusSpell <GetSaveMetaData>b__105_4(KeyValuePair<CorvusInstantSpell, CorvusCooldownSpellTiming> x) { }

		internal CorvusSpellTiming<CorvusInstantSpell> <GetSaveMetaData>b__105_5(KeyValuePair<CorvusInstantSpell, CorvusCooldownSpellTiming> x) { }

		internal string <PauseCorvusAttacks>b__129_0(Attack x) { }

		internal CorvusContinuousSpell <ToggleAllActiveContinuousSpells>b__135_0(KeyValuePair<CorvusContinuousSpell, CorvusContinuousSpellTiming> x) { }

	}

	private enum SpiritAbsorptionState
	{
		Released = 0,
		Absorbing = 1,
		Absorbed = 2,
	}

	private const string AttunementBonus = "AttunementBonus"; //Field offset: 0x0
	private const string Key_Timed_FrameToAbsorb = "CorvusMetaData_TimedEvents_frameToAbsorbOn"; //Field offset: 0x0
	private const string Key_Timed_AbsorptionState = "CorvusMetaData_TimedEvents_spiritAbsorptionState"; //Field offset: 0x0
	private const string TimingSeparator = ":"; //Field offset: 0x0
	private const string SpellSeparator = ";"; //Field offset: 0x0
	private const string Key_Spells_Cooldown = "CorvusMetaData_Spells_instantSpellsOnCooldown"; //Field offset: 0x0
	private const string Key_Spells_ActiveInstant = "CorvusMetaData_Spells_activeInstantSpells"; //Field offset: 0x0
	private const string Key_Spells_ActiveContinuous = "CorvusMetaData_Spells_activeContinuousSpells"; //Field offset: 0x0
	private const string Key_SoulBarrier_MaxLivesAbsorbed = "CorvusMetaData_SoulBarrier_soulBarrierMaxLivesAbsorbed"; //Field offset: 0x0
	private const string Key_SoulBarrier_LivesAbsorbed = "CorvusMetaData_SoulBarrier_soulBarrierLivesAbsorbed"; //Field offset: 0x0
	private const string Key_Recovery_FramesActive = "CorvusMetaData_Recovery_recoveryFramesActive"; //Field offset: 0x0
	private const string Key_Recovery_Recovering = "CorvusMetaData_Recovery_isRecovering"; //Field offset: 0x0
	private const string Key_Mana_Available = "CorvusMetaData_Mana_availableMana"; //Field offset: 0x0
	private const string Key_Attunement_MaxDamage = "CorvusMetaData_Attunement_maxDamage"; //Field offset: 0x0
	private const string Key_Attunement_IsActive = "CorvusMetaData_Attunement_isActive"; //Field offset: 0x0
	private const int maxMana = 800; //Field offset: 0x0
	private const string Key_Attunement_MaxSpeed = "CorvusMetaData_Attunement_maxSpeed"; //Field offset: 0x0
	private bool isAttunementActive; //Field offset: 0x10
	private float attunementMaxSpeedMultiplier; //Field offset: 0x14
	private float attunementMaxDamageMultiplier; //Field offset: 0x18
	private Tuple<Int32, Single> originalDamageAtLevel; //Field offset: 0x20
	private Tower cachedCorvus; //Field offset: 0x28
	private SpiritTower cachedSpiritTower; //Field offset: 0x30
	private Simulation Sim; //Field offset: 0x38
	private int owner; //Field offset: 0x40
	public bool updateUiThisFrame; //Field offset: 0x44
	private SpiritTower originalSpiritSubTower; //Field offset: 0x48
	private SpiritTower duplicateSpiritSubTower; //Field offset: 0x50
	private readonly Dictionary<CorvusSpellType, List`1<Projectile>> emittedProjectilesBySpell; //Field offset: 0x58
	private float scale; //Field offset: 0x60
	private readonly SingleEmissionModel emissionModel; //Field offset: 0x68
	private int hauntedBloonMana; //Field offset: 0x70
	private readonly List<Haunt> hauntedBloonBehaviours; //Field offset: 0x78
	private int availableMana; //Field offset: 0x80
	public Func<Single, Single> manaGenerationEquation; //Field offset: 0x88
	private bool isRecovering; //Field offset: 0x90
	private int recoveryFramesActive; //Field offset: 0x94
	private int soulBarrierLivesAbsorbed; //Field offset: 0x98
	private int soulBarrierMaxLivesAbsorbed; //Field offset: 0x9C
	private readonly Dictionary<CorvusSpellType, Type> spellTypeLookup; //Field offset: 0xA0
	private readonly Dictionary<CorvusSpellType, List`1<CorvusSpellType>> spellRestrictions; //Field offset: 0xA8
	private readonly Dictionary<CorvusContinuousSpell, CorvusContinuousSpellTiming> activeContinuousSpells; //Field offset: 0xB0
	private readonly Dictionary<CorvusInstantSpell, CorvusInstantSpellTiming> activeInstantSpells; //Field offset: 0xB8
	private readonly Dictionary<CorvusInstantSpell, CorvusCooldownSpellTiming> instantSpellsOnCooldown; //Field offset: 0xC0
	private List<String> pausedCorvusAttacks; //Field offset: 0xC8
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"action", "frame"}])]
	private readonly LockList<ValueTuple`2<Action, Int32>> queuedEvents; //Field offset: 0xD0
	private SpiritAbsorptionState spiritAbsorptionState; //Field offset: 0xD8
	private int frameToAbsorbOn; //Field offset: 0xDC

	public int AvailableMana
	{
		 get { } //Length: 7
	}

	public float AvailableManaFraction
	{
		 get { } //Length: 20
	}

	public string AvailableManaString
	{
		 get { } //Length: 131
	}

	public SpiritTower GetDuplicateSpiritTower
	{
		 get { } //Length: 5
	}

	public bool IsDuplicateSpiritActive
	{
		 get { } //Length: 9
	}

	public bool IsHauntActive
	{
		 get { } //Length: 64
	}

	public CorvusManager() { }

	[CompilerGenerated]
	private bool <GetCorvus>b__20_0(Tower x) { }

	[CompilerGenerated]
	private bool <GetCorvus>b__20_1(Tower x) { }

	public void ActivateAttunement(float maxSpeedMultiplier, float maxDamageMultiplier) { }

	public void AddMana(int amount) { }

	public void AddMutatorToDuplicate(BehaviorMutator mutator) { }

	public void AnimateDuplicateSpellCast(CorvusSpellModel spellModel) { }

	private void AnimateSpellCast(CorvusSpellModel spellModel) { }

	private void ApplyRecovery() { }

	public void ApplyScaleBonusToDuplicateSpeed(string bonusKey, float scaleBonus) { }

	public void ApplyScaleBonusToDuplicateTurning(string bonusKey, float scaleBonus) { }

	private int CalculateCurrentMaxSoulBarrierAbsorb() { }

	public void CancelAllSpellsExceptOverload() { }

	public void CancelContinuousSpell(CorvusSpellType spellType) { }

	public void CancelInstantSpell(CorvusSpellType spellType) { }

	private bool CanSpellBeCast(CorvusSpellType spellType) { }

	private void CastInstantSpell(CorvusInstantSpell instantSpell) { }

	public void CastSpell(CorvusSpellType spellType) { }

	private static List<CorvusSpellTiming`1<T>> Clone(IEnumerable<CorvusSpellTiming`1<T>> c) { }

	private static List<T> Clone(IEnumerable<T> c) { }

	public int ConsumeAllMana() { }

	private void ConsumeContinuousSpellMana(CorvusContinuousSpell spell) { }

	private string ConvertSpellDictionaryToString(Dictionary<CorvusSpell, CorvusSpellTiming`1<T>> spellDictionary) { }

	private Dictionary<CorvusSpell, CorvusSpellTiming`1<T>> ConvertStringToSpellDictionary(string input, bool isCooldown = false) { }

	private void CopyCastingEffectsFromOriginal() { }

	private void CopyMovementFromOriginal() { }

	private void CopyPausedAttacksFromOriginal() { }

	private void CopyProjectilesFromOriginal() { }

	private void CopyScaleFromOriginal() { }

	public void CreateDuplicateProjectileToFollowPath(CorvusSpellType spellType, Emission emission, ProjectileModel projectileModel, Path path) { }

	public void CreateProjectileAtDuplicate(CorvusSpellType spellType, Emission emission, ProjectileModel projectileModel) { }

	public void DestroyDuplicateProjectilesForSpell(CorvusSpellType spellType) { }

	private void DuplicateProjectileCreated() { }

	public void DuplicateSpiritCreated(SpiritTower original, Tower duplicate) { }

	public void DuplicateSpiritDestroyed() { }

	public void EndRecoveryState() { }

	public void EnterRecoveryState() { }

	private void ExpireInstantSpell(CorvusInstantSpell spell) { }

	private void ExpireSoulBarrier() { }

	private Projectile FindMainProjectile() { }

	public int get_AvailableMana() { }

	public float get_AvailableManaFraction() { }

	public string get_AvailableManaString() { }

	public SpiritTower get_GetDuplicateSpiritTower() { }

	public bool get_IsDuplicateSpiritActive() { }

	public bool get_IsHauntActive() { }

	public Tower GetCorvus() { }

	public List<Projectile> GetDuplicateProjectilesEmittedBySpell(CorvusSpellType spellType) { }

	public float GetDuplicateTowerRotation() { }

	public int GetEffectiveSoulBarrierStrength() { }

	public void GetSaveMetaData(Dictionary<String, String> metaData) { }

	private float GetSpellActiveDurationRemainingPercent(CorvusSpellType spellType) { }

	private float GetSpellCooldownPercent(CorvusSpellType spellType) { }

	public CorvusSpellStatus GetSpellStatus(CorvusSpellType spellType) { }

	public SpiritTower GetSpiritTower() { }

	public TargetingState GetTargetingStateOfDuplicateSpirit() { }

	public TargetingState GetTargetingStateOfSpirit() { }

	private bool HasEnoughManaForSpell(CorvusSpell spell) { }

	public void HauntedBloonCreated(Haunt hauntedBloonBehaviour) { }

	public void Initialise(Simulation Sim, int owner) { }

	public bool IsManaDraining() { }

	public bool IsMutatorOnDuplicate(string mutatorId) { }

	public bool IsSpellActive(CorvusSpell spell) { }

	public bool IsSpellActive(CorvusSpellType spellType) { }

	private bool IsSpellWithProjectileActive() { }

	public bool IsStunned() { }

	private CorvusSpell LookupSpellByType(CorvusSpellType spellType) { }

	private void ManaChanged() { }

	public void MergeWithRedistributedCorvus(Tower theirCorvus) { }

	private void OnBloonDegrade(Bloon bloon, DamageResult damageResult) { }

	private void OnBloonDestroyEvent(RootObject obj) { }

	private void OnCorvusUpgraded() { }

	private void OnDestroy(RootObject obj) { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradecost, bool isfromsave, double cashbefore, double cashafter, bool isinsta) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradecost, int pathupgraded, double cashbefore, double cashafter, bool playupgradeeffect, bool isparagon, bool leveledfromendofroundxp, double nonupgradecashinvestment) { }

	public static void PauseAttack(Entity entity, string attackName) { }

	public void PauseCorvusAttacks() { }

	private void Process(int elapsed) { }

	private void ProcessSpiritAbsorption() { }

	private void QueryBaseDamageModel() { }

	public void QueueEventWithDelay(Action action, int triggerOn) { }

	public void RemoveMutatorToDuplicate(string mutatorId) { }

	public void RemoveScaleBonusToDuplicateSpeed(string bonusKey) { }

	public void RemoveScaleBonusToDuplicateTurning(string bonusKey) { }

	public void ResetAllSpells() { }

	public void ResetDuplicateRehitCooldown() { }

	public void ResetDuplicateScale() { }

	private void ResetManager() { }

	public void ScaleDuplicateRehitCooldown(float scale) { }

	public void ScaleDuplicateSize(float scale) { }

	public void SendSpiritsAlongTrack(float speedBonusFrames) { }

	public void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public void SoulBarrierAbsorbedLives(int lives) { }

	public void SoulBarrierActivated(int maxLivesAbsorbed) { }

	private void TakeInstantSpellOffCooldown(CorvusInstantSpell spell) { }

	private void ToggleAllActiveContinuousSpells() { }

	private void ToggleContinuousSpell(CorvusContinuousSpell continuousSpell) { }

	public void ToggleDuplicateSpellAttacksOff(string spellName) { }

	public void ToggleDuplicateSpellAttacksOn(string spellName) { }

	public void TriggerCorvusToAbsorbSpirit(float duration) { }

	public void TriggerCorvusToReleaseSpirit() { }

	public bool TryConsumeMana(int amount) { }

	public static void UnpauseAttack(Entity entity, string attackName) { }

	public void UnpauseCorvusAttacks() { }

	private void UpdateAttunmentRates() { }

}

