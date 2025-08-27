namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "FilterGlueLevel", menuName = "BTD6/Behaviors/Towers/FilterGlueLevel")]
public class FilterGlueLevel : Filter
{
	public int glueLevel; //Field offset: 0x30

	public virtual FilterModel Def
	{
		 get { } //Length: 104
	}

	public FilterGlueLevel() { }

	public virtual FilterModel get_Def() { }

}

