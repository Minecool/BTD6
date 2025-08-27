namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class PsiEffect : ProjectileBehavior
{
	private PsiEffectModel psiEffectModel; //Field offset: 0x68
	private PsiLimitProjectile limitProjectile; //Field offset: 0x70

	public PsiEffect() { }

	private void CheckEndOfRoundCap() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

