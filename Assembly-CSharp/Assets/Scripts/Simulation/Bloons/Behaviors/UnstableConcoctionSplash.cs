namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class UnstableConcoctionSplash : EmitOnPop
{
	private UnstableConcoctionSplashModel unstableConcoctionSplash; //Field offset: 0x88
	private Emission emission; //Field offset: 0x90

	public UnstableConcoctionSplash() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PreDegrade(DamageResult damageResult, List<Projectile> collidingWith, bool createEffect, Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

