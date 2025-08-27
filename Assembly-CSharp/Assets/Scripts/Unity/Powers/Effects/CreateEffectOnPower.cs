namespace Assets.Scripts.Unity.Powers.Effects;

public class CreateEffectOnPower : PowerBehavior
{
	public Effect effect; //Field offset: 0x20

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 212
	}

	public CreateEffectOnPower() { }

	public void Awake() { }

	public virtual PowerBehaviorModel get_Def() { }

}

