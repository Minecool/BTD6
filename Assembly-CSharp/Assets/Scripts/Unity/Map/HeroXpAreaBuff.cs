namespace Assets.Scripts.Unity.Map;

public class HeroXpAreaBuff : AreaBuff
{
	private HeroXpAreaBuffModel def; //Field offset: 0x48
	public float multiplier; //Field offset: 0x50

	public virtual AreaBuffModel Def
	{
		 get { } //Length: 301
	}

	public HeroXpAreaBuff() { }

	public virtual AreaBuffModel get_Def() { }

}

