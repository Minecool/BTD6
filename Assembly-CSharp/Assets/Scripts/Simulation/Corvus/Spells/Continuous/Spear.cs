namespace Assets.Scripts.Simulation.Corvus.Spells.Continuous;

public class Spear : CorvusContinuousSpell
{
	private SpearModel spellModel; //Field offset: 0xA0

	public virtual AttackModel SpellAttackModel
	{
		 get { } //Length: 33
	}

	public virtual CorvusContinuousSpellModel SpellModel
	{
		 get { } //Length: 8
	}

	public virtual CorvusSpellType SpellType
	{
		 get { } //Length: 6
	}

	public Spear() { }

	public virtual AttackModel get_SpellAttackModel() { }

	public virtual CorvusContinuousSpellModel get_SpellModel() { }

	public virtual CorvusSpellType get_SpellType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlaySound() { }

	public void Process(int elapsed) { }

	public virtual void ToggleOff() { }

	public virtual void ToggleOn() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

