namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RotateSideToTarget : AttackBehavior
{
	public RotateSideToTargetModel rotateToTargetModel; //Field offset: 0x68

	public RotateSideToTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

