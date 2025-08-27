namespace Assets.Scripts.Simulation.Corvus.Spells.Instant;

public class SoulBarrier : CorvusInstantSpell
{
	private struct DamageAbsorbers
	{
		public float soulBarrier; //Field offset: 0x0
		public float manaShield; //Field offset: 0x4
		public float lives; //Field offset: 0x8
		public float livesAbsorbedByBarrier; //Field offset: 0xC

		public DamageAbsorbers(float soulBarrier, float manaShield, float lives) { }

		public void SplitDamage(float damage) { }

	}

	public SoulBarrierModel spellModel; //Field offset: 0xA0

	public virtual CorvusInstantSpellModel SpellModel
	{
		 get { } //Length: 8
	}

	public virtual CorvusSpellType SpellType
	{
		 get { } //Length: 6
	}

	public SoulBarrier() { }

	private void BloonManager_OnBloonLeaked(Bloon bloon, float livesBefore, float livesAfter, float manaShieldBefore, float manaShieldAfter) { }

	public virtual void Cast() { }

	public virtual void Expire() { }

	public virtual CorvusInstantSpellModel get_SpellModel() { }

	public virtual CorvusSpellType get_SpellType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void PlaySound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

