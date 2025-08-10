# 🔵 Dots - A Sidescroller Jumping Game

A fun and challenging sidescroller game where you control a blue dot that must jump over incoming enemy dots. Built with Godot 4.3 and C#, featuring a beautiful procedurally-generated night sky with twinkling stars and a detailed moon.

![Version](https://img.shields.io/badge/version-1.1.0-blue)
![Godot](https://img.shields.io/badge/Godot-4.3-brightgreen)
![.NET](https://img.shields.io/badge/.NET-9.0-purple)
![Platform](https://img.shields.io/badge/platform-macOS%20%7C%20Windows%20%7C%20Linux-lightgrey)

## ✨ What's New in v1.1.0

- 🎯 **macOS Compatibility** - Full support for Apple Silicon Macs
- 🚀 **.NET 9.0 Support** - Updated to latest .NET runtime for better performance
- 📦 **Easy Launch Script** - One-click game launch with `launch_godot.sh`
- 🔧 **Auto-configuration** - Improved project setup with automatic environment detection

## 🎮 Game Features

- **🕹️ Simple Controls** - Intuitive movement and jumping mechanics
- **📈 Progressive Difficulty** - Game speeds up every 5 points for increasing challenge
- **🌌 Beautiful Night Sky** - Procedurally-generated stars with twinkling animations
- **🌙 Detailed Moon** - Realistic moon with craters in the night sky
- **📊 Score System** - Real-time score tracking with high score challenges
- **♻️ Instant Restart** - Quick retry with R key when game over
- **⚡ Smooth Performance** - Optimized for 60 FPS gameplay

## 🚀 Getting Started

### Prerequisites

- **Godot 4.3 or later** with C#/.NET support
- **.NET 9.0 SDK** (or .NET 8.0 with compatibility mode)
- **macOS**, **Windows**, or **Linux** operating system

### Quick Start (macOS)

```bash
# Clone the repository
git clone https://github.com/Tortured-Metaphor/Dots.git
cd Dots

# Install dependencies (if not already installed)
brew install dotnet

# Launch the game with the provided script
./launch_godot.sh
```

Then in Godot, press **F5** or click **Play** to start the game!

### Manual Installation

1. **Install Prerequisites**
   ```bash
   # macOS (using Homebrew)
   brew install dotnet
   brew install --cask godot-mono
   
   # Windows (using Chocolatey)
   choco install dotnet-sdk
   choco install godot-mono
   
   # Linux (Ubuntu/Debian)
   sudo apt-get install dotnet-sdk-9.0
   # Download Godot Mono from godotengine.org
   ```

2. **Clone the Repository**
   ```bash
   git clone https://github.com/Tortured-Metaphor/Dots.git
   cd Dots
   ```

3. **Build and Run**
   ```bash
   # Build the project
   dotnet build
   
   # Launch with script (macOS/Linux)
   ./launch_godot.sh
   
   # Or open manually in Godot
   # Import project.godot and press F5
   ```

## 🎯 How to Play

### 🎮 Controls
| Action | Keys |
|--------|------|
| **Move Left** | `A` or `←` |
| **Move Right** | `D` or `→` |
| **Jump** | `Space` or `W` |
| **Restart** | `R` (after game over) |

### 🎯 Objective
Your mission is simple but challenging: **survive as long as possible!** Jump over the red enemy dots that approach from the right side of the screen. Each enemy that passes increases your score. How high can you go?

### 💡 Pro Tips
- **Master the Jump** - You can't double jump, so time it perfectly!
- **Watch the Patterns** - Enemies have subtle spawning patterns you can learn
- **Stay Centered** - The middle of the screen gives you the most reaction time
- **Difficulty Spikes** - Every 5 points, the game speeds up significantly
- **Perfect Jumps** - Jump at the last moment for style points (not scored, but cool!)
- **Zen Mode** - Watch the stars twinkle while you play for a calming effect

## 📁 Project Structure

```
Dots/
├── scenes/
│   ├── Main.tscn          # Main game scene
│   ├── Player.tscn        # Player dot scene
│   └── EnemyDot.tscn      # Enemy dot scene
├── scripts/
│   ├── GameManager.cs     # Main game logic and spawning
│   ├── Player.cs          # Player movement and controls
│   ├── EnemyDot.cs        # Enemy behavior
│   └── SkyBackground.cs   # Procedural sky generation
├── project.godot          # Godot project settings
├── DotsGame.csproj        # C# project file
├── DotsGame.sln           # Visual Studio solution
└── icon.svg               # Game icon
```

## 🛠️ Development

### Opening in an IDE

**Visual Studio Code:**
```bash
code .
```
Install the C# extension for full IntelliSense support.

**Visual Studio:**
Open `DotsGame.sln` directly in Visual Studio.

### Building from Command Line

```bash
dotnet build
```

### Modifying the Game

- **Change player speed**: Edit `Speed` constant in `scripts/Player.cs`
- **Adjust jump height**: Modify `JumpVelocity` in `scripts/Player.cs`
- **Change enemy speed**: Edit `speed` variable in `scripts/EnemyDot.cs`
- **Adjust spawn rate**: Modify `wait_time` in `scenes/Main.tscn` SpawnTimer node
- **Add more stars**: Increase the loop count in `SkyBackground.cs` `GenerateStars()` method

## 🐛 Troubleshooting

### "Build failed" Error
- Ensure you have .NET 8.0 SDK installed: `dotnet --version`
- Try cleaning and rebuilding: `dotnet clean && dotnet build`

### Game Won't Start
- Check that all scene files are present in the `scenes/` folder
- Verify the main scene is set in Project Settings → Application → Run → Main Scene

### C# Scripts Not Working
- Make sure you're using the .NET version of Godot 4.3
- Rebuild the project from Godot's Build menu
- Check the console for compilation errors

### Performance Issues
- Reduce the number of stars in `SkyBackground.cs`
- Ensure you're running in Release mode for better performance

## 📦 Exporting the Game

1. In Godot, go to **Project → Export**
2. Add a new export preset for your platform
3. Configure export settings (name, icon, etc.)
4. Click "Export Project"
5. Choose a location and export

## 🎨 Customization Ideas

- Add power-ups (invincibility, slow motion)
- Implement different enemy types with varying speeds
- Add sound effects and background music
- Create multiple difficulty levels
- Add a high score leaderboard
- Implement parallax background layers
- Add particle effects for jumping and collisions

## 🎨 Game Mechanics

### Player Physics
- **Movement Speed**: 300 pixels/second
- **Jump Velocity**: -400 pixels/second
- **Gravity**: 980 pixels/second²
- **Player Size**: 15-pixel radius circle

### Enemy System  
- **Enemy Speed**: 200 pixels/second (left-moving)
- **Spawn Rate**: Starts at 2 seconds, decreases by 0.1s every 5 points
- **Minimum Spawn Time**: 0.5 seconds
- **Enemy Size**: 12-pixel radius circle

### Visual Features
- **50 Procedural Stars**: Randomly positioned with twinkling effects
- **Dynamic Moon**: With realistic crater details
- **Ground Line**: Vibrant green (RGB: 0.4, 0.8, 0.3)
- **Night Sky**: Deep blue background (RGB: 0.05, 0.05, 0.15)

## 📊 Version History

### v1.1.0 (Current) - 2025-08-10
- ✅ macOS Apple Silicon support
- ✅ .NET 9.0 compatibility
- ✅ Launch script for easy startup
- ✅ Improved build configuration
- ✅ Enhanced README documentation

### v1.0.0 - 2025-08-10
- 🎮 Initial game release
- 🎨 Procedural sky generation
- 🏃 Basic movement and jumping
- 🎯 Score tracking system
- 🔄 Game over and restart functionality

## 🏆 High Score Challenge

Can you beat these milestones?
- 🥉 **Bronze**: 10 points
- 🥈 **Silver**: 25 points  
- 🥇 **Gold**: 50 points
- 💎 **Diamond**: 100 points
- 🌟 **Legend**: 200+ points

Share your high scores by opening an issue with a screenshot!

## 📄 License

This project is open source and available for educational purposes under the MIT License.

## 🤝 Contributing

Contributions are welcome! Feel free to:
- 🐛 Report bugs
- 💡 Suggest new features
- 🔧 Submit pull requests
- ⭐ Star the repository if you enjoy the game!

## 📧 Contact

For questions, suggestions, or just to say hi:
- Open an [issue on GitHub](https://github.com/Tortured-Metaphor/Dots/issues)
- Star the repo if you enjoyed the game!

---

<div align="center">

**Made with ❤️ using Godot 4.3 and C#**

**Enjoy playing Dots!** 🎮✨

*Jump, dodge, survive, repeat!*

</div>
