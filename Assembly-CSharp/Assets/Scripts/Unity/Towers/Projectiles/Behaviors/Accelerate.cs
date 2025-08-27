namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Accelerate : ProjectileBehavior
{
	public Accelerate parent; //Field offset: 0x88
	public float acceleration; //Field offset: 0x90
	public string expAcceleration; //Field offset: 0x98
	public float maxSpeed; //Field offset: 0xA0
	public string expMaxSpeed; //Field offset: 0xA8
	public float turnRateChange; //Field offset: 0xB0
	public string expTurnRateChange; //Field offset: 0xB8
	public float maxTurnRate; //Field offset: 0xC0
	public string expMaxTurnRate; //Field offset: 0xC8
	public bool decelerate; //Field offset: 0xD0
	public string expDecelerate; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 265
	}

	public Accelerate() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

