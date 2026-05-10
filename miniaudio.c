// Include stb_vorbis before miniaudio.h so that miniaudio's built-in Ogg/Vorbis
// decoder is enabled (guarded by STB_VORBIS_INCLUDE_STB_VORBIS_H).
#include "extras/stb_vorbis.c"

#define MINIAUDIO_IMPLEMENTATION
#include "miniaudio.h"
