namespace Assets.Scripts.Simulation.Towers.Weapons;

public class Weapon : AttackBehavior
{
	public int animationStartedAt; //Field offset: 0x68
	public int lastEmission; //Field offset: 0x6C
	public WeaponModel weaponModel; //Field offset: 0x70
	public Emission emmision; //Field offset: 0x78
	private float fractionalPierce; //Field offset: 0x80
	private List<RootBehavior> createdBehaviors; //Field offset: 0x88
	private bool hasFiredThisFrame; //Field offset: 0x90
	private List<AnimationStateOverride> animationStateOverrides; //Field offset: 0x98
	private int rateFrames; //Field offset: 0xA0
	private float missedRate; //Field offset: 0xA4
	private RootObjectLockList<WeaponBehavior> weaponBehaviors; //Field offset: 0xA8
	private WeaponRateMin weaponRateMin; //Field offset: 0xB0
	private float bonusDamageCarryover; //Field offset: 0xB8
	public int animationOffsetFrames; //Field offset: 0xBC
	private Attack mainAttack; //Field offset: 0xC0
	public int blockEmissionUntil; //Field offset: 0xC8
	public Optional<Vector3> overrideTargetPosition; //Field offset: 0xCC
	private List<Projectile> newProjectiles2; //Field offset: 0xE0
	private List<Projectile> newProjectiles; //Field offset: 0xE8

	public bool HasFiredThisFrame
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool IsInThrow
	{
		 get { } //Length: 9
	}

	public bool IsReloadReady
	{
		 get { } //Length: 101
	}

	public int RateFrames
	{
		 get { } //Length: 7
	}

	public Weapon() { }

	private ProjectileModel ApplyExtraDamagePrecision(ProjectileModel projectileDef) { }

	public void ApplyStartingCooldown() { }

	private float CalcRateFrames() { }

	public void Emit(Vector3 ejectPoint, int elapsed, Tower owner, List<Projectile> created, bool doubleShot = false) { }

	public bool get_HasFiredThisFrame() { }

	public bool get_IsInThrow() { }

	public bool get_IsReloadReady() { }

	public int get_RateFrames() { }

	public int GetAnimationOverride(int animation) { }

	public Vector3 GetEjectPosition(bool addDisplaySpaceHeight = true) { }

	public float GetRate(bool forceCalculate) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	private void RoundStart(int roundSpawned) { }

	public void set_HasFiredThisFrame(bool value) { }

	public void SetAnimation(int animation) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SpawnDart(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UpdateMissedFrames() { }

}

