namespace Assets.Scripts.Simulation.Corvus.Spells.Instant;

public abstract class CorvusInstantSpell : CorvusSpell
{

	public abstract CorvusInstantSpellModel SpellModel
	{
		 get { } //Length: 0
	}

	protected CorvusInstantSpell() { }

	public abstract void Cast() { }

	public abstract void Expire() { }

	public abstract CorvusInstantSpellModel get_SpellModel() { }

}

