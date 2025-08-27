namespace Assets.Scripts.Simulation.Bloons;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class Bloon : Collidable<IBloonBehavior>
{
	internal struct ChargedMutator
	{
		public int layerCount; //Field offset: 0x0
		public int initialLayerCount; //Field offset: 0x4
		public BehaviorMutator mutator; //Field offset: 0x8

	}

	public struct DamageTask
	{
		public float totalAmount; //Field offset: 0x0
		public Projectile projectile; //Field offset: 0x8
		public bool distributeToChildren; //Field offset: 0x10
		public bool overrideDistributeBlocker; //Field offset: 0x11
		public bool createEffect; //Field offset: 0x12
		public Tower tower; //Field offset: 0x18
		public bool blockSpawnChildren; //Field offset: 0x20
		public BloonProperties immuneBloonProperties; //Field offset: 0x24
		public BloonProperties originalImmuneBloonProperties; //Field offset: 0x28
		public Nullable<Int32> powerActivatedByPlayerId; //Field offset: 0x2C

	}

	private sealed class DisplayLoaded : MulticastDelegate
	{

		public DisplayLoaded(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private int health; //Field offset: 0x158
	public Path _path; //Field offset: 0x160
	public BloonModel bloonModel; //Field offset: 0x168
	public ObjectId layerId; //Field offset: 0x170
	public int lowestLayerNumber; //Field offset: 0x174
	public int spawnRound; //Field offset: 0x178
	public int emissionIndex; //Field offset: 0x17C
	public List<ObjectId> lineage; //Field offset: 0x180
	public DamageResult damageResult; //Field offset: 0x188
	[CompilerGenerated]
	private TowerSet <TowerSetImmunity>k__BackingField; //Field offset: 0x190
	private Queue<BloonArmour> armour; //Field offset: 0x198
	private List<RootBehavior> modelBehaviors; //Field offset: 0x1A0
	private List<Bloon> childrenCreatedOut; //Field offset: 0x1A8
	private List<Projectile> collidingWith; //Field offset: 0x1B0
	private readonly RootObjectLockList<IBloonBehavior> bloonBehaviors; //Field offset: 0x1B8
	[CompilerGenerated]
	private Action<Bloon, DamageResult> OnBloonDegrade; //Field offset: 0x1C0
	[CompilerGenerated]
	private Action<Bloon> OnBloonLeaked; //Field offset: 0x1C8
	[CompilerGenerated]
	private Action<Bloon> OnArmourAdded; //Field offset: 0x1D0
	[CompilerGenerated]
	private Action<Bloon> OnArmourBroken; //Field offset: 0x1D8
	[CompilerGenerated]
	private Action<Bloon> OnBloonLoadedFromSave; //Field offset: 0x1E0
	public Action<Bloon> OnStartedDeathAnim; //Field offset: 0x1E8
	[CompilerGenerated]
	private DisplayLoaded OnDisplayLoaded; //Field offset: 0x1F0
	private float trackScale; //Field offset: 0x1F8
	public float baseScale; //Field offset: 0x1FC
	private float trackSpeedMultiplier; //Field offset: 0x200
	private float globalBloonScale; //Field offset: 0x204
	public string cosmeticId; //Field offset: 0x208
	public ObjectId idLastSave; //Field offset: 0x210
	private bool nonTargetable; //Field offset: 0x214
	private float distanceTraveled; //Field offset: 0x218
	private int createdAtRoundTime; //Field offset: 0x21C
	public int offTrackCount; //Field offset: 0x220
	public int blockSpawnChildrenCount; //Field offset: 0x224
	private List<ChargedMutator> chargedMutators; //Field offset: 0x228
	private List<DamageTask> pendingDamageTasks; //Field offset: 0x230
	private bool isDamaging; //Field offset: 0x238
	private bool isInvunerable; //Field offset: 0x239
	public float prevRot; //Field offset: 0x23C

	public event Action<Bloon> OnArmourAdded
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public event Action<Bloon> OnArmourBroken
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public event Action<Bloon, DamageResult> OnBloonDegrade
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public event Action<Bloon> OnBloonLeaked
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public event Action<Bloon> OnBloonLoadedFromSave
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	private event DisplayLoaded OnDisplayLoaded
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public virtual RootObjectLockList<IBloonBehavior> Behaviors
	{
		 get { } //Length: 8
	}

	public int CreatedAtRoundTime
	{
		 get { } //Length: 7
	}

	public int CurrentArmourAmount
	{
		 get { } //Length: 112
	}

	public float CurrentArmourProportion
	{
		 get { } //Length: 138
	}

	public float DistanceTraveled
	{
		 get { } //Length: 9
	}

	public bool HasArmour
	{
		 get { } //Length: 68
	}

	public Vector2 Heading
	{
		 get { } //Length: 151
	}

	public int Health
	{
		 get { } //Length: 7
	}

	public virtual bool IsInvulnerable
	{
		 get { } //Length: 27
		 set { } //Length: 7
	}

	public bool NonTargetable
	{
		 get { } //Length: 8
	}

	public Path path
	{
		 get { } //Length: 8
	}

	public float TotalSpeedFrames
	{
		 get { } //Length: 43
	}

	public private TowerSet TowerSetImmunity
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public Bloon() { }

	[CompilerGenerated]
	private void <ApplyTowerSetImmunity>b__89_0() { }

	[CompilerGenerated]
	public void add_OnArmourAdded(Action<Bloon> value) { }

	[CompilerGenerated]
	public void add_OnArmourBroken(Action<Bloon> value) { }

	[CompilerGenerated]
	public void add_OnBloonDegrade(Action<Bloon, DamageResult> value) { }

	[CompilerGenerated]
	public void add_OnBloonLeaked(Action<Bloon> value) { }

	[CompilerGenerated]
	public void add_OnBloonLoadedFromSave(Action<Bloon> value) { }

	[CompilerGenerated]
	private void add_OnDisplayLoaded(DisplayLoaded value) { }

	public void AddArmourLayer(BloonArmour armourLayer) { }

	public virtual CollisionGroupData[] AdditionalCollisions() { }

	public virtual void AddMutator(BehaviorMutator mutator, int time = -1, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, bool cascadeMutators = false, bool includeSubTowers = false, bool ignoreRecursionCheck = false, int roundsRemaining = -1, bool isParagonMutator = false, bool cantBeAbsorbed = false) { }

	public void AddMutatorForNumLayers(BehaviorMutator mutator, int time = -1, int layerCount = -1, bool updateDuration = true, bool applyMutation = true, bool cascadeMutators = false, int roundsRemaining = -1) { }

	private void ApplyDamageToArmour(Tower tower, Projectile projectile, int amount, Nullable<Int32> powerActivatedByPlayerId = null) { }

	private void ApplyDamageToBloon(Tower tower, Projectile projectile, int amount, bool distributeToChildren, bool overrideDistributeBlocker, bool blockSpawnChildren, Nullable<Int32> powerActivatedByPlayerId = null) { }

	public float ApplyFractionalDamage(float damage) { }

	public void ApplyTowerSetImmunity(TowerSet immunity) { }

	public virtual void Attatched() { }

	public virtual void BeginCollision() { }

	private float CalculateExtraTagDamageForArmour(DamageModifierForTagModel damageModifierForTag, BloonArmour armour, float baseDamage) { }

	private void ClearCreatedChildren() { }

	public void CopyMutatorsFromBloon(Bloon from) { }

	private void CreateDepletionEffectsForProjectile(Projectile projectile) { }

	public void Damage(float totalAmount, Projectile projectile, bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, Tower tower = null, BloonProperties immuneBloonProperties = 0, BloonProperties originalImmuneBloonProperties = 0, bool canDestroyProjectile = true, bool ignoreNonTargetable = false, bool blockSpawnChildren = false, bool ignoreInvunerable = false, Nullable<Int32> powerActivatedByPlayerId = null) { }

	public void Degrade(Projectile projectile, bool createEffect, Tower tower, bool blockSpawnChildren, Nullable<Int32> powerActivatedByPlayerId) { }

	public void DepleteMutatorsForNumLayers(int layers) { }

	private void DestroyBloon(Tower tower, Projectile projectile, float amount, bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, bool blockSpawnChildren, Nullable<Int32> powerActivatedByPlayerId = null) { }

	public static bool DoesBloonMeetChecks(BloonModel bloonModel, Vector2 fromPos, Vector2 bloonPos, float withinRange = 0, String[] bloonIds = null, bool camoOnly = false, bool regrowOnly = false, bool fortifiedOnly = false, bool moabOnly = false, bool inverseChecks = false) { }

	public virtual void EndCollision() { }

	private void ExecuteDamageTask(float totalAmount, Projectile projectile, bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, Tower tower = null, bool blockSpawnChildren = false, BloonProperties immuneBloonProperties = 0, BloonProperties originalImmuneBloonProperties = 0, Nullable<Int32> powerActivatedByPlayerId = null) { }

	public virtual bool FilterMutation(BehaviorMutator mutator, ICollection<BehaviorMutatorFilter> filters) { }

	private void FlipDisplayLayers(bool flip) { }

	public virtual RootObjectLockList<IBloonBehavior> get_Behaviors() { }

	public int get_CreatedAtRoundTime() { }

	public int get_CurrentArmourAmount() { }

	public float get_CurrentArmourProportion() { }

	public float get_DistanceTraveled() { }

	public bool get_HasArmour() { }

	public Vector2 get_Heading() { }

	public int get_Health() { }

	public virtual bool get_IsInvulnerable() { }

	public bool get_NonTargetable() { }

	public Path get_path() { }

	public float get_TotalSpeedFrames() { }

	[CompilerGenerated]
	public TowerSet get_TowerSetImmunity() { }

	public List<ChargedMutator> GetChargedMutators() { }

	private float GetModifiedArmourDamage(Projectile projectile, BloonArmour armour, float totalAmount) { }

	private float GetModifiedBloonDamage(BloonProperties immuneBloonProperties, BloonProperties originalImmuneBloonProperties, BloonModel bloonModel, float amount, Projectile projectile) { }

	public float GetModifiedTotalLeakDamage() { }

	public BloonSaveDataModel GetSaveData() { }

	public bool HasTag(string checkTag) { }

	public bool HasTags(String[] checkTags) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsBloonValidForPushback() { }

	public bool IsImmuneByProperty(BloonProperties immuneBloonProperties) { }

	public bool IsImmuneByTowerSet(Projectile projectile, Tower tower) { }

	public void LateSetSaveData(Dictionary<String, String> metaData) { }

	public void Leaked() { }

	public void Move(float byAmount) { }

	protected virtual void OnDestroy() { }

	public void OnSpawn() { }

	public float PercThroughMap() { }

	private void PlayImmuneSound(BloonImmuneSound immuneSound) { }

	private ValueTuple<Boolean, Boolean, Boolean> PreCheckDamageOutcome(Projectile projectile, Tower tower, float damageAmount, BloonProperties immuneBloonProperties, BloonProperties originalImmuneBloonProperties, bool ignoreInvulnerable, bool ignoreNonTargetable, bool canDestroyProjectile) { }

	public virtual void PreCollision(Projectile proj) { }

	public void Process(int elapsed) { }

	private void RecieveDamage(int amount, Projectile projectile, bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, Tower tower, bool blockSpawnChildren, bool armourSpawnedThisFrame, Nullable<Int32> powerActivatedByPlayerId = null) { }

	[CompilerGenerated]
	public void remove_OnArmourAdded(Action<Bloon> value) { }

	[CompilerGenerated]
	public void remove_OnArmourBroken(Action<Bloon> value) { }

	[CompilerGenerated]
	public void remove_OnBloonDegrade(Action<Bloon, DamageResult> value) { }

	[CompilerGenerated]
	public void remove_OnBloonLeaked(Action<Bloon> value) { }

	[CompilerGenerated]
	public void remove_OnBloonLoadedFromSave(Action<Bloon> value) { }

	[CompilerGenerated]
	private void remove_OnDisplayLoaded(DisplayLoaded value) { }

	public void RemoveAllMutators() { }

	protected virtual void RemovedMutator(BehaviorMutator mutator) { }

	public void ResetHealth() { }

	public void ResetMutatorChargeCount(string mutatorKey) { }

	public void ResetMutatorChargeCountForId(string mutatorId, bool bailOnFirst = false) { }

	public virtual void set_IsInvulnerable(bool value) { }

	[CompilerGenerated]
	private void set_TowerSetImmunity(TowerSet value) { }

	public void SetHealth(int val) { }

	public void SetPath(Path path, float too, bool updatePosition = true) { }

	public void SetRotation(float rotation) { }

	public void SetSaveData(BloonSaveDataModel saveData) { }

	private void UpdateArmourDamageState() { }

	private void UpdateDisplay() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UpdateLayerId() { }

	private void UpdateTowerAndStats(Tower tower, Projectile projectile, long damageUsed, long nonRegrowEffectiveDamage, Nullable<Int32> powerActivatedByPlayerId = null) { }

	public void UpdateTracking(int playerId, Tower tower, Projectile projectile, long damageDealt) { }

	public bool WillDamageBloon(DamageModel damageModel, Projectile projectile, bool ignoreNonTargetable = false) { }

	public bool WillDestroyBloon(DamageModel damageModel, Projectile projectile, bool ignoreNonTargetable = false) { }

	public bool WillPopBloon(DamageModel damageModel, Projectile projectile, bool ignoreNonTargetable = false) { }

}

