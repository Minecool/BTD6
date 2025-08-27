namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", StaticAccessorType::DoubleColon (2))]
public sealed class AudioSource : AudioBehaviour
{

	public bool bypassEffects
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool bypassListenerEffects
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool bypassReverbZones
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("AudioClip")]
	public AudioClip clip
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float dopplerLevel
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool ignoreListenerPause
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool ignoreListenerVolume
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool isPlaying
	{
		[NativeName("IsPlayingScripting")]
		 get { } //Length: 51
	}

	public bool isVirtual
	{
		[NativeName("GetLastVirtualState")]
		 get { } //Length: 51
	}

	public bool loop
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float maxDistance
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[Obsolete("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float maxVolume
	{
		 get { } //Length: 87
		 set { } //Length: 83
	}

	public float minDistance
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[Obsolete("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float minVolume
	{
		 get { } //Length: 87
		 set { } //Length: 83
	}

	public bool mute
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public AudioMixerGroup outputAudioMixerGroup
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("StereoPan")]
	public float panStereo
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float pitch
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool playOnAwake
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int priority
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float reverbZoneMix
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[Obsolete("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.", True)]
	public float rolloffFactor
	{
		 get { } //Length: 87
		 set { } //Length: 83
	}

	public AudioRolloffMode rolloffMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty("SpatialBlendMix")]
	public float spatialBlend
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool spatialize
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool spatializePostEffects
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float spread
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty("SecPosition")]
	public float time
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty("SamplePosition")]
	public int timeSamples
	{
		[NativeMethod(IsThreadSafe = True)]
		 get { } //Length: 51
		[NativeMethod(IsThreadSafe = True)]
		 set { } //Length: 64
	}

	public AudioVelocityUpdateMode velocityUpdateMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float volume
	{
		 get { } //Length: 51
		 set { } //Length: 1761
	}

	public AudioSource() { }

	public bool get_bypassEffects() { }

	public bool get_bypassListenerEffects() { }

	public bool get_bypassReverbZones() { }

	public AudioClip get_clip() { }

	public float get_dopplerLevel() { }

	public bool get_ignoreListenerPause() { }

	public bool get_ignoreListenerVolume() { }

	[NativeName("IsPlayingScripting")]
	public bool get_isPlaying() { }

	[NativeName("GetLastVirtualState")]
	public bool get_isVirtual() { }

	public bool get_loop() { }

	public float get_maxDistance() { }

	public float get_maxVolume() { }

	public float get_minDistance() { }

	public float get_minVolume() { }

	public bool get_mute() { }

	public AudioMixerGroup get_outputAudioMixerGroup() { }

	public float get_panStereo() { }

	public float get_pitch() { }

	public bool get_playOnAwake() { }

	public int get_priority() { }

	public float get_reverbZoneMix() { }

	public float get_rolloffFactor() { }

	public AudioRolloffMode get_rolloffMode() { }

	public float get_spatialBlend() { }

	public bool get_spatialize() { }

	public bool get_spatializePostEffects() { }

	public float get_spread() { }

	public float get_time() { }

	[NativeMethod(IsThreadSafe = True)]
	public int get_timeSamples() { }

	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	public float get_volume() { }

	public bool GetAmbisonicDecoderFloat(int index, out float value) { }

	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	[Obsolete("GetOutputData returning a float[] is deprecated, use GetOutputData and pass a pre allocated array instead.")]
	public Single[] GetOutputData(int numSamples, int channel) { }

	public void GetOutputData(Single[] samples, int channel) { }

	private static void GetOutputDataHelper(AudioSource source, out Single[] samples, int channel) { }

	private static float GetPitch(AudioSource source) { }

	public bool GetSpatializerFloat(int index, out float value) { }

	[Obsolete("GetSpectrumData returning a float[] is deprecated, use GetSpectrumData and pass a pre allocated array instead.")]
	public Single[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	public void GetSpectrumData(Single[] samples, int channel, FFTWindow window) { }

	[NativeThrows]
	private static void GetSpectrumDataHelper(AudioSource source, out Single[] samples, int channel, FFTWindow window) { }

	public void Pause() { }

	public void Play(ulong delay) { }

	[ExcludeFromDocs]
	public void Play() { }

	private void Play(double delay) { }

	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	[ExcludeFromDocs]
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	public void PlayDelayed(float delay) { }

	private static void PlayHelper(AudioSource source, ulong delay) { }

	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	[ExcludeFromDocs]
	public void PlayOneShot(AudioClip clip) { }

	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	public void PlayScheduled(double time) { }

	public void set_bypassEffects(bool value) { }

	public void set_bypassListenerEffects(bool value) { }

	public void set_bypassReverbZones(bool value) { }

	public void set_clip(AudioClip value) { }

	public void set_dopplerLevel(float value) { }

	public void set_ignoreListenerPause(bool value) { }

	public void set_ignoreListenerVolume(bool value) { }

	public void set_loop(bool value) { }

	public void set_maxDistance(float value) { }

	public void set_maxVolume(float value) { }

	public void set_minDistance(float value) { }

	public void set_minVolume(float value) { }

	public void set_mute(bool value) { }

	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	public void set_panStereo(float value) { }

	public void set_pitch(float value) { }

	public void set_playOnAwake(bool value) { }

	public void set_priority(int value) { }

	public void set_reverbZoneMix(float value) { }

	public void set_rolloffFactor(float value) { }

	public void set_rolloffMode(AudioRolloffMode value) { }

	public void set_spatialBlend(float value) { }

	public void set_spatialize(bool value) { }

	public void set_spatializePostEffects(bool value) { }

	public void set_spread(float value) { }

	public void set_time(float value) { }

	[NativeMethod(IsThreadSafe = True)]
	public void set_timeSamples(int value) { }

	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	public void set_volume(float value) { }

	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	[NativeThrows]
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	private static void SetPitch(AudioSource source, float pitch) { }

	public void SetScheduledEndTime(double time) { }

	public void SetScheduledStartTime(double time) { }

	public bool SetSpatializerFloat(int index, float value) { }

	public void Stop() { }

	private void Stop(bool stopOneShots) { }

	public void UnPause() { }

}

