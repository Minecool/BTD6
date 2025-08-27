namespace NinjaKiwi.LiNK.Client.DataModels;

[DataContract]
public sealed class SavedIdentity : IMixable<LiNKAccountModel>
{
	[CompilerGenerated]
	private sealed class <NinjaKiwi-LiNK-Utils-IMixable<NinjaKiwi-LiNK-DataModels-LiNKAccountModel>-MixInPropertiesFrom>d__10 : IEnumerable<Boolean>, IEnumerable, IEnumerator<Boolean>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private bool <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public SavedIdentity <>4__this; //Field offset: 0x20
		private LiNKAccountModel source; //Field offset: 0x28
		public LiNKAccountModel <>3__source; //Field offset: 0x30

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
		public <NinjaKiwi-LiNK-Utils-IMixable<NinjaKiwi-LiNK-DataModels-LiNKAccountModel>-MixInPropertiesFrom>d__10(int <>1__state) { }

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

	[JsonProperty("LiNKID")]
	public string liNKID; //Field offset: 0x10
	[JsonProperty("ShortCode")]
	public string shortCode; //Field offset: 0x18
	[JsonProperty("DisplayName")]
	public string displayName; //Field offset: 0x20
	[JsonProperty("SafeName")]
	public string safeName; //Field offset: 0x28
	[JsonProperty("ProvidersAvailable")]
	public String[] providersAvailable; //Field offset: 0x30
	[JsonProperty("Age")]
	public int age; //Field offset: 0x38
	[JsonProperty("recoveryCode")]
	public string recoveryCode; //Field offset: 0x40
	[JsonProperty("SessionID")]
	public string sessionID; //Field offset: 0x48
	[JsonProperty("encryptedSessionID")]
	public string encryptedSessionID; //Field offset: 0x50

	[JsonConstructor]
	public SavedIdentity() { }

	internal LiNKAccountModel ConvertToLiNKAccountModel() { }

	[IteratorStateMachine(typeof(<NinjaKiwi-LiNK-Utils-IMixable<NinjaKiwi-LiNK-DataModels-LiNKAccountModel>-MixInPropertiesFrom>d__10))]
	private override IEnumerable<Boolean> NinjaKiwi.LiNK.Utils.IMixable<NinjaKiwi.LiNK.DataModels.LiNKAccountModel>.MixInPropertiesFrom(LiNKAccountModel source) { }

}

