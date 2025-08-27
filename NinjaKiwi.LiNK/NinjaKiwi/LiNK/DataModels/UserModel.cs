namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public sealed class UserModel : IMixable<UserModel>
{
	[CompilerGenerated]
	private sealed class <NinjaKiwi-LiNK-Utils-IMixable<NinjaKiwi-LiNK-DataModels-UserModel>-MixInPropertiesFrom>d__19 : IEnumerable<Boolean>, IEnumerable, IEnumerator<Boolean>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private bool <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public UserModel <>4__this; //Field offset: 0x20
		private UserModel source; //Field offset: 0x28
		public UserModel <>3__source; //Field offset: 0x30

		private override bool System.Collections.Generic.IEnumerator<System.Boolean>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 34
		}

		[DebuggerHidden]
		public <NinjaKiwi-LiNK-Utils-IMixable<NinjaKiwi-LiNK-DataModels-UserModel>-MixInPropertiesFrom>d__19(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Boolean> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator() { }

		[DebuggerHidden]
		private override bool System.Collections.Generic.IEnumerator<System.Boolean>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[DataMember(Name = "nkapiID", IsRequired = True)]
	public string liNKID; //Field offset: 0x10
	[DataMember(Name = "shortcode")]
	public string shortCode; //Field offset: 0x18
	[DataMember(Name = "displayName")]
	public string displayName; //Field offset: 0x20
	[DataMember(Name = "safeName")]
	public string safeName; //Field offset: 0x28
	[DataMember(Name = "age")]
	public int age; //Field offset: 0x30
	[DataMember(Name = "ageTS")]
	public long ageTimestamp; //Field offset: 0x38
	[DataMember(Name = "clan")]
	public int clan; //Field offset: 0x40
	[DataMember(Name = "country")]
	public string country; //Field offset: 0x48
	[DataMember(Name = "continent")]
	public string continent; //Field offset: 0x50
	[DataMember(Name = "avatar")]
	public int avatar; //Field offset: 0x58
	[DataMember(Name = "online")]
	public bool online; //Field offset: 0x5C
	[DataMember(Name = "onlineApp")]
	public int onlineApp; //Field offset: 0x60
	[DataMember(Name = "access")]
	public int access; //Field offset: 0x64
	[DataMember(Name = "xboxID")]
	public string xboxID; //Field offset: 0x68
	[DataMember(Name = "psID")]
	public string psID; //Field offset: 0x70
	public string recoveryCode; //Field offset: 0x78
	[DataMember(Name = "providersAvailable")]
	public String[] providersAvailable; //Field offset: 0x80

	public bool IsChild
	{
		 get { } //Length: 8
	}

	public UserModel() { }

	private bool CheckLiNKID(string otherLiNKID) { }

	public bool get_IsChild() { }

	[IteratorStateMachine(typeof(<NinjaKiwi-LiNK-Utils-IMixable<NinjaKiwi-LiNK-DataModels-UserModel>-MixInPropertiesFrom>d__19))]
	private override IEnumerable<Boolean> NinjaKiwi.LiNK.Utils.IMixable<NinjaKiwi.LiNK.DataModels.UserModel>.MixInPropertiesFrom(UserModel source) { }

}

