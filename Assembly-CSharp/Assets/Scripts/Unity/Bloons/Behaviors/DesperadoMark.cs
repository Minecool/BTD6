namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class DesperadoMark : BloonBehavior
{
	public float desperadoDamageMultiplier; //Field offset: 0x88
	public string expDesperadoDamageMultiplier; //Field offset: 0x90
	public float popCashMultiplier; //Field offset: 0x98
	public string expPopCashMultiplier; //Field offset: 0xA0

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 161
	}

	public DesperadoMark() { }

	public virtual BloonBehaviorModel get_Def() { }

}

