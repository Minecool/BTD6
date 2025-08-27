namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AddDisplayObject", menuName = "BTD6/Behaviors/Towers/AddDisplayObject")]
public class AddDisplayObject : EntityBehavior<Model>
{
	public DisplayCategory category; //Field offset: 0x28
	public float scale; //Field offset: 0x2C
	public float offsetX; //Field offset: 0x30
	public float offsetY; //Field offset: 0x34
	public float offsetZ; //Field offset: 0x38
	public bool ignoreRotation; //Field offset: 0x3C
	public PrefabReference display; //Field offset: 0x40

	public virtual Model Def
	{
		 get { } //Length: 264
	}

	public AddDisplayObject() { }

	public virtual Model get_Def() { }

}

