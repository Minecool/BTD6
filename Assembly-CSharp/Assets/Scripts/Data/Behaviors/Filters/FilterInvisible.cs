namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterInvisible", menuName = "BTD6/Behaviors/Filters/FilterInvisible")]
public class FilterInvisible : Filter
{
	public bool isActive; //Field offset: 0x30
	public bool ignoreBroadPhase; //Field offset: 0x31

	public virtual FilterModel Def
	{
		 get { } //Length: 130
	}

	public FilterInvisible() { }

	public virtual FilterModel get_Def() { }

}

