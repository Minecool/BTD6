namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class HideAttackDisplayIfPaused : AttackBehavior
{
	public HideAttackDisplayIfPausedModel hideAttackDisplayIfPausedModel; //Field offset: 0x68

	public HideAttackDisplayIfPaused() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	private void UpdateDisplay() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

