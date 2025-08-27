namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class Grow : BloonBehavior
{
	public GrowModel growModel; //Field offset: 0x70
	public int timeTillGrow; //Field offset: 0x78
	public int growCeilingLayerNumber; //Field offset: 0x7C
	public string growTo; //Field offset: 0x80
	public string growToChildColor; //Field offset: 0x88
	public string growToParentColor; //Field offset: 0x90
	private bool init; //Field offset: 0x98
	public int growBlockCount; //Field offset: 0x9C

	public Grow() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public void Process(int elapsed) { }

	public void Regenerate() { }

	public void ResetTimeUntilGrow() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

