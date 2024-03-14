This project includes all of these UI elements:

     UI includes any text, buttons, or display that the user can read or interact with

     We have the title screen, with menu buttons where the player can choose the difficulty.
     During the game, the player's Score will be tracked and displayed.
     At the end you will have a Game Over screen capable of restarting the game.
    
     Menu UI with difficulty options (easy, medium and hard); 

     Easy setting causes objects to be launched slowly; 
     Hard configuration causes objects to be launched quickly;
     When the button's EventListener is called, it will execute the SetDifficult method; 
     The SetDifficult method will take the difficulty value and communicate it to the GameManager script,
     responsible for managing the scene.

     In the GameManager script, the StartGame method will take this difficulty value and
     used to change the spawRate(Target Launch)
     using Diegetic Ui concept applying "SCREEN SHAKE" animation

 
https://github.com/alfredo1995/click-fruit/assets/71193893/d833eb19-ff41-4dab-8cc2-46923075e9ef

