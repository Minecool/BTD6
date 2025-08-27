namespace Assets.Scripts.Unity.Map.Triggers;

public class OnProjectileHitTrigger : MapTrigger
{
	public GameObject collisionMarker; //Field offset: 0x20
	public float collisionRadius; //Field offset: 0x28
	public int hitRangeMin; //Field offset: 0x2C
	public int hitRangeMax; //Field offset: 0x30
	public string projectileChipTag; //Field offset: 0x38
	private OnProjectileHitTriggerModel def; //Field offset: 0x40

	public virtual MapTriggerModel Def
	{
		 get { } //Length: 411
	}

	public OnProjectileHitTrigger() { }

	public virtual MapTriggerModel get_Def() { }

}

