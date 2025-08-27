namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterAllExceptTarget", menuName = "BTD6/Behaviors/Filters/FilterAllExceptTarget")]
public class FilterAllExceptTarget : Filter
{
	public bool cantBePaused; //Field offset: 0x30

	public virtual FilterModel Def
	{
		 get { } //Length: 106
	}

	public FilterAllExceptTarget() { }

	public virtual FilterModel get_Def() { }

}

