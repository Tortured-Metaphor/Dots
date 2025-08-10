using Godot;

public partial class EnemyDot : Area2D
{
    private float speed = 200.0f;
    
    public override void _Ready()
    {
        BodyEntered += OnBodyEntered;
    }
    
    public override void _Process(double delta)
    {
        Position += Vector2.Left * speed * (float)delta;
        
        if (Position.X < -50)
        {
            QueueFree();
        }
    }
    
    private void OnBodyEntered(Node2D body)
    {
        if (body is Player)
        {
            GetTree().CallGroup("game_manager", "OnPlayerHit");
        }
    }
}