cmake_minimum_required(VERSION 3.15)
project(miniaudio C)

# ── Sources ────────────────────────────────────────────────────────────────
set(MINIAUDIO_ROOT "${CMAKE_CURRENT_SOURCE_DIR}/..")

set(MINIAUDIO_SOURCES
    "${MINIAUDIO_ROOT}/miniaudio.c"
    "${MINIAUDIO_ROOT}/miniaudio_csharp_extension.c"
)

# ── Library target ──────────────────────────────────────────────────────────
# iOS and Emscripten produce static libs; all other platforms produce shared libs.
if(CMAKE_SYSTEM_NAME STREQUAL "iOS" OR EMSCRIPTEN)
    add_library(miniaudio STATIC ${MINIAUDIO_SOURCES})
else()
    add_library(miniaudio SHARED ${MINIAUDIO_SOURCES})
endif()

# ── Compile definitions ─────────────────────────────────────────────────────
target_compile_definitions(miniaudio PRIVATE
    MA_IMPLEMENTATION          # Compile miniaudio implementation
    MA_ENABLE_ONLY_SPECIFIC_BACKENDS  # Opt-in to platform-specific backends
)

target_include_directories(miniaudio PRIVATE
    "${MINIAUDIO_ROOT}"
)

# ── Platform-specific settings ──────────────────────────────────────────────
if(APPLE)
    if(CMAKE_SYSTEM_NAME STREQUAL "iOS")
        target_compile_definitions(miniaudio PRIVATE MA_ENABLE_COREAUDIO)
        target_compile_options(miniaudio PRIVATE -x objective-c)
        set_target_properties(miniaudio PROPERTIES
            FRAMEWORK TRUE
            MACOSX_FRAMEWORK_IDENTIFIER com.sokolnet.miniaudio
        )
    else()
        target_compile_definitions(miniaudio PRIVATE MA_ENABLE_COREAUDIO)
        target_compile_options(miniaudio PRIVATE -x objective-c)
        set_target_properties(miniaudio PROPERTIES
            MACHO_COMPATIBILITY_VERSION 1
            MACHO_CURRENT_VERSION 1
        )
        target_link_libraries(miniaudio PRIVATE
            "-framework CoreAudio"
            "-framework AudioToolbox"
            "-framework CoreFoundation"
        )
    endif()
elseif(WIN32)
    target_compile_definitions(miniaudio PRIVATE MA_ENABLE_WASAPI MA_ENABLE_DSOUND MA_ENABLE_WINMM)
elseif(ANDROID)
    # AAudio is only available from API 26+; fall back to OpenSL ES on older levels.
    if(ANDROID_NATIVE_API_LEVEL GREATER_EQUAL 26)
        target_compile_definitions(miniaudio PRIVATE MA_ENABLE_AAUDIO MA_ENABLE_OPENSL)
        target_link_libraries(miniaudio PRIVATE OpenSLES aaudio log)
    else()
        target_compile_definitions(miniaudio PRIVATE MA_ENABLE_OPENSL)
        target_link_libraries(miniaudio PRIVATE OpenSLES log)
    endif()
elseif(EMSCRIPTEN)
    target_compile_definitions(miniaudio PRIVATE MA_ENABLE_WEBAUDIO)
    target_compile_options(miniaudio PRIVATE -msimd128)
elseif(UNIX)
    target_compile_definitions(miniaudio PRIVATE MA_ENABLE_ALSA MA_ENABLE_PULSEAUDIO)
    target_link_libraries(miniaudio PRIVATE dl m pthread)
endif()

# ── Output name ─────────────────────────────────────────────────────────────
set_target_properties(miniaudio PROPERTIES OUTPUT_NAME "miniaudio")
