namespace Assets.Scripts.Simulation.Bloons.Behaviors.Actions;

public class ReflectProjectilesInRadiusAction : BloonBehaviorAction
{
	private const float DirectionVectorTolerance = 0.01; //Field offset: 0x0
	private const float MinimumDampeningEffect = 0.25; //Field offset: 0x0
	private const float DistanceUnitTolerance = 1; //Field offset: 0x0
	public ReflectProjectilesInRadiusActionModel modl; //Field offset: 0x78
	public int finalTick; //Field offset: 0x80
	private float innerRadiusSquared; //Field offset: 0x84
	private float outerRadiusSquared; //Field offset: 0x88
	private bool isShieldAnimating; //Field offset: 0x8C

	public ReflectProjectilesInRadiusAction() { }

	private static int ApproximateDirectionVectorComponent(float value) { }

	private bool ApproximateIfProjectileIsAimingAtBloon(Projectile projectile) { }

	private static int ApproximateNormalisedDistance(float value, float target) { }

	public virtual void Attatched() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public void Process(int elapsed) { }

	private void ReflectProjectile(Projectile projectile) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SetShieldAnimation(bool on) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

