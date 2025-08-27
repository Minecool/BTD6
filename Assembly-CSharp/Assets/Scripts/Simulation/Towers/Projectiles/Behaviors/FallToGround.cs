namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class FallToGround : ProjectileBehavior
{
	public FallToGroundModel fallModel; //Field offset: 0x68
	private float speed; //Field offset: 0x70
	private float groundHeight; //Field offset: 0x74

	public FallToGround() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void SetStartPosition(Vector3 pos) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

