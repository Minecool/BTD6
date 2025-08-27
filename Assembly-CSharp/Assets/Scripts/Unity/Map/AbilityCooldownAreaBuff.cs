namespace Assets.Scripts.Unity.Map;

public class AbilityCooldownAreaBuff : AreaBuff
{
	private AbilityCooldownAreaBuffModel def; //Field offset: 0x48
	public float multiplier; //Field offset: 0x50

	public virtual AreaBuffModel Def
	{
		 get { } //Length: 301
	}

	public AbilityCooldownAreaBuff() { }

	public virtual AreaBuffModel get_Def() { }

}

