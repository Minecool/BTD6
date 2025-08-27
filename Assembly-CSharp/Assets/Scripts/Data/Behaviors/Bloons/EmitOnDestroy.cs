namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "EmitOnDestroy", menuName = "BTD6/Behaviors/Bloons/EmitOnDestroy")]
public class EmitOnDestroy : BloonBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public Effect effect; //Field offset: 0x40
	public Sound sound1; //Field offset: 0x48
	public Sound sound2; //Field offset: 0x50

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 441
	}

	public EmitOnDestroy() { }

	public virtual BloonBehaviorModel get_Def() { }

}

