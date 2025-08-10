using Godot;
using System;

public partial class SkyBackground : Node2D
{
    private Random random = new Random();
    
    public override void _Ready()
    {
        GenerateStars();
        CreateMoon();
    }
    
    private void GenerateStars()
    {
        for (int i = 0; i < 50; i++)
        {
            var star = new Polygon2D();
            
            float size = (float)random.NextDouble() * 2 + 1;
            star.Polygon = CreateStarShape(size);
            
            star.Position = new Vector2(
                (float)random.NextDouble() * 1280,
                (float)random.NextDouble() * 400
            );
            
            float brightness = (float)random.NextDouble() * 0.5f + 0.5f;
            star.Color = new Color(brightness, brightness, brightness * 0.9f, brightness);
            
            AddChild(star);
            
            if (random.NextDouble() > 0.7)
            {
                var tween = GetTree().CreateTween();
                tween.SetLoops();
                tween.TweenProperty(star, "modulate:a", 0.3f, random.NextDouble() * 2 + 1);
                tween.TweenProperty(star, "modulate:a", brightness, random.NextDouble() * 2 + 1);
            }
        }
    }
    
    private Vector2[] CreateStarShape(float size)
    {
        return new Vector2[]
        {
            new Vector2(0, -size * 2),
            new Vector2(size * 0.5f, -size * 0.5f),
            new Vector2(size * 2, 0),
            new Vector2(size * 0.5f, size * 0.5f),
            new Vector2(0, size * 2),
            new Vector2(-size * 0.5f, size * 0.5f),
            new Vector2(-size * 2, 0),
            new Vector2(-size * 0.5f, -size * 0.5f)
        };
    }
    
    private void CreateMoon()
    {
        var moon = new Polygon2D();
        moon.Polygon = CreateCirclePolygon(30, 16);
        moon.Position = new Vector2(1000, 100);
        moon.Color = new Color(0.95f, 0.95f, 0.85f, 1);
        AddChild(moon);
        
        var crater1 = new Polygon2D();
        crater1.Polygon = CreateCirclePolygon(8, 8);
        crater1.Position = new Vector2(1010, 95);
        crater1.Color = new Color(0.85f, 0.85f, 0.75f, 0.5f);
        AddChild(crater1);
        
        var crater2 = new Polygon2D();
        crater2.Polygon = CreateCirclePolygon(5, 6);
        crater2.Position = new Vector2(990, 105);
        crater2.Color = new Color(0.85f, 0.85f, 0.75f, 0.5f);
        AddChild(crater2);
    }
    
    private Vector2[] CreateCirclePolygon(float radius, int segments)
    {
        var points = new Vector2[segments];
        for (int i = 0; i < segments; i++)
        {
            float angle = (float)(i * Math.PI * 2 / segments);
            points[i] = new Vector2(
                (float)Math.Cos(angle) * radius,
                (float)Math.Sin(angle) * radius
            );
        }
        return points;
    }
}