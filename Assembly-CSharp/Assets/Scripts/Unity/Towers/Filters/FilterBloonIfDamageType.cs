namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterBloonIfDamageType : Filter
{
	public FilterBloonIfDamageType parent; //Field offset: 0x88
	public string ifCantHitBloonProperty; //Field offset: 0x90
	public string expIfCantHitBloonProperty; //Field offset: 0x98
	public Damage damage; //Field offset: 0xA0
	public Damage expDamage; //Field offset: 0xA8

	public virtual FilterModel Def
	{
		 get { } //Length: 309
	}

	public FilterBloonIfDamageType() { }

	public virtual FilterModel get_Def() { }

}

