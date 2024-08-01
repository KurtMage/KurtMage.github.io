# NOTE:
This is currently a work in progress. I plan on adding more layouts and ways that you can customize it to change buttons layouts.

# Gamepad Viewer Layouts

Various controller layouts for gamepad viewer. Example of some 2XKO layouts:

![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/hitbox/2XKO/4%20layouts.gif)

# How to set up for OBS
1. Choose a layout from [the layouts section](#layouts-by-game). Copy the link for the layout you want.
NOTE: Every URL below has `p=1` in it. This is what determines what player your controller is, and you can change it. For example, if the controller that you want to visualize is player 3, you would change this to `p=3`.
2. In OBS, click the + in sources to add a source. Select Browser as the type.
3. In the URL box, put the URL from step 1.
4. Change the Width to 1500.
5. Final important note: you need to give it an input from the controller for it to show up. Other than that, you're all set up!

# How to change your button layout for custom controls
1. Right-click on the browser source you created in [the setup section](#how-to-set-up-for-obs).
2. Copy-paste the following code into the `Custom CSS` dialog box below the line that says `body { background-color: rgba(0, 0, 0, 0); margin: 0px auto; overflow: hidden; }` (** Make sure you do not delete that line **):
```
:root {
     /***************
     *   0  1  2 3  *
     * 0 L  M  H D  *
     * 1 S1 S2 T P  *
     ****************/

    --top-row-index-finger-button-row: 0;
    --top-row-index-finger-button-col: 0;

    --top-row-middle-finger-button-row: 0;
    --top-row-middle-finger-button-col: 1;

    --top-row-ring-finger-button-row: 0;
    --top-row-ring-finger-button-col: 2;

    --top-row-pinky-finger-button-row: 0;
    --top-row-pinky-finger-button-col: 3;
    
    --bot-row-index-finger-button-row: 1;
    --bot-row-index-finger-button-col: 0;

    --bot-row-middle-finger-button-row: 1;
    --bot-row-middle-finger-button-col: 1;

    --bot-row-ring-finger-button-row: 1;
    --bot-row-ring-finger-button-col: 2;

    --bot-row-pinky-finger-button-row: 1;
    --bot-row-pinky-finger-button-col: 3;
}
```
3. You can change any of the variables in order to change what button goes where. Each variable refers to the row/column of a button. The buttons are referenced by the following table:
   
|   | 0 | 1 | 2 | 3 |
| - | - | - | - | - |
| 0 | L | M | H | D |
| 1 | S1| S2| T | P |

So, for example, if you wanted to set the top-right button to `T`, you would look at the table and see that `T`'s row is 1 and column is 2. The top right button would be your pinky finger on the top row. So you would set `--top-row-pinky-finger-button-row: 1` and `--top-row-pinky-finger-button-row: 2` (replacing the `0` and `3` that these variables are currently set to, to `1` and `2`).

4. Hit "Ok" in the dialog box and then input something on your controller to display your layout.

## Example demo of customizing button layout:
![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/customize%20controls.gif)


# Layouts by Controller Layout

[Hitbox](#hitbox-layouts-by-game)
[Playstation 4 controller](#playstation-4-controller-layouts-by-game)

# Hitbox layouts by game
[2XKO](#2xko)

[Street Fighter](#street-fighter)
## 2XKO

### Light mode black borders
![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/hitbox/2XKO/light%20mode.gif)
```
https://gamepadviewer.com/?p=1&s=7&map=%7B%7D&editcss=https://kurtmage.github.io/hitbox%20layout/2XKO/light-mode.css
```

### Dark mode black borders
![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/hitbox/2XKO/Dark%20mode%20black%20border.gif)
```
https://gamepadviewer.com/?p=1&s=7&map=%7B%7D&editcss=https://kurtmage.github.io/hitbox%20layout/2XKO/dark-mode.css
```

### Dark mode white borders
![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/hitbox/2XKO/dark%20mode%20white%20border.gif)
```
https://gamepadviewer.com/?p=1&s=7&map=%7B%7D&editcss=https://kurtmage.github.io/hitbox%20layout/2XKO/dark-mode-white-outlines.css
```

### Layout 1
![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/hitbox/2XKO/white%20buttons%20with%20border1.gif)
```
https://gamepadviewer.com/?p=1&s=7&map=%7B%7D&editcss=https://kurtmage.github.io/hitbox%20layout/2XKO/white-button-press-outlined-letters.css
```
### Layout 2
![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/hitbox/2XKO/white%20pressed%20buttons.gif)
```
https://gamepadviewer.com/?p=1&s=7&map=%7B%7D&editcss=https://kurtmage.github.io/hitbox%20layout/white-button-press.css
```
### Layout 3
![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/hitbox/2XKO/dim%20buttons.gif)
```
https://gamepadviewer.com/?p=1&s=7&map=%7B%7D&editcss=https://kurtmage.github.io/hitbox%20layout/2XKO/dim-buttons.css
```

## Street Fighter
### Layout 1
![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/hitbox/Street%20Fighter/dim%20buttons.gif)
```
https://gamepadviewer.com/?p=1&s=7&map=%7B%7D&editcss=https://kurtmage.github.io/hitbox%20layout/street%20fighter/dim-buttons.css
```

# Playstation 4 controller layouts by game
[2XKO](#ps4-2xko)

<!----><a name="ps4-2xko"></a>
## 2XKO
![](https://github.com/KurtMage/KurtMage.github.io/blob/main/gifs/Playstation%204%20controller/2XKO/press%20white%20outlined.gif)
```
https://gamepadviewer.com/?p=1&s=5&map=%7B%7D&editcss=https://kurtmage.github.io/PS4%20controller/2XKO/pressed-white-outlined-buttons.css
```
