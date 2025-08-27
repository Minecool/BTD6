namespace Assets.Scripts.Simulation.Corvus.Spells.Instant;

public class Vision : CorvusInstantSpell
{
	internal class VisionMutator : BehaviorMutator
	{

		public VisionMutator(string mutatorId) { }

		private void ChangeTowerModel(TowerModel towerModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private VisionModel spellModel; //Field offset: 0xA0
	private VisionMutator visionMutator; //Field offset: 0xA8

	public virtual CorvusInstantSpellModel SpellModel
	{
		 get { } //Length: 8
	}

	public virtual CorvusSpellType SpellType
	{
		 get { } //Length: 31
	}

	public Vision() { }

	public virtual void Cast() { }

	public virtual void Expire() { }

	public virtual CorvusInstantSpellModel get_SpellModel() { }

	public virtual CorvusSpellType get_SpellType() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlaySound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

