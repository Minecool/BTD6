namespace Assets.Scripts.Models.ServerEvents;

public class BossEvent : RemoteDataServerEvent<BossEventMetadata, BossDataModel>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UInt64, TimeSpan> <>9__0_0; //Field offset: 0x8
		public static Func<UInt64, TimeSpan> <>9__0_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal TimeSpan <ValidateData>b__0_0(ulong rawValue) { }

		internal TimeSpan <ValidateData>b__0_1(ulong rawValue) { }

	}


	public BossEvent() { }

	protected virtual BossDataModel ValidateData(BossDataModel bossData) { }

	private void ValidateEventLength(ScoreComponent scoreComponents, ScoreComponent testComponent, Func<UInt64, TimeSpan> getMaxEventLength) { }

}

