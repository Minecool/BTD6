namespace Assets.Scripts.Simulation.Objects;

public interface ICollidable : ICommonBehaviorProxy, IMutable, IRootBehavior, IRootObject
{

	public float Radius
	{
		 get { } //Length: 0
	}

	public float VsBlockerRadius
	{
		 get { } //Length: 0
	}

	public CollisionGroupData[] AdditionalCollisions() { }

	public void BeginCollision() { }

	public void EndCollision() { }

	public float get_Radius() { }

	public float get_VsBlockerRadius() { }

	public void PreCollision(Projectile proj) { }

}

