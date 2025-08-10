using Godot;

public partial class GameManager : Node2D
{
    [Export]
    private PackedScene enemyDotScene;
    
    private int score = 0;
    private Label scoreLabel;
    private Label gameOverLabel;
    private Timer spawnTimer;
    private Node2D enemySpawner;
    private bool gameOver = false;
    
    public override void _Ready()
    {
        AddToGroup("game_manager");
        
        enemyDotScene = GD.Load<PackedScene>("res://scenes/EnemyDot.tscn");
        
        var skyBackground = new SkyBackground();
        GetNode("Background").AddChild(skyBackground);
        
        CreateUI();
        
        enemySpawner = GetNode<Node2D>("EnemySpawner");
        spawnTimer = GetNode<Timer>("EnemySpawner/SpawnTimer");
        spawnTimer.Timeout += OnSpawnTimerTimeout;
        
        var staticBody = new StaticBody2D();
        staticBody.Position = new Vector2(640, 515);
        var collisionShape = new CollisionShape2D();
        var shape = new RectangleShape2D();
        shape.Size = new Vector2(1280, 30);
        collisionShape.Shape = shape;
        staticBody.AddChild(collisionShape);
        AddChild(staticBody);
    }
    
    private void CreateUI()
    {
        var canvasLayer = new CanvasLayer();
        AddChild(canvasLayer);
        
        scoreLabel = new Label();
        scoreLabel.Position = new Vector2(20, 20);
        scoreLabel.AddThemeStyleboxOverride("normal", new StyleBoxFlat());
        scoreLabel.AddThemeFontSizeOverride("font_size", 24);
        scoreLabel.Text = "Score: 0";
        canvasLayer.AddChild(scoreLabel);
        
        gameOverLabel = new Label();
        gameOverLabel.Position = new Vector2(500, 250);
        gameOverLabel.AddThemeFontSizeOverride("font_size", 48);
        gameOverLabel.Text = "GAME OVER\nPress R to Restart";
        gameOverLabel.Visible = false;
        canvasLayer.AddChild(gameOverLabel);
    }
    
    private void OnSpawnTimerTimeout()
    {
        if (gameOver) return;
        
        var enemy = enemyDotScene.Instantiate<EnemyDot>();
        enemy.Position = new Vector2(1350, 480);
        enemySpawner.AddChild(enemy);
        
        score++;
        scoreLabel.Text = $"Score: {score}";
        
        if (score % 5 == 0 && spawnTimer.WaitTime > 0.5)
        {
            spawnTimer.WaitTime -= 0.1;
        }
    }
    
    public void OnPlayerHit()
    {
        if (gameOver) return;
        
        gameOver = true;
        spawnTimer.Stop();
        gameOverLabel.Visible = true;
        GetNode<Player>("Player").SetPhysicsProcess(false);
    }
    
    public override void _Input(InputEvent @event)
    {
        if (gameOver && @event is InputEventKey keyEvent && keyEvent.Pressed)
        {
            if (keyEvent.Keycode == Key.R)
            {
                GetTree().ReloadCurrentScene();
            }
        }
    }
}