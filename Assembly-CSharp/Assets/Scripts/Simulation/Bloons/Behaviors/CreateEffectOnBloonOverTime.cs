namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class CreateEffectOnBloonOverTime : BloonBehavior
{
	public CreateEffectOnBloonOverTimeModel createEffectOnBloonOverTimeModel; //Field offset: 0x70
	public int lastTick; //Field offset: 0x78
	private List<Entity> effects; //Field offset: 0x80
	private string towerName; //Field offset: 0x88

	public CreateEffectOnBloonOverTime() { }

	private void CheckTick() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void PlaySound() { }

	public virtual void PostDegrade(DamageResult damageResult, List<Bloon> childrenCreatedOut, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

