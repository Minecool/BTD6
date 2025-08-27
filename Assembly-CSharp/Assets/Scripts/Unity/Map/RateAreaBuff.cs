namespace Assets.Scripts.Unity.Map;

public class RateAreaBuff : AreaBuff
{
	private RateAreaBuffModel def; //Field offset: 0x48
	public float multiplier; //Field offset: 0x50

	public virtual AreaBuffModel Def
	{
		 get { } //Length: 299
	}

	public RateAreaBuff() { }

	public virtual AreaBuffModel get_Def() { }

}

