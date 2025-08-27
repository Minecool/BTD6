namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class PsiLimitProjectile : WeaponBehavior
{
	public PsiLimitProjectileModel psiLimitProjectileModel; //Field offset: 0x68
	private int canFireAt; //Field offset: 0x70

	public PsiLimitProjectile() { }

	public virtual bool FilterEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnSandboxBloonsCleared() { }

	public void SetCanFireAt(int timestamp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

