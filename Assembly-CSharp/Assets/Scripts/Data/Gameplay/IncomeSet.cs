namespace Assets.Scripts.Data.Gameplay;

[CreateAssetMenu(menuName = "BTD6/Income Set")]
public class IncomeSet : ScriptableObject, IIncomeSet
{
	private class Container
	{
		public RoundThresholdMultiplier[] items; //Field offset: 0x10

		public Container() { }

	}

	[SerializeField]
	private float finalMultiplier; //Field offset: 0x18
	[ReorderableList("items", True)]
	[SerializeField]
	private Container thresholds; //Field offset: 0x20

	public IncomeSetModel Def
	{
		 get { } //Length: 152
	}

	public IncomeSet() { }

	public IncomeSetModel get_Def() { }

}

