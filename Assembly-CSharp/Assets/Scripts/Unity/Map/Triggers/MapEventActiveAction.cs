namespace Assets.Scripts.Unity.Map.Triggers;

public class MapEventActiveAction : MapAction
{
	public MapEvent mapEvent; //Field offset: 0x20
	public bool setToActive; //Field offset: 0x28

	public virtual MapActionModel Def
	{
		 get { } //Length: 174
	}

	public MapEventActiveAction() { }

	public virtual MapActionModel get_Def() { }

}

