namespace Assets.Scripts.Simulation.Corvus.Spells.Continuous;

public class Malevolence : CorvusContinuousSpell
{
	private MalevolenceModel spellModel; //Field offset: 0xA0

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

	public Malevolence() { }

	public virtual AttackModel get_SpellAttackModel() { }

	public virtual CorvusContinuousSpellModel get_SpellModel() { }

	public virtual CorvusSpellType get_SpellType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PauseAttacks() { }

	private void PlaySound() { }

	public void Process(int elapsed) { }

	public virtual void ToggleOff() { }

	public virtual void ToggleOn() { }

	public virtual void ToggleSpellAttacksOff(string spellName) { }

	public virtual void ToggleSpellAttacksOn(string spellName) { }

	private void UnpauseAttacks() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

