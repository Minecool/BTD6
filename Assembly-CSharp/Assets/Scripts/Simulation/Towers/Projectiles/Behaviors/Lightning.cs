namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Lightning : ProjectileBehavior
{
	private LightningModel lightningModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private int currentDelayFrames; //Field offset: 0x78
	private CreateLightningEffect effectMaker; //Field offset: 0x80
	private bool hitTarget; //Field offset: 0x88
	private List<ObjectId> sharedCollidedWith; //Field offset: 0x90

	public Lightning() { }

	private bool BloonFilter(Bloon bloon) { }

	public void CreateSplit(Bloon bloonToTarget) { }

	public bool HaveAlreadyCollidedWithBloonInLineage(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

