namespace Assets.Scripts.Simulation.Physics;

public abstract class Collidable : CommonBehaviorProxy<T>, ICollidable, ICommonBehaviorProxy, IMutable, IRootBehavior, IRootObject
{
	[CompilerGenerated]
	private float <Radius>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private float <VsBlockerRadius>k__BackingField; //Field offset: 0x0

	public override float Radius
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public override float VsBlockerRadius
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	protected Collidable`1() { }

	public override CollisionGroupData[] AdditionalCollisions() { }

	public override void BeginCollision() { }

	public override void EndCollision() { }

	[CompilerGenerated]
	public override float get_Radius() { }

	[CompilerGenerated]
	public override float get_VsBlockerRadius() { }

	public override void PreCollision(Projectile proj) { }

	[CompilerGenerated]
	public void set_Radius(float value) { }

	[CompilerGenerated]
	public void set_VsBlockerRadius(float value) { }

	public override bool ShouldCollideWithMap(MapBlocker mapBlocker) { }

}

