namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Darkshift : AbilityBehavior
{
	public Darkshift parent; //Field offset: 0x88
	public bool restrictToTowerRadius; //Field offset: 0x90
	public string expRestrictToTowerRadius; //Field offset: 0x98
	public float placementZoneAssetRadius; //Field offset: 0xA0
	public string expPlacementZoneAssetRadius; //Field offset: 0xA8
	public GameObject placementZoneAsset; //Field offset: 0xB0
	public GameObject expPlacementZoneAsset; //Field offset: 0xB8
	public AudioClip darkshiftSound; //Field offset: 0xC0
	public AudioClip expDarkshiftSound; //Field offset: 0xC8
	public Effect disappearEffect; //Field offset: 0xD0
	public Effect expDisappearEffect; //Field offset: 0xD8
	public Effect reappearEffect; //Field offset: 0xE0
	public Effect expReappearEffect; //Field offset: 0xE8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 492
	}

	public Darkshift() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

