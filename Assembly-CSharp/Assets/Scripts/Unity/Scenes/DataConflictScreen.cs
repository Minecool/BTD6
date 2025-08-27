namespace Assets.Scripts.Unity.Scenes;

public class DataConflictScreen : GenericAnimatedScene
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public bool isRemoteLatest; //Field offset: 0x10
		public DataConflictScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal GameObject <ShowDataConflict>b__0() { }

	}

	internal class DataDisplay
	{
		internal enum TimeFormat
		{
			Seconds = 0,
			Minutes = 1,
			Hours = 2,
			Days = 3,
		}

		public NK_TextMeshProUGUI Time; //Field offset: 0x10
		public NK_TextMeshProUGUI level; //Field offset: 0x18
		public Image rankImg; //Field offset: 0x20
		public Sprite veteranRankSprite; //Field offset: 0x28
		public Image barBorderImg; //Field offset: 0x30
		public Sprite veteranBorderSprite; //Field offset: 0x38
		public NK_TextMeshProUGUI xpInfo; //Field offset: 0x40
		public Image bar; //Field offset: 0x48
		public Sprite veteranBarSprite; //Field offset: 0x50
		public NK_TextMeshProUGUI MonkeyMoney; //Field offset: 0x58
		public Button OkButton; //Field offset: 0x60
		public Image latestSaveBorder; //Field offset: 0x68
		public GameObject newerData; //Field offset: 0x70

		public DataDisplay() { }

		public void ShowData(ProfileModel data, bool isLatest) { }

		public static string TimeSpanToText(TimeSpan timespan, out TimeFormat format) { }

	}

	public DataDisplay LocalDataDisplay; //Field offset: 0x28
	public DataDisplay RemoteDataDisplay; //Field offset: 0x30

	public DataConflictScreen() { }

	public void ShowDataConflict(DataConflict<ProfileModel> conflict) { }

	public virtual IEnumerator StartCloseAnimation() { }

}

