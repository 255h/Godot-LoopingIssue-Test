using Godot;
using System;

public class Loading : Control
{
   
    private AnimationPlayer _Animation;




    public override void _Ready()
    {
       
        _Animation = GetNode("Animation") as AnimationPlayer;
       
    }

      public void LoadingStopped()
    {
             
        _Animation.Play("FadeOut");
        
    }

}
