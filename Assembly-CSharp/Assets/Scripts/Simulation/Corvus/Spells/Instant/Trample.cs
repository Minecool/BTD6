namespace Assets.Scripts.Simulation.Corvus.Spells.Instant;

public class Trample : CorvusInstantSpell
{
	private TrampleModel spellModel; //Field offset: 0xA0
	protected Emission emission; //Field offset: 0xA8
	private Projectile projectile; //Field offset: 0xB0
	private Projectile projectileDuplicate; //Field offset: 0xB8

	public virtual CorvusInstantSpellModel SpellModel
	{
		 get { } //Length: 8
	}

	public virtual CorvusSpellType SpellType
	{
		 get { } //Length: 6
	}

	public Trample() { }

	public virtual void Cast() { }

	private void ClearProjectiles() { }

	private void DestroyProjectile(Projectile projectileToDestroy) { }

	public virtual void Expire() { }

	public virtual CorvusInstantSpellModel get_SpellModel() { }

	public virtual CorvusSpellType get_SpellType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnProjectileDestroy(RootObject obj) { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

