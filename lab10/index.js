const curtain = document.getElementById("curtain");

curtain && curtain.addEventListener("click", () => {
    curtain.classList.add("up");
}, { once: true });

const lamp = document.getElementById("lamp");
const lampHoverItems = document.querySelectorAll("#lamp .lamp-hover");
const lampSwitchEls = document.querySelectorAll("#lamp .switcher");
lampHoverItems.forEach((item) => {
    let isDown = false;
    item.addEventListener("mousedown", () => {
        lampSwitchEls.forEach((el) => el.classList.add("do"));
        isDown = true;
    });
    document.body.addEventListener("mouseup", () => {
        if(isDown) {
            lampSwitchEls.forEach((el) => el.classList.remove("do"));
            isDown = false;
            lamp.classList.toggle("on");
        }
    })
});