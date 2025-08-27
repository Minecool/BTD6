namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class Hex : BloonBehavior
{
	public float damagePercentOfMax; //Field offset: 0x88
	public string expDamagePercentOfMax; //Field offset: 0x90
	public float interval; //Field offset: 0x98
	public string expInterval; //Field offset: 0xA0
	public float totalDuration; //Field offset: 0xA8
	public string expTotalDuration; //Field offset: 0xB0

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public Hex() { }

	public virtual BloonBehaviorModel get_Def() { }

}

