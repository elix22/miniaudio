#!/bin/bash
# Build script for miniaudio library on iOS (with ogg/vorbis + opus support)
# Usage: ./build-miniaudio-ios.sh [architecture] [build_type]
# Example: ./build-miniaudio-ios.sh arm64 Release         (device)
# Example: ./build-miniaudio-ios.sh arm64 Debug           (device debug)

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
MINIAUDIO_DIR="$(cd "$SCRIPT_DIR/.." && pwd)"
CMAKE_DIR="$SCRIPT_DIR"
BUILD_DIR="$MINIAUDIO_DIR/build-xcode-ios"

ARCH="${1:-arm64}"
BUILD_TYPE="${2:-Release}"

echo "=========================================="
echo "Building miniaudio for iOS"
echo "Architecture: $ARCH"
echo "Build Type: $BUILD_TYPE"
echo "=========================================="

if [ "$ARCH" = "arm64" ]; then
    SDK="iphoneos"
    DEPLOYMENT_TARGET="13.0"
else
    SDK="iphonesimulator"
    DEPLOYMENT_TARGET="13.0"
fi

rm -rf "$BUILD_DIR"
mkdir -p "$BUILD_DIR"
cd "$BUILD_DIR"

cmake "$CMAKE_DIR" \
    -G Xcode \
    -DCMAKE_SYSTEM_NAME=iOS \
    -DCMAKE_OSX_ARCHITECTURES="$ARCH" \
    -DCMAKE_OSX_DEPLOYMENT_TARGET="$DEPLOYMENT_TARGET" \
    -DCMAKE_XCODE_ATTRIBUTE_DEVELOPMENT_TEAM="" \
    -DCMAKE_XCODE_ATTRIBUTE_CODE_SIGNING_ALLOWED=NO \
    -DCMAKE_BUILD_TYPE="$BUILD_TYPE"

cmake --build . --config "$BUILD_TYPE"

DEST_DIR="$MINIAUDIO_DIR/libs/ios/$(echo "$BUILD_TYPE" | tr '[:upper:]' '[:lower:]')"
mkdir -p "$DEST_DIR"

OUTPUT_FRAMEWORK="$BUILD_DIR/$BUILD_TYPE-$SDK/miniaudio.framework"
if [ -d "$OUTPUT_FRAMEWORK" ]; then
    rm -rf "$DEST_DIR/miniaudio.framework"
    cp -R "$OUTPUT_FRAMEWORK" "$DEST_DIR/"
    echo "=========================================="
    echo "✓ Copied to: $DEST_DIR/miniaudio.framework"
    echo "=========================================="
else
    echo "✗ Failed to build miniaudio.framework — looking for any output:"
    find "$BUILD_DIR" -name "libminiaudio*" -o -name "miniaudio.framework" 2>/dev/null || true
    exit 1
fi
