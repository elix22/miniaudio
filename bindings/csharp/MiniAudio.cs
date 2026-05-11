// machine generated, do not edit
using System;
using System.Runtime.InteropServices;
using M = System.Runtime.InteropServices.MarshalAsAttribute;
using U = System.Runtime.InteropServices.UnmanagedType;

namespace MiniAudioNS
{
public static unsafe partial class MiniAudio
{
public enum ma_log_level
{
    MA_LOG_LEVEL_DEBUG = 4,
    MA_LOG_LEVEL_INFO = 3,
    MA_LOG_LEVEL_WARNING = 2,
    MA_LOG_LEVEL_ERROR = 1,
}
public const int MA_CHANNEL_NONE = 0;
public const int MA_CHANNEL_MONO = 1;
public const int MA_CHANNEL_FRONT_LEFT = 2;
public const int MA_CHANNEL_FRONT_RIGHT = 3;
public const int MA_CHANNEL_FRONT_CENTER = 4;
public const int MA_CHANNEL_LFE = 5;
public const int MA_CHANNEL_BACK_LEFT = 6;
public const int MA_CHANNEL_BACK_RIGHT = 7;
public const int MA_CHANNEL_FRONT_LEFT_CENTER = 8;
public const int MA_CHANNEL_FRONT_RIGHT_CENTER = 9;
public const int MA_CHANNEL_BACK_CENTER = 10;
public const int MA_CHANNEL_SIDE_LEFT = 11;
public const int MA_CHANNEL_SIDE_RIGHT = 12;
public const int MA_CHANNEL_TOP_CENTER = 13;
public const int MA_CHANNEL_TOP_FRONT_LEFT = 14;
public const int MA_CHANNEL_TOP_FRONT_CENTER = 15;
public const int MA_CHANNEL_TOP_FRONT_RIGHT = 16;
public const int MA_CHANNEL_TOP_BACK_LEFT = 17;
public const int MA_CHANNEL_TOP_BACK_CENTER = 18;
public const int MA_CHANNEL_TOP_BACK_RIGHT = 19;
public const int MA_CHANNEL_AUX_0 = 20;
public const int MA_CHANNEL_AUX_1 = 21;
public const int MA_CHANNEL_AUX_2 = 22;
public const int MA_CHANNEL_AUX_3 = 23;
public const int MA_CHANNEL_AUX_4 = 24;
public const int MA_CHANNEL_AUX_5 = 25;
public const int MA_CHANNEL_AUX_6 = 26;
public const int MA_CHANNEL_AUX_7 = 27;
public const int MA_CHANNEL_AUX_8 = 28;
public const int MA_CHANNEL_AUX_9 = 29;
public const int MA_CHANNEL_AUX_10 = 30;
public const int MA_CHANNEL_AUX_11 = 31;
public const int MA_CHANNEL_AUX_12 = 32;
public const int MA_CHANNEL_AUX_13 = 33;
public const int MA_CHANNEL_AUX_14 = 34;
public const int MA_CHANNEL_AUX_15 = 35;
public const int MA_CHANNEL_AUX_16 = 36;
public const int MA_CHANNEL_AUX_17 = 37;
public const int MA_CHANNEL_AUX_18 = 38;
public const int MA_CHANNEL_AUX_19 = 39;
public const int MA_CHANNEL_AUX_20 = 40;
public const int MA_CHANNEL_AUX_21 = 41;
public const int MA_CHANNEL_AUX_22 = 42;
public const int MA_CHANNEL_AUX_23 = 43;
public const int MA_CHANNEL_AUX_24 = 44;
public const int MA_CHANNEL_AUX_25 = 45;
public const int MA_CHANNEL_AUX_26 = 46;
public const int MA_CHANNEL_AUX_27 = 47;
public const int MA_CHANNEL_AUX_28 = 48;
public const int MA_CHANNEL_AUX_29 = 49;
public const int MA_CHANNEL_AUX_30 = 50;
public const int MA_CHANNEL_AUX_31 = 51;
public const int MA_CHANNEL_POSITION_COUNT = 52;
public const int MA_CHANNEL_LEFT = 2;
public const int MA_CHANNEL_RIGHT = 3;
public enum ma_result
{
    MA_SUCCESS = 0,
    MA_ERROR = -1,
    MA_INVALID_ARGS = -2,
    MA_INVALID_OPERATION = -3,
    MA_OUT_OF_MEMORY = -4,
    MA_OUT_OF_RANGE = -5,
    MA_ACCESS_DENIED = -6,
    MA_DOES_NOT_EXIST = -7,
    MA_ALREADY_EXISTS = -8,
    MA_TOO_MANY_OPEN_FILES = -9,
    MA_INVALID_FILE = -10,
    MA_TOO_BIG = -11,
    MA_PATH_TOO_LONG = -12,
    MA_NAME_TOO_LONG = -13,
    MA_NOT_DIRECTORY = -14,
    MA_IS_DIRECTORY = -15,
    MA_DIRECTORY_NOT_EMPTY = -16,
    MA_AT_END = -17,
    MA_NO_SPACE = -18,
    MA_BUSY = -19,
    MA_IO_ERROR = -20,
    MA_INTERRUPT = -21,
    MA_UNAVAILABLE = -22,
    MA_ALREADY_IN_USE = -23,
    MA_BAD_ADDRESS = -24,
    MA_BAD_SEEK = -25,
    MA_BAD_PIPE = -26,
    MA_DEADLOCK = -27,
    MA_TOO_MANY_LINKS = -28,
    MA_NOT_IMPLEMENTED = -29,
    MA_NO_MESSAGE = -30,
    MA_BAD_MESSAGE = -31,
    MA_NO_DATA_AVAILABLE = -32,
    MA_INVALID_DATA = -33,
    MA_TIMEOUT = -34,
    MA_NO_NETWORK = -35,
    MA_NOT_UNIQUE = -36,
    MA_NOT_SOCKET = -37,
    MA_NO_ADDRESS = -38,
    MA_BAD_PROTOCOL = -39,
    MA_PROTOCOL_UNAVAILABLE = -40,
    MA_PROTOCOL_NOT_SUPPORTED = -41,
    MA_PROTOCOL_FAMILY_NOT_SUPPORTED = -42,
    MA_ADDRESS_FAMILY_NOT_SUPPORTED = -43,
    MA_SOCKET_NOT_SUPPORTED = -44,
    MA_CONNECTION_RESET = -45,
    MA_ALREADY_CONNECTED = -46,
    MA_NOT_CONNECTED = -47,
    MA_CONNECTION_REFUSED = -48,
    MA_NO_HOST = -49,
    MA_IN_PROGRESS = -50,
    MA_CANCELLED = -51,
    MA_MEMORY_ALREADY_MAPPED = -52,
    MA_CRC_MISMATCH = -100,
    MA_FORMAT_NOT_SUPPORTED = -200,
    MA_DEVICE_TYPE_NOT_SUPPORTED = -201,
    MA_SHARE_MODE_NOT_SUPPORTED = -202,
    MA_NO_BACKEND = -203,
    MA_NO_DEVICE = -204,
    MA_API_NOT_FOUND = -205,
    MA_INVALID_DEVICE_CONFIG = -206,
    MA_LOOP = -207,
    MA_BACKEND_NOT_ENABLED = -208,
    MA_DEVICE_NOT_INITIALIZED = -300,
    MA_DEVICE_ALREADY_INITIALIZED = -301,
    MA_DEVICE_NOT_STARTED = -302,
    MA_DEVICE_NOT_STOPPED = -303,
    MA_FAILED_TO_INIT_BACKEND = -400,
    MA_FAILED_TO_OPEN_BACKEND_DEVICE = -401,
    MA_FAILED_TO_START_BACKEND_DEVICE = -402,
    MA_FAILED_TO_STOP_BACKEND_DEVICE = -403,
}
public enum ma_stream_format
{
    ma_stream_format_pcm = 0,
}
public enum ma_stream_layout
{
    ma_stream_layout_interleaved = 0,
    ma_stream_layout_deinterleaved,
}
public enum ma_dither_mode
{
    ma_dither_mode_none = 0,
    ma_dither_mode_rectangle,
    ma_dither_mode_triangle,
}
public enum ma_format
{
    ma_format_unknown = 0,
    ma_format_u8 = 1,
    ma_format_s16 = 2,
    ma_format_s24 = 3,
    ma_format_s32 = 4,
    ma_format_f32 = 5,
    ma_format_count,
}
public enum ma_standard_sample_rate
{
    ma_standard_sample_rate_48000 = 48000,
    ma_standard_sample_rate_44100 = 44100,
    ma_standard_sample_rate_32000 = 32000,
    ma_standard_sample_rate_24000 = 24000,
    ma_standard_sample_rate_22050 = 22050,
    ma_standard_sample_rate_88200 = 88200,
    ma_standard_sample_rate_96000 = 96000,
    ma_standard_sample_rate_176400 = 176400,
    ma_standard_sample_rate_192000 = 192000,
    ma_standard_sample_rate_16000 = 16000,
    ma_standard_sample_rate_11025 = 11025,
    ma_standard_sample_rate_8000 = 8000,
    ma_standard_sample_rate_352800 = 352800,
    ma_standard_sample_rate_384000 = 384000,
    ma_standard_sample_rate_min = 8000,
    ma_standard_sample_rate_max = 384000,
    ma_standard_sample_rate_count = 14,
}
public enum ma_channel_mix_mode
{
    ma_channel_mix_mode_rectangular = 0,
    ma_channel_mix_mode_simple,
    ma_channel_mix_mode_custom_weights,
    ma_channel_mix_mode_default = 0,
}
public enum ma_standard_channel_map
{
    ma_standard_channel_map_microsoft,
    ma_standard_channel_map_alsa,
    ma_standard_channel_map_rfc3551,
    ma_standard_channel_map_flac,
    ma_standard_channel_map_vorbis,
    ma_standard_channel_map_sound4,
    ma_standard_channel_map_sndio,
    ma_standard_channel_map_webaudio = 3,
    ma_standard_channel_map_default = 0,
}
public enum ma_performance_profile
{
    ma_performance_profile_low_latency = 0,
    ma_performance_profile_conservative,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_allocation_callbacks
{
    public void* pUserData;
    public delegate* unmanaged<nuint, void*, void*> onMalloc;
    public delegate* unmanaged<void*, nuint, void*, void*> onRealloc;
    public delegate* unmanaged<void*, void*, void> onFree;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_lcg
{
    public uint state;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_atomic_uint32
{
    public uint value;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_atomic_int32
{
    public int value;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_atomic_uint64
{
    public ulong value;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_atomic_float
{
    public float value;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_atomic_bool32
{
    public uint value;
}
public enum ma_thread_priority
{
    ma_thread_priority_idle = -5,
    ma_thread_priority_lowest = -4,
    ma_thread_priority_low = -3,
    ma_thread_priority_normal = -2,
    ma_thread_priority_high = -1,
    ma_thread_priority_highest = 0,
    ma_thread_priority_realtime = 1,
    ma_thread_priority_default = 0,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_event
{
    public uint value;
    public IntPtr dolock;
    public IntPtr cond;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_semaphore
{
    public int value;
    public IntPtr dolock;
    public IntPtr cond;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_version", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_version", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_version(ref uint pMajor, ref uint pMinor, ref uint pRevision);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_version_string", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_version_string", CallingConvention = CallingConvention.Cdecl)]
#endif
private static extern IntPtr ma_version_string_native();

public static string ma_version_string()
{
    IntPtr ptr = ma_version_string_native();
    if (ptr == IntPtr.Zero)
        return "";

    // Manual UTF-8 to string conversion to avoid marshalling corruption
    try
    {
        return Marshal.PtrToStringUTF8(ptr) ?? "";
    }
    catch
    {
        // Fallback in case of any marshalling issues
        return "";
    }
}

[StructLayout(LayoutKind.Sequential)]
public struct ma_log_callback
{
    public IntPtr onLog;
    public void* pUserData;
}
#if WEB
public static ma_log_callback ma_log_callback_init(IntPtr onLog, void* pUserData)
{
    ma_log_callback result = default;
    ma_log_callback_init_internal(ref result, onLog, pUserData);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_log_callback_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_log_callback_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_log_callback ma_log_callback_init(IntPtr onLog, void* pUserData);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_log
{
    #pragma warning disable 169
    public struct callbacksCollection
    {
        public ref ma_log_callback this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 4)[index];
        private ma_log_callback _item0;
        private ma_log_callback _item1;
        private ma_log_callback _item2;
        private ma_log_callback _item3;
    }
    #pragma warning restore 169
    public callbacksCollection callbacks;
    public uint callbackCount;
    public ma_allocation_callbacks allocationCallbacks;
    public IntPtr dolock;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_log_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_log_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_log_init(in ma_allocation_callbacks pAllocationCallbacks, ma_log* pLog);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_log_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_log_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_log_uninit(ma_log* pLog);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_log_register_callback", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_log_register_callback", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_log_register_callback(ma_log* pLog, ma_log_callback callback);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_log_unregister_callback", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_log_unregister_callback", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_log_unregister_callback(ma_log* pLog, ma_log_callback callback);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_log_post", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_log_post", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_log_post(ma_log* pLog, uint level, [M(U.LPUTF8Str)] string pMessage);

[StructLayout(LayoutKind.Sequential)]
public struct ma_biquad_coefficient
{
    public float f32;
    public int s32;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_biquad_config
{
    public ma_format format;
    public uint channels;
    public double b0;
    public double b1;
    public double b2;
    public double a0;
    public double a1;
    public double a2;
}
#if WEB
public static ma_biquad_config ma_biquad_config_init(ma_format format, uint channels, double b0, double b1, double b2, double a0, double a1, double a2)
{
    ma_biquad_config result = default;
    ma_biquad_config_init_internal(ref result, format, channels, b0, b1, b2, a0, a1, a2);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_biquad_config ma_biquad_config_init(ma_format format, uint channels, double b0, double b1, double b2, double a0, double a1, double a2);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_biquad
{
    public ma_format format;
    public uint channels;
    public ma_biquad_coefficient b0;
    public ma_biquad_coefficient b1;
    public ma_biquad_coefficient b2;
    public ma_biquad_coefficient a1;
    public ma_biquad_coefficient a2;
    public ma_biquad_coefficient* pR1;
    public ma_biquad_coefficient* pR2;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_biquad_get_heap_size(in ma_biquad_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_biquad_init_preallocated(in ma_biquad_config pConfig, void* pHeap, ma_biquad* pBQ);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_biquad_init(in ma_biquad_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_biquad* pBQ);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_biquad_uninit(ma_biquad* pBQ, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_biquad_reinit(in ma_biquad_config pConfig, ma_biquad* pBQ);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_clear_cache", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_clear_cache", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_biquad_clear_cache(ma_biquad* pBQ);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_biquad_process_pcm_frames(ma_biquad* pBQ, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_biquad_get_latency(in ma_biquad pBQ);

[StructLayout(LayoutKind.Sequential)]
public struct ma_lpf1_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double cutoffFrequency;
    public double q;
}
#if WEB
public static ma_lpf1_config ma_lpf1_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency)
{
    ma_lpf1_config result = default;
    ma_lpf1_config_init_internal(ref result, format, channels, sampleRate, cutoffFrequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_lpf1_config ma_lpf1_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency);
#endif

#if WEB
public static ma_lpf1_config ma_lpf2_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q)
{
    ma_lpf1_config result = default;
    ma_lpf2_config_init_internal(ref result, format, channels, sampleRate, cutoffFrequency, q);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_lpf1_config ma_lpf2_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_lpf1
{
    public ma_format format;
    public uint channels;
    public ma_biquad_coefficient a;
    public ma_biquad_coefficient* pR1;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf1_get_heap_size(in ma_lpf1_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf1_init_preallocated(in ma_lpf1_config pConfig, void* pHeap, ma_lpf1* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf1_init(in ma_lpf1_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_lpf1* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_lpf1_uninit(ma_lpf1* pLPF, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf1_reinit(in ma_lpf1_config pConfig, ma_lpf1* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_clear_cache", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_clear_cache", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf1_clear_cache(ma_lpf1* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf1_process_pcm_frames(ma_lpf1* pLPF, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_lpf1_get_latency(in ma_lpf1 pLPF);

[StructLayout(LayoutKind.Sequential)]
public struct ma_lpf2
{
    public ma_biquad bq;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf2_get_heap_size(in ma_lpf1_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf2_init_preallocated(in ma_lpf1_config pConfig, void* pHeap, ma_lpf2* pHPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf2_init(in ma_lpf1_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_lpf2* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_lpf2_uninit(ma_lpf2* pLPF, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf2_reinit(in ma_lpf1_config pConfig, ma_lpf2* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_clear_cache", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_clear_cache", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf2_clear_cache(ma_lpf2* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf2_process_pcm_frames(ma_lpf2* pLPF, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_lpf2_get_latency(in ma_lpf2 pLPF);

[StructLayout(LayoutKind.Sequential)]
public struct ma_lpf_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double cutoffFrequency;
    public uint order;
}
#if WEB
public static ma_lpf_config ma_lpf_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order)
{
    ma_lpf_config result = default;
    ma_lpf_config_init_internal(ref result, format, channels, sampleRate, cutoffFrequency, order);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_lpf_config ma_lpf_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_lpf
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public uint lpf1Count;
    public uint lpf2Count;
    public ma_lpf1* pLPF1;
    public ma_lpf2* pLPF2;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf_get_heap_size(in ma_lpf_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf_init_preallocated(in ma_lpf_config pConfig, void* pHeap, ma_lpf* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf_init(in ma_lpf_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_lpf* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_lpf_uninit(ma_lpf* pLPF, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf_reinit(in ma_lpf_config pConfig, ma_lpf* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_clear_cache", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_clear_cache", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf_clear_cache(ma_lpf* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf_process_pcm_frames(ma_lpf* pLPF, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_lpf_get_latency(in ma_lpf pLPF);

[StructLayout(LayoutKind.Sequential)]
public struct ma_hpf1_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double cutoffFrequency;
    public double q;
}
#if WEB
public static ma_hpf1_config ma_hpf1_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency)
{
    ma_hpf1_config result = default;
    ma_hpf1_config_init_internal(ref result, format, channels, sampleRate, cutoffFrequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf1_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf1_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_hpf1_config ma_hpf1_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency);
#endif

#if WEB
public static ma_hpf1_config ma_hpf2_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q)
{
    ma_hpf1_config result = default;
    ma_hpf2_config_init_internal(ref result, format, channels, sampleRate, cutoffFrequency, q);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_hpf1_config ma_hpf2_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_hpf1
{
    public ma_format format;
    public uint channels;
    public ma_biquad_coefficient a;
    public ma_biquad_coefficient* pR1;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf1_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf1_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf1_get_heap_size(in ma_hpf1_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf1_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf1_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf1_init_preallocated(in ma_hpf1_config pConfig, void* pHeap, ma_hpf1* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf1_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf1_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf1_init(in ma_hpf1_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_hpf1* pHPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf1_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf1_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hpf1_uninit(ma_hpf1* pHPF, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf1_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf1_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf1_reinit(in ma_hpf1_config pConfig, ma_hpf1* pHPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf1_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf1_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf1_process_pcm_frames(ma_hpf1* pHPF, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf1_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf1_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_hpf1_get_latency(in ma_hpf1 pHPF);

[StructLayout(LayoutKind.Sequential)]
public struct ma_hpf2
{
    public ma_biquad bq;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf2_get_heap_size(in ma_hpf1_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf2_init_preallocated(in ma_hpf1_config pConfig, void* pHeap, ma_hpf2* pHPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf2_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf2_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf2_init(in ma_hpf1_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_hpf2* pHPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hpf2_uninit(ma_hpf2* pHPF, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf2_reinit(in ma_hpf1_config pConfig, ma_hpf2* pHPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf2_process_pcm_frames(ma_hpf2* pHPF, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_hpf2_get_latency(in ma_hpf2 pHPF);

[StructLayout(LayoutKind.Sequential)]
public struct ma_hpf_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double cutoffFrequency;
    public uint order;
}
#if WEB
public static ma_hpf_config ma_hpf_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order)
{
    ma_hpf_config result = default;
    ma_hpf_config_init_internal(ref result, format, channels, sampleRate, cutoffFrequency, order);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_hpf_config ma_hpf_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_hpf
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public uint hpf1Count;
    public uint hpf2Count;
    public ma_hpf1* pHPF1;
    public ma_hpf2* pHPF2;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf_get_heap_size(in ma_hpf_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf_init_preallocated(in ma_hpf_config pConfig, void* pHeap, ma_hpf* pLPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf_init(in ma_hpf_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_hpf* pHPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hpf_uninit(ma_hpf* pHPF, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf_reinit(in ma_hpf_config pConfig, ma_hpf* pHPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf_process_pcm_frames(ma_hpf* pHPF, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_hpf_get_latency(in ma_hpf pHPF);

[StructLayout(LayoutKind.Sequential)]
public struct ma_bpf2_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double cutoffFrequency;
    public double q;
}
#if WEB
public static ma_bpf2_config ma_bpf2_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q)
{
    ma_bpf2_config result = default;
    ma_bpf2_config_init_internal(ref result, format, channels, sampleRate, cutoffFrequency, q);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_bpf2_config ma_bpf2_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_bpf2
{
    public ma_biquad bq;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf2_get_heap_size(in ma_bpf2_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf2_init_preallocated(in ma_bpf2_config pConfig, void* pHeap, ma_bpf2* pBPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf2_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf2_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf2_init(in ma_bpf2_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_bpf2* pBPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_bpf2_uninit(ma_bpf2* pBPF, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf2_reinit(in ma_bpf2_config pConfig, ma_bpf2* pBPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf2_process_pcm_frames(ma_bpf2* pBPF, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_bpf2_get_latency(in ma_bpf2 pBPF);

[StructLayout(LayoutKind.Sequential)]
public struct ma_bpf_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double cutoffFrequency;
    public uint order;
}
#if WEB
public static ma_bpf_config ma_bpf_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order)
{
    ma_bpf_config result = default;
    ma_bpf_config_init_internal(ref result, format, channels, sampleRate, cutoffFrequency, order);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_bpf_config ma_bpf_config_init(ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_bpf
{
    public ma_format format;
    public uint channels;
    public uint bpf2Count;
    public ma_bpf2* pBPF2;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf_get_heap_size(in ma_bpf_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf_init_preallocated(in ma_bpf_config pConfig, void* pHeap, ma_bpf* pBPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf_init(in ma_bpf_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_bpf* pBPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_bpf_uninit(ma_bpf* pBPF, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf_reinit(in ma_bpf_config pConfig, ma_bpf* pBPF);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf_process_pcm_frames(ma_bpf* pBPF, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_bpf_get_latency(in ma_bpf pBPF);

[StructLayout(LayoutKind.Sequential)]
public struct ma_notch2_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double q;
    public double frequency;
}
#if WEB
public static ma_notch2_config ma_notch2_config_init(ma_format format, uint channels, uint sampleRate, double q, double frequency)
{
    ma_notch2_config result = default;
    ma_notch2_config_init_internal(ref result, format, channels, sampleRate, q, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch2_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch2_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_notch2_config ma_notch2_config_init(ma_format format, uint channels, uint sampleRate, double q, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_notch2
{
    public ma_biquad bq;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_notch2_get_heap_size(in ma_notch2_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_notch2_init_preallocated(in ma_notch2_config pConfig, void* pHeap, ma_notch2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch2_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch2_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_notch2_init(in ma_notch2_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_notch2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch2_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch2_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_notch2_uninit(ma_notch2* pFilter, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch2_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch2_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_notch2_reinit(in ma_notch2_config pConfig, ma_notch2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_notch2_process_pcm_frames(ma_notch2* pFilter, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_notch2_get_latency(in ma_notch2 pFilter);

[StructLayout(LayoutKind.Sequential)]
public struct ma_peak2_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double gainDB;
    public double q;
    public double frequency;
}
#if WEB
public static ma_peak2_config ma_peak2_config_init(ma_format format, uint channels, uint sampleRate, double gainDB, double q, double frequency)
{
    ma_peak2_config result = default;
    ma_peak2_config_init_internal(ref result, format, channels, sampleRate, gainDB, q, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak2_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak2_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_peak2_config ma_peak2_config_init(ma_format format, uint channels, uint sampleRate, double gainDB, double q, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_peak2
{
    public ma_biquad bq;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_peak2_get_heap_size(in ma_peak2_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_peak2_init_preallocated(in ma_peak2_config pConfig, void* pHeap, ma_peak2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak2_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak2_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_peak2_init(in ma_peak2_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_peak2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak2_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak2_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_peak2_uninit(ma_peak2* pFilter, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak2_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak2_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_peak2_reinit(in ma_peak2_config pConfig, ma_peak2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_peak2_process_pcm_frames(ma_peak2* pFilter, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_peak2_get_latency(in ma_peak2 pFilter);

[StructLayout(LayoutKind.Sequential)]
public struct ma_loshelf2_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double gainDB;
    public double shelfSlope;
    public double frequency;
}
#if WEB
public static ma_loshelf2_config ma_loshelf2_config_init(ma_format format, uint channels, uint sampleRate, double gainDB, double shelfSlope, double frequency)
{
    ma_loshelf2_config result = default;
    ma_loshelf2_config_init_internal(ref result, format, channels, sampleRate, gainDB, shelfSlope, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_loshelf2_config ma_loshelf2_config_init(ma_format format, uint channels, uint sampleRate, double gainDB, double shelfSlope, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_loshelf2
{
    public ma_biquad bq;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_loshelf2_get_heap_size(in ma_loshelf2_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_loshelf2_init_preallocated(in ma_loshelf2_config pConfig, void* pHeap, ma_loshelf2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf2_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf2_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_loshelf2_init(in ma_loshelf2_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_loshelf2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_loshelf2_uninit(ma_loshelf2* pFilter, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_loshelf2_reinit(in ma_loshelf2_config pConfig, ma_loshelf2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_loshelf2_process_pcm_frames(ma_loshelf2* pFilter, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_loshelf2_get_latency(in ma_loshelf2 pFilter);

[StructLayout(LayoutKind.Sequential)]
public struct ma_hishelf2_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double gainDB;
    public double shelfSlope;
    public double frequency;
}
#if WEB
public static ma_hishelf2_config ma_hishelf2_config_init(ma_format format, uint channels, uint sampleRate, double gainDB, double shelfSlope, double frequency)
{
    ma_hishelf2_config result = default;
    ma_hishelf2_config_init_internal(ref result, format, channels, sampleRate, gainDB, shelfSlope, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf2_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_hishelf2_config ma_hishelf2_config_init(ma_format format, uint channels, uint sampleRate, double gainDB, double shelfSlope, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_hishelf2
{
    public ma_biquad bq;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf2_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hishelf2_get_heap_size(in ma_hishelf2_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf2_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hishelf2_init_preallocated(in ma_hishelf2_config pConfig, void* pHeap, ma_hishelf2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf2_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf2_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hishelf2_init(in ma_hishelf2_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_hishelf2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf2_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hishelf2_uninit(ma_hishelf2* pFilter, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf2_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hishelf2_reinit(in ma_hishelf2_config pConfig, ma_hishelf2* pFilter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf2_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hishelf2_process_pcm_frames(ma_hishelf2* pFilter, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf2_get_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_hishelf2_get_latency(in ma_hishelf2 pFilter);

[StructLayout(LayoutKind.Sequential)]
public struct ma_delay_config
{
    public uint channels;
    public uint sampleRate;
    public uint delayInFrames;
    public uint delayStart;
    public float wet;
    public float dry;
    public float decay;
}
#if WEB
public static ma_delay_config ma_delay_config_init(uint channels, uint sampleRate, uint delayInFrames, float decay)
{
    ma_delay_config result = default;
    ma_delay_config_init_internal(ref result, channels, sampleRate, delayInFrames, decay);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_delay_config ma_delay_config_init(uint channels, uint sampleRate, uint delayInFrames, float decay);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_delay
{
    public ma_delay_config config;
    public uint cursor;
    public uint bufferSizeInFrames;
    public float* pBuffer;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_delay_init(in ma_delay_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_delay* pDelay);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_uninit(ma_delay* pDelay, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_delay_process_pcm_frames(ma_delay* pDelay, void* pFramesOut, void* pFramesIn, uint frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_set_wet", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_set_wet", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_set_wet(ma_delay* pDelay, float value);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_get_wet", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_get_wet", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_delay_get_wet(in ma_delay pDelay);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_set_dry", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_set_dry", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_set_dry(ma_delay* pDelay, float value);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_get_dry", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_get_dry", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_delay_get_dry(in ma_delay pDelay);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_set_decay", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_set_decay", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_set_decay(ma_delay* pDelay, float value);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_get_decay", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_get_decay", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_delay_get_decay(in ma_delay pDelay);

[StructLayout(LayoutKind.Sequential)]
public struct ma_gainer_config
{
    public uint channels;
    public uint smoothTimeInFrames;
}
#if WEB
public static ma_gainer_config ma_gainer_config_init(uint channels, uint smoothTimeInFrames)
{
    ma_gainer_config result = default;
    ma_gainer_config_init_internal(ref result, channels, smoothTimeInFrames);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_gainer_config ma_gainer_config_init(uint channels, uint smoothTimeInFrames);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_gainer
{
    public ma_gainer_config config;
    public uint t;
    public float masterVolume;
    public float* pOldGains;
    public float* pNewGains;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_gainer_get_heap_size(in ma_gainer_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_gainer_init_preallocated(in ma_gainer_config pConfig, void* pHeap, ma_gainer* pGainer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_gainer_init(in ma_gainer_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_gainer* pGainer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_gainer_uninit(ma_gainer* pGainer, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_gainer_process_pcm_frames(ma_gainer* pGainer, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_set_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_set_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_gainer_set_gain(ma_gainer* pGainer, float newGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_set_gains", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_set_gains", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_gainer_set_gains(ma_gainer* pGainer, ref float pNewGains);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_set_master_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_set_master_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_gainer_set_master_volume(ma_gainer* pGainer, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_get_master_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_get_master_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_gainer_get_master_volume(in ma_gainer pGainer, ref float pVolume);

public enum ma_pan_mode
{
    ma_pan_mode_balance = 0,
    ma_pan_mode_pan,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_panner_config
{
    public ma_format format;
    public uint channels;
    public ma_pan_mode mode;
    public float pan;
}
#if WEB
public static ma_panner_config ma_panner_config_init(ma_format format, uint channels)
{
    ma_panner_config result = default;
    ma_panner_config_init_internal(ref result, format, channels);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_panner_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_panner_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_panner_config ma_panner_config_init(ma_format format, uint channels);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_panner
{
    public ma_format format;
    public uint channels;
    public ma_pan_mode mode;
    public float pan;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_panner_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_panner_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_panner_init(in ma_panner_config pConfig, ma_panner* pPanner);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_panner_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_panner_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_panner_process_pcm_frames(ma_panner* pPanner, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_panner_set_mode", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_panner_set_mode", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_panner_set_mode(ma_panner* pPanner, ma_pan_mode mode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_panner_get_mode", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_panner_get_mode", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_pan_mode ma_panner_get_mode(in ma_panner pPanner);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_panner_set_pan", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_panner_set_pan", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_panner_set_pan(ma_panner* pPanner, float pan);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_panner_get_pan", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_panner_get_pan", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_panner_get_pan(in ma_panner pPanner);

[StructLayout(LayoutKind.Sequential)]
public struct ma_fader_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
}
#if WEB
public static ma_fader_config ma_fader_config_init(ma_format format, uint channels, uint sampleRate)
{
    ma_fader_config result = default;
    ma_fader_config_init_internal(ref result, format, channels, sampleRate);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fader_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fader_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_fader_config ma_fader_config_init(ma_format format, uint channels, uint sampleRate);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_fader
{
    public ma_fader_config config;
    public float volumeBeg;
    public float volumeEnd;
    public ulong lengthInFrames;
    public long cursorInFrames;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fader_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fader_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_fader_init(in ma_fader_config pConfig, ma_fader* pFader);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fader_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fader_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_fader_process_pcm_frames(ma_fader* pFader, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fader_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fader_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_fader_get_data_format(in ma_fader pFader, ref ma_format pFormat, ref uint pChannels, ref uint pSampleRate);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fader_set_fade", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fader_set_fade", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_fader_set_fade(ma_fader* pFader, float volumeBeg, float volumeEnd, ulong lengthInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fader_set_fade_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fader_set_fade_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_fader_set_fade_ex(ma_fader* pFader, float volumeBeg, float volumeEnd, ulong lengthInFrames, long startOffsetInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fader_get_current_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fader_get_current_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_fader_get_current_volume(in ma_fader pFader);

[StructLayout(LayoutKind.Sequential)]
public struct ma_vec3f
{
    public float x;
    public float y;
    public float z;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_atomic_vec3f
{
    public ma_vec3f v;
    public uint dolock;
}
public enum ma_attenuation_model
{
    ma_attenuation_model_none,
    ma_attenuation_model_inverse,
    ma_attenuation_model_linear,
    ma_attenuation_model_exponential,
}
public enum ma_positioning
{
    ma_positioning_absolute,
    ma_positioning_relative,
}
public enum ma_handedness
{
    ma_handedness_right,
    ma_handedness_left,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_spatializer_listener_config
{
    public uint channelsOut;
    public byte* pChannelMapOut;
    public ma_handedness handedness;
    public float coneInnerAngleInRadians;
    public float coneOuterAngleInRadians;
    public float coneOuterGain;
    public float speedOfSound;
    public ma_vec3f worldUp;
}
#if WEB
public static ma_spatializer_listener_config ma_spatializer_listener_config_init(uint channelsOut)
{
    ma_spatializer_listener_config result = default;
    ma_spatializer_listener_config_init_internal(ref result, channelsOut);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_spatializer_listener_config ma_spatializer_listener_config_init(uint channelsOut);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_spatializer_listener
{
    public ma_spatializer_listener_config config;
    public ma_atomic_vec3f position;
    public ma_atomic_vec3f direction;
    public ma_atomic_vec3f velocity;
    public uint isEnabled;
    public uint _ownsHeap;
    public void* _pHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spatializer_listener_get_heap_size(in ma_spatializer_listener_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spatializer_listener_init_preallocated(in ma_spatializer_listener_config pConfig, void* pHeap, ma_spatializer_listener* pListener);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spatializer_listener_init(in ma_spatializer_listener_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_spatializer_listener* pListener);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_uninit(ma_spatializer_listener* pListener, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_channel_map", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_channel_map", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern byte* ma_spatializer_listener_get_channel_map(ma_spatializer_listener* pListener);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_set_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_set_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_set_cone(ma_spatializer_listener* pListener, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_get_cone(in ma_spatializer_listener pListener, ref float pInnerAngleInRadians, ref float pOuterAngleInRadians, ref float pOuterGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_set_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_set_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_set_position(ma_spatializer_listener* pListener, float x, float y, float z);

#if WEB
public static ma_vec3f ma_spatializer_listener_get_position(in ma_spatializer_listener pListener)
{
    ma_vec3f result = default;
    ma_spatializer_listener_get_position_internal(ref result, pListener);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_spatializer_listener_get_position(in ma_spatializer_listener pListener);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_set_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_set_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_set_direction(ma_spatializer_listener* pListener, float x, float y, float z);

#if WEB
public static ma_vec3f ma_spatializer_listener_get_direction(in ma_spatializer_listener pListener)
{
    ma_vec3f result = default;
    ma_spatializer_listener_get_direction_internal(ref result, pListener);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_spatializer_listener_get_direction(in ma_spatializer_listener pListener);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_set_velocity(ma_spatializer_listener* pListener, float x, float y, float z);

#if WEB
public static ma_vec3f ma_spatializer_listener_get_velocity(in ma_spatializer_listener pListener)
{
    ma_vec3f result = default;
    ma_spatializer_listener_get_velocity_internal(ref result, pListener);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_spatializer_listener_get_velocity(in ma_spatializer_listener pListener);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_set_speed_of_sound", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_set_speed_of_sound", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_set_speed_of_sound(ma_spatializer_listener* pListener, float speedOfSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_speed_of_sound", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_speed_of_sound", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_spatializer_listener_get_speed_of_sound(in ma_spatializer_listener pListener);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_set_world_up", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_set_world_up", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_set_world_up(ma_spatializer_listener* pListener, float x, float y, float z);

#if WEB
public static ma_vec3f ma_spatializer_listener_get_world_up(in ma_spatializer_listener pListener)
{
    ma_vec3f result = default;
    ma_spatializer_listener_get_world_up_internal(ref result, pListener);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_world_up", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_world_up", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_spatializer_listener_get_world_up(in ma_spatializer_listener pListener);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_set_enabled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_set_enabled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_set_enabled(ma_spatializer_listener* pListener, uint isEnabled);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_is_enabled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_is_enabled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_spatializer_listener_is_enabled(in ma_spatializer_listener pListener);

[StructLayout(LayoutKind.Sequential)]
public struct ma_spatializer_config
{
    public uint channelsIn;
    public uint channelsOut;
    public byte* pChannelMapIn;
    public ma_attenuation_model attenuationModel;
    public ma_positioning positioning;
    public ma_handedness handedness;
    public float minGain;
    public float maxGain;
    public float minDistance;
    public float maxDistance;
    public float rolloff;
    public float coneInnerAngleInRadians;
    public float coneOuterAngleInRadians;
    public float coneOuterGain;
    public float dopplerFactor;
    public float directionalAttenuationFactor;
    public float minSpatializationChannelGain;
    public uint gainSmoothTimeInFrames;
}
#if WEB
public static ma_spatializer_config ma_spatializer_config_init(uint channelsIn, uint channelsOut)
{
    ma_spatializer_config result = default;
    ma_spatializer_config_init_internal(ref result, channelsIn, channelsOut);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_spatializer_config ma_spatializer_config_init(uint channelsIn, uint channelsOut);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_spatializer
{
    public uint channelsIn;
    public uint channelsOut;
    public byte* pChannelMapIn;
    public ma_attenuation_model attenuationModel;
    public ma_positioning positioning;
    public ma_handedness handedness;
    public float minGain;
    public float maxGain;
    public float minDistance;
    public float maxDistance;
    public float rolloff;
    public float coneInnerAngleInRadians;
    public float coneOuterAngleInRadians;
    public float coneOuterGain;
    public float dopplerFactor;
    public float directionalAttenuationFactor;
    public uint gainSmoothTimeInFrames;
    public ma_atomic_vec3f position;
    public ma_atomic_vec3f direction;
    public ma_atomic_vec3f velocity;
    public float dopplerPitch;
    public float minSpatializationChannelGain;
    public ma_gainer gainer;
    public float* pNewChannelGainsOut;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spatializer_get_heap_size(in ma_spatializer_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spatializer_init_preallocated(in ma_spatializer_config pConfig, void* pHeap, ma_spatializer* pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spatializer_init(in ma_spatializer_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_spatializer* pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_uninit(ma_spatializer* pSpatializer, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spatializer_process_pcm_frames(ma_spatializer* pSpatializer, ma_spatializer_listener* pListener, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_master_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_master_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spatializer_set_master_volume(ma_spatializer* pSpatializer, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_master_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_master_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spatializer_get_master_volume(in ma_spatializer pSpatializer, ref float pVolume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_input_channels", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_input_channels", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_spatializer_get_input_channels(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_output_channels", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_output_channels", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_spatializer_get_output_channels(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_attenuation_model(ma_spatializer* pSpatializer, ma_attenuation_model attenuationModel);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_attenuation_model ma_spatializer_get_attenuation_model(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_positioning", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_positioning", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_positioning(ma_spatializer* pSpatializer, ma_positioning positioning);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_positioning", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_positioning", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_positioning ma_spatializer_get_positioning(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_rolloff", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_rolloff", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_rolloff(ma_spatializer* pSpatializer, float rolloff);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_rolloff", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_rolloff", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_spatializer_get_rolloff(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_min_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_min_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_min_gain(ma_spatializer* pSpatializer, float minGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_min_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_min_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_spatializer_get_min_gain(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_max_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_max_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_max_gain(ma_spatializer* pSpatializer, float maxGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_max_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_max_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_spatializer_get_max_gain(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_min_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_min_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_min_distance(ma_spatializer* pSpatializer, float minDistance);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_min_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_min_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_spatializer_get_min_distance(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_max_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_max_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_max_distance(ma_spatializer* pSpatializer, float maxDistance);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_max_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_max_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_spatializer_get_max_distance(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_cone(ma_spatializer* pSpatializer, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_get_cone(in ma_spatializer pSpatializer, ref float pInnerAngleInRadians, ref float pOuterAngleInRadians, ref float pOuterGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_doppler_factor(ma_spatializer* pSpatializer, float dopplerFactor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_spatializer_get_doppler_factor(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_directional_attenuation_factor(ma_spatializer* pSpatializer, float directionalAttenuationFactor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_spatializer_get_directional_attenuation_factor(in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_position(ma_spatializer* pSpatializer, float x, float y, float z);

#if WEB
public static ma_vec3f ma_spatializer_get_position(in ma_spatializer pSpatializer)
{
    ma_vec3f result = default;
    ma_spatializer_get_position_internal(ref result, pSpatializer);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_spatializer_get_position(in ma_spatializer pSpatializer);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_direction(ma_spatializer* pSpatializer, float x, float y, float z);

#if WEB
public static ma_vec3f ma_spatializer_get_direction(in ma_spatializer pSpatializer)
{
    ma_vec3f result = default;
    ma_spatializer_get_direction_internal(ref result, pSpatializer);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_spatializer_get_direction(in ma_spatializer pSpatializer);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_set_velocity(ma_spatializer* pSpatializer, float x, float y, float z);

#if WEB
public static ma_vec3f ma_spatializer_get_velocity(in ma_spatializer pSpatializer)
{
    ma_vec3f result = default;
    ma_spatializer_get_velocity_internal(ref result, pSpatializer);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_spatializer_get_velocity(in ma_spatializer pSpatializer);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_relative_position_and_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_relative_position_and_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_get_relative_position_and_direction(in ma_spatializer pSpatializer, in ma_spatializer_listener pListener, ma_vec3f* pRelativePos, ma_vec3f* pRelativeDir);

[StructLayout(LayoutKind.Sequential)]
public struct ma_linear_resampler_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRateIn;
    public uint sampleRateOut;
    public uint lpfOrder;
    public double lpfNyquistFactor;
}
#if WEB
public static ma_linear_resampler_config ma_linear_resampler_config_init(ma_format format, uint channels, uint sampleRateIn, uint sampleRateOut)
{
    ma_linear_resampler_config result = default;
    ma_linear_resampler_config_init_internal(ref result, format, channels, sampleRateIn, sampleRateOut);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_linear_resampler_config ma_linear_resampler_config_init(ma_format format, uint channels, uint sampleRateIn, uint sampleRateOut);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_linear_resampler
{
    public ma_linear_resampler_config config;
    public uint inAdvanceInt;
    public uint inAdvanceFrac;
    public uint inTimeInt;
    public uint inTimeFrac;
    public void* x0; // union { float* f32; ma_int16* s16; }
    public void* x1; // union { float* f32; ma_int16* s16; }
    public ma_lpf lpf;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_linear_resampler_get_heap_size(in ma_linear_resampler_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_linear_resampler_init_preallocated(in ma_linear_resampler_config pConfig, void* pHeap, ma_linear_resampler* pResampler);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_linear_resampler_init(in ma_linear_resampler_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_linear_resampler* pResampler);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_linear_resampler_uninit(ma_linear_resampler* pResampler, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_linear_resampler_process_pcm_frames(ma_linear_resampler* pResampler, void* pFramesIn, ref ulong pFrameCountIn, void* pFramesOut, ref ulong pFrameCountOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_set_rate", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_set_rate", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_linear_resampler_set_rate(ma_linear_resampler* pResampler, uint sampleRateIn, uint sampleRateOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_set_rate_ratio", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_set_rate_ratio", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_linear_resampler_set_rate_ratio(ma_linear_resampler* pResampler, float ratioInOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_get_input_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_get_input_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_linear_resampler_get_input_latency(in ma_linear_resampler pResampler);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_get_output_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_get_output_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_linear_resampler_get_output_latency(in ma_linear_resampler pResampler);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_get_required_input_frame_count", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_get_required_input_frame_count", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_linear_resampler_get_required_input_frame_count(in ma_linear_resampler pResampler, ulong outputFrameCount, ref ulong pInputFrameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_get_expected_output_frame_count", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_get_expected_output_frame_count", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_linear_resampler_get_expected_output_frame_count(in ma_linear_resampler pResampler, ulong inputFrameCount, ref ulong pOutputFrameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_reset", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_reset", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_linear_resampler_reset(ma_linear_resampler* pResampler);

[StructLayout(LayoutKind.Sequential)]
public struct ma_resampling_backend_vtable
{
    public delegate* unmanaged<void*, ma_resampler_config*, nuint*, void*> onGetHeapSize;
    public delegate* unmanaged<void*, ma_resampler_config*, void*, void*, void*> onInit;
    public delegate* unmanaged<void*, IntPtr, ma_allocation_callbacks*, void> onUninit;
    public delegate* unmanaged<void*, IntPtr, void*, ulong*, void*, ulong*, void*> onProcess;
    public delegate* unmanaged<void*, IntPtr, uint, uint, void*> onSetRate;
    public delegate* unmanaged<void*, IntPtr, void*> onGetInputLatency;
    public delegate* unmanaged<void*, IntPtr, void*> onGetOutputLatency;
    public delegate* unmanaged<void*, IntPtr, ulong, ulong*, void*> onGetRequiredInputFrameCount;
    public delegate* unmanaged<void*, IntPtr, ulong, ulong*, void*> onGetExpectedOutputFrameCount;
    public delegate* unmanaged<void*, IntPtr, void*> onReset;
}
public enum ma_resample_algorithm
{
    ma_resample_algorithm_linear = 0,
    ma_resample_algorithm_custom,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resampler_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRateIn;
    public uint sampleRateOut;
    public ma_resample_algorithm algorithm;
    public ma_resampling_backend_vtable* pBackendVTable;
    public void* pBackendUserData;
    public uint lpfOrder; /* linear.lpfOrder */
}
#if WEB
public static ma_resampler_config ma_resampler_config_init(ma_format format, uint channels, uint sampleRateIn, uint sampleRateOut, ma_resample_algorithm algorithm)
{
    ma_resampler_config result = default;
    ma_resampler_config_init_internal(ref result, format, channels, sampleRateIn, sampleRateOut, algorithm);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_resampler_config ma_resampler_config_init(ma_format format, uint channels, uint sampleRateIn, uint sampleRateOut, ma_resample_algorithm algorithm);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_resampler
{
    public IntPtr pBackend;
    public ma_resampling_backend_vtable* pBackendVTable;
    public void* pBackendUserData;
    public ma_format format;
    public uint channels;
    public uint sampleRateIn;
    public uint sampleRateOut;
    public ma_linear_resampler state; // union { ma_linear_resampler linear; }
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resampler_get_heap_size(in ma_resampler_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resampler_init_preallocated(in ma_resampler_config pConfig, void* pHeap, ma_resampler* pResampler);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resampler_init(in ma_resampler_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_resampler* pResampler);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_resampler_uninit(ma_resampler* pResampler, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resampler_process_pcm_frames(ma_resampler* pResampler, void* pFramesIn, ref ulong pFrameCountIn, void* pFramesOut, ref ulong pFrameCountOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_set_rate", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_set_rate", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resampler_set_rate(ma_resampler* pResampler, uint sampleRateIn, uint sampleRateOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_set_rate_ratio", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_set_rate_ratio", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resampler_set_rate_ratio(ma_resampler* pResampler, float ratio);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_get_input_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_get_input_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_resampler_get_input_latency(in ma_resampler pResampler);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_get_output_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_get_output_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_resampler_get_output_latency(in ma_resampler pResampler);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_get_required_input_frame_count", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_get_required_input_frame_count", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resampler_get_required_input_frame_count(in ma_resampler pResampler, ulong outputFrameCount, ref ulong pInputFrameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_get_expected_output_frame_count", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_get_expected_output_frame_count", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resampler_get_expected_output_frame_count(in ma_resampler pResampler, ulong inputFrameCount, ref ulong pOutputFrameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_reset", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_reset", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resampler_reset(ma_resampler* pResampler);

public enum ma_channel_conversion_path
{
    ma_channel_conversion_path_unknown,
    ma_channel_conversion_path_passthrough,
    ma_channel_conversion_path_mono_out,
    ma_channel_conversion_path_mono_in,
    ma_channel_conversion_path_shuffle,
    ma_channel_conversion_path_weights,
}
public enum ma_mono_expansion_mode
{
    ma_mono_expansion_mode_duplicate = 0,
    ma_mono_expansion_mode_average,
    ma_mono_expansion_mode_stereo_only,
    ma_mono_expansion_mode_default = 0,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_channel_converter_config
{
    public ma_format format;
    public uint channelsIn;
    public uint channelsOut;
    public byte* pChannelMapIn;
    public byte* pChannelMapOut;
    public ma_channel_mix_mode mixingMode;
    public uint calculateLFEFromSpatialChannels;
    public IntPtr ppWeights;
}
#if WEB
public static ma_channel_converter_config ma_channel_converter_config_init(ma_format format, uint channelsIn, in byte pChannelMapIn, uint channelsOut, in byte pChannelMapOut, ma_channel_mix_mode mixingMode)
{
    ma_channel_converter_config result = default;
    ma_channel_converter_config_init_internal(ref result, format, channelsIn, pChannelMapIn, channelsOut, pChannelMapOut, mixingMode);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_converter_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_converter_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_channel_converter_config ma_channel_converter_config_init(ma_format format, uint channelsIn, in byte pChannelMapIn, uint channelsOut, in byte pChannelMapOut, ma_channel_mix_mode mixingMode);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_channel_converter
{
    public ma_format format;
    public uint channelsIn;
    public uint channelsOut;
    public ma_channel_mix_mode mixingMode;
    public ma_channel_conversion_path conversionPath;
    public byte* pChannelMapIn;
    public byte* pChannelMapOut;
    public byte* pShuffleTable;
    public void* weights; // union { float** f32; ma_int32** s16; }
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_converter_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_converter_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_channel_converter_get_heap_size(in ma_channel_converter_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_converter_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_converter_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_channel_converter_init_preallocated(in ma_channel_converter_config pConfig, void* pHeap, ma_channel_converter* pConverter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_converter_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_converter_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_channel_converter_init(in ma_channel_converter_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_channel_converter* pConverter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_converter_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_converter_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_channel_converter_uninit(ma_channel_converter* pConverter, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_converter_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_converter_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_channel_converter_process_pcm_frames(ma_channel_converter* pConverter, void* pFramesOut, void* pFramesIn, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_converter_get_input_channel_map", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_converter_get_input_channel_map", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_channel_converter_get_input_channel_map(in ma_channel_converter pConverter, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_converter_get_output_channel_map", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_converter_get_output_channel_map", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_channel_converter_get_output_channel_map(in ma_channel_converter pConverter, ref byte pChannelMap, nuint channelMapCap);

[StructLayout(LayoutKind.Sequential)]
public struct ma_data_converter_config
{
    public ma_format formatIn;
    public ma_format formatOut;
    public uint channelsIn;
    public uint channelsOut;
    public uint sampleRateIn;
    public uint sampleRateOut;
    public byte* pChannelMapIn;
    public byte* pChannelMapOut;
    public ma_dither_mode ditherMode;
    public ma_channel_mix_mode channelMixMode;
    public uint calculateLFEFromSpatialChannels;
    public IntPtr ppChannelWeights;
    public uint allowDynamicSampleRate;
    public ma_resampler_config resampling;
}
#if WEB
public static ma_data_converter_config ma_data_converter_config_init_default()
{
    ma_data_converter_config result = default;
    ma_data_converter_config_init_default_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_config_init_default", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_config_init_default", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_data_converter_config ma_data_converter_config_init_default();
#endif

#if WEB
public static ma_data_converter_config ma_data_converter_config_init(ma_format formatIn, ma_format formatOut, uint channelsIn, uint channelsOut, uint sampleRateIn, uint sampleRateOut)
{
    ma_data_converter_config result = default;
    ma_data_converter_config_init_internal(ref result, formatIn, formatOut, channelsIn, channelsOut, sampleRateIn, sampleRateOut);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_data_converter_config ma_data_converter_config_init(ma_format formatIn, ma_format formatOut, uint channelsIn, uint channelsOut, uint sampleRateIn, uint sampleRateOut);
#endif

public enum ma_data_converter_execution_path
{
    ma_data_converter_execution_path_passthrough,
    ma_data_converter_execution_path_format_only,
    ma_data_converter_execution_path_channels_only,
    ma_data_converter_execution_path_resample_only,
    ma_data_converter_execution_path_resample_first,
    ma_data_converter_execution_path_channels_first,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_data_converter
{
    public ma_format formatIn;
    public ma_format formatOut;
    public uint channelsIn;
    public uint channelsOut;
    public uint sampleRateIn;
    public uint sampleRateOut;
    public ma_dither_mode ditherMode;
    public ma_data_converter_execution_path executionPath;
    public ma_channel_converter channelConverter;
    public ma_resampler resampler;
    public byte hasPreFormatConversion;
    public byte hasPostFormatConversion;
    public byte hasChannelConverter;
    public byte hasResampler;
    public byte isPassthrough;
    public byte _ownsHeap;
    public void* _pHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_get_heap_size(in ma_data_converter_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_init_preallocated(in ma_data_converter_config pConfig, void* pHeap, ma_data_converter* pConverter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_init(in ma_data_converter_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_data_converter* pConverter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_data_converter_uninit(ma_data_converter* pConverter, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_process_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_process_pcm_frames(ma_data_converter* pConverter, void* pFramesIn, ref ulong pFrameCountIn, void* pFramesOut, ref ulong pFrameCountOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_set_rate", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_set_rate", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_set_rate(ma_data_converter* pConverter, uint sampleRateIn, uint sampleRateOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_set_rate_ratio", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_set_rate_ratio", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_set_rate_ratio(ma_data_converter* pConverter, float ratioInOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_get_input_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_get_input_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_data_converter_get_input_latency(in ma_data_converter pConverter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_get_output_latency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_get_output_latency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_data_converter_get_output_latency(in ma_data_converter pConverter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_get_required_input_frame_count", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_get_required_input_frame_count", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_get_required_input_frame_count(in ma_data_converter pConverter, ulong outputFrameCount, ref ulong pInputFrameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_get_expected_output_frame_count", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_get_expected_output_frame_count", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_get_expected_output_frame_count(in ma_data_converter pConverter, ulong inputFrameCount, ref ulong pOutputFrameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_get_input_channel_map", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_get_input_channel_map", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_get_input_channel_map(in ma_data_converter pConverter, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_get_output_channel_map", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_get_output_channel_map", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_get_output_channel_map(in ma_data_converter pConverter, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_reset", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_reset", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_converter_reset(ma_data_converter* pConverter);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_u8_to_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_u8_to_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_u8_to_s16(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_u8_to_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_u8_to_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_u8_to_s24(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_u8_to_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_u8_to_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_u8_to_s32(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_u8_to_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_u8_to_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_u8_to_f32(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s16_to_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s16_to_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s16_to_u8(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s16_to_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s16_to_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s16_to_s24(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s16_to_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s16_to_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s16_to_s32(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s16_to_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s16_to_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s16_to_f32(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s24_to_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s24_to_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s24_to_u8(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s24_to_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s24_to_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s24_to_s16(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s24_to_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s24_to_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s24_to_s32(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s24_to_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s24_to_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s24_to_f32(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s32_to_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s32_to_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s32_to_u8(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s32_to_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s32_to_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s32_to_s16(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s32_to_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s32_to_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s32_to_s24(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_s32_to_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_s32_to_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_s32_to_f32(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_f32_to_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_f32_to_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_f32_to_u8(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_f32_to_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_f32_to_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_f32_to_s16(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_f32_to_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_f32_to_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_f32_to_s24(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_f32_to_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_f32_to_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_f32_to_s32(void* pOut, void* pIn, ulong count, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_convert", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_convert", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_convert(void* pOut, ma_format formatOut, void* pIn, ma_format formatIn, ulong sampleCount, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_convert_pcm_frames_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_convert_pcm_frames_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_convert_pcm_frames_format(void* pOut, ma_format formatOut, void* pIn, ma_format formatIn, ulong frameCount, uint channels, ma_dither_mode ditherMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_deinterleave_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_deinterleave_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_deinterleave_pcm_frames(ma_format format, uint channels, ulong frameCount, void* pInterleavedPCMFrames, IntPtr ppDeinterleavedPCMFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_interleave_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_interleave_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_interleave_pcm_frames(ma_format format, uint channels, ulong frameCount, void** ppDeinterleavedPCMFrames, void* pInterleavedPCMFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_get_channel", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_get_channel", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern byte ma_channel_map_get_channel(in byte pChannelMap, uint channelCount, uint channelIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_init_blank", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_init_blank", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_channel_map_init_blank(ref byte pChannelMap, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_init_standard", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_init_standard", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_channel_map_init_standard(ma_standard_channel_map standardChannelMap, ref byte pChannelMap, nuint channelMapCap, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_copy", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_copy", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_channel_map_copy(ref byte pOut, in byte pIn, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_copy_or_default", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_copy_or_default", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_channel_map_copy_or_default(ref byte pOut, nuint channelMapCapOut, in byte pIn, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_is_valid", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_is_valid", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_channel_map_is_valid(in byte pChannelMap, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_is_equal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_is_equal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_channel_map_is_equal(in byte pChannelMapA, in byte pChannelMapB, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_is_blank", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_is_blank", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_channel_map_is_blank(in byte pChannelMap, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_contains_channel_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_contains_channel_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_channel_map_contains_channel_position(uint channels, in byte pChannelMap, byte channelPosition);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_find_channel_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_find_channel_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_channel_map_find_channel_position(uint channels, in byte pChannelMap, byte channelPosition, ref uint pChannelIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_map_to_string", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_map_to_string", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern nuint ma_channel_map_to_string(in byte pChannelMap, uint channels, IntPtr pBufferOut, nuint bufferCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_position_to_string", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_position_to_string", CallingConvention = CallingConvention.Cdecl)]
#endif
private static extern IntPtr ma_channel_position_to_string_native(byte channel);

public static string ma_channel_position_to_string(byte channel)
{
    IntPtr ptr = ma_channel_position_to_string_native(channel);
    if (ptr == IntPtr.Zero)
        return "";

    // Manual UTF-8 to string conversion to avoid marshalling corruption
    try
    {
        return Marshal.PtrToStringUTF8(ptr) ?? "";
    }
    catch
    {
        // Fallback in case of any marshalling issues
        return "";
    }
}

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_convert_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_convert_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_convert_frames(void* pOut, ulong frameCountOut, ma_format formatOut, uint channelsOut, uint sampleRateOut, void* pIn, ulong frameCountIn, ma_format formatIn, uint channelsIn, uint sampleRateIn);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_convert_frames_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_convert_frames_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_convert_frames_ex(void* pOut, ulong frameCountOut, void* pIn, ulong frameCountIn, in ma_data_converter_config pConfig);

[StructLayout(LayoutKind.Sequential)]
public struct ma_data_source_vtable
{
    public delegate* unmanaged<IntPtr, void*, ulong, ulong*, void*> onRead;
    public delegate* unmanaged<IntPtr, ulong, void*> onSeek;
    public delegate* unmanaged<IntPtr, ma_format*, uint*, uint*, byte*, nuint, void*> onGetDataFormat;
    public delegate* unmanaged<IntPtr, ulong*, void*> onGetCursor;
    public delegate* unmanaged<IntPtr, ulong*, void*> onGetLength;
    public delegate* unmanaged<IntPtr, uint, void*> onSetLooping;
    public uint flags;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_data_source_config
{
    public ma_data_source_vtable* vtable;
}
#if WEB
public static ma_data_source_config ma_data_source_config_init()
{
    ma_data_source_config result = default;
    ma_data_source_config_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_data_source_config ma_data_source_config_init();
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_data_source_base
{
    public ma_data_source_vtable* vtable;
    public ulong rangeBegInFrames;
    public ulong rangeEndInFrames;
    public ulong loopBegInFrames;
    public ulong loopEndInFrames;
    public IntPtr pCurrent;
    public IntPtr pNext;
    public IntPtr onGetNext;
    public uint isLooping;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_init(in ma_data_source_config pConfig, IntPtr pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_data_source_uninit(IntPtr pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_read_pcm_frames(IntPtr pDataSource, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_seek_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_seek_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_seek_pcm_frames(IntPtr pDataSource, ulong frameCount, ref ulong pFramesSeeked);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_seek_to_pcm_frame(IntPtr pDataSource, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_seek_seconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_seek_seconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_seek_seconds(IntPtr pDataSource, float secondCount, ref float pSecondsSeeked);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_seek_to_second", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_seek_to_second", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_seek_to_second(IntPtr pDataSource, float seekPointInSeconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_get_data_format(IntPtr pDataSource, ref ma_format pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_get_cursor_in_pcm_frames(IntPtr pDataSource, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_get_length_in_pcm_frames(IntPtr pDataSource, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_cursor_in_seconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_cursor_in_seconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_get_cursor_in_seconds(IntPtr pDataSource, ref float pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_length_in_seconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_length_in_seconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_get_length_in_seconds(IntPtr pDataSource, ref float pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_set_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_set_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_set_looping(IntPtr pDataSource, uint isLooping);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_is_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_is_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_data_source_is_looping(IntPtr pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_set_range_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_set_range_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_set_range_in_pcm_frames(IntPtr pDataSource, ulong rangeBegInFrames, ulong rangeEndInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_range_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_range_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_data_source_get_range_in_pcm_frames(IntPtr pDataSource, ref ulong pRangeBegInFrames, ref ulong pRangeEndInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_set_loop_point_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_set_loop_point_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_set_loop_point_in_pcm_frames(IntPtr pDataSource, ulong loopBegInFrames, ulong loopEndInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_loop_point_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_loop_point_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_data_source_get_loop_point_in_pcm_frames(IntPtr pDataSource, ref ulong pLoopBegInFrames, ref ulong pLoopEndInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_set_current", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_set_current", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_set_current(IntPtr pDataSource, IntPtr pCurrentDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_current", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_current", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern IntPtr ma_data_source_get_current(IntPtr pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_set_next", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_set_next", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_set_next(IntPtr pDataSource, IntPtr pNextDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_next", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_next", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern IntPtr ma_data_source_get_next(IntPtr pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_set_next_callback", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_set_next_callback", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_set_next_callback(IntPtr pDataSource, IntPtr onGetNext);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_get_next_callback", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_get_next_callback", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern IntPtr ma_data_source_get_next_callback(IntPtr pDataSource);

[StructLayout(LayoutKind.Sequential)]
public struct ma_audio_buffer_ref
{
    public ma_data_source_base ds;
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public ulong cursor;
    public ulong sizeInFrames;
    public void* pData;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_ref_init(ma_format format, uint channels, void* pData, ulong sizeInFrames, ma_audio_buffer_ref* pAudioBufferRef);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_audio_buffer_ref_uninit(ma_audio_buffer_ref* pAudioBufferRef);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_set_data", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_set_data", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_ref_set_data(ma_audio_buffer_ref* pAudioBufferRef, void* pData, ulong sizeInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_audio_buffer_ref_read_pcm_frames(ma_audio_buffer_ref* pAudioBufferRef, void* pFramesOut, ulong frameCount, uint loop);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_ref_seek_to_pcm_frame(ma_audio_buffer_ref* pAudioBufferRef, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_map", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_map", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_ref_map(ma_audio_buffer_ref* pAudioBufferRef, IntPtr ppFramesOut, ref ulong pFrameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_unmap", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_unmap", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_ref_unmap(ma_audio_buffer_ref* pAudioBufferRef, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_at_end", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_at_end", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_audio_buffer_ref_at_end(in ma_audio_buffer_ref pAudioBufferRef);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_ref_get_cursor_in_pcm_frames(in ma_audio_buffer_ref pAudioBufferRef, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_ref_get_length_in_pcm_frames(in ma_audio_buffer_ref pAudioBufferRef, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_ref_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_ref_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_ref_get_available_frames(in ma_audio_buffer_ref pAudioBufferRef, ref ulong pAvailableFrames);

[StructLayout(LayoutKind.Sequential)]
public struct ma_audio_buffer_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public ulong sizeInFrames;
    public void* pData;
    public ma_allocation_callbacks allocationCallbacks;
}
#if WEB
public static ma_audio_buffer_config ma_audio_buffer_config_init(ma_format format, uint channels, ulong sizeInFrames, void* pData, in ma_allocation_callbacks pAllocationCallbacks)
{
    ma_audio_buffer_config result = default;
    ma_audio_buffer_config_init_internal(ref result, format, channels, sizeInFrames, pData, pAllocationCallbacks);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_audio_buffer_config ma_audio_buffer_config_init(ma_format format, uint channels, ulong sizeInFrames, void* pData, in ma_allocation_callbacks pAllocationCallbacks);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_audio_buffer
{
    public ma_audio_buffer_ref _ref;
    public ma_allocation_callbacks allocationCallbacks;
    public uint ownsData;
    #pragma warning disable 169
    public struct _pExtraDataCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 1)[index];
        private byte _item0;
    }
    #pragma warning restore 169
    public _pExtraDataCollection _pExtraData;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_init(in ma_audio_buffer_config pConfig, ma_audio_buffer* pAudioBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_init_copy", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_init_copy", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_init_copy(in ma_audio_buffer_config pConfig, ma_audio_buffer* pAudioBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_alloc_and_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_alloc_and_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_alloc_and_init(in ma_audio_buffer_config pConfig, out IntPtr ppAudioBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_audio_buffer_uninit(ma_audio_buffer* pAudioBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_uninit_and_free", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_uninit_and_free", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_audio_buffer_uninit_and_free(ma_audio_buffer* pAudioBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_audio_buffer_read_pcm_frames(ma_audio_buffer* pAudioBuffer, void* pFramesOut, ulong frameCount, uint loop);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_seek_to_pcm_frame(ma_audio_buffer* pAudioBuffer, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_map", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_map", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_map(ma_audio_buffer* pAudioBuffer, IntPtr ppFramesOut, ref ulong pFrameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_unmap", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_unmap", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_unmap(ma_audio_buffer* pAudioBuffer, ulong frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_at_end", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_at_end", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_audio_buffer_at_end(in ma_audio_buffer pAudioBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_get_cursor_in_pcm_frames(in ma_audio_buffer pAudioBuffer, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_get_length_in_pcm_frames(in ma_audio_buffer pAudioBuffer, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_audio_buffer_get_available_frames(in ma_audio_buffer pAudioBuffer, ref ulong pAvailableFrames);

[StructLayout(LayoutKind.Sequential)]
public struct ma_paged_audio_buffer_page
{
    public ma_paged_audio_buffer_page* pNext;
    public ulong sizeInFrames;
    #pragma warning disable 169
    public struct pAudioDataCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 1)[index];
        private byte _item0;
    }
    #pragma warning restore 169
    public pAudioDataCollection pAudioData;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_paged_audio_buffer_data
{
    public ma_format format;
    public uint channels;
    public ma_paged_audio_buffer_page head;
    public ma_paged_audio_buffer_page* pTail;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_data_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_data_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_data_init(ma_format format, uint channels, ma_paged_audio_buffer_data* pData);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_data_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_data_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_paged_audio_buffer_data_uninit(ma_paged_audio_buffer_data* pData, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_data_get_head", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_data_get_head", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_paged_audio_buffer_page* ma_paged_audio_buffer_data_get_head(ma_paged_audio_buffer_data* pData);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_data_get_tail", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_data_get_tail", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_paged_audio_buffer_page* ma_paged_audio_buffer_data_get_tail(ma_paged_audio_buffer_data* pData);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_data_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_data_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_data_get_length_in_pcm_frames(ma_paged_audio_buffer_data* pData, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_data_allocate_page", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_data_allocate_page", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_data_allocate_page(ma_paged_audio_buffer_data* pData, ulong pageSizeInFrames, void* pInitialData, in ma_allocation_callbacks pAllocationCallbacks, out IntPtr ppPage);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_data_free_page", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_data_free_page", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_data_free_page(ma_paged_audio_buffer_data* pData, ma_paged_audio_buffer_page* pPage, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_data_append_page", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_data_append_page", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_data_append_page(ma_paged_audio_buffer_data* pData, ma_paged_audio_buffer_page* pPage);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_data_allocate_and_append_page", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_data_allocate_and_append_page", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_data_allocate_and_append_page(ma_paged_audio_buffer_data* pData, uint pageSizeInFrames, void* pInitialData, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_paged_audio_buffer_config
{
    public ma_paged_audio_buffer_data* pData;
}
#if WEB
public static ma_paged_audio_buffer_config ma_paged_audio_buffer_config_init(ma_paged_audio_buffer_data* pData)
{
    ma_paged_audio_buffer_config result = default;
    ma_paged_audio_buffer_config_init_internal(ref result, pData);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_paged_audio_buffer_config ma_paged_audio_buffer_config_init(ma_paged_audio_buffer_data* pData);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_paged_audio_buffer
{
    public ma_data_source_base ds;
    public ma_paged_audio_buffer_data* pData;
    public ma_paged_audio_buffer_page* pCurrent;
    public ulong relativeCursor;
    public ulong absoluteCursor;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_init(in ma_paged_audio_buffer_config pConfig, ma_paged_audio_buffer* pPagedAudioBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_paged_audio_buffer_uninit(ma_paged_audio_buffer* pPagedAudioBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_read_pcm_frames(ma_paged_audio_buffer* pPagedAudioBuffer, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_seek_to_pcm_frame(ma_paged_audio_buffer* pPagedAudioBuffer, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_get_cursor_in_pcm_frames(ma_paged_audio_buffer* pPagedAudioBuffer, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_paged_audio_buffer_get_length_in_pcm_frames(ma_paged_audio_buffer* pPagedAudioBuffer, ref ulong pLength);

[StructLayout(LayoutKind.Sequential)]
public struct ma_rb
{
    public void* pBuffer;
    public uint subbufferSizeInBytes;
    public uint subbufferCount;
    public uint subbufferStrideInBytes;
    public uint encodedReadOffset;
    public uint encodedWriteOffset;
    public byte ownsBuffer;
    public byte clearOnWriteAcquire;
    public ma_allocation_callbacks allocationCallbacks;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_init_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_init_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_rb_init_ex(nuint subbufferSizeInBytes, nuint subbufferCount, nuint subbufferStrideInBytes, void* pOptionalPreallocatedBuffer, in ma_allocation_callbacks pAllocationCallbacks, ma_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_rb_init(nuint bufferSizeInBytes, void* pOptionalPreallocatedBuffer, in ma_allocation_callbacks pAllocationCallbacks, ma_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_rb_uninit(ma_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_reset", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_reset", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_rb_reset(ma_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_acquire_read", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_acquire_read", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_rb_acquire_read(ma_rb* pRB, ref nuint pSizeInBytes, IntPtr ppBufferOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_commit_read", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_commit_read", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_rb_commit_read(ma_rb* pRB, nuint sizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_acquire_write", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_acquire_write", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_rb_acquire_write(ma_rb* pRB, ref nuint pSizeInBytes, IntPtr ppBufferOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_commit_write", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_commit_write", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_rb_commit_write(ma_rb* pRB, nuint sizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_seek_read", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_seek_read", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_rb_seek_read(ma_rb* pRB, nuint offsetInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_seek_write", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_seek_write", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_rb_seek_write(ma_rb* pRB, nuint offsetInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_pointer_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_pointer_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern int ma_rb_pointer_distance(ma_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_available_read", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_available_read", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_rb_available_read(ma_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_available_write", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_available_write", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_rb_available_write(ma_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_get_subbuffer_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_get_subbuffer_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern nuint ma_rb_get_subbuffer_size(ma_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_get_subbuffer_stride", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_get_subbuffer_stride", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern nuint ma_rb_get_subbuffer_stride(ma_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_get_subbuffer_offset", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_get_subbuffer_offset", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern nuint ma_rb_get_subbuffer_offset(ma_rb* pRB, nuint subbufferIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_rb_get_subbuffer_ptr", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_rb_get_subbuffer_ptr", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void* ma_rb_get_subbuffer_ptr(ma_rb* pRB, nuint subbufferIndex, void* pBuffer);

[StructLayout(LayoutKind.Sequential)]
public struct ma_pcm_rb
{
    public ma_data_source_base ds;
    public ma_rb rb;
    public ma_format format;
    public uint channels;
    public uint sampleRate;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_init_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_init_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pcm_rb_init_ex(ma_format format, uint channels, uint subbufferSizeInFrames, uint subbufferCount, uint subbufferStrideInFrames, void* pOptionalPreallocatedBuffer, in ma_allocation_callbacks pAllocationCallbacks, ma_pcm_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pcm_rb_init(ma_format format, uint channels, uint bufferSizeInFrames, void* pOptionalPreallocatedBuffer, in ma_allocation_callbacks pAllocationCallbacks, ma_pcm_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_rb_uninit(ma_pcm_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_reset", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_reset", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_rb_reset(ma_pcm_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_acquire_read", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_acquire_read", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pcm_rb_acquire_read(ma_pcm_rb* pRB, ref uint pSizeInFrames, IntPtr ppBufferOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_commit_read", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_commit_read", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pcm_rb_commit_read(ma_pcm_rb* pRB, uint sizeInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_acquire_write", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_acquire_write", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pcm_rb_acquire_write(ma_pcm_rb* pRB, ref uint pSizeInFrames, IntPtr ppBufferOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_commit_write", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_commit_write", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pcm_rb_commit_write(ma_pcm_rb* pRB, uint sizeInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_seek_read", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_seek_read", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pcm_rb_seek_read(ma_pcm_rb* pRB, uint offsetInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_seek_write", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_seek_write", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pcm_rb_seek_write(ma_pcm_rb* pRB, uint offsetInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_pointer_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_pointer_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern int ma_pcm_rb_pointer_distance(ma_pcm_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_available_read", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_available_read", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_pcm_rb_available_read(ma_pcm_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_available_write", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_available_write", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_pcm_rb_available_write(ma_pcm_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_get_subbuffer_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_get_subbuffer_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_pcm_rb_get_subbuffer_size(ma_pcm_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_get_subbuffer_stride", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_get_subbuffer_stride", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_pcm_rb_get_subbuffer_stride(ma_pcm_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_get_subbuffer_offset", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_get_subbuffer_offset", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_pcm_rb_get_subbuffer_offset(ma_pcm_rb* pRB, uint subbufferIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_get_subbuffer_ptr", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_get_subbuffer_ptr", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void* ma_pcm_rb_get_subbuffer_ptr(ma_pcm_rb* pRB, uint subbufferIndex, void* pBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_get_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_get_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_format ma_pcm_rb_get_format(in ma_pcm_rb pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_get_channels", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_get_channels", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_pcm_rb_get_channels(in ma_pcm_rb pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_get_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_get_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_pcm_rb_get_sample_rate(in ma_pcm_rb pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pcm_rb_set_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pcm_rb_set_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pcm_rb_set_sample_rate(ma_pcm_rb* pRB, uint sampleRate);

[StructLayout(LayoutKind.Sequential)]
public struct ma_duplex_rb
{
    public ma_pcm_rb rb;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_duplex_rb_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_duplex_rb_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_duplex_rb_init(ma_format captureFormat, uint captureChannels, uint sampleRate, uint captureInternalSampleRate, uint captureInternalPeriodSizeInFrames, in ma_allocation_callbacks pAllocationCallbacks, ma_duplex_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_duplex_rb_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_duplex_rb_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_duplex_rb_uninit(ma_duplex_rb* pRB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_result_description", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_result_description", CallingConvention = CallingConvention.Cdecl)]
#endif
private static extern IntPtr ma_result_description_native(ma_result result);

public static string ma_result_description(ma_result result)
{
    IntPtr ptr = ma_result_description_native(result);
    if (ptr == IntPtr.Zero)
        return "";

    // Manual UTF-8 to string conversion to avoid marshalling corruption
    try
    {
        return Marshal.PtrToStringUTF8(ptr) ?? "";
    }
    catch
    {
        // Fallback in case of any marshalling issues
        return "";
    }
}

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_malloc", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_malloc", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void* ma_malloc(nuint sz, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_calloc", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_calloc", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void* ma_calloc(nuint sz, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_realloc", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_realloc", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void* ma_realloc(void* p, nuint sz, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_free", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_free", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_free(void* p, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_aligned_malloc", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_aligned_malloc", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void* ma_aligned_malloc(nuint sz, nuint alignment, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_aligned_free", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_aligned_free", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_aligned_free(void* p, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_get_format_name", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_get_format_name", CallingConvention = CallingConvention.Cdecl)]
#endif
private static extern IntPtr ma_get_format_name_native(ma_format format);

public static string ma_get_format_name(ma_format format)
{
    IntPtr ptr = ma_get_format_name_native(format);
    if (ptr == IntPtr.Zero)
        return "";

    // Manual UTF-8 to string conversion to avoid marshalling corruption
    try
    {
        return Marshal.PtrToStringUTF8(ptr) ?? "";
    }
    catch
    {
        // Fallback in case of any marshalling issues
        return "";
    }
}

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_blend_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_blend_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_blend_f32(ref float pOut, ref float pInA, ref float pInB, float factor, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_get_bytes_per_sample", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_get_bytes_per_sample", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_get_bytes_per_sample(ma_format format);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_log_level_to_string", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_log_level_to_string", CallingConvention = CallingConvention.Cdecl)]
#endif
private static extern IntPtr ma_log_level_to_string_native(uint logLevel);

public static string ma_log_level_to_string(uint logLevel)
{
    IntPtr ptr = ma_log_level_to_string_native(logLevel);
    if (ptr == IntPtr.Zero)
        return "";

    // Manual UTF-8 to string conversion to avoid marshalling corruption
    try
    {
        return Marshal.PtrToStringUTF8(ptr) ?? "";
    }
    catch
    {
        // Fallback in case of any marshalling issues
        return "";
    }
}

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spinlock_lock", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spinlock_lock", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spinlock_lock(uint* pSpinlock);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spinlock_lock_noyield", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spinlock_lock_noyield", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spinlock_lock_noyield(uint* pSpinlock);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spinlock_unlock", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spinlock_unlock", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_spinlock_unlock(uint* pSpinlock);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_mutex_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_mutex_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_mutex_init(ref IntPtr pMutex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_mutex_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_mutex_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_mutex_uninit(ref IntPtr pMutex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_mutex_lock", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_mutex_lock", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_mutex_lock(ref IntPtr pMutex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_mutex_unlock", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_mutex_unlock", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_mutex_unlock(ref IntPtr pMutex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_event_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_event_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_event_init(ma_event* pEvent);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_event_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_event_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_event_uninit(ma_event* pEvent);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_event_wait", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_event_wait", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_event_wait(ma_event* pEvent);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_event_signal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_event_signal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_event_signal(ma_event* pEvent);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_semaphore_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_semaphore_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_semaphore_init(int initialValue, ma_semaphore* pSemaphore);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_semaphore_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_semaphore_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_semaphore_uninit(ma_semaphore* pSemaphore);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_semaphore_wait", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_semaphore_wait", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_semaphore_wait(ma_semaphore* pSemaphore);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_semaphore_release", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_semaphore_release", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_semaphore_release(ma_semaphore* pSemaphore);

[StructLayout(LayoutKind.Sequential)]
public struct ma_fence
{
    public IntPtr e;
    public uint counter;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fence_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fence_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_fence_init(ma_fence* pFence);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fence_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fence_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_fence_uninit(ma_fence* pFence);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fence_acquire", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fence_acquire", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_fence_acquire(ma_fence* pFence);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fence_release", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fence_release", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_fence_release(ma_fence* pFence);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fence_wait", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fence_wait", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_fence_wait(ma_fence* pFence);

[StructLayout(LayoutKind.Sequential)]
public struct ma_async_notification_callbacks
{
    public delegate* unmanaged<IntPtr, void> onSignal;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_async_notification_signal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_async_notification_signal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_async_notification_signal(IntPtr pNotification);

[StructLayout(LayoutKind.Sequential)]
public struct ma_async_notification_poll
{
    public ma_async_notification_callbacks cb;
    public uint signalled;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_async_notification_poll_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_async_notification_poll_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_async_notification_poll_init(ma_async_notification_poll* pNotificationPoll);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_async_notification_poll_is_signalled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_async_notification_poll_is_signalled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_async_notification_poll_is_signalled(in ma_async_notification_poll pNotificationPoll);

[StructLayout(LayoutKind.Sequential)]
public struct ma_async_notification_event
{
    public ma_async_notification_callbacks cb;
    public IntPtr e;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_async_notification_event_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_async_notification_event_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_async_notification_event_init(ma_async_notification_event* pNotificationEvent);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_async_notification_event_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_async_notification_event_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_async_notification_event_uninit(ma_async_notification_event* pNotificationEvent);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_async_notification_event_wait", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_async_notification_event_wait", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_async_notification_event_wait(ma_async_notification_event* pNotificationEvent);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_async_notification_event_signal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_async_notification_event_signal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_async_notification_event_signal(ma_async_notification_event* pNotificationEvent);

[StructLayout(LayoutKind.Sequential)]
public struct ma_slot_allocator_config
{
    public uint capacity;
}
#if WEB
public static ma_slot_allocator_config ma_slot_allocator_config_init(uint capacity)
{
    ma_slot_allocator_config result = default;
    ma_slot_allocator_config_init_internal(ref result, capacity);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_slot_allocator_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_slot_allocator_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_slot_allocator_config ma_slot_allocator_config_init(uint capacity);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_slot_allocator_group
{
    public uint bitfield;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_slot_allocator
{
    public ma_slot_allocator_group* pGroups;
    public uint* pSlots;
    public uint count;
    public uint capacity;
    public uint _ownsHeap;
    public void* _pHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_slot_allocator_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_slot_allocator_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_slot_allocator_get_heap_size(in ma_slot_allocator_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_slot_allocator_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_slot_allocator_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_slot_allocator_init_preallocated(in ma_slot_allocator_config pConfig, void* pHeap, ma_slot_allocator* pAllocator);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_slot_allocator_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_slot_allocator_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_slot_allocator_init(in ma_slot_allocator_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_slot_allocator* pAllocator);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_slot_allocator_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_slot_allocator_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_slot_allocator_uninit(ma_slot_allocator* pAllocator, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_slot_allocator_alloc", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_slot_allocator_alloc", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_slot_allocator_alloc(ma_slot_allocator* pAllocator, ref ulong pSlot);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_slot_allocator_free", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_slot_allocator_free", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_slot_allocator_free(ma_slot_allocator* pAllocator, ulong slot);

public enum ma_job_type
{
    MA_JOB_TYPE_QUIT = 0,
    MA_JOB_TYPE_CUSTOM,
    MA_JOB_TYPE_RESOURCE_MANAGER_LOAD_DATA_BUFFER_NODE,
    MA_JOB_TYPE_RESOURCE_MANAGER_FREE_DATA_BUFFER_NODE,
    MA_JOB_TYPE_RESOURCE_MANAGER_PAGE_DATA_BUFFER_NODE,
    MA_JOB_TYPE_RESOURCE_MANAGER_LOAD_DATA_BUFFER,
    MA_JOB_TYPE_RESOURCE_MANAGER_FREE_DATA_BUFFER,
    MA_JOB_TYPE_RESOURCE_MANAGER_LOAD_DATA_STREAM,
    MA_JOB_TYPE_RESOURCE_MANAGER_FREE_DATA_STREAM,
    MA_JOB_TYPE_RESOURCE_MANAGER_PAGE_DATA_STREAM,
    MA_JOB_TYPE_RESOURCE_MANAGER_SEEK_DATA_STREAM,
    MA_JOB_TYPE_DEVICE_AAUDIO_REROUTE,
    MA_JOB_TYPE_COUNT,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_job
{
    public ulong next;
    public uint order;
}
#if WEB
public static ma_job ma_job_init(ushort code)
{
    ma_job result = default;
    ma_job_init_internal(ref result, code);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_job ma_job_init(ushort code);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_process", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_process", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_job_process(ma_job* pJob);

public enum ma_job_queue_flags
{
    MA_JOB_QUEUE_FLAG_NON_BLOCKING = 1,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_job_queue_config
{
    public uint flags;
    public uint capacity;
}
#if WEB
public static ma_job_queue_config ma_job_queue_config_init(uint flags, uint capacity)
{
    ma_job_queue_config result = default;
    ma_job_queue_config_init_internal(ref result, flags, capacity);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_queue_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_queue_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_job_queue_config ma_job_queue_config_init(uint flags, uint capacity);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_job_queue
{
    public uint flags;
    public uint capacity;
    public ulong head;
    public ulong tail;
    public IntPtr sem;
    public ma_slot_allocator allocator;
    public ma_job* pJobs;
    public uint dolock;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_queue_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_queue_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_job_queue_get_heap_size(in ma_job_queue_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_queue_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_queue_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_job_queue_init_preallocated(in ma_job_queue_config pConfig, void* pHeap, ma_job_queue* pQueue);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_queue_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_queue_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_job_queue_init(in ma_job_queue_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_job_queue* pQueue);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_queue_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_queue_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_job_queue_uninit(ma_job_queue* pQueue, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_queue_post", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_queue_post", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_job_queue_post(ma_job_queue* pQueue, in ma_job pJob);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_queue_next", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_queue_next", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_job_queue_next(ma_job_queue* pQueue, ma_job* pJob);

public enum ma_device_state
{
    ma_device_state_uninitialized = 0,
    ma_device_state_stopped = 1,
    ma_device_state_started = 2,
    ma_device_state_starting = 3,
    ma_device_state_stopping = 4,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_atomic_device_state
{
    public ma_device_state value;
}
public enum ma_backend
{
    ma_backend_wasapi,
    ma_backend_dsound,
    ma_backend_winmm,
    ma_backend_coreaudio,
    ma_backend_sndio,
    ma_backend_audio4,
    ma_backend_oss,
    ma_backend_pulseaudio,
    ma_backend_alsa,
    ma_backend_jack,
    ma_backend_aaudio,
    ma_backend_opensl,
    ma_backend_webaudio,
    ma_backend_custom,
    ma_backend_null,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_device_job_thread_config
{
    public uint noThread;
    public uint jobQueueCapacity;
    public uint jobQueueFlags;
}
#if WEB
public static ma_device_job_thread_config ma_device_job_thread_config_init()
{
    ma_device_job_thread_config result = default;
    ma_device_job_thread_config_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_job_thread_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_job_thread_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_device_job_thread_config ma_device_job_thread_config_init();
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_device_job_thread
{
    public IntPtr thread;
    public ma_job_queue jobQueue;
    public uint _hasThread;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_job_thread_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_job_thread_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_job_thread_init(in ma_device_job_thread_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_device_job_thread* pJobThread);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_job_thread_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_job_thread_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_device_job_thread_uninit(ma_device_job_thread* pJobThread, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_job_thread_post", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_job_thread_post", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_job_thread_post(ma_device_job_thread* pJobThread, in ma_job pJob);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_job_thread_next", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_job_thread_next", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_job_thread_next(ma_device_job_thread* pJobThread, ma_job* pJob);

public enum ma_device_notification_type
{
    ma_device_notification_type_started,
    ma_device_notification_type_stopped,
    ma_device_notification_type_rerouted,
    ma_device_notification_type_interruption_began,
    ma_device_notification_type_interruption_ended,
    ma_device_notification_type_unlocked,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_device_notification
{
    public ma_device* pDevice;
    public ma_device_notification_type type;
}
public enum ma_device_type
{
    ma_device_type_playback = 1,
    ma_device_type_capture = 2,
    ma_device_type_duplex = 3,
    ma_device_type_loopback = 4,
}
public enum ma_share_mode
{
    ma_share_mode_shared = 0,
    ma_share_mode_exclusive,
}
public enum ma_ios_session_category
{
    ma_ios_session_category_default = 0,
    ma_ios_session_category_none,
    ma_ios_session_category_ambient,
    ma_ios_session_category_solo_ambient,
    ma_ios_session_category_playback,
    ma_ios_session_category_record,
    ma_ios_session_category_play_and_record,
    ma_ios_session_category_multi_route,
}
public enum ma_ios_session_category_option
{
    ma_ios_session_category_option_mix_with_others = 1,
    ma_ios_session_category_option_duck_others = 2,
    ma_ios_session_category_option_allow_bluetooth = 4,
    ma_ios_session_category_option_default_to_speaker = 8,
    ma_ios_session_category_option_interrupt_spoken_audio_and_mix_with_others = 17,
    ma_ios_session_category_option_allow_bluetooth_a2dp = 32,
    ma_ios_session_category_option_allow_air_play = 64,
}
public enum ma_opensl_stream_type
{
    ma_opensl_stream_type_default = 0,
    ma_opensl_stream_type_voice,
    ma_opensl_stream_type_system,
    ma_opensl_stream_type_ring,
    ma_opensl_stream_type_media,
    ma_opensl_stream_type_alarm,
    ma_opensl_stream_type_notification,
}
public enum ma_opensl_recording_preset
{
    ma_opensl_recording_preset_default = 0,
    ma_opensl_recording_preset_generic,
    ma_opensl_recording_preset_camcorder,
    ma_opensl_recording_preset_voice_recognition,
    ma_opensl_recording_preset_voice_communication,
    ma_opensl_recording_preset_voice_unprocessed,
}
public enum ma_wasapi_usage
{
    ma_wasapi_usage_default = 0,
    ma_wasapi_usage_games,
    ma_wasapi_usage_pro_audio,
}
public enum ma_aaudio_usage
{
    ma_aaudio_usage_default = 0,
    ma_aaudio_usage_media,
    ma_aaudio_usage_voice_communication,
    ma_aaudio_usage_voice_communication_signalling,
    ma_aaudio_usage_alarm,
    ma_aaudio_usage_notification,
    ma_aaudio_usage_notification_ringtone,
    ma_aaudio_usage_notification_event,
    ma_aaudio_usage_assistance_accessibility,
    ma_aaudio_usage_assistance_navigation_guidance,
    ma_aaudio_usage_assistance_sonification,
    ma_aaudio_usage_game,
    ma_aaudio_usage_assitant,
    ma_aaudio_usage_emergency,
    ma_aaudio_usage_safety,
    ma_aaudio_usage_vehicle_status,
    ma_aaudio_usage_announcement,
}
public enum ma_aaudio_content_type
{
    ma_aaudio_content_type_default = 0,
    ma_aaudio_content_type_speech,
    ma_aaudio_content_type_music,
    ma_aaudio_content_type_movie,
    ma_aaudio_content_type_sonification,
}
public enum ma_aaudio_input_preset
{
    ma_aaudio_input_preset_default = 0,
    ma_aaudio_input_preset_generic,
    ma_aaudio_input_preset_camcorder,
    ma_aaudio_input_preset_voice_recognition,
    ma_aaudio_input_preset_voice_communication,
    ma_aaudio_input_preset_unprocessed,
    ma_aaudio_input_preset_voice_performance,
}
public enum ma_aaudio_allowed_capture_policy
{
    ma_aaudio_allow_capture_default = 0,
    ma_aaudio_allow_capture_by_all,
    ma_aaudio_allow_capture_by_system,
    ma_aaudio_allow_capture_by_none,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_timer
{
    public long counter;
    public double counterD;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_device_id
{
    #pragma warning disable 169
    public struct wasapiCollection
    {
        public ref ushort this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 64)[index];
        private ushort _item0;
        private ushort _item1;
        private ushort _item2;
        private ushort _item3;
        private ushort _item4;
        private ushort _item5;
        private ushort _item6;
        private ushort _item7;
        private ushort _item8;
        private ushort _item9;
        private ushort _item10;
        private ushort _item11;
        private ushort _item12;
        private ushort _item13;
        private ushort _item14;
        private ushort _item15;
        private ushort _item16;
        private ushort _item17;
        private ushort _item18;
        private ushort _item19;
        private ushort _item20;
        private ushort _item21;
        private ushort _item22;
        private ushort _item23;
        private ushort _item24;
        private ushort _item25;
        private ushort _item26;
        private ushort _item27;
        private ushort _item28;
        private ushort _item29;
        private ushort _item30;
        private ushort _item31;
        private ushort _item32;
        private ushort _item33;
        private ushort _item34;
        private ushort _item35;
        private ushort _item36;
        private ushort _item37;
        private ushort _item38;
        private ushort _item39;
        private ushort _item40;
        private ushort _item41;
        private ushort _item42;
        private ushort _item43;
        private ushort _item44;
        private ushort _item45;
        private ushort _item46;
        private ushort _item47;
        private ushort _item48;
        private ushort _item49;
        private ushort _item50;
        private ushort _item51;
        private ushort _item52;
        private ushort _item53;
        private ushort _item54;
        private ushort _item55;
        private ushort _item56;
        private ushort _item57;
        private ushort _item58;
        private ushort _item59;
        private ushort _item60;
        private ushort _item61;
        private ushort _item62;
        private ushort _item63;
    }
    #pragma warning restore 169
    public wasapiCollection wasapi;
    #pragma warning disable 169
    public struct dsoundCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 16)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
    }
    #pragma warning restore 169
    public dsoundCollection dsound;
    public uint winmm;
    #pragma warning disable 169
    public struct alsaCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 256)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
        private byte _item16;
        private byte _item17;
        private byte _item18;
        private byte _item19;
        private byte _item20;
        private byte _item21;
        private byte _item22;
        private byte _item23;
        private byte _item24;
        private byte _item25;
        private byte _item26;
        private byte _item27;
        private byte _item28;
        private byte _item29;
        private byte _item30;
        private byte _item31;
        private byte _item32;
        private byte _item33;
        private byte _item34;
        private byte _item35;
        private byte _item36;
        private byte _item37;
        private byte _item38;
        private byte _item39;
        private byte _item40;
        private byte _item41;
        private byte _item42;
        private byte _item43;
        private byte _item44;
        private byte _item45;
        private byte _item46;
        private byte _item47;
        private byte _item48;
        private byte _item49;
        private byte _item50;
        private byte _item51;
        private byte _item52;
        private byte _item53;
        private byte _item54;
        private byte _item55;
        private byte _item56;
        private byte _item57;
        private byte _item58;
        private byte _item59;
        private byte _item60;
        private byte _item61;
        private byte _item62;
        private byte _item63;
        private byte _item64;
        private byte _item65;
        private byte _item66;
        private byte _item67;
        private byte _item68;
        private byte _item69;
        private byte _item70;
        private byte _item71;
        private byte _item72;
        private byte _item73;
        private byte _item74;
        private byte _item75;
        private byte _item76;
        private byte _item77;
        private byte _item78;
        private byte _item79;
        private byte _item80;
        private byte _item81;
        private byte _item82;
        private byte _item83;
        private byte _item84;
        private byte _item85;
        private byte _item86;
        private byte _item87;
        private byte _item88;
        private byte _item89;
        private byte _item90;
        private byte _item91;
        private byte _item92;
        private byte _item93;
        private byte _item94;
        private byte _item95;
        private byte _item96;
        private byte _item97;
        private byte _item98;
        private byte _item99;
        private byte _item100;
        private byte _item101;
        private byte _item102;
        private byte _item103;
        private byte _item104;
        private byte _item105;
        private byte _item106;
        private byte _item107;
        private byte _item108;
        private byte _item109;
        private byte _item110;
        private byte _item111;
        private byte _item112;
        private byte _item113;
        private byte _item114;
        private byte _item115;
        private byte _item116;
        private byte _item117;
        private byte _item118;
        private byte _item119;
        private byte _item120;
        private byte _item121;
        private byte _item122;
        private byte _item123;
        private byte _item124;
        private byte _item125;
        private byte _item126;
        private byte _item127;
        private byte _item128;
        private byte _item129;
        private byte _item130;
        private byte _item131;
        private byte _item132;
        private byte _item133;
        private byte _item134;
        private byte _item135;
        private byte _item136;
        private byte _item137;
        private byte _item138;
        private byte _item139;
        private byte _item140;
        private byte _item141;
        private byte _item142;
        private byte _item143;
        private byte _item144;
        private byte _item145;
        private byte _item146;
        private byte _item147;
        private byte _item148;
        private byte _item149;
        private byte _item150;
        private byte _item151;
        private byte _item152;
        private byte _item153;
        private byte _item154;
        private byte _item155;
        private byte _item156;
        private byte _item157;
        private byte _item158;
        private byte _item159;
        private byte _item160;
        private byte _item161;
        private byte _item162;
        private byte _item163;
        private byte _item164;
        private byte _item165;
        private byte _item166;
        private byte _item167;
        private byte _item168;
        private byte _item169;
        private byte _item170;
        private byte _item171;
        private byte _item172;
        private byte _item173;
        private byte _item174;
        private byte _item175;
        private byte _item176;
        private byte _item177;
        private byte _item178;
        private byte _item179;
        private byte _item180;
        private byte _item181;
        private byte _item182;
        private byte _item183;
        private byte _item184;
        private byte _item185;
        private byte _item186;
        private byte _item187;
        private byte _item188;
        private byte _item189;
        private byte _item190;
        private byte _item191;
        private byte _item192;
        private byte _item193;
        private byte _item194;
        private byte _item195;
        private byte _item196;
        private byte _item197;
        private byte _item198;
        private byte _item199;
        private byte _item200;
        private byte _item201;
        private byte _item202;
        private byte _item203;
        private byte _item204;
        private byte _item205;
        private byte _item206;
        private byte _item207;
        private byte _item208;
        private byte _item209;
        private byte _item210;
        private byte _item211;
        private byte _item212;
        private byte _item213;
        private byte _item214;
        private byte _item215;
        private byte _item216;
        private byte _item217;
        private byte _item218;
        private byte _item219;
        private byte _item220;
        private byte _item221;
        private byte _item222;
        private byte _item223;
        private byte _item224;
        private byte _item225;
        private byte _item226;
        private byte _item227;
        private byte _item228;
        private byte _item229;
        private byte _item230;
        private byte _item231;
        private byte _item232;
        private byte _item233;
        private byte _item234;
        private byte _item235;
        private byte _item236;
        private byte _item237;
        private byte _item238;
        private byte _item239;
        private byte _item240;
        private byte _item241;
        private byte _item242;
        private byte _item243;
        private byte _item244;
        private byte _item245;
        private byte _item246;
        private byte _item247;
        private byte _item248;
        private byte _item249;
        private byte _item250;
        private byte _item251;
        private byte _item252;
        private byte _item253;
        private byte _item254;
        private byte _item255;
    }
    #pragma warning restore 169
    public alsaCollection alsa;
    #pragma warning disable 169
    public struct pulseCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 256)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
        private byte _item16;
        private byte _item17;
        private byte _item18;
        private byte _item19;
        private byte _item20;
        private byte _item21;
        private byte _item22;
        private byte _item23;
        private byte _item24;
        private byte _item25;
        private byte _item26;
        private byte _item27;
        private byte _item28;
        private byte _item29;
        private byte _item30;
        private byte _item31;
        private byte _item32;
        private byte _item33;
        private byte _item34;
        private byte _item35;
        private byte _item36;
        private byte _item37;
        private byte _item38;
        private byte _item39;
        private byte _item40;
        private byte _item41;
        private byte _item42;
        private byte _item43;
        private byte _item44;
        private byte _item45;
        private byte _item46;
        private byte _item47;
        private byte _item48;
        private byte _item49;
        private byte _item50;
        private byte _item51;
        private byte _item52;
        private byte _item53;
        private byte _item54;
        private byte _item55;
        private byte _item56;
        private byte _item57;
        private byte _item58;
        private byte _item59;
        private byte _item60;
        private byte _item61;
        private byte _item62;
        private byte _item63;
        private byte _item64;
        private byte _item65;
        private byte _item66;
        private byte _item67;
        private byte _item68;
        private byte _item69;
        private byte _item70;
        private byte _item71;
        private byte _item72;
        private byte _item73;
        private byte _item74;
        private byte _item75;
        private byte _item76;
        private byte _item77;
        private byte _item78;
        private byte _item79;
        private byte _item80;
        private byte _item81;
        private byte _item82;
        private byte _item83;
        private byte _item84;
        private byte _item85;
        private byte _item86;
        private byte _item87;
        private byte _item88;
        private byte _item89;
        private byte _item90;
        private byte _item91;
        private byte _item92;
        private byte _item93;
        private byte _item94;
        private byte _item95;
        private byte _item96;
        private byte _item97;
        private byte _item98;
        private byte _item99;
        private byte _item100;
        private byte _item101;
        private byte _item102;
        private byte _item103;
        private byte _item104;
        private byte _item105;
        private byte _item106;
        private byte _item107;
        private byte _item108;
        private byte _item109;
        private byte _item110;
        private byte _item111;
        private byte _item112;
        private byte _item113;
        private byte _item114;
        private byte _item115;
        private byte _item116;
        private byte _item117;
        private byte _item118;
        private byte _item119;
        private byte _item120;
        private byte _item121;
        private byte _item122;
        private byte _item123;
        private byte _item124;
        private byte _item125;
        private byte _item126;
        private byte _item127;
        private byte _item128;
        private byte _item129;
        private byte _item130;
        private byte _item131;
        private byte _item132;
        private byte _item133;
        private byte _item134;
        private byte _item135;
        private byte _item136;
        private byte _item137;
        private byte _item138;
        private byte _item139;
        private byte _item140;
        private byte _item141;
        private byte _item142;
        private byte _item143;
        private byte _item144;
        private byte _item145;
        private byte _item146;
        private byte _item147;
        private byte _item148;
        private byte _item149;
        private byte _item150;
        private byte _item151;
        private byte _item152;
        private byte _item153;
        private byte _item154;
        private byte _item155;
        private byte _item156;
        private byte _item157;
        private byte _item158;
        private byte _item159;
        private byte _item160;
        private byte _item161;
        private byte _item162;
        private byte _item163;
        private byte _item164;
        private byte _item165;
        private byte _item166;
        private byte _item167;
        private byte _item168;
        private byte _item169;
        private byte _item170;
        private byte _item171;
        private byte _item172;
        private byte _item173;
        private byte _item174;
        private byte _item175;
        private byte _item176;
        private byte _item177;
        private byte _item178;
        private byte _item179;
        private byte _item180;
        private byte _item181;
        private byte _item182;
        private byte _item183;
        private byte _item184;
        private byte _item185;
        private byte _item186;
        private byte _item187;
        private byte _item188;
        private byte _item189;
        private byte _item190;
        private byte _item191;
        private byte _item192;
        private byte _item193;
        private byte _item194;
        private byte _item195;
        private byte _item196;
        private byte _item197;
        private byte _item198;
        private byte _item199;
        private byte _item200;
        private byte _item201;
        private byte _item202;
        private byte _item203;
        private byte _item204;
        private byte _item205;
        private byte _item206;
        private byte _item207;
        private byte _item208;
        private byte _item209;
        private byte _item210;
        private byte _item211;
        private byte _item212;
        private byte _item213;
        private byte _item214;
        private byte _item215;
        private byte _item216;
        private byte _item217;
        private byte _item218;
        private byte _item219;
        private byte _item220;
        private byte _item221;
        private byte _item222;
        private byte _item223;
        private byte _item224;
        private byte _item225;
        private byte _item226;
        private byte _item227;
        private byte _item228;
        private byte _item229;
        private byte _item230;
        private byte _item231;
        private byte _item232;
        private byte _item233;
        private byte _item234;
        private byte _item235;
        private byte _item236;
        private byte _item237;
        private byte _item238;
        private byte _item239;
        private byte _item240;
        private byte _item241;
        private byte _item242;
        private byte _item243;
        private byte _item244;
        private byte _item245;
        private byte _item246;
        private byte _item247;
        private byte _item248;
        private byte _item249;
        private byte _item250;
        private byte _item251;
        private byte _item252;
        private byte _item253;
        private byte _item254;
        private byte _item255;
    }
    #pragma warning restore 169
    public pulseCollection pulse;
    public int jack;
    #pragma warning disable 169
    public struct coreaudioCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 256)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
        private byte _item16;
        private byte _item17;
        private byte _item18;
        private byte _item19;
        private byte _item20;
        private byte _item21;
        private byte _item22;
        private byte _item23;
        private byte _item24;
        private byte _item25;
        private byte _item26;
        private byte _item27;
        private byte _item28;
        private byte _item29;
        private byte _item30;
        private byte _item31;
        private byte _item32;
        private byte _item33;
        private byte _item34;
        private byte _item35;
        private byte _item36;
        private byte _item37;
        private byte _item38;
        private byte _item39;
        private byte _item40;
        private byte _item41;
        private byte _item42;
        private byte _item43;
        private byte _item44;
        private byte _item45;
        private byte _item46;
        private byte _item47;
        private byte _item48;
        private byte _item49;
        private byte _item50;
        private byte _item51;
        private byte _item52;
        private byte _item53;
        private byte _item54;
        private byte _item55;
        private byte _item56;
        private byte _item57;
        private byte _item58;
        private byte _item59;
        private byte _item60;
        private byte _item61;
        private byte _item62;
        private byte _item63;
        private byte _item64;
        private byte _item65;
        private byte _item66;
        private byte _item67;
        private byte _item68;
        private byte _item69;
        private byte _item70;
        private byte _item71;
        private byte _item72;
        private byte _item73;
        private byte _item74;
        private byte _item75;
        private byte _item76;
        private byte _item77;
        private byte _item78;
        private byte _item79;
        private byte _item80;
        private byte _item81;
        private byte _item82;
        private byte _item83;
        private byte _item84;
        private byte _item85;
        private byte _item86;
        private byte _item87;
        private byte _item88;
        private byte _item89;
        private byte _item90;
        private byte _item91;
        private byte _item92;
        private byte _item93;
        private byte _item94;
        private byte _item95;
        private byte _item96;
        private byte _item97;
        private byte _item98;
        private byte _item99;
        private byte _item100;
        private byte _item101;
        private byte _item102;
        private byte _item103;
        private byte _item104;
        private byte _item105;
        private byte _item106;
        private byte _item107;
        private byte _item108;
        private byte _item109;
        private byte _item110;
        private byte _item111;
        private byte _item112;
        private byte _item113;
        private byte _item114;
        private byte _item115;
        private byte _item116;
        private byte _item117;
        private byte _item118;
        private byte _item119;
        private byte _item120;
        private byte _item121;
        private byte _item122;
        private byte _item123;
        private byte _item124;
        private byte _item125;
        private byte _item126;
        private byte _item127;
        private byte _item128;
        private byte _item129;
        private byte _item130;
        private byte _item131;
        private byte _item132;
        private byte _item133;
        private byte _item134;
        private byte _item135;
        private byte _item136;
        private byte _item137;
        private byte _item138;
        private byte _item139;
        private byte _item140;
        private byte _item141;
        private byte _item142;
        private byte _item143;
        private byte _item144;
        private byte _item145;
        private byte _item146;
        private byte _item147;
        private byte _item148;
        private byte _item149;
        private byte _item150;
        private byte _item151;
        private byte _item152;
        private byte _item153;
        private byte _item154;
        private byte _item155;
        private byte _item156;
        private byte _item157;
        private byte _item158;
        private byte _item159;
        private byte _item160;
        private byte _item161;
        private byte _item162;
        private byte _item163;
        private byte _item164;
        private byte _item165;
        private byte _item166;
        private byte _item167;
        private byte _item168;
        private byte _item169;
        private byte _item170;
        private byte _item171;
        private byte _item172;
        private byte _item173;
        private byte _item174;
        private byte _item175;
        private byte _item176;
        private byte _item177;
        private byte _item178;
        private byte _item179;
        private byte _item180;
        private byte _item181;
        private byte _item182;
        private byte _item183;
        private byte _item184;
        private byte _item185;
        private byte _item186;
        private byte _item187;
        private byte _item188;
        private byte _item189;
        private byte _item190;
        private byte _item191;
        private byte _item192;
        private byte _item193;
        private byte _item194;
        private byte _item195;
        private byte _item196;
        private byte _item197;
        private byte _item198;
        private byte _item199;
        private byte _item200;
        private byte _item201;
        private byte _item202;
        private byte _item203;
        private byte _item204;
        private byte _item205;
        private byte _item206;
        private byte _item207;
        private byte _item208;
        private byte _item209;
        private byte _item210;
        private byte _item211;
        private byte _item212;
        private byte _item213;
        private byte _item214;
        private byte _item215;
        private byte _item216;
        private byte _item217;
        private byte _item218;
        private byte _item219;
        private byte _item220;
        private byte _item221;
        private byte _item222;
        private byte _item223;
        private byte _item224;
        private byte _item225;
        private byte _item226;
        private byte _item227;
        private byte _item228;
        private byte _item229;
        private byte _item230;
        private byte _item231;
        private byte _item232;
        private byte _item233;
        private byte _item234;
        private byte _item235;
        private byte _item236;
        private byte _item237;
        private byte _item238;
        private byte _item239;
        private byte _item240;
        private byte _item241;
        private byte _item242;
        private byte _item243;
        private byte _item244;
        private byte _item245;
        private byte _item246;
        private byte _item247;
        private byte _item248;
        private byte _item249;
        private byte _item250;
        private byte _item251;
        private byte _item252;
        private byte _item253;
        private byte _item254;
        private byte _item255;
    }
    #pragma warning restore 169
    public coreaudioCollection coreaudio;
    #pragma warning disable 169
    public struct sndioCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 256)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
        private byte _item16;
        private byte _item17;
        private byte _item18;
        private byte _item19;
        private byte _item20;
        private byte _item21;
        private byte _item22;
        private byte _item23;
        private byte _item24;
        private byte _item25;
        private byte _item26;
        private byte _item27;
        private byte _item28;
        private byte _item29;
        private byte _item30;
        private byte _item31;
        private byte _item32;
        private byte _item33;
        private byte _item34;
        private byte _item35;
        private byte _item36;
        private byte _item37;
        private byte _item38;
        private byte _item39;
        private byte _item40;
        private byte _item41;
        private byte _item42;
        private byte _item43;
        private byte _item44;
        private byte _item45;
        private byte _item46;
        private byte _item47;
        private byte _item48;
        private byte _item49;
        private byte _item50;
        private byte _item51;
        private byte _item52;
        private byte _item53;
        private byte _item54;
        private byte _item55;
        private byte _item56;
        private byte _item57;
        private byte _item58;
        private byte _item59;
        private byte _item60;
        private byte _item61;
        private byte _item62;
        private byte _item63;
        private byte _item64;
        private byte _item65;
        private byte _item66;
        private byte _item67;
        private byte _item68;
        private byte _item69;
        private byte _item70;
        private byte _item71;
        private byte _item72;
        private byte _item73;
        private byte _item74;
        private byte _item75;
        private byte _item76;
        private byte _item77;
        private byte _item78;
        private byte _item79;
        private byte _item80;
        private byte _item81;
        private byte _item82;
        private byte _item83;
        private byte _item84;
        private byte _item85;
        private byte _item86;
        private byte _item87;
        private byte _item88;
        private byte _item89;
        private byte _item90;
        private byte _item91;
        private byte _item92;
        private byte _item93;
        private byte _item94;
        private byte _item95;
        private byte _item96;
        private byte _item97;
        private byte _item98;
        private byte _item99;
        private byte _item100;
        private byte _item101;
        private byte _item102;
        private byte _item103;
        private byte _item104;
        private byte _item105;
        private byte _item106;
        private byte _item107;
        private byte _item108;
        private byte _item109;
        private byte _item110;
        private byte _item111;
        private byte _item112;
        private byte _item113;
        private byte _item114;
        private byte _item115;
        private byte _item116;
        private byte _item117;
        private byte _item118;
        private byte _item119;
        private byte _item120;
        private byte _item121;
        private byte _item122;
        private byte _item123;
        private byte _item124;
        private byte _item125;
        private byte _item126;
        private byte _item127;
        private byte _item128;
        private byte _item129;
        private byte _item130;
        private byte _item131;
        private byte _item132;
        private byte _item133;
        private byte _item134;
        private byte _item135;
        private byte _item136;
        private byte _item137;
        private byte _item138;
        private byte _item139;
        private byte _item140;
        private byte _item141;
        private byte _item142;
        private byte _item143;
        private byte _item144;
        private byte _item145;
        private byte _item146;
        private byte _item147;
        private byte _item148;
        private byte _item149;
        private byte _item150;
        private byte _item151;
        private byte _item152;
        private byte _item153;
        private byte _item154;
        private byte _item155;
        private byte _item156;
        private byte _item157;
        private byte _item158;
        private byte _item159;
        private byte _item160;
        private byte _item161;
        private byte _item162;
        private byte _item163;
        private byte _item164;
        private byte _item165;
        private byte _item166;
        private byte _item167;
        private byte _item168;
        private byte _item169;
        private byte _item170;
        private byte _item171;
        private byte _item172;
        private byte _item173;
        private byte _item174;
        private byte _item175;
        private byte _item176;
        private byte _item177;
        private byte _item178;
        private byte _item179;
        private byte _item180;
        private byte _item181;
        private byte _item182;
        private byte _item183;
        private byte _item184;
        private byte _item185;
        private byte _item186;
        private byte _item187;
        private byte _item188;
        private byte _item189;
        private byte _item190;
        private byte _item191;
        private byte _item192;
        private byte _item193;
        private byte _item194;
        private byte _item195;
        private byte _item196;
        private byte _item197;
        private byte _item198;
        private byte _item199;
        private byte _item200;
        private byte _item201;
        private byte _item202;
        private byte _item203;
        private byte _item204;
        private byte _item205;
        private byte _item206;
        private byte _item207;
        private byte _item208;
        private byte _item209;
        private byte _item210;
        private byte _item211;
        private byte _item212;
        private byte _item213;
        private byte _item214;
        private byte _item215;
        private byte _item216;
        private byte _item217;
        private byte _item218;
        private byte _item219;
        private byte _item220;
        private byte _item221;
        private byte _item222;
        private byte _item223;
        private byte _item224;
        private byte _item225;
        private byte _item226;
        private byte _item227;
        private byte _item228;
        private byte _item229;
        private byte _item230;
        private byte _item231;
        private byte _item232;
        private byte _item233;
        private byte _item234;
        private byte _item235;
        private byte _item236;
        private byte _item237;
        private byte _item238;
        private byte _item239;
        private byte _item240;
        private byte _item241;
        private byte _item242;
        private byte _item243;
        private byte _item244;
        private byte _item245;
        private byte _item246;
        private byte _item247;
        private byte _item248;
        private byte _item249;
        private byte _item250;
        private byte _item251;
        private byte _item252;
        private byte _item253;
        private byte _item254;
        private byte _item255;
    }
    #pragma warning restore 169
    public sndioCollection sndio;
    #pragma warning disable 169
    public struct audio4Collection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 256)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
        private byte _item16;
        private byte _item17;
        private byte _item18;
        private byte _item19;
        private byte _item20;
        private byte _item21;
        private byte _item22;
        private byte _item23;
        private byte _item24;
        private byte _item25;
        private byte _item26;
        private byte _item27;
        private byte _item28;
        private byte _item29;
        private byte _item30;
        private byte _item31;
        private byte _item32;
        private byte _item33;
        private byte _item34;
        private byte _item35;
        private byte _item36;
        private byte _item37;
        private byte _item38;
        private byte _item39;
        private byte _item40;
        private byte _item41;
        private byte _item42;
        private byte _item43;
        private byte _item44;
        private byte _item45;
        private byte _item46;
        private byte _item47;
        private byte _item48;
        private byte _item49;
        private byte _item50;
        private byte _item51;
        private byte _item52;
        private byte _item53;
        private byte _item54;
        private byte _item55;
        private byte _item56;
        private byte _item57;
        private byte _item58;
        private byte _item59;
        private byte _item60;
        private byte _item61;
        private byte _item62;
        private byte _item63;
        private byte _item64;
        private byte _item65;
        private byte _item66;
        private byte _item67;
        private byte _item68;
        private byte _item69;
        private byte _item70;
        private byte _item71;
        private byte _item72;
        private byte _item73;
        private byte _item74;
        private byte _item75;
        private byte _item76;
        private byte _item77;
        private byte _item78;
        private byte _item79;
        private byte _item80;
        private byte _item81;
        private byte _item82;
        private byte _item83;
        private byte _item84;
        private byte _item85;
        private byte _item86;
        private byte _item87;
        private byte _item88;
        private byte _item89;
        private byte _item90;
        private byte _item91;
        private byte _item92;
        private byte _item93;
        private byte _item94;
        private byte _item95;
        private byte _item96;
        private byte _item97;
        private byte _item98;
        private byte _item99;
        private byte _item100;
        private byte _item101;
        private byte _item102;
        private byte _item103;
        private byte _item104;
        private byte _item105;
        private byte _item106;
        private byte _item107;
        private byte _item108;
        private byte _item109;
        private byte _item110;
        private byte _item111;
        private byte _item112;
        private byte _item113;
        private byte _item114;
        private byte _item115;
        private byte _item116;
        private byte _item117;
        private byte _item118;
        private byte _item119;
        private byte _item120;
        private byte _item121;
        private byte _item122;
        private byte _item123;
        private byte _item124;
        private byte _item125;
        private byte _item126;
        private byte _item127;
        private byte _item128;
        private byte _item129;
        private byte _item130;
        private byte _item131;
        private byte _item132;
        private byte _item133;
        private byte _item134;
        private byte _item135;
        private byte _item136;
        private byte _item137;
        private byte _item138;
        private byte _item139;
        private byte _item140;
        private byte _item141;
        private byte _item142;
        private byte _item143;
        private byte _item144;
        private byte _item145;
        private byte _item146;
        private byte _item147;
        private byte _item148;
        private byte _item149;
        private byte _item150;
        private byte _item151;
        private byte _item152;
        private byte _item153;
        private byte _item154;
        private byte _item155;
        private byte _item156;
        private byte _item157;
        private byte _item158;
        private byte _item159;
        private byte _item160;
        private byte _item161;
        private byte _item162;
        private byte _item163;
        private byte _item164;
        private byte _item165;
        private byte _item166;
        private byte _item167;
        private byte _item168;
        private byte _item169;
        private byte _item170;
        private byte _item171;
        private byte _item172;
        private byte _item173;
        private byte _item174;
        private byte _item175;
        private byte _item176;
        private byte _item177;
        private byte _item178;
        private byte _item179;
        private byte _item180;
        private byte _item181;
        private byte _item182;
        private byte _item183;
        private byte _item184;
        private byte _item185;
        private byte _item186;
        private byte _item187;
        private byte _item188;
        private byte _item189;
        private byte _item190;
        private byte _item191;
        private byte _item192;
        private byte _item193;
        private byte _item194;
        private byte _item195;
        private byte _item196;
        private byte _item197;
        private byte _item198;
        private byte _item199;
        private byte _item200;
        private byte _item201;
        private byte _item202;
        private byte _item203;
        private byte _item204;
        private byte _item205;
        private byte _item206;
        private byte _item207;
        private byte _item208;
        private byte _item209;
        private byte _item210;
        private byte _item211;
        private byte _item212;
        private byte _item213;
        private byte _item214;
        private byte _item215;
        private byte _item216;
        private byte _item217;
        private byte _item218;
        private byte _item219;
        private byte _item220;
        private byte _item221;
        private byte _item222;
        private byte _item223;
        private byte _item224;
        private byte _item225;
        private byte _item226;
        private byte _item227;
        private byte _item228;
        private byte _item229;
        private byte _item230;
        private byte _item231;
        private byte _item232;
        private byte _item233;
        private byte _item234;
        private byte _item235;
        private byte _item236;
        private byte _item237;
        private byte _item238;
        private byte _item239;
        private byte _item240;
        private byte _item241;
        private byte _item242;
        private byte _item243;
        private byte _item244;
        private byte _item245;
        private byte _item246;
        private byte _item247;
        private byte _item248;
        private byte _item249;
        private byte _item250;
        private byte _item251;
        private byte _item252;
        private byte _item253;
        private byte _item254;
        private byte _item255;
    }
    #pragma warning restore 169
    public audio4Collection audio4;
    #pragma warning disable 169
    public struct ossCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 64)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
        private byte _item16;
        private byte _item17;
        private byte _item18;
        private byte _item19;
        private byte _item20;
        private byte _item21;
        private byte _item22;
        private byte _item23;
        private byte _item24;
        private byte _item25;
        private byte _item26;
        private byte _item27;
        private byte _item28;
        private byte _item29;
        private byte _item30;
        private byte _item31;
        private byte _item32;
        private byte _item33;
        private byte _item34;
        private byte _item35;
        private byte _item36;
        private byte _item37;
        private byte _item38;
        private byte _item39;
        private byte _item40;
        private byte _item41;
        private byte _item42;
        private byte _item43;
        private byte _item44;
        private byte _item45;
        private byte _item46;
        private byte _item47;
        private byte _item48;
        private byte _item49;
        private byte _item50;
        private byte _item51;
        private byte _item52;
        private byte _item53;
        private byte _item54;
        private byte _item55;
        private byte _item56;
        private byte _item57;
        private byte _item58;
        private byte _item59;
        private byte _item60;
        private byte _item61;
        private byte _item62;
        private byte _item63;
    }
    #pragma warning restore 169
    public ossCollection oss;
    public int aaudio;
    public uint opensl;
    #pragma warning disable 169
    public struct webaudioCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 32)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
        private byte _item16;
        private byte _item17;
        private byte _item18;
        private byte _item19;
        private byte _item20;
        private byte _item21;
        private byte _item22;
        private byte _item23;
        private byte _item24;
        private byte _item25;
        private byte _item26;
        private byte _item27;
        private byte _item28;
        private byte _item29;
        private byte _item30;
        private byte _item31;
    }
    #pragma warning restore 169
    public webaudioCollection webaudio;
    public int nullbackend;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_id_equal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_id_equal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_device_id_equal(in ma_device_id pA, in ma_device_id pB);

[StructLayout(LayoutKind.Sequential)]
public struct ma_device_info
{
    public ma_device_id id;
    #pragma warning disable 169
    public struct nameCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 256)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
        private byte _item16;
        private byte _item17;
        private byte _item18;
        private byte _item19;
        private byte _item20;
        private byte _item21;
        private byte _item22;
        private byte _item23;
        private byte _item24;
        private byte _item25;
        private byte _item26;
        private byte _item27;
        private byte _item28;
        private byte _item29;
        private byte _item30;
        private byte _item31;
        private byte _item32;
        private byte _item33;
        private byte _item34;
        private byte _item35;
        private byte _item36;
        private byte _item37;
        private byte _item38;
        private byte _item39;
        private byte _item40;
        private byte _item41;
        private byte _item42;
        private byte _item43;
        private byte _item44;
        private byte _item45;
        private byte _item46;
        private byte _item47;
        private byte _item48;
        private byte _item49;
        private byte _item50;
        private byte _item51;
        private byte _item52;
        private byte _item53;
        private byte _item54;
        private byte _item55;
        private byte _item56;
        private byte _item57;
        private byte _item58;
        private byte _item59;
        private byte _item60;
        private byte _item61;
        private byte _item62;
        private byte _item63;
        private byte _item64;
        private byte _item65;
        private byte _item66;
        private byte _item67;
        private byte _item68;
        private byte _item69;
        private byte _item70;
        private byte _item71;
        private byte _item72;
        private byte _item73;
        private byte _item74;
        private byte _item75;
        private byte _item76;
        private byte _item77;
        private byte _item78;
        private byte _item79;
        private byte _item80;
        private byte _item81;
        private byte _item82;
        private byte _item83;
        private byte _item84;
        private byte _item85;
        private byte _item86;
        private byte _item87;
        private byte _item88;
        private byte _item89;
        private byte _item90;
        private byte _item91;
        private byte _item92;
        private byte _item93;
        private byte _item94;
        private byte _item95;
        private byte _item96;
        private byte _item97;
        private byte _item98;
        private byte _item99;
        private byte _item100;
        private byte _item101;
        private byte _item102;
        private byte _item103;
        private byte _item104;
        private byte _item105;
        private byte _item106;
        private byte _item107;
        private byte _item108;
        private byte _item109;
        private byte _item110;
        private byte _item111;
        private byte _item112;
        private byte _item113;
        private byte _item114;
        private byte _item115;
        private byte _item116;
        private byte _item117;
        private byte _item118;
        private byte _item119;
        private byte _item120;
        private byte _item121;
        private byte _item122;
        private byte _item123;
        private byte _item124;
        private byte _item125;
        private byte _item126;
        private byte _item127;
        private byte _item128;
        private byte _item129;
        private byte _item130;
        private byte _item131;
        private byte _item132;
        private byte _item133;
        private byte _item134;
        private byte _item135;
        private byte _item136;
        private byte _item137;
        private byte _item138;
        private byte _item139;
        private byte _item140;
        private byte _item141;
        private byte _item142;
        private byte _item143;
        private byte _item144;
        private byte _item145;
        private byte _item146;
        private byte _item147;
        private byte _item148;
        private byte _item149;
        private byte _item150;
        private byte _item151;
        private byte _item152;
        private byte _item153;
        private byte _item154;
        private byte _item155;
        private byte _item156;
        private byte _item157;
        private byte _item158;
        private byte _item159;
        private byte _item160;
        private byte _item161;
        private byte _item162;
        private byte _item163;
        private byte _item164;
        private byte _item165;
        private byte _item166;
        private byte _item167;
        private byte _item168;
        private byte _item169;
        private byte _item170;
        private byte _item171;
        private byte _item172;
        private byte _item173;
        private byte _item174;
        private byte _item175;
        private byte _item176;
        private byte _item177;
        private byte _item178;
        private byte _item179;
        private byte _item180;
        private byte _item181;
        private byte _item182;
        private byte _item183;
        private byte _item184;
        private byte _item185;
        private byte _item186;
        private byte _item187;
        private byte _item188;
        private byte _item189;
        private byte _item190;
        private byte _item191;
        private byte _item192;
        private byte _item193;
        private byte _item194;
        private byte _item195;
        private byte _item196;
        private byte _item197;
        private byte _item198;
        private byte _item199;
        private byte _item200;
        private byte _item201;
        private byte _item202;
        private byte _item203;
        private byte _item204;
        private byte _item205;
        private byte _item206;
        private byte _item207;
        private byte _item208;
        private byte _item209;
        private byte _item210;
        private byte _item211;
        private byte _item212;
        private byte _item213;
        private byte _item214;
        private byte _item215;
        private byte _item216;
        private byte _item217;
        private byte _item218;
        private byte _item219;
        private byte _item220;
        private byte _item221;
        private byte _item222;
        private byte _item223;
        private byte _item224;
        private byte _item225;
        private byte _item226;
        private byte _item227;
        private byte _item228;
        private byte _item229;
        private byte _item230;
        private byte _item231;
        private byte _item232;
        private byte _item233;
        private byte _item234;
        private byte _item235;
        private byte _item236;
        private byte _item237;
        private byte _item238;
        private byte _item239;
        private byte _item240;
        private byte _item241;
        private byte _item242;
        private byte _item243;
        private byte _item244;
        private byte _item245;
        private byte _item246;
        private byte _item247;
        private byte _item248;
        private byte _item249;
        private byte _item250;
        private byte _item251;
        private byte _item252;
        private byte _item253;
        private byte _item254;
        private byte _item255;
    }
    #pragma warning restore 169
    public nameCollection name;
    public uint isDefault;
    public uint nativeDataFormatCount;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_device_config
{
    public ma_device_type deviceType;
    public uint sampleRate;
    public uint periodSizeInFrames;
    public uint periodSizeInMilliseconds;
    public uint periods;
    public ma_performance_profile performanceProfile;
    public byte noPreSilencedOutputBuffer;
    public byte noClip;
    public byte noDisableDenormals;
    public byte noFixedSizedCallback;
    public IntPtr dataCallback;
    public IntPtr notificationCallback;
    public IntPtr stopCallback;
    public void* pUserData;
    public ma_resampler_config resampling;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_device_descriptor
{
    public ma_device_id* pDeviceID;
    public ma_share_mode shareMode;
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    #pragma warning disable 169
    public struct channelMapCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 254)[index];
        private byte _item0;
        private byte _item1;
        private byte _item2;
        private byte _item3;
        private byte _item4;
        private byte _item5;
        private byte _item6;
        private byte _item7;
        private byte _item8;
        private byte _item9;
        private byte _item10;
        private byte _item11;
        private byte _item12;
        private byte _item13;
        private byte _item14;
        private byte _item15;
        private byte _item16;
        private byte _item17;
        private byte _item18;
        private byte _item19;
        private byte _item20;
        private byte _item21;
        private byte _item22;
        private byte _item23;
        private byte _item24;
        private byte _item25;
        private byte _item26;
        private byte _item27;
        private byte _item28;
        private byte _item29;
        private byte _item30;
        private byte _item31;
        private byte _item32;
        private byte _item33;
        private byte _item34;
        private byte _item35;
        private byte _item36;
        private byte _item37;
        private byte _item38;
        private byte _item39;
        private byte _item40;
        private byte _item41;
        private byte _item42;
        private byte _item43;
        private byte _item44;
        private byte _item45;
        private byte _item46;
        private byte _item47;
        private byte _item48;
        private byte _item49;
        private byte _item50;
        private byte _item51;
        private byte _item52;
        private byte _item53;
        private byte _item54;
        private byte _item55;
        private byte _item56;
        private byte _item57;
        private byte _item58;
        private byte _item59;
        private byte _item60;
        private byte _item61;
        private byte _item62;
        private byte _item63;
        private byte _item64;
        private byte _item65;
        private byte _item66;
        private byte _item67;
        private byte _item68;
        private byte _item69;
        private byte _item70;
        private byte _item71;
        private byte _item72;
        private byte _item73;
        private byte _item74;
        private byte _item75;
        private byte _item76;
        private byte _item77;
        private byte _item78;
        private byte _item79;
        private byte _item80;
        private byte _item81;
        private byte _item82;
        private byte _item83;
        private byte _item84;
        private byte _item85;
        private byte _item86;
        private byte _item87;
        private byte _item88;
        private byte _item89;
        private byte _item90;
        private byte _item91;
        private byte _item92;
        private byte _item93;
        private byte _item94;
        private byte _item95;
        private byte _item96;
        private byte _item97;
        private byte _item98;
        private byte _item99;
        private byte _item100;
        private byte _item101;
        private byte _item102;
        private byte _item103;
        private byte _item104;
        private byte _item105;
        private byte _item106;
        private byte _item107;
        private byte _item108;
        private byte _item109;
        private byte _item110;
        private byte _item111;
        private byte _item112;
        private byte _item113;
        private byte _item114;
        private byte _item115;
        private byte _item116;
        private byte _item117;
        private byte _item118;
        private byte _item119;
        private byte _item120;
        private byte _item121;
        private byte _item122;
        private byte _item123;
        private byte _item124;
        private byte _item125;
        private byte _item126;
        private byte _item127;
        private byte _item128;
        private byte _item129;
        private byte _item130;
        private byte _item131;
        private byte _item132;
        private byte _item133;
        private byte _item134;
        private byte _item135;
        private byte _item136;
        private byte _item137;
        private byte _item138;
        private byte _item139;
        private byte _item140;
        private byte _item141;
        private byte _item142;
        private byte _item143;
        private byte _item144;
        private byte _item145;
        private byte _item146;
        private byte _item147;
        private byte _item148;
        private byte _item149;
        private byte _item150;
        private byte _item151;
        private byte _item152;
        private byte _item153;
        private byte _item154;
        private byte _item155;
        private byte _item156;
        private byte _item157;
        private byte _item158;
        private byte _item159;
        private byte _item160;
        private byte _item161;
        private byte _item162;
        private byte _item163;
        private byte _item164;
        private byte _item165;
        private byte _item166;
        private byte _item167;
        private byte _item168;
        private byte _item169;
        private byte _item170;
        private byte _item171;
        private byte _item172;
        private byte _item173;
        private byte _item174;
        private byte _item175;
        private byte _item176;
        private byte _item177;
        private byte _item178;
        private byte _item179;
        private byte _item180;
        private byte _item181;
        private byte _item182;
        private byte _item183;
        private byte _item184;
        private byte _item185;
        private byte _item186;
        private byte _item187;
        private byte _item188;
        private byte _item189;
        private byte _item190;
        private byte _item191;
        private byte _item192;
        private byte _item193;
        private byte _item194;
        private byte _item195;
        private byte _item196;
        private byte _item197;
        private byte _item198;
        private byte _item199;
        private byte _item200;
        private byte _item201;
        private byte _item202;
        private byte _item203;
        private byte _item204;
        private byte _item205;
        private byte _item206;
        private byte _item207;
        private byte _item208;
        private byte _item209;
        private byte _item210;
        private byte _item211;
        private byte _item212;
        private byte _item213;
        private byte _item214;
        private byte _item215;
        private byte _item216;
        private byte _item217;
        private byte _item218;
        private byte _item219;
        private byte _item220;
        private byte _item221;
        private byte _item222;
        private byte _item223;
        private byte _item224;
        private byte _item225;
        private byte _item226;
        private byte _item227;
        private byte _item228;
        private byte _item229;
        private byte _item230;
        private byte _item231;
        private byte _item232;
        private byte _item233;
        private byte _item234;
        private byte _item235;
        private byte _item236;
        private byte _item237;
        private byte _item238;
        private byte _item239;
        private byte _item240;
        private byte _item241;
        private byte _item242;
        private byte _item243;
        private byte _item244;
        private byte _item245;
        private byte _item246;
        private byte _item247;
        private byte _item248;
        private byte _item249;
        private byte _item250;
        private byte _item251;
        private byte _item252;
        private byte _item253;
    }
    #pragma warning restore 169
    public channelMapCollection channelMap;
    public uint periodSizeInFrames;
    public uint periodSizeInMilliseconds;
    public uint periodCount;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_backend_callbacks
{
    public delegate* unmanaged<ma_context*, ma_context_config*, ma_backend_callbacks*, void*> onContextInit;
    public delegate* unmanaged<ma_context*, void*> onContextUninit;
    public delegate* unmanaged<ma_context*, IntPtr, void*, void*> onContextEnumerateDevices;
    public delegate* unmanaged<ma_context*, ma_device_type, ma_device_id*, ma_device_info*, void*> onContextGetDeviceInfo;
    public delegate* unmanaged<ma_device*, ma_device_config*, ma_device_descriptor*, ma_device_descriptor*, void*> onDeviceInit;
    public delegate* unmanaged<ma_device*, void*> onDeviceUninit;
    public delegate* unmanaged<ma_device*, void*> onDeviceStart;
    public delegate* unmanaged<ma_device*, void*> onDeviceStop;
    public delegate* unmanaged<ma_device*, void*, uint, uint*, void*> onDeviceRead;
    public delegate* unmanaged<ma_device*, void*, uint, uint*, void*> onDeviceWrite;
    public delegate* unmanaged<ma_device*, void*> onDeviceDataLoop;
    public delegate* unmanaged<ma_device*, void*> onDeviceDataLoopWakeup;
    public delegate* unmanaged<ma_device*, ma_device_type, ma_device_info*, void*> onDeviceGetInfo;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_context_config
{
    public ma_log* pLog;
    public ma_thread_priority threadPriority;
    public nuint threadStackSize;
    public void* pUserData;
    public ma_allocation_callbacks allocationCallbacks;
    public ma_backend_callbacks custom;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_context_command__wasapi
{
    public int code;
    public IntPtr* pEvent;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_context
{
    public ma_backend_callbacks callbacks;
    public ma_backend backend;
    public ma_log* pLog;
    public ma_log log;
    public ma_thread_priority threadPriority;
    public nuint threadStackSize;
    public void* pUserData;
    public ma_allocation_callbacks allocationCallbacks;
    public IntPtr deviceEnumLock;
    public IntPtr deviceInfoLock;
    public uint deviceInfoCapacity;
    public uint playbackDeviceInfoCount;
    public uint captureDeviceInfoCount;
    public ma_device_info* pDeviceInfos;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_device
{
    public ma_context* pContext;
    public ma_device_type type;
    public uint sampleRate;
    public ma_atomic_device_state state;
    public IntPtr onData;
    public IntPtr onNotification;
    public IntPtr onStop;
    public void* pUserData;
    public IntPtr startStopLock;
    public IntPtr wakeupEvent;
    public IntPtr startEvent;
    public IntPtr stopEvent;
    public IntPtr thread;
    public ma_result workResult;
    public byte isOwnerOfContext;
    public byte noPreSilencedOutputBuffer;
    public byte noClip;
    public byte noDisableDenormals;
    public byte noFixedSizedCallback;
    public ma_atomic_float masterVolumeFactor;
    public ma_duplex_rb duplexRB;
}
#if WEB
public static ma_context_config ma_context_config_init()
{
    ma_context_config result = default;
    ma_context_config_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_context_config ma_context_config_init();
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_context_init(ma_backend* backends, uint backendCount, in ma_context_config pConfig, ma_context* pContext);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_context_uninit(ma_context* pContext);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_sizeof", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_sizeof", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern nuint ma_context_sizeof();

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_get_log", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_get_log", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_log* ma_context_get_log(ma_context* pContext);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_enumerate_devices", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_enumerate_devices", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_context_enumerate_devices(ma_context* pContext, IntPtr callback, void* pUserData);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_get_devices", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_get_devices", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_context_get_devices(ma_context* pContext, out IntPtr ppPlaybackDeviceInfos, ref uint pPlaybackDeviceCount, out IntPtr ppCaptureDeviceInfos, ref uint pCaptureDeviceCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_get_device_info", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_get_device_info", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_context_get_device_info(ma_context* pContext, ma_device_type deviceType, in ma_device_id pDeviceID, ma_device_info* pDeviceInfo);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_is_loopback_supported", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_is_loopback_supported", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_context_is_loopback_supported(ma_context* pContext);

#if WEB
public static ma_device_config ma_device_config_init(ma_device_type deviceType)
{
    ma_device_config result = default;
    ma_device_config_init_internal(ref result, deviceType);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_device_config ma_device_config_init(ma_device_type deviceType);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_init(ma_context* pContext, in ma_device_config pConfig, ma_device* pDevice);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_init_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_init_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_init_ex(ma_backend* backends, uint backendCount, in ma_context_config pContextConfig, in ma_device_config pConfig, ma_device* pDevice);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_device_uninit(ma_device* pDevice);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_get_context", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_get_context", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_context* ma_device_get_context(ma_device* pDevice);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_get_log", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_get_log", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_log* ma_device_get_log(ma_device* pDevice);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_get_info", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_get_info", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_get_info(ma_device* pDevice, ma_device_type type, ma_device_info* pDeviceInfo);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_get_name", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_get_name", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_get_name(ma_device* pDevice, ma_device_type type, IntPtr pName, nuint nameCap, ref nuint pLengthNotIncludingNullTerminator);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_start", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_start", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_start(ma_device* pDevice);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_stop", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_stop", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_stop(ma_device* pDevice);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_is_started", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_is_started", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_device_is_started(in ma_device pDevice);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_get_state", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_get_state", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_device_state ma_device_get_state(in ma_device pDevice);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_post_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_post_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_post_init(ma_device* pDevice, ma_device_type deviceType, in ma_device_descriptor pPlaybackDescriptor, in ma_device_descriptor pCaptureDescriptor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_set_master_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_set_master_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_set_master_volume(ma_device* pDevice, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_get_master_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_get_master_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_get_master_volume(ma_device* pDevice, ref float pVolume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_set_master_volume_db", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_set_master_volume_db", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_set_master_volume_db(ma_device* pDevice, float gainDB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_get_master_volume_db", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_get_master_volume_db", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_get_master_volume_db(ma_device* pDevice, ref float pGainDB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_handle_backend_data_callback", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_handle_backend_data_callback", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_device_handle_backend_data_callback(ma_device* pDevice, void* pOutput, void* pInput, uint frameCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_calculate_buffer_size_in_frames_from_descriptor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_calculate_buffer_size_in_frames_from_descriptor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_calculate_buffer_size_in_frames_from_descriptor(in ma_device_descriptor pDescriptor, uint nativeSampleRate, ma_performance_profile performanceProfile);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_get_backend_name", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_get_backend_name", CallingConvention = CallingConvention.Cdecl)]
#endif
private static extern IntPtr ma_get_backend_name_native(ma_backend backend);

public static string ma_get_backend_name(ma_backend backend)
{
    IntPtr ptr = ma_get_backend_name_native(backend);
    if (ptr == IntPtr.Zero)
        return "";

    // Manual UTF-8 to string conversion to avoid marshalling corruption
    try
    {
        return Marshal.PtrToStringUTF8(ptr) ?? "";
    }
    catch
    {
        // Fallback in case of any marshalling issues
        return "";
    }
}

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_get_backend_from_name", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_get_backend_from_name", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_get_backend_from_name([M(U.LPUTF8Str)] string pBackendName, ma_backend* pBackend);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_is_backend_enabled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_is_backend_enabled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_is_backend_enabled(ma_backend backend);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_get_enabled_backends", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_get_enabled_backends", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_get_enabled_backends(ma_backend* pBackends, nuint backendCap, ref nuint pBackendCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_is_loopback_supported", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_is_loopback_supported", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_is_loopback_supported(ma_backend backend);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_calculate_buffer_size_in_milliseconds_from_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_calculate_buffer_size_in_milliseconds_from_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_calculate_buffer_size_in_milliseconds_from_frames(uint bufferSizeInFrames, uint sampleRate);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_calculate_buffer_size_in_frames_from_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_calculate_buffer_size_in_frames_from_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_calculate_buffer_size_in_frames_from_milliseconds(uint bufferSizeInMilliseconds, uint sampleRate);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_pcm_frames(void* dst, void* src, ulong frameCount, ma_format format, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_silence_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_silence_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_silence_pcm_frames(void* p, ulong frameCount, ma_format format, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_offset_pcm_frames_ptr", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_offset_pcm_frames_ptr", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void* ma_offset_pcm_frames_ptr(void* p, ulong offsetInFrames, ma_format format, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_offset_pcm_frames_const_ptr", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_offset_pcm_frames_const_ptr", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void* ma_offset_pcm_frames_const_ptr(void* p, ulong offsetInFrames, ma_format format, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_clip_samples_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_clip_samples_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_clip_samples_u8(ref byte pDst, in short pSrc, ulong count);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_clip_samples_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_clip_samples_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_clip_samples_s16(ref short pDst, in int pSrc, ulong count);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_clip_samples_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_clip_samples_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_clip_samples_s24(ref byte pDst, in long pSrc, ulong count);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_clip_samples_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_clip_samples_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_clip_samples_s32(ref int pDst, in long pSrc, ulong count);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_clip_samples_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_clip_samples_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_clip_samples_f32(ref float pDst, in float pSrc, ulong count);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_clip_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_clip_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_clip_pcm_frames(void* pDst, void* pSrc, ulong frameCount, ma_format format, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_u8(ref byte pSamplesOut, in byte pSamplesIn, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_s16(ref short pSamplesOut, in short pSamplesIn, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_s24(void* pSamplesOut, void* pSamplesIn, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_s32(ref int pSamplesOut, in int pSamplesIn, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_f32(ref float pSamplesOut, in float pSamplesIn, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_u8(ref byte pSamples, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_s16(ref short pSamples, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_s24(void* pSamples, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_s32(ref int pSamples, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_f32(ref float pSamples, ulong sampleCount, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_pcm_frames_u8(ref byte pFramesOut, in byte pFramesIn, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_pcm_frames_s16(ref short pFramesOut, in short pFramesIn, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_pcm_frames_s24(void* pFramesOut, void* pFramesIn, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_pcm_frames_s32(ref int pFramesOut, in int pFramesIn, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_pcm_frames_f32(ref float pFramesOut, in float pFramesIn, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_pcm_frames(void* pFramesOut, void* pFramesIn, ulong frameCount, ma_format format, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_pcm_frames_u8(ref byte pFrames, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_pcm_frames_s16(ref short pFrames, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_pcm_frames_s24(void* pFrames, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_pcm_frames_s32(ref int pFrames, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_pcm_frames_f32(ref float pFrames, ulong frameCount, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_apply_volume_factor_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_apply_volume_factor_pcm_frames(void* pFrames, ulong frameCount, ma_format format, uint channels, float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_per_channel_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_factor_per_channel_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_factor_per_channel_f32(ref float pFramesOut, in float pFramesIn, ulong frameCount, uint channels, ref float pChannelGains);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_u8", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_u8", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_and_clip_samples_u8(ref byte pDst, in short pSrc, ulong count, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_s16", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_s16", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_and_clip_samples_s16(ref short pDst, in int pSrc, ulong count, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_s24", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_s24", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_and_clip_samples_s24(ref byte pDst, in long pSrc, ulong count, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_s32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_s32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_and_clip_samples_s32(ref int pDst, in long pSrc, ulong count, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_and_clip_samples_f32(ref float pDst, in float pSrc, ulong count, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_copy_and_apply_volume_and_clip_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_copy_and_apply_volume_and_clip_pcm_frames(void* pDst, void* pSrc, ulong frameCount, ma_format format, uint channels, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_volume_linear_to_db", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_volume_linear_to_db", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_volume_linear_to_db(float factor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_volume_db_to_linear", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_volume_db_to_linear", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_volume_db_to_linear(float gain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_mix_pcm_frames_f32", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_mix_pcm_frames_f32", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_mix_pcm_frames_f32(ref float pDst, in float pSrc, ulong frameCount, uint channels, float volume);

public enum ma_open_mode_flags
{
    MA_OPEN_MODE_READ = 1,
    MA_OPEN_MODE_WRITE = 2,
}
public enum ma_seek_origin
{
    ma_seek_origin_start,
    ma_seek_origin_current,
    ma_seek_origin_end,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_file_info
{
    public ulong sizeInBytes;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_vfs_callbacks
{
    public delegate* unmanaged<IntPtr, byte*, uint, IntPtr, void*> onOpen;
    public delegate* unmanaged<IntPtr, IntPtr, uint, IntPtr, void*> onOpenW;
    public delegate* unmanaged<IntPtr, IntPtr, void*> onClose;
    public delegate* unmanaged<IntPtr, IntPtr, void*, nuint, nuint*, void*> onRead;
    public delegate* unmanaged<IntPtr, IntPtr, void*, nuint, nuint*, void*> onWrite;
    public delegate* unmanaged<IntPtr, IntPtr, long, ma_seek_origin, void*> onSeek;
    public delegate* unmanaged<IntPtr, IntPtr, long*, void*> onTell;
    public delegate* unmanaged<IntPtr, IntPtr, ma_file_info*, void*> onInfo;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_vfs_open", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_vfs_open", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_vfs_open(IntPtr pVFS, [M(U.LPUTF8Str)] string pFilePath, uint openMode, IntPtr pFile);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_vfs_open_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_vfs_open_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_vfs_open_w(IntPtr pVFS, IntPtr pFilePath, uint openMode, IntPtr pFile);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_vfs_close", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_vfs_close", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_vfs_close(IntPtr pVFS, IntPtr file);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_vfs_read", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_vfs_read", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_vfs_read(IntPtr pVFS, IntPtr file, void* pDst, nuint sizeInBytes, ref nuint pBytesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_vfs_write", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_vfs_write", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_vfs_write(IntPtr pVFS, IntPtr file, void* pSrc, nuint sizeInBytes, ref nuint pBytesWritten);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_vfs_seek", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_vfs_seek", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_vfs_seek(IntPtr pVFS, IntPtr file, long offset, ma_seek_origin origin);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_vfs_tell", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_vfs_tell", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_vfs_tell(IntPtr pVFS, IntPtr file, ref long pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_vfs_info", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_vfs_info", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_vfs_info(IntPtr pVFS, IntPtr file, ma_file_info* pInfo);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_vfs_open_and_read_file", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_vfs_open_and_read_file", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_vfs_open_and_read_file(IntPtr pVFS, [M(U.LPUTF8Str)] string pFilePath, IntPtr ppData, ref nuint pSize, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_default_vfs
{
    public ma_vfs_callbacks cb;
    public ma_allocation_callbacks allocationCallbacks;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_default_vfs_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_default_vfs_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_default_vfs_init(ma_default_vfs* pVFS, in ma_allocation_callbacks pAllocationCallbacks);

public enum ma_encoding_format
{
    ma_encoding_format_unknown = 0,
    ma_encoding_format_wav,
    ma_encoding_format_flac,
    ma_encoding_format_mp3,
    ma_encoding_format_vorbis,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_decoding_backend_config
{
    public ma_format preferredFormat;
    public uint seekPointCount;
}
#if WEB
public static ma_decoding_backend_config ma_decoding_backend_config_init(ma_format preferredFormat, uint seekPointCount)
{
    ma_decoding_backend_config result = default;
    ma_decoding_backend_config_init_internal(ref result, preferredFormat, seekPointCount);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoding_backend_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoding_backend_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_decoding_backend_config ma_decoding_backend_config_init(ma_format preferredFormat, uint seekPointCount);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_decoding_backend_vtable
{
    public delegate* unmanaged<void*, IntPtr, IntPtr, IntPtr, void*, ma_decoding_backend_config*, ma_allocation_callbacks*, void*, void*> onInit;
    public delegate* unmanaged<void*, byte*, ma_decoding_backend_config*, ma_allocation_callbacks*, void*, void*> onInitFile;
    public delegate* unmanaged<void*, IntPtr, ma_decoding_backend_config*, ma_allocation_callbacks*, void*, void*> onInitFileW;
    public delegate* unmanaged<void*, void*, nuint, ma_decoding_backend_config*, ma_allocation_callbacks*, void*, void*> onInitMemory;
    public delegate* unmanaged<void*, IntPtr, ma_allocation_callbacks*, void> onUninit;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_decoder_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public byte* pChannelMap;
    public ma_channel_mix_mode channelMixMode;
    public ma_dither_mode ditherMode;
    public ma_resampler_config resampling;
    public ma_allocation_callbacks allocationCallbacks;
    public ma_encoding_format encodingFormat;
    public uint seekPointCount;
    public ma_decoding_backend_vtable** ppCustomBackendVTables;
    public uint customBackendCount;
    public void* pCustomBackendUserData;
}
// Helper for ma_decoder.data union: max(vfs:2 ptrs, memory:3 ptr-sized) = 3 * pointer_size
#if WEB
[StructLayout(LayoutKind.Explicit, Size = 12)]   // 3 x 4 bytes (wasm32)
#else
[StructLayout(LayoutKind.Explicit, Size = 24)]   // 3 x 8 bytes (x64)
#endif
public struct ma_decoder_data_union { }
[StructLayout(LayoutKind.Sequential)]
public struct ma_decoder
{
    public ma_data_source_base ds;
    public IntPtr pBackend;
    public ma_decoding_backend_vtable* pBackendVTable;
    public void* pBackendUserData;
    public IntPtr onRead;
    public IntPtr onSeek;
    public IntPtr onTell;
    public void* pUserData;
    public ulong readPointerInPCMFrames;
    public ma_format outputFormat;
    public uint outputChannels;
    public uint outputSampleRate;
    public ma_data_converter converter;
    public void* pInputCache;
    public ulong inputCacheCap;
    public ulong inputCacheConsumed;
    public ulong inputCacheRemaining;
    public ma_allocation_callbacks allocationCallbacks;
    public ma_decoder_data_union data; // union { vfs { pVFS, file }; memory { pData, dataSize, currentReadPos }; }
}
#if WEB
public static ma_decoder_config ma_decoder_config_init(ma_format outputFormat, uint outputChannels, uint outputSampleRate)
{
    ma_decoder_config result = default;
    ma_decoder_config_init_internal(ref result, outputFormat, outputChannels, outputSampleRate);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_decoder_config ma_decoder_config_init(ma_format outputFormat, uint outputChannels, uint outputSampleRate);
#endif

#if WEB
public static ma_decoder_config ma_decoder_config_init_default()
{
    ma_decoder_config result = default;
    ma_decoder_config_init_default_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_config_init_default", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_config_init_default", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_decoder_config ma_decoder_config_init_default();
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_init(IntPtr onRead, IntPtr onSeek, void* pUserData, in ma_decoder_config pConfig, ma_decoder* pDecoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_init_memory", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_init_memory", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_init_memory(void* pData, nuint dataSize, in ma_decoder_config pConfig, ma_decoder* pDecoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_init_vfs", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_init_vfs", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_init_vfs(IntPtr pVFS, [M(U.LPUTF8Str)] string pFilePath, in ma_decoder_config pConfig, ma_decoder* pDecoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_init_vfs_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_init_vfs_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_init_vfs_w(IntPtr pVFS, IntPtr pFilePath, in ma_decoder_config pConfig, ma_decoder* pDecoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_init_file", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_init_file", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_init_file([M(U.LPUTF8Str)] string pFilePath, in ma_decoder_config pConfig, ma_decoder* pDecoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_init_file_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_init_file_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_init_file_w(IntPtr pFilePath, in ma_decoder_config pConfig, ma_decoder* pDecoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_uninit(ma_decoder* pDecoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_read_pcm_frames(ma_decoder* pDecoder, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_seek_to_pcm_frame(ma_decoder* pDecoder, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_get_data_format(ma_decoder* pDecoder, ref ma_format pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_get_cursor_in_pcm_frames(ma_decoder* pDecoder, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_get_length_in_pcm_frames(ma_decoder* pDecoder, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decoder_get_available_frames(ma_decoder* pDecoder, ref ulong pAvailableFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decode_from_vfs", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decode_from_vfs", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decode_from_vfs(IntPtr pVFS, [M(U.LPUTF8Str)] string pFilePath, ma_decoder_config* pConfig, ref ulong pFrameCountOut, IntPtr ppPCMFramesOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decode_file", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decode_file", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decode_file([M(U.LPUTF8Str)] string pFilePath, ma_decoder_config* pConfig, ref ulong pFrameCountOut, IntPtr ppPCMFramesOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decode_memory", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decode_memory", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_decode_memory(void* pData, nuint dataSize, ma_decoder_config* pConfig, ref ulong pFrameCountOut, IntPtr ppPCMFramesOut);

[StructLayout(LayoutKind.Sequential)]
public struct ma_encoder_config
{
    public ma_encoding_format encodingFormat;
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public ma_allocation_callbacks allocationCallbacks;
}
#if WEB
public static ma_encoder_config ma_encoder_config_init(ma_encoding_format encodingFormat, ma_format format, uint channels, uint sampleRate)
{
    ma_encoder_config result = default;
    ma_encoder_config_init_internal(ref result, encodingFormat, format, channels, sampleRate);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_encoder_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_encoder_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_encoder_config ma_encoder_config_init(ma_encoding_format encodingFormat, ma_format format, uint channels, uint sampleRate);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_encoder
{
    public ma_encoder_config config;
    public IntPtr onWrite;
    public IntPtr onSeek;
    public IntPtr onInit;
    public IntPtr onUninit;
    public IntPtr onWritePCMFrames;
    public void* pUserData;
    public void* pInternalEncoder;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_encoder_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_encoder_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_encoder_init(IntPtr onWrite, IntPtr onSeek, void* pUserData, in ma_encoder_config pConfig, ma_encoder* pEncoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_encoder_init_vfs", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_encoder_init_vfs", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_encoder_init_vfs(IntPtr pVFS, [M(U.LPUTF8Str)] string pFilePath, in ma_encoder_config pConfig, ma_encoder* pEncoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_encoder_init_vfs_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_encoder_init_vfs_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_encoder_init_vfs_w(IntPtr pVFS, IntPtr pFilePath, in ma_encoder_config pConfig, ma_encoder* pEncoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_encoder_init_file", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_encoder_init_file", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_encoder_init_file([M(U.LPUTF8Str)] string pFilePath, in ma_encoder_config pConfig, ma_encoder* pEncoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_encoder_init_file_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_encoder_init_file_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_encoder_init_file_w(IntPtr pFilePath, in ma_encoder_config pConfig, ma_encoder* pEncoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_encoder_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_encoder_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_encoder_uninit(ma_encoder* pEncoder);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_encoder_write_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_encoder_write_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_encoder_write_pcm_frames(ma_encoder* pEncoder, void* pFramesIn, ulong frameCount, ref ulong pFramesWritten);

public enum ma_waveform_type
{
    ma_waveform_type_sine,
    ma_waveform_type_square,
    ma_waveform_type_triangle,
    ma_waveform_type_sawtooth,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_waveform_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public ma_waveform_type type;
    public double amplitude;
    public double frequency;
}
#if WEB
public static ma_waveform_config ma_waveform_config_init(ma_format format, uint channels, uint sampleRate, ma_waveform_type type, double amplitude, double frequency)
{
    ma_waveform_config result = default;
    ma_waveform_config_init_internal(ref result, format, channels, sampleRate, type, amplitude, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_waveform_config ma_waveform_config_init(ma_format format, uint channels, uint sampleRate, ma_waveform_type type, double amplitude, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_waveform
{
    public ma_data_source_base ds;
    public ma_waveform_config config;
    public double advance;
    public double time;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_waveform_init(in ma_waveform_config pConfig, ma_waveform* pWaveform);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_waveform_uninit(ma_waveform* pWaveform);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_waveform_read_pcm_frames(ma_waveform* pWaveform, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_waveform_seek_to_pcm_frame(ma_waveform* pWaveform, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_set_amplitude", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_set_amplitude", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_waveform_set_amplitude(ma_waveform* pWaveform, double amplitude);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_set_frequency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_set_frequency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_waveform_set_frequency(ma_waveform* pWaveform, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_set_type", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_set_type", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_waveform_set_type(ma_waveform* pWaveform, ma_waveform_type type);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_set_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_set_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_waveform_set_sample_rate(ma_waveform* pWaveform, uint sampleRate);

[StructLayout(LayoutKind.Sequential)]
public struct ma_pulsewave_config
{
    public ma_format format;
    public uint channels;
    public uint sampleRate;
    public double dutyCycle;
    public double amplitude;
    public double frequency;
}
#if WEB
public static ma_pulsewave_config ma_pulsewave_config_init(ma_format format, uint channels, uint sampleRate, double dutyCycle, double amplitude, double frequency)
{
    ma_pulsewave_config result = default;
    ma_pulsewave_config_init_internal(ref result, format, channels, sampleRate, dutyCycle, amplitude, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_pulsewave_config ma_pulsewave_config_init(ma_format format, uint channels, uint sampleRate, double dutyCycle, double amplitude, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_pulsewave
{
    public ma_waveform waveform;
    public ma_pulsewave_config config;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pulsewave_init(in ma_pulsewave_config pConfig, ma_pulsewave* pWaveform);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pulsewave_uninit(ma_pulsewave* pWaveform);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pulsewave_read_pcm_frames(ma_pulsewave* pWaveform, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pulsewave_seek_to_pcm_frame(ma_pulsewave* pWaveform, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_set_amplitude", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_set_amplitude", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pulsewave_set_amplitude(ma_pulsewave* pWaveform, double amplitude);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_set_frequency", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_set_frequency", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pulsewave_set_frequency(ma_pulsewave* pWaveform, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_set_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_set_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pulsewave_set_sample_rate(ma_pulsewave* pWaveform, uint sampleRate);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_set_duty_cycle", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_set_duty_cycle", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_pulsewave_set_duty_cycle(ma_pulsewave* pWaveform, double dutyCycle);

public enum ma_noise_type
{
    ma_noise_type_white,
    ma_noise_type_pink,
    ma_noise_type_brownian,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_noise_config
{
    public ma_format format;
    public uint channels;
    public ma_noise_type type;
    public int seed;
    public double amplitude;
    public uint duplicateChannels;
}
#if WEB
public static ma_noise_config ma_noise_config_init(ma_format format, uint channels, ma_noise_type type, int seed, double amplitude)
{
    ma_noise_config result = default;
    ma_noise_config_init_internal(ref result, format, channels, type, seed, amplitude);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_noise_config ma_noise_config_init(ma_format format, uint channels, ma_noise_type type, int seed, double amplitude);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_noise
{
    public ma_data_source_base ds;
    public ma_noise_config config;
    public ma_lcg lcg;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_noise_get_heap_size(in ma_noise_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_noise_init_preallocated(in ma_noise_config pConfig, void* pHeap, ma_noise* pNoise);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_noise_init(in ma_noise_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_noise* pNoise);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_noise_uninit(ma_noise* pNoise, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_noise_read_pcm_frames(ma_noise* pNoise, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_set_amplitude", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_set_amplitude", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_noise_set_amplitude(ma_noise* pNoise, double amplitude);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_set_seed", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_set_seed", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_noise_set_seed(ma_noise* pNoise, int seed);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_set_type", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_set_type", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_noise_set_type(ma_noise* pNoise, ma_noise_type type);

public enum ma_resource_manager_data_source_flags
{
    MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_STREAM = 1,
    MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_DECODE = 2,
    MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_ASYNC = 4,
    MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_WAIT_INIT = 8,
    MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_UNKNOWN_LENGTH = 16,
    MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_LOOPING = 32,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager_pipeline_stage_notification
{
    public IntPtr pNotification;
    public ma_fence* pFence;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager_pipeline_notifications
{
    public ma_resource_manager_pipeline_stage_notification init;
    public ma_resource_manager_pipeline_stage_notification done;
}
#if WEB
public static ma_resource_manager_pipeline_notifications ma_resource_manager_pipeline_notifications_init()
{
    ma_resource_manager_pipeline_notifications result = default;
    ma_resource_manager_pipeline_notifications_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_pipeline_notifications_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_pipeline_notifications_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_resource_manager_pipeline_notifications ma_resource_manager_pipeline_notifications_init();
#endif

public enum ma_resource_manager_flags
{
    MA_RESOURCE_MANAGER_FLAG_NON_BLOCKING = 1,
    MA_RESOURCE_MANAGER_FLAG_NO_THREADING = 2,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager_data_source_config
{
#if WEB
    private IntPtr _pFilePath;
    public string pFilePath { get => Marshal.PtrToStringAnsi(_pFilePath);  set { if (_pFilePath != IntPtr.Zero) { Marshal.FreeHGlobal(_pFilePath); _pFilePath = IntPtr.Zero; } if (value != null) { _pFilePath = Marshal.StringToHGlobalAnsi(value); } } }
#else
    [M(U.LPUTF8Str)] public string pFilePath;
#endif
    public IntPtr pFilePathW;
    public ma_resource_manager_pipeline_notifications* pNotifications;
    public ulong initialSeekPointInPCMFrames;
    public ulong rangeBegInPCMFrames;
    public ulong rangeEndInPCMFrames;
    public ulong loopPointBegInPCMFrames;
    public ulong loopPointEndInPCMFrames;
    public uint flags;
    public uint isLooping;
}
#if WEB
public static ma_resource_manager_data_source_config ma_resource_manager_data_source_config_init()
{
    ma_resource_manager_data_source_config result = default;
    ma_resource_manager_data_source_config_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_resource_manager_data_source_config ma_resource_manager_data_source_config_init();
#endif

public enum ma_resource_manager_data_supply_type
{
    ma_resource_manager_data_supply_type_unknown = 0,
    ma_resource_manager_data_supply_type_encoded,
    ma_resource_manager_data_supply_type_decoded,
    ma_resource_manager_data_supply_type_decoded_paged,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager_data_supply
{
    public ma_resource_manager_data_supply_type type;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager_data_buffer_node
{
    public uint hashedName32;
    public uint refCount;
    public ma_result result;
    public uint executionCounter;
    public uint executionPointer;
    public uint isDataOwnedByResourceManager;
    public ma_resource_manager_data_supply data;
    public ma_resource_manager_data_buffer_node* pParent;
    public ma_resource_manager_data_buffer_node* pChildLo;
    public ma_resource_manager_data_buffer_node* pChildHi;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager_data_buffer
{
    public ma_data_source_base ds;
    public ma_resource_manager* pResourceManager;
    public ma_resource_manager_data_buffer_node* pNode;
    public uint flags;
    public uint executionCounter;
    public uint executionPointer;
    public ulong seekTargetInPCMFrames;
    public uint seekToCursorOnNextRead;
    public ma_result result;
    public uint isLooping;
    public ma_atomic_bool32 isConnectorInitialized;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager_data_stream
{
    public ma_data_source_base ds;
    public ma_resource_manager* pResourceManager;
    public uint flags;
    public ma_decoder decoder;
    public uint isDecoderInitialized;
    public ulong totalLengthInPCMFrames;
    public uint relativeCursor;
    public ulong absoluteCursor;
    public uint currentPageIndex;
    public uint executionCounter;
    public uint executionPointer;
    public uint isLooping;
    public void* pPageData;
    #pragma warning disable 169
    public struct pageFrameCountCollection
    {
        public ref uint this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private uint _item0;
        private uint _item1;
    }
    #pragma warning restore 169
    public pageFrameCountCollection pageFrameCount;
    public ma_result result;
    public uint isDecoderAtEnd;
    #pragma warning disable 169
    public struct isPageValidCollection
    {
        public ref uint this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private uint _item0;
        private uint _item1;
    }
    #pragma warning restore 169
    public isPageValidCollection isPageValid;
    public uint seekCounter;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager_data_source
{
    public uint flags;
    public uint executionCounter;
    public uint executionPointer;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager_config
{
    public ma_allocation_callbacks allocationCallbacks;
    public ma_log* pLog;
    public ma_format decodedFormat;
    public uint decodedChannels;
    public uint decodedSampleRate;
    public uint jobThreadCount;
    public nuint jobThreadStackSize;
    public uint jobQueueCapacity;
    public uint flags;
    public IntPtr pVFS;
    public ma_decoding_backend_vtable** ppCustomDecodingBackendVTables;
    public uint customDecodingBackendCount;
    public void* pCustomDecodingBackendUserData;
    public ma_resampler_config resampling;
}
#if WEB
public static ma_resource_manager_config ma_resource_manager_config_init()
{
    ma_resource_manager_config result = default;
    ma_resource_manager_config_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_resource_manager_config ma_resource_manager_config_init();
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_resource_manager
{
    public ma_resource_manager_config config;
    public ma_resource_manager_data_buffer_node* pRootDataBufferNode;
    public IntPtr dataBufferBSTLock;
    #pragma warning disable 169
    public struct jobThreadsCollection
    {
        public ref IntPtr this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 64)[index];
        private IntPtr _item0;
        private IntPtr _item1;
        private IntPtr _item2;
        private IntPtr _item3;
        private IntPtr _item4;
        private IntPtr _item5;
        private IntPtr _item6;
        private IntPtr _item7;
        private IntPtr _item8;
        private IntPtr _item9;
        private IntPtr _item10;
        private IntPtr _item11;
        private IntPtr _item12;
        private IntPtr _item13;
        private IntPtr _item14;
        private IntPtr _item15;
        private IntPtr _item16;
        private IntPtr _item17;
        private IntPtr _item18;
        private IntPtr _item19;
        private IntPtr _item20;
        private IntPtr _item21;
        private IntPtr _item22;
        private IntPtr _item23;
        private IntPtr _item24;
        private IntPtr _item25;
        private IntPtr _item26;
        private IntPtr _item27;
        private IntPtr _item28;
        private IntPtr _item29;
        private IntPtr _item30;
        private IntPtr _item31;
        private IntPtr _item32;
        private IntPtr _item33;
        private IntPtr _item34;
        private IntPtr _item35;
        private IntPtr _item36;
        private IntPtr _item37;
        private IntPtr _item38;
        private IntPtr _item39;
        private IntPtr _item40;
        private IntPtr _item41;
        private IntPtr _item42;
        private IntPtr _item43;
        private IntPtr _item44;
        private IntPtr _item45;
        private IntPtr _item46;
        private IntPtr _item47;
        private IntPtr _item48;
        private IntPtr _item49;
        private IntPtr _item50;
        private IntPtr _item51;
        private IntPtr _item52;
        private IntPtr _item53;
        private IntPtr _item54;
        private IntPtr _item55;
        private IntPtr _item56;
        private IntPtr _item57;
        private IntPtr _item58;
        private IntPtr _item59;
        private IntPtr _item60;
        private IntPtr _item61;
        private IntPtr _item62;
        private IntPtr _item63;
    }
    #pragma warning restore 169
    public jobThreadsCollection jobThreads;
    public ma_job_queue jobQueue;
    public ma_default_vfs defaultVFS;
    public ma_log log;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_init(in ma_resource_manager_config pConfig, ma_resource_manager* pResourceManager);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_resource_manager_uninit(ma_resource_manager* pResourceManager);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_get_log", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_get_log", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_log* ma_resource_manager_get_log(ma_resource_manager* pResourceManager);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_register_file", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_register_file", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_register_file(ma_resource_manager* pResourceManager, [M(U.LPUTF8Str)] string pFilePath, uint flags);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_register_file_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_register_file_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_register_file_w(ma_resource_manager* pResourceManager, IntPtr pFilePath, uint flags);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_register_decoded_data", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_register_decoded_data", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_register_decoded_data(ma_resource_manager* pResourceManager, [M(U.LPUTF8Str)] string pName, void* pData, ulong frameCount, ma_format format, uint channels, uint sampleRate);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_register_decoded_data_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_register_decoded_data_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_register_decoded_data_w(ma_resource_manager* pResourceManager, IntPtr pName, void* pData, ulong frameCount, ma_format format, uint channels, uint sampleRate);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_register_encoded_data", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_register_encoded_data", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_register_encoded_data(ma_resource_manager* pResourceManager, [M(U.LPUTF8Str)] string pName, void* pData, nuint sizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_register_encoded_data_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_register_encoded_data_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_register_encoded_data_w(ma_resource_manager* pResourceManager, IntPtr pName, void* pData, nuint sizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_unregister_file", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_unregister_file", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_unregister_file(ma_resource_manager* pResourceManager, [M(U.LPUTF8Str)] string pFilePath);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_unregister_file_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_unregister_file_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_unregister_file_w(ma_resource_manager* pResourceManager, IntPtr pFilePath);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_unregister_data", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_unregister_data", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_unregister_data(ma_resource_manager* pResourceManager, [M(U.LPUTF8Str)] string pName);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_unregister_data_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_unregister_data_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_unregister_data_w(ma_resource_manager* pResourceManager, IntPtr pName);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_init_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_init_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_init_ex(ma_resource_manager* pResourceManager, in ma_resource_manager_data_source_config pConfig, ma_resource_manager_data_buffer* pDataBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_init(ma_resource_manager* pResourceManager, [M(U.LPUTF8Str)] string pFilePath, uint flags, in ma_resource_manager_pipeline_notifications pNotifications, ma_resource_manager_data_buffer* pDataBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_init_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_init_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_init_w(ma_resource_manager* pResourceManager, IntPtr pFilePath, uint flags, in ma_resource_manager_pipeline_notifications pNotifications, ma_resource_manager_data_buffer* pDataBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_init_copy", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_init_copy", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_init_copy(ma_resource_manager* pResourceManager, in ma_resource_manager_data_buffer pExistingDataBuffer, ma_resource_manager_data_buffer* pDataBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_uninit(ma_resource_manager_data_buffer* pDataBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_read_pcm_frames(ma_resource_manager_data_buffer* pDataBuffer, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_seek_to_pcm_frame(ma_resource_manager_data_buffer* pDataBuffer, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_get_data_format(ma_resource_manager_data_buffer* pDataBuffer, ref ma_format pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_get_cursor_in_pcm_frames(ma_resource_manager_data_buffer* pDataBuffer, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_get_length_in_pcm_frames(ma_resource_manager_data_buffer* pDataBuffer, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_result", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_result", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_result(in ma_resource_manager_data_buffer pDataBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_set_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_set_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_set_looping(ma_resource_manager_data_buffer* pDataBuffer, uint isLooping);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_is_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_is_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_resource_manager_data_buffer_is_looping(in ma_resource_manager_data_buffer pDataBuffer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_buffer_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_buffer_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_buffer_get_available_frames(ma_resource_manager_data_buffer* pDataBuffer, ref ulong pAvailableFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_init_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_init_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_init_ex(ma_resource_manager* pResourceManager, in ma_resource_manager_data_source_config pConfig, ma_resource_manager_data_stream* pDataStream);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_init(ma_resource_manager* pResourceManager, [M(U.LPUTF8Str)] string pFilePath, uint flags, in ma_resource_manager_pipeline_notifications pNotifications, ma_resource_manager_data_stream* pDataStream);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_init_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_init_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_init_w(ma_resource_manager* pResourceManager, IntPtr pFilePath, uint flags, in ma_resource_manager_pipeline_notifications pNotifications, ma_resource_manager_data_stream* pDataStream);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_uninit(ma_resource_manager_data_stream* pDataStream);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_read_pcm_frames(ma_resource_manager_data_stream* pDataStream, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_seek_to_pcm_frame(ma_resource_manager_data_stream* pDataStream, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_get_data_format(ma_resource_manager_data_stream* pDataStream, ref ma_format pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_get_cursor_in_pcm_frames(ma_resource_manager_data_stream* pDataStream, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_get_length_in_pcm_frames(ma_resource_manager_data_stream* pDataStream, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_result", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_result", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_result(in ma_resource_manager_data_stream pDataStream);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_set_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_set_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_set_looping(ma_resource_manager_data_stream* pDataStream, uint isLooping);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_is_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_is_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_resource_manager_data_stream_is_looping(in ma_resource_manager_data_stream pDataStream);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_stream_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_stream_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_stream_get_available_frames(ma_resource_manager_data_stream* pDataStream, ref ulong pAvailableFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_init_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_init_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_init_ex(ma_resource_manager* pResourceManager, in ma_resource_manager_data_source_config pConfig, ma_resource_manager_data_source* pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_init(ma_resource_manager* pResourceManager, [M(U.LPUTF8Str)] string pName, uint flags, in ma_resource_manager_pipeline_notifications pNotifications, ma_resource_manager_data_source* pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_init_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_init_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_init_w(ma_resource_manager* pResourceManager, IntPtr pName, uint flags, in ma_resource_manager_pipeline_notifications pNotifications, ma_resource_manager_data_source* pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_init_copy", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_init_copy", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_init_copy(ma_resource_manager* pResourceManager, in ma_resource_manager_data_source pExistingDataSource, ma_resource_manager_data_source* pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_uninit(ma_resource_manager_data_source* pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_read_pcm_frames(ma_resource_manager_data_source* pDataSource, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_seek_to_pcm_frame(ma_resource_manager_data_source* pDataSource, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_get_data_format(ma_resource_manager_data_source* pDataSource, ref ma_format pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_get_cursor_in_pcm_frames(ma_resource_manager_data_source* pDataSource, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_get_length_in_pcm_frames(ma_resource_manager_data_source* pDataSource, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_result", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_result", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_result(in ma_resource_manager_data_source pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_set_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_set_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_set_looping(ma_resource_manager_data_source* pDataSource, uint isLooping);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_is_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_is_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_resource_manager_data_source_is_looping(in ma_resource_manager_data_source pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_get_available_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_data_source_get_available_frames(ma_resource_manager_data_source* pDataSource, ref ulong pAvailableFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_post_job", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_post_job", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_post_job(ma_resource_manager* pResourceManager, in ma_job pJob);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_post_job_quit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_post_job_quit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_post_job_quit(ma_resource_manager* pResourceManager);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_next_job", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_next_job", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_next_job(ma_resource_manager* pResourceManager, ma_job* pJob);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_process_job", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_process_job", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_process_job(ma_resource_manager* pResourceManager, ma_job* pJob);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_process_next_job", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_process_next_job", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_resource_manager_process_next_job(ma_resource_manager* pResourceManager);

[StructLayout(LayoutKind.Sequential)]
public struct ma_stack
{
    public nuint offset;
    public nuint sizeInBytes;
    #pragma warning disable 169
    public struct _dataCollection
    {
        public ref byte this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 1)[index];
        private byte _item0;
    }
    #pragma warning restore 169
    public _dataCollection _data;
}
public enum ma_node_flags
{
    MA_NODE_FLAG_PASSTHROUGH = 1,
    MA_NODE_FLAG_CONTINUOUS_PROCESSING = 2,
    MA_NODE_FLAG_ALLOW_NULL_INPUT = 4,
    MA_NODE_FLAG_DIFFERENT_PROCESSING_RATES = 8,
    MA_NODE_FLAG_SILENT_OUTPUT = 16,
}
public enum ma_node_state
{
    ma_node_state_started = 0,
    ma_node_state_stopped = 1,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_node_vtable
{
    public delegate* unmanaged<IntPtr, void*, uint*, void*, uint*, void> onProcess;
    public delegate* unmanaged<IntPtr, uint, uint*, void*> onGetRequiredInputFrameCount;
    public byte inputBusCount;
    public byte outputBusCount;
    public uint flags;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_node_config
{
    public ma_node_vtable* vtable;
    public ma_node_state initialState;
    public uint inputBusCount;
    public uint outputBusCount;
    public uint* pInputChannels;
    public uint* pOutputChannels;
}
#if WEB
public static ma_node_config ma_node_config_init()
{
    ma_node_config result = default;
    ma_node_config_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_node_config ma_node_config_init();
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_node_output_bus
{
    public IntPtr pNode;
    public byte outputBusIndex;
    public byte channels;
    public byte inputNodeInputBusIndex;
    public uint flags;
    public uint refCount;
    public uint isAttached;
    public uint dolock;
    public float volume;
    public ma_node_output_bus* pNext;
    public ma_node_output_bus* pPrev;
    public IntPtr pInputNode;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_node_input_bus
{
    public ma_node_output_bus head;
    public uint nextCounter;
    public uint dolock;
    public byte channels;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_node_base
{
    public ma_node_graph* pNodeGraph;
    public ma_node_vtable* vtable;
    public uint inputBusCount;
    public uint outputBusCount;
    public ma_node_input_bus* pInputBuses;
    public ma_node_output_bus* pOutputBuses;
    public float* pCachedData;
    public ushort cachedDataCapInFramesPerBus;
    public ushort cachedFrameCountOut;
    public ushort cachedFrameCountIn;
    public ushort consumedFrameCountIn;
    public ma_node_state state;
    #pragma warning disable 169
    public struct stateTimesCollection
    {
        public ref ulong this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private ulong _item0;
        private ulong _item1;
    }
    #pragma warning restore 169
    public stateTimesCollection stateTimes;
    public ulong localTime;
    #pragma warning disable 169
    public struct _inputBusesCollection
    {
        public ref ma_node_input_bus this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private ma_node_input_bus _item0;
        private ma_node_input_bus _item1;
    }
    #pragma warning restore 169
    public _inputBusesCollection _inputBuses;
    #pragma warning disable 169
    public struct _outputBusesCollection
    {
        public ref ma_node_output_bus this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 2)[index];
        private ma_node_output_bus _item0;
        private ma_node_output_bus _item1;
    }
    #pragma warning restore 169
    public _outputBusesCollection _outputBuses;
    public void* _pHeap;
    public uint _ownsHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_get_heap_size(ma_node_graph* pNodeGraph, in ma_node_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_init_preallocated(ma_node_graph* pNodeGraph, in ma_node_config pConfig, void* pHeap, IntPtr pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_init(ma_node_graph* pNodeGraph, in ma_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, IntPtr pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_node_uninit(IntPtr pNode, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_node_graph", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_node_graph", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_node_graph* ma_node_get_node_graph(IntPtr pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_input_bus_count", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_input_bus_count", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_node_get_input_bus_count(IntPtr pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_output_bus_count", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_output_bus_count", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_node_get_output_bus_count(IntPtr pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_input_channels", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_input_channels", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_node_get_input_channels(IntPtr pNode, uint inputBusIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_output_channels", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_output_channels", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_node_get_output_channels(IntPtr pNode, uint outputBusIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_attach_output_bus", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_attach_output_bus", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_attach_output_bus(IntPtr pNode, uint outputBusIndex, IntPtr pOtherNode, uint otherNodeInputBusIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_detach_output_bus", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_detach_output_bus", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_detach_output_bus(IntPtr pNode, uint outputBusIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_detach_all_output_buses", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_detach_all_output_buses", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_detach_all_output_buses(IntPtr pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_set_output_bus_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_set_output_bus_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_set_output_bus_volume(IntPtr pNode, uint outputBusIndex, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_output_bus_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_output_bus_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_node_get_output_bus_volume(IntPtr pNode, uint outputBusIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_set_state", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_set_state", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_set_state(IntPtr pNode, ma_node_state state);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_state", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_state", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_node_state ma_node_get_state(IntPtr pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_set_state_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_set_state_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_set_state_time(IntPtr pNode, ma_node_state state, ulong globalTime);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_state_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_state_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_node_get_state_time(IntPtr pNode, ma_node_state state);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_state_by_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_state_by_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_node_state ma_node_get_state_by_time(IntPtr pNode, ulong globalTime);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_state_by_time_range", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_state_by_time_range", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_node_state ma_node_get_state_by_time_range(IntPtr pNode, ulong globalTimeBeg, ulong globalTimeEnd);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_get_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_get_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_node_get_time(IntPtr pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_set_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_set_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_set_time(IntPtr pNode, ulong localTime);

[StructLayout(LayoutKind.Sequential)]
public struct ma_node_graph_config
{
    public uint channels;
    public uint processingSizeInFrames;
    public nuint preMixStackSizeInBytes;
}
#if WEB
public static ma_node_graph_config ma_node_graph_config_init(uint channels)
{
    ma_node_graph_config result = default;
    ma_node_graph_config_init_internal(ref result, channels);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_node_graph_config ma_node_graph_config_init(uint channels);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_node_graph
{
    public ma_node_base _base;
    public ma_node_base endpoint;
    public float* pProcessingCache;
    public uint processingCacheFramesRemaining;
    public uint processingSizeInFrames;
    public uint isReading;
    public ma_stack* pPreMixStack;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_graph_init(in ma_node_graph_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_node_graph* pNodeGraph);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_node_graph_uninit(ma_node_graph* pNodeGraph, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_get_endpoint", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_get_endpoint", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern IntPtr ma_node_graph_get_endpoint(ma_node_graph* pNodeGraph);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_graph_read_pcm_frames(ma_node_graph* pNodeGraph, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_get_channels", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_get_channels", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_node_graph_get_channels(in ma_node_graph pNodeGraph);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_get_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_get_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_node_graph_get_time(in ma_node_graph pNodeGraph);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_set_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_set_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_node_graph_set_time(ma_node_graph* pNodeGraph, ulong globalTime);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_get_processing_size_in_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_get_processing_size_in_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_node_graph_get_processing_size_in_frames(in ma_node_graph pNodeGraph);

[StructLayout(LayoutKind.Sequential)]
public struct ma_data_source_node_config
{
    public ma_node_config nodeConfig;
    public IntPtr pDataSource;
}
#if WEB
public static ma_data_source_node_config ma_data_source_node_config_init(IntPtr pDataSource)
{
    ma_data_source_node_config result = default;
    ma_data_source_node_config_init_internal(ref result, pDataSource);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_data_source_node_config ma_data_source_node_config_init(IntPtr pDataSource);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_data_source_node
{
    public ma_node_base _base;
    public IntPtr pDataSource;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_node_init(ma_node_graph* pNodeGraph, in ma_data_source_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_data_source_node* pDataSourceNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_data_source_node_uninit(ma_data_source_node* pDataSourceNode, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_node_set_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_node_set_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_data_source_node_set_looping(ma_data_source_node* pDataSourceNode, uint isLooping);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_node_is_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_node_is_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_data_source_node_is_looping(ma_data_source_node* pDataSourceNode);

[StructLayout(LayoutKind.Sequential)]
public struct ma_splitter_node_config
{
    public ma_node_config nodeConfig;
    public uint channels;
    public uint outputBusCount;
}
#if WEB
public static ma_splitter_node_config ma_splitter_node_config_init(uint channels)
{
    ma_splitter_node_config result = default;
    ma_splitter_node_config_init_internal(ref result, channels);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_splitter_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_splitter_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_splitter_node_config ma_splitter_node_config_init(uint channels);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_splitter_node
{
    public ma_node_base _base;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_splitter_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_splitter_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_splitter_node_init(ma_node_graph* pNodeGraph, in ma_splitter_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_splitter_node* pSplitterNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_splitter_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_splitter_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_splitter_node_uninit(ma_splitter_node* pSplitterNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_biquad_node_config
{
    public ma_node_config nodeConfig;
    public ma_biquad_config biquad;
}
#if WEB
public static ma_biquad_node_config ma_biquad_node_config_init(uint channels, float b0, float b1, float b2, float a0, float a1, float a2)
{
    ma_biquad_node_config result = default;
    ma_biquad_node_config_init_internal(ref result, channels, b0, b1, b2, a0, a1, a2);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_biquad_node_config ma_biquad_node_config_init(uint channels, float b0, float b1, float b2, float a0, float a1, float a2);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_biquad_node
{
    public ma_node_base baseNode;
    public ma_biquad biquad;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_biquad_node_init(ma_node_graph* pNodeGraph, in ma_biquad_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_biquad_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_biquad_node_reinit(in ma_biquad_config pConfig, ma_biquad_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_biquad_node_uninit(ma_biquad_node* pNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_lpf_node_config
{
    public ma_node_config nodeConfig;
    public ma_lpf_config lpf;
}
#if WEB
public static ma_lpf_node_config ma_lpf_node_config_init(uint channels, uint sampleRate, double cutoffFrequency, uint order)
{
    ma_lpf_node_config result = default;
    ma_lpf_node_config_init_internal(ref result, channels, sampleRate, cutoffFrequency, order);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_lpf_node_config ma_lpf_node_config_init(uint channels, uint sampleRate, double cutoffFrequency, uint order);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_lpf_node
{
    public ma_node_base baseNode;
    public ma_lpf lpf;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf_node_init(ma_node_graph* pNodeGraph, in ma_lpf_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_lpf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_lpf_node_reinit(in ma_lpf_config pConfig, ma_lpf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_lpf_node_uninit(ma_lpf_node* pNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_hpf_node_config
{
    public ma_node_config nodeConfig;
    public ma_hpf_config hpf;
}
#if WEB
public static ma_hpf_node_config ma_hpf_node_config_init(uint channels, uint sampleRate, double cutoffFrequency, uint order)
{
    ma_hpf_node_config result = default;
    ma_hpf_node_config_init_internal(ref result, channels, sampleRate, cutoffFrequency, order);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_hpf_node_config ma_hpf_node_config_init(uint channels, uint sampleRate, double cutoffFrequency, uint order);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_hpf_node
{
    public ma_node_base baseNode;
    public ma_hpf hpf;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf_node_init(ma_node_graph* pNodeGraph, in ma_hpf_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_hpf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hpf_node_reinit(in ma_hpf_config pConfig, ma_hpf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hpf_node_uninit(ma_hpf_node* pNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_bpf_node_config
{
    public ma_node_config nodeConfig;
    public ma_bpf_config bpf;
}
#if WEB
public static ma_bpf_node_config ma_bpf_node_config_init(uint channels, uint sampleRate, double cutoffFrequency, uint order)
{
    ma_bpf_node_config result = default;
    ma_bpf_node_config_init_internal(ref result, channels, sampleRate, cutoffFrequency, order);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_bpf_node_config ma_bpf_node_config_init(uint channels, uint sampleRate, double cutoffFrequency, uint order);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_bpf_node
{
    public ma_node_base baseNode;
    public ma_bpf bpf;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf_node_init(ma_node_graph* pNodeGraph, in ma_bpf_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_bpf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_bpf_node_reinit(in ma_bpf_config pConfig, ma_bpf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_bpf_node_uninit(ma_bpf_node* pNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_notch_node_config
{
    public ma_node_config nodeConfig;
    public ma_notch2_config notch;
}
#if WEB
public static ma_notch_node_config ma_notch_node_config_init(uint channels, uint sampleRate, double q, double frequency)
{
    ma_notch_node_config result = default;
    ma_notch_node_config_init_internal(ref result, channels, sampleRate, q, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_notch_node_config ma_notch_node_config_init(uint channels, uint sampleRate, double q, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_notch_node
{
    public ma_node_base baseNode;
    public ma_notch2 notch;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_notch_node_init(ma_node_graph* pNodeGraph, in ma_notch_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_notch_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_notch_node_reinit(in ma_notch2_config pConfig, ma_notch_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_notch_node_uninit(ma_notch_node* pNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_peak_node_config
{
    public ma_node_config nodeConfig;
    public ma_peak2_config peak;
}
#if WEB
public static ma_peak_node_config ma_peak_node_config_init(uint channels, uint sampleRate, double gainDB, double q, double frequency)
{
    ma_peak_node_config result = default;
    ma_peak_node_config_init_internal(ref result, channels, sampleRate, gainDB, q, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_peak_node_config ma_peak_node_config_init(uint channels, uint sampleRate, double gainDB, double q, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_peak_node
{
    public ma_node_base baseNode;
    public ma_peak2 peak;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_peak_node_init(ma_node_graph* pNodeGraph, in ma_peak_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_peak_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_peak_node_reinit(in ma_peak2_config pConfig, ma_peak_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_peak_node_uninit(ma_peak_node* pNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_loshelf_node_config
{
    public ma_node_config nodeConfig;
    public ma_loshelf2_config loshelf;
}
#if WEB
public static ma_loshelf_node_config ma_loshelf_node_config_init(uint channels, uint sampleRate, double gainDB, double q, double frequency)
{
    ma_loshelf_node_config result = default;
    ma_loshelf_node_config_init_internal(ref result, channels, sampleRate, gainDB, q, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_loshelf_node_config ma_loshelf_node_config_init(uint channels, uint sampleRate, double gainDB, double q, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_loshelf_node
{
    public ma_node_base baseNode;
    public ma_loshelf2 loshelf;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_loshelf_node_init(ma_node_graph* pNodeGraph, in ma_loshelf_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_loshelf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_loshelf_node_reinit(in ma_loshelf2_config pConfig, ma_loshelf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_loshelf_node_uninit(ma_loshelf_node* pNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_hishelf_node_config
{
    public ma_node_config nodeConfig;
    public ma_hishelf2_config hishelf;
}
#if WEB
public static ma_hishelf_node_config ma_hishelf_node_config_init(uint channels, uint sampleRate, double gainDB, double q, double frequency)
{
    ma_hishelf_node_config result = default;
    ma_hishelf_node_config_init_internal(ref result, channels, sampleRate, gainDB, q, frequency);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_hishelf_node_config ma_hishelf_node_config_init(uint channels, uint sampleRate, double gainDB, double q, double frequency);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_hishelf_node
{
    public ma_node_base baseNode;
    public ma_hishelf2 hishelf;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hishelf_node_init(ma_node_graph* pNodeGraph, in ma_hishelf_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_hishelf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf_node_reinit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_hishelf_node_reinit(in ma_hishelf2_config pConfig, ma_hishelf_node* pNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hishelf_node_uninit(ma_hishelf_node* pNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_delay_node_config
{
    public ma_node_config nodeConfig;
    public ma_delay_config delay;
}
#if WEB
public static ma_delay_node_config ma_delay_node_config_init(uint channels, uint sampleRate, uint delayInFrames, float decay)
{
    ma_delay_node_config result = default;
    ma_delay_node_config_init_internal(ref result, channels, sampleRate, delayInFrames, decay);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_delay_node_config ma_delay_node_config_init(uint channels, uint sampleRate, uint delayInFrames, float decay);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_delay_node
{
    public ma_node_base baseNode;
    public ma_delay delay;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_delay_node_init(ma_node_graph* pNodeGraph, in ma_delay_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_delay_node* pDelayNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_node_uninit(ma_delay_node* pDelayNode, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_set_wet", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_set_wet", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_node_set_wet(ma_delay_node* pDelayNode, float value);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_get_wet", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_get_wet", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_delay_node_get_wet(in ma_delay_node pDelayNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_set_dry", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_set_dry", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_node_set_dry(ma_delay_node* pDelayNode, float value);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_get_dry", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_get_dry", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_delay_node_get_dry(in ma_delay_node pDelayNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_set_decay", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_set_decay", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_node_set_decay(ma_delay_node* pDelayNode, float value);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_get_decay", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_get_decay", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_delay_node_get_decay(in ma_delay_node pDelayNode);

public enum ma_sound_flags
{
    MA_SOUND_FLAG_STREAM = 1,
    MA_SOUND_FLAG_DECODE = 2,
    MA_SOUND_FLAG_ASYNC = 4,
    MA_SOUND_FLAG_WAIT_INIT = 8,
    MA_SOUND_FLAG_UNKNOWN_LENGTH = 16,
    MA_SOUND_FLAG_LOOPING = 32,
    MA_SOUND_FLAG_NO_DEFAULT_ATTACHMENT = 4096,
    MA_SOUND_FLAG_NO_PITCH = 8192,
    MA_SOUND_FLAG_NO_SPATIALIZATION = 16384,
}
public enum ma_engine_node_type
{
    ma_engine_node_type_sound,
    ma_engine_node_type_group,
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_engine_node_config
{
    public ma_engine* pEngine;
    public ma_engine_node_type type;
    public uint channelsIn;
    public uint channelsOut;
    public uint sampleRate;
    public uint volumeSmoothTimeInPCMFrames;
    public ma_mono_expansion_mode monoExpansionMode;
    public byte isPitchDisabled;
    public byte isSpatializationDisabled;
    public byte pinnedListenerIndex;
    public ma_resampler_config resampling;
}
#if WEB
public static ma_engine_node_config ma_engine_node_config_init(ma_engine* pEngine, ma_engine_node_type type, uint flags)
{
    ma_engine_node_config result = default;
    ma_engine_node_config_init_internal(ref result, pEngine, type, flags);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_node_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_engine_node_config ma_engine_node_config_init(ma_engine* pEngine, ma_engine_node_type type, uint flags);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_engine_node
{
    public ma_node_base baseNode;
    public ma_engine* pEngine;
    public uint sampleRate;
    public uint volumeSmoothTimeInPCMFrames;
    public ma_mono_expansion_mode monoExpansionMode;
    public ma_fader fader;
    public ma_resampler resampler;
    public ma_spatializer spatializer;
    public ma_panner panner;
    public ma_gainer volumeGainer;
    public ma_atomic_float volume;
    public float pitch;
    public float oldPitch;
    public float oldDopplerPitch;
    public uint isPitchDisabled;
    public uint isSpatializationDisabled;
    public uint pinnedListenerIndex;
    public struct _fadeSettings_e__Struct {
        public ma_atomic_float volumeBeg;
        public ma_atomic_float volumeEnd;
        public ma_atomic_uint64 fadeLengthInFrames;
        public ma_atomic_uint64 absoluteGlobalTimeInFrames;
    }
    public _fadeSettings_e__Struct fadeSettings;
    public byte _ownsHeap;
    public void* _pHeap;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_node_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_node_get_heap_size", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_node_get_heap_size(in ma_engine_node_config pConfig, ref nuint pHeapSizeInBytes);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_node_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_node_init_preallocated", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_node_init_preallocated(in ma_engine_node_config pConfig, void* pHeap, ma_engine_node* pEngineNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_node_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_node_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_node_init(in ma_engine_node_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_engine_node* pEngineNode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_node_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_node_uninit(ma_engine_node* pEngineNode, in ma_allocation_callbacks pAllocationCallbacks);

[StructLayout(LayoutKind.Sequential)]
public struct ma_sound_config
{
#if WEB
    private IntPtr _pFilePath;
    public string pFilePath { get => Marshal.PtrToStringAnsi(_pFilePath);  set { if (_pFilePath != IntPtr.Zero) { Marshal.FreeHGlobal(_pFilePath); _pFilePath = IntPtr.Zero; } if (value != null) { _pFilePath = Marshal.StringToHGlobalAnsi(value); } } }
#else
    [M(U.LPUTF8Str)] public string pFilePath;
#endif
    public IntPtr pFilePathW;
    public IntPtr pDataSource;
    public IntPtr pInitialAttachment;
    public uint initialAttachmentInputBusIndex;
    public uint channelsIn;
    public uint channelsOut;
    public ma_mono_expansion_mode monoExpansionMode;
    public uint flags;
    public uint volumeSmoothTimeInPCMFrames;
    public ulong initialSeekPointInPCMFrames;
    public ulong rangeBegInPCMFrames;
    public ulong rangeEndInPCMFrames;
    public ulong loopPointBegInPCMFrames;
    public ulong loopPointEndInPCMFrames;
    public IntPtr endCallback;
    public void* pEndCallbackUserData;
    public ma_resampler_config pitchResampling;
    public ma_resource_manager_pipeline_notifications initNotifications;
    public ma_fence* pDoneFence;
    public uint isLooping;
}
#if WEB
public static ma_sound_config ma_sound_config_init()
{
    ma_sound_config result = default;
    ma_sound_config_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_sound_config ma_sound_config_init();
#endif

#if WEB
public static ma_sound_config ma_sound_config_init_2(ma_engine* pEngine)
{
    ma_sound_config result = default;
    ma_sound_config_init_2_internal(ref result, pEngine);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_config_init_2", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_config_init_2", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_sound_config ma_sound_config_init_2(ma_engine* pEngine);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_sound
{
    public ma_engine_node engineNode;
    public IntPtr pDataSource;
    public ulong seekTarget;
    public uint atEnd;
    public IntPtr endCallback;
    public void* pEndCallbackUserData;
    public float* pProcessingCache;
    public uint processingCacheFramesRemaining;
    public uint processingCacheCap;
    public byte ownsDataSource;
    public ma_resource_manager_data_source* pResourceManagerDataSource;
}
[StructLayout(LayoutKind.Sequential)]
public struct ma_sound_inlined
{
    public ma_sound sound;
    public ma_sound_inlined* pNext;
    public ma_sound_inlined* pPrev;
}
#if WEB
public static ma_sound_config ma_sound_group_config_init()
{
    ma_sound_config result = default;
    ma_sound_group_config_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_sound_config ma_sound_group_config_init();
#endif

#if WEB
public static ma_sound_config ma_sound_group_config_init_2(ma_engine* pEngine)
{
    ma_sound_config result = default;
    ma_sound_group_config_init_2_internal(ref result, pEngine);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_config_init_2", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_config_init_2", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_sound_config ma_sound_group_config_init_2(ma_engine* pEngine);
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_engine_config
{
    public ma_resource_manager* pResourceManager;
    public ma_context* pContext;
    public ma_device* pDevice;
    public ma_device_id* pPlaybackDeviceID;
    public IntPtr dataCallback;
    public IntPtr notificationCallback;
    public ma_log* pLog;
    public uint listenerCount;
    public uint channels;
    public uint sampleRate;
    public uint periodSizeInFrames;
    public uint periodSizeInMilliseconds;
    public uint gainSmoothTimeInFrames;
    public uint gainSmoothTimeInMilliseconds;
    public uint defaultVolumeSmoothTimeInPCMFrames;
    public uint preMixStackSizeInBytes;
    public ma_allocation_callbacks allocationCallbacks;
    public uint noAutoStart;
    public uint noDevice;
    public ma_mono_expansion_mode monoExpansionMode;
    public IntPtr pResourceManagerVFS;
    public delegate* unmanaged<void*, float*, ulong, void> onProcess;
    public void* pProcessUserData;
    public ma_resampler_config resourceManagerResampling;
    public ma_resampler_config pitchResampling;
}
#if WEB
public static ma_engine_config ma_engine_config_init()
{
    ma_engine_config result = default;
    ma_engine_config_init_internal(ref result);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_config_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_config_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_engine_config ma_engine_config_init();
#endif

[StructLayout(LayoutKind.Sequential)]
public struct ma_engine
{
    public ma_node_graph nodeGraph;
    public ma_resource_manager* pResourceManager;
    public ma_device* pDevice;
    public ma_log* pLog;
    public uint sampleRate;
    public uint listenerCount;
    #pragma warning disable 169
    public struct listenersCollection
    {
        public ref ma_spatializer_listener this[int index] => ref MemoryMarshal.CreateSpan(ref _item0, 4)[index];
        private ma_spatializer_listener _item0;
        private ma_spatializer_listener _item1;
        private ma_spatializer_listener _item2;
        private ma_spatializer_listener _item3;
    }
    #pragma warning restore 169
    public listenersCollection listeners;
    public ma_allocation_callbacks allocationCallbacks;
    public byte ownsResourceManager;
    public byte ownsDevice;
    public uint inlinedSoundLock;
    public ma_sound_inlined* pInlinedSoundHead;
    public uint inlinedSoundCount;
    public uint gainSmoothTimeInFrames;
    public uint defaultVolumeSmoothTimeInPCMFrames;
    public ma_mono_expansion_mode monoExpansionMode;
    public delegate* unmanaged<void*, float*, ulong, void> onProcess;
    public void* pProcessUserData;
    public ma_resampler_config pitchResamplingConfig;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_init(in ma_engine_config pConfig, ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_uninit(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_read_pcm_frames(ma_engine* pEngine, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_node_graph", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_node_graph", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_node_graph* ma_engine_get_node_graph(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_resource_manager", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_resource_manager", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_resource_manager* ma_engine_get_resource_manager(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_device", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_device", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_device* ma_engine_get_device(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_log", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_log", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_log* ma_engine_get_log(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_endpoint", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_endpoint", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern IntPtr ma_engine_get_endpoint(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_engine_get_time_in_pcm_frames(in ma_engine pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_engine_get_time_in_milliseconds(in ma_engine pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_set_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_set_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_set_time_in_pcm_frames(ma_engine* pEngine, ulong globalTime);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_set_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_set_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_set_time_in_milliseconds(ma_engine* pEngine, ulong globalTime);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_engine_get_time(in ma_engine pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_set_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_set_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_set_time(ma_engine* pEngine, ulong globalTime);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_channels", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_channels", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_engine_get_channels(in ma_engine pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_sample_rate", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_engine_get_sample_rate(in ma_engine pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_start", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_start", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_start(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_stop", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_stop", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_stop(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_set_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_set_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_set_volume(ma_engine* pEngine, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_engine_get_volume(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_set_gain_db", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_set_gain_db", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_set_gain_db(ma_engine* pEngine, float gainDB);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_gain_db", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_gain_db", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_engine_get_gain_db(ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_get_listener_count", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_get_listener_count", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_engine_get_listener_count(in ma_engine pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_find_closest_listener", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_find_closest_listener", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_engine_find_closest_listener(in ma_engine pEngine, float absolutePosX, float absolutePosY, float absolutePosZ);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_set_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_set_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_set_position(ma_engine* pEngine, uint listenerIndex, float x, float y, float z);

#if WEB
public static ma_vec3f ma_engine_listener_get_position(in ma_engine pEngine, uint listenerIndex)
{
    ma_vec3f result = default;
    ma_engine_listener_get_position_internal(ref result, pEngine, listenerIndex);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_get_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_get_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_engine_listener_get_position(in ma_engine pEngine, uint listenerIndex);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_set_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_set_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_set_direction(ma_engine* pEngine, uint listenerIndex, float x, float y, float z);

#if WEB
public static ma_vec3f ma_engine_listener_get_direction(in ma_engine pEngine, uint listenerIndex)
{
    ma_vec3f result = default;
    ma_engine_listener_get_direction_internal(ref result, pEngine, listenerIndex);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_get_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_get_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_engine_listener_get_direction(in ma_engine pEngine, uint listenerIndex);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_set_velocity(ma_engine* pEngine, uint listenerIndex, float x, float y, float z);

#if WEB
public static ma_vec3f ma_engine_listener_get_velocity(in ma_engine pEngine, uint listenerIndex)
{
    ma_vec3f result = default;
    ma_engine_listener_get_velocity_internal(ref result, pEngine, listenerIndex);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_engine_listener_get_velocity(in ma_engine pEngine, uint listenerIndex);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_set_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_set_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_set_cone(ma_engine* pEngine, uint listenerIndex, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_get_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_get_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_get_cone(in ma_engine pEngine, uint listenerIndex, ref float pInnerAngleInRadians, ref float pOuterAngleInRadians, ref float pOuterGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_set_world_up", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_set_world_up", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_set_world_up(ma_engine* pEngine, uint listenerIndex, float x, float y, float z);

#if WEB
public static ma_vec3f ma_engine_listener_get_world_up(in ma_engine pEngine, uint listenerIndex)
{
    ma_vec3f result = default;
    ma_engine_listener_get_world_up_internal(ref result, pEngine, listenerIndex);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_get_world_up", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_get_world_up", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_engine_listener_get_world_up(in ma_engine pEngine, uint listenerIndex);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_set_enabled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_set_enabled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_set_enabled(ma_engine* pEngine, uint listenerIndex, uint isEnabled);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_is_enabled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_is_enabled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_engine_listener_is_enabled(in ma_engine pEngine, uint listenerIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_play_sound_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_play_sound_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_play_sound_ex(ma_engine* pEngine, [M(U.LPUTF8Str)] string pFilePath, IntPtr pNode, uint nodeInputBusIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_play_sound", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_play_sound", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_engine_play_sound(ma_engine* pEngine, [M(U.LPUTF8Str)] string pFilePath, ma_sound* pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_init_from_file", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_init_from_file", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_init_from_file(ma_engine* pEngine, [M(U.LPUTF8Str)] string pFilePath, uint flags, ma_sound* pGroup, ma_fence* pDoneFence, ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_init_from_file_w", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_init_from_file_w", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_init_from_file_w(ma_engine* pEngine, IntPtr pFilePath, uint flags, ma_sound* pGroup, ma_fence* pDoneFence, ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_init_copy", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_init_copy", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_init_copy(ma_engine* pEngine, in ma_sound pExistingSound, uint flags, ma_sound* pGroup, ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_init_from_data_source", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_init_from_data_source", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_init_from_data_source(ma_engine* pEngine, IntPtr pDataSource, uint flags, ma_sound* pGroup, ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_init_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_init_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_init_ex(ma_engine* pEngine, in ma_sound_config pConfig, ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_uninit(ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_engine", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_engine", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_engine* ma_sound_get_engine(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_data_source", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_data_source", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern IntPtr ma_sound_get_data_source(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_start", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_start", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_start(ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_stop", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_stop", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_stop(ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_stop_with_fade_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_stop_with_fade_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_stop_with_fade_in_pcm_frames(ma_sound* pSound, ulong fadeLengthInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_stop_with_fade_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_stop_with_fade_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_stop_with_fade_in_milliseconds(ma_sound* pSound, ulong fadeLengthInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_reset_start_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_reset_start_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_reset_start_time(ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_reset_stop_time", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_reset_stop_time", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_reset_stop_time(ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_reset_fade", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_reset_fade", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_reset_fade(ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_reset_stop_time_and_fade", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_reset_stop_time_and_fade", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_reset_stop_time_and_fade(ma_sound* pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_volume(ma_sound* pSound, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_volume(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_pan", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_pan", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_pan(ma_sound* pSound, float pan);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_pan", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_pan", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_pan(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_pan_mode", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_pan_mode", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_pan_mode(ma_sound* pSound, ma_pan_mode panMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_pan_mode", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_pan_mode", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_pan_mode ma_sound_get_pan_mode(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_pitch", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_pitch", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_pitch(ma_sound* pSound, float pitch);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_pitch", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_pitch", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_pitch(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_spatialization_enabled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_spatialization_enabled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_spatialization_enabled(ma_sound* pSound, uint enabled);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_is_spatialization_enabled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_is_spatialization_enabled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_is_spatialization_enabled(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_pinned_listener_index", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_pinned_listener_index", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_pinned_listener_index(ma_sound* pSound, uint listenerIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_pinned_listener_index", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_pinned_listener_index", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_get_pinned_listener_index(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_listener_index", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_listener_index", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_get_listener_index(in ma_sound pSound);

#if WEB
public static ma_vec3f ma_sound_get_direction_to_listener(in ma_sound pSound)
{
    ma_vec3f result = default;
    ma_sound_get_direction_to_listener_internal(ref result, pSound);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_direction_to_listener", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_direction_to_listener", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_sound_get_direction_to_listener(in ma_sound pSound);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_position(ma_sound* pSound, float x, float y, float z);

#if WEB
public static ma_vec3f ma_sound_get_position(in ma_sound pSound)
{
    ma_vec3f result = default;
    ma_sound_get_position_internal(ref result, pSound);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_sound_get_position(in ma_sound pSound);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_direction(ma_sound* pSound, float x, float y, float z);

#if WEB
public static ma_vec3f ma_sound_get_direction(in ma_sound pSound)
{
    ma_vec3f result = default;
    ma_sound_get_direction_internal(ref result, pSound);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_sound_get_direction(in ma_sound pSound);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_velocity(ma_sound* pSound, float x, float y, float z);

#if WEB
public static ma_vec3f ma_sound_get_velocity(in ma_sound pSound)
{
    ma_vec3f result = default;
    ma_sound_get_velocity_internal(ref result, pSound);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_sound_get_velocity(in ma_sound pSound);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_attenuation_model(ma_sound* pSound, ma_attenuation_model attenuationModel);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_attenuation_model ma_sound_get_attenuation_model(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_positioning", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_positioning", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_positioning(ma_sound* pSound, ma_positioning positioning);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_positioning", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_positioning", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_positioning ma_sound_get_positioning(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_rolloff", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_rolloff", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_rolloff(ma_sound* pSound, float rolloff);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_rolloff", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_rolloff", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_rolloff(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_min_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_min_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_min_gain(ma_sound* pSound, float minGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_min_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_min_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_min_gain(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_max_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_max_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_max_gain(ma_sound* pSound, float maxGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_max_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_max_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_max_gain(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_min_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_min_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_min_distance(ma_sound* pSound, float minDistance);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_min_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_min_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_min_distance(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_max_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_max_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_max_distance(ma_sound* pSound, float maxDistance);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_max_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_max_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_max_distance(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_cone(ma_sound* pSound, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_get_cone(in ma_sound pSound, ref float pInnerAngleInRadians, ref float pOuterAngleInRadians, ref float pOuterGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_doppler_factor(ma_sound* pSound, float dopplerFactor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_doppler_factor(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_directional_attenuation_factor(ma_sound* pSound, float directionalAttenuationFactor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_directional_attenuation_factor(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_fade_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_fade_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_fade_in_pcm_frames(ma_sound* pSound, float volumeBeg, float volumeEnd, ulong fadeLengthInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_fade_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_fade_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_fade_in_milliseconds(ma_sound* pSound, float volumeBeg, float volumeEnd, ulong fadeLengthInMilliseconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_fade_start_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_fade_start_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_fade_start_in_pcm_frames(ma_sound* pSound, float volumeBeg, float volumeEnd, ulong fadeLengthInFrames, ulong absoluteGlobalTimeInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_fade_start_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_fade_start_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_fade_start_in_milliseconds(ma_sound* pSound, float volumeBeg, float volumeEnd, ulong fadeLengthInMilliseconds, ulong absoluteGlobalTimeInMilliseconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_current_fade_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_current_fade_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_get_current_fade_volume(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_start_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_start_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_start_time_in_pcm_frames(ma_sound* pSound, ulong absoluteGlobalTimeInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_start_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_start_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_start_time_in_milliseconds(ma_sound* pSound, ulong absoluteGlobalTimeInMilliseconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_stop_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_stop_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_stop_time_in_pcm_frames(ma_sound* pSound, ulong absoluteGlobalTimeInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_stop_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_stop_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_stop_time_in_milliseconds(ma_sound* pSound, ulong absoluteGlobalTimeInMilliseconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_stop_time_with_fade_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_stop_time_with_fade_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_stop_time_with_fade_in_pcm_frames(ma_sound* pSound, ulong stopAbsoluteGlobalTimeInFrames, ulong fadeLengthInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_stop_time_with_fade_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_stop_time_with_fade_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_stop_time_with_fade_in_milliseconds(ma_sound* pSound, ulong stopAbsoluteGlobalTimeInMilliseconds, ulong fadeLengthInMilliseconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_is_playing", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_is_playing", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_is_playing(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_sound_get_time_in_pcm_frames(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_sound_get_time_in_milliseconds(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_set_looping(ma_sound* pSound, uint isLooping);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_is_looping", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_is_looping", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_is_looping(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_at_end", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_at_end", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_at_end(in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_seek_to_pcm_frame(ma_sound* pSound, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_seek_to_second", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_seek_to_second", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_seek_to_second(ma_sound* pSound, float seekPointInSeconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_get_data_format(in ma_sound pSound, ref ma_format pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_get_cursor_in_pcm_frames(in ma_sound pSound, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_get_length_in_pcm_frames(in ma_sound pSound, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_cursor_in_seconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_cursor_in_seconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_get_cursor_in_seconds(in ma_sound pSound, ref float pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_length_in_seconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_length_in_seconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_get_length_in_seconds(in ma_sound pSound, ref float pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_set_end_callback", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_set_end_callback", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_set_end_callback(ma_sound* pSound, IntPtr callback, void* pUserData);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_group_init(ma_engine* pEngine, uint flags, ma_sound* pParentGroup, ma_sound* pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_init_ex", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_init_ex", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_group_init_ex(ma_engine* pEngine, in ma_sound_config pConfig, ma_sound* pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_uninit(ma_sound* pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_engine", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_engine", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_engine* ma_sound_group_get_engine(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_start", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_start", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_group_start(ma_sound* pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_stop", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_stop", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_sound_group_stop(ma_sound* pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_volume(ma_sound* pGroup, float volume);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_volume(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_pan", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_pan", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_pan(ma_sound* pGroup, float pan);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_pan", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_pan", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_pan(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_pan_mode", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_pan_mode", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_pan_mode(ma_sound* pGroup, ma_pan_mode panMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_pan_mode", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_pan_mode", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_pan_mode ma_sound_group_get_pan_mode(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_pitch", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_pitch", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_pitch(ma_sound* pGroup, float pitch);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_pitch", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_pitch", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_pitch(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_spatialization_enabled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_spatialization_enabled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_spatialization_enabled(ma_sound* pGroup, uint enabled);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_is_spatialization_enabled", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_is_spatialization_enabled", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_group_is_spatialization_enabled(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_pinned_listener_index", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_pinned_listener_index", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_pinned_listener_index(ma_sound* pGroup, uint listenerIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_pinned_listener_index", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_pinned_listener_index", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_group_get_pinned_listener_index(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_listener_index", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_listener_index", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_group_get_listener_index(in ma_sound pGroup);

#if WEB
public static ma_vec3f ma_sound_group_get_direction_to_listener(in ma_sound pGroup)
{
    ma_vec3f result = default;
    ma_sound_group_get_direction_to_listener_internal(ref result, pGroup);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_direction_to_listener", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_direction_to_listener", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_sound_group_get_direction_to_listener(in ma_sound pGroup);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_position(ma_sound* pGroup, float x, float y, float z);

#if WEB
public static ma_vec3f ma_sound_group_get_position(in ma_sound pGroup)
{
    ma_vec3f result = default;
    ma_sound_group_get_position_internal(ref result, pGroup);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_position", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_position", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_sound_group_get_position(in ma_sound pGroup);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_direction(ma_sound* pGroup, float x, float y, float z);

#if WEB
public static ma_vec3f ma_sound_group_get_direction(in ma_sound pGroup)
{
    ma_vec3f result = default;
    ma_sound_group_get_direction_internal(ref result, pGroup);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_direction", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_direction", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_sound_group_get_direction(in ma_sound pGroup);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_velocity(ma_sound* pGroup, float x, float y, float z);

#if WEB
public static ma_vec3f ma_sound_group_get_velocity(in ma_sound pGroup)
{
    ma_vec3f result = default;
    ma_sound_group_get_velocity_internal(ref result, pGroup);
    return result;
}
#else
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_velocity", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_vec3f ma_sound_group_get_velocity(in ma_sound pGroup);
#endif

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_attenuation_model(ma_sound* pGroup, ma_attenuation_model attenuationModel);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_attenuation_model", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_attenuation_model ma_sound_group_get_attenuation_model(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_positioning", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_positioning", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_positioning(ma_sound* pGroup, ma_positioning positioning);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_positioning", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_positioning", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_positioning ma_sound_group_get_positioning(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_rolloff", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_rolloff", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_rolloff(ma_sound* pGroup, float rolloff);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_rolloff", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_rolloff", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_rolloff(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_min_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_min_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_min_gain(ma_sound* pGroup, float minGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_min_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_min_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_min_gain(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_max_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_max_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_max_gain(ma_sound* pGroup, float maxGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_max_gain", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_max_gain", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_max_gain(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_min_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_min_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_min_distance(ma_sound* pGroup, float minDistance);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_min_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_min_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_min_distance(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_max_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_max_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_max_distance(ma_sound* pGroup, float maxDistance);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_max_distance", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_max_distance", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_max_distance(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_cone(ma_sound* pGroup, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_cone", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_cone", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_get_cone(in ma_sound pGroup, ref float pInnerAngleInRadians, ref float pOuterAngleInRadians, ref float pOuterGain);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_doppler_factor(ma_sound* pGroup, float dopplerFactor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_doppler_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_doppler_factor(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_directional_attenuation_factor(ma_sound* pGroup, float directionalAttenuationFactor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_directional_attenuation_factor", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_directional_attenuation_factor(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_fade_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_fade_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_fade_in_pcm_frames(ma_sound* pGroup, float volumeBeg, float volumeEnd, ulong fadeLengthInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_fade_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_fade_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_fade_in_milliseconds(ma_sound* pGroup, float volumeBeg, float volumeEnd, ulong fadeLengthInMilliseconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_current_fade_volume", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_current_fade_volume", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern float ma_sound_group_get_current_fade_volume(ma_sound* pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_start_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_start_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_start_time_in_pcm_frames(ma_sound* pGroup, ulong absoluteGlobalTimeInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_start_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_start_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_start_time_in_milliseconds(ma_sound* pGroup, ulong absoluteGlobalTimeInMilliseconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_stop_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_stop_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_stop_time_in_pcm_frames(ma_sound* pGroup, ulong absoluteGlobalTimeInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_set_stop_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_set_stop_time_in_milliseconds", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_set_stop_time_in_milliseconds(ma_sound* pGroup, ulong absoluteGlobalTimeInMilliseconds);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_is_playing", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_is_playing", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern uint ma_sound_group_is_playing(in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_time_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ulong ma_sound_group_get_time_in_pcm_frames(in ma_sound pGroup);

[StructLayout(LayoutKind.Sequential)]
public struct ma_libvorbis
{
    public ma_data_source_base ds;
    public IntPtr onRead;
    public IntPtr onSeek;
    public IntPtr onTell;
    public void* pReadSeekTellUserData;
    public ma_format format;
    public void* vf;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libvorbis_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libvorbis_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libvorbis_init(IntPtr onRead, IntPtr onSeek, IntPtr onTell, void* pReadSeekTellUserData, in ma_decoding_backend_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_libvorbis* pVorbis);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libvorbis_init_file", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libvorbis_init_file", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libvorbis_init_file([M(U.LPUTF8Str)] string pFilePath, in ma_decoding_backend_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_libvorbis* pVorbis);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libvorbis_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libvorbis_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_libvorbis_uninit(ma_libvorbis* pVorbis, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libvorbis_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libvorbis_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libvorbis_read_pcm_frames(ma_libvorbis* pVorbis, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libvorbis_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libvorbis_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libvorbis_seek_to_pcm_frame(ma_libvorbis* pVorbis, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libvorbis_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libvorbis_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libvorbis_get_data_format(ma_libvorbis* pVorbis, ref ma_format pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libvorbis_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libvorbis_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libvorbis_get_cursor_in_pcm_frames(ma_libvorbis* pVorbis, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libvorbis_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libvorbis_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libvorbis_get_length_in_pcm_frames(ma_libvorbis* pVorbis, ref ulong pLength);

[StructLayout(LayoutKind.Sequential)]
public struct ma_libopus
{
    public ma_data_source_base ds;
    public IntPtr onRead;
    public IntPtr onSeek;
    public IntPtr onTell;
    public void* pReadSeekTellUserData;
    public ma_format format;
    public void* of;
}
#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libopus_init", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libopus_init", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libopus_init(IntPtr onRead, IntPtr onSeek, IntPtr onTell, void* pReadSeekTellUserData, in ma_decoding_backend_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_libopus* pOpus);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libopus_init_file", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libopus_init_file", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libopus_init_file([M(U.LPUTF8Str)] string pFilePath, in ma_decoding_backend_config pConfig, in ma_allocation_callbacks pAllocationCallbacks, ma_libopus* pOpus);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libopus_uninit", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libopus_uninit", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_libopus_uninit(ma_libopus* pOpus, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libopus_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libopus_read_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libopus_read_pcm_frames(ma_libopus* pOpus, void* pFramesOut, ulong frameCount, ref ulong pFramesRead);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libopus_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libopus_seek_to_pcm_frame", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libopus_seek_to_pcm_frame(ma_libopus* pOpus, ulong frameIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libopus_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libopus_get_data_format", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libopus_get_data_format(ma_libopus* pOpus, ref ma_format pFormat, ref uint pChannels, ref uint pSampleRate, ref byte pChannelMap, nuint channelMapCap);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libopus_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libopus_get_cursor_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libopus_get_cursor_in_pcm_frames(ma_libopus* pOpus, ref ulong pCursor);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_libopus_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_libopus_get_length_in_pcm_frames", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern ma_result ma_libopus_get_length_in_pcm_frames(ma_libopus* pOpus, ref ulong pLength);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_log_callback_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_log_callback_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_log_callback_init_internal(ref ma_log_callback result, IntPtr onLog, void* pUserData);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_biquad_config_init_internal(ref ma_biquad_config result, ma_format format, uint channels, double b0, double b1, double b2, double a0, double a1, double a2);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf1_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf1_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_lpf1_config_init_internal(ref ma_lpf1_config result, ma_format format, uint channels, uint sampleRate, double cutoffFrequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_lpf2_config_init_internal(ref ma_lpf1_config result, ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_lpf_config_init_internal(ref ma_lpf_config result, ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf1_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf1_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hpf1_config_init_internal(ref ma_hpf1_config result, ma_format format, uint channels, uint sampleRate, double cutoffFrequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hpf2_config_init_internal(ref ma_hpf1_config result, ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hpf_config_init_internal(ref ma_hpf_config result, ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_bpf2_config_init_internal(ref ma_bpf2_config result, ma_format format, uint channels, uint sampleRate, double cutoffFrequency, double q);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_bpf_config_init_internal(ref ma_bpf_config result, ma_format format, uint channels, uint sampleRate, double cutoffFrequency, uint order);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_notch2_config_init_internal(ref ma_notch2_config result, ma_format format, uint channels, uint sampleRate, double q, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_peak2_config_init_internal(ref ma_peak2_config result, ma_format format, uint channels, uint sampleRate, double gainDB, double q, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_loshelf2_config_init_internal(ref ma_loshelf2_config result, ma_format format, uint channels, uint sampleRate, double gainDB, double shelfSlope, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf2_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hishelf2_config_init_internal(ref ma_hishelf2_config result, ma_format format, uint channels, uint sampleRate, double gainDB, double shelfSlope, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_config_init_internal(ref ma_delay_config result, uint channels, uint sampleRate, uint delayInFrames, float decay);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_gainer_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_gainer_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_gainer_config_init_internal(ref ma_gainer_config result, uint channels, uint smoothTimeInFrames);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_panner_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_panner_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_panner_config_init_internal(ref ma_panner_config result, ma_format format, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_fader_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_fader_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_fader_config_init_internal(ref ma_fader_config result, ma_format format, uint channels, uint sampleRate);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_config_init_internal(ref ma_spatializer_listener_config result, uint channelsOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_get_position_internal(ref ma_vec3f result, in ma_spatializer_listener pListener);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_get_direction_internal(ref ma_vec3f result, in ma_spatializer_listener pListener);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_get_velocity_internal(ref ma_vec3f result, in ma_spatializer_listener pListener);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_listener_get_world_up_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_listener_get_world_up_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_listener_get_world_up_internal(ref ma_vec3f result, in ma_spatializer_listener pListener);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_config_init_internal(ref ma_spatializer_config result, uint channelsIn, uint channelsOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_get_position_internal(ref ma_vec3f result, in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_get_direction_internal(ref ma_vec3f result, in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_spatializer_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_spatializer_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_spatializer_get_velocity_internal(ref ma_vec3f result, in ma_spatializer pSpatializer);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_linear_resampler_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_linear_resampler_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_linear_resampler_config_init_internal(ref ma_linear_resampler_config result, ma_format format, uint channels, uint sampleRateIn, uint sampleRateOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resampler_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resampler_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_resampler_config_init_internal(ref ma_resampler_config result, ma_format format, uint channels, uint sampleRateIn, uint sampleRateOut, ma_resample_algorithm algorithm);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_channel_converter_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_channel_converter_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_channel_converter_config_init_internal(ref ma_channel_converter_config result, ma_format format, uint channelsIn, in byte pChannelMapIn, uint channelsOut, in byte pChannelMapOut, ma_channel_mix_mode mixingMode);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_config_init_default_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_config_init_default_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_data_converter_config_init_default_internal(ref ma_data_converter_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_converter_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_converter_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_data_converter_config_init_internal(ref ma_data_converter_config result, ma_format formatIn, ma_format formatOut, uint channelsIn, uint channelsOut, uint sampleRateIn, uint sampleRateOut);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_data_source_config_init_internal(ref ma_data_source_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_audio_buffer_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_audio_buffer_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_audio_buffer_config_init_internal(ref ma_audio_buffer_config result, ma_format format, uint channels, ulong sizeInFrames, void* pData, in ma_allocation_callbacks pAllocationCallbacks);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_paged_audio_buffer_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_paged_audio_buffer_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_paged_audio_buffer_config_init_internal(ref ma_paged_audio_buffer_config result, ma_paged_audio_buffer_data* pData);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_slot_allocator_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_slot_allocator_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_slot_allocator_config_init_internal(ref ma_slot_allocator_config result, uint capacity);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_job_init_internal(ref ma_job result, ushort code);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_job_queue_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_job_queue_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_job_queue_config_init_internal(ref ma_job_queue_config result, uint flags, uint capacity);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_job_thread_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_job_thread_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_device_job_thread_config_init_internal(ref ma_device_job_thread_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_context_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_context_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_context_config_init_internal(ref ma_context_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_device_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_device_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_device_config_init_internal(ref ma_device_config result, ma_device_type deviceType);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoding_backend_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoding_backend_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_decoding_backend_config_init_internal(ref ma_decoding_backend_config result, ma_format preferredFormat, uint seekPointCount);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_decoder_config_init_internal(ref ma_decoder_config result, ma_format outputFormat, uint outputChannels, uint outputSampleRate);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_decoder_config_init_default_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_decoder_config_init_default_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_decoder_config_init_default_internal(ref ma_decoder_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_encoder_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_encoder_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_encoder_config_init_internal(ref ma_encoder_config result, ma_encoding_format encodingFormat, ma_format format, uint channels, uint sampleRate);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_waveform_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_waveform_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_waveform_config_init_internal(ref ma_waveform_config result, ma_format format, uint channels, uint sampleRate, ma_waveform_type type, double amplitude, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_pulsewave_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_pulsewave_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_pulsewave_config_init_internal(ref ma_pulsewave_config result, ma_format format, uint channels, uint sampleRate, double dutyCycle, double amplitude, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_noise_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_noise_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_noise_config_init_internal(ref ma_noise_config result, ma_format format, uint channels, ma_noise_type type, int seed, double amplitude);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_pipeline_notifications_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_pipeline_notifications_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_resource_manager_pipeline_notifications_init_internal(ref ma_resource_manager_pipeline_notifications result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_data_source_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_data_source_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_resource_manager_data_source_config_init_internal(ref ma_resource_manager_data_source_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_resource_manager_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_resource_manager_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_resource_manager_config_init_internal(ref ma_resource_manager_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_node_config_init_internal(ref ma_node_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_node_graph_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_node_graph_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_node_graph_config_init_internal(ref ma_node_graph_config result, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_data_source_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_data_source_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_data_source_node_config_init_internal(ref ma_data_source_node_config result, IntPtr pDataSource);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_splitter_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_splitter_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_splitter_node_config_init_internal(ref ma_splitter_node_config result, uint channels);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_biquad_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_biquad_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_biquad_node_config_init_internal(ref ma_biquad_node_config result, uint channels, float b0, float b1, float b2, float a0, float a1, float a2);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_lpf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_lpf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_lpf_node_config_init_internal(ref ma_lpf_node_config result, uint channels, uint sampleRate, double cutoffFrequency, uint order);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hpf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hpf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hpf_node_config_init_internal(ref ma_hpf_node_config result, uint channels, uint sampleRate, double cutoffFrequency, uint order);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_bpf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_bpf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_bpf_node_config_init_internal(ref ma_bpf_node_config result, uint channels, uint sampleRate, double cutoffFrequency, uint order);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_notch_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_notch_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_notch_node_config_init_internal(ref ma_notch_node_config result, uint channels, uint sampleRate, double q, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_peak_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_peak_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_peak_node_config_init_internal(ref ma_peak_node_config result, uint channels, uint sampleRate, double gainDB, double q, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_loshelf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_loshelf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_loshelf_node_config_init_internal(ref ma_loshelf_node_config result, uint channels, uint sampleRate, double gainDB, double q, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_hishelf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_hishelf_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_hishelf_node_config_init_internal(ref ma_hishelf_node_config result, uint channels, uint sampleRate, double gainDB, double q, double frequency);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_delay_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_delay_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_delay_node_config_init_internal(ref ma_delay_node_config result, uint channels, uint sampleRate, uint delayInFrames, float decay);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_node_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_node_config_init_internal(ref ma_engine_node_config result, ma_engine* pEngine, ma_engine_node_type type, uint flags);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_config_init_internal(ref ma_sound_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_config_init_2_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_config_init_2_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_config_init_2_internal(ref ma_sound_config result, ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_config_init_internal(ref ma_sound_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_config_init_2_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_config_init_2_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_config_init_2_internal(ref ma_sound_config result, ma_engine* pEngine);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_config_init_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_config_init_internal(ref ma_engine_config result);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_get_position_internal(ref ma_vec3f result, in ma_engine pEngine, uint listenerIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_get_direction_internal(ref ma_vec3f result, in ma_engine pEngine, uint listenerIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_get_velocity_internal(ref ma_vec3f result, in ma_engine pEngine, uint listenerIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_engine_listener_get_world_up_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_engine_listener_get_world_up_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_engine_listener_get_world_up_internal(ref ma_vec3f result, in ma_engine pEngine, uint listenerIndex);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_direction_to_listener_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_direction_to_listener_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_get_direction_to_listener_internal(ref ma_vec3f result, in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_get_position_internal(ref ma_vec3f result, in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_get_direction_internal(ref ma_vec3f result, in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_get_velocity_internal(ref ma_vec3f result, in ma_sound pSound);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_direction_to_listener_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_direction_to_listener_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_get_direction_to_listener_internal(ref ma_vec3f result, in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_position_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_get_position_internal(ref ma_vec3f result, in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_direction_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_get_direction_internal(ref ma_vec3f result, in ma_sound pGroup);

#if __IOS__
[DllImport("@rpath/miniaudio.framework/miniaudio", EntryPoint = "ma_sound_group_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#else
[DllImport("miniaudio", EntryPoint = "ma_sound_group_get_velocity_internal", CallingConvention = CallingConvention.Cdecl)]
#endif
public static extern void ma_sound_group_get_velocity_internal(ref ma_vec3f result, in ma_sound pGroup);

}
}
