namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RotateToParent : AttackBehavior
{
	public RotateToParentModel rotateToParentModel; //Field offset: 0x68

	public RotateToParent() { }

	protected override void ApplyRotation() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

