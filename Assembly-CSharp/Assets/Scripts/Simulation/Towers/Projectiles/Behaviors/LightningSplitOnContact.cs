namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class LightningSplitOnContact : ProjectileBehavior
{
	private LightningSplitOnContactModel lightningSplitOnContactModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private Vector3 collidedPosition; //Field offset: 0x78
	private bool isInDelay; //Field offset: 0x84
	private int currentDelayFrames; //Field offset: 0x88

	public LightningSplitOnContact() { }

	private bool BloonFilter(Bloon bloon) { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	private void Split() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

