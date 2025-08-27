namespace Assets.Scripts.Unity.Towers.Behaviors;

public class OrbitingTower : TowerBehavior
{
	public OrbitingTower parent; //Field offset: 0x98
	public float rotationDegreesPerFrame; //Field offset: 0xA0
	public string expRotationDegreesPerFrame; //Field offset: 0xA8
	public float radius; //Field offset: 0xB0
	public string expRadius; //Field offset: 0xB8
	public bool ignoreRotation; //Field offset: 0xC0
	public string expIgnoreRotation; //Field offset: 0xC8
	public float offsetHeight; //Field offset: 0xD0
	public string expOffsetHeight; //Field offset: 0xD8
	public bool dontUseParentOrigin; //Field offset: 0xE0
	public string expDontUseParentOrigin; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 225
	}

	public OrbitingTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

