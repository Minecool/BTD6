namespace Assets.Scripts.Unity.Map;

public class RangeAreaBuff : AreaBuff
{
	private RangeAreaBuffModel def; //Field offset: 0x48
	public float multiplier; //Field offset: 0x50

	public virtual AreaBuffModel Def
	{
		 get { } //Length: 299
	}

	public RangeAreaBuff() { }

	public virtual AreaBuffModel get_Def() { }

}

