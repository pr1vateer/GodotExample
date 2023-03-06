using Godot;
using System;

public partial class Sprite2D_script : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var speed = 5f;
		if(Input.IsKeyPressed(Key.W)){
			this.Position += new Vector2(0,-speed);
		}
		else if(Input.IsKeyPressed(Key.S)){
			this.Position += new Vector2(0,speed);
		}	
	}
}
