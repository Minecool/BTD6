namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PetRabbitMerge : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<GeraldoItemModel> <>9__12_0; //Field offset: 0x8
		public static Func<Tower, Int32> <>9__13_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <CheckToStartMerge>b__13_0(Tower mergingRabbit) { }

		internal bool <Process>b__12_0(GeraldoItemModel x) { }

	}

	public PetRabbitMergeModel petRabbitMergeModel; //Field offset: 0x68
	private List<Tower> mergingRabbits; //Field offset: 0x70
	private TowerModel wererabbitTowerModel; //Field offset: 0x78
	private bool isMerging; //Field offset: 0x80
	private bool isMergeTarget; //Field offset: 0x81
	private Entity effectDuringMerge; //Field offset: 0x88

	public bool IsMerging
	{
		 get { } //Length: 8
	}

	public PetRabbitMerge() { }

	private void CheckToStartMerge() { }

	public bool get_IsMerging() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	private void SetAsMergeTarget(List<Tower> mergingRabbits) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

