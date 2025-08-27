namespace Assets.Scripts.Simulation.Towers.Emissions;

public class EmissionAtClosestPathSegment : Emission
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Vector2 ejectPointV2; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal float <Emit>b__0(PathSegment segment) { }

	}

	public EmissionAtClosestPathSegmentModel emissionAtClosestPathSegmentModel; //Field offset: 0x70

	public EmissionAtClosestPathSegment() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

