namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "PlaceProjectileAt", menuName = "BTD6/Behaviors/Abilities/PlaceProjectileAt")]
public class PlaceProjectileAt : AbilityBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public AreaType[] placeableArea; //Field offset: 0x40
	public float placementRadius; //Field offset: 0x48
	public float rangeCircleRadius; //Field offset: 0x4C
	public float delay; //Field offset: 0x50
	public Effect effectAtLocation; //Field offset: 0x58
	public Effect effectAtTower; //Field offset: 0x60
	public OffsetPosition effectAtTowerMarker; //Field offset: 0x68
	public Sound soundOnPlace; //Field offset: 0x70
	public bool useRandomRotation; //Field offset: 0x78
	public AssetPath placingDisplay; //Field offset: 0x80

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 786
	}

	public PlaceProjectileAt() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

