namespace UnityEngine.Video;

[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public sealed class VideoPlayer : Behaviour
{
	internal sealed class ErrorEventHandler : MulticastDelegate
	{

		public ErrorEventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source, string message) { }

	}

	internal sealed class EventHandler : MulticastDelegate
	{

		public EventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source) { }

	}

	internal sealed class FrameReadyEventHandler : MulticastDelegate
	{

		public FrameReadyEventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source, long frameIdx) { }

	}

	internal sealed class TimeEventHandler : MulticastDelegate
	{

		public TimeEventHandler(object object, IntPtr method) { }

		public override void Invoke(VideoPlayer source, double seconds) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler prepareCompleted; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler loopPointReached; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler started; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler frameDropped; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ErrorEventHandler errorReceived; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventHandler seekCompleted; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TimeEventHandler clockResyncOccurred; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FrameReadyEventHandler frameReady; //Field offset: 0x50

	public event TimeEventHandler clockResyncOccurred
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event ErrorEventHandler errorReceived
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event EventHandler frameDropped
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event FrameReadyEventHandler frameReady
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event EventHandler loopPointReached
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event EventHandler prepareCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event EventHandler seekCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event EventHandler started
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public VideoAspectRatio aspectRatio
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public VideoAudioOutputMode audioOutputMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public ushort audioTrackCount
	{
		 get { } //Length: 51
	}

	public bool canSetDirectAudioVolume
	{
		[NativeName("CanSetDirectAudioVolume")]
		 get { } //Length: 51
	}

	public bool canSetPlaybackSpeed
	{
		[NativeName("CanSetPlaybackSpeed")]
		 get { } //Length: 51
	}

	public bool canSetSkipOnDrop
	{
		[NativeName("CanSetSkipOnDrop")]
		 get { } //Length: 51
	}

	public bool canSetTime
	{
		[NativeName("CanSetTime")]
		 get { } //Length: 51
	}

	[Obsolete("VideoPlayer.canSetTimeSource is deprecated. Use canSetTimeUpdateMode instead. (UnityUpgradable) -> canSetTimeUpdateMode")]
	public bool canSetTimeSource
	{
		[NativeName("CanSetTimeSource")]
		 get { } //Length: 51
	}

	public bool canSetTimeUpdateMode
	{
		[NativeName("CanSetTimeUpdateMode")]
		 get { } //Length: 51
	}

	public bool canStep
	{
		[NativeName("CanStep")]
		 get { } //Length: 51
	}

	[NativeName("VideoClip")]
	public VideoClip clip
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public double clockTime
	{
		 get { } //Length: 51
	}

	public ushort controlledAudioTrackCount
	{
		 get { } //Length: 51
		 set { } //Length: 242
	}

	public static ushort controlledAudioTrackMaxCount
	{
		 get { } //Length: 42
	}

	public double externalReferenceTime
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeName("FramePosition")]
	public long frame
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public ulong frameCount
	{
		 get { } //Length: 51
	}

	public float frameRate
	{
		 get { } //Length: 51
	}

	public uint height
	{
		 get { } //Length: 51
	}

	[NativeName("Loop")]
	public bool isLooping
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool isPaused
	{
		[NativeName("IsPaused")]
		 get { } //Length: 51
	}

	public bool isPlaying
	{
		[NativeName("IsPlaying")]
		 get { } //Length: 51
	}

	public bool isPrepared
	{
		[NativeName("IsPrepared")]
		 get { } //Length: 51
	}

	[NativeName("Duration")]
	public double length
	{
		 get { } //Length: 51
	}

	public uint pixelAspectRatioDenominator
	{
		 get { } //Length: 51
	}

	public uint pixelAspectRatioNumerator
	{
		 get { } //Length: 51
	}

	public float playbackSpeed
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool playOnAwake
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public VideoRenderMode renderMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool sendFrameReadyEvents
	{
		[NativeName("AreFrameReadyEventsEnabled")]
		 get { } //Length: 51
		[NativeName("EnableFrameReadyEvents")]
		 set { } //Length: 66
	}

	public bool skipOnDrop
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public VideoSource source
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeHeader("Runtime/Camera/Camera.h")]
	public Camera targetCamera
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Video3DLayout targetCamera3DLayout
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float targetCameraAlpha
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public string targetMaterialProperty
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeHeader("Runtime/Graphics/Renderer.h")]
	public Renderer targetMaterialRenderer
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	public RenderTexture targetTexture
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeHeader("Runtime/Graphics/Texture.h")]
	public Texture texture
	{
		 get { } //Length: 51
	}

	[NativeName("SecPosition")]
	public double time
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public VideoTimeReference timeReference
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[Obsolete("VideoPlayer.timeSource is deprecated. Use timeUpdateMode instead. (UnityUpgradable) -> timeUpdateMode")]
	public VideoTimeSource timeSource
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public VideoTimeUpdateMode timeUpdateMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeName("VideoUrl")]
	public string url
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool waitForFirstFrame
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public uint width
	{
		 get { } //Length: 51
	}

	public VideoPlayer() { }

	[CompilerGenerated]
	public void add_clockResyncOccurred(TimeEventHandler value) { }

	[CompilerGenerated]
	public void add_errorReceived(ErrorEventHandler value) { }

	[CompilerGenerated]
	public void add_frameDropped(EventHandler value) { }

	[CompilerGenerated]
	public void add_frameReady(FrameReadyEventHandler value) { }

	[CompilerGenerated]
	public void add_loopPointReached(EventHandler value) { }

	[CompilerGenerated]
	public void add_prepareCompleted(EventHandler value) { }

	[CompilerGenerated]
	public void add_seekCompleted(EventHandler value) { }

	[CompilerGenerated]
	public void add_started(EventHandler value) { }

	public void EnableAudioTrack(ushort trackIndex, bool enabled) { }

	public VideoAspectRatio get_aspectRatio() { }

	public VideoAudioOutputMode get_audioOutputMode() { }

	public ushort get_audioTrackCount() { }

	[NativeName("CanSetDirectAudioVolume")]
	public bool get_canSetDirectAudioVolume() { }

	[NativeName("CanSetPlaybackSpeed")]
	public bool get_canSetPlaybackSpeed() { }

	[NativeName("CanSetSkipOnDrop")]
	public bool get_canSetSkipOnDrop() { }

	[NativeName("CanSetTime")]
	public bool get_canSetTime() { }

	[NativeName("CanSetTimeSource")]
	public bool get_canSetTimeSource() { }

	[NativeName("CanSetTimeUpdateMode")]
	public bool get_canSetTimeUpdateMode() { }

	[NativeName("CanStep")]
	public bool get_canStep() { }

	public VideoClip get_clip() { }

	public double get_clockTime() { }

	public ushort get_controlledAudioTrackCount() { }

	public static ushort get_controlledAudioTrackMaxCount() { }

	public double get_externalReferenceTime() { }

	public long get_frame() { }

	public ulong get_frameCount() { }

	public float get_frameRate() { }

	public uint get_height() { }

	public bool get_isLooping() { }

	[NativeName("IsPaused")]
	public bool get_isPaused() { }

	[NativeName("IsPlaying")]
	public bool get_isPlaying() { }

	[NativeName("IsPrepared")]
	public bool get_isPrepared() { }

	public double get_length() { }

	public uint get_pixelAspectRatioDenominator() { }

	public uint get_pixelAspectRatioNumerator() { }

	public float get_playbackSpeed() { }

	public bool get_playOnAwake() { }

	public VideoRenderMode get_renderMode() { }

	[NativeName("AreFrameReadyEventsEnabled")]
	public bool get_sendFrameReadyEvents() { }

	public bool get_skipOnDrop() { }

	public VideoSource get_source() { }

	public Camera get_targetCamera() { }

	public Video3DLayout get_targetCamera3DLayout() { }

	public float get_targetCameraAlpha() { }

	public string get_targetMaterialProperty() { }

	public Renderer get_targetMaterialRenderer() { }

	public RenderTexture get_targetTexture() { }

	public Texture get_texture() { }

	public double get_time() { }

	public VideoTimeReference get_timeReference() { }

	public VideoTimeSource get_timeSource() { }

	public VideoTimeUpdateMode get_timeUpdateMode() { }

	public string get_url() { }

	public bool get_waitForFirstFrame() { }

	public uint get_width() { }

	public ushort GetAudioChannelCount(ushort trackIndex) { }

	public string GetAudioLanguageCode(ushort trackIndex) { }

	public uint GetAudioSampleRate(ushort trackIndex) { }

	private ushort GetControlledAudioTrackCount() { }

	public bool GetDirectAudioMute(ushort trackIndex) { }

	public float GetDirectAudioVolume(ushort trackIndex) { }

	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	public AudioSource GetTargetAudioSource(ushort trackIndex) { }

	[RequiredByNativeCode]
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

	[RequiredByNativeCode]
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCode]
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCode]
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCode]
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	public bool IsAudioTrackEnabled(ushort trackIndex) { }

	public void Pause() { }

	public void Play() { }

	public void Prepare() { }

	[CompilerGenerated]
	public void remove_clockResyncOccurred(TimeEventHandler value) { }

	[CompilerGenerated]
	public void remove_errorReceived(ErrorEventHandler value) { }

	[CompilerGenerated]
	public void remove_frameDropped(EventHandler value) { }

	[CompilerGenerated]
	public void remove_frameReady(FrameReadyEventHandler value) { }

	[CompilerGenerated]
	public void remove_loopPointReached(EventHandler value) { }

	[CompilerGenerated]
	public void remove_prepareCompleted(EventHandler value) { }

	[CompilerGenerated]
	public void remove_seekCompleted(EventHandler value) { }

	[CompilerGenerated]
	public void remove_started(EventHandler value) { }

	public void set_aspectRatio(VideoAspectRatio value) { }

	public void set_audioOutputMode(VideoAudioOutputMode value) { }

	public void set_clip(VideoClip value) { }

	public void set_controlledAudioTrackCount(ushort value) { }

	public void set_externalReferenceTime(double value) { }

	public void set_frame(long value) { }

	public void set_isLooping(bool value) { }

	public void set_playbackSpeed(float value) { }

	public void set_playOnAwake(bool value) { }

	public void set_renderMode(VideoRenderMode value) { }

	[NativeName("EnableFrameReadyEvents")]
	public void set_sendFrameReadyEvents(bool value) { }

	public void set_skipOnDrop(bool value) { }

	public void set_source(VideoSource value) { }

	public void set_targetCamera(Camera value) { }

	public void set_targetCamera3DLayout(Video3DLayout value) { }

	public void set_targetCameraAlpha(float value) { }

	public void set_targetMaterialProperty(string value) { }

	public void set_targetMaterialRenderer(Renderer value) { }

	public void set_targetTexture(RenderTexture value) { }

	public void set_time(double value) { }

	public void set_timeReference(VideoTimeReference value) { }

	public void set_timeSource(VideoTimeSource value) { }

	public void set_timeUpdateMode(VideoTimeUpdateMode value) { }

	public void set_url(string value) { }

	public void set_waitForFirstFrame(bool value) { }

	private void SetControlledAudioTrackCount(ushort value) { }

	public void SetDirectAudioMute(ushort trackIndex, bool mute) { }

	public void SetDirectAudioVolume(ushort trackIndex, float volume) { }

	public void SetTargetAudioSource(ushort trackIndex, AudioSource source) { }

	public void StepForward() { }

	public void Stop() { }

}

