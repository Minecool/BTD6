namespace Assets.Scripts.Simulation.Objects;

public interface IWeaponBehavior : IEntityBehavior
{

	public bool CanFire() { }

	public void EmissionStarted() { }

	public Nullable<Vector3> EmitPosition() { }

	public Nullable<Single> EmitRotation() { }

	public bool FilterEmission() { }

	public Nullable<Int32> GetAnimation(int currentAnimation) { }

	public Emission GetEmission(Emission currentEmissionDef, bool doubleShot = false) { }

	public ProjectileModel GetProjectile(ProjectileModel currentProjectileDef, bool doubleShot = false) { }

	public float GetRate(float rate) { }

	public bool OnPreEmissionCheck() { }

	public void ProjectilesCreated(List<Projectile> projectiles) { }

}

