namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class ProjectileOverTime : BloonBehavior
{
	public ProjectileOverTimeModel projectileOverTimeModel; //Field offset: 0x70
	public int lastTick; //Field offset: 0x78
	private Emission emission; //Field offset: 0x80
	private Vector3 lastPosition; //Field offset: 0x88
	private float lastRotation; //Field offset: 0x94

	public ProjectileOverTime() { }

	public virtual void Attatched() { }

	private void CheckTick() { }

	private void Emit(Vector3 position) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

