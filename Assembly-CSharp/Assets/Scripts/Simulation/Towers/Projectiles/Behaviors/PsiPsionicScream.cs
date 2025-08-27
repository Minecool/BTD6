namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class PsiPsionicScream : ProjectileBehavior
{
	private PsiPsionicScreamModel psiPsionicScreamModel; //Field offset: 0x68

	public PsiPsionicScream() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

