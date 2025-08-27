namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "Darkshift", menuName = "BTD6/Behaviors/Abilities/Darkshift")]
public class Darkshift : AbilityBehavior
{
	public bool restrictToTowerRadius; //Field offset: 0x30
	public float placementZoneAssetRadius; //Field offset: 0x34
	public PrefabReference placementZoneAsset; //Field offset: 0x38
	public Sound darkshiftSound; //Field offset: 0x40
	public Effect disappearEffect; //Field offset: 0x48
	public Effect reappearEffect; //Field offset: 0x50

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 314
	}

	public Darkshift() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

