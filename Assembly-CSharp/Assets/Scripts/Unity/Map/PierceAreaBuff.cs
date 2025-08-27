namespace Assets.Scripts.Unity.Map;

public class PierceAreaBuff : AreaBuff
{
	private PierceAreaBuffModel def; //Field offset: 0x48
	public float pierce; //Field offset: 0x50

	public virtual AreaBuffModel Def
	{
		 get { } //Length: 299
	}

	public PierceAreaBuff() { }

	public virtual AreaBuffModel get_Def() { }

}

