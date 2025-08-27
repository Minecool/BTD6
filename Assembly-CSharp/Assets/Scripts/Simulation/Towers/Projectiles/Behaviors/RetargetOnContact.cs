namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RetargetOnContact : ProjectileBehavior
{
	public RetargetOnContactModel retargetOnContactModel; //Field offset: 0x68
	private int currentBounceCount; //Field offset: 0x70
	private int startFrame; //Field offset: 0x74
	private bool useDelay; //Field offset: 0x78
	private FilterAllExceptTarget disableFilterForTargetAquire; //Field offset: 0x80
	private bool processing; //Field offset: 0x88

	public RetargetOnContact() { }

	public virtual void Attatched() { }

	private bool BloonFilter(Bloon bloon) { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	private void Retarget() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

