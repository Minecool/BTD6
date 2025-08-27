namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "WindZone", menuName = "BTD6/Behaviors/Towers/WindZone")]
public class WindZone : TowerBehavior
{
	public float distanceMin; //Field offset: 0x30
	public float distanceMax; //Field offset: 0x34
	public float chance; //Field offset: 0x38
	public int oneInHowMany; //Field offset: 0x3C
	public bool affectMoab; //Field offset: 0x40
	public float distanceScaleForTags; //Field offset: 0x44
	public string distanceScaleForTagsTags; //Field offset: 0x48
	public string overlayType; //Field offset: 0x50
	public float stunDurationMoab; //Field offset: 0x58
	public float stunDurationBfb; //Field offset: 0x5C
	public float stunDurationZomg; //Field offset: 0x60
	public Filter[] filters; //Field offset: 0x68

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 408
	}

	public WindZone() { }

	public FilterModel[] GatherFilters() { }

	public virtual TowerBehaviorModel get_Def() { }

}

