namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class WallOfTrees : ProjectileBehaviorOnEmit
{
	public WallOfTreesModel wallOfTreesModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private float collected; //Field offset: 0x78
	private float cashCollected; //Field offset: 0x7C
	private float baseCashCollected; //Field offset: 0x80

	public WallOfTrees() { }

	public virtual void Collide(Bloon bloon) { }

	public void EmitCash() { }

	public virtual bool FilterCollision(Bloon bloon) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnEmit() { }

	public virtual void PostAttached() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

