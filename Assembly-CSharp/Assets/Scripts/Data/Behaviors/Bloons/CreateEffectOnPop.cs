namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "CreateEffectOnPop", menuName = "BTD6/Behaviors/Bloons/CreateEffectOnPop")]
public class CreateEffectOnPop : BloonBehavior
{
	public Effect effect; //Field offset: 0x30
	public bool ignoreSameFrameDegrade; //Field offset: 0x38

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 244
	}

	public CreateEffectOnPop() { }

	public virtual BloonBehaviorModel get_Def() { }

}

