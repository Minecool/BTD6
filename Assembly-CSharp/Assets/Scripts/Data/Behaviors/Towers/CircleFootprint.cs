namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CircleFootprint", menuName = "BTD6/Behaviors/Towers/CircleFootprint")]
public class CircleFootprint : Footprint
{
	[SerializeField]
	public float radius; //Field offset: 0x30

	public virtual FootprintModel Def
	{
		 get { } //Length: 169
	}

	public CircleFootprint() { }

	public virtual FootprintModel get_Def() { }

}

