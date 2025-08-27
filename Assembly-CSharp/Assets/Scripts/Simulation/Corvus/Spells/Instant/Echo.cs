namespace Assets.Scripts.Simulation.Corvus.Spells.Instant;

public class Echo : CorvusInstantSpell
{
	private EchoModel spellModel; //Field offset: 0xA0
	private bool awaitingDeferredCast; //Field offset: 0xA8

	public virtual CorvusInstantSpellModel SpellModel
	{
		 get { } //Length: 8
	}

	public virtual CorvusSpellType SpellType
	{
		 get { } //Length: 6
	}

	public Echo() { }

	public virtual void Cast() { }

	public void CreateDuplicateSpirit() { }

	public void DeferCast() { }

	public virtual void Expire() { }

	public virtual CorvusInstantSpellModel get_SpellModel() { }

	public virtual CorvusSpellType get_SpellType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

