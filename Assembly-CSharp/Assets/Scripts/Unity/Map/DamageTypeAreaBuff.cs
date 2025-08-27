namespace Assets.Scripts.Unity.Map;

public class DamageTypeAreaBuff : AreaBuff
{
	private DamageTypeAreaBuffModel def; //Field offset: 0x48
	public string damageType; //Field offset: 0x50

	public virtual AreaBuffModel Def
	{
		 get { } //Length: 341
	}

	public DamageTypeAreaBuff() { }

	public virtual AreaBuffModel get_Def() { }

}

