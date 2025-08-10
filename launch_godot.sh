#!/bin/bash

# Set the .NET environment variables for Godot
export DOTNET_ROOT="/opt/homebrew/opt/dotnet/libexec"
export PATH="$DOTNET_ROOT:$PATH"

# Launch Godot with the project
echo "Launching Godot with .NET support..."
/Applications/Godot_mono.app/Contents/MacOS/Godot --path "$(pwd)" --editor