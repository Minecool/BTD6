namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "EmitOnPop", menuName = "BTD6/Behaviors/Bloons/EmitOnPop")]
public class EmitOnPop : BloonBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public bool ignoreSameFrameDegrade; //Field offset: 0x40

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 247
	}

	public EmitOnPop() { }

	public virtual BloonBehaviorModel get_Def() { }

}

