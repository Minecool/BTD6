namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterIfAttackHasTarget : Filter
{
	public FilterIfAttackHasTarget parent; //Field offset: 0x88
	public Attack attack; //Field offset: 0x90
	public Attack expAttack; //Field offset: 0x98

	public virtual FilterModel Def
	{
		 get { } //Length: 155
	}

	public FilterIfAttackHasTarget() { }

	public virtual FilterModel get_Def() { }

}

