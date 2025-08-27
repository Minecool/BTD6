namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RectangleFootprint", menuName = "BTD6/Behaviors/Towers/RectangleFootprint")]
public class RectangleFootprint : Footprint
{
	[SerializeField]
	public float xWidth; //Field offset: 0x30
	[SerializeField]
	public float yWidth; //Field offset: 0x34

	public virtual FootprintModel Def
	{
		 get { } //Length: 188
	}

	public RectangleFootprint() { }

	public virtual FootprintModel get_Def() { }

}

