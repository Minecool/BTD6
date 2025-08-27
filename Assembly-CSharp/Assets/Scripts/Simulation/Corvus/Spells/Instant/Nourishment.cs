namespace Assets.Scripts.Simulation.Corvus.Spells.Instant;

public class Nourishment : CorvusInstantSpell
{
	private NourishmentModel spellModel; //Field offset: 0xA0

	public virtual CorvusInstantSpellModel SpellModel
	{
		 get { } //Length: 8
	}

	public virtual CorvusSpellType SpellType
	{
		 get { } //Length: 6
	}

	public Nourishment() { }

	public virtual void Cast() { }

	public virtual void Expire() { }

	public virtual CorvusInstantSpellModel get_SpellModel() { }

	public virtual CorvusSpellType get_SpellType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlaySound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

