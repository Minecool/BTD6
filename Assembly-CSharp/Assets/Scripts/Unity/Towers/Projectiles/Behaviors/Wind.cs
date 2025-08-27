namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Wind : ProjectileBehavior
{
	public Wind parent; //Field offset: 0x88
	public float distanceMin; //Field offset: 0x90
	public string expDistanceMin; //Field offset: 0x98
	public float distanceMax; //Field offset: 0xA0
	public string expDistanceMax; //Field offset: 0xA8
	public float chance; //Field offset: 0xB0
	public string expChance; //Field offset: 0xB8
	public bool affectMoab; //Field offset: 0xC0
	public string expAffectMoab; //Field offset: 0xC8
	public float distanceScaleForTags; //Field offset: 0xD0
	public string expDistanceScaleForTags; //Field offset: 0xD8
	public string distanceScaleForTagsTags; //Field offset: 0xE0
	public string expDistanceScaleForTagsTags; //Field offset: 0xE8
	public string overlayType; //Field offset: 0xF0
	public string expOverlayType; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 273
	}

	public Wind() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

