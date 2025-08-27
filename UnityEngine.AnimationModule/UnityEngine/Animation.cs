namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Modules/Animation/Animation.h")]
public sealed class Animation : Behaviour, IEnumerable
{
	private sealed class Enumerator : IEnumerator
	{
		private Animation m_Outer; //Field offset: 0x10
		private int m_CurrentIndex; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 76
		}

		internal Enumerator(Animation outer) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}


	[Obsolete("Use cullingType instead")]
	public bool animateOnlyIfVisible
	{
		[FreeFunction("AnimationBindings::GetAnimateOnlyIfVisible", HasExplicitThis = True)]
		 get { } //Length: 51
		[FreeFunction("AnimationBindings::SetAnimateOnlyIfVisible", HasExplicitThis = True)]
		 set { } //Length: 66
	}

	public bool animatePhysics
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public AnimationClip clip
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public AnimationCullingType cullingType
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool isPlaying
	{
		[NativeName("IsPlaying")]
		 get { } //Length: 51
	}

	public AnimationState Item
	{
		 get { } //Length: 66
	}

	public Bounds localBounds
	{
		[NativeName("GetLocalAABB")]
		 get { } //Length: 81
		[NativeName("SetLocalAABB")]
		 set { } //Length: 66
	}

	public bool playAutomatically
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public WrapMode wrapMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Animation() { }

	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	[ExcludeFromDocs]
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	public void AddClip(AnimationClip clip, string newName) { }

	public void Blend(string animation, float targetWeight, float fadeLength) { }

	[ExcludeFromDocs]
	public void Blend(string animation, float targetWeight) { }

	[ExcludeFromDocs]
	public void Blend(string animation) { }

	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	[ExcludeFromDocs]
	public void CrossFade(string animation, float fadeLength) { }

	[ExcludeFromDocs]
	public void CrossFade(string animation) { }

	[ExcludeFromDocs]
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = True)]
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	[ExcludeFromDocs]
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	[ExcludeFromDocs]
	public AnimationState CrossFadeQueued(string animation) { }

	[FreeFunction("AnimationBindings::GetAnimateOnlyIfVisible", HasExplicitThis = True)]
	public bool get_animateOnlyIfVisible() { }

	public bool get_animatePhysics() { }

	public AnimationClip get_clip() { }

	public AnimationCullingType get_cullingType() { }

	[NativeName("IsPlaying")]
	public bool get_isPlaying() { }

	public AnimationState get_Item(string name) { }

	[NativeName("GetLocalAABB")]
	public Bounds get_localBounds() { }

	private void get_localBounds_Injected(out Bounds ret) { }

	public bool get_playAutomatically() { }

	public WrapMode get_wrapMode() { }

	public AnimationClip GetClip(string name) { }

	public int GetClipCount() { }

	public override IEnumerator GetEnumerator() { }

	[FreeFunction("AnimationBindings::GetState", HasExplicitThis = True)]
	internal AnimationState GetState(string name) { }

	[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = True, ThrowsException = True)]
	internal AnimationState GetStateAtIndex(int index) { }

	[NativeName("GetAnimationStateCount")]
	internal int GetStateCount() { }

	public bool IsPlaying(string name) { }

	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocs]
	public bool Play(string animation) { }

	[Obsolete("use PlayMode instead of AnimationPlayMode.")]
	public bool Play(string animation, AnimationPlayMode mode) { }

	[ExcludeFromDocs]
	public bool Play() { }

	[Obsolete("use PlayMode instead of AnimationPlayMode.")]
	public bool Play(AnimationPlayMode mode) { }

	public bool Play(PlayMode mode) { }

	[NativeName("Play")]
	private bool PlayDefaultAnimation(PlayMode mode) { }

	[ExcludeFromDocs]
	public AnimationState PlayQueued(string animation) { }

	[ExcludeFromDocs]
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	[FreeFunction("AnimationBindings::PlayQueuedImpl", HasExplicitThis = True)]
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	public void RemoveClip(string clipName) { }

	public void RemoveClip(AnimationClip clip) { }

	[NativeName("RemoveClip")]
	private void RemoveClipNamed(string clipName) { }

	public void Rewind(string name) { }

	public void Rewind() { }

	[NativeName("Rewind")]
	private void RewindNamed(string name) { }

	public void Sample() { }

	[FreeFunction("AnimationBindings::SetAnimateOnlyIfVisible", HasExplicitThis = True)]
	public void set_animateOnlyIfVisible(bool value) { }

	public void set_animatePhysics(bool value) { }

	public void set_clip(AnimationClip value) { }

	public void set_cullingType(AnimationCullingType value) { }

	[NativeName("SetLocalAABB")]
	public void set_localBounds(Bounds value) { }

	private void set_localBounds_Injected(ref Bounds value) { }

	public void set_playAutomatically(bool value) { }

	public void set_wrapMode(WrapMode value) { }

	public void Stop(string name) { }

	public void Stop() { }

	[NativeName("Stop")]
	private void StopNamed(string name) { }

	public void SyncLayer(int layer) { }

}

