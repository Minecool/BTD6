namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class KineticChargeProjectile : ProjectileBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Bloon, Single> <>9__15_0; //Field offset: 0x8
		public static Func<Bloon, Single> <>9__15_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <GetBloonTarget>b__15_0(Bloon possibleTarget) { }

		internal float <GetBloonTarget>b__15_1(Bloon possibleTarget) { }

	}

	public KineticChargeProjectileModel kineticChargeProjectileModel; //Field offset: 0x68
	private Vector2 deployTo; //Field offset: 0x70
	private bool isFlyingTowardsTarget; //Field offset: 0x78
	private Bloon attachedBloon; //Field offset: 0x80
	private int attachedAt; //Field offset: 0x88
	private int healthAtAttached; //Field offset: 0x8C
	private SingleEmission emission; //Field offset: 0x90
	private Tower parentTower; //Field offset: 0x98
	private bool explodeNextMovement; //Field offset: 0xA0

	public KineticChargeProjectile() { }

	private void AttachToBloon(Bloon bloon) { }

	public virtual void Collide(Bloon bloon) { }

	private void Explode() { }

	private Bloon GetBloonTarget() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBloonValid(Bloon bloon) { }

	private bool IsBloonVisible(Bloon bloon) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	private void OnAttachedBloonDestroyed(RootObject obj) { }

	protected virtual void OnDestroy() { }

	protected override void Process(int elapsed) { }

	public virtual void SetStartPosition(Vector3 pos) { }

	private void StartFlyingTowardsTarget(Bloon bloon) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateMovement() { }

}

