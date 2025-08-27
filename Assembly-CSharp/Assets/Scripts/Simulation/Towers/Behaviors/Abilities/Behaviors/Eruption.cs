namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class Eruption : AbilityBehavior
{
	public const string mutatorId = "Eruption"; //Field offset: 0x0
	public EruptionModel eruptionModel; //Field offset: 0x68
	public EruptionMutator mutator; //Field offset: 0x70
	private ActivateAttack activateAttack; //Field offset: 0x78

	public Eruption() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

