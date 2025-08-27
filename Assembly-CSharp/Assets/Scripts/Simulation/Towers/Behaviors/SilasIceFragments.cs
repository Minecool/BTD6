namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SilasIceFragments : TowerBehavior
{
	internal class OrbitingProjectile : IComparable<OrbitingProjectile>
	{
		public int projectileIndex; //Field offset: 0x10
		public Projectile projectile; //Field offset: 0x18

		public OrbitingProjectile() { }

		public override int CompareTo(OrbitingProjectile other) { }

	}

	public SilasIceFragmentsModel silasIceFragmentsModel; //Field offset: 0x68
	private bool isActive; //Field offset: 0x70
	private bool isStunned; //Field offset: 0x71
	public readonly List<OrbitingProjectile> innerOrbitProjectiles; //Field offset: 0x78
	public readonly List<OrbitingProjectile> middleOrbitProjectiles; //Field offset: 0x80
	public readonly List<OrbitingProjectile> outerOrbitProjectiles; //Field offset: 0x88
	private float innerAngle; //Field offset: 0x90
	private float middleAngle; //Field offset: 0x94
	private float outerAngle; //Field offset: 0x98
	private float innerOrbitSpeed; //Field offset: 0x9C
	private float middleOrbitSpeed; //Field offset: 0xA0
	private float outerOrbitSpeed; //Field offset: 0xA4
	private bool isBeingDestroyed; //Field offset: 0xA8
	private int angleOffset; //Field offset: 0xAC

	public SilasIceFragments() { }

	public bool CheckRefresh(List<OrbitingProjectile> orbitingProjectiles) { }

	public void CreateFragment() { }

	private void CreateOrbitingFragment(float orbitDistance, List<OrbitingProjectile> orbitingProjectiles, float rotationTime) { }

	public static void DestroyOrbitingReusables(List<OrbitingProjectile> orbitingProjectiles) { }

	public static void DestroyReusables(IList<T> reusables) { }

	public float IncrementAngle(float angle, bool isCounterClockwise, float speedFrames) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void MoveProjectiles(List<OrbitingProjectile> orbitingProjectiles, float orbitDistance, float angle, int maxProjectilesInOrbit) { }

	protected virtual void OnDestroy() { }

	private void OnProjectileDestoryed(RootObject obj) { }

	public virtual void OnProjectilesCreated(List<Projectile> projectiles) { }

	public void Process(int elapsed) { }

	private bool RemoveOrbitingProjectile(Projectile proj, List<OrbitingProjectile> orbitingProjectiles) { }

	public float ResetAngle(float angle, bool isCounterClockwise) { }

	public void SetActive(bool active) { }

	public void SetStunned(bool stunned) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

