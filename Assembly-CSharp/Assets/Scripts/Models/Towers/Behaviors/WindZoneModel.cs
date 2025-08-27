namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(WindZone), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WindZoneModel : TowerBehaviorModel
{
	public float distanceMin; //Field offset: 0x30
	public float distanceMax; //Field offset: 0x34
	public float chance; //Field offset: 0x38
	public int oneInHowMany; //Field offset: 0x3C
	public bool affectMoab; //Field offset: 0x40
	public float distanceScaleForTags; //Field offset: 0x44
	public string distanceScaleForTagsTags; //Field offset: 0x48
	public String[] distanceScaleForTagsTagsList; //Field offset: 0x50
	public float speedMultiplier; //Field offset: 0x58
	public FilterModel[] filters; //Field offset: 0x60
	public string overlayType; //Field offset: 0x68
	[SerializeField]
	private float stunDurationMoab; //Field offset: 0x70
	public int stunDurationMoabFrames; //Field offset: 0x74
	[SerializeField]
	private float stunDurationBfb; //Field offset: 0x78
	public int stunDurationBfbFrames; //Field offset: 0x7C
	[SerializeField]
	private float stunDurationZomg; //Field offset: 0x80
	public int stunDurationZomgFrames; //Field offset: 0x84
	private AddBehaviorToBloonMutator windMutator; //Field offset: 0x88
	private SlowMutator slowMutator; //Field offset: 0x90

	public SlowMutator SlowMutator
	{
		 get { } //Length: 143
	}

	public AddBehaviorToBloonMutator WindMutator
	{
		 get { } //Length: 284
	}

	public WindZoneModel(string name, float distanceMin, float distanceMax, float chance, int oneInHowMany, bool affectMoab, string overlayType, FilterModel[] filters, AddBehaviorToBloonMutator windMutator = null, SlowMutator slowMutator = null, float distanceScaleForTags = 1, string distanceScaleForTagsTags = "", float speedMultiplier = 1, float stunDurationMoab = 0, float stunDurationBfb = 0, float stunDurationZomg = 0) { }

	public virtual Model Clone() { }

	public SlowMutator get_SlowMutator() { }

	public AddBehaviorToBloonMutator get_WindMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

