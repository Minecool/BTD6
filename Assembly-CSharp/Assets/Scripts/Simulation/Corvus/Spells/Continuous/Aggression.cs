namespace Assets.Scripts.Simulation.Corvus.Spells.Continuous;

public class Aggression : CorvusContinuousSpell
{
	private AggressionModel spellModel; //Field offset: 0xA0

	public virtual CorvusContinuousSpellModel SpellModel
	{
		 get { } //Length: 8
	}

	public virtual CorvusSpellType SpellType
	{
		 get { } //Length: 3
	}

	public Aggression() { }

	public virtual CorvusContinuousSpellModel get_SpellModel() { }

	public virtual CorvusSpellType get_SpellType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	private void ScaleRehitCooldown(float scale) { }

	public virtual void ToggleOff() { }

	public virtual void ToggleOn() { }

	private void UpdateDisplayMutators() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

