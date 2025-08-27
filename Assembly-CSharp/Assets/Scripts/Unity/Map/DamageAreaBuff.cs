namespace Assets.Scripts.Unity.Map;

public class DamageAreaBuff : AreaBuff
{
	private DamageAreaBuffModel def; //Field offset: 0x48
	public float increase; //Field offset: 0x50

	public virtual AreaBuffModel Def
	{
		 get { } //Length: 299
	}

	public DamageAreaBuff() { }

	public virtual AreaBuffModel get_Def() { }

}

