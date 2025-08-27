namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(OnProjectileHitTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnProjectileHitTriggerModel : MapTriggerModel
{
	public float collisionMarkerX; //Field offset: 0x38
	public float collisionMarkerY; //Field offset: 0x3C
	public float collisionRadius; //Field offset: 0x40
	public int hitRangeMin; //Field offset: 0x44
	public int hitRangeMax; //Field offset: 0x48
	public string projectileChipTag; //Field offset: 0x50

	public OnProjectileHitTriggerModel(string name, float collisionMarkerX, float collisionMarkerY, float collisionRadius, int hitRangeMin, int hitRangeMax, string projectileChipTag) { }

}

