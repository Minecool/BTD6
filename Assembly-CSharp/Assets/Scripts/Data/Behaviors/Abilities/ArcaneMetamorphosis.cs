namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ArcaneMetamorphosis", menuName = "BTD6/Behaviors/Abilities/ArcaneMetamorphosis")]
public class ArcaneMetamorphosis : AbilityBehavior
{
	public int manaPerSecond; //Field offset: 0x30
	public AssetPath[] displayDegrees; //Field offset: 0x38
	public Effect effectTower; //Field offset: 0x40
	public Effect effectSubTower; //Field offset: 0x48
	public Effect effectEndTower; //Field offset: 0x50
	public Effect effectEndSubTower; //Field offset: 0x58
	public int endAnimationState; //Field offset: 0x60

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 397
	}

	public ArcaneMetamorphosis() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

