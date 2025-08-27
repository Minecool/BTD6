namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class PlaceProjectileAt : AbilityBehavior
{
	public PlaceProjectileAt parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Emission emission; //Field offset: 0x98
	public string placeableArea; //Field offset: 0xA0
	public string expPlaceableArea; //Field offset: 0xA8
	public float placementRadius; //Field offset: 0xB0
	public string expPlacementRadius; //Field offset: 0xB8
	public float rangeCircleRadius; //Field offset: 0xC0
	public string expRangeCircleRadius; //Field offset: 0xC8
	public float delay; //Field offset: 0xD0
	public string expDelay; //Field offset: 0xD8
	public Effect effectAtLocation; //Field offset: 0xE0
	public Effect expEffectAtLocation; //Field offset: 0xE8
	public Effect effectAtTower; //Field offset: 0xF0
	public Effect expEffectAtTower; //Field offset: 0xF8
	public GameObject effectAtTowerMarker; //Field offset: 0x100
	public GameObject expEffectAtTowerMarker; //Field offset: 0x108
	public AudioClip soundOnPlace; //Field offset: 0x110
	public AudioClip expSoundOnPlace; //Field offset: 0x118
	public bool useRandomRotation; //Field offset: 0x120
	public string expUseRandomRotation; //Field offset: 0x128
	public GameObject placingDisplay; //Field offset: 0x130
	public GameObject expPlacingDisplay; //Field offset: 0x138

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 1648
	}

	public PlaceProjectileAt() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

