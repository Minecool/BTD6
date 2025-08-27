namespace Assets.Scripts.Unity.Towers.Behaviors;

public class GreatWhiteDisplayStep : TowerBehavior
{
	public GreatWhiteDisplayStep parent; //Field offset: 0x98
	public GameObject portalEffectDisplay; //Field offset: 0xA0
	public GameObject expPortalEffectDisplay; //Field offset: 0xA8
	public GameObject noGrabEffectDisplay; //Field offset: 0xB0
	public GameObject expNoGrabEffectDisplay; //Field offset: 0xB8
	public BeastHandlerPetDisplayStep displayStep; //Field offset: 0xC0
	public BeastHandlerPetDisplayStep expDisplayStep; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 240
	}

	public GreatWhiteDisplayStep() { }

	public virtual TowerBehaviorModel get_Def() { }

}

