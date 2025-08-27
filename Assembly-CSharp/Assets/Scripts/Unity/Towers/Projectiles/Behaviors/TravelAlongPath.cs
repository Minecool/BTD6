namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TravelAlongPath : ProjectileBehavior
{
	public TravelAlongPath parent; //Field offset: 0x88
	public float range; //Field offset: 0x90
	public string expRange; //Field offset: 0x98
	public float speed; //Field offset: 0xA0
	public string expSpeed; //Field offset: 0xA8
	public bool reverse; //Field offset: 0xB0
	public string expReverse; //Field offset: 0xB8
	public bool disableRotateWithPathDirection; //Field offset: 0xC0
	public string expDisableRotateWithPathDirection; //Field offset: 0xC8
	public float rotationLerp; //Field offset: 0xD0
	public string expRotationLerp; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 212
	}

	public TravelAlongPath() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

