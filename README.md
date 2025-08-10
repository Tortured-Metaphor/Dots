# 🔵 Dots - A Sidescroller Jumping Game

A fun and challenging sidescroller game where you control a blue dot that must jump over incoming enemy dots. Built with Godot 4.3 and C#.

## 🎮 Game Features

- **Simple Controls** - Move and jump to avoid enemies
- **Progressive Difficulty** - Game speeds up as your score increases
- **Beautiful Night Sky** - Twinkling stars and moon create an atmospheric background
- **Score System** - Track your progress and challenge yourself to beat your high score
- **Instant Restart** - Quick retry when you get hit

## 🚀 Getting Started

### Prerequisites

- **Godot 4.3 or later** with C#/.NET support
- **.NET 8.0 SDK** or later
- **Visual Studio Code** or **Visual Studio** (optional, for C# development)

### Installation

1. **Download Godot Engine**
   - Visit [godotengine.org](https://godotengine.org/download)
   - Download **Godot 4.3 - .NET version** (includes C# support)
   - Extract and run Godot

2. **Clone or Download this Repository**
   ```bash
   git clone https://github.com/Tortured-Metaphor/Dots.git
   cd Dots
   ```

3. **Open the Project in Godot**
   - Launch Godot
   - Click "Import" on the project manager
   - Navigate to the Dots folder
   - Select `project.godot` and click "Import & Edit"

4. **Build the C# Solution**
   - Godot will automatically detect the C# project
   - Click "Build" in the top menu or press `Ctrl+Shift+B` (Windows/Linux) or `Cmd+Shift+B` (Mac)
   - Wait for the build to complete

5. **Run the Game**
   - Press `F5` or click the "Play" button (▶️) in the top-right corner
   - The game will compile and launch

## 🎯 How to Play

### Controls
- **A / ←** - Move left
- **D / →** - Move right  
- **Space / W** - Jump
- **R** - Restart (when game over)

### Objective
Jump over the red enemy dots that approach from the right side of the screen. Each enemy that spawns increases your score. The game gets progressively harder as enemies spawn more frequently.

### Tips
- Time your jumps carefully - you can't double jump!
- The spawn rate increases every 5 points
- Stay near the center for more reaction time
- Watch for patterns in enemy spawning

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

## 📄 License

This project is open source and available for educational purposes.

## 🤝 Contributing

Feel free to fork this project and submit pull requests with improvements!

## 📧 Contact

For questions or suggestions, please open an issue on GitHub.

---

**Enjoy playing Dots!** 🎮✨
