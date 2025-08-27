namespace Assets.Scripts.Simulation.Corvus.Spells;

public abstract class CorvusSpell : TowerBehavior
{
	internal enum SpellAttackState
	{
		NoAttack_ForSpell = 0,
		Awaiting_Initialise = 1,
		Paused_FromInitialise = 2,
		Paused_FromSpellbook = 3,
		Active = 4,
	}

	public CorvusSpellModel corvusSpellModel; //Field offset: 0x68
	protected List<Projectile> emittedProjectiles; //Field offset: 0x70
	protected SpellAttackState attackState; //Field offset: 0x78
	protected bool needsSpellAttacksSynced; //Field offset: 0x7C
	[CompilerGenerated]
	private readonly AttackModel <SpellAttackModel>k__BackingField; //Field offset: 0x80
	private Entity effectAtCorvus; //Field offset: 0x88
	private Entity effectAtSpirit; //Field offset: 0x90
	private Entity effectAtDuplicateSpirit; //Field offset: 0x98

	public CorvusManager Corvus
	{
		 get { } //Length: 54
	}

	public bool HasEffectAtSpirit
	{
		 get { } //Length: 12
	}

	public override AttackModel SpellAttackModel
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public abstract CorvusSpellType SpellType
	{
		 get { } //Length: 0
	}

	public override Projectile SpiritProjectile
	{
		 get { } //Length: 120
	}

	public override SpiritTower SpiritTower
	{
		 get { } //Length: 486
	}

	public CorvusSpell() { }

	public void CreateCastingEffects() { }

	public void CreateEffectAtDuplicateSpirit() { }

	public override void CreateProjectileAt(Emission emission, ProjectileModel projectileModel, Vector3 position) { }

	public override void CreateProjectileAtSpirit(Emission emission, ProjectileModel projectileModel) { }

	public CorvusManager get_Corvus() { }

	public bool get_HasEffectAtSpirit() { }

	[CompilerGenerated]
	public override AttackModel get_SpellAttackModel() { }

	public abstract CorvusSpellType get_SpellType() { }

	public override Projectile get_SpiritProjectile() { }

	public override SpiritTower get_SpiritTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnEffectDestroyed(RootObject destroyedEffectObject) { }

	public void OnSpellCastEnded() { }

	public void OnSpellCastStarted() { }

	private void Process(int elapsed) { }

	public void SyncSpellAttacksWithManagerState() { }

	public override void ToggleSpellAttacksOff(string spellName) { }

	public override void ToggleSpellAttacksOn(string spellName) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

