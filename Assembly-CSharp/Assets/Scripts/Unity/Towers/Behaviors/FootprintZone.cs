namespace Assets.Scripts.Unity.Towers.Behaviors;

public class FootprintZone : SupportBehavior
{
	public FootprintZone parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public float footprintReduction; //Field offset: 0xE0
	public string expFootprintReduction; //Field offset: 0xE8
	public string mutatorId; //Field offset: 0xF0
	public string expMutatorId; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 231
	}

	public FootprintZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

