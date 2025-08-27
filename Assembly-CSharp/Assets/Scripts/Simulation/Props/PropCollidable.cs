namespace Assets.Scripts.Simulation.Props;

public class PropCollidable : PropBase, ICollidable, ICommonBehaviorProxy, IMutable, IRootBehavior, IRootObject
{
	[CompilerGenerated]
	private float <Radius>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private float <VsBlockerRadius>k__BackingField; //Field offset: 0x214

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

	public PropCollidable() { }

	public override CollisionGroupData[] AdditionalCollisions() { }

	public override void BeginCollision() { }

	public void Degrade() { }

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

	public bool ShouldCollideWithMap(MapBlocker mapBlocker) { }

}

