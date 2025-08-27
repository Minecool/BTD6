namespace Assets.Scripts.Models.ContestedTerritory;

public class CtIncreasedProjectileLifespanModModel : MutatorModModel
{
	public float increasedLifespan; //Field offset: 0x30

	public CtIncreasedProjectileLifespanModModel(string name, float increasedLifespan) { }

	private void ApplyToAnyAgeModels(ProjectileModel projectile) { }

	private void ApplyToAnyLinearTravelModels(ProjectileModel projectile) { }

	private void ApplyToAnyTravelAlongPathModels(ProjectileModel projectile) { }

	private void ApplyToAnyTravelCurvyModels(ProjectileModel projectile) { }

	private void ApplyToAnyTravelStraightSlowdownModels(ProjectileModel projectile) { }

	private void ApplyToAnyTravelStraitModels(ProjectileModel projectile) { }

	private void ApplyToAnyTravelTowardsEmitTowerModels(ProjectileModel projectile) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

