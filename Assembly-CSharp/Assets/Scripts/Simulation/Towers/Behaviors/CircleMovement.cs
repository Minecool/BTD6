namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CircleMovement : TowerBehavior
{
	private float currentAngle; //Field offset: 0x68
	public CircleMovementModel circleMovementModel; //Field offset: 0x70

	public CircleMovement() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

