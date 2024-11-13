# GameEngineBonus

# Contribution 

Diagram of observer pattern, code for DLL, ColorPicker, and Character Controller. - Michael Atteh - 100831528 
50%

Diagram of Timer, Code for timer,  Write-Up, and Reflection, Level Primitives -Dylan Dos Ramos - 100873698 
50%

# Reason for extra time

The reason we needed the extra time is for some different reasons. Firstly, github was giving some issues while in class, the repository wasn't connecting to the laptop, and when it did, it just gave and error about how the file size was too big. Another reason is that figuring out how to add in a DLL in that amount of time was quite challenging. The time loss from the github issues didn't give much time to work on anything except a small bit of the primative asset's and a idea of how to implement the design element. Having this extra time allowed us to achieve more out of the bonus assignment, and be able to properly deliver the required deliverables in a less stressful environment.


# Design Pattern

Observer 

The observer pattern was used for this project, when left clicking on the mouse, the text at the top of the screen, as well as the character changes between different colours. The colours swap through 5 different sets, the observer looks out for when an action is done by the user, this being a left click of the mouse button, doing this feedback is sent to the user that their action updated a part of the game. While it isn’t directly functionality/gameplay based, it allows the user to have a little bit of freedom with customization, letting them choose a colour they want, and what they want the title colour to be.

![ssss](https://github.com/user-attachments/assets/c359a4b5-4803-40ba-b78d-f0e57fdb68e2)

Singleton

Another design pattern that we are going for not related to the DLL, is Singleton, using singleton a time manager would be utilized to add in a way for the player to see how long it took them to complete the current stage. Even though it’s not in the original game, it still would be a good feature to add into the game. This would also make it easier for some people that want to compare times in the game, since the only other way to track how long it takes to beat a level would be to use an external program, so having it backed directly into the game would make it easier to see, plus it generally makes people more engaged with a game if there is a timer, since they might continue to play it over and over again as they attempt to get a better time.

![Timer](https://github.com/user-attachments/assets/57b72ed9-1a2f-4fbf-b9d7-2e165c1f6f48)

# DLL

As for the DLL, it also circles back to the observer pattern, which is the main way that the colour swapping is able to take place. Both the character controller, and the colour picker scripts call to the Plugin to achieve the effect of changing colours. The DLL stores the colour index’s, when the colourPicker script is then called it then returns the index and allows for the colours to change for the user to see.
