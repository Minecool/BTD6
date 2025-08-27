namespace Assets.Scripts.Simulation.Corvus.Spells.Instant;

public class Overload : CorvusInstantSpell
{
	private OverloadModel spellModel; //Field offset: 0xA0
	protected Emission emission; //Field offset: 0xA8

	public virtual CorvusInstantSpellModel SpellModel
	{
		 get { } //Length: 8
	}

	public virtual CorvusSpellType SpellType
	{
		 get { } //Length: 6
	}

	public Overload() { }

	public virtual void Cast() { }

	public virtual void Expire() { }

	public virtual CorvusInstantSpellModel get_SpellModel() { }

	public virtual CorvusSpellType get_SpellType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlaySound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

