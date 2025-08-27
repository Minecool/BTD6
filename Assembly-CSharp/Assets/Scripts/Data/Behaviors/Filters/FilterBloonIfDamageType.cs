namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterBloonIfDamageType", menuName = "BTD6/Behaviors/Filters/FilterBloonIfDamageType")]
public class FilterBloonIfDamageType : Filter
{
	public string ifCantHitBloonProperty; //Field offset: 0x30
	public Damage damage; //Field offset: 0x38

	public virtual FilterModel Def
	{
		 get { } //Length: 299
	}

	public FilterBloonIfDamageType() { }

	public virtual FilterModel get_Def() { }

}

