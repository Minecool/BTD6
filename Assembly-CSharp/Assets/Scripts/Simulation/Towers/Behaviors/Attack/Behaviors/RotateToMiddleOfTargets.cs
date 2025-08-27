namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RotateToMiddleOfTargets : AttackBehavior
{
	public RotateToMiddleOfTargetsModel rotateToMiddleOfTargetsModel; //Field offset: 0x68

	public RotateToMiddleOfTargets() { }

	protected override void ApplyRotation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void SetUpAttack() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

