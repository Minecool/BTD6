namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioSource : AudioBehaviour
{

	public bool bypassEffects
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool bypassListenerEffects
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool bypassReverbZones
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public AudioClip clip
	{
		 get { } //Length: 203
		 set { } //Length: 177
	}

	internal ActivePlayable[] containerActivePlayables
	{
		internal get { } //Length: 118
	}

	public float dopplerLevel
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool ignoreListenerPause
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool ignoreListenerVolume
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	internal bool isContainerPlaying
	{
		[NativeName("IsContainerPlaying")]
		internal get { } //Length: 118
	}

	public bool isPlaying
	{
		[NativeName("IsPlayingScripting")]
		 get { } //Length: 118
	}

	public bool isVirtual
	{
		[NativeName("GetLastVirtualState")]
		 get { } //Length: 118
	}

	public bool loop
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float maxDistance
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[Obsolete("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float maxVolume
	{
		 get { } //Length: 87
		 set { } //Length: 83
	}

	public float minDistance
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[Obsolete("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float minVolume
	{
		 get { } //Length: 87
		 set { } //Length: 83
	}

	public bool mute
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public AudioMixerGroup outputAudioMixerGroup
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	[NativeProperty("StereoPan")]
	public float panStereo
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float pitch
	{
		 get { } //Length: 155
		 set { } //Length: 171
	}

	public bool playOnAwake
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public int priority
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public AudioResource resource
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	public float reverbZoneMix
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[Obsolete("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float rolloffFactor
	{
		 get { } //Length: 87
		 set { } //Length: 83
	}

	public AudioRolloffMode rolloffMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	[NativeProperty("SpatialBlendMix")]
	public float spatialBlend
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool spatialize
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool spatializePostEffects
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float spread
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[NativeProperty("SecPosition")]
	public float time
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[NativeProperty("SamplePosition")]
	public int timeSamples
	{
		[NativeMethod(IsThreadSafe = True)]
		 get { } //Length: 118
		[NativeMethod(IsThreadSafe = True)]
		 set { } //Length: 131
	}

	public AudioVelocityUpdateMode velocityUpdateMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public float volume
	{
		 get { } //Length: 118
		 set { } //Length: 216
	}

	public AudioSource() { }

	public bool get_bypassEffects() { }

	private static bool get_bypassEffects_Injected(IntPtr _unity_self) { }

	public bool get_bypassListenerEffects() { }

	private static bool get_bypassListenerEffects_Injected(IntPtr _unity_self) { }

	public bool get_bypassReverbZones() { }

	private static bool get_bypassReverbZones_Injected(IntPtr _unity_self) { }

	public AudioClip get_clip() { }

	internal ActivePlayable[] get_containerActivePlayables() { }

	private static ActivePlayable[] get_containerActivePlayables_Injected(IntPtr _unity_self) { }

	public float get_dopplerLevel() { }

	private static float get_dopplerLevel_Injected(IntPtr _unity_self) { }

	public bool get_ignoreListenerPause() { }

	private static bool get_ignoreListenerPause_Injected(IntPtr _unity_self) { }

	public bool get_ignoreListenerVolume() { }

	private static bool get_ignoreListenerVolume_Injected(IntPtr _unity_self) { }

	[NativeName("IsContainerPlaying")]
	internal bool get_isContainerPlaying() { }

	private static bool get_isContainerPlaying_Injected(IntPtr _unity_self) { }

	[NativeName("IsPlayingScripting")]
	public bool get_isPlaying() { }

	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[NativeName("GetLastVirtualState")]
	public bool get_isVirtual() { }

	private static bool get_isVirtual_Injected(IntPtr _unity_self) { }

	public bool get_loop() { }

	private static bool get_loop_Injected(IntPtr _unity_self) { }

	public float get_maxDistance() { }

	private static float get_maxDistance_Injected(IntPtr _unity_self) { }

	public float get_maxVolume() { }

	public float get_minDistance() { }

	private static float get_minDistance_Injected(IntPtr _unity_self) { }

	public float get_minVolume() { }

	public bool get_mute() { }

	private static bool get_mute_Injected(IntPtr _unity_self) { }

	public AudioMixerGroup get_outputAudioMixerGroup() { }

	private static IntPtr get_outputAudioMixerGroup_Injected(IntPtr _unity_self) { }

	public float get_panStereo() { }

	private static float get_panStereo_Injected(IntPtr _unity_self) { }

	public float get_pitch() { }

	public bool get_playOnAwake() { }

	private static bool get_playOnAwake_Injected(IntPtr _unity_self) { }

	public int get_priority() { }

	private static int get_priority_Injected(IntPtr _unity_self) { }

	public AudioResource get_resource() { }

	private static IntPtr get_resource_Injected(IntPtr _unity_self) { }

	public float get_reverbZoneMix() { }

	private static float get_reverbZoneMix_Injected(IntPtr _unity_self) { }

	public float get_rolloffFactor() { }

	public AudioRolloffMode get_rolloffMode() { }

	private static AudioRolloffMode get_rolloffMode_Injected(IntPtr _unity_self) { }

	public float get_spatialBlend() { }

	private static float get_spatialBlend_Injected(IntPtr _unity_self) { }

	public bool get_spatialize() { }

	private static bool get_spatialize_Injected(IntPtr _unity_self) { }

	public bool get_spatializePostEffects() { }

	private static bool get_spatializePostEffects_Injected(IntPtr _unity_self) { }

	public float get_spread() { }

	private static float get_spread_Injected(IntPtr _unity_self) { }

	public float get_time() { }

	private static float get_time_Injected(IntPtr _unity_self) { }

	[NativeMethod(IsThreadSafe = True)]
	public int get_timeSamples() { }

	private static int get_timeSamples_Injected(IntPtr _unity_self) { }

	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	private static AudioVelocityUpdateMode get_velocityUpdateMode_Injected(IntPtr _unity_self) { }

	public float get_volume() { }

	private static float get_volume_Injected(IntPtr _unity_self) { }

	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	private static bool GetAmbisonicDecoderFloat_Injected(IntPtr _unity_self, int index, out float value) { }

	internal float GetAudioRandomContainerRuntimeMeterValue() { }

	private static float GetAudioRandomContainerRuntimeMeterValue_Injected(IntPtr _unity_self) { }

	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	private static IntPtr GetCustomCurveHelper_Injected(IntPtr source, AudioSourceCurveType type) { }

	public void GetOutputData(Single[] samples, int channel) { }

	[Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
	public Single[] GetOutputData(int numSamples, int channel) { }

	private static void GetOutputDataHelper(AudioSource source, out Single[] samples, int channel) { }

	private static void GetOutputDataHelper_Injected(IntPtr source, out BlittableArrayWrapper samples, int channel) { }

	private static float GetPitch(AudioSource source) { }

	private static float GetPitch_Injected(IntPtr source) { }

	public bool GetSpatializerFloat(int index, out float value) { }

	private static bool GetSpatializerFloat_Injected(IntPtr _unity_self, int index, out float value) { }

	[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
	public Single[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	public void GetSpectrumData(Single[] samples, int channel, FFTWindow window) { }

	[NativeThrows]
	private static void GetSpectrumDataHelper(AudioSource source, out Single[] samples, int channel, FFTWindow window) { }

	private static void GetSpectrumDataHelper_Injected(IntPtr source, out BlittableArrayWrapper samples, int channel, FFTWindow window) { }

	public void Pause() { }

	private static void Pause_Injected(IntPtr _unity_self) { }

	private void Play(double delay) { }

	[ExcludeFromDocs]
	public void Play() { }

	public void Play(ulong delay) { }

	private static void Play_Injected(IntPtr _unity_self, double delay) { }

	[ExcludeFromDocs]
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	public void PlayDelayed(float delay) { }

	private static void PlayHelper(AudioSource source, ulong delay) { }

	private static void PlayHelper_Injected(IntPtr source, ulong delay) { }

	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	[ExcludeFromDocs]
	public void PlayOneShot(AudioClip clip) { }

	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	private static void PlayOneShotHelper_Injected(IntPtr source, IntPtr clip, float volumeScale) { }

	public void PlayScheduled(double time) { }

	public void set_bypassEffects(bool value) { }

	private static void set_bypassEffects_Injected(IntPtr _unity_self, bool value) { }

	public void set_bypassListenerEffects(bool value) { }

	private static void set_bypassListenerEffects_Injected(IntPtr _unity_self, bool value) { }

	public void set_bypassReverbZones(bool value) { }

	private static void set_bypassReverbZones_Injected(IntPtr _unity_self, bool value) { }

	public void set_clip(AudioClip value) { }

	public void set_dopplerLevel(float value) { }

	private static void set_dopplerLevel_Injected(IntPtr _unity_self, float value) { }

	public void set_ignoreListenerPause(bool value) { }

	private static void set_ignoreListenerPause_Injected(IntPtr _unity_self, bool value) { }

	public void set_ignoreListenerVolume(bool value) { }

	private static void set_ignoreListenerVolume_Injected(IntPtr _unity_self, bool value) { }

	public void set_loop(bool value) { }

	private static void set_loop_Injected(IntPtr _unity_self, bool value) { }

	public void set_maxDistance(float value) { }

	private static void set_maxDistance_Injected(IntPtr _unity_self, float value) { }

	public void set_maxVolume(float value) { }

	public void set_minDistance(float value) { }

	private static void set_minDistance_Injected(IntPtr _unity_self, float value) { }

	public void set_minVolume(float value) { }

	public void set_mute(bool value) { }

	private static void set_mute_Injected(IntPtr _unity_self, bool value) { }

	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	private static void set_outputAudioMixerGroup_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_panStereo(float value) { }

	private static void set_panStereo_Injected(IntPtr _unity_self, float value) { }

	public void set_pitch(float value) { }

	public void set_playOnAwake(bool value) { }

	private static void set_playOnAwake_Injected(IntPtr _unity_self, bool value) { }

	public void set_priority(int value) { }

	private static void set_priority_Injected(IntPtr _unity_self, int value) { }

	public void set_resource(AudioResource value) { }

	private static void set_resource_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_reverbZoneMix(float value) { }

	private static void set_reverbZoneMix_Injected(IntPtr _unity_self, float value) { }

	public void set_rolloffFactor(float value) { }

	public void set_rolloffMode(AudioRolloffMode value) { }

	private static void set_rolloffMode_Injected(IntPtr _unity_self, AudioRolloffMode value) { }

	public void set_spatialBlend(float value) { }

	private static void set_spatialBlend_Injected(IntPtr _unity_self, float value) { }

	public void set_spatialize(bool value) { }

	private static void set_spatialize_Injected(IntPtr _unity_self, bool value) { }

	public void set_spatializePostEffects(bool value) { }

	private static void set_spatializePostEffects_Injected(IntPtr _unity_self, bool value) { }

	public void set_spread(float value) { }

	private static void set_spread_Injected(IntPtr _unity_self, float value) { }

	public void set_time(float value) { }

	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	[NativeMethod(IsThreadSafe = True)]
	public void set_timeSamples(int value) { }

	private static void set_timeSamples_Injected(IntPtr _unity_self, int value) { }

	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	private static void set_velocityUpdateMode_Injected(IntPtr _unity_self, AudioVelocityUpdateMode value) { }

	public void set_volume(float value) { }

	private static void set_volume_Injected(IntPtr _unity_self, float value) { }

	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	private static bool SetAmbisonicDecoderFloat_Injected(IntPtr _unity_self, int index, float value) { }

	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	[NativeThrows]
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	private static void SetCustomCurveHelper_Injected(IntPtr source, AudioSourceCurveType type, IntPtr curve) { }

	private static void SetPitch(AudioSource source, float pitch) { }

	private static void SetPitch_Injected(IntPtr source, float pitch) { }

	public void SetScheduledEndTime(double time) { }

	private static void SetScheduledEndTime_Injected(IntPtr _unity_self, double time) { }

	public void SetScheduledStartTime(double time) { }

	private static void SetScheduledStartTime_Injected(IntPtr _unity_self, double time) { }

	public bool SetSpatializerFloat(int index, float value) { }

	private static bool SetSpatializerFloat_Injected(IntPtr _unity_self, int index, float value) { }

	internal void SkipToNextElementIfHasContainer() { }

	private static void SkipToNextElementIfHasContainer_Injected(IntPtr _unity_self) { }

	private void Stop(bool stopOneShots) { }

	public void Stop() { }

	private static void Stop_Injected(IntPtr _unity_self, bool stopOneShots) { }

	public void UnPause() { }

	private static void UnPause_Injected(IntPtr _unity_self) { }

}

