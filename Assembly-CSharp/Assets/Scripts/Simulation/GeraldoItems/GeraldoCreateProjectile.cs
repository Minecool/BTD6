namespace Assets.Scripts.Simulation.GeraldoItems;

public class GeraldoCreateProjectile : GeraldoItemBehavior
{

	public GeraldoCreateProjectile() { }

	public virtual void Activate(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	public virtual bool CheckLocation(Vector2 location, int inputId) { }

	public void CreateProjectile(GeraldoCreateProjectileModel createProjectileModel, Vector2 location, ProjectileModel projModel, int inputId, Tower geraldo) { }

}

