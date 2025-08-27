namespace Assets.Scripts.Simulation.Corvus.Spells.Continuous;

public abstract class CorvusContinuousSpell : CorvusSpell
{

	public abstract CorvusContinuousSpellModel SpellModel
	{
		 get { } //Length: 0
	}

	protected CorvusContinuousSpell() { }

	public abstract CorvusContinuousSpellModel get_SpellModel() { }

	public abstract void ToggleOff() { }

	public abstract void ToggleOn() { }

}

