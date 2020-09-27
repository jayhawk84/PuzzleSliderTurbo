# PuzzleSliderTurbo
This is a web-based version of a classic sliding puzzle game.

I originally created a repository from scratch on Github, but when I created a scaffolded MVC project in Visual Studio for this game, I decided to just publish this one and bring over the README from the first iteration.

The concept is a variation on the old 15-puzzle sliding piece game, where a square image is split into pieces and rearranged.  One piece is removed and then the player has to slide the pieces, one at a time, until they all find their original place on the board.


## <div align="center">Table of Contents</div>
#### <div align="center">(Some contents forthcoming)</div>

1) [Why I chose this](#why)
2) [Concept](#idea)
3) [Wire-Frame Desktop](#desktop)
4) [Wire-Frame Mobile](#mobile)
5) [Entity Relationship Diagram (ERD) (forthcoming)]
6) [User Stories](#user-stories)
7) [Use Case/Req/UML (forthcoming)]
8) [Testing (forthcoming)]
9) [Prototype](#prototype)
10) [Early Web App](#early-build)

## <div align="center">WHY</div>
[(Table of contents)](#table-of-contents)

I used to play a lot of board games with my siblings when we were younger.  Sometimes, though, I wanted to play my own game.  Before I got a game boy, that meant something like a Puzzle 15 would have to suffice.  I have fond memories of playing them, and I thought it would be a lot of fun to build the game using Visual Studio and C# to create a web application.

## <div align="center">IDEA</div>
[(Table of contents)](#table-of-contents)

The idea of a Puzzle 15 is that a square image is split into a 4 X 4 grid of sixteen squares.  One of the squares is missing, so you have fifteen puzzle pieces, hence Puzzle 15.  You have to slide the pieces one at a time into the one empty grid space, back and forth and around the board, until you have shuffled them all into the correct spaces.  You will know they're the correct spaces because they will form a complete image.  For my web application, I will give players the opportunity to show or hide the image in the upper left corner to give them a guide for solving.  I also wanted to provide a chance to decrease or increase difficulty from a 2 X 2 to 3 X 3 to 4 X 4 grid.  Then alternately, they could toggle between color, black and white, or line drawing versions of the image which would also affect difficulty to a degree.  If they are having too much trouble, they can bail out and let the computer solve the puzzle by hitting the "Give Up" button.  Oh, and they can change the image as well if they don't like the one the system chose for them by cycling through the images in the top right.

## <div align="center">DESKTOP</div>
[(Table of contents)](#table-of-contents)

This is how the layout on desktop would look.  The player could show/hide the finished image, and if they wanted to select a different image, they could cycle through them and select a new one.
![WIREFRAME_DESKTOP](https://github.com/jayhawk84/SuperPuzzleSliderTurbo/blob/master/PuzzleMedia/SPST%20desktop.jpg)

## <div align="center">MOBILE</div>
[(Table of contents)](#table-of-contents)

The mobile layout would be similar to the desktop in that the buttons would all still be there, but they wouldn't be as large or wrap the center puzzle.  Once selecting start, the puzzle would be the primary focus in center of viewscreen.
![WIREFRAME_MOBILE](https://github.com/jayhawk84/SuperPuzzleSliderTurbo/blob/master/PuzzleMedia/SPST%20mobile.jpg)

## <div align="center">USER STORIES</div>
[(Table of contents)](#table-of-contents)
1. As an anonymous user, I want to be able to play the game without having to login or register.
2. As a user, I want to be able to cycle through different images if I do not like the initial image and pick a different one to slide.
3. As a user, I would like to have varying levels of difficulty available when I play the game.

## <div align="center">PROTOTYPE</div>
[(Table of contents)](#prototype)
![PROTOTYPE](https://github.com/jayhawk84/SuperPuzzleSliderTurbo/blob/master/PuzzleMedia/Prototype.PNG)
#### <div align="center"><a href="https://ojbh74.axshare.com/#id=ithaj4&p=page_1" target="_blank">Interactive Axure Prototype (link)</a></div>

## <div align="center">EARLY BUILD</div>
[(Table of contents)](#early-build)
#### This is a screenshot of the initial build, using numbers instead of an image until I can figure out how to assign image pieces to the array
![EARLY BUILD](https://github.com/jayhawk84/PuzzleSliderTurbo/blob/master/PuzzleMedia/puzzleOnline.PNG)

#### This is a screenshot of a different build, using a picture I took in Hawaii.  I am still trying to figure out the best combination of code that isn't reliant on hard-coded numbers, so this will inevitably change.  But it looks good with a picture.
![EARLY BUILD](https://github.com/jayhawk84/PuzzleSliderTurbo/blob/master/PuzzleMedia/puzzlePicture.PNG)

## Database screenshot
![Database](https://github.com/jayhawk84/PuzzleSliderTurbo/blob/master/PuzzleMedia/SSMS_table_data.jpg)
