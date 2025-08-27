namespace Assets.Scripts.Simulation.Towers.Projectiles;

[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
[Il2CppSetOption(Option::NullChecks (1), False)]
public class Projectile : Collidable<IProjectileBehavior>
{
	internal struct CritRoll
	{
		public float damageAdditive; //Field offset: 0x0
		public float damageMultiplier; //Field offset: 0x4
		public float chance; //Field offset: 0x8
		public PrefabReference critDisplay; //Field offset: 0x10
		public bool hasRolled; //Field offset: 0x18
		public bool rollSuccess; //Field offset: 0x19

	}

	public ProjectileModel projectileModel; //Field offset: 0x158
	public List<ObjectId> collidedWith; //Field offset: 0x160
	private readonly List<RootBehavior> createdBehaviors; //Field offset: 0x168
	private readonly List<IProjectileBehavior> projectileBehaviorsOrderedByPass; //Field offset: 0x170
	private readonly RootObjectLockList<IProjectileBehavior> projectileBehaviors; //Field offset: 0x178
	public Age ageBehavior; //Field offset: 0x180
	public Vector3 emittedFrom; //Field offset: 0x188
	public float pierce; //Field offset: 0x194
	public int timeSinceLastCollisionCheck; //Field offset: 0x198
	public bool dynamicCollision; //Field offset: 0x19C
	public bool onlyHitMoab; //Field offset: 0x19D
	public bool cantHitMoab; //Field offset: 0x19E
	public bool cantHitCamo; //Field offset: 0x19F
	public bool canCollideWithBloons; //Field offset: 0x1A0
	public bool isPowerProjectile; //Field offset: 0x1A1
	public string powerId; //Field offset: 0x1A8
	private DestroyedEventHandler destroyedEvent; //Field offset: 0x1B0
	private Tower emittedBy; //Field offset: 0x1B8
	[CompilerGenerated]
	private TowerSet <ParentTowerSet>k__BackingField; //Field offset: 0x1C0
	public List<CritRoll> critRolls; //Field offset: 0x1C8
	private PrefabReference chosenCritDisplay; //Field offset: 0x1D0
	public bool hasSpawnedCritEffect; //Field offset: 0x1D8
	[CompilerGenerated]
	private Weapon <Weapon>k__BackingField; //Field offset: 0x1E0
	private Target _target; //Field offset: 0x1E8
	[CompilerGenerated]
	private float <EjectRotation>k__BackingField; //Field offset: 0x230

	public int Age
	{
		 get { } //Length: 27
	}

	public virtual RootObjectLockList<IProjectileBehavior> Behaviors
	{
		 get { } //Length: 8
	}

	public PrefabReference ChosenCritDisplay
	{
		 get { } //Length: 8
	}

	public float EjectRotation
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public virtual Tower EmittedBy
	{
		 get { } //Length: 8
		 set { } //Length: 584
	}

	public ObjectId EmittedByTowerId
	{
		 get { } //Length: 76
	}

	public float ExhaustDurationFraction
	{
		 get { } //Length: 93
	}

	public float ExhaustFraction
	{
		 get { } //Length: 143
	}

	public float ExhaustPeirceFraction
	{
		 get { } //Length: 33
	}

	public int owner
	{
		 get { } //Length: 61
		 set { } //Length: 77
	}

	public TowerSet ParentTowerSet
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public virtual Target target
	{
		 get { } //Length: 60
		 set { } //Length: 612
	}

	public Weapon Weapon
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Projectile() { }

	public void AddCritRoll(float damageAdditive, float damageMultiplier, float chance, PrefabReference critDisplay) { }

	public virtual void Attatched() { }

	private bool CalcCantTargetCamo() { }

	private bool CalcCantTargetMoab() { }

	private bool CalcOnlyTargetsMoab() { }

	private bool CanBeDepleted() { }

	public bool CanProjectileCollide() { }

	public override void CollideBlocker() { }

	public bool CollideBloon(Bloon bloon, bool ignorePreCollisionChecks = false) { }

	public void CollideBloons(CollisionState<Bloon> colliding) { }

	public void CollideBloons(IEnumerable<Bloon> colliding, int count = 999999999, List<Vector3> collisionPositions = null) { }

	private bool CollideCollideable(PropCollidable collideable, bool ignorePreCollisionChecks = false) { }

	public void CollideCollideables(CollisionState<PropCollidable> colliding) { }

	public void CollideMap(MapBlocker mapBlocker) { }

	public void Deplete() { }

	private void Exhausted() { }

	public virtual void Expire() { }

	private void Expired() { }

	public bool FilterBloon(Bloon bloon) { }

	public int get_Age() { }

	public virtual RootObjectLockList<IProjectileBehavior> get_Behaviors() { }

	public PrefabReference get_ChosenCritDisplay() { }

	[CompilerGenerated]
	public float get_EjectRotation() { }

	public virtual Tower get_EmittedBy() { }

	public ObjectId get_EmittedByTowerId() { }

	public float get_ExhaustDurationFraction() { }

	public float get_ExhaustFraction() { }

	public float get_ExhaustPeirceFraction() { }

	public int get_owner() { }

	[CompilerGenerated]
	public TowerSet get_ParentTowerSet() { }

	public virtual Target get_target() { }

	[CompilerGenerated]
	public Weapon get_Weapon() { }

	public Vector3 GetPositionOfTarget() { }

	public ProjectileSaveDataModel GetSaveData() { }

	public bool HasValidBloonCollision() { }

	public bool HasValidPropCollision() { }

	public bool HaveAlreadyCollidedWithBloonInLineage(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsCollisionValid(Bloon bloon) { }

	public void LateSetSaveData(ProjectileSaveDataModel projSaveData) { }

	protected virtual void OnDestroy() { }

	public void OnTowerDestroyed(RootObject obj) { }

	public virtual float Pickup() { }

	public float RollForCrits(float baseDamage) { }

	[CompilerGenerated]
	public void set_EjectRotation(float value) { }

	public virtual void set_EmittedBy(Tower value) { }

	public void set_owner(int value) { }

	[CompilerGenerated]
	public void set_ParentTowerSet(TowerSet value) { }

	public virtual void set_target(Target value) { }

	[CompilerGenerated]
	public void set_Weapon(Weapon value) { }

	public void SetCollisionPasses() { }

	private void SetParentTowerSet() { }

	public void SetSaveData(ProjectileSaveDataModel projSaveData) { }

	public void SetStartPosition(Vector3 pos) { }

	public virtual bool ShouldCollideWithMap(MapBlocker mapBlocker) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

