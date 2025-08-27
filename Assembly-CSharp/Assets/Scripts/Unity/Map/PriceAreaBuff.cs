namespace Assets.Scripts.Unity.Map;

public class PriceAreaBuff : AreaBuff
{
	private PriceAreaBuffModel def; //Field offset: 0x48
	public float multiplier; //Field offset: 0x50

	public virtual AreaBuffModel Def
	{
		 get { } //Length: 299
	}

	public PriceAreaBuff() { }

	public virtual AreaBuffModel get_Def() { }

}

