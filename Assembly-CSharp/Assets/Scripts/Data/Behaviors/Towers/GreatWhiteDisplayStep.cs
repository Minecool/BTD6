namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "GreatWhiteDisplayStep", menuName = "BTD6/Behaviors/Towers/GreatWhiteDisplayStep")]
public class GreatWhiteDisplayStep : TowerBehavior
{
	public PrefabReference portalEffectDisplay; //Field offset: 0x30
	public PrefabReference noGrabEffectDisplay; //Field offset: 0x38
	public BeastHandlerPetDisplayStep displayStep; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 172
	}

	public GreatWhiteDisplayStep() { }

	public virtual TowerBehaviorModel get_Def() { }

}

