using Godot;

public partial class Player : CharacterBody2D
{
    private const float Speed = 300.0f;
    private const float JumpVelocity = -400.0f;
    
    private float gravity;
    private Polygon2D dotShape;
    
    public override void _Ready()
    {
        gravity = (float)ProjectSettings.GetSetting("physics/2d/default_gravity");
        
        dotShape = GetNode<Polygon2D>("DotShape");
        
        var collisionShape = GetNode<CollisionShape2D>("CollisionShape2D");
    }
    
    public override void _PhysicsProcess(double delta)
    {
        Vector2 velocity = Velocity;
        
        if (!IsOnFloor())
        {
            velocity.Y += gravity * (float)delta;
        }
        
        if (Input.IsActionJustPressed("jump") && IsOnFloor())
        {
            velocity.Y = JumpVelocity;
        }
        
        Vector2 direction = Input.GetVector("move_left", "move_right", "ui_up", "ui_down");
        if (direction != Vector2.Zero)
        {
            velocity.X = direction.X * Speed;
        }
        else
        {
            velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed * (float)delta);
        }
        
        Velocity = velocity;
        MoveAndSlide();
    }
}