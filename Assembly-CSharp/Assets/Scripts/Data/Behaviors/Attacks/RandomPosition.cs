namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "RandomPosition", menuName = "BTD6/Behaviors/Attacks/RandomPosition")]
public class RandomPosition : TargetTypeBehavior
{
	public float minDistance; //Field offset: 0x38
	public float maxDistance; //Field offset: 0x3C
	public float targetRadius; //Field offset: 0x40
	public float pointDistance; //Field offset: 0x44
	public bool dontUseTowerPosition; //Field offset: 0x48
	public string areaType; //Field offset: 0x50
	public bool useInverted; //Field offset: 0x58
	public bool ignoreTerrain; //Field offset: 0x59
	public float idealDistanceWithinTrack; //Field offset: 0x5C
	public string towerSet; //Field offset: 0x60

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 319
	}

	public RandomPosition() { }

	public virtual AttackBehaviorModel get_Def() { }

}

