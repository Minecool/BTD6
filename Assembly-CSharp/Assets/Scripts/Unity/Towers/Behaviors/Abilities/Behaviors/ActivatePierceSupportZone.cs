namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ActivatePierceSupportZone : AbilityBehavior
{
	public ActivatePierceSupportZone parent; //Field offset: 0x88
	public string mutatorId; //Field offset: 0x90
	public string expMutatorId; //Field offset: 0x98
	public float lifespan; //Field offset: 0xA0
	public string expLifespan; //Field offset: 0xA8
	public bool isUnique; //Field offset: 0xB0
	public string expIsUnique; //Field offset: 0xB8
	public int pierceIncrease; //Field offset: 0xC0
	public string expPierceIncrease; //Field offset: 0xC8
	public float range; //Field offset: 0xD0
	public string expRange; //Field offset: 0xD8
	public int maxNumTowersModified; //Field offset: 0xE0
	public string expMaxNumTowersModified; //Field offset: 0xE8
	public bool affectThisTower; //Field offset: 0xF0
	public string expAffectThisTower; //Field offset: 0xF8
	public bool useTowerRange; //Field offset: 0x100
	public string expUseTowerRange; //Field offset: 0x108
	public string buffLocsName; //Field offset: 0x110
	public string expBuffLocsName; //Field offset: 0x118
	public string buffIconName; //Field offset: 0x120
	public string expBuffIconName; //Field offset: 0x128

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 400
	}

	public ActivatePierceSupportZone() { }

	public TowerFilterModel[] GatherFilters() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

