namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Rotate : ProjectileBehavior
{
	public RotateModel rotateModel; //Field offset: 0x68

	public Rotate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

