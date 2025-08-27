namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Wind", menuName = "BTD6/Behaviors/Projectiles/Wind")]
public class Wind : ProjectileBehavior
{
	public float distanceMin; //Field offset: 0x30
	public float distanceMax; //Field offset: 0x34
	public float chance; //Field offset: 0x38
	public bool affectMoab; //Field offset: 0x3C
	public float distanceScaleForTags; //Field offset: 0x40
	public string distanceScaleForTagsTags; //Field offset: 0x48
	public string overlayType; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 252
	}

	public Wind() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

