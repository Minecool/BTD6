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
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public VideoAudioOutputMode audioOutputMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public ushort audioTrackCount
	{
		 get { } //Length: 118
	}

	public bool canSetDirectAudioVolume
	{
		[NativeName("CanSetDirectAudioVolume")]
		 get { } //Length: 118
	}

	public bool canSetPlaybackSpeed
	{
		[NativeName("CanSetPlaybackSpeed")]
		 get { } //Length: 118
	}

	public bool canSetSkipOnDrop
	{
		[NativeName("CanSetSkipOnDrop")]
		 get { } //Length: 118
	}

	public bool canSetTime
	{
		[NativeName("CanSetTime")]
		 get { } //Length: 118
	}

	[Obsolete("VideoPlayer.canSetTimeSource is deprecated. Use canSetTimeUpdateMode instead. (UnityUpgradable) -> canSetTimeUpdateMode")]
	public bool canSetTimeSource
	{
		[NativeName("CanSetTimeSource")]
		 get { } //Length: 118
	}

	public bool canSetTimeUpdateMode
	{
		[NativeName("CanSetTimeUpdateMode")]
		 get { } //Length: 118
	}

	public bool canStep
	{
		[NativeName("CanStep")]
		 get { } //Length: 118
	}

	[NativeName("VideoClip")]
	public VideoClip clip
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	public double clockTime
	{
		 get { } //Length: 118
	}

	public ushort controlledAudioTrackCount
	{
		 get { } //Length: 118
		 set { } //Length: 306
	}

	public static ushort controlledAudioTrackMaxCount
	{
		 get { } //Length: 42
	}

	public double externalReferenceTime
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[NativeName("FramePosition")]
	public long frame
	{
		 get { } //Length: 118
		 set { } //Length: 133
	}

	public ulong frameCount
	{
		 get { } //Length: 118
	}

	public float frameRate
	{
		 get { } //Length: 118
	}

	public uint height
	{
		 get { } //Length: 118
	}

	[NativeName("Loop")]
	public bool isLooping
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool isPaused
	{
		[NativeName("IsPaused")]
		 get { } //Length: 118
	}

	public bool isPlaying
	{
		[NativeName("IsPlaying")]
		 get { } //Length: 118
	}

	public bool isPrepared
	{
		[NativeName("IsPrepared")]
		 get { } //Length: 118
	}

	[NativeName("Duration")]
	public double length
	{
		 get { } //Length: 118
	}

	public uint pixelAspectRatioDenominator
	{
		 get { } //Length: 118
	}

	public uint pixelAspectRatioNumerator
	{
		 get { } //Length: 118
	}

	public float playbackSpeed
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool playOnAwake
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public VideoRenderMode renderMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public bool sendFrameReadyEvents
	{
		[NativeName("AreFrameReadyEventsEnabled")]
		 get { } //Length: 118
		[NativeName("EnableFrameReadyEvents")]
		 set { } //Length: 134
	}

	public bool skipOnDrop
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public VideoSource source
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	[NativeHeader("Runtime/Camera/Camera.h")]
	public Camera targetCamera
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	public Video3DLayout targetCamera3DLayout
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public float targetCameraAlpha
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public string targetMaterialProperty
	{
		 get { } //Length: 256
		 set { } //Length: 435
	}

	[NativeHeader("Runtime/Graphics/Renderer.h")]
	public Renderer targetMaterialRenderer
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	public RenderTexture targetTexture
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	[NativeHeader("Runtime/Graphics/Texture.h")]
	public Texture texture
	{
		 get { } //Length: 144
	}

	[NativeName("SecPosition")]
	public double time
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public VideoTimeReference timeReference
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	[Obsolete("VideoPlayer.timeSource is deprecated. Use timeUpdateMode instead. (UnityUpgradable) -> timeUpdateMode")]
	public VideoTimeSource timeSource
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public VideoTimeUpdateMode timeUpdateMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	[NativeName("VideoUrl")]
	public string url
	{
		 get { } //Length: 256
		 set { } //Length: 435
	}

	public bool waitForFirstFrame
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public uint width
	{
		 get { } //Length: 118
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

	private static void EnableAudioTrack_Injected(IntPtr _unity_self, ushort trackIndex, bool enabled) { }

	public VideoAspectRatio get_aspectRatio() { }

	private static VideoAspectRatio get_aspectRatio_Injected(IntPtr _unity_self) { }

	public VideoAudioOutputMode get_audioOutputMode() { }

	private static VideoAudioOutputMode get_audioOutputMode_Injected(IntPtr _unity_self) { }

	public ushort get_audioTrackCount() { }

	private static ushort get_audioTrackCount_Injected(IntPtr _unity_self) { }

	[NativeName("CanSetDirectAudioVolume")]
	public bool get_canSetDirectAudioVolume() { }

	private static bool get_canSetDirectAudioVolume_Injected(IntPtr _unity_self) { }

	[NativeName("CanSetPlaybackSpeed")]
	public bool get_canSetPlaybackSpeed() { }

	private static bool get_canSetPlaybackSpeed_Injected(IntPtr _unity_self) { }

	[NativeName("CanSetSkipOnDrop")]
	public bool get_canSetSkipOnDrop() { }

	private static bool get_canSetSkipOnDrop_Injected(IntPtr _unity_self) { }

	[NativeName("CanSetTime")]
	public bool get_canSetTime() { }

	private static bool get_canSetTime_Injected(IntPtr _unity_self) { }

	[NativeName("CanSetTimeSource")]
	public bool get_canSetTimeSource() { }

	private static bool get_canSetTimeSource_Injected(IntPtr _unity_self) { }

	[NativeName("CanSetTimeUpdateMode")]
	public bool get_canSetTimeUpdateMode() { }

	private static bool get_canSetTimeUpdateMode_Injected(IntPtr _unity_self) { }

	[NativeName("CanStep")]
	public bool get_canStep() { }

	private static bool get_canStep_Injected(IntPtr _unity_self) { }

	public VideoClip get_clip() { }

	private static IntPtr get_clip_Injected(IntPtr _unity_self) { }

	public double get_clockTime() { }

	private static double get_clockTime_Injected(IntPtr _unity_self) { }

	public ushort get_controlledAudioTrackCount() { }

	public static ushort get_controlledAudioTrackMaxCount() { }

	public double get_externalReferenceTime() { }

	private static double get_externalReferenceTime_Injected(IntPtr _unity_self) { }

	public long get_frame() { }

	private static long get_frame_Injected(IntPtr _unity_self) { }

	public ulong get_frameCount() { }

	private static ulong get_frameCount_Injected(IntPtr _unity_self) { }

	public float get_frameRate() { }

	private static float get_frameRate_Injected(IntPtr _unity_self) { }

	public uint get_height() { }

	private static uint get_height_Injected(IntPtr _unity_self) { }

	public bool get_isLooping() { }

	private static bool get_isLooping_Injected(IntPtr _unity_self) { }

	[NativeName("IsPaused")]
	public bool get_isPaused() { }

	private static bool get_isPaused_Injected(IntPtr _unity_self) { }

	[NativeName("IsPlaying")]
	public bool get_isPlaying() { }

	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[NativeName("IsPrepared")]
	public bool get_isPrepared() { }

	private static bool get_isPrepared_Injected(IntPtr _unity_self) { }

	public double get_length() { }

	private static double get_length_Injected(IntPtr _unity_self) { }

	public uint get_pixelAspectRatioDenominator() { }

	private static uint get_pixelAspectRatioDenominator_Injected(IntPtr _unity_self) { }

	public uint get_pixelAspectRatioNumerator() { }

	private static uint get_pixelAspectRatioNumerator_Injected(IntPtr _unity_self) { }

	public float get_playbackSpeed() { }

	private static float get_playbackSpeed_Injected(IntPtr _unity_self) { }

	public bool get_playOnAwake() { }

	private static bool get_playOnAwake_Injected(IntPtr _unity_self) { }

	public VideoRenderMode get_renderMode() { }

	private static VideoRenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	[NativeName("AreFrameReadyEventsEnabled")]
	public bool get_sendFrameReadyEvents() { }

	private static bool get_sendFrameReadyEvents_Injected(IntPtr _unity_self) { }

	public bool get_skipOnDrop() { }

	private static bool get_skipOnDrop_Injected(IntPtr _unity_self) { }

	public VideoSource get_source() { }

	private static VideoSource get_source_Injected(IntPtr _unity_self) { }

	public Camera get_targetCamera() { }

	private static IntPtr get_targetCamera_Injected(IntPtr _unity_self) { }

	public Video3DLayout get_targetCamera3DLayout() { }

	private static Video3DLayout get_targetCamera3DLayout_Injected(IntPtr _unity_self) { }

	public float get_targetCameraAlpha() { }

	private static float get_targetCameraAlpha_Injected(IntPtr _unity_self) { }

	public string get_targetMaterialProperty() { }

	private static void get_targetMaterialProperty_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public Renderer get_targetMaterialRenderer() { }

	private static IntPtr get_targetMaterialRenderer_Injected(IntPtr _unity_self) { }

	public RenderTexture get_targetTexture() { }

	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	public Texture get_texture() { }

	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	public double get_time() { }

	private static double get_time_Injected(IntPtr _unity_self) { }

	public VideoTimeReference get_timeReference() { }

	private static VideoTimeReference get_timeReference_Injected(IntPtr _unity_self) { }

	public VideoTimeSource get_timeSource() { }

	private static VideoTimeSource get_timeSource_Injected(IntPtr _unity_self) { }

	public VideoTimeUpdateMode get_timeUpdateMode() { }

	private static VideoTimeUpdateMode get_timeUpdateMode_Injected(IntPtr _unity_self) { }

	public string get_url() { }

	private static void get_url_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public bool get_waitForFirstFrame() { }

	private static bool get_waitForFirstFrame_Injected(IntPtr _unity_self) { }

	public uint get_width() { }

	private static uint get_width_Injected(IntPtr _unity_self) { }

	public ushort GetAudioChannelCount(ushort trackIndex) { }

	private static ushort GetAudioChannelCount_Injected(IntPtr _unity_self, ushort trackIndex) { }

	public string GetAudioLanguageCode(ushort trackIndex) { }

	private static void GetAudioLanguageCode_Injected(IntPtr _unity_self, ushort trackIndex, out ManagedSpanWrapper ret) { }

	public uint GetAudioSampleRate(ushort trackIndex) { }

	private static uint GetAudioSampleRate_Injected(IntPtr _unity_self, ushort trackIndex) { }

	private ushort GetControlledAudioTrackCount() { }

	private static ushort GetControlledAudioTrackCount_Injected(IntPtr _unity_self) { }

	public bool GetDirectAudioMute(ushort trackIndex) { }

	private static bool GetDirectAudioMute_Injected(IntPtr _unity_self, ushort trackIndex) { }

	public float GetDirectAudioVolume(ushort trackIndex) { }

	private static float GetDirectAudioVolume_Injected(IntPtr _unity_self, ushort trackIndex) { }

	[NativeHeader("Modules/Audio/Public/AudioSource.h")]
	public AudioSource GetTargetAudioSource(ushort trackIndex) { }

	private static IntPtr GetTargetAudioSource_Injected(IntPtr _unity_self, ushort trackIndex) { }

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

	private static bool IsAudioTrackEnabled_Injected(IntPtr _unity_self, ushort trackIndex) { }

	public void Pause() { }

	private static void Pause_Injected(IntPtr _unity_self) { }

	public void Play() { }

	private static void Play_Injected(IntPtr _unity_self) { }

	public void Prepare() { }

	private static void Prepare_Injected(IntPtr _unity_self) { }

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

	private static void set_aspectRatio_Injected(IntPtr _unity_self, VideoAspectRatio value) { }

	public void set_audioOutputMode(VideoAudioOutputMode value) { }

	private static void set_audioOutputMode_Injected(IntPtr _unity_self, VideoAudioOutputMode value) { }

	public void set_clip(VideoClip value) { }

	private static void set_clip_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_controlledAudioTrackCount(ushort value) { }

	public void set_externalReferenceTime(double value) { }

	private static void set_externalReferenceTime_Injected(IntPtr _unity_self, double value) { }

	public void set_frame(long value) { }

	private static void set_frame_Injected(IntPtr _unity_self, long value) { }

	public void set_isLooping(bool value) { }

	private static void set_isLooping_Injected(IntPtr _unity_self, bool value) { }

	public void set_playbackSpeed(float value) { }

	private static void set_playbackSpeed_Injected(IntPtr _unity_self, float value) { }

	public void set_playOnAwake(bool value) { }

	private static void set_playOnAwake_Injected(IntPtr _unity_self, bool value) { }

	public void set_renderMode(VideoRenderMode value) { }

	private static void set_renderMode_Injected(IntPtr _unity_self, VideoRenderMode value) { }

	[NativeName("EnableFrameReadyEvents")]
	public void set_sendFrameReadyEvents(bool value) { }

	private static void set_sendFrameReadyEvents_Injected(IntPtr _unity_self, bool value) { }

	public void set_skipOnDrop(bool value) { }

	private static void set_skipOnDrop_Injected(IntPtr _unity_self, bool value) { }

	public void set_source(VideoSource value) { }

	private static void set_source_Injected(IntPtr _unity_self, VideoSource value) { }

	public void set_targetCamera(Camera value) { }

	private static void set_targetCamera_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_targetCamera3DLayout(Video3DLayout value) { }

	private static void set_targetCamera3DLayout_Injected(IntPtr _unity_self, Video3DLayout value) { }

	public void set_targetCameraAlpha(float value) { }

	private static void set_targetCameraAlpha_Injected(IntPtr _unity_self, float value) { }

	public void set_targetMaterialProperty(string value) { }

	private static void set_targetMaterialProperty_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_targetMaterialRenderer(Renderer value) { }

	private static void set_targetMaterialRenderer_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_targetTexture(RenderTexture value) { }

	private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_time(double value) { }

	private static void set_time_Injected(IntPtr _unity_self, double value) { }

	public void set_timeReference(VideoTimeReference value) { }

	private static void set_timeReference_Injected(IntPtr _unity_self, VideoTimeReference value) { }

	public void set_timeSource(VideoTimeSource value) { }

	private static void set_timeSource_Injected(IntPtr _unity_self, VideoTimeSource value) { }

	public void set_timeUpdateMode(VideoTimeUpdateMode value) { }

	private static void set_timeUpdateMode_Injected(IntPtr _unity_self, VideoTimeUpdateMode value) { }

	public void set_url(string value) { }

	private static void set_url_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_waitForFirstFrame(bool value) { }

	private static void set_waitForFirstFrame_Injected(IntPtr _unity_self, bool value) { }

	private void SetControlledAudioTrackCount(ushort value) { }

	private static void SetControlledAudioTrackCount_Injected(IntPtr _unity_self, ushort value) { }

	public void SetDirectAudioMute(ushort trackIndex, bool mute) { }

	private static void SetDirectAudioMute_Injected(IntPtr _unity_self, ushort trackIndex, bool mute) { }

	public void SetDirectAudioVolume(ushort trackIndex, float volume) { }

	private static void SetDirectAudioVolume_Injected(IntPtr _unity_self, ushort trackIndex, float volume) { }

	public void SetTargetAudioSource(ushort trackIndex, AudioSource source) { }

	private static void SetTargetAudioSource_Injected(IntPtr _unity_self, ushort trackIndex, IntPtr source) { }

	public void StepForward() { }

	private static void StepForward_Injected(IntPtr _unity_self) { }

	public void Stop() { }

	private static void Stop_Injected(IntPtr _unity_self) { }

}

