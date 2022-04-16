const mySlider = document.getElementById("my-slider");
const sliderValue = document.getElementById("slider-value");

function slider() {
    valPercent = (mySlider.value / mySlider.max) * 100;
    mySlider.style.background = `linear-gradient(to right, #1f1f20 ${valPercent}%, gray ${valPercent}%)`;
    sliderValue.textContent = mySlider.value;
}
slider();

const mySlider1 = document.getElementById("my-slider1");
const sliderValue1 = document.getElementById("slider-value1");


function slider1() {
    valPercent1 = (mySlider1.value / mySlider1.max) * 100;
    mySlider1.style.background = `linear-gradient(to right, #1f1f20 ${valPercent1}%, gray ${valPercent1}%)`;
    sliderValue1.textContent = mySlider1.value;
}
slider1();