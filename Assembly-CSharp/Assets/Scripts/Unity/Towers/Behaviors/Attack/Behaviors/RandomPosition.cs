namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class RandomPosition : TargetTypeBehavior
{
	public RandomPosition parent; //Field offset: 0x98
	public float minDistance; //Field offset: 0xA0
	public string expMinDistance; //Field offset: 0xA8
	public float maxDistance; //Field offset: 0xB0
	public string expMaxDistance; //Field offset: 0xB8
	public float targetRadius; //Field offset: 0xC0
	public string expTargetRadius; //Field offset: 0xC8
	public float pointDistance; //Field offset: 0xD0
	public string expPointDistance; //Field offset: 0xD8
	public bool dontUseTowerPosition; //Field offset: 0xE0
	public string expDontUseTowerPosition; //Field offset: 0xE8
	public string areaType; //Field offset: 0xF0
	public string expAreaType; //Field offset: 0xF8
	public bool useInverted; //Field offset: 0x100
	public string expUseInverted; //Field offset: 0x108
	public bool ignoreTerrain; //Field offset: 0x110
	public string expIgnoreTerrain; //Field offset: 0x118
	public float idealDistanceWithinTrack; //Field offset: 0x120
	public string expIdealDistanceWithinTrack; //Field offset: 0x128
	public string towerSet; //Field offset: 0x130
	public string expTowerSet; //Field offset: 0x138

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 361
	}

	public RandomPosition() { }

	public virtual AttackBehaviorModel get_Def() { }

}

