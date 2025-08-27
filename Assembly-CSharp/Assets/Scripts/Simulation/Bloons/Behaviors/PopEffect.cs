namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class PopEffect : BloonBehavior
{
	private const float displayTime = 0.1; //Field offset: 0x0
	private const int effectLimit = 10; //Field offset: 0x0
	public PopEffectModel def; //Field offset: 0x70
	public int lastEffect; //Field offset: 0x78

	public PopEffect() { }

	public void CreateEffect() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayPopSound() { }

	public virtual void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

