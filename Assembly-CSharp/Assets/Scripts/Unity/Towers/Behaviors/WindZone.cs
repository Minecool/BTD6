namespace Assets.Scripts.Unity.Towers.Behaviors;

public class WindZone : TowerBehavior
{
	public WindZone parent; //Field offset: 0x98
	public float distanceMin; //Field offset: 0xA0
	public string expDistanceMin; //Field offset: 0xA8
	public float distanceMax; //Field offset: 0xB0
	public string expDistanceMax; //Field offset: 0xB8
	public float chance; //Field offset: 0xC0
	public string expChance; //Field offset: 0xC8
	public int oneInHowMany; //Field offset: 0xD0
	public string expOneInHowMany; //Field offset: 0xD8
	public bool affectMoab; //Field offset: 0xE0
	public string expAffectMoab; //Field offset: 0xE8
	public float distanceScaleForTags; //Field offset: 0xF0
	public string expDistanceScaleForTags; //Field offset: 0xF8
	public string distanceScaleForTagsTags; //Field offset: 0x100
	public string expDistanceScaleForTagsTags; //Field offset: 0x108
	public string overlayType; //Field offset: 0x110
	public string expOverlayType; //Field offset: 0x118
	public float stunDurationMoab; //Field offset: 0x120
	public string expStunDurationMoab; //Field offset: 0x128
	public float stunDurationBfb; //Field offset: 0x130
	public string expStunDurationBfb; //Field offset: 0x138
	public float stunDurationZomg; //Field offset: 0x140
	public string expStunDurationZomg; //Field offset: 0x148

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 467
	}

	public WindZone() { }

	public FilterModel[] GatherFilters() { }

	public virtual TowerBehaviorModel get_Def() { }

}

