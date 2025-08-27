namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class PsiBloonBehavior : BloonBehavior
{
	public PsiBloonBehaviorModel psiBloonBehaviorModel; //Field offset: 0x70
	private Emission emission; //Field offset: 0x78
	private int addedAt; //Field offset: 0x80

	public PsiBloonBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDegrade(Projectile projectile, Bloon degradedBloon, Tower poppedBy, DamageResult damageResult) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateTremble() { }

}

