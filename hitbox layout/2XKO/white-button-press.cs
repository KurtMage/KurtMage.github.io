body { background-color: rgba(0, 0, 0, 0); margin: 0px auto; overflow: hidden; }

.controller.fight-stick {
    background: url(https://imgur.com/AEMTeDY.png) center no-repeat;
    height: 535px;
    width: 1500px;
}

/* start/back */

.fight-stick .back {
    position: absolute;
    top: -37px;
    left: 1271px;
}

.fight-stick .start {
    position: absolute;
    top: -37px;
    left: 1362px;
}

.fight-stick .back, .fight-stick .start {
    width: 70px;
    height: 70px;
    background: #333333;
    display: block;
    border-radius: 100%;
}

.fight-stick .back.pressed, .fight-stick .start.pressed {
    transform: translateY(2px);
    -webkit-filter: brightness(0%) invert(1);
}

/* Face buttons */

.fight-stick .a {
    background: url(https://imgur.com/Dg2SRLd.png);
    bottom: 19px;
    left: 376px;
    background-position: 0px -246px; /* Position of S1 button */
}

.fight-stick .a.pressed {
    background-position: 0px -369px; /* Position of pressed S1 button */
}

.fight-stick .b {
    background: url(https://imgur.com/Dg2SRLd.png);
    bottom: 84px;
    right: -345px;
    background-position: -123px -246px; /* Position of S2 button */
}

.fight-stick .b.pressed {
    background-position: -123px -369px; /* Position of S2 button */
}

.fight-stick .x {
    background: url(https://imgur.com/Dg2SRLd.png);
    top: 46px;
    left: 409px;
    background-position: 0px 0px; /* Position of L button */
}

.fight-stick .x.pressed {
    background-position: 0px -123px; /* Position of L button */
}

.fight-stick .y {
    background: url(https://imgur.com/Dg2SRLd.png);
    right: -378px;
    top: -19px;
    background-position: -123px 0px; /* Position of M button */
}

.fight-stick .y.pressed {
    background-position: -123px -123px; /* Position of L button */
}

.fight-stick .button.pressed {
    transform: translateY(5px);
    -webkit-filter: invert(0);
}

/* Bumpers */

.fight-stick .bumper.right {
    position: absolute;
    right: 172px;
    top: -17px;
    float: left;
    background-position: -246px 0px; /* Position of H button */
}

.fight-stick .bumper.right.pressed {
    background-position: -246px -123px; /* Position of pressed H button */
}

.fight-stick .bumper.left {
    position: absolute;
    float: right;
    bottom: 21px;
    right: 12px;
    background-position: -369px 0px; /* Position of H button */
}

.fight-stick .bumper.left.pressed {
    background-position: -369px -123px; /* Position of pressed H button */
}

.fight-stick .bumper.pressed {
    -webkit-filter: invert(0);
}

.fight-stick .bumper {
    background: url(https://imgur.com/Dg2SRLd.png);
}

/* Triggers */

.fight-stick .trigger-button.right {
    position: absolute;
    right: 203px;
    top: -19px;
    float: left;
    background-position: -246px -246px; /* Position of T button */
}

.fight-stick .trigger-button.right.pressed {
    background-position: -246px -369px; /* Position of T button */
}

.fight-stick .trigger-button.left {
    position: absolute;
    right: 42px;
    top: 53px;
    float: left;
    background-position: -369px -246px;
}

.fight-stick .trigger-button.left.pressed {
    background-position: -369px -369px; /* Position of bottom-right button */
}


.fight-stick .trigger-button {
    background: url(https://imgur.com/Dg2SRLd.png); 
}

.fight-stick .trigger-button.pressed {
    transform: translateY(5px);
    -webkit-filter: invert(0);
}

/* L3/R3 */

.fight-stick .quadrant {
    display: none;
}

.fight-stick .fstick {
    display: none;
}

/* Direction buttons */

.fight-stick .face.up {
    width: 123px;
    height: 123px;
    background: #333333;
    border-radius: 100%;
    opacity: 1;
    display: block;
    position:absolute;
    bottom: 17px;
    left: 705px;
}

.fight-stick .face.right {
    width: 123px;
    height: 123px;
    background: #333333;
    border-radius: 100%;
    opacity: 1;
    display: block;
    position: absolute;
    bottom: 231px;
    left: 698px;
}

.fight-stick .face.down {
    width: 123px;
    height: 123px;
    background: #333333;
    border-radius: 100%;
    opacity: 1;
    display: block;
    position: absolute;
    bottom: 322px;
    left: 563px;
}

.fight-stick .face.left {
    width: 123px;
    height: 123px;
    background: #333333;
    border-radius: 100%;
    opacity: 1;
    display: block;
    position: absolute;
    bottom: 338px;
    left: 397px;
}

.fight-stick .face.pressed {
    transform: translateY(5px);
    -webkit-filter: brightness(0%) invert(1);
}
