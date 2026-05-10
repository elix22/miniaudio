// Include stb_vorbis before miniaudio.h so that miniaudio's built-in Ogg/Vorbis
// decoder is enabled (guarded by STB_VORBIS_INCLUDE_STB_VORBIS_H).
#include "extras/stb_vorbis.c"

// stb_vorbis defines L, C, R and PLAYBACK_* macros without cleaning them up.
// They leak into subsequent headers (especially Windows SDK winnt.h) and cause
// syntax errors. Undef them here before including miniaudio.h.
#undef L
#undef C
#undef R
#undef PLAYBACK_MONO
#undef PLAYBACK_LEFT
#undef PLAYBACK_RIGHT

#define MINIAUDIO_IMPLEMENTATION
#include "miniaudio.h"
