namespace Assets.Scripts.Unity.Towers.Behaviors;

public class BananaCashIncreaseSupport : SupportBehavior
{
	public BananaCashIncreaseSupport parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public float multiplier; //Field offset: 0xE0
	public string expMultiplier; //Field offset: 0xE8
	public string mutatorId; //Field offset: 0xF0
	public string expMutatorId; //Field offset: 0xF8
	public bool useTiers; //Field offset: 0x100
	public string expUseTiers; //Field offset: 0x108
	public int firstPathTier; //Field offset: 0x110
	public string expFirstPathTier; //Field offset: 0x118
	public int secondPathTier; //Field offset: 0x120
	public string expSecondPathTier; //Field offset: 0x128
	public int thirdPathTier; //Field offset: 0x130
	public string expThirdPathTier; //Field offset: 0x138

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 335
	}

	public BananaCashIncreaseSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

