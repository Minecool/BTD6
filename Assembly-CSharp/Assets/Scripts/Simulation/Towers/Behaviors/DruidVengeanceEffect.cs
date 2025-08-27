namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DruidVengeanceEffect : TowerBehavior
{
	public DruidVengeanceEffectModel druidVengeanceEffectModel; //Field offset: 0x68
	private int currentEffectTier; //Field offset: 0x70
	private Entity currentEffect; //Field offset: 0x78

	public DruidVengeanceEffect() { }

	private float GetStacks() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnProjectilesCreated(List<Projectile> projectiles) { }

	private void Process(int elapsed) { }

	public void RemoveEffect() { }

	public void RespawnEffect() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateGlowEffectTier() { }

}

