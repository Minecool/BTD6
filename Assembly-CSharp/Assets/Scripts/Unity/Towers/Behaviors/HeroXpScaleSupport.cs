namespace Assets.Scripts.Unity.Towers.Behaviors;

public class HeroXpScaleSupport : SupportBehavior
{
	public HeroXpScaleSupport parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public float heroXpScale; //Field offset: 0xE0
	public string expHeroXpScale; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 193
	}

	public HeroXpScaleSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

