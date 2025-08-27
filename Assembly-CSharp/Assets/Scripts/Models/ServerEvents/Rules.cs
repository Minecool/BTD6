namespace Assets.Scripts.Models.ServerEvents;

public class Rules
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DailyChallengeModel, DailyChallengeModel> <>9__16_0; //Field offset: 0x8
		public static Func<DefaultData, DefaultData> <>9__16_1; //Field offset: 0x10
		public static Func<DefaultData, DefaultData> <>9__16_2; //Field offset: 0x18
		public static Func<TowerData, TowerData> <>9__16_3; //Field offset: 0x20
		public static Func<PowerData, PowerData> <>9__16_4; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal DailyChallengeModel <Clone>b__16_0(DailyChallengeModel c) { }

		internal DefaultData <Clone>b__16_1(DefaultData dt) { }

		internal DefaultData <Clone>b__16_2(DefaultData dp) { }

		internal TowerData <Clone>b__16_3(TowerData at) { }

		internal PowerData <Clone>b__16_4(PowerData ap) { }

	}

	public string rewards; //Field offset: 0x10
	public int trophies; //Field offset: 0x18
	public int maxMonkeySeats; //Field offset: 0x1C
	public int maxPowerSlots; //Field offset: 0x20
	public int maxPowersOnBoat; //Field offset: 0x24
	public DailyChallengeModel[] challenges; //Field offset: 0x28
	public int maxMonkeysOnBoat; //Field offset: 0x30
	public int startingHealth; //Field offset: 0x34
	public bool isExtreme; //Field offset: 0x38
	public bool difficultyEnabled; //Field offset: 0x39
	public List<DefaultData> defaultTowers; //Field offset: 0x40
	public List<DefaultData> defaultPowers; //Field offset: 0x48
	public List<TowerData> availableTowers; //Field offset: 0x50
	public List<PowerData> availablePowers; //Field offset: 0x58
	public int minStartTowers; //Field offset: 0x60
	public bool modifiedCrew; //Field offset: 0x64

	public Rules() { }

	public Rules Clone() { }

}

