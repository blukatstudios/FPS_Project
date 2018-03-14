using Godot;
using System;

public class PauseMenu : Container{
  
  public Godot.Button quitButton;
  public Godot.Button mainMenuButton;
  
  public override void _Ready(){
    
  }

  public void Init(){
    SetQuitButton((Godot.Button)Menu.Button(text : "Quit", onClick: Quit));
    SetMainMenuButton((Godot.Button)Menu.Button(text : "Main Menu", onClick: QuitToMainMenu));
    ScaleControls();
  }
  
  void ScaleControls(){
      Rect2 screen = this.GetViewportRect();
      float width = screen.Size.x;
      float height = screen.Size.y;
      float wu = width/10; // relative height and width units
      float hu = height/10;
      
      Menu.ScaleControl(mainMenuButton, 4 * wu, 2 * hu, 3 * wu, 2 * hu);
      Menu.ScaleControl(quitButton, 4 * wu, 2 * hu, 3 * wu,  4 * hu);
  }
  
  public void SetQuitButton(Godot.Button button){
    if(quitButton != null){ quitButton.QueueFree(); }
    quitButton = button;
    AddChild(button);
  }
  
  public void SetMainMenuButton(Godot.Button button){
    if(mainMenuButton != null){ quitButton.QueueFree(); }
    mainMenuButton = button;
    AddChild(button);
  }
  
  public void Quit(){
      Session.session.Quit();
  }
  
  public void QuitToMainMenu(){
    Session.session.QuitToMainMenu();
  }
  
}
